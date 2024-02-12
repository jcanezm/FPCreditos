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

    public partial class frmBuscaNomina : Form
    {
        public frmBuscaNomina()
        {
            InitializeComponent();
        }
        clsData emp = new clsData();
        public int filtro = 0, conPeriodo = 0;
        int idOrg, idLoc, Periodo = 0;
        string nomina, n = "", secc = "";

        private void BindLocOrg()
        {
            cboLoc.DataSource = emp.Localidades();
            cboLoc.ValueMember = "codigo";
            cboLoc.DisplayMember = "descripcion";

            cboOrg.DataSource = emp.Organismos();
            cboOrg.ValueMember = "codigo";
            cboOrg.DisplayMember = "descripcion";

            cboPeriodo.DataSource = emp.PeriodoIni();
            cboPeriodo.ValueMember = "mensual";
            cboPeriodo.DisplayMember = "mensual";
            
            cboPeriodoF.DataSource = emp.PeriodoFin();
            cboPeriodoF.ValueMember = "mensual";
            cboPeriodoF.DisplayMember = "mensual";


            cboPeriodoBusqueda2.DataSource = emp.PeriodoIni();
            cboPeriodoBusqueda2.ValueMember = "mensual";
            cboPeriodoBusqueda2.DisplayMember = "mensual";
            

        }
        private void dgListadoNominas()
        {
            FiltroNominas();
            int loc = 0, org = 0, PeriodoIni = 0, PeriodoFin = 0;
            org = Convert.ToInt32(cboOrg.SelectedValue);
            loc = Convert.ToInt32(cboLoc.SelectedValue);
            PeriodoIni = Convert.ToInt32(cboPeriodo.SelectedValue);
            PeriodoFin = Convert.ToInt32(cboPeriodoF.SelectedValue);
            secc = "";
            secc = cboSeccion.SelectedItem.ToString();

           
            dgvNominas.DataSource = emp.NominasLiberadas(filtro, loc, org, PeriodoIni, PeriodoFin, conPeriodo,secc);
           
            if (dgvNominas.DataSource != null)
            {
                foreach (DataGridViewRow dgvRow in dgvNominas.Rows)
                {
                    if (dgvRow.Cells["acción"].Value.ToString() == "No Revisado")
                    {
                        dgvRow.DefaultCellStyle.BackColor = Color.Yellow;
                    }
                    else if (dgvRow.Cells["acción"].Value.ToString() == "Revisado")
                    {
                        dgvRow.DefaultCellStyle.BackColor = Color.Green;
                    }
                }
            }



        }
        private void TipodeBusqueda()
        {
            if (rdoBusqueda1.Checked == true)
            {
                gpoBusqueda1.Enabled = true;
            }
            else
            {
                gpoBusqueda1.Enabled = false;
            }

            if (rdoBusqueda2.Checked == true)
            {
                gpoBusqueda2.Enabled = true;
               
            }
            else
            {
                gpoBusqueda2.Enabled = false;
              
            }
        }
        private void SeleccionPeriodoBusqueda2()
        {
            if (rdoFiltroPorPeriodo.Checked == true)
            {
                cboPeriodoBusqueda2.Enabled = true;
                //cboTipoPeriodo.Enabled = true;
                cboTipoPeriodo.Enabled = true;
                cboTipoSeccionFiltro.Enabled = true;
            }
            else
            {
                cboPeriodoBusqueda2.Enabled = false;
                cboTipoPeriodo.Enabled = false;
                cboTipoSeccionFiltro.Enabled = false;
                //cboTipoPeriodo.Enabled = false;
            }
            if (rdoUltimosQuince.Checked==true)
            {
                cboPeriodoBusqueda2.Enabled = false;
                //cboTipoPeriodo.Enabled = false;
            }
            else
            {
                cboPeriodoBusqueda2.Enabled = true;
                //cboTipoPeriodo.Enabled = true;
            }

           
        }
        private void FiltroNominas()
        {
            clsData VerNominasLiberadas = new clsData();
            if (rdoLoc.Checked == true)
            {
                filtro = 1;
                cboPeriodoF.Enabled = false;
                cboPeriodo.Enabled = true;
                cboLoc.Enabled = true;
                cboOrg.Enabled = false;
            }
            else if (rdoOrg.Checked == true)
            {
                filtro = 2;
                cboPeriodoF.Enabled = false;
                cboPeriodo.Enabled = true;
                cboLoc.Enabled = false;
                cboOrg.Enabled = true;
            }

            else if (rdoEspecifico.Checked == true)
            {
                filtro = 4;
                cboPeriodoF.Enabled = false;
                cboPeriodo.Enabled = true;
                cboLoc.Enabled = true;
                cboOrg.Enabled = true;
            }

            if (chckPeriodo.Checked == true)
            {
                cboPeriodoF.Enabled = true;
                conPeriodo = 1;
            }
    
            
        }
     
        private void frmBuscaNomina_Load(object sender, EventArgs e)
        {
            BindLocOrg(); FiltroNominas();
            cboSeccion.SelectedIndex = 0;
            cboTipoPeriodo.SelectedIndex = 0;
            cboTipoSeccionFiltro.SelectedIndex = 0;
        }

        private void cmdFiltro_Click(object sender, EventArgs e)
        {
            if (rdoBusqueda1.Checked == true)
            {
                //FILTRAR POR LA BUSQUEDA 1
                FiltroNominas();
                int loc = 0, org = 0, PeriodoIni = 0, PeriodoFin = 0;
                org = Convert.ToInt32(cboOrg.SelectedValue);
                loc = Convert.ToInt32(cboLoc.SelectedValue);
                PeriodoIni = Convert.ToInt32(cboPeriodo.SelectedValue);
                PeriodoFin = Convert.ToInt32(cboPeriodoF.SelectedValue);
                secc = cboSeccion.SelectedItem.ToString();
              


                dgvNominas.DataSource = emp.NominasLiberadas(filtro, loc, org, PeriodoIni, PeriodoFin, conPeriodo, secc);
                if (dgvNominas.DataSource != null)
                {
                    foreach (DataGridViewRow dgvRow in dgvNominas.Rows)
                    {
                        if (dgvRow.Cells["acción"].Value.ToString() == "No Revisado")
                        {
                            dgvRow.DefaultCellStyle.BackColor = Color.Yellow;
                        }
                        else if (dgvRow.Cells["acción"].Value.ToString() == "Revisado")
                        {
                            dgvRow.DefaultCellStyle.BackColor = Color.Green;
                        }
                    }
                }

            }
            else if (rdoBusqueda2.Checked == true)
            {
                //FILTRAR POR LA BUSQUEDA 2
                int filtro = 0,  intPeriodo=0;
                string tipoperiodo = "", tipoSeccion="";
                intPeriodo = Convert.ToInt32(cboPeriodoBusqueda2.SelectedValue);
                tipoSeccion = cboTipoSeccionFiltro.SelectedItem.ToString();
                if (rdoUltimosQuince.Checked == true)
                {
                    filtro = 1;
                    tipoperiodo = cboTipoPeriodo.Text;
                    
                }
                else if (rdoFiltroPorPeriodo.Checked == true)
                {
                    filtro = 2;
                    tipoperiodo = cboTipoPeriodo.Text;
                   
                }
               

                dgvNominas.DataSource = emp.NominasLiberadasdos(filtro, intPeriodo, tipoperiodo, tipoSeccion);
                if (dgvNominas.DataSource != null)
                {
                    foreach (DataGridViewRow dgvRow in dgvNominas.Rows)
                    {
                        if (dgvRow.Cells["acción"].Value.ToString() == "No Revisado")
                        {
                            dgvRow.DefaultCellStyle.BackColor = Color.Yellow;
                        }
                        else if (dgvRow.Cells["acción"].Value.ToString() == "Revisado")
                        {
                            dgvRow.DefaultCellStyle.BackColor = Color.Green;
                        }
                    }
                }

            }
            else
            {
                //SIN FILTRO
                MessageBox.Show("Selecciona un Tipo de Busqueda","Error");
            }
        }

        private void chckPeriodo_CheckedChanged(object sender, EventArgs e)
        {
            FiltroNominas();
        }

        private void rdoLoc_CheckedChanged(object sender, EventArgs e)
        {
            FiltroNominas();
        }

        private void rdoOrg_CheckedChanged(object sender, EventArgs e)
        {
            FiltroNominas();
        }

        private void rdoEspecifico_CheckedChanged(object sender, EventArgs e)
        {
            FiltroNominas();
        }

        private void cmdChecked_Click(object sender, EventArgs e)
        {
            //FiltroNominas();
            int s = 0;
            idOrg = (int)dgvNominas[1, dgvNominas.CurrentRow.Index].Value;
            idLoc = (int)dgvNominas[0, dgvNominas.CurrentRow.Index].Value;
            Periodo = (int)dgvNominas[4, dgvNominas.CurrentRow.Index].Value;
            nomina = dgvNominas[7, dgvNominas.CurrentRow.Index].Value.ToString();
            if (secc != "")
            {
                secc = dgvNominas[10, dgvNominas.CurrentRow.Index].Value.ToString();
            }

            switch (nomina)
            {
                case "MENSUAL": n = "M";
                    break;
                case "QUINCENA 1": n = "1";
                    break;
                case "QUINCENA 2": n = "2";
                    break;
            }
            switch (secc)
            {
                case "RETENCION": s=1;
                    break;
                case "RECURSOS PROPIOS": s=2;
                    break;
                case "EVENTUALES": s = 3;
                    break;
            }

            if (emp.NominasRevisadas(idLoc, idOrg, Periodo, n,s))
            {
                dgListadoNominas();
            }
        }

        private void chckSeccion_CheckedChanged(object sender, EventArgs e)
        {
            FiltroNominas();
        }

        private void rdoBusqueda1_CheckedChanged(object sender, EventArgs e)
        {
            TipodeBusqueda();
        }

        private void rdoBusqueda2_CheckedChanged(object sender, EventArgs e)
        {
            TipodeBusqueda();
        }

        private void rdoUltimosQuince_CheckedChanged(object sender, EventArgs e)
        {
            SeleccionPeriodoBusqueda2();
        }

        private void rdoFiltroPorPeriodo_CheckedChanged(object sender, EventArgs e)
        {
            SeleccionPeriodoBusqueda2();
        }

        private void chckfiltroSeccion_CheckedChanged(object sender, EventArgs e)
        {
            SeleccionPeriodoBusqueda2();
        }

        
    }
}
