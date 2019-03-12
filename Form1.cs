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
using System.Runtime.Serialization;

namespace RoboCar {
	public partial class Form1 : Form 
	{
		// HIVE MQ の brokerを指定して、クライアントを作成
		System.Security.Cryptography.X509Certificates.X509Certificate caCert = new System.Security.Cryptography.X509Certificates.X509Certificate();
		System.Security.Cryptography.X509Certificates.X509Certificate caClientCert = new System.Security.Cryptography.X509Certificates.X509Certificate();
		MqttSslProtocols Ssl = new MqttSslProtocols();
		MqttClient mqttClient = null;
		string		ClientId = "";
	
		[DataContract]
		public class JsonItem {
			[DataMember(Name = "name")]
			public string Name { get; set; }

			[DataMember(Name = "Id")]
			public string Id { get; set; }
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

		}

		private void OnRecieveMqttTopic(object sender, MqttMsgPublishEventArgs e)
		{
			Console.WriteLine(e.Topic);
			Console.WriteLine(Encoding.UTF8.GetString(e.Message));
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
	}
}
