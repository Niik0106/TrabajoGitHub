using MaterialSkin;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TrabajoGitHub
{
    public partial class Form1 : MaterialSkin.Controls.MaterialForm
    {
        public Form1()
        {
            InitializeComponent();
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500,
            Accent.LightBlue200, TextShade.WHITE);
        }

        MaterialSkinManager TManager = MaterialSkinManager.Instance;

        private void switchTema_CheckedChanged(object sender, EventArgs e)
        {

            if (switchTema.Checked)
            {
                TManager.Theme = MaterialSkinManager.Themes.DARK;
            }
            else
            {
                TManager.Theme = MaterialSkinManager.Themes.LIGHT;
            }
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {

        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {

        }

        private void btnMostrar2_Click(object sender, EventArgs e)
        {

        }

        private void btnLimpiar2_Click(object sender, EventArgs e)
        {

        }
    }
}
