namespace appp
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.button1 = new System.Windows.Forms.Button();
            this.Crop = new System.Windows.Forms.Button();
            this.vlc = new AxAXVLC.AxVLCPlugin2();
            this.Stop = new System.Windows.Forms.Button();
            this.Start = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.vlc)).BeginInit();
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.ForeColor = System.Drawing.SystemColors.Control;
            this.button1.Location = new System.Drawing.Point(364, 277);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(47, 21);
            this.button1.TabIndex = 2;
            this.button1.Text = "play";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Crop
            // 
            this.Crop.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Crop.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Crop.ForeColor = System.Drawing.SystemColors.Control;
            this.Crop.Location = new System.Drawing.Point(310, 277);
            this.Crop.Name = "Crop";
            this.Crop.Size = new System.Drawing.Size(48, 21);
            this.Crop.TabIndex = 3;
            this.Crop.Text = "Crop";
            this.Crop.UseVisualStyleBackColor = false;
            this.Crop.Click += new System.EventHandler(this.button2_Click);
            // 
            // vlc
            // 
            this.vlc.Enabled = true;
            this.vlc.Location = new System.Drawing.Point(12, 26);
            this.vlc.Name = "vlc";
            this.vlc.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("vlc.OcxState")));
            this.vlc.Size = new System.Drawing.Size(582, 314);
            this.vlc.TabIndex = 0;
            this.vlc.Enter += new System.EventHandler(this.vlc_Enter);
            // 
            // Stop
            // 
            this.Stop.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Stop.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Stop.ForeColor = System.Drawing.SystemColors.Control;
            this.Stop.Location = new System.Drawing.Point(247, 277);
            this.Stop.Name = "Stop";
            this.Stop.Size = new System.Drawing.Size(57, 21);
            this.Stop.TabIndex = 4;
            this.Stop.Text = "Stop";
            this.Stop.UseVisualStyleBackColor = false;
            this.Stop.Click += new System.EventHandler(this.Stop_Click);
            // 
            // Start
            // 
            this.Start.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Start.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Start.ForeColor = System.Drawing.SystemColors.Control;
            this.Start.Location = new System.Drawing.Point(193, 277);
            this.Start.Name = "Start";
            this.Start.Size = new System.Drawing.Size(48, 20);
            this.Start.TabIndex = 5;
            this.Start.Text = "Start";
            this.Start.UseVisualStyleBackColor = false;
            this.Start.Click += new System.EventHandler(this.Start_Click);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.textBox1.ForeColor = System.Drawing.SystemColors.Menu;
            this.textBox1.Location = new System.Drawing.Point(193, 251);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(205, 20);
            this.textBox1.TabIndex = 6;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(370, 251);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(28, 20);
            this.button2.TabIndex = 7;
            this.button2.Text = "+";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.ClientSize = new System.Drawing.Size(606, 351);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.Start);
            this.Controls.Add(this.Stop);
            this.Controls.Add(this.Crop);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.vlc);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.vlc)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private AxAXVLC.AxVLCPlugin2 vlc;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button Crop;
        private System.Windows.Forms.Button Stop;
        private System.Windows.Forms.Button Start;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button2;
    }
}

