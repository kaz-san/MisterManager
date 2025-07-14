using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MisterManager
{
    public partial class MisterManager : Form
    {
        string dl_path = @"C:\Users\" + Environment.UserName + @"\Downloads\MiSTer\";

        string base_repo = "https://api.github.com/repos/MiSTer-devel/";
        string base_dl = "https://raw.githubusercontent.com/MiSTer-devel/";


        public MisterManager()
        {
            InitializeComponent();
            
            comb_letter.Items.Add(@"D:\");
            comb_letter.Items.Add(@"E:\");
            comb_letter.Items.Add(@"F:\");
            comb_letter.Items.Add(@"G:\");
            comb_letter.Items.Add(@"H:\");
            comb_letter.Items.Add(@"I:\");
            comb_letter.Items.Add(@"J:\");
            comb_letter.Items.Add(@"K:\");
            comb_letter.Items.Add(@"L:\");

            comb_letter.SelectedIndex = 5;
        }

        private void MisterManager_Load(object sender, EventArgs e)
        {
            
        }

        private void b_dl_Click(object sender, EventArgs e)
        {
            System.IO.Directory.CreateDirectory(dl_path);
            string folder_dl = dl_path;

            //Deleting old downloaded files
            foreach (string file in Directory.GetFiles(dl_path))
            {
                File.Delete(file);
            }

            string mister_latest, menu_latest, core_latest;
            
            //Setting Mister system and Menu URL
            string mister_repo  = base_repo + "Main_MiSTer/contents/releases"; string mister_dl = base_dl + "Main_MiSTer/master/releases/MiSTer_";
            string menu_repo    = base_repo + "Menu_MiSTer/contents/releases"; string menu_dl   = base_dl + "Menu_MiSTer/master/releases/menu_";

            //Setting Console cores URL
            string a7800_repo   = base_repo + "Atari7800_MiSTer/contents/releases";     string a7800_dl  = base_dl + "Atari7800_MiSTer/master/releases/Atari7800_";
            string col_repo     = base_repo + "ColecoVision_MiSTer/contents/releases";  string col_dl    = base_dl + "ColecoVision_MiSTer/master/releases/ColecoVision_";
            string cdi_repo     = base_repo + "CDi_MiSTer/contents/releases";           string cdi_dl    = base_dl + "CDi_MiSTer/master/releases/CDi_";
            string gb_repo      = base_repo + "Gameboy_MiSTer/contents/releases";       string gb_dl     = base_dl + "Gameboy_MiSTer/master/releases/Gameboy_";
            string gba_repo     = base_repo + "GBA_MiSTer/contents/releases";           string gba_dl    = base_dl + "GBA_MiSTer/master/releases/GBA_";
            string gen_repo     = base_repo + "Genesis_MiSTer/contents/releases";       string gen_dl    = base_dl + "Genesis_MiSTer/master/releases/Genesis_";
            string sms_repo     = base_repo + "SMS_MiSTer/contents/releases";           string sms_dl    = base_dl + "SMS_MiSTer/master/releases/SMS_";
            string mcd_repo     = base_repo + "MegaCD_MiSTer/contents/releases";        string mcd_dl    = base_dl + "MegaCD_MiSTer/master/releases/MegaCD_";
            string ng_repo      = base_repo + "NeoGeo_MiSTer/contents/releases";        string ng_dl     = base_dl + "NeoGeo_MiSTer/master/releases/NeoGeo_";
            string nes_repo     = base_repo + "NES_MiSTer/contents/releases";           string nes_dl    = base_dl + "NES_MiSTer/master/releases/NES_";
            string n64_repo     = base_repo + "N64_MiSTer/contents/releases";           string n64_dl    = base_dl + "N64_MiSTer/master/releases/N64_";      
            string snes_repo    = base_repo + "SNES_MiSTer/contents/releases";          string snes_dl   = base_dl + "SNES_MiSTer/master/releases/SNES_";
            string pce_repo     = base_repo + "TurboGrafx16_MiSTer/contents/releases";  string pce_dl    = base_dl + "TurboGrafx16_MiSTer/master/releases/TurboGrafx16_";
            string vec_repo     = base_repo + "Vectrex_MiSTer/contents/releases";       string vec_dl    = base_dl + "Vectrex_MiSTer/master/releases/Vectrex_";
            string s32x_repo    = base_repo + "S32X_MiSTer/contents/releases";          string s32x_dl   = base_dl + "S32X_MiSTer/master/releases/S32X_";
            string saturn_repo  = base_repo + "Saturn_MiSTer/contents/releases";        string saturn_dl = base_dl + "Saturn_MiSTer/master/releases/Saturn_";
            string sps_repo     = base_repo + "PSX_MiSTer/contents/releases";           string sps_dl    = base_dl + "PSX_MiSTer/master/releases/PSX_";
            string ws_repo      = base_repo + "WonderSwan_MiSTer/contents/releases";    string ws_dl     = base_dl + "WonderSwan_MiSTer/master/releases/WonderSwan_";

            /////////////////////////////////
            //Checking the latest version of Mister and Menu if the checkboxes are checked
            /////////////////////////////////////////////////////////
            if (cb_mister.Checked) { mister_latest = Worker.GetLatestMisterDate(mister_repo);
                Worker.GetFile(mister_dl + mister_latest, folder_dl + "MiSTer"); 
            }

            if (cb_menu.Checked) { menu_latest = Worker.GetLatestCoreDate(menu_repo);
                Worker.GetFile(menu_dl + menu_latest + ".rbf", folder_dl + "menu.rbf");
            }
            /////////////////////////////////
            //Checking the latest version of the Console cores if the checkboxes are checked
            /////////////////////////////////////////////////////////

            if (cb_a7800.Checked){ core_latest = Worker.GetLatestCoreDate(a7800_repo);
                Worker.GetFile(a7800_dl + core_latest + ".rbf", folder_dl + "Atari7800_" + core_latest + ".rbf");
            }

            if (cb_col.Checked){ core_latest = Worker.GetLatestCoreDate(col_repo);
                Worker.GetFile(col_dl + core_latest + ".rbf", folder_dl + "ColecoVision_" + core_latest + ".rbf");
            }

            if (cb_gb.Checked){ core_latest = Worker.GetLatestCoreDate(gb_repo);
                Worker.GetFile(gb_dl + core_latest + ".rbf", folder_dl + "Gameboy_" + core_latest + ".rbf");
            }
            
            if (cb_gba.Checked){ core_latest = Worker.GetLatestCoreDate(gba_repo);
                Worker.GetFile(gba_dl + core_latest + ".rbf", folder_dl + "GBA_" + core_latest + ".rbf");
            }

            if (cb_gen.Checked){ core_latest = Worker.GetLatestCoreDate(gen_repo);
                Worker.GetFile(gen_dl + core_latest + ".rbf", folder_dl + "Genesis_" + core_latest + ".rbf");
            }

            if (cb_sms.Checked){ core_latest = Worker.GetLatestCoreDate(sms_repo);
                Worker.GetFile(sms_dl + core_latest + ".rbf", folder_dl + "SMS_" + core_latest + ".rbf");
            }

            if (cb_mcd.Checked){ core_latest = Worker.GetLatestCoreDate(mcd_repo);
                Worker.GetFile(mcd_dl + core_latest + ".rbf", folder_dl + "MegaCD_" + core_latest + ".rbf");
            }

            if (cb_ng.Checked){ core_latest = Worker.GetLatestCoreDate(ng_repo);
                Worker.GetFile(ng_dl + core_latest + ".rbf", folder_dl + "NeoGeo_" + core_latest + ".rbf");
            }

            if (cb_nes.Checked){ core_latest = Worker.GetLatestCoreDate(nes_repo);
                Worker.GetFile(nes_dl + core_latest + ".rbf", folder_dl + "NES_" + core_latest + ".rbf");
            }

            if (cb_snes.Checked){ core_latest = Worker.GetLatestCoreDate(snes_repo);
                Worker.GetFile(snes_dl + core_latest + ".rbf", folder_dl + "SNES_" + core_latest + ".rbf");
            }

            if (cb_pce.Checked){ core_latest = Worker.GetLatestCoreDate(pce_repo);
                Worker.GetFile(pce_dl + core_latest + ".rbf", folder_dl + "TurboGrafx16_" + core_latest + ".rbf");
            }

            if (cb_vec.Checked){ core_latest = Worker.GetLatestCoreDate(vec_repo);
                Worker.GetFile(vec_dl + core_latest + ".rbf", folder_dl + "Vectrex_" + core_latest + ".rbf");
            }

            if (cb_s32x.Checked){ core_latest = Worker.GetLatestCoreDate(s32x_repo);
                Worker.GetFile(s32x_dl + core_latest + ".rbf", folder_dl + "S32X_" + core_latest + ".rbf");
            }

            if (cb_sps.Checked) { core_latest = Worker.GetLatestCoreDate(sps_repo);
                Worker.GetFile(sps_dl + core_latest + ".rbf", folder_dl + "PSX_" + core_latest + ".rbf");
            }

            if (cb_ss.Checked)
            {
                core_latest = Worker.GetLatestCoreDate(saturn_repo);
                Worker.GetFile(saturn_dl + core_latest + ".rbf", folder_dl + "Saturn_" + core_latest + ".rbf");
            }

            if (cb_ws.Checked) { core_latest = Worker.GetLatestCoreDate(ws_repo);
                Worker.GetFile(ws_dl + core_latest + ".rbf", folder_dl + "WonderSwan_" + core_latest + ".rbf");
            }

            if (cb_cdi.Checked)
            {
                core_latest = Worker.GetLatestCoreDate(cdi_repo);
                Worker.GetFile(cdi_dl + core_latest + ".rbf", folder_dl + "CDi_" + core_latest + ".rbf");
            }

            if (cb_n64.Checked)
            {
                core_latest = Worker.GetLatestCoreDate(n64_repo);
                Worker.GetFile(n64_dl + core_latest + ".rbf", folder_dl + "N64_" + core_latest + ".rbf");
            }

            MessageBox.Show("Download Successful!","Downloader",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }

        private void b_upload_Click(object sender, EventArgs e)
        {
            //Deleting old cores
            foreach (string file in Directory.GetFiles(comb_letter.Text + @"\_Console"))
            {
                File.Delete(file);
            }

            //Deleting old menu and system
            File.Delete(comb_letter.Text + "MiSTer");
            File.Delete(comb_letter.Text + "menu.rbf");

            //Copying the new menu and system
            File.Copy(dl_path + "MiSTer", comb_letter.Text + "MiSTer");
            File.Copy(dl_path + "menu.rbf", comb_letter.Text + "menu.rbf");

            //Copying the new console cores
            var r = Directory.GetFiles(dl_path , "*_*.rbf");

            foreach (var s in r)
            {
                var sourceFile = new FileInfo(s);
                sourceFile.CopyTo(comb_letter.Text + @"\_Console" + "\\"+ s.Replace(dl_path, string.Empty));
            }

            MessageBox.Show("Upload Successful!", "Uploader", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/kaz-san");
        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void cb_sps_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void cb_a2600_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void cb_col_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void cb_gb_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void cb_gba_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void cb_gen_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void cb_mcd_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
