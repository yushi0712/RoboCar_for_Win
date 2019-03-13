namespace RoboCar {
	partial class RoboCar {
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
			this.btn_ClearList = new System.Windows.Forms.Button();
			this.column_Time = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.column_P_Score = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.btn_GetMotorParam = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// btn_Debug1
			// 
			this.btn_Debug1.Location = new System.Drawing.Point(688, 139);
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
			this.txtBox_MotorSpeed.Location = new System.Drawing.Point(122, 43);
			this.txtBox_MotorSpeed.Name = "txtBox_MotorSpeed";
			this.txtBox_MotorSpeed.Size = new System.Drawing.Size(100, 19);
			this.txtBox_MotorSpeed.TabIndex = 1;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(47, 46);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(69, 12);
			this.label1.TabIndex = 2;
			this.label1.Text = "Motor Speed";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(228, 46);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(55, 12);
			this.label2.TabIndex = 3;
			this.label2.Text = "(40～255)";
			// 
			// txtBox_MotorSpeed_LeftTurn
			// 
			this.txtBox_MotorSpeed_LeftTurn.ImeMode = System.Windows.Forms.ImeMode.Off;
			this.txtBox_MotorSpeed_LeftTurn.Location = new System.Drawing.Point(122, 81);
			this.txtBox_MotorSpeed_LeftTurn.Name = "txtBox_MotorSpeed_LeftTurn";
			this.txtBox_MotorSpeed_LeftTurn.Size = new System.Drawing.Size(100, 19);
			this.txtBox_MotorSpeed_LeftTurn.TabIndex = 4;
			// 
			// txtBox_MotorSpeed_RightTurn
			// 
			this.txtBox_MotorSpeed_RightTurn.ImeMode = System.Windows.Forms.ImeMode.Off;
			this.txtBox_MotorSpeed_RightTurn.Location = new System.Drawing.Point(122, 119);
			this.txtBox_MotorSpeed_RightTurn.Name = "txtBox_MotorSpeed_RightTurn";
			this.txtBox_MotorSpeed_RightTurn.Size = new System.Drawing.Size(100, 19);
			this.txtBox_MotorSpeed_RightTurn.TabIndex = 5;
			// 
			// txtBox_LrLevel_LeftTurn
			// 
			this.txtBox_LrLevel_LeftTurn.ImeMode = System.Windows.Forms.ImeMode.Off;
			this.txtBox_LrLevel_LeftTurn.Location = new System.Drawing.Point(122, 157);
			this.txtBox_LrLevel_LeftTurn.Name = "txtBox_LrLevel_LeftTurn";
			this.txtBox_LrLevel_LeftTurn.Size = new System.Drawing.Size(100, 19);
			this.txtBox_LrLevel_LeftTurn.TabIndex = 6;
			// 
			// txtBox_LrLevel_RightTurn
			// 
			this.txtBox_LrLevel_RightTurn.ImeMode = System.Windows.Forms.ImeMode.Off;
			this.txtBox_LrLevel_RightTurn.Location = new System.Drawing.Point(122, 195);
			this.txtBox_LrLevel_RightTurn.Name = "txtBox_LrLevel_RightTurn";
			this.txtBox_LrLevel_RightTurn.Size = new System.Drawing.Size(100, 19);
			this.txtBox_LrLevel_RightTurn.TabIndex = 6;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(33, 84);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(83, 12);
			this.label3.TabIndex = 2;
			this.label3.Text = "LeftTurn Speed";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(26, 122);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(90, 12);
			this.label4.TabIndex = 7;
			this.label4.Text = "RightTurn Speed";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(19, 160);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(97, 12);
			this.label5.TabIndex = 8;
			this.label5.Text = "L/R Level(L Turn)";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(19, 198);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(99, 12);
			this.label6.TabIndex = 9;
			this.label6.Text = "L/R Level(R Turn)";
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(228, 84);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(55, 12);
			this.label7.TabIndex = 10;
			this.label7.Text = "(40～255)";
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Location = new System.Drawing.Point(228, 122);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(55, 12);
			this.label8.TabIndex = 11;
			this.label8.Text = "(40～255)";
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Location = new System.Drawing.Point(228, 160);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(49, 12);
			this.label9.TabIndex = 12;
			this.label9.Text = "(0～255)";
			// 
			// label10
			// 
			this.label10.AutoSize = true;
			this.label10.Location = new System.Drawing.Point(228, 198);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(49, 12);
			this.label10.TabIndex = 13;
			this.label10.Text = "(0～255)";
			// 
			// btn_Send
			// 
			this.btn_Send.Location = new System.Drawing.Point(148, 233);
			this.btn_Send.Name = "btn_Send";
			this.btn_Send.Size = new System.Drawing.Size(121, 33);
			this.btn_Send.TabIndex = 14;
			this.btn_Send.Text = "Send motor param.";
			this.btn_Send.UseVisualStyleBackColor = true;
			this.btn_Send.Click += new System.EventHandler(this.btn_Send_Click);
			// 
			// listView_Sensor
			// 
			this.listView_Sensor.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.column_Time,
            this.column_Axl,
            this.column_Temp,
            this.column_Bright,
            this.column_Prox,
            this.column_P_Score});
			this.listView_Sensor.GridLines = true;
			this.listView_Sensor.Location = new System.Drawing.Point(300, 33);
			this.listView_Sensor.Name = "listView_Sensor";
			this.listView_Sensor.Size = new System.Drawing.Size(382, 307);
			this.listView_Sensor.TabIndex = 15;
			this.listView_Sensor.UseCompatibleStateImageBehavior = false;
			this.listView_Sensor.View = System.Windows.Forms.View.Details;
			// 
			// column_Axl
			// 
			this.column_Axl.Text = "衝撃";
			this.column_Axl.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// column_Temp
			// 
			this.column_Temp.Text = "温度";
			this.column_Temp.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// column_Bright
			// 
			this.column_Bright.Text = "照度";
			this.column_Bright.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// column_Prox
			// 
			this.column_Prox.Text = "近接";
			this.column_Prox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// btn_ClearList
			// 
			this.btn_ClearList.Location = new System.Drawing.Point(688, 33);
			this.btn_ClearList.Name = "btn_ClearList";
			this.btn_ClearList.Size = new System.Drawing.Size(97, 27);
			this.btn_ClearList.TabIndex = 16;
			this.btn_ClearList.Text = "Clear";
			this.btn_ClearList.UseVisualStyleBackColor = true;
			this.btn_ClearList.Click += new System.EventHandler(this.btn_ClearList_Click);
			// 
			// column_Time
			// 
			this.column_Time.Text = "";
			// 
			// column_P_Score
			// 
			this.column_P_Score.Text = "P-Score";
			// 
			// btn_GetMotorParam
			// 
			this.btn_GetMotorParam.Location = new System.Drawing.Point(21, 233);
			this.btn_GetMotorParam.Name = "btn_GetMotorParam";
			this.btn_GetMotorParam.Size = new System.Drawing.Size(121, 33);
			this.btn_GetMotorParam.TabIndex = 17;
			this.btn_GetMotorParam.Text = "Get motor param.";
			this.btn_GetMotorParam.UseVisualStyleBackColor = true;
			this.btn_GetMotorParam.Click += new System.EventHandler(this.btn_GetMotorParam_Click);
			// 
			// RoboCar
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(797, 365);
			this.Controls.Add(this.btn_GetMotorParam);
			this.Controls.Add(this.btn_ClearList);
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
			this.Name = "RoboCar";
			this.Text = "RoboCar";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
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
		private System.Windows.Forms.Button btn_ClearList;
		private System.Windows.Forms.ColumnHeader column_Time;
		private System.Windows.Forms.ColumnHeader column_P_Score;
		private System.Windows.Forms.Button btn_GetMotorParam;
	}
}

