namespace MidiConverter
{
    partial class Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form));
            this.check = new System.Windows.Forms.Button();
            this.checkboxActive = new System.Windows.Forms.CheckBox();
            this.options = new System.Windows.Forms.GroupBox();
            this.general = new System.Windows.Forms.GroupBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.information = new System.Windows.Forms.GroupBox();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.linkLabel2 = new System.Windows.Forms.LinkLabel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.options.SuspendLayout();
            this.general.SuspendLayout();
            this.information.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // check
            // 
            this.check.Cursor = System.Windows.Forms.Cursors.Hand;
            this.check.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.check.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.check.Location = new System.Drawing.Point(9, 29);
            this.check.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.check.Name = "check";
            this.check.Size = new System.Drawing.Size(445, 35);
            this.check.TabIndex = 0;
            this.check.Text = "click and press note";
            this.check.UseVisualStyleBackColor = true;
            this.check.Click += new System.EventHandler(this.check_Click);
            // 
            // checkboxActive
            // 
            this.checkboxActive.AutoSize = true;
            this.checkboxActive.Checked = true;
            this.checkboxActive.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkboxActive.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.checkboxActive.Location = new System.Drawing.Point(9, 29);
            this.checkboxActive.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.checkboxActive.Name = "checkboxActive";
            this.checkboxActive.Size = new System.Drawing.Size(69, 24);
            this.checkboxActive.TabIndex = 1;
            this.checkboxActive.Text = "active";
            this.checkboxActive.UseVisualStyleBackColor = true;
            // 
            // options
            // 
            this.options.Controls.Add(this.check);
            this.options.Location = new System.Drawing.Point(9, 182);
            this.options.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.options.Name = "options";
            this.options.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.options.Size = new System.Drawing.Size(462, 86);
            this.options.TabIndex = 2;
            this.options.TabStop = false;
            this.options.Text = "debug";
            // 
            // general
            // 
            this.general.Controls.Add(this.checkBox3);
            this.general.Controls.Add(this.checkBox2);
            this.general.Controls.Add(this.checkboxActive);
            this.general.Location = new System.Drawing.Point(9, 18);
            this.general.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.general.Name = "general";
            this.general.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.general.Size = new System.Drawing.Size(215, 154);
            this.general.TabIndex = 3;
            this.general.TabStop = false;
            this.general.Text = "general";
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.checkBox3.Location = new System.Drawing.Point(9, 97);
            this.checkBox3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(92, 24);
            this.checkBox3.TabIndex = 3;
            this.checkBox3.Text = "auto size";
            this.checkBox3.UseVisualStyleBackColor = true;
            this.checkBox3.CheckedChanged += new System.EventHandler(this.checkBox3_CheckedChanged);
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.checkBox2.Location = new System.Drawing.Point(9, 63);
            this.checkBox2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(124, 24);
            this.checkBox2.TabIndex = 2;
            this.checkBox2.Text = "always on top";
            this.checkBox2.UseVisualStyleBackColor = true;
            this.checkBox2.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // information
            // 
            this.information.Controls.Add(this.pictureBox1);
            this.information.Location = new System.Drawing.Point(9, 278);
            this.information.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.information.Name = "information";
            this.information.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.information.Size = new System.Drawing.Size(462, 169);
            this.information.TabIndex = 4;
            this.information.TabStop = false;
            this.information.Text = "information";
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.LinkColor = System.Drawing.Color.RoyalBlue;
            this.linkLabel1.Location = new System.Drawing.Point(72, 97);
            this.linkLabel1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(63, 20);
            this.linkLabel1.TabIndex = 5;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Discord";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // linkLabel2
            // 
            this.linkLabel2.AutoSize = true;
            this.linkLabel2.LinkColor = System.Drawing.Color.RoyalBlue;
            this.linkLabel2.Location = new System.Drawing.Point(7, 97);
            this.linkLabel2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.linkLabel2.Name = "linkLabel2";
            this.linkLabel2.Size = new System.Drawing.Size(57, 20);
            this.linkLabel2.TabIndex = 6;
            this.linkLabel2.TabStop = true;
            this.linkLabel2.Text = "Github";
            this.linkLabel2.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel2_LinkClicked);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = global::MidiCraft.Properties.Resources.keybinds;
            this.pictureBox1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
            this.pictureBox1.Location = new System.Drawing.Point(9, 29);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(445, 130);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.linkLabel1);
            this.groupBox1.Controls.Add(this.linkLabel2);
            this.groupBox1.Location = new System.Drawing.Point(231, 18);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(176, 154);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "about";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 121);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 20);
            this.label1.TabIndex = 7;
            this.label1.Text = "by snoopti | Jonas ";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(484, 461);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.information);
            this.Controls.Add(this.general);
            this.Controls.Add(this.options);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(500, 500);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(500, 500);
            this.Name = "Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MidiCraft | by snoopti";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.options.ResumeLayout(false);
            this.general.ResumeLayout(false);
            this.general.PerformLayout();
            this.information.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button check;
        private System.Windows.Forms.CheckBox checkboxActive;
        private System.Windows.Forms.GroupBox options;
        private System.Windows.Forms.GroupBox general;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.GroupBox information;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.LinkLabel linkLabel2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
    }
}

