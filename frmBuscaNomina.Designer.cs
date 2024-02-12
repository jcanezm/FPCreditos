namespace FPcreditos
{
    partial class frmBuscaNomina
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
            this.rdoEspecifico = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.cboPeriodoF = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cboPeriodo = new System.Windows.Forms.ComboBox();
            this.chckPeriodo = new System.Windows.Forms.CheckBox();
            this.cboOrg = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cboLoc = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.rdoOrg = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.rdoLoc = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvNominas = new System.Windows.Forms.DataGridView();
            this.cmdChecked = new System.Windows.Forms.Button();
            this.cmdFiltro = new System.Windows.Forms.Button();
            this.cboSeccion = new System.Windows.Forms.ComboBox();
            this.gpoBusqueda1 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.gpoBusqueda2 = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.cboTipoSeccionFiltro = new System.Windows.Forms.ComboBox();
            this.cboPeriodoBusqueda2 = new System.Windows.Forms.ComboBox();
            this.cboTipoPeriodo = new System.Windows.Forms.ComboBox();
            this.rdoFiltroPorPeriodo = new System.Windows.Forms.RadioButton();
            this.rdoUltimosQuince = new System.Windows.Forms.RadioButton();
            this.label5 = new System.Windows.Forms.Label();
            this.rdoBusqueda1 = new System.Windows.Forms.RadioButton();
            this.rdoBusqueda2 = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNominas)).BeginInit();
            this.gpoBusqueda1.SuspendLayout();
            this.gpoBusqueda2.SuspendLayout();
            this.SuspendLayout();
            // 
            // rdoEspecifico
            // 
            this.rdoEspecifico.AutoSize = true;
            this.rdoEspecifico.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoEspecifico.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.rdoEspecifico.Location = new System.Drawing.Point(293, 22);
            this.rdoEspecifico.Name = "rdoEspecifico";
            this.rdoEspecifico.Size = new System.Drawing.Size(87, 22);
            this.rdoEspecifico.TabIndex = 76;
            this.rdoEspecifico.Text = "Especifico";
            this.rdoEspecifico.UseVisualStyleBackColor = true;
            this.rdoEspecifico.CheckedChanged += new System.EventHandler(this.rdoEspecifico_CheckedChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(420, 75);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 18);
            this.label4.TabIndex = 75;
            this.label4.Text = "Hasta:";
            // 
            // cboPeriodoF
            // 
            this.cboPeriodoF.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboPeriodoF.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboPeriodoF.ForeColor = System.Drawing.Color.Black;
            this.cboPeriodoF.FormattingEnabled = true;
            this.cboPeriodoF.Location = new System.Drawing.Point(488, 72);
            this.cboPeriodoF.Name = "cboPeriodoF";
            this.cboPeriodoF.Size = new System.Drawing.Size(148, 26);
            this.cboPeriodoF.TabIndex = 74;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(420, 51);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 18);
            this.label3.TabIndex = 73;
            this.label3.Text = "Periodo:";
            // 
            // cboPeriodo
            // 
            this.cboPeriodo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboPeriodo.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboPeriodo.ForeColor = System.Drawing.Color.Black;
            this.cboPeriodo.FormattingEnabled = true;
            this.cboPeriodo.Location = new System.Drawing.Point(488, 48);
            this.cboPeriodo.Name = "cboPeriodo";
            this.cboPeriodo.Size = new System.Drawing.Size(148, 26);
            this.cboPeriodo.TabIndex = 72;
            // 
            // chckPeriodo
            // 
            this.chckPeriodo.AutoSize = true;
            this.chckPeriodo.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chckPeriodo.ForeColor = System.Drawing.Color.Red;
            this.chckPeriodo.Location = new System.Drawing.Point(488, 26);
            this.chckPeriodo.Name = "chckPeriodo";
            this.chckPeriodo.Size = new System.Drawing.Size(122, 22);
            this.chckPeriodo.TabIndex = 71;
            this.chckPeriodo.Text = "Activar Periodo";
            this.chckPeriodo.UseVisualStyleBackColor = true;
            this.chckPeriodo.CheckedChanged += new System.EventHandler(this.chckPeriodo_CheckedChanged);
            // 
            // cboOrg
            // 
            this.cboOrg.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboOrg.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboOrg.FormattingEnabled = true;
            this.cboOrg.Location = new System.Drawing.Point(104, 71);
            this.cboOrg.Name = "cboOrg";
            this.cboOrg.Size = new System.Drawing.Size(304, 26);
            this.cboOrg.TabIndex = 67;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label6.Location = new System.Drawing.Point(13, 72);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(79, 18);
            this.label6.TabIndex = 69;
            this.label6.Text = "Organismo:";
            // 
            // cboLoc
            // 
            this.cboLoc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboLoc.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboLoc.FormattingEnabled = true;
            this.cboLoc.Location = new System.Drawing.Point(104, 47);
            this.cboLoc.Name = "cboLoc";
            this.cboLoc.Size = new System.Drawing.Size(304, 26);
            this.cboLoc.TabIndex = 70;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label9.Location = new System.Drawing.Point(13, 48);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(70, 18);
            this.label9.TabIndex = 68;
            this.label9.Text = "Localidad:";
            // 
            // rdoOrg
            // 
            this.rdoOrg.AutoSize = true;
            this.rdoOrg.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoOrg.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.rdoOrg.Location = new System.Drawing.Point(194, 22);
            this.rdoOrg.Name = "rdoOrg";
            this.rdoOrg.Size = new System.Drawing.Size(93, 22);
            this.rdoOrg.TabIndex = 66;
            this.rdoOrg.Text = "Organismo";
            this.rdoOrg.UseVisualStyleBackColor = true;
            this.rdoOrg.CheckedChanged += new System.EventHandler(this.rdoOrg_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DarkCyan;
            this.label2.Location = new System.Drawing.Point(13, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 18);
            this.label2.TabIndex = 65;
            this.label2.Text = "Filtrar por:";
            // 
            // rdoLoc
            // 
            this.rdoLoc.AutoSize = true;
            this.rdoLoc.Checked = true;
            this.rdoLoc.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoLoc.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.rdoLoc.Location = new System.Drawing.Point(104, 22);
            this.rdoLoc.Name = "rdoLoc";
            this.rdoLoc.Size = new System.Drawing.Size(84, 22);
            this.rdoLoc.TabIndex = 63;
            this.rdoLoc.TabStop = true;
            this.rdoLoc.Text = "Localidad";
            this.rdoLoc.UseVisualStyleBackColor = true;
            this.rdoLoc.CheckedChanged += new System.EventHandler(this.rdoLoc_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(189, 18);
            this.label1.TabIndex = 62;
            this.label1.Text = "Selecciona tipo de Busqueda:";
            // 
            // dgvNominas
            // 
            this.dgvNominas.AllowUserToAddRows = false;
            this.dgvNominas.AllowUserToDeleteRows = false;
            this.dgvNominas.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvNominas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNominas.Location = new System.Drawing.Point(12, 216);
            this.dgvNominas.Name = "dgvNominas";
            this.dgvNominas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvNominas.Size = new System.Drawing.Size(1093, 376);
            this.dgvNominas.TabIndex = 78;
            // 
            // cmdChecked
            // 
            this.cmdChecked.BackColor = System.Drawing.Color.White;
            this.cmdChecked.BackgroundImage = global::FPcreditos.Properties.Resources.visto;
            this.cmdChecked.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.cmdChecked.Location = new System.Drawing.Point(1038, 144);
            this.cmdChecked.Name = "cmdChecked";
            this.cmdChecked.Size = new System.Drawing.Size(64, 66);
            this.cmdChecked.TabIndex = 77;
            this.cmdChecked.UseVisualStyleBackColor = false;
            this.cmdChecked.Click += new System.EventHandler(this.cmdChecked_Click);
            // 
            // cmdFiltro
            // 
            this.cmdFiltro.BackColor = System.Drawing.Color.LightCyan;
            this.cmdFiltro.BackgroundImage = global::FPcreditos.Properties.Resources._81088;
            this.cmdFiltro.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.cmdFiltro.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdFiltro.Location = new System.Drawing.Point(1037, 38);
            this.cmdFiltro.Name = "cmdFiltro";
            this.cmdFiltro.Size = new System.Drawing.Size(65, 66);
            this.cmdFiltro.TabIndex = 64;
            this.cmdFiltro.UseVisualStyleBackColor = false;
            this.cmdFiltro.Click += new System.EventHandler(this.cmdFiltro_Click);
            // 
            // cboSeccion
            // 
            this.cboSeccion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboSeccion.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboSeccion.ForeColor = System.Drawing.Color.Black;
            this.cboSeccion.FormattingEnabled = true;
            this.cboSeccion.Items.AddRange(new object[] {
            "TODOS",
            "RETENCION",
            "RECURSOS PROPIOS",
            "EVENTUALES",
            "OTROS"});
            this.cboSeccion.Location = new System.Drawing.Point(723, 47);
            this.cboSeccion.Name = "cboSeccion";
            this.cboSeccion.Size = new System.Drawing.Size(148, 26);
            this.cboSeccion.TabIndex = 80;
            // 
            // gpoBusqueda1
            // 
            this.gpoBusqueda1.Controls.Add(this.label7);
            this.gpoBusqueda1.Controls.Add(this.cboLoc);
            this.gpoBusqueda1.Controls.Add(this.cboSeccion);
            this.gpoBusqueda1.Controls.Add(this.rdoLoc);
            this.gpoBusqueda1.Controls.Add(this.label2);
            this.gpoBusqueda1.Controls.Add(this.rdoOrg);
            this.gpoBusqueda1.Controls.Add(this.label9);
            this.gpoBusqueda1.Controls.Add(this.label6);
            this.gpoBusqueda1.Controls.Add(this.label4);
            this.gpoBusqueda1.Controls.Add(this.rdoEspecifico);
            this.gpoBusqueda1.Controls.Add(this.cboPeriodoF);
            this.gpoBusqueda1.Controls.Add(this.label3);
            this.gpoBusqueda1.Controls.Add(this.cboOrg);
            this.gpoBusqueda1.Controls.Add(this.cboPeriodo);
            this.gpoBusqueda1.Controls.Add(this.chckPeriodo);
            this.gpoBusqueda1.Enabled = false;
            this.gpoBusqueda1.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpoBusqueda1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.gpoBusqueda1.Location = new System.Drawing.Point(15, 35);
            this.gpoBusqueda1.Name = "gpoBusqueda1";
            this.gpoBusqueda1.Size = new System.Drawing.Size(1017, 105);
            this.gpoBusqueda1.TabIndex = 83;
            this.gpoBusqueda1.TabStop = false;
            this.gpoBusqueda1.Text = "BUSQUEDA 1";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label7.Location = new System.Drawing.Point(658, 50);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(59, 18);
            this.label7.TabIndex = 81;
            this.label7.Text = "Sección:";
            // 
            // gpoBusqueda2
            // 
            this.gpoBusqueda2.Controls.Add(this.label8);
            this.gpoBusqueda2.Controls.Add(this.cboTipoSeccionFiltro);
            this.gpoBusqueda2.Controls.Add(this.cboPeriodoBusqueda2);
            this.gpoBusqueda2.Controls.Add(this.cboTipoPeriodo);
            this.gpoBusqueda2.Controls.Add(this.rdoFiltroPorPeriodo);
            this.gpoBusqueda2.Controls.Add(this.rdoUltimosQuince);
            this.gpoBusqueda2.Controls.Add(this.label5);
            this.gpoBusqueda2.Enabled = false;
            this.gpoBusqueda2.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpoBusqueda2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.gpoBusqueda2.Location = new System.Drawing.Point(15, 146);
            this.gpoBusqueda2.Name = "gpoBusqueda2";
            this.gpoBusqueda2.Size = new System.Drawing.Size(1017, 64);
            this.gpoBusqueda2.TabIndex = 84;
            this.gpoBusqueda2.TabStop = false;
            this.gpoBusqueda2.Text = "BUSQUEDA 2";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label8.Location = new System.Drawing.Point(768, 26);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(59, 18);
            this.label8.TabIndex = 83;
            this.label8.Text = "Sección:";
            // 
            // cboTipoSeccionFiltro
            // 
            this.cboTipoSeccionFiltro.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTipoSeccionFiltro.Enabled = false;
            this.cboTipoSeccionFiltro.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboTipoSeccionFiltro.ForeColor = System.Drawing.Color.Black;
            this.cboTipoSeccionFiltro.FormattingEnabled = true;
            this.cboTipoSeccionFiltro.Items.AddRange(new object[] {
            "TODOS",
            "RETENCION",
            "RECURSOS PROPIOS",
            "EVENTUALES",
            "OTROS"});
            this.cboTipoSeccionFiltro.Location = new System.Drawing.Point(833, 23);
            this.cboTipoSeccionFiltro.Name = "cboTipoSeccionFiltro";
            this.cboTipoSeccionFiltro.Size = new System.Drawing.Size(135, 26);
            this.cboTipoSeccionFiltro.TabIndex = 81;
            // 
            // cboPeriodoBusqueda2
            // 
            this.cboPeriodoBusqueda2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboPeriodoBusqueda2.Enabled = false;
            this.cboPeriodoBusqueda2.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboPeriodoBusqueda2.ForeColor = System.Drawing.Color.Black;
            this.cboPeriodoBusqueda2.FormattingEnabled = true;
            this.cboPeriodoBusqueda2.Location = new System.Drawing.Point(457, 24);
            this.cboPeriodoBusqueda2.Name = "cboPeriodoBusqueda2";
            this.cboPeriodoBusqueda2.Size = new System.Drawing.Size(122, 26);
            this.cboPeriodoBusqueda2.TabIndex = 81;
            // 
            // cboTipoPeriodo
            // 
            this.cboTipoPeriodo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTipoPeriodo.Enabled = false;
            this.cboTipoPeriodo.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboTipoPeriodo.ForeColor = System.Drawing.Color.Black;
            this.cboTipoPeriodo.FormattingEnabled = true;
            this.cboTipoPeriodo.Items.AddRange(new object[] {
            "TODOS",
            "AYUNTAMIENTOS",
            "ORGANISMOS"});
            this.cboTipoPeriodo.Location = new System.Drawing.Point(585, 24);
            this.cboTipoPeriodo.Name = "cboTipoPeriodo";
            this.cboTipoPeriodo.Size = new System.Drawing.Size(148, 26);
            this.cboTipoPeriodo.TabIndex = 81;
            // 
            // rdoFiltroPorPeriodo
            // 
            this.rdoFiltroPorPeriodo.AutoSize = true;
            this.rdoFiltroPorPeriodo.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoFiltroPorPeriodo.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.rdoFiltroPorPeriodo.Location = new System.Drawing.Point(312, 25);
            this.rdoFiltroPorPeriodo.Name = "rdoFiltroPorPeriodo";
            this.rdoFiltroPorPeriodo.Size = new System.Drawing.Size(139, 22);
            this.rdoFiltroPorPeriodo.TabIndex = 82;
            this.rdoFiltroPorPeriodo.Text = "Filtrar Por Periodo";
            this.rdoFiltroPorPeriodo.UseVisualStyleBackColor = true;
            this.rdoFiltroPorPeriodo.CheckedChanged += new System.EventHandler(this.rdoFiltroPorPeriodo_CheckedChanged);
            // 
            // rdoUltimosQuince
            // 
            this.rdoUltimosQuince.AutoSize = true;
            this.rdoUltimosQuince.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoUltimosQuince.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.rdoUltimosQuince.Location = new System.Drawing.Point(104, 25);
            this.rdoUltimosQuince.Name = "rdoUltimosQuince";
            this.rdoUltimosQuince.Size = new System.Drawing.Size(185, 22);
            this.rdoUltimosQuince.TabIndex = 81;
            this.rdoUltimosQuince.Text = "Ultimos Quince Liberados";
            this.rdoUltimosQuince.UseVisualStyleBackColor = true;
            this.rdoUltimosQuince.CheckedChanged += new System.EventHandler(this.rdoUltimosQuince_CheckedChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.DarkCyan;
            this.label5.Location = new System.Drawing.Point(13, 27);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 18);
            this.label5.TabIndex = 81;
            this.label5.Text = "Filtrar por:";
            // 
            // rdoBusqueda1
            // 
            this.rdoBusqueda1.AutoSize = true;
            this.rdoBusqueda1.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoBusqueda1.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.rdoBusqueda1.Location = new System.Drawing.Point(207, 7);
            this.rdoBusqueda1.Name = "rdoBusqueda1";
            this.rdoBusqueda1.Size = new System.Drawing.Size(97, 22);
            this.rdoBusqueda1.TabIndex = 81;
            this.rdoBusqueda1.Text = "Busqueda 1";
            this.rdoBusqueda1.UseVisualStyleBackColor = true;
            this.rdoBusqueda1.CheckedChanged += new System.EventHandler(this.rdoBusqueda1_CheckedChanged);
            // 
            // rdoBusqueda2
            // 
            this.rdoBusqueda2.AutoSize = true;
            this.rdoBusqueda2.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoBusqueda2.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.rdoBusqueda2.Location = new System.Drawing.Point(310, 7);
            this.rdoBusqueda2.Name = "rdoBusqueda2";
            this.rdoBusqueda2.Size = new System.Drawing.Size(97, 22);
            this.rdoBusqueda2.TabIndex = 85;
            this.rdoBusqueda2.Text = "Busqueda 2";
            this.rdoBusqueda2.UseVisualStyleBackColor = true;
            this.rdoBusqueda2.CheckedChanged += new System.EventHandler(this.rdoBusqueda2_CheckedChanged);
            // 
            // frmBuscaNomina
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SkyBlue;
            this.ClientSize = new System.Drawing.Size(1115, 604);
            this.Controls.Add(this.rdoBusqueda2);
            this.Controls.Add(this.rdoBusqueda1);
            this.Controls.Add(this.gpoBusqueda2);
            this.Controls.Add(this.gpoBusqueda1);
            this.Controls.Add(this.dgvNominas);
            this.Controls.Add(this.cmdChecked);
            this.Controls.Add(this.cmdFiltro);
            this.Controls.Add(this.label1);
            this.Name = "frmBuscaNomina";
            this.Text = "Busca Nóminas Liberadas";
            this.Load += new System.EventHandler(this.frmBuscaNomina_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvNominas)).EndInit();
            this.gpoBusqueda1.ResumeLayout(false);
            this.gpoBusqueda1.PerformLayout();
            this.gpoBusqueda2.ResumeLayout(false);
            this.gpoBusqueda2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rdoEspecifico;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cboPeriodoF;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cboPeriodo;
        private System.Windows.Forms.CheckBox chckPeriodo;
        private System.Windows.Forms.ComboBox cboOrg;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cboLoc;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.RadioButton rdoOrg;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button cmdFiltro;
        private System.Windows.Forms.RadioButton rdoLoc;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button cmdChecked;
        private System.Windows.Forms.DataGridView dgvNominas;
        private System.Windows.Forms.ComboBox cboSeccion;
        private System.Windows.Forms.GroupBox gpoBusqueda1;
        private System.Windows.Forms.GroupBox gpoBusqueda2;
        private System.Windows.Forms.ComboBox cboTipoPeriodo;
        private System.Windows.Forms.RadioButton rdoFiltroPorPeriodo;
        private System.Windows.Forms.RadioButton rdoUltimosQuince;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RadioButton rdoBusqueda1;
        private System.Windows.Forms.RadioButton rdoBusqueda2;
        private System.Windows.Forms.ComboBox cboPeriodoBusqueda2;
        private System.Windows.Forms.ComboBox cboTipoSeccionFiltro;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
    }
}