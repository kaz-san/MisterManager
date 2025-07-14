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
            this.cb_ss = new System.Windows.Forms.CheckBox();
            this.cb_ws = new System.Windows.Forms.CheckBox();
            this.cb_sps = new System.Windows.Forms.CheckBox();
            this.cb_s32x = new System.Windows.Forms.CheckBox();
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
            this.cb_a7800 = new System.Windows.Forms.CheckBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.b_upload = new System.Windows.Forms.Button();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.cb_n64 = new System.Windows.Forms.CheckBox();
            this.cb_cdi = new System.Windows.Forms.CheckBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // comb_letter
            // 
            this.comb_letter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comb_letter.FormattingEnabled = true;
            this.comb_letter.Location = new System.Drawing.Point(38, 39);
            this.comb_letter.Margin = new System.Windows.Forms.Padding(2);
            this.comb_letter.Name = "comb_letter";
            this.comb_letter.Size = new System.Drawing.Size(38, 21);
            this.comb_letter.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 24);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "SD Card Letter";
            // 
            // b_dl
            // 
            this.b_dl.Location = new System.Drawing.Point(106, 362);
            this.b_dl.Margin = new System.Windows.Forms.Padding(2);
            this.b_dl.Name = "b_dl";
            this.b_dl.Size = new System.Drawing.Size(128, 38);
            this.b_dl.TabIndex = 2;
            this.b_dl.Text = "Download Updates";
            this.b_dl.UseVisualStyleBackColor = true;
            this.b_dl.Click += new System.EventHandler(this.b_dl_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cb_menu);
            this.groupBox1.Controls.Add(this.cb_mister);
            this.groupBox1.Location = new System.Drawing.Point(38, 37);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(282, 73);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "System";
            // 
            // cb_menu
            // 
            this.cb_menu.AutoSize = true;
            this.cb_menu.Checked = true;
            this.cb_menu.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cb_menu.Location = new System.Drawing.Point(13, 48);
            this.cb_menu.Margin = new System.Windows.Forms.Padding(2);
            this.cb_menu.Name = "cb_menu";
            this.cb_menu.Size = new System.Drawing.Size(53, 17);
            this.cb_menu.TabIndex = 1;
            this.cb_menu.Text = "Menu";
            this.cb_menu.UseVisualStyleBackColor = true;
            // 
            // cb_mister
            // 
            this.cb_mister.AutoSize = true;
            this.cb_mister.Checked = true;
            this.cb_mister.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cb_mister.Location = new System.Drawing.Point(13, 26);
            this.cb_mister.Margin = new System.Windows.Forms.Padding(2);
            this.cb_mister.Name = "cb_mister";
            this.cb_mister.Size = new System.Drawing.Size(60, 17);
            this.cb_mister.TabIndex = 0;
            this.cb_mister.Text = "MiSTer";
            this.cb_mister.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cb_cdi);
            this.groupBox2.Controls.Add(this.cb_n64);
            this.groupBox2.Controls.Add(this.cb_ss);
            this.groupBox2.Controls.Add(this.cb_ws);
            this.groupBox2.Controls.Add(this.cb_sps);
            this.groupBox2.Controls.Add(this.cb_s32x);
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
            this.groupBox2.Controls.Add(this.cb_a7800);
            this.groupBox2.Location = new System.Drawing.Point(38, 115);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox2.Size = new System.Drawing.Size(282, 243);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Console cores";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // cb_ss
            // 
            this.cb_ss.AutoSize = true;
            this.cb_ss.Checked = true;
            this.cb_ss.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cb_ss.Location = new System.Drawing.Point(10, 179);
            this.cb_ss.Margin = new System.Windows.Forms.Padding(2);
            this.cb_ss.Name = "cb_ss";
            this.cb_ss.Size = new System.Drawing.Size(57, 17);
            this.cb_ss.TabIndex = 17;
            this.cb_ss.Text = "Saturn";
            this.cb_ss.UseVisualStyleBackColor = true;
            // 
            // cb_ws
            // 
            this.cb_ws.AutoSize = true;
            this.cb_ws.Checked = true;
            this.cb_ws.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cb_ws.Location = new System.Drawing.Point(171, 158);
            this.cb_ws.Margin = new System.Windows.Forms.Padding(2);
            this.cb_ws.Name = "cb_ws";
            this.cb_ws.Size = new System.Drawing.Size(91, 17);
            this.cb_ws.TabIndex = 16;
            this.cb_ws.Text = "WonderSwan";
            this.cb_ws.UseVisualStyleBackColor = true;
            // 
            // cb_sps
            // 
            this.cb_sps.AutoSize = true;
            this.cb_sps.Checked = true;
            this.cb_sps.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cb_sps.Location = new System.Drawing.Point(171, 180);
            this.cb_sps.Margin = new System.Windows.Forms.Padding(2);
            this.cb_sps.Name = "cb_sps";
            this.cb_sps.Size = new System.Drawing.Size(79, 17);
            this.cb_sps.TabIndex = 15;
            this.cb_sps.Text = "PlayStation";
            this.cb_sps.UseVisualStyleBackColor = true;
            this.cb_sps.CheckedChanged += new System.EventHandler(this.cb_sps_CheckedChanged);
            // 
            // cb_s32x
            // 
            this.cb_s32x.AutoSize = true;
            this.cb_s32x.Checked = true;
            this.cb_s32x.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cb_s32x.Location = new System.Drawing.Point(10, 158);
            this.cb_s32x.Margin = new System.Windows.Forms.Padding(2);
            this.cb_s32x.Name = "cb_s32x";
            this.cb_s32x.Size = new System.Drawing.Size(45, 17);
            this.cb_s32x.TabIndex = 14;
            this.cb_s32x.Text = "32X";
            this.cb_s32x.UseVisualStyleBackColor = true;
            this.cb_s32x.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // cb_vec
            // 
            this.cb_vec.AutoSize = true;
            this.cb_vec.Checked = true;
            this.cb_vec.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cb_vec.Location = new System.Drawing.Point(171, 137);
            this.cb_vec.Margin = new System.Windows.Forms.Padding(2);
            this.cb_vec.Name = "cb_vec";
            this.cb_vec.Size = new System.Drawing.Size(62, 17);
            this.cb_vec.TabIndex = 13;
            this.cb_vec.Text = "Vectrex";
            this.cb_vec.UseVisualStyleBackColor = true;
            // 
            // cb_pce
            // 
            this.cb_pce.AutoSize = true;
            this.cb_pce.Checked = true;
            this.cb_pce.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cb_pce.Location = new System.Drawing.Point(171, 115);
            this.cb_pce.Margin = new System.Windows.Forms.Padding(2);
            this.cb_pce.Name = "cb_pce";
            this.cb_pce.Size = new System.Drawing.Size(76, 17);
            this.cb_pce.TabIndex = 12;
            this.cb_pce.Text = "PC Engine";
            this.cb_pce.UseVisualStyleBackColor = true;
            // 
            // cb_nes
            // 
            this.cb_nes.AutoSize = true;
            this.cb_nes.Checked = true;
            this.cb_nes.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cb_nes.Location = new System.Drawing.Point(171, 72);
            this.cb_nes.Margin = new System.Windows.Forms.Padding(2);
            this.cb_nes.Name = "cb_nes";
            this.cb_nes.Size = new System.Drawing.Size(48, 17);
            this.cb_nes.TabIndex = 10;
            this.cb_nes.Text = "NES";
            this.cb_nes.UseVisualStyleBackColor = true;
            // 
            // cb_ng
            // 
            this.cb_ng.AutoSize = true;
            this.cb_ng.Checked = true;
            this.cb_ng.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cb_ng.Location = new System.Drawing.Point(171, 50);
            this.cb_ng.Margin = new System.Windows.Forms.Padding(2);
            this.cb_ng.Name = "cb_ng";
            this.cb_ng.Size = new System.Drawing.Size(69, 17);
            this.cb_ng.TabIndex = 9;
            this.cb_ng.Text = "Neo Geo";
            this.cb_ng.UseVisualStyleBackColor = true;
            // 
            // cb_snes
            // 
            this.cb_snes.AutoSize = true;
            this.cb_snes.Checked = true;
            this.cb_snes.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cb_snes.Location = new System.Drawing.Point(171, 93);
            this.cb_snes.Margin = new System.Windows.Forms.Padding(2);
            this.cb_snes.Name = "cb_snes";
            this.cb_snes.Size = new System.Drawing.Size(55, 17);
            this.cb_snes.TabIndex = 11;
            this.cb_snes.Text = "SNES";
            this.cb_snes.UseVisualStyleBackColor = true;
            // 
            // cb_sms
            // 
            this.cb_sms.AutoSize = true;
            this.cb_sms.Checked = true;
            this.cb_sms.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cb_sms.Location = new System.Drawing.Point(171, 28);
            this.cb_sms.Margin = new System.Windows.Forms.Padding(2);
            this.cb_sms.Name = "cb_sms";
            this.cb_sms.Size = new System.Drawing.Size(95, 17);
            this.cb_sms.TabIndex = 8;
            this.cb_sms.Text = "Master System";
            this.cb_sms.UseVisualStyleBackColor = true;
            // 
            // cb_mcd
            // 
            this.cb_mcd.AutoSize = true;
            this.cb_mcd.Checked = true;
            this.cb_mcd.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cb_mcd.Location = new System.Drawing.Point(10, 138);
            this.cb_mcd.Margin = new System.Windows.Forms.Padding(2);
            this.cb_mcd.Name = "cb_mcd";
            this.cb_mcd.Size = new System.Drawing.Size(68, 17);
            this.cb_mcd.TabIndex = 7;
            this.cb_mcd.Text = "MegaCD";
            this.cb_mcd.UseVisualStyleBackColor = true;
            this.cb_mcd.CheckedChanged += new System.EventHandler(this.cb_mcd_CheckedChanged);
            // 
            // cb_gen
            // 
            this.cb_gen.AutoSize = true;
            this.cb_gen.Checked = true;
            this.cb_gen.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cb_gen.Location = new System.Drawing.Point(10, 115);
            this.cb_gen.Margin = new System.Windows.Forms.Padding(2);
            this.cb_gen.Name = "cb_gen";
            this.cb_gen.Size = new System.Drawing.Size(64, 17);
            this.cb_gen.TabIndex = 6;
            this.cb_gen.Text = "Genesis";
            this.cb_gen.UseVisualStyleBackColor = true;
            this.cb_gen.CheckedChanged += new System.EventHandler(this.cb_gen_CheckedChanged);
            // 
            // cb_gba
            // 
            this.cb_gba.AutoSize = true;
            this.cb_gba.Checked = true;
            this.cb_gba.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cb_gba.Location = new System.Drawing.Point(10, 93);
            this.cb_gba.Margin = new System.Windows.Forms.Padding(2);
            this.cb_gba.Name = "cb_gba";
            this.cb_gba.Size = new System.Drawing.Size(117, 17);
            this.cb_gba.TabIndex = 5;
            this.cb_gba.Text = "Gameboy Advance";
            this.cb_gba.UseVisualStyleBackColor = true;
            this.cb_gba.CheckedChanged += new System.EventHandler(this.cb_gba_CheckedChanged);
            // 
            // cb_gb
            // 
            this.cb_gb.AutoSize = true;
            this.cb_gb.Checked = true;
            this.cb_gb.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cb_gb.Location = new System.Drawing.Point(10, 71);
            this.cb_gb.Margin = new System.Windows.Forms.Padding(2);
            this.cb_gb.Name = "cb_gb";
            this.cb_gb.Size = new System.Drawing.Size(71, 17);
            this.cb_gb.TabIndex = 4;
            this.cb_gb.Text = "Gameboy";
            this.cb_gb.UseVisualStyleBackColor = true;
            this.cb_gb.CheckedChanged += new System.EventHandler(this.cb_gb_CheckedChanged);
            // 
            // cb_col
            // 
            this.cb_col.AutoSize = true;
            this.cb_col.Checked = true;
            this.cb_col.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cb_col.Location = new System.Drawing.Point(10, 50);
            this.cb_col.Margin = new System.Windows.Forms.Padding(2);
            this.cb_col.Name = "cb_col";
            this.cb_col.Size = new System.Drawing.Size(87, 17);
            this.cb_col.TabIndex = 3;
            this.cb_col.Text = "ColecoVision";
            this.cb_col.UseVisualStyleBackColor = true;
            this.cb_col.CheckedChanged += new System.EventHandler(this.cb_col_CheckedChanged);
            // 
            // cb_a7800
            // 
            this.cb_a7800.AutoSize = true;
            this.cb_a7800.Checked = true;
            this.cb_a7800.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cb_a7800.Location = new System.Drawing.Point(10, 28);
            this.cb_a7800.Margin = new System.Windows.Forms.Padding(2);
            this.cb_a7800.Name = "cb_a7800";
            this.cb_a7800.Size = new System.Drawing.Size(74, 17);
            this.cb_a7800.TabIndex = 2;
            this.cb_a7800.Text = "Atari 7800";
            this.cb_a7800.UseVisualStyleBackColor = true;
            this.cb_a7800.CheckedChanged += new System.EventHandler(this.cb_a2600_CheckedChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.b_upload);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.comb_letter);
            this.groupBox3.Location = new System.Drawing.Point(36, 413);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox3.Size = new System.Drawing.Size(282, 79);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            this.groupBox3.Enter += new System.EventHandler(this.groupBox3_Enter);
            // 
            // b_upload
            // 
            this.b_upload.Location = new System.Drawing.Point(140, 24);
            this.b_upload.Margin = new System.Windows.Forms.Padding(2);
            this.b_upload.Name = "b_upload";
            this.b_upload.Size = new System.Drawing.Size(123, 34);
            this.b_upload.TabIndex = 2;
            this.b_upload.Text = "Upload to SD Card";
            this.b_upload.UseVisualStyleBackColor = true;
            this.b_upload.Click += new System.EventHandler(this.b_upload_Click);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(110, 504);
            this.linkLabel1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(124, 13);
            this.linkLabel1.TabIndex = 6;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Made by Kaz-San (2025)";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // cb_n64
            // 
            this.cb_n64.AutoSize = true;
            this.cb_n64.Checked = true;
            this.cb_n64.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cb_n64.Location = new System.Drawing.Point(10, 200);
            this.cb_n64.Margin = new System.Windows.Forms.Padding(2);
            this.cb_n64.Name = "cb_n64";
            this.cb_n64.Size = new System.Drawing.Size(46, 17);
            this.cb_n64.TabIndex = 18;
            this.cb_n64.Text = "N64";
            this.cb_n64.UseVisualStyleBackColor = true;
            // 
            // cb_cdi
            // 
            this.cb_cdi.AutoSize = true;
            this.cb_cdi.Checked = true;
            this.cb_cdi.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cb_cdi.Location = new System.Drawing.Point(171, 200);
            this.cb_cdi.Margin = new System.Windows.Forms.Padding(2);
            this.cb_cdi.Name = "cb_cdi";
            this.cb_cdi.Size = new System.Drawing.Size(46, 17);
            this.cb_cdi.TabIndex = 19;
            this.cb_cdi.Text = "CD-i";
            this.cb_cdi.UseVisualStyleBackColor = true;
            // 
            // MisterManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(350, 524);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.b_dl);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
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
        private System.Windows.Forms.CheckBox cb_a7800;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button b_upload;
        private System.Windows.Forms.CheckBox cb_pce;
        private System.Windows.Forms.CheckBox cb_snes;
        private System.Windows.Forms.CheckBox cb_vec;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.CheckBox cb_s32x;
        private System.Windows.Forms.CheckBox cb_sps;
        private System.Windows.Forms.CheckBox cb_ws;
        private System.Windows.Forms.CheckBox cb_ss;
        private System.Windows.Forms.CheckBox cb_cdi;
        private System.Windows.Forms.CheckBox cb_n64;
    }
}

