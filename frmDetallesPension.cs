using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using FPcreditos.clases;

namespace FPcreditos
{
    public partial class frmDetallesPension : Form
    {
        public frmDetallesPension()
        {
            InitializeComponent();
        }
        public int loc = 0;
        public int org = 0;
        public int mensual = 0;
        public string locNom = "";
        public string orgNom = "";
        public int tipoPension = 0;
        public string tn = "";
        public string tipoCobro = "";

        public int locCero = 0;
        public int orgCero = 0;
        public int mensualCero = 0;
        public string locNomCero = "";
        public string orgNomCero = "";
        public int tipoPensionCero = 0;
        public string tnCero = "";
        public string tipoCobroCero = "";

        clsData emp = new clsData();

        private void frmDetallesPension_Load(object sender, EventArgs e)
        {
           

            if (tipoPension == 1)
            {
                lblLoc.Text = loc.ToString() + " " + locNom.ToString();
                lblPeriodo.Text = mensual.ToString();
                lblOrg.Text = org.ToString() + " " + orgNom.ToString();
                gridDetallesPension();
            }
            else if (tipoPension == 2)
            {
                lblLoc.Text = locCero.ToString() + " " + locNomCero.ToString();
                lblPeriodo.Text = mensualCero.ToString();
                lblOrg.Text = orgCero.ToString() + " " + orgNomCero.ToString();
                gridDetallesZero();
            }
        }
        public void gridDetallesZero()
        {
            decimal fp = 0;
            int i = 0;
            DataTable dtDetallesCero= new DataTable();
            dtDetallesCero = emp.DetallesAportacionesZero(locCero, orgCero, mensualCero,tnCero,tipoCobroCero);
            dgvEmpDetalles.DataSource = dtDetallesCero;
            this.dgvEmpDetalles.Columns["TFP"].DefaultCellStyle.Format = "c";
            dgvEmpDetalles.Columns["locInt"].Visible = false;
            dgvEmpDetalles.Columns["orgInt"].Visible = false;
            dgvEmpDetalles.Columns["Localidad"].Visible = false;
            dgvEmpDetalles.Columns["Organismo"].Visible = false;
            lblLoc.Text = dgvEmpDetalles[2, 0].Value.ToString();
            lblOrg.Text = dgvEmpDetalles[3, 0].Value.ToString();
            while (i < dtDetallesCero.Rows.Count)
            {
                    fp += Convert.ToDecimal(dgvEmpDetalles[6, i++].Value);
            }

            lblTP.Text = fp.ToString("c");

           
        }
        public void gridDetallesPension()
        {
            decimal fp = 0;
            int i = 0;
            DataTable dtDetallesPension = new DataTable();
            dtDetallesPension = emp.DetallesAportaciones(loc, org, mensual,tn,tipoCobro);
            dgvEmpDetalles.DataSource = dtDetallesPension;
            if (dtDetallesPension.Rows.Count > 0)
            {
                this.dgvEmpDetalles.Columns["TFP"].DefaultCellStyle.Format = "c";
                dgvEmpDetalles.Columns["locInt"].Visible = false;
                dgvEmpDetalles.Columns["orgInt"].Visible = false;
                dgvEmpDetalles.Columns["Localidad"].Visible = false;
                dgvEmpDetalles.Columns["organismo"].Visible = false;
                lblLoc.Text = dgvEmpDetalles[2, 0].Value.ToString();
                lblOrg.Text = dgvEmpDetalles[3, 0].Value.ToString();
                while (i < dtDetallesPension.Rows.Count)
                {
                    fp += Convert.ToDecimal(dgvEmpDetalles[8, i++].Value);
                }

                lblTP.Text = fp.ToString("c");

            }
            else
            {
                MessageBox.Show("No se encontro información aplicada desde este sistema!");
            }
        }
    }
}
