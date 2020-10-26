using System;

namespace MisterManager
{
    partial class MisterManager
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MisterManager));
            this.comb_letter = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.b_dl = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cb_menu = new System.Windows.Forms.CheckBox();
            this.cb_mister = new System.Windows.Forms.CheckBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cb_vec = new System.Windows.Forms.CheckBox();
            this.cb_pce = new System.Windows.Forms.CheckBox();
            this.cb_nes = new System.Windows.Forms.CheckBox();
            this.cb_ng = new System.Windows.Forms.CheckBox();
            this.cb_snes = new System.Windows.Forms.CheckBox();
            this.cb_sms = new System.Windows.Forms.CheckBox();
            this.cb_mcd = new System.Windows.Forms.CheckBox();
            this.cb_gen = new System.Windows.Forms.CheckBox();
            this.cb_gba = new System.Windows.Forms.CheckBox();
            this.cb_gb = new System.Windows.Forms.CheckBox();
            this.cb_col = new System.Windows.Forms.CheckBox();
            this.cb_a2600 = new System.Windows.Forms.CheckBox();
            this.cb_a5200 = new System.Windows.Forms.CheckBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.b_upload = new System.Windows.Forms.Button();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // comb_letter
            // 
            this.comb_letter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comb_letter.FormattingEnabled = true;
            this.comb_letter.Location = new System.Drawing.Point(51, 48);
            this.comb_letter.Name = "comb_letter";
            this.comb_letter.Size = new System.Drawing.Size(50, 24);
            this.comb_letter.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "SD Card Letter";
            // 
            // b_dl
            // 
            this.b_dl.Location = new System.Drawing.Point(144, 382);
            this.b_dl.Name = "b_dl";
            this.b_dl.Size = new System.Drawing.Size(170, 47);
            this.b_dl.TabIndex = 2;
            this.b_dl.Text = "Download Updates";
            this.b_dl.UseVisualStyleBackColor = true;
            this.b_dl.Click += new System.EventHandler(this.b_dl_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cb_menu);
            this.groupBox1.Controls.Add(this.cb_mister);
            this.groupBox1.Location = new System.Drawing.Point(50, 46);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(376, 90);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "System";
            // 
            // cb_menu
            // 
            this.cb_menu.AutoSize = true;
            this.cb_menu.Checked = true;
            this.cb_menu.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cb_menu.Location = new System.Drawing.Point(17, 59);
            this.cb_menu.Name = "cb_menu";
            this.cb_menu.Size = new System.Drawing.Size(65, 21);
            this.cb_menu.TabIndex = 1;
            this.cb_menu.Text = "Menu";
            this.cb_menu.UseVisualStyleBackColor = true;
            // 
            // cb_mister
            // 
            this.cb_mister.AutoSize = true;
            this.cb_mister.Checked = true;
            this.cb_mister.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cb_mister.Location = new System.Drawing.Point(17, 32);
            this.cb_mister.Name = "cb_mister";
            this.cb_mister.Size = new System.Drawing.Size(75, 21);
            this.cb_mister.TabIndex = 0;
            this.cb_mister.Text = "MiSTer";
            this.cb_mister.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cb_vec);
            this.groupBox2.Controls.Add(this.cb_pce);
            this.groupBox2.Controls.Add(this.cb_nes);
            this.groupBox2.Controls.Add(this.cb_ng);
            this.groupBox2.Controls.Add(this.cb_snes);
            this.groupBox2.Controls.Add(this.cb_sms);
            this.groupBox2.Controls.Add(this.cb_mcd);
            this.groupBox2.Controls.Add(this.cb_gen);
            this.groupBox2.Controls.Add(this.cb_gba);
            this.groupBox2.Controls.Add(this.cb_gb);
            this.groupBox2.Controls.Add(this.cb_col);
            this.groupBox2.Controls.Add(this.cb_a2600);
            this.groupBox2.Controls.Add(this.cb_a5200);
            this.groupBox2.Location = new System.Drawing.Point(50, 142);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(376, 234);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Console cores";
            // 
            // cb_vec
            // 
            this.cb_vec.AutoSize = true;
            this.cb_vec.Checked = true;
            this.cb_vec.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cb_vec.Location = new System.Drawing.Point(228, 169);
            this.cb_vec.Name = "cb_vec";
            this.cb_vec.Size = new System.Drawing.Size(77, 21);
            this.cb_vec.TabIndex = 13;
            this.cb_vec.Text = "Vectrex";
            this.cb_vec.UseVisualStyleBackColor = true;
            // 
            // cb_pce
            // 
            this.cb_pce.AutoSize = true;
            this.cb_pce.Checked = true;
            this.cb_pce.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cb_pce.Location = new System.Drawing.Point(228, 142);
            this.cb_pce.Name = "cb_pce";
            this.cb_pce.Size = new System.Drawing.Size(96, 21);
            this.cb_pce.TabIndex = 12;
            this.cb_pce.Text = "PC Engine";
            this.cb_pce.UseVisualStyleBackColor = true;
            // 
            // cb_nes
            // 
            this.cb_nes.AutoSize = true;
            this.cb_nes.Checked = true;
            this.cb_nes.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cb_nes.Location = new System.Drawing.Point(228, 88);
            this.cb_nes.Name = "cb_nes";
            this.cb_nes.Size = new System.Drawing.Size(58, 21);
            this.cb_nes.TabIndex = 10;
            this.cb_nes.Text = "NES";
            this.cb_nes.UseVisualStyleBackColor = true;
            // 
            // cb_ng
            // 
            this.cb_ng.AutoSize = true;
            this.cb_ng.Checked = true;
            this.cb_ng.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cb_ng.Location = new System.Drawing.Point(228, 61);
            this.cb_ng.Name = "cb_ng";
            this.cb_ng.Size = new System.Drawing.Size(87, 21);
            this.cb_ng.TabIndex = 9;
            this.cb_ng.Text = "Neo Geo";
            this.cb_ng.UseVisualStyleBackColor = true;
            // 
            // cb_snes
            // 
            this.cb_snes.AutoSize = true;
            this.cb_snes.Checked = true;
            this.cb_snes.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cb_snes.Location = new System.Drawing.Point(228, 115);
            this.cb_snes.Name = "cb_snes";
            this.cb_snes.Size = new System.Drawing.Size(67, 21);
            this.cb_snes.TabIndex = 11;
            this.cb_snes.Text = "SNES";
            this.cb_snes.UseVisualStyleBackColor = true;
            // 
            // cb_sms
            // 
            this.cb_sms.AutoSize = true;
            this.cb_sms.Checked = true;
            this.cb_sms.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cb_sms.Location = new System.Drawing.Point(228, 34);
            this.cb_sms.Name = "cb_sms";
            this.cb_sms.Size = new System.Drawing.Size(123, 21);
            this.cb_sms.TabIndex = 8;
            this.cb_sms.Text = "Master System";
            this.cb_sms.UseVisualStyleBackColor = true;
            // 
            // cb_mcd
            // 
            this.cb_mcd.AutoSize = true;
            this.cb_mcd.Checked = true;
            this.cb_mcd.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cb_mcd.Location = new System.Drawing.Point(17, 196);
            this.cb_mcd.Name = "cb_mcd";
            this.cb_mcd.Size = new System.Drawing.Size(84, 21);
            this.cb_mcd.TabIndex = 7;
            this.cb_mcd.Text = "MegaCD";
            this.cb_mcd.UseVisualStyleBackColor = true;
            // 
            // cb_gen
            // 
            this.cb_gen.AutoSize = true;
            this.cb_gen.Checked = true;
            this.cb_gen.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cb_gen.Location = new System.Drawing.Point(17, 169);
            this.cb_gen.Name = "cb_gen";
            this.cb_gen.Size = new System.Drawing.Size(82, 21);
            this.cb_gen.TabIndex = 6;
            this.cb_gen.Text = "Genesis";
            this.cb_gen.UseVisualStyleBackColor = true;
            // 
            // cb_gba
            // 
            this.cb_gba.AutoSize = true;
            this.cb_gba.Checked = true;
            this.cb_gba.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cb_gba.Location = new System.Drawing.Point(17, 142);
            this.cb_gba.Name = "cb_gba";
            this.cb_gba.Size = new System.Drawing.Size(150, 21);
            this.cb_gba.TabIndex = 5;
            this.cb_gba.Text = "Gameboy Advance";
            this.cb_gba.UseVisualStyleBackColor = true;
            // 
            // cb_gb
            // 
            this.cb_gb.AutoSize = true;
            this.cb_gb.Checked = true;
            this.cb_gb.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cb_gb.Location = new System.Drawing.Point(17, 115);
            this.cb_gb.Name = "cb_gb";
            this.cb_gb.Size = new System.Drawing.Size(91, 21);
            this.cb_gb.TabIndex = 4;
            this.cb_gb.Text = "Gameboy";
            this.cb_gb.UseVisualStyleBackColor = true;
            // 
            // cb_col
            // 
            this.cb_col.AutoSize = true;
            this.cb_col.Checked = true;
            this.cb_col.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cb_col.Location = new System.Drawing.Point(17, 88);
            this.cb_col.Name = "cb_col";
            this.cb_col.Size = new System.Drawing.Size(111, 21);
            this.cb_col.TabIndex = 3;
            this.cb_col.Text = "ColecoVision";
            this.cb_col.UseVisualStyleBackColor = true;
            // 
            // cb_a2600
            // 
            this.cb_a2600.AutoSize = true;
            this.cb_a2600.Checked = true;
            this.cb_a2600.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cb_a2600.Location = new System.Drawing.Point(17, 61);
            this.cb_a2600.Name = "cb_a2600";
            this.cb_a2600.Size = new System.Drawing.Size(95, 21);
            this.cb_a2600.TabIndex = 2;
            this.cb_a2600.Text = "Atari 2600";
            this.cb_a2600.UseVisualStyleBackColor = true;
            // 
            // cb_a5200
            // 
            this.cb_a5200.AutoSize = true;
            this.cb_a5200.Enabled = false;
            this.cb_a5200.Location = new System.Drawing.Point(17, 34);
            this.cb_a5200.Name = "cb_a5200";
            this.cb_a5200.Size = new System.Drawing.Size(95, 21);
            this.cb_a5200.TabIndex = 1;
            this.cb_a5200.Text = "Atari 5200";
            this.cb_a5200.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.b_upload);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.comb_letter);
            this.groupBox3.Location = new System.Drawing.Point(50, 435);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(376, 97);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            // 
            // b_upload
            // 
            this.b_upload.Location = new System.Drawing.Point(187, 30);
            this.b_upload.Name = "b_upload";
            this.b_upload.Size = new System.Drawing.Size(164, 42);
            this.b_upload.TabIndex = 2;
            this.b_upload.Text = "Upload to SD Card";
            this.b_upload.UseVisualStyleBackColor = true;
            this.b_upload.Click += new System.EventHandler(this.b_upload_Click);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(144, 539);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(166, 17);
            this.linkLabel1.TabIndex = 6;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Made by Kaz-San (2020)";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // MisterManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(471, 566);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.b_dl);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MisterManager";
            this.Text = "MisterManager";
            this.Load += new System.EventHandler(this.MisterManager_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion

        private System.Windows.Forms.ComboBox comb_letter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button b_dl;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox cb_menu;
        private System.Windows.Forms.CheckBox cb_mister;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox cb_nes;
        private System.Windows.Forms.CheckBox cb_ng;
        private System.Windows.Forms.CheckBox cb_sms;
        private System.Windows.Forms.CheckBox cb_mcd;
        private System.Windows.Forms.CheckBox cb_gen;
        private System.Windows.Forms.CheckBox cb_gba;
        private System.Windows.Forms.CheckBox cb_gb;
        private System.Windows.Forms.CheckBox cb_col;
        private System.Windows.Forms.CheckBox cb_a2600;
        private System.Windows.Forms.CheckBox cb_a5200;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button b_upload;
        private System.Windows.Forms.CheckBox cb_pce;
        private System.Windows.Forms.CheckBox cb_snes;
        private System.Windows.Forms.CheckBox cb_vec;
        private System.Windows.Forms.LinkLabel linkLabel1;
    }
}

