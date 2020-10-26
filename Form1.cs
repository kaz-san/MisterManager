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
            string a5200_repo   = base_repo + "Atari800_MiSTer/contents/releases";      string a5200_dl = base_dl + "Atari800_MiSTer/master/releases/Atari800_";
            string a2600_repo   = base_repo + "Atari2600_MiSTer/contents/releases";     string a2600_dl = base_dl + "Atari2600_MiSTer/master/releases/Atari2600_";
            string col_repo     = base_repo + "ColecoVision_MiSTer/contents/releases";  string col_dl   = base_dl + "ColecoVision_MiSTer/master/releases/ColecoVision_";
            string gb_repo      = base_repo + "Gameboy_MiSTer/contents/releases";       string gb_dl    = base_dl + "Gameboy_MiSTer/master/releases/Gameboy_";
            string gba_repo     = base_repo + "GBA_MiSTer/contents/releases";           string gba_dl   = base_dl + "GBA_MiSTer/master/releases/GBA_";
            string gen_repo     = base_repo + "Genesis_MiSTer/contents/releases";       string gen_dl   = base_dl + "Genesis_MiSTer/master/releases/Genesis_";
            string sms_repo     = base_repo + "SMS_MiSTer/contents/releases";           string sms_dl   = base_dl + "SMS_MiSTer/master/releases/SMS_";
            string mcd_repo     = base_repo + "MegaCD_MiSTer/contents/releases";        string mcd_dl   = base_dl + "MegaCD_MiSTer/master/releases/MegaCD_";
            string ng_repo      = base_repo + "NeoGeo_MiSTer/contents/releases";        string ng_dl    = base_dl + "NeoGeo_MiSTer/master/releases/NeoGeo_";
            string nes_repo     = base_repo + "NES_MiSTer/contents/releases";           string nes_dl   = base_dl + "NES_MiSTer/master/releases/NES_";
            string snes_repo    = base_repo + "SNES_MiSTer/contents/releases";          string snes_dl  = base_dl + "SNES_MiSTer/master/releases/SNES_";
            string pce_repo     = base_repo + "TurboGrafx16_MiSTer/contents/releases";  string pce_dl   = base_dl + "TurboGrafx16_MiSTer/master/releases/TurboGrafx16_";
            string vec_repo     = base_repo + "Vectrex_MiSTer/contents/releases";       string vec_dl   = base_dl + "Vectrex_MiSTer/master/releases/Vectrex_";


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
            if (cb_a5200.Checked){ core_latest = Worker.GetLatestCoreDate(a5200_repo);
                Worker.GetFile(a5200_dl + core_latest + ".rbf", folder_dl + "Atari800_" + core_latest + ".rbf");
            }

            if (cb_a2600.Checked){ core_latest = Worker.GetLatestCoreDate(a2600_repo);
                Worker.GetFile(a2600_dl + core_latest + ".rbf", folder_dl + "Atari2600_" + core_latest + ".rbf");
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
    }
}
