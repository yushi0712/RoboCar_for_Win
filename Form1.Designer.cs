namespace RoboCar {
	partial class Form1 {
		/// <summary>
		/// 必要なデザイナー変数です。
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// 使用中のリソースをすべてクリーンアップします。
		/// </summary>
		/// <param name="disposing">マネージ リソースが破棄される場合 true、破棄されない場合は false です。</param>
		protected override void Dispose(bool disposing) {
			if (disposing && (components != null)) {
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows フォーム デザイナーで生成されたコード

		/// <summary>
		/// デザイナー サポートに必要なメソッドです。このメソッドの内容を
		/// コード エディターで変更しないでください。
		/// </summary>
		private void InitializeComponent() {
			this.btn_Debug1 = new System.Windows.Forms.Button();
			this.txtBox_MotorSpeed = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.txtBox_MotorSpeed_LeftTurn = new System.Windows.Forms.TextBox();
			this.txtBox_MotorSpeed_RightTurn = new System.Windows.Forms.TextBox();
			this.txtBox_LrLevel_LeftTurn = new System.Windows.Forms.TextBox();
			this.txtBox_LrLevel_RightTurn = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.label9 = new System.Windows.Forms.Label();
			this.label10 = new System.Windows.Forms.Label();
			this.btn_Send = new System.Windows.Forms.Button();
			this.listView_Sensor = new System.Windows.Forms.ListView();
			this.column_Axl = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.column_Temp = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.column_Bright = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.column_Prox = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.SuspendLayout();
			// 
			// btn_Debug1
			// 
			this.btn_Debug1.Location = new System.Drawing.Point(158, 311);
			this.btn_Debug1.Name = "btn_Debug1";
			this.btn_Debug1.Size = new System.Drawing.Size(75, 23);
			this.btn_Debug1.TabIndex = 0;
			this.btn_Debug1.Text = "Debug1";
			this.btn_Debug1.UseVisualStyleBackColor = true;
			this.btn_Debug1.Click += new System.EventHandler(this.btn_Debug1_Click);
			// 
			// txtBox_MotorSpeed
			// 
			this.txtBox_MotorSpeed.ImeMode = System.Windows.Forms.ImeMode.Off;
			this.txtBox_MotorSpeed.Location = new System.Drawing.Point(133, 43);
			this.txtBox_MotorSpeed.Name = "txtBox_MotorSpeed";
			this.txtBox_MotorSpeed.Size = new System.Drawing.Size(100, 19);
			this.txtBox_MotorSpeed.TabIndex = 1;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(58, 46);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(69, 12);
			this.label1.TabIndex = 2;
			this.label1.Text = "Motor Speed";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(239, 46);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(55, 12);
			this.label2.TabIndex = 3;
			this.label2.Text = "(40～255)";
			// 
			// txtBox_MotorSpeed_LeftTurn
			// 
			this.txtBox_MotorSpeed_LeftTurn.ImeMode = System.Windows.Forms.ImeMode.Off;
			this.txtBox_MotorSpeed_LeftTurn.Location = new System.Drawing.Point(133, 87);
			this.txtBox_MotorSpeed_LeftTurn.Name = "txtBox_MotorSpeed_LeftTurn";
			this.txtBox_MotorSpeed_LeftTurn.Size = new System.Drawing.Size(100, 19);
			this.txtBox_MotorSpeed_LeftTurn.TabIndex = 4;
			// 
			// txtBox_MotorSpeed_RightTurn
			// 
			this.txtBox_MotorSpeed_RightTurn.ImeMode = System.Windows.Forms.ImeMode.Off;
			this.txtBox_MotorSpeed_RightTurn.Location = new System.Drawing.Point(133, 124);
			this.txtBox_MotorSpeed_RightTurn.Name = "txtBox_MotorSpeed_RightTurn";
			this.txtBox_MotorSpeed_RightTurn.Size = new System.Drawing.Size(100, 19);
			this.txtBox_MotorSpeed_RightTurn.TabIndex = 5;
			// 
			// txtBox_LrLevel_LeftTurn
			// 
			this.txtBox_LrLevel_LeftTurn.ImeMode = System.Windows.Forms.ImeMode.Off;
			this.txtBox_LrLevel_LeftTurn.Location = new System.Drawing.Point(133, 160);
			this.txtBox_LrLevel_LeftTurn.Name = "txtBox_LrLevel_LeftTurn";
			this.txtBox_LrLevel_LeftTurn.Size = new System.Drawing.Size(100, 19);
			this.txtBox_LrLevel_LeftTurn.TabIndex = 6;
			// 
			// txtBox_LrLevel_RightTurn
			// 
			this.txtBox_LrLevel_RightTurn.ImeMode = System.Windows.Forms.ImeMode.Off;
			this.txtBox_LrLevel_RightTurn.Location = new System.Drawing.Point(133, 198);
			this.txtBox_LrLevel_RightTurn.Name = "txtBox_LrLevel_RightTurn";
			this.txtBox_LrLevel_RightTurn.Size = new System.Drawing.Size(100, 19);
			this.txtBox_LrLevel_RightTurn.TabIndex = 6;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(44, 90);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(83, 12);
			this.label3.TabIndex = 2;
			this.label3.Text = "LeftTurn Speed";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(37, 127);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(90, 12);
			this.label4.TabIndex = 7;
			this.label4.Text = "RightTurn Speed";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(30, 163);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(97, 12);
			this.label5.TabIndex = 8;
			this.label5.Text = "L/R Level(L Turn)";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(30, 201);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(99, 12);
			this.label6.TabIndex = 9;
			this.label6.Text = "L/R Level(R Turn)";
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(239, 90);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(55, 12);
			this.label7.TabIndex = 10;
			this.label7.Text = "(40～255)";
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Location = new System.Drawing.Point(239, 127);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(55, 12);
			this.label8.TabIndex = 11;
			this.label8.Text = "(40～255)";
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Location = new System.Drawing.Point(239, 163);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(49, 12);
			this.label9.TabIndex = 12;
			this.label9.Text = "(0～255)";
			// 
			// label10
			// 
			this.label10.AutoSize = true;
			this.label10.Location = new System.Drawing.Point(239, 201);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(49, 12);
			this.label10.TabIndex = 13;
			this.label10.Text = "(0～255)";
			// 
			// btn_Send
			// 
			this.btn_Send.Location = new System.Drawing.Point(133, 242);
			this.btn_Send.Name = "btn_Send";
			this.btn_Send.Size = new System.Drawing.Size(123, 49);
			this.btn_Send.TabIndex = 14;
			this.btn_Send.Text = "Send";
			this.btn_Send.UseVisualStyleBackColor = true;
			this.btn_Send.Click += new System.EventHandler(this.btn_Send_Click);
			// 
			// listView_Sensor
			// 
			this.listView_Sensor.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.column_Axl,
            this.column_Temp,
            this.column_Bright,
            this.column_Prox});
			this.listView_Sensor.GridLines = true;
			this.listView_Sensor.Location = new System.Drawing.Point(323, 33);
			this.listView_Sensor.Name = "listView_Sensor";
			this.listView_Sensor.Size = new System.Drawing.Size(359, 287);
			this.listView_Sensor.TabIndex = 15;
			this.listView_Sensor.UseCompatibleStateImageBehavior = false;
			this.listView_Sensor.View = System.Windows.Forms.View.Details;
			// 
			// column_Axl
			// 
			this.column_Axl.Text = "衝撃";
			// 
			// column_Temp
			// 
			this.column_Temp.Text = "温度";
			this.column_Temp.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			// 
			// column_Bright
			// 
			this.column_Bright.Text = "照度";
			this.column_Bright.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			// 
			// column_Prox
			// 
			this.column_Prox.Text = "近接";
			this.column_Prox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(772, 365);
			this.Controls.Add(this.listView_Sensor);
			this.Controls.Add(this.btn_Send);
			this.Controls.Add(this.label10);
			this.Controls.Add(this.label9);
			this.Controls.Add(this.label8);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.txtBox_LrLevel_RightTurn);
			this.Controls.Add(this.txtBox_LrLevel_LeftTurn);
			this.Controls.Add(this.txtBox_MotorSpeed_RightTurn);
			this.Controls.Add(this.txtBox_MotorSpeed_LeftTurn);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.txtBox_MotorSpeed);
			this.Controls.Add(this.btn_Debug1);
			this.Name = "Form1";
			this.Text = "Form1";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button btn_Debug1;
		private System.Windows.Forms.TextBox txtBox_MotorSpeed;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox txtBox_MotorSpeed_LeftTurn;
		private System.Windows.Forms.TextBox txtBox_MotorSpeed_RightTurn;
		private System.Windows.Forms.TextBox txtBox_LrLevel_LeftTurn;
		private System.Windows.Forms.TextBox txtBox_LrLevel_RightTurn;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.Button btn_Send;
		private System.Windows.Forms.ListView listView_Sensor;
		private System.Windows.Forms.ColumnHeader column_Axl;
		private System.Windows.Forms.ColumnHeader column_Temp;
		private System.Windows.Forms.ColumnHeader column_Bright;
		private System.Windows.Forms.ColumnHeader column_Prox;
	}
}

