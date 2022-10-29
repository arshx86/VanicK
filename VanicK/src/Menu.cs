#region

using System;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

#endregion

namespace vanick
{
    public partial class Menu : Form
    {

        public Menu() => InitializeComponent();

        private void Menu_Load(object sender, EventArgs e)
        {
            var proc = Process.GetProcessesByName("csgo");
            if (proc.Length <= 0)
            {
                MessageBox.Show("Please run CSGO first!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Environment.Exit(0);
            }
            Glow.Run();
        }

        private void modeswitch_CheckedChanged(object sender, EventArgs e)
        {
            if (!modeswitch.Checked)
            {
                // team mode
                enemy_lbl.ForeColor = Color.White;
                team_lbl.ForeColor = Color.Green;
                // bring back latest edited color
                picker.Color = Utils.FromStruct(Consts.GlowTeam);
            }
            else
            {
                // enemy mode,
                team_lbl.ForeColor = Color.White;
                enemy_lbl.ForeColor = Color.Green;
                // bring back latest edited color
                picker.Color = Utils.FromStruct(Consts.GlowEnemy);
            }
        }

        private void colorWheel1_ColorChanged(object sender, EventArgs e)
        {
            if (!modeswitch.Checked)
                // team mode
                Consts.GlowTeam = Utils.CreateStruct(picker.Color);
            else
                // enemy mode
                Consts.GlowEnemy = Utils.CreateStruct(picker.Color);
        }
    }
}