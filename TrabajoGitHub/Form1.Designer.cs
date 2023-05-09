
namespace TrabajoGitHub
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.materialTabControl1 = new MaterialSkin.Controls.MaterialTabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.switchTema = new MaterialSkin.Controls.MaterialSwitch();
            this.btnMostrar = new MaterialSkin.Controls.MaterialButton();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.txtNumHijos = new MaterialSkin.Controls.MaterialTextBox();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.txtSueldoMensual = new MaterialSkin.Controls.MaterialTextBox();
            this.cboxAFP = new MaterialSkin.Controls.MaterialComboBox();
            this.materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            this.btnLimpiar = new MaterialSkin.Controls.MaterialButton();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel5 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel6 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel7 = new MaterialSkin.Controls.MaterialLabel();
            this.txtRetencionAFP = new MaterialSkin.Controls.MaterialTextBox();
            this.txtAsignacionFamiliar = new MaterialSkin.Controls.MaterialTextBox();
            this.txtRetencionSunat = new MaterialSkin.Controls.MaterialTextBox();
            this.txtSueldoNeto = new MaterialSkin.Controls.MaterialTextBox();
            this.materialLabel8 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel9 = new MaterialSkin.Controls.MaterialLabel();
            this.materialTextBox1 = new MaterialSkin.Controls.MaterialTextBox();
            this.materialTextBox2 = new MaterialSkin.Controls.MaterialTextBox();
            this.btnMostrar2 = new MaterialSkin.Controls.MaterialButton();
            this.btnLimpiar2 = new MaterialSkin.Controls.MaterialButton();
            this.txtSueldoBruto = new MaterialSkin.Controls.MaterialTextBox();
            this.txtRetencionSunat2 = new MaterialSkin.Controls.MaterialTextBox();
            this.txtSueldoNeto2 = new MaterialSkin.Controls.MaterialTextBox();
            this.materialLabel10 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel11 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel12 = new MaterialSkin.Controls.MaterialLabel();
            this.materialTabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.SuspendLayout();
            // 
            // materialTabControl1
            // 
            this.materialTabControl1.Controls.Add(this.tabPage1);
            this.materialTabControl1.Controls.Add(this.tabPage2);
            this.materialTabControl1.Controls.Add(this.tabPage3);
            this.materialTabControl1.Depth = 0;
            this.materialTabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.materialTabControl1.Location = new System.Drawing.Point(3, 64);
            this.materialTabControl1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialTabControl1.Multiline = true;
            this.materialTabControl1.Name = "materialTabControl1";
            this.materialTabControl1.SelectedIndex = 0;
            this.materialTabControl1.Size = new System.Drawing.Size(927, 609);
            this.materialTabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.switchTema);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(919, 583);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Home";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.txtSueldoNeto);
            this.tabPage2.Controls.Add(this.txtRetencionSunat);
            this.tabPage2.Controls.Add(this.txtAsignacionFamiliar);
            this.tabPage2.Controls.Add(this.txtRetencionAFP);
            this.tabPage2.Controls.Add(this.materialLabel7);
            this.tabPage2.Controls.Add(this.materialLabel6);
            this.tabPage2.Controls.Add(this.materialLabel5);
            this.tabPage2.Controls.Add(this.materialLabel1);
            this.tabPage2.Controls.Add(this.btnLimpiar);
            this.tabPage2.Controls.Add(this.materialLabel4);
            this.tabPage2.Controls.Add(this.cboxAFP);
            this.tabPage2.Controls.Add(this.txtSueldoMensual);
            this.tabPage2.Controls.Add(this.materialLabel3);
            this.tabPage2.Controls.Add(this.txtNumHijos);
            this.tabPage2.Controls.Add(this.materialLabel2);
            this.tabPage2.Controls.Add(this.btnMostrar);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(919, 583);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Docente T. Completo";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.materialLabel12);
            this.tabPage3.Controls.Add(this.materialLabel11);
            this.tabPage3.Controls.Add(this.materialLabel10);
            this.tabPage3.Controls.Add(this.txtSueldoNeto2);
            this.tabPage3.Controls.Add(this.txtRetencionSunat2);
            this.tabPage3.Controls.Add(this.txtSueldoBruto);
            this.tabPage3.Controls.Add(this.btnLimpiar2);
            this.tabPage3.Controls.Add(this.btnMostrar2);
            this.tabPage3.Controls.Add(this.materialTextBox2);
            this.tabPage3.Controls.Add(this.materialTextBox1);
            this.tabPage3.Controls.Add(this.materialLabel9);
            this.tabPage3.Controls.Add(this.materialLabel8);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(919, 583);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Docente Horas";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // switchTema
            // 
            this.switchTema.AutoSize = true;
            this.switchTema.Depth = 0;
            this.switchTema.Location = new System.Drawing.Point(379, 264);
            this.switchTema.Margin = new System.Windows.Forms.Padding(0);
            this.switchTema.MouseLocation = new System.Drawing.Point(-1, -1);
            this.switchTema.MouseState = MaterialSkin.MouseState.HOVER;
            this.switchTema.Name = "switchTema";
            this.switchTema.Ripple = true;
            this.switchTema.Size = new System.Drawing.Size(108, 37);
            this.switchTema.TabIndex = 0;
            this.switchTema.Text = "Oscuro";
            this.switchTema.UseVisualStyleBackColor = true;
            this.switchTema.CheckedChanged += new System.EventHandler(this.switchTema_CheckedChanged);
            // 
            // btnMostrar
            // 
            this.btnMostrar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnMostrar.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnMostrar.Depth = 0;
            this.btnMostrar.HighEmphasis = true;
            this.btnMostrar.Icon = null;
            this.btnMostrar.Location = new System.Drawing.Point(319, 413);
            this.btnMostrar.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnMostrar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnMostrar.Name = "btnMostrar";
            this.btnMostrar.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnMostrar.Size = new System.Drawing.Size(90, 36);
            this.btnMostrar.TabIndex = 0;
            this.btnMostrar.Text = "Mostrar";
            this.btnMostrar.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnMostrar.UseAccentColor = false;
            this.btnMostrar.UseVisualStyleBackColor = true;
            this.btnMostrar.Click += new System.EventHandler(this.btnMostrar_Click);
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel2.Location = new System.Drawing.Point(25, 73);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(118, 19);
            this.materialLabel2.TabIndex = 4;
            this.materialLabel2.Text = "Numero de Hijos";
            // 
            // txtNumHijos
            // 
            this.txtNumHijos.AnimateReadOnly = false;
            this.txtNumHijos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNumHijos.Depth = 0;
            this.txtNumHijos.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtNumHijos.LeadingIcon = null;
            this.txtNumHijos.Location = new System.Drawing.Point(178, 54);
            this.txtNumHijos.MaxLength = 50;
            this.txtNumHijos.MouseState = MaterialSkin.MouseState.OUT;
            this.txtNumHijos.Multiline = false;
            this.txtNumHijos.Name = "txtNumHijos";
            this.txtNumHijos.Size = new System.Drawing.Size(231, 50);
            this.txtNumHijos.TabIndex = 5;
            this.txtNumHijos.Text = "";
            this.txtNumHijos.TrailingIcon = null;
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel3.Location = new System.Drawing.Point(28, 165);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(115, 19);
            this.materialLabel3.TabIndex = 6;
            this.materialLabel3.Text = "Sueldo Mensual";
            // 
            // txtSueldoMensual
            // 
            this.txtSueldoMensual.AnimateReadOnly = false;
            this.txtSueldoMensual.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSueldoMensual.Depth = 0;
            this.txtSueldoMensual.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtSueldoMensual.LeadingIcon = null;
            this.txtSueldoMensual.Location = new System.Drawing.Point(178, 151);
            this.txtSueldoMensual.MaxLength = 50;
            this.txtSueldoMensual.MouseState = MaterialSkin.MouseState.OUT;
            this.txtSueldoMensual.Multiline = false;
            this.txtSueldoMensual.Name = "txtSueldoMensual";
            this.txtSueldoMensual.Size = new System.Drawing.Size(231, 50);
            this.txtSueldoMensual.TabIndex = 7;
            this.txtSueldoMensual.Text = "";
            this.txtSueldoMensual.TrailingIcon = null;
            // 
            // cboxAFP
            // 
            this.cboxAFP.AutoResize = false;
            this.cboxAFP.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cboxAFP.Depth = 0;
            this.cboxAFP.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cboxAFP.DropDownHeight = 174;
            this.cboxAFP.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboxAFP.DropDownWidth = 121;
            this.cboxAFP.Font = new System.Drawing.Font("Roboto Medium", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.cboxAFP.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cboxAFP.FormattingEnabled = true;
            this.cboxAFP.IntegralHeight = false;
            this.cboxAFP.ItemHeight = 43;
            this.cboxAFP.Items.AddRange(new object[] {
            "PRIMA",
            "RIMAC",
            "PRO FUTURO"});
            this.cboxAFP.Location = new System.Drawing.Point(178, 235);
            this.cboxAFP.MaxDropDownItems = 4;
            this.cboxAFP.MouseState = MaterialSkin.MouseState.OUT;
            this.cboxAFP.Name = "cboxAFP";
            this.cboxAFP.Size = new System.Drawing.Size(231, 49);
            this.cboxAFP.StartIndex = 0;
            this.cboxAFP.TabIndex = 8;
            // 
            // materialLabel4
            // 
            this.materialLabel4.AutoSize = true;
            this.materialLabel4.Depth = 0;
            this.materialLabel4.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel4.Location = new System.Drawing.Point(28, 238);
            this.materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel4.Name = "materialLabel4";
            this.materialLabel4.Size = new System.Drawing.Size(34, 19);
            this.materialLabel4.TabIndex = 9;
            this.materialLabel4.Text = " AFP";
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnLimpiar.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnLimpiar.Depth = 0;
            this.btnLimpiar.HighEmphasis = true;
            this.btnLimpiar.Icon = null;
            this.btnLimpiar.Location = new System.Drawing.Point(502, 413);
            this.btnLimpiar.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnLimpiar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnLimpiar.Size = new System.Drawing.Size(79, 36);
            this.btnLimpiar.TabIndex = 10;
            this.btnLimpiar.Text = "LIMPIAR";
            this.btnLimpiar.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnLimpiar.UseAccentColor = false;
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel1.Location = new System.Drawing.Point(499, 73);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(104, 19);
            this.materialLabel1.TabIndex = 11;
            this.materialLabel1.Text = "Retencion AFP";
            // 
            // materialLabel5
            // 
            this.materialLabel5.AutoSize = true;
            this.materialLabel5.Depth = 0;
            this.materialLabel5.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel5.Location = new System.Drawing.Point(499, 165);
            this.materialLabel5.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel5.Name = "materialLabel5";
            this.materialLabel5.Size = new System.Drawing.Size(167, 19);
            this.materialLabel5.TabIndex = 12;
            this.materialLabel5.Text = "ASIGNACION FAMILIAR";
            // 
            // materialLabel6
            // 
            this.materialLabel6.AutoSize = true;
            this.materialLabel6.Depth = 0;
            this.materialLabel6.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel6.Location = new System.Drawing.Point(502, 251);
            this.materialLabel6.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel6.Name = "materialLabel6";
            this.materialLabel6.Size = new System.Drawing.Size(141, 19);
            this.materialLabel6.TabIndex = 13;
            this.materialLabel6.Text = "RETENCION SUNAT";
            // 
            // materialLabel7
            // 
            this.materialLabel7.AutoSize = true;
            this.materialLabel7.Depth = 0;
            this.materialLabel7.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel7.Location = new System.Drawing.Point(502, 322);
            this.materialLabel7.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel7.Name = "materialLabel7";
            this.materialLabel7.Size = new System.Drawing.Size(106, 19);
            this.materialLabel7.TabIndex = 14;
            this.materialLabel7.Text = "SUELDO NETO";
            // 
            // txtRetencionAFP
            // 
            this.txtRetencionAFP.AnimateReadOnly = false;
            this.txtRetencionAFP.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtRetencionAFP.Depth = 0;
            this.txtRetencionAFP.Enabled = false;
            this.txtRetencionAFP.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtRetencionAFP.LeadingIcon = null;
            this.txtRetencionAFP.Location = new System.Drawing.Point(656, 54);
            this.txtRetencionAFP.MaxLength = 50;
            this.txtRetencionAFP.MouseState = MaterialSkin.MouseState.OUT;
            this.txtRetencionAFP.Multiline = false;
            this.txtRetencionAFP.Name = "txtRetencionAFP";
            this.txtRetencionAFP.Size = new System.Drawing.Size(213, 50);
            this.txtRetencionAFP.TabIndex = 15;
            this.txtRetencionAFP.Text = "";
            this.txtRetencionAFP.TrailingIcon = null;
            // 
            // txtAsignacionFamiliar
            // 
            this.txtAsignacionFamiliar.AnimateReadOnly = false;
            this.txtAsignacionFamiliar.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtAsignacionFamiliar.Depth = 0;
            this.txtAsignacionFamiliar.Enabled = false;
            this.txtAsignacionFamiliar.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtAsignacionFamiliar.LeadingIcon = null;
            this.txtAsignacionFamiliar.Location = new System.Drawing.Point(688, 151);
            this.txtAsignacionFamiliar.MaxLength = 50;
            this.txtAsignacionFamiliar.MouseState = MaterialSkin.MouseState.OUT;
            this.txtAsignacionFamiliar.Multiline = false;
            this.txtAsignacionFamiliar.Name = "txtAsignacionFamiliar";
            this.txtAsignacionFamiliar.Size = new System.Drawing.Size(181, 50);
            this.txtAsignacionFamiliar.TabIndex = 16;
            this.txtAsignacionFamiliar.Text = "";
            this.txtAsignacionFamiliar.TrailingIcon = null;
            // 
            // txtRetencionSunat
            // 
            this.txtRetencionSunat.AnimateReadOnly = false;
            this.txtRetencionSunat.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtRetencionSunat.Depth = 0;
            this.txtRetencionSunat.Enabled = false;
            this.txtRetencionSunat.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtRetencionSunat.LeadingIcon = null;
            this.txtRetencionSunat.Location = new System.Drawing.Point(688, 234);
            this.txtRetencionSunat.MaxLength = 50;
            this.txtRetencionSunat.MouseState = MaterialSkin.MouseState.OUT;
            this.txtRetencionSunat.Multiline = false;
            this.txtRetencionSunat.Name = "txtRetencionSunat";
            this.txtRetencionSunat.Size = new System.Drawing.Size(181, 50);
            this.txtRetencionSunat.TabIndex = 17;
            this.txtRetencionSunat.Text = "";
            this.txtRetencionSunat.TrailingIcon = null;
            // 
            // txtSueldoNeto
            // 
            this.txtSueldoNeto.AnimateReadOnly = false;
            this.txtSueldoNeto.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSueldoNeto.Depth = 0;
            this.txtSueldoNeto.Enabled = false;
            this.txtSueldoNeto.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtSueldoNeto.LeadingIcon = null;
            this.txtSueldoNeto.Location = new System.Drawing.Point(656, 309);
            this.txtSueldoNeto.MaxLength = 50;
            this.txtSueldoNeto.MouseState = MaterialSkin.MouseState.OUT;
            this.txtSueldoNeto.Multiline = false;
            this.txtSueldoNeto.Name = "txtSueldoNeto";
            this.txtSueldoNeto.Size = new System.Drawing.Size(213, 50);
            this.txtSueldoNeto.TabIndex = 18;
            this.txtSueldoNeto.Text = "";
            this.txtSueldoNeto.TrailingIcon = null;
            // 
            // materialLabel8
            // 
            this.materialLabel8.AutoSize = true;
            this.materialLabel8.Depth = 0;
            this.materialLabel8.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel8.Location = new System.Drawing.Point(226, 45);
            this.materialLabel8.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel8.Name = "materialLabel8";
            this.materialLabel8.Size = new System.Drawing.Size(157, 19);
            this.materialLabel8.TabIndex = 0;
            this.materialLabel8.Text = "HORAS TRABAJADAS";
            // 
            // materialLabel9
            // 
            this.materialLabel9.AutoSize = true;
            this.materialLabel9.Depth = 0;
            this.materialLabel9.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel9.Location = new System.Drawing.Point(226, 119);
            this.materialLabel9.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel9.Name = "materialLabel9";
            this.materialLabel9.Size = new System.Drawing.Size(136, 19);
            this.materialLabel9.TabIndex = 1;
            this.materialLabel9.Text = "PRECIO POR HORA";
            // 
            // materialTextBox1
            // 
            this.materialTextBox1.AnimateReadOnly = false;
            this.materialTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.materialTextBox1.Depth = 0;
            this.materialTextBox1.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialTextBox1.LeadingIcon = null;
            this.materialTextBox1.Location = new System.Drawing.Point(415, 30);
            this.materialTextBox1.MaxLength = 50;
            this.materialTextBox1.MouseState = MaterialSkin.MouseState.OUT;
            this.materialTextBox1.Multiline = false;
            this.materialTextBox1.Name = "materialTextBox1";
            this.materialTextBox1.Size = new System.Drawing.Size(229, 50);
            this.materialTextBox1.TabIndex = 2;
            this.materialTextBox1.Text = "";
            this.materialTextBox1.TrailingIcon = null;
            // 
            // materialTextBox2
            // 
            this.materialTextBox2.AnimateReadOnly = false;
            this.materialTextBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.materialTextBox2.Depth = 0;
            this.materialTextBox2.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialTextBox2.LeadingIcon = null;
            this.materialTextBox2.Location = new System.Drawing.Point(415, 104);
            this.materialTextBox2.MaxLength = 50;
            this.materialTextBox2.MouseState = MaterialSkin.MouseState.OUT;
            this.materialTextBox2.Multiline = false;
            this.materialTextBox2.Name = "materialTextBox2";
            this.materialTextBox2.Size = new System.Drawing.Size(229, 50);
            this.materialTextBox2.TabIndex = 3;
            this.materialTextBox2.Text = "";
            this.materialTextBox2.TrailingIcon = null;
            // 
            // btnMostrar2
            // 
            this.btnMostrar2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnMostrar2.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnMostrar2.Depth = 0;
            this.btnMostrar2.HighEmphasis = true;
            this.btnMostrar2.Icon = null;
            this.btnMostrar2.Location = new System.Drawing.Point(296, 229);
            this.btnMostrar2.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnMostrar2.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnMostrar2.Name = "btnMostrar2";
            this.btnMostrar2.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnMostrar2.Size = new System.Drawing.Size(90, 36);
            this.btnMostrar2.TabIndex = 4;
            this.btnMostrar2.Text = "MOSTRAR";
            this.btnMostrar2.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnMostrar2.UseAccentColor = false;
            this.btnMostrar2.UseVisualStyleBackColor = true;
            this.btnMostrar2.Click += new System.EventHandler(this.btnMostrar2_Click);
            // 
            // btnLimpiar2
            // 
            this.btnLimpiar2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnLimpiar2.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnLimpiar2.Depth = 0;
            this.btnLimpiar2.HighEmphasis = true;
            this.btnLimpiar2.Icon = null;
            this.btnLimpiar2.Location = new System.Drawing.Point(559, 229);
            this.btnLimpiar2.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnLimpiar2.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnLimpiar2.Name = "btnLimpiar2";
            this.btnLimpiar2.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnLimpiar2.Size = new System.Drawing.Size(79, 36);
            this.btnLimpiar2.TabIndex = 5;
            this.btnLimpiar2.Text = "LIMPIAR";
            this.btnLimpiar2.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnLimpiar2.UseAccentColor = false;
            this.btnLimpiar2.UseVisualStyleBackColor = true;
            this.btnLimpiar2.Click += new System.EventHandler(this.btnLimpiar2_Click);
            // 
            // txtSueldoBruto
            // 
            this.txtSueldoBruto.AnimateReadOnly = false;
            this.txtSueldoBruto.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSueldoBruto.Depth = 0;
            this.txtSueldoBruto.Enabled = false;
            this.txtSueldoBruto.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtSueldoBruto.LeadingIcon = null;
            this.txtSueldoBruto.Location = new System.Drawing.Point(415, 290);
            this.txtSueldoBruto.MaxLength = 50;
            this.txtSueldoBruto.MouseState = MaterialSkin.MouseState.OUT;
            this.txtSueldoBruto.Multiline = false;
            this.txtSueldoBruto.Name = "txtSueldoBruto";
            this.txtSueldoBruto.Size = new System.Drawing.Size(229, 50);
            this.txtSueldoBruto.TabIndex = 6;
            this.txtSueldoBruto.Text = "";
            this.txtSueldoBruto.TrailingIcon = null;
            // 
            // txtRetencionSunat2
            // 
            this.txtRetencionSunat2.AnimateReadOnly = false;
            this.txtRetencionSunat2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtRetencionSunat2.Depth = 0;
            this.txtRetencionSunat2.Enabled = false;
            this.txtRetencionSunat2.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtRetencionSunat2.LeadingIcon = null;
            this.txtRetencionSunat2.Location = new System.Drawing.Point(415, 368);
            this.txtRetencionSunat2.MaxLength = 50;
            this.txtRetencionSunat2.MouseState = MaterialSkin.MouseState.OUT;
            this.txtRetencionSunat2.Multiline = false;
            this.txtRetencionSunat2.Name = "txtRetencionSunat2";
            this.txtRetencionSunat2.Size = new System.Drawing.Size(229, 50);
            this.txtRetencionSunat2.TabIndex = 7;
            this.txtRetencionSunat2.Text = "";
            this.txtRetencionSunat2.TrailingIcon = null;
            // 
            // txtSueldoNeto2
            // 
            this.txtSueldoNeto2.AnimateReadOnly = false;
            this.txtSueldoNeto2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSueldoNeto2.Depth = 0;
            this.txtSueldoNeto2.Enabled = false;
            this.txtSueldoNeto2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtSueldoNeto2.LeadingIcon = null;
            this.txtSueldoNeto2.Location = new System.Drawing.Point(415, 444);
            this.txtSueldoNeto2.MaxLength = 50;
            this.txtSueldoNeto2.MouseState = MaterialSkin.MouseState.OUT;
            this.txtSueldoNeto2.Multiline = false;
            this.txtSueldoNeto2.Name = "txtSueldoNeto2";
            this.txtSueldoNeto2.Size = new System.Drawing.Size(229, 50);
            this.txtSueldoNeto2.TabIndex = 8;
            this.txtSueldoNeto2.Text = "";
            this.txtSueldoNeto2.TrailingIcon = null;
            // 
            // materialLabel10
            // 
            this.materialLabel10.AutoSize = true;
            this.materialLabel10.Depth = 0;
            this.materialLabel10.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel10.Location = new System.Drawing.Point(229, 310);
            this.materialLabel10.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel10.Name = "materialLabel10";
            this.materialLabel10.Size = new System.Drawing.Size(116, 19);
            this.materialLabel10.TabIndex = 9;
            this.materialLabel10.Text = "SUELDO BRUTO";
            // 
            // materialLabel11
            // 
            this.materialLabel11.AutoSize = true;
            this.materialLabel11.Depth = 0;
            this.materialLabel11.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel11.Location = new System.Drawing.Point(229, 386);
            this.materialLabel11.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel11.Name = "materialLabel11";
            this.materialLabel11.Size = new System.Drawing.Size(141, 19);
            this.materialLabel11.TabIndex = 10;
            this.materialLabel11.Text = "RETENCION SUNAT";
            // 
            // materialLabel12
            // 
            this.materialLabel12.AutoSize = true;
            this.materialLabel12.Depth = 0;
            this.materialLabel12.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel12.Location = new System.Drawing.Point(232, 457);
            this.materialLabel12.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel12.Name = "materialLabel12";
            this.materialLabel12.Size = new System.Drawing.Size(106, 19);
            this.materialLabel12.TabIndex = 11;
            this.materialLabel12.Text = "SUELDO NETO";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(933, 676);
            this.Controls.Add(this.materialTabControl1);
            this.DrawerTabControl = this.materialTabControl1;
            this.Name = "Form1";
            this.Text = "CALCULAR SUELDO DOCENTES";
            this.materialTabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialSkin.Controls.MaterialTabControl materialTabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private MaterialSkin.Controls.MaterialSwitch switchTema;
        private MaterialSkin.Controls.MaterialButton btnMostrar;
        private MaterialSkin.Controls.MaterialTextBox txtNumHijos;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialTextBox txtSueldoMensual;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private MaterialSkin.Controls.MaterialLabel materialLabel4;
        private MaterialSkin.Controls.MaterialComboBox cboxAFP;
        private MaterialSkin.Controls.MaterialButton btnLimpiar;
        private MaterialSkin.Controls.MaterialTextBox txtSueldoNeto;
        private MaterialSkin.Controls.MaterialTextBox txtRetencionSunat;
        private MaterialSkin.Controls.MaterialTextBox txtAsignacionFamiliar;
        private MaterialSkin.Controls.MaterialTextBox txtRetencionAFP;
        private MaterialSkin.Controls.MaterialLabel materialLabel7;
        private MaterialSkin.Controls.MaterialLabel materialLabel6;
        private MaterialSkin.Controls.MaterialLabel materialLabel5;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialTextBox materialTextBox2;
        private MaterialSkin.Controls.MaterialTextBox materialTextBox1;
        private MaterialSkin.Controls.MaterialLabel materialLabel9;
        private MaterialSkin.Controls.MaterialLabel materialLabel8;
        private MaterialSkin.Controls.MaterialLabel materialLabel12;
        private MaterialSkin.Controls.MaterialLabel materialLabel11;
        private MaterialSkin.Controls.MaterialLabel materialLabel10;
        private MaterialSkin.Controls.MaterialTextBox txtSueldoNeto2;
        private MaterialSkin.Controls.MaterialTextBox txtRetencionSunat2;
        private MaterialSkin.Controls.MaterialTextBox txtSueldoBruto;
        private MaterialSkin.Controls.MaterialButton btnLimpiar2;
        private MaterialSkin.Controls.MaterialButton btnMostrar2;
    }
}

