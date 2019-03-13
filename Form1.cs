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
using System.Threading;

namespace RoboCar {
	public partial class RoboCar : Form 
	{
		// HIVE MQ の brokerを指定して、クライアントを作成
		System.Security.Cryptography.X509Certificates.X509Certificate caCert = new System.Security.Cryptography.X509Certificates.X509Certificate();
		System.Security.Cryptography.X509Certificates.X509Certificate caClientCert = new System.Security.Cryptography.X509Certificates.X509Certificate();
		MqttSslProtocols Ssl = new MqttSslProtocols();
		MqttClient mqttClient = null;
		string		ClientId = "";
		string mqttTopic_Sensor = "KM/Sensor";
		string mqttTopic_Command= "KM/Command";
		string mqttTopic_Query = "KM/Query";
		string mqttTopic_Param = "KM/Param";

		public class Json_Sensor {
			public float AxlDiff { get; set; }
			public float Temp { get; set; }
			public float Bright { get; set; }
			public float Prox { get; set; }
			public float P_Score { get; set; }
		}
		public class Json_Param{
			public int MtSpd { get; set; }
			public int MtSpd_LT { get; set; }
			public int MtSpd_RT { get; set; }
			public int MtLv_LT { get; set; }
			public int MtLv_RT { get; set; }
		}

		public RoboCar() {
			InitializeComponent();

			mqttClient = new MqttClient("m16.cloudmqtt.com", 17555, false, caCert, Ssl);

			// メッセージを受信した際に発生するイベント
			mqttClient.MqttMsgPublishReceived += OnRecieveMqttTopic;

			// 受信するメッセージのトピック、QoSレベルを指定して、メッセージ受信待ち状態に入る
			mqttClient.Subscribe(new string[] { mqttTopic_Sensor }, new byte[] { 2 });
			mqttClient.Subscribe(new string[] { mqttTopic_Param}, new byte[] { 2 });


			ClientId = Guid.NewGuid().ToString();
			mqttClient.Connect(ClientId, "vsscjrry", "kurgC_M_VZmF");
		}


		private void AddItem_ThreadSafe(ListViewItem lvi) 
		{
			listView_Sensor.Items.Add(lvi);
			listView_Sensor.EnsureVisible(listView_Sensor.Items.Count - 1);
		}

		private void UpdateParam_ThreadSafe(Json_Param Param) 
		{
			txtBox_MotorSpeed.Text = Param.MtSpd.ToString();
			txtBox_MotorSpeed_LeftTurn.Text = Param.MtSpd_LT.ToString();
			txtBox_MotorSpeed_RightTurn.Text = Param.MtSpd_RT.ToString();
			txtBox_LrLevel_LeftTurn.Text = Param.MtLv_LT.ToString();
			txtBox_LrLevel_RightTurn.Text = Param.MtLv_RT.ToString();
		}

		delegate void delegate1(ListViewItem lvi);
		delegate void delegate2(Json_Param Param);
		private void OnRecieveMqttTopic(object sender, MqttMsgPublishEventArgs e)
		{
			if (e.Topic == mqttTopic_Sensor) {
				var serializer = new DataContractJsonSerializer(typeof(Json_Sensor));
				using (var ms = new MemoryStream(e.Message)) {
					ms.Position = 0;
					var deserialized = (Json_Sensor)serializer.ReadObject(ms);

					
					ListViewItem lvi = new ListViewItem(DateTime.Now.ToString(@"HH\:mm\:ss"));
					lvi.SubItems.Add(deserialized.AxlDiff.ToString("F2"));
					lvi.SubItems.Add(deserialized.Temp.ToString("F2"));
					lvi.SubItems.Add(deserialized.Bright.ToString("F2"));
					lvi.SubItems.Add(deserialized.Prox.ToString("F2"));
					lvi.SubItems.Add(deserialized.P_Score.ToString("F2"));

					Invoke(new delegate1(AddItem_ThreadSafe), lvi);
				}
			}
			else if (e.Topic == mqttTopic_Param) {
				var serializer = new DataContractJsonSerializer(typeof(Json_Param));
				using (var ms = new MemoryStream(e.Message)) {
					ms.Position = 0;
					var deserialized = (Json_Param)serializer.ReadObject(ms);
					Console.WriteLine("MtSpd : {0}", deserialized.MtSpd);
					Invoke(new delegate2(UpdateParam_ThreadSafe), deserialized);
				}
			}
		}

		private void Form1_FormClosing(object sender, FormClosingEventArgs e) {
			mqttClient.Disconnect();
			Thread.Sleep(500);
		}

		//===== "Send motor param."ボタン押下 =====
		private void btn_Send_Click(object sender, EventArgs e) {
			string Payload;
			Payload = "{";
			Payload += string.Format("\"MotorSpeed\":{0}", int.Parse(txtBox_MotorSpeed.Text));
			Payload += string.Format(",\"MotorSpeedLR\":[{0},{1},{2},{3}]",
								int.Parse(txtBox_MotorSpeed_LeftTurn.Text), int.Parse(txtBox_MotorSpeed_RightTurn.Text),
								int.Parse(txtBox_LrLevel_LeftTurn.Text), int.Parse(txtBox_LrLevel_RightTurn.Text));
			Payload += "}";
			mqttClient.Publish(mqttTopic_Command, Encoding.UTF8.GetBytes(Payload), 0, false);
		}

		//===== "Clear"ボタン押下 =====
		private void btn_ClearList_Click(object sender, EventArgs e) 
		{
			listView_Sensor.Items.Clear();

		}

		//===== "Get motor param."ボタン押下 =====
		private void btn_GetMotorParam_Click(object sender, EventArgs e) 
		{
			string Payload = "{\"Id\":\"Param\"}";
			mqttClient.Publish(mqttTopic_Query, Encoding.UTF8.GetBytes(Payload), 0, false);
		}

		//===== "Debug"ボタン押下 =====
		private void btn_Debug1_Click(object sender, EventArgs e) {
		}
	}
}
