namespace TestPersonalization
{
    partial class TestPersonalization
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TestPersonalization));
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.btnSpeichern = new System.Windows.Forms.Button();
            this.grpAppdata = new System.Windows.Forms.GroupBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtRegistry = new System.Windows.Forms.TextBox();
            this.btnSpeicherRegistry = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnAnleitung = new System.Windows.Forms.Button();
            this.grpAppdata.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // richTextBox1
            // 
            this.richTextBox1.Font = new System.Drawing.Font("Microsoft JhengHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox1.Location = new System.Drawing.Point(62, 37);
            this.richTextBox1.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(538, 208);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
            // 
            // btnSpeichern
            // 
            this.btnSpeichern.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnSpeichern.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSpeichern.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnSpeichern.Location = new System.Drawing.Point(62, 260);
            this.btnSpeichern.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnSpeichern.Name = "btnSpeichern";
            this.btnSpeichern.Size = new System.Drawing.Size(542, 44);
            this.btnSpeichern.TabIndex = 1;
            this.btnSpeichern.Text = "Speichern";
            this.btnSpeichern.UseVisualStyleBackColor = false;
            this.btnSpeichern.Click += new System.EventHandler(this.btnSpeichern_Click);
            // 
            // grpAppdata
            // 
            this.grpAppdata.Controls.Add(this.richTextBox1);
            this.grpAppdata.Controls.Add(this.btnSpeichern);
            this.grpAppdata.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpAppdata.Location = new System.Drawing.Point(24, 190);
            this.grpAppdata.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.grpAppdata.Name = "grpAppdata";
            this.grpAppdata.Padding = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.grpAppdata.Size = new System.Drawing.Size(648, 346);
            this.grpAppdata.TabIndex = 2;
            this.grpAppdata.TabStop = false;
            this.grpAppdata.Text = "Appdata";
            // 
            // statusStrip1
            // 
            this.statusStrip1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 561);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(2, 0, 28, 0);
            this.statusStrip1.Size = new System.Drawing.Size(1378, 22);
            this.statusStrip1.TabIndex = 3;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(0, 12);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtRegistry);
            this.groupBox1.Controls.Add(this.btnSpeicherRegistry);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(706, 190);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.groupBox1.Size = new System.Drawing.Size(648, 346);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Registry";
            // 
            // txtRegistry
            // 
            this.txtRegistry.Font = new System.Drawing.Font("Microsoft JhengHei UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.txtRegistry.Location = new System.Drawing.Point(62, 127);
            this.txtRegistry.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txtRegistry.Name = "txtRegistry";
            this.txtRegistry.Size = new System.Drawing.Size(538, 41);
            this.txtRegistry.TabIndex = 2;
            // 
            // btnSpeicherRegistry
            // 
            this.btnSpeicherRegistry.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnSpeicherRegistry.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSpeicherRegistry.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSpeicherRegistry.Location = new System.Drawing.Point(62, 260);
            this.btnSpeicherRegistry.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnSpeicherRegistry.Name = "btnSpeicherRegistry";
            this.btnSpeicherRegistry.Size = new System.Drawing.Size(542, 44);
            this.btnSpeicherRegistry.TabIndex = 1;
            this.btnSpeicherRegistry.Text = "Speichern";
            this.btnSpeicherRegistry.UseVisualStyleBackColor = false;
            this.btnSpeicherRegistry.Click += new System.EventHandler(this.btnSpeicherRegistry_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bauhaus 93", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(443, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(743, 73);
            this.label1.TabIndex = 5;
            this.label1.Text = "Test Personalization Tool";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::TestPersonalization.Properties.Resources.ivanti_logo;
            this.pictureBox1.Location = new System.Drawing.Point(47, 43);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(403, 90);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // btnAnleitung
            // 
            this.btnAnleitung.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnAnleitung.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnAnleitung.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAnleitung.Location = new System.Drawing.Point(1255, 43);
            this.btnAnleitung.Name = "btnAnleitung";
            this.btnAnleitung.Size = new System.Drawing.Size(99, 104);
            this.btnAnleitung.TabIndex = 7;
            this.btnAnleitung.Text = "Help";
            this.btnAnleitung.UseVisualStyleBackColor = false;
            this.btnAnleitung.Click += new System.EventHandler(this.btnAnleitung_Click);
            // 
            // TestPersonalization
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(1378, 583);
            this.Controls.Add(this.btnAnleitung);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.grpAppdata);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "TestPersonalization";
            this.Text = "Test Personalization Tool";
            this.grpAppdata.ResumeLayout(false);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button btnSpeichern;
        private System.Windows.Forms.GroupBox grpAppdata;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtRegistry;
        private System.Windows.Forms.Button btnSpeicherRegistry;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnAnleitung;
    }
}

