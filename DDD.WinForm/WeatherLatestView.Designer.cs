﻿namespace DDD.WinForm
{
    partial class WeatherLatestView
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.DataDateLabel = new System.Windows.Forms.Label();
            this.ConditionLabel = new System.Windows.Forms.Label();
            this.TemperatureLabel = new System.Windows.Forms.Label();
            this.AreaIdTextBox = new System.Windows.Forms.TextBox();
            this.LatestBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(47, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "地域";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(47, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "日時";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(47, 98);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 12);
            this.label3.TabIndex = 2;
            this.label3.Text = "状態";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(47, 128);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 12);
            this.label4.TabIndex = 3;
            this.label4.Text = "温度";
            // 
            // DataDateLabel
            // 
            this.DataDateLabel.AutoSize = true;
            this.DataDateLabel.Location = new System.Drawing.Point(105, 67);
            this.DataDateLabel.Name = "DataDateLabel";
            this.DataDateLabel.Size = new System.Drawing.Size(35, 12);
            this.DataDateLabel.TabIndex = 4;
            this.DataDateLabel.Text = "label5";
            // 
            // ConditionLabel
            // 
            this.ConditionLabel.AutoSize = true;
            this.ConditionLabel.Location = new System.Drawing.Point(105, 98);
            this.ConditionLabel.Name = "ConditionLabel";
            this.ConditionLabel.Size = new System.Drawing.Size(35, 12);
            this.ConditionLabel.TabIndex = 5;
            this.ConditionLabel.Text = "label6";
            // 
            // TemperatureLabel
            // 
            this.TemperatureLabel.AutoSize = true;
            this.TemperatureLabel.Location = new System.Drawing.Point(105, 128);
            this.TemperatureLabel.Name = "TemperatureLabel";
            this.TemperatureLabel.Size = new System.Drawing.Size(35, 12);
            this.TemperatureLabel.TabIndex = 6;
            this.TemperatureLabel.Text = "label7";
            // 
            // AreaIdTextBox
            // 
            this.AreaIdTextBox.Location = new System.Drawing.Point(95, 23);
            this.AreaIdTextBox.Name = "AreaIdTextBox";
            this.AreaIdTextBox.Size = new System.Drawing.Size(100, 19);
            this.AreaIdTextBox.TabIndex = 7;
            // 
            // LatestBtn
            // 
            this.LatestBtn.Location = new System.Drawing.Point(201, 21);
            this.LatestBtn.Name = "LatestBtn";
            this.LatestBtn.Size = new System.Drawing.Size(75, 23);
            this.LatestBtn.TabIndex = 8;
            this.LatestBtn.Text = "直近値";
            this.LatestBtn.UseVisualStyleBackColor = true;
            this.LatestBtn.Click += new System.EventHandler(this.LatestBtn_Click);
            // 
            // WeatherLatestView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(334, 261);
            this.Controls.Add(this.LatestBtn);
            this.Controls.Add(this.AreaIdTextBox);
            this.Controls.Add(this.TemperatureLabel);
            this.Controls.Add(this.ConditionLabel);
            this.Controls.Add(this.DataDateLabel);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "WeatherLatestView";
            this.Text = "WeatherLatestViewBad2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label DataDateLabel;
        private System.Windows.Forms.Label ConditionLabel;
        private System.Windows.Forms.Label TemperatureLabel;
        private System.Windows.Forms.TextBox AreaIdTextBox;
        private System.Windows.Forms.Button LatestBtn;
    }
}

