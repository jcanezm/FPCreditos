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
    public partial class frmAplicado : Form
    {
        public frmAplicado()
        {
            InitializeComponent();
        }
        clsData emp = new clsData();
        private void BindOrg()
        {
       
            cboLoc.DataSource = emp.Localidades();
            cboLoc.ValueMember = "codigo";
            cboLoc.DisplayMember = "descripcion";

            cboOrg.DataSource = emp.Organismos();
            cboOrg.ValueMember = "codigo";
            cboOrg.DisplayMember = "descripcion";
        
        }

        private void frmAplicado_Load(object sender, EventArgs e)
        {
            BindOrg();
        }
        private void MostrarFP()
        {
            int loc = Convert.ToInt32(cboLoc.SelectedValue);
            int org = Convert.ToInt32(cboOrg.SelectedValue);
            string fecha1 = maskedFecha1.Text;
            fecha1 = fecha1.Replace("-", "");
            int fechaIni = Convert.ToInt32(fecha1);
            DataTable dtAplicadas,dtAplicadasCero = new DataTable();
            string fecha2 = maskedFecha2.Text;
            fecha2 = fecha2.Replace("-", "");
            int fechaFin = Convert.ToInt32(fecha2);
            string tipoNomina = cboTipoNomina.SelectedItem.ToString();

            if (chckOrg.Checked == false)
            {
                dtAplicadas = emp.AportacionesAplicadas(loc, org, fechaIni, fechaFin,tipoNomina);

                dgvFPaplicado.DataSource = dtAplicadas;
                dgvFPaplicado.Columns[0].Visible = false;
                dgvFPaplicado.Columns[1].Visible = false;

                dtAplicadasCero = emp.AportacionesCeroAplicadas(loc, org, fechaIni, fechaFin, tipoNomina);
                dgvFPAplicadoCero.DataSource = dtAplicadasCero;
            }
            else
            {
                dtAplicadas = emp.AportacionesAplicadasXorganismos(org, fechaIni, fechaFin, tipoNomina);
                dgvFPaplicado.DataSource = dtAplicadas;

                dtAplicadasCero = emp.AportacionesCeroAplicadasXorganismos(org, fechaIni, fechaFin, tipoNomina);
                dgvFPAplicadoCero.DataSource = dtAplicadasCero;
            }
        }

        private void cmdcargar_Click(object sender, EventArgs e)
        {
            MostrarFP();
        }

        private void chckOrg_CheckedChanged(object sender, EventArgs e)
        {
            if (chckOrg.Checked == true)
            {
                cboLoc.Enabled = false;
            }
            else
            {
                cboLoc.Enabled = true;
            }
        }

        private void dgvFPaplicado_DoubleClick(object sender, EventArgs e)
        {
            frmDetallesPension detalles = new frmDetallesPension();
            detalles.loc = Convert.ToInt32(dgvFPaplicado[0, dgvFPaplicado.CurrentRow.Index].Value);
            detalles.org = Convert.ToInt32(dgvFPaplicado[1, dgvFPaplicado.CurrentRow.Index].Value);
            detalles.mensual = Convert.ToInt32(dgvFPaplicado[6, dgvFPaplicado.CurrentRow.Index].Value);
            detalles.orgNom = dgvFPaplicado[3, dgvFPaplicado.CurrentRow.Index].Value.ToString();
            detalles.locNom = dgvFPaplicado[2, dgvFPaplicado.CurrentRow.Index].Value.ToString();
            detalles.tn = dgvFPaplicado[7, dgvFPaplicado.CurrentRow.Index].Value.ToString();
            detalles.tipoCobro = dgvFPaplicado[8, dgvFPaplicado.CurrentRow.Index].Value.ToString();
            detalles.tipoPension = 1;
            detalles.Show();
        }

        private void dgvFPAplicadoCero_DoubleClick(object sender, EventArgs e)
        {
            frmDetallesPension detalles = new frmDetallesPension();
            detalles.locCero = Convert.ToInt32(dgvFPAplicadoCero[0, dgvFPAplicadoCero.CurrentRow.Index].Value);
            detalles.orgCero = Convert.ToInt32(dgvFPAplicadoCero[1, dgvFPAplicadoCero.CurrentRow.Index].Value);
            detalles.mensualCero = Convert.ToInt32(dgvFPAplicadoCero[6, dgvFPAplicadoCero.CurrentRow.Index].Value);
            detalles.orgNomCero = dgvFPAplicadoCero[3, dgvFPAplicadoCero.CurrentRow.Index].Value.ToString();
            detalles.locNomCero = dgvFPAplicadoCero[2, dgvFPAplicadoCero.CurrentRow.Index].Value.ToString();
            detalles.tnCero = dgvFPAplicadoCero[7, dgvFPAplicadoCero.CurrentRow.Index].Value.ToString();
            detalles.tipoCobroCero = dgvFPAplicadoCero[8, dgvFPAplicadoCero.CurrentRow.Index].Value.ToString();
            detalles.tipoPension = 2;
            detalles.Show();
        }

       
    }
}
