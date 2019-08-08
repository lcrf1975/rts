namespace KeyGen
{
    partial class Form_Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Main));
            this.label_Exp_Date = new System.Windows.Forms.Label();
            this.dateTimePicker_Date = new System.Windows.Forms.DateTimePicker();
            this.label_Key = new System.Windows.Forms.Label();
            this.label_Key_Value = new System.Windows.Forms.Label();
            this.button_Generate = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label_Exp_Date
            // 
            this.label_Exp_Date.AutoSize = true;
            this.label_Exp_Date.Location = new System.Drawing.Point(9, 9);
            this.label_Exp_Date.Name = "label_Exp_Date";
            this.label_Exp_Date.Size = new System.Drawing.Size(82, 13);
            this.label_Exp_Date.TabIndex = 0;
            this.label_Exp_Date.Text = "Expiration Date:";
            // 
            // dateTimePicker_Date
            // 
            this.dateTimePicker_Date.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker_Date.Location = new System.Drawing.Point(12, 25);
            this.dateTimePicker_Date.MaxDate = new System.DateTime(2099, 12, 31, 0, 0, 0, 0);
            this.dateTimePicker_Date.MinDate = new System.DateTime(1999, 1, 1, 0, 0, 0, 0);
            this.dateTimePicker_Date.Name = "dateTimePicker_Date";
            this.dateTimePicker_Date.Size = new System.Drawing.Size(117, 20);
            this.dateTimePicker_Date.TabIndex = 6;
            // 
            // label_Key
            // 
            this.label_Key.AutoSize = true;
            this.label_Key.Location = new System.Drawing.Point(132, 9);
            this.label_Key.Name = "label_Key";
            this.label_Key.Size = new System.Drawing.Size(28, 13);
            this.label_Key.TabIndex = 7;
            this.label_Key.Text = "Key:";
            // 
            // label_Key_Value
            // 
            this.label_Key_Value.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label_Key_Value.Location = new System.Drawing.Point(135, 25);
            this.label_Key_Value.Name = "label_Key_Value";
            this.label_Key_Value.Size = new System.Drawing.Size(477, 20);
            this.label_Key_Value.TabIndex = 8;
            this.label_Key_Value.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // button_Generate
            // 
            this.button_Generate.Location = new System.Drawing.Point(12, 51);
            this.button_Generate.Name = "button_Generate";
            this.button_Generate.Size = new System.Drawing.Size(75, 23);
            this.button_Generate.TabIndex = 9;
            this.button_Generate.Text = "Generate";
            this.button_Generate.UseVisualStyleBackColor = true;
            this.button_Generate.Click += new System.EventHandler(this.button_Generate_Click);
            // 
            // Form_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 87);
            this.Controls.Add(this.button_Generate);
            this.Controls.Add(this.label_Key_Value);
            this.Controls.Add(this.label_Key);
            this.Controls.Add(this.dateTimePicker_Date);
            this.Controls.Add(this.label_Exp_Date);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form_Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Key Generator";
            this.Shown += new System.EventHandler(this.Form_Main_Shown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_Exp_Date;
        private System.Windows.Forms.DateTimePicker dateTimePicker_Date;
        private System.Windows.Forms.Label label_Key;
        private System.Windows.Forms.Label label_Key_Value;
        private System.Windows.Forms.Button button_Generate;
    }
}

