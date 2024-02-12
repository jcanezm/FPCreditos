namespace FPcreditos
{
    partial class frmAplicado
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label3 = new System.Windows.Forms.Label();
            this.dgvFPAplicadoCero = new System.Windows.Forms.DataGridView();
            this.chckOrg = new System.Windows.Forms.CheckBox();
            this.maskedFecha2 = new System.Windows.Forms.MaskedTextBox();
            this.maskedFecha1 = new System.Windows.Forms.MaskedTextBox();
            this.dgvFPaplicado = new System.Windows.Forms.DataGridView();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.cboLoc = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cboOrg = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cmdcargar = new System.Windows.Forms.Button();
            this.cboTipoNomina = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFPAplicadoCero)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFPaplicado)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DarkRed;
            this.label3.Location = new System.Drawing.Point(386, 173);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(221, 16);
            this.label3.TabIndex = 63;
            this.label3.Text = "Fondo de Pensión Cero Aplicado:";
            // 
            // dgvFPAplicadoCero
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvFPAplicadoCero.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvFPAplicadoCero.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvFPAplicadoCero.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvFPAplicadoCero.Location = new System.Drawing.Point(389, 192);
            this.dgvFPAplicadoCero.Name = "dgvFPAplicadoCero";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvFPAplicadoCero.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvFPAplicadoCero.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvFPAplicadoCero.Size = new System.Drawing.Size(337, 401);
            this.dgvFPAplicadoCero.TabIndex = 62;
            this.dgvFPAplicadoCero.DoubleClick += new System.EventHandler(this.dgvFPAplicadoCero_DoubleClick);
            // 
            // chckOrg
            // 
            this.chckOrg.AutoSize = true;
            this.chckOrg.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chckOrg.Location = new System.Drawing.Point(15, 153);
            this.chckOrg.Name = "chckOrg";
            this.chckOrg.Size = new System.Drawing.Size(143, 17);
            this.chckOrg.TabIndex = 61;
            this.chckOrg.Text = "Filtrar por Organismo";
            this.chckOrg.UseVisualStyleBackColor = true;
            this.chckOrg.CheckedChanged += new System.EventHandler(this.chckOrg_CheckedChanged);
            // 
            // maskedFecha2
            // 
            this.maskedFecha2.Location = new System.Drawing.Point(366, 111);
            this.maskedFecha2.Mask = "0000-00";
            this.maskedFecha2.Name = "maskedFecha2";
            this.maskedFecha2.Size = new System.Drawing.Size(123, 20);
            this.maskedFecha2.TabIndex = 60;
            this.maskedFecha2.ValidatingType = typeof(System.DateTime);
            // 
            // maskedFecha1
            // 
            this.maskedFecha1.Location = new System.Drawing.Point(114, 111);
            this.maskedFecha1.Mask = "0000-00";
            this.maskedFecha1.Name = "maskedFecha1";
            this.maskedFecha1.Size = new System.Drawing.Size(123, 20);
            this.maskedFecha1.TabIndex = 59;
            this.maskedFecha1.ValidatingType = typeof(System.DateTime);
            // 
            // dgvFPaplicado
            // 
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvFPaplicado.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvFPaplicado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvFPaplicado.DefaultCellStyle = dataGridViewCellStyle5;
            this.dgvFPaplicado.Location = new System.Drawing.Point(15, 192);
            this.dgvFPaplicado.Name = "dgvFPaplicado";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvFPaplicado.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvFPaplicado.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvFPaplicado.Size = new System.Drawing.Size(368, 401);
            this.dgvFPaplicado.TabIndex = 58;
            this.dgvFPaplicado.DoubleClick += new System.EventHandler(this.dgvFPaplicado_DoubleClick);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.label8.Location = new System.Drawing.Point(12, 173);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(187, 16);
            this.label8.TabIndex = 57;
            this.label8.Text = "Fondo de Pensión Aplicado:";
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.DarkGray;
            this.label7.Location = new System.Drawing.Point(243, 102);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(13, 40);
            this.label7.TabIndex = 56;
            this.label7.Text = "||";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(262, 111);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(98, 16);
            this.label5.TabIndex = 55;
            this.label5.Text = "Periodo Final:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.DarkRed;
            this.label10.Location = new System.Drawing.Point(12, 92);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(205, 16);
            this.label10.TabIndex = 54;
            this.label10.Text = "Selecciona el periodo a cargar";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(12, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 16);
            this.label2.TabIndex = 53;
            this.label2.Text = "Periodo Inicio:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(12, 29);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(75, 16);
            this.label9.TabIndex = 50;
            this.label9.Text = "Localidad:";
            // 
            // cboLoc
            // 
            this.cboLoc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboLoc.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboLoc.FormattingEnabled = true;
            this.cboLoc.Location = new System.Drawing.Point(99, 28);
            this.cboLoc.Name = "cboLoc";
            this.cboLoc.Size = new System.Drawing.Size(438, 24);
            this.cboLoc.TabIndex = 52;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(12, 61);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(81, 16);
            this.label6.TabIndex = 51;
            this.label6.Text = "Organismo:";
            // 
            // cboOrg
            // 
            this.cboOrg.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboOrg.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboOrg.FormattingEnabled = true;
            this.cboOrg.Location = new System.Drawing.Point(99, 58);
            this.cboOrg.Name = "cboOrg";
            this.cboOrg.Size = new System.Drawing.Size(438, 24);
            this.cboOrg.TabIndex = 49;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkRed;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(152, 16);
            this.label1.TabIndex = 48;
            this.label1.Text = "Selecciona Organismo";
            // 
            // cmdcargar
            // 
            this.cmdcargar.BackColor = System.Drawing.Color.Transparent;
            this.cmdcargar.BackgroundImage = global::FPcreditos.Properties.Resources.reload;
            this.cmdcargar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.cmdcargar.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdcargar.Location = new System.Drawing.Point(673, 134);
            this.cmdcargar.Name = "cmdcargar";
            this.cmdcargar.Size = new System.Drawing.Size(53, 52);
            this.cmdcargar.TabIndex = 47;
            this.cmdcargar.UseVisualStyleBackColor = false;
            this.cmdcargar.Click += new System.EventHandler(this.cmdcargar_Click);
            // 
            // cboTipoNomina
            // 
            this.cboTipoNomina.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTipoNomina.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboTipoNomina.ForeColor = System.Drawing.Color.Black;
            this.cboTipoNomina.FormattingEnabled = true;
            this.cboTipoNomina.Items.AddRange(new object[] {
            "Q",
            "M"});
            this.cboTipoNomina.Location = new System.Drawing.Point(637, 58);
            this.cboTipoNomina.Name = "cboTipoNomina";
            this.cboTipoNomina.Size = new System.Drawing.Size(89, 24);
            this.cboTipoNomina.TabIndex = 77;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(634, 39);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 16);
            this.label4.TabIndex = 78;
            this.label4.Text = "Tipo Nomina:";
            // 
            // frmAplicado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(741, 604);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cboTipoNomina);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dgvFPAplicadoCero);
            this.Controls.Add(this.chckOrg);
            this.Controls.Add(this.maskedFecha2);
            this.Controls.Add(this.maskedFecha1);
            this.Controls.Add(this.dgvFPaplicado);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.cboLoc);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cboOrg);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmdcargar);
            this.Name = "frmAplicado";
            this.Text = "frmAplicado";
            this.Load += new System.EventHandler(this.frmAplicado_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvFPAplicadoCero)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFPaplicado)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dgvFPAplicadoCero;
        private System.Windows.Forms.CheckBox chckOrg;
        private System.Windows.Forms.MaskedTextBox maskedFecha2;
        private System.Windows.Forms.MaskedTextBox maskedFecha1;
        private System.Windows.Forms.DataGridView dgvFPaplicado;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cboLoc;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cboOrg;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button cmdcargar;
        private System.Windows.Forms.ComboBox cboTipoNomina;
        private System.Windows.Forms.Label label4;
    }
}