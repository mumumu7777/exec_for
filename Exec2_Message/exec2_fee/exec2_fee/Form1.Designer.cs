﻿namespace exec2_fee
{
	partial class Form1
	{
		/// <summary>
		/// 設計工具所需的變數。
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// 清除任何使用中的資源。
		/// </summary>
		/// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form 設計工具產生的程式碼

		/// <summary>
		/// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
		/// 這個方法的內容。
		/// </summary>
		private void InitializeComponent()
		{
			this.label1 = new System.Windows.Forms.Label();
			this.malebtm = new System.Windows.Forms.RadioButton();
			this.femalebtm = new System.Windows.Forms.RadioButton();
			this.性別 = new System.Windows.Forms.Label();
			this.calc = new System.Windows.Forms.Label();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.ticketfee = new System.Windows.Forms.Label();
			this.REASON = new System.Windows.Forms.Label();
			this.searchbtm = new System.Windows.Forms.Button();
			this.label2 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(64, 29);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(33, 12);
			this.label1.TabIndex = 0;
			this.label1.Text = "label1";
			// 
			// malebtm
			// 
			this.malebtm.AutoSize = true;
			this.malebtm.Location = new System.Drawing.Point(404, 184);
			this.malebtm.Name = "malebtm";
			this.malebtm.Size = new System.Drawing.Size(47, 16);
			this.malebtm.TabIndex = 1;
			this.malebtm.TabStop = true;
			this.malebtm.Text = "男生";
			this.malebtm.UseVisualStyleBackColor = true;
			this.malebtm.CheckedChanged += new System.EventHandler(this.malebtm_CheckedChanged);
			// 
			// femalebtm
			// 
			this.femalebtm.AutoSize = true;
			this.femalebtm.Location = new System.Drawing.Point(404, 232);
			this.femalebtm.Name = "femalebtm";
			this.femalebtm.Size = new System.Drawing.Size(47, 16);
			this.femalebtm.TabIndex = 1;
			this.femalebtm.TabStop = true;
			this.femalebtm.Text = "女生";
			this.femalebtm.UseVisualStyleBackColor = true;
			this.femalebtm.CheckedChanged += new System.EventHandler(this.femalebtm_CheckedChanged);
			// 
			// 性別
			// 
			this.性別.AutoSize = true;
			this.性別.Location = new System.Drawing.Point(413, 124);
			this.性別.Name = "性別";
			this.性別.Size = new System.Drawing.Size(29, 12);
			this.性別.TabIndex = 0;
			this.性別.Text = "性別";
			// 
			// calc
			// 
			this.calc.AutoSize = true;
			this.calc.Location = new System.Drawing.Point(65, 184);
			this.calc.Name = "calc";
			this.calc.Size = new System.Drawing.Size(29, 12);
			this.calc.TabIndex = 0;
			this.calc.Text = "結果";
			// 
			// textBox1
			// 
			this.textBox1.Location = new System.Drawing.Point(109, 65);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(210, 22);
			this.textBox1.TabIndex = 2;
			// 
			// ticketfee
			// 
			this.ticketfee.AutoSize = true;
			this.ticketfee.Location = new System.Drawing.Point(120, 223);
			this.ticketfee.Name = "ticketfee";
			this.ticketfee.Size = new System.Drawing.Size(0, 12);
			this.ticketfee.TabIndex = 0;
			// 
			// REASON
			// 
			this.REASON.AutoSize = true;
			this.REASON.Location = new System.Drawing.Point(63, 259);
			this.REASON.Name = "REASON";
			this.REASON.Size = new System.Drawing.Size(32, 12);
			this.REASON.TabIndex = 0;
			this.REASON.Text = "原因:";
			// 
			// searchbtm
			// 
			this.searchbtm.Location = new System.Drawing.Point(173, 113);
			this.searchbtm.Name = "searchbtm";
			this.searchbtm.Size = new System.Drawing.Size(75, 23);
			this.searchbtm.TabIndex = 3;
			this.searchbtm.Text = "查詢";
			this.searchbtm.UseVisualStyleBackColor = true;
			this.searchbtm.Click += new System.EventHandler(this.searchbtm_Click);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(57, 223);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(44, 12);
			this.label2.TabIndex = 0;
			this.label2.Text = "門票費:";
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(520, 355);
			this.Controls.Add(this.searchbtm);
			this.Controls.Add(this.textBox1);
			this.Controls.Add(this.femalebtm);
			this.Controls.Add(this.malebtm);
			this.Controls.Add(this.性別);
			this.Controls.Add(this.REASON);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.ticketfee);
			this.Controls.Add(this.calc);
			this.Controls.Add(this.label1);
			this.Name = "Form1";
			this.Text = "Form1";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.RadioButton malebtm;
		private System.Windows.Forms.RadioButton femalebtm;
		private System.Windows.Forms.Label 性別;
		private System.Windows.Forms.Label calc;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.Label ticketfee;
		private System.Windows.Forms.Label REASON;
		private System.Windows.Forms.Button searchbtm;
		private System.Windows.Forms.Label label2;
	}
}

