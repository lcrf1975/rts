namespace Geocoder
{
    partial class Form_Options
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label_Bing_API_Key = new System.Windows.Forms.Label();
            this.textBox_Bing_API_Key = new System.Windows.Forms.TextBox();
            this.textBox_Google_API_Key = new System.Windows.Forms.TextBox();
            this.label_Google_API_Key = new System.Windows.Forms.Label();
            this.button_Save = new System.Windows.Forms.Button();
            this.label_License_Key = new System.Windows.Forms.Label();
            this.textBox_License_Key = new System.Windows.Forms.TextBox();
            this.label_Exp_Date = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label_Bing_API_Key
            // 
            this.label_Bing_API_Key.AutoSize = true;
            this.label_Bing_API_Key.Location = new System.Drawing.Point(9, 48);
            this.label_Bing_API_Key.Name = "label_Bing_API_Key";
            this.label_Bing_API_Key.Size = new System.Drawing.Size(72, 13);
            this.label_Bing_API_Key.TabIndex = 3;
            this.label_Bing_API_Key.Text = "Bing API Key:";
            // 
            // textBox_Bing_API_Key
            // 
            this.textBox_Bing_API_Key.Location = new System.Drawing.Point(12, 64);
            this.textBox_Bing_API_Key.Name = "textBox_Bing_API_Key";
            this.textBox_Bing_API_Key.Size = new System.Drawing.Size(600, 20);
            this.textBox_Bing_API_Key.TabIndex = 4;
            // 
            // textBox_Google_API_Key
            // 
            this.textBox_Google_API_Key.Location = new System.Drawing.Point(12, 103);
            this.textBox_Google_API_Key.Name = "textBox_Google_API_Key";
            this.textBox_Google_API_Key.Size = new System.Drawing.Size(600, 20);
            this.textBox_Google_API_Key.TabIndex = 6;
            // 
            // label_Google_API_Key
            // 
            this.label_Google_API_Key.AutoSize = true;
            this.label_Google_API_Key.Location = new System.Drawing.Point(9, 87);
            this.label_Google_API_Key.Name = "label_Google_API_Key";
            this.label_Google_API_Key.Size = new System.Drawing.Size(85, 13);
            this.label_Google_API_Key.TabIndex = 5;
            this.label_Google_API_Key.Text = "Google API Key:";
            // 
            // button_Save
            // 
            this.button_Save.Location = new System.Drawing.Point(12, 129);
            this.button_Save.Name = "button_Save";
            this.button_Save.Size = new System.Drawing.Size(75, 23);
            this.button_Save.TabIndex = 7;
            this.button_Save.Text = "SAVE";
            this.button_Save.UseVisualStyleBackColor = true;
            this.button_Save.Click += new System.EventHandler(this.button_Save_Click);
            // 
            // label_License_Key
            // 
            this.label_License_Key.AutoSize = true;
            this.label_License_Key.Location = new System.Drawing.Point(9, 9);
            this.label_License_Key.Name = "label_License_Key";
            this.label_License_Key.Size = new System.Drawing.Size(68, 13);
            this.label_License_Key.TabIndex = 0;
            this.label_License_Key.Text = "License Key:";
            // 
            // textBox_License_Key
            // 
            this.textBox_License_Key.BackColor = System.Drawing.SystemColors.Info;
            this.textBox_License_Key.Location = new System.Drawing.Point(12, 25);
            this.textBox_License_Key.Name = "textBox_License_Key";
            this.textBox_License_Key.Size = new System.Drawing.Size(504, 20);
            this.textBox_License_Key.TabIndex = 1;
            this.textBox_License_Key.TextChanged += new System.EventHandler(this.textBox_License_Key_TextChanged);
            // 
            // label_Exp_Date
            // 
            this.label_Exp_Date.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label_Exp_Date.Location = new System.Drawing.Point(522, 25);
            this.label_Exp_Date.Name = "label_Exp_Date";
            this.label_Exp_Date.Size = new System.Drawing.Size(90, 20);
            this.label_Exp_Date.TabIndex = 2;
            this.label_Exp_Date.Text = "YYYY/MM/DD";
            this.label_Exp_Date.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form_Options
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 165);
            this.Controls.Add(this.label_Exp_Date);
            this.Controls.Add(this.textBox_License_Key);
            this.Controls.Add(this.label_License_Key);
            this.Controls.Add(this.button_Save);
            this.Controls.Add(this.textBox_Google_API_Key);
            this.Controls.Add(this.label_Google_API_Key);
            this.Controls.Add(this.textBox_Bing_API_Key);
            this.Controls.Add(this.label_Bing_API_Key);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form_Options";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Options";
            this.Shown += new System.EventHandler(this.Form_Options_Shown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_Bing_API_Key;
        private System.Windows.Forms.TextBox textBox_Bing_API_Key;
        private System.Windows.Forms.TextBox textBox_Google_API_Key;
        private System.Windows.Forms.Label label_Google_API_Key;
        private System.Windows.Forms.Button button_Save;
        private System.Windows.Forms.Label label_License_Key;
        private System.Windows.Forms.TextBox textBox_License_Key;
        private System.Windows.Forms.Label label_Exp_Date;
    }
}