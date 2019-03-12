using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using uPLibrary.Networking.M2Mqtt;
using uPLibrary.Networking.M2Mqtt.Messages;
using System.Runtime.Serialization.Json;
using System.IO;

namespace RoboCar {
	public partial class Form1 : Form 
	{
		// HIVE MQ の brokerを指定して、クライアントを作成
		System.Security.Cryptography.X509Certificates.X509Certificate caCert = new System.Security.Cryptography.X509Certificates.X509Certificate();
		System.Security.Cryptography.X509Certificates.X509Certificate caClientCert = new System.Security.Cryptography.X509Certificates.X509Certificate();
		MqttSslProtocols Ssl = new MqttSslProtocols();
		MqttClient mqttClient = null;
		string		ClientId = "";

		public class Json_Sensor {
			public float AxlDiff { get; set; }
			public float Temp { get; set; }
			public float Bright { get; set; }
			public float Prox { get; set; }
			public float P_Score { get; set; }
		}

		public Form1() {
			InitializeComponent();

			mqttClient = new MqttClient("m16.cloudmqtt.com", 17555, false, caCert, Ssl);

			// メッセージを受信した際に発生するイベント
			mqttClient.MqttMsgPublishReceived += OnRecieveMqttTopic;

			// 受信するメッセージのトピック、QoSレベルを指定して、メッセージ受信待ち状態に入る
			mqttClient.Subscribe(new string[] { "KM/Sensor" }, new byte[] { 2 });


			ClientId = Guid.NewGuid().ToString();
			mqttClient.Connect(ClientId, "vsscjrry", "kurgC_M_VZmF");
		}

		private void btn_Debug1_Click(object sender, EventArgs e) 
		{
			string json = "{\"AxlDiff\":0.21,\"Name\":\"Kato Jun\"}";
			var serializer = new DataContractJsonSerializer(typeof(Json_Sensor));

			using (var ms = new MemoryStream(Encoding.UTF8.GetBytes(json))) {
				ms.Position = 0;
				var deserialized = (Json_Sensor)serializer.ReadObject(ms);
				Console.WriteLine("AxlDiff : {0}", deserialized.AxlDiff);  // 31		
			}
		}

		private void AddItem_ThreadSafe(ListViewItem lvi)
		{
			listView_Sensor.Items.Add(lvi);
			listView_Sensor.EnsureVisible(listView_Sensor.Items.Count-1);
		}

		delegate void delegate1(ListViewItem lvi);
		private void OnRecieveMqttTopic(object sender, MqttMsgPublishEventArgs e)
		{
			if(e.Topic == "KM/Sensor") {
				var serializer = new DataContractJsonSerializer(typeof(Json_Sensor));
				using (var ms = new MemoryStream(e.Message)) {
					ms.Position = 0;
					var deserialized = (Json_Sensor)serializer.ReadObject(ms);
					Console.WriteLine("AxlDiff : {0}", deserialized.AxlDiff);  // 31		

					ListViewItem lvi = new ListViewItem(deserialized.AxlDiff.ToString("F2"));
					lvi.SubItems.Add(deserialized.Temp.ToString("F2"));
					lvi.SubItems.Add(deserialized.Bright.ToString("F2"));
					lvi.SubItems.Add(deserialized.Prox.ToString("F2"));
					lvi.SubItems.Add(deserialized.P_Score.ToString("F2"));

					Invoke(new delegate1(AddItem_ThreadSafe), lvi);
				}
			}
		}

		private void btn_Send_Click(object sender, EventArgs e) 
		{
			string Payload;
			Payload = "{";
			Payload += string.Format("\"MotorSpeed\":{0}", int.Parse(txtBox_MotorSpeed.Text));
			Payload += string.Format(",\"MotorSpeedLR\":[{0},{1},{2},{3}]",
								int.Parse(txtBox_MotorSpeed_LeftTurn.Text), int.Parse(txtBox_MotorSpeed_RightTurn.Text),
								int.Parse(txtBox_LrLevel_LeftTurn.Text), int.Parse(txtBox_LrLevel_RightTurn.Text));
			Payload += "}";
			MessageBox.Show(Payload);
			mqttClient.Publish("KM/Command", Encoding.UTF8.GetBytes(Payload), 0, false);
		}

		private void Form1_FormClosing(object sender, FormClosingEventArgs e) {
			mqttClient.Disconnect();
		}

		private void btn_ClearList_Click(object sender, EventArgs e) 
		{
			listView_Sensor.Items.Clear();

		}
	}
}
