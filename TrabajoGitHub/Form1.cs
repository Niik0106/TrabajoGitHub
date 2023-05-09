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
            try
            {
                double hijo;
                double retencionAFP, retencionSunat, sueldoNeto;
                string op = cboxAFP.Text;
                hijo = AsignacionF(hijos);
                retencionAFP = RetencionAFP(op, sueldo);
                retencionSunat = RetencionSunat(sueldo);
                sueldoNeto = SueldoNeto(hijo, sueldoNeto, retencionAFP, retencionSunat);
                txtRetencionAFP.Text = retencionAFP.ToString();
                txtAsignacionFamiliar = hijo.ToString();
                txtRetencionSunat.Text = retencionSunat.ToString();
                txtSueldoNeto.Text = sueldoNeto.ToString();
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "ERROR CAMPOS VACIOS", "ADVERTENCIA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNumHijos.Clear();
                txtSueldoMensual.Clear();
                txtNumHijos.Focus();
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtNumHijos.Clear();
            txtSueldoMensual.Clear();
            txtRetencionSunat.Clear();
            txtAsignacionFamiliar.Clear();
            txtRetencionAFP.Clear();
            txtSueldoNeto.Clear();
            txtNumHijos.Focus();
        }

        private void btnMostrar2_Click(object sender, EventArgs e)
        {

        }

        private void btnLimpiar2_Click(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }
    }
}
