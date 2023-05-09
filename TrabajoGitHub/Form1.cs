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
                double sueldo = double.Parse(txtSueldoMensual.Text); 
                int hijos = int.Parse(txtNumHijos.Text);
                double hijo;
                double retencionAFP, retencionSunat, sueldoNeto = 0;
                string op = cboxAFP.Text;
                hijo = Asignacion(hijos);
                retencionAFP = RetencionAFP(op, sueldo);
                retencionSunat = RetencionSunat(sueldo);
                sueldoNeto = SueldoNeto(hijo, sueldoNeto, retencionAFP, retencionSunat);
                txtRetencionAFP.Text = retencionAFP.ToString();
                txtAsignacionFamiliar.Text = hijo.ToString();
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


        public double Asignacion(int hijos)
        {
            double asignacion_f;
            if (hijos > 0)
            {
                asignacion_f = 100;
            }
            else
                asignacion_f = 0;
            return asignacion_f;
        }

        public double RetencionAFP(string op, double sueldo)
        {
            double retencionafp = 0;
            switch (op)
            {
                case "PRIMA": retencionafp = 0.13 * sueldo;
                    break;
                case "RIMAC": retencionafp = 0.115 * sueldo;
                    break;
                case "PROFOTURO": retencionafp = 0.124 * sueldo;
                    break;
            }
            return retencionafp;
        }




        public double RetencionSunat(double sueldo)
        {
            double r_sunat = 0;
            if (sueldo > 3500)
            {
                r_sunat = (sueldo - 3500) * 0.15;
            }
            return r_sunat;
        }

        public double SueldoNeto(double hijo, double sueldo, double retencionAFP, double retencionSunat)
        {
            double sueldoneto = 0;
            sueldoneto = (sueldo - retencionSunat - retencionAFP + hijo);
            return sueldoneto;
        }

        private void btnMostrar2_Click(object sender, EventArgs e)
        {
            try
            {
                


            }
            catch
            {

            }

        }

        private void btnLimpiar2_Click(object sender, EventArgs e)
        {

        }

      
    }
}
