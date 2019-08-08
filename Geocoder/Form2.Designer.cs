namespace Geocoder
{
    partial class Form_Map
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Map));
            this.webBrowser_Map = new System.Windows.Forms.WebBrowser();
            this.panel_WAIT = new System.Windows.Forms.Panel();
            this.pictureBox_WAIT = new System.Windows.Forms.PictureBox();
            this.label_ADDRESS = new System.Windows.Forms.Label();
            this.checkBox_SAT_VIEW = new System.Windows.Forms.CheckBox();
            this.comboBox_ZOOM = new System.Windows.Forms.ComboBox();
            this.panel_WAIT.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_WAIT)).BeginInit();
            this.SuspendLayout();
            // 
            // webBrowser_Map
            // 
            this.webBrowser_Map.AllowWebBrowserDrop = false;
            this.webBrowser_Map.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webBrowser_Map.IsWebBrowserContextMenuEnabled = false;
            this.webBrowser_Map.Location = new System.Drawing.Point(0, 0);
            this.webBrowser_Map.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser_Map.Name = "webBrowser_Map";
            this.webBrowser_Map.ScriptErrorsSuppressed = true;
            this.webBrowser_Map.ScrollBarsEnabled = false;
            this.webBrowser_Map.Size = new System.Drawing.Size(660, 666);
            this.webBrowser_Map.TabIndex = 0;
            this.webBrowser_Map.WebBrowserShortcutsEnabled = false;
            this.webBrowser_Map.Navigated += new System.Windows.Forms.WebBrowserNavigatedEventHandler(this.webBrowser_Map_Navigated);
            // 
            // panel_WAIT
            // 
            this.panel_WAIT.BackColor = System.Drawing.SystemColors.Control;
            this.panel_WAIT.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_WAIT.Controls.Add(this.pictureBox_WAIT);
            this.panel_WAIT.Location = new System.Drawing.Point(264, 267);
            this.panel_WAIT.Name = "panel_WAIT";
            this.panel_WAIT.Size = new System.Drawing.Size(132, 132);
            this.panel_WAIT.TabIndex = 1;
            // 
            // pictureBox_WAIT
            // 
            this.pictureBox_WAIT.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox_WAIT.Image")));
            this.pictureBox_WAIT.Location = new System.Drawing.Point(1, 1);
            this.pictureBox_WAIT.Name = "pictureBox_WAIT";
            this.pictureBox_WAIT.Size = new System.Drawing.Size(128, 128);
            this.pictureBox_WAIT.TabIndex = 0;
            this.pictureBox_WAIT.TabStop = false;
            // 
            // label_ADDRESS
            // 
            this.label_ADDRESS.BackColor = System.Drawing.SystemColors.Control;
            this.label_ADDRESS.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label_ADDRESS.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_ADDRESS.Location = new System.Drawing.Point(10, 15);
            this.label_ADDRESS.Name = "label_ADDRESS";
            this.label_ADDRESS.Size = new System.Drawing.Size(640, 23);
            this.label_ADDRESS.TabIndex = 2;
            this.label_ADDRESS.Text = "ADDRESS";
            this.label_ADDRESS.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // checkBox_SAT_VIEW
            // 
            this.checkBox_SAT_VIEW.Appearance = System.Windows.Forms.Appearance.Button;
            this.checkBox_SAT_VIEW.AutoSize = true;
            this.checkBox_SAT_VIEW.Location = new System.Drawing.Point(582, 41);
            this.checkBox_SAT_VIEW.Name = "checkBox_SAT_VIEW";
            this.checkBox_SAT_VIEW.Size = new System.Drawing.Size(69, 23);
            this.checkBox_SAT_VIEW.TabIndex = 3;
            this.checkBox_SAT_VIEW.TabStop = false;
            this.checkBox_SAT_VIEW.Text = "SAT VIEW";
            this.checkBox_SAT_VIEW.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.checkBox_SAT_VIEW.UseVisualStyleBackColor = true;
            this.checkBox_SAT_VIEW.CheckedChanged += new System.EventHandler(this.checkBox_SAT_VIEW_CheckedChanged);
            // 
            // comboBox_ZOOM
            // 
            this.comboBox_ZOOM.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_ZOOM.FormattingEnabled = true;
            this.comboBox_ZOOM.Items.AddRange(new object[] {
            "HIGH",
            "MEDIUM",
            "LOW"});
            this.comboBox_ZOOM.Location = new System.Drawing.Point(583, 67);
            this.comboBox_ZOOM.Name = "comboBox_ZOOM";
            this.comboBox_ZOOM.Size = new System.Drawing.Size(67, 21);
            this.comboBox_ZOOM.TabIndex = 4;
            this.comboBox_ZOOM.TabStop = false;
            this.comboBox_ZOOM.SelectedIndexChanged += new System.EventHandler(this.comboBox_ZOOM_SelectedIndexChanged);
            // 
            // Form_Map
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(660, 666);
            this.Controls.Add(this.comboBox_ZOOM);
            this.Controls.Add(this.checkBox_SAT_VIEW);
            this.Controls.Add(this.label_ADDRESS);
            this.Controls.Add(this.panel_WAIT);
            this.Controls.Add(this.webBrowser_Map);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form_Map";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Map View";
            this.Shown += new System.EventHandler(this.Form_Map_Shown);
            this.panel_WAIT.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_WAIT)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.WebBrowser webBrowser_Map;
        private System.Windows.Forms.Panel panel_WAIT;
        private System.Windows.Forms.PictureBox pictureBox_WAIT;
        private System.Windows.Forms.Label label_ADDRESS;
        private System.Windows.Forms.CheckBox checkBox_SAT_VIEW;
        private System.Windows.Forms.ComboBox comboBox_ZOOM;
    }
}