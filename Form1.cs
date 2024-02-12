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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        clsData Data = new clsData();
        private void btnVisualizar_Click(object sender, EventArgs e)
        {
            VerNomina();
        }
        private void BindLocOrg()
        {
          cboLoc.DataSource = Data.Localidades();
          cboLoc.ValueMember = "codigo";
          cboLoc.DisplayMember = "descripcion";

          cboOrg.DataSource = Data.Organismos();
          cboOrg.ValueMember = "codigo";
          cboOrg.DisplayMember = "descripcion";
           
        }
        private void BindAños()
        {
          cboAño.DataSource = Data.años();
          cboAño.ValueMember = "año";
          cboAño.DisplayMember = "año";
        }
        private void BindMeses()
        {
          cboMes.DataSource = Data.months();
          cboMes.ValueMember = "id";
          cboMes.DisplayMember = "mes";
        }
        public int CrearMensual(int mes, int año)
        {
            int m = 0;
            if (mes <= 9)
            {
                m = Convert.ToInt32(año.ToString() + "0" + mes.ToString());
            }
            else
            {
                m = Convert.ToInt32(año.ToString() + mes.ToString());
            }
            return m;

        }
        private void tipoNomina()
        {

            cboTipoNomina.DataSource = Data.TipoNominaData();
            cboTipoNomina.ValueMember = "id";
            cboTipoNomina.DisplayMember = "nom";

        }
        public void VerNomina()
        {
            lblPension.Text = "0"; lblEmpPension.Text = "0"; lblPensionCero.Text = "0"; lblEmpCero.Text = "0";
            lblTotPensionAplicado.Text = "0"; lblTotPenCeroAplicado.Text = "0"; lblTotEmpAplicados.Text = "0"; lblTotEmpCeroAplicado.Text = "0";
            lblTotalpension.Text = "0"; lblEmpTotal.Text = "0"; lblTotalesPensionAplicado.Text = "0"; lblTotalesEmpAplicado.Text = "0";

            int org = 0, loc = 0, mensual = 0, mes = 0, año = 0;
            string tipoNomina = "", tipoSeccion="";
            decimal nemp = 0, totalPen = 0;
            decimal nempC = 0, totalPenC = 0;
            decimal nempT = 0, totalPenT = 0;
            org = Convert.ToInt32(cboOrg.SelectedValue);
            loc = Convert.ToInt32(cboLoc.SelectedValue);
            mes = Convert.ToInt32(cboMes.SelectedValue);
            año = Convert.ToInt32(cboAño.SelectedValue);
            tipoNomina = cboTipoNomina.SelectedValue.ToString();
            mensual = CrearMensual(mes, año);
            DataTable TablaConActivos = new DataTable();
            DataTable TablaConPCero = new DataTable();
            tipoSeccion = cboSeccion.SelectedItem.ToString();
           

            //----------Visualiza Solo empleados con numero de pension-----------------------------
            TablaConActivos = Data.ResumenPersonasconNumeroPension(loc, org, mensual, tipoNomina, tipoSeccion);
            if (TablaConActivos.Rows.Count != 0 && TablaConActivos.Rows[0][0].ToString() != "0")
            {
                MessageBox.Show("NÓMINA CARGADA CON EXITO");
                nemp = Convert.ToDecimal(TablaConActivos.Rows[0][0]);
                lblEmpPension.Text = nemp.ToString("N0");
                totalPen = Convert.ToDecimal(TablaConActivos.Rows[0][1]);
                lblPension.Text = "$ " + totalPen.ToString("N2");
            }
            else
            {
                MessageBox.Show("LA NÓMINA SELECCIONADA ES INVALIDA O SIN CONTENIDO");
                lblEmpPension.Text = "$ 0.00";
                lblPension.Text = "0";
            }

            //---------------Visualiza pension cero-------------------------------------
            TablaConPCero = Data.ResumenPersonasconPensionCero(loc, org, mensual, tipoNomina,tipoSeccion);
            if (TablaConPCero.Rows.Count != 0 && TablaConPCero.Rows[0][0].ToString() != "0")
            {
              nempC = Convert.ToDecimal(TablaConPCero.Rows[0][0]);
              lblEmpCero.Text = nempC.ToString("N0");
              totalPenC = Convert.ToDecimal(TablaConPCero.Rows[0][1]);
              lblPensionCero.Text = "$ " + totalPenC.ToString("N2");
            }
            else
            {
                lblEmpCero.Text = "$ 0.00";
                lblPensionCero.Text = "0";
            }


            nempT = nemp + nempC;
            totalPenT = totalPen + totalPenC;
            lblTotalpension.Text = "$ " + totalPenT.ToString("N2");
            lblEmpTotal.Text = nempT.ToString("N0");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //LLenar Localidades,Organismos, año y mes
            BindLocOrg(); this.BindAños(); this.BindMeses(); tipoNomina(); 
            //-----------------------------

            cboSeccion.SelectedIndex = 0;
        }
        decimal fp, fpc, totalP = 0;
        int totalempleados = 0, totemp = 0, totempCero = 0;
        private void TotalesFP(decimal fp, decimal fpc, int emp, int empCero)
        {
            totalP = fp + fpc;
            totalempleados = emp + empCero;
            lblTotalesPensionAplicado.Text = "$ " + totalP.ToString("N2");
            lblTotalesEmpAplicado.Text = totalempleados.ToString("N0");
        }
        private void cmdGen_Click(object sender, EventArgs e)
        {
            int org = 0, loc = 0, mensualQ = 0, Mes = 0, Año = 0, periodoInt = 0;
            string tipoSeccion = "";
            //consultar numero de personas que se generaron despues de
            //llenar tabla liquidacion y liquidacion aytos
            //------------------------------------------------------
            Mes = Convert.ToInt32(cboMes.SelectedValue);
            Año = Convert.ToInt32(cboAño.SelectedValue);
            org = Convert.ToInt32(cboOrg.SelectedValue);
            loc = Convert.ToInt32(cboLoc.SelectedValue);
            periodoInt = CrearMensual(Mes, Año);
            DataTable dtFondoPension = new DataTable();
            tipoSeccion = cboSeccion.SelectedItem.ToString();
            
            //----------------------------------------------------------
            //Tipo Nomina
            string tipoN = cboTipoNomina.SelectedValue.ToString();
            if (tipoN != "M")
            {
                string mes = periodoInt.ToString();
                string periodo = mes.Substring(4);
                switch (periodo)
                {
                  case "01":if (tipoN == "1") { mensualQ = CrearMensual(1, Año); }
                   else { mensualQ = this.CrearMensual(2, Año); }
                  break;
                  case "02": if (tipoN == "1") { mensualQ = this.CrearMensual(3, Año); }
                   else { mensualQ = this.CrearMensual(4, Año); }
                  break;
                  case "03": if (tipoN == "1") { mensualQ = this.CrearMensual(5, Año); }
                   else { mensualQ = this.CrearMensual(6, Año); }
                  break;
                  case "04": if (tipoN == "1") { mensualQ = this.CrearMensual(7, Año); }
                   else { mensualQ = this.CrearMensual(8, Año); }
                  break;
                  case "05": if (tipoN == "1") { mensualQ = this.CrearMensual(9, Año); }
                   else { mensualQ = this.CrearMensual(10, Año); }
                  break;
                  case "06": if (tipoN == "1") { mensualQ = this.CrearMensual(11, Año); }
                   else { mensualQ = this.CrearMensual(12, Año); }
                  break;
                  case "07": if (tipoN == "1") { mensualQ = this.CrearMensual(13, Año); }
                   else { mensualQ = this.CrearMensual(14, Año); }
                  break;
                  case "08": if (tipoN == "1") { mensualQ = this.CrearMensual(15, Año); }
                   else { mensualQ = this.CrearMensual(16, Año); }
                  break;
                  case "09": if (tipoN == "1") { mensualQ = this.CrearMensual(17, Año); }
                   else { mensualQ = this.CrearMensual(18, Año); }
                  break;
                  case "10": if (tipoN == "1") { mensualQ = this.CrearMensual(19, Año); }
                    else { mensualQ = this.CrearMensual(20, Año); }
                  break;
                  case "11": if (tipoN == "1") { mensualQ = this.CrearMensual(21, Año); }
                    else { mensualQ = this.CrearMensual(22, Año); }
                  break;
                  case "12": if (tipoN == "1") { mensualQ = this.CrearMensual(23, Año); }
                    else { mensualQ = this.CrearMensual(24, Año); }
                  break;

                }

            }

            //Generar aportaciones
            bool verificarAporta = Data.VerificarAportaciones(org, loc, periodoInt, mensualQ, tipoN, tipoSeccion);
            if (verificarAporta==true)
            {
               if (Data.AportacionesSN(periodoInt, loc, org, tipoN, mensualQ,tipoSeccion))
               {
              
                 MessageBox.Show("Aportaciones -CARGADAS CON EXITO- en la tabla.");

               }
               else
               {
                 MessageBox.Show("Nómina NO Liberada o Periodo NO Generado....");
               }
             }
             else
             {
               MessageBox.Show("Las Aportaciones del mes seleccionado YA SE CARGARON...");
             }

             //---LLenar datagrid
            DataTable resumenActivos = new DataTable();
            resumenActivos = Data.AportacionesResumen(periodoInt, loc, org, tipoN, mensualQ, tipoSeccion);


            if (resumenActivos.Rows.Count > 0)
            {
                fp = Convert.ToDecimal(resumenActivos.Rows[0][4]);
                totemp = Convert.ToInt32(resumenActivos.Rows[0][5]);
                TotalesFP(fp, 0, totemp, 0);

                lblTotPensionAplicado.Text = "$ " + fp.ToString("N2");
                lblTotEmpAplicados.Text = totemp.ToString("N0");
            }
            else
            {
                fp = 0;
                totemp = 0;
            }
            
        }

        private void cmd_pencero_Click(object sender, EventArgs e)
        {
            string tipoSeccion = "";
            tipoSeccion = cboSeccion.SelectedItem.ToString();
           
            int org = 0, loc = 0, mensual = 0, mensualQ = 0, Mes = 0, Año = 0;
            clsData empCero = new clsData();
            //consultar numero de personas que se generaron despues de
            //llenar tabla liquidacion y liquidacion aytos
            //------------------------------------------------------
            Mes = Convert.ToInt32(cboMes.SelectedValue);
            Año = Convert.ToInt32(cboAño.SelectedValue);
            org = Convert.ToInt32(cboOrg.SelectedValue);
            loc = Convert.ToInt32(cboLoc.SelectedValue);
            mensual = this.CrearMensual(Mes, Año);
            DataTable dtFondoPension = new DataTable();

            //Tipo Nomina
            string tipoN = cboTipoNomina.SelectedValue.ToString();
            if (tipoN != "M")
            {
                string mes = mensual.ToString();
                string periodo = mes.Substring(4);
                switch (periodo)
                {
                    case "01":
                        if (tipoN == "1") { mensualQ = this.CrearMensual(1, Año); }
                        else { mensualQ = this.CrearMensual(2, Año); }
                        break;
                    case "02": if (tipoN == "1") { mensualQ = this.CrearMensual(3, Año); }
                        else { mensualQ = this.CrearMensual(4, Año); }
                        break;
                    case "03": if (tipoN == "1") { mensualQ = this.CrearMensual(5, Año); }
                        else { mensualQ = this.CrearMensual(6, Año); }
                        break;
                    case "04": if (tipoN == "1") { mensualQ = this.CrearMensual(7, Año); }
                        else { mensualQ = this.CrearMensual(8, Año); }
                        break;
                    case "05": if (tipoN == "1") { mensualQ = this.CrearMensual(9, Año); }
                        else { mensualQ = this.CrearMensual(10, Año); }
                        break;
                    case "06": if (tipoN == "1") { mensualQ = this.CrearMensual(11, Año); }
                        else { mensualQ = this.CrearMensual(12, Año); }
                        break;
                    case "07": if (tipoN == "1") { mensualQ = this.CrearMensual(13, Año); }
                        else { mensualQ = this.CrearMensual(14, Año); }
                        break;
                    case "08": if (tipoN == "1") { mensualQ = this.CrearMensual(15, Año); }
                        else { mensualQ = this.CrearMensual(16, Año); }
                        break;
                    case "09": if (tipoN == "1") { mensualQ = this.CrearMensual(17, Año); }
                        else { mensualQ = this.CrearMensual(18, Año); }
                        break;
                    case "10": if (tipoN == "1") { mensualQ = this.CrearMensual(19, Año); }
                        else { mensualQ = this.CrearMensual(20, Año); }
                        break;
                    case "11": if (tipoN == "1") { mensualQ = this.CrearMensual(21, Año); }
                        else { mensualQ = this.CrearMensual(22, Año); }
                        break;
                    case "12": if (tipoN == "1") { mensualQ = this.CrearMensual(23, Año); }
                        else { mensualQ = this.CrearMensual(24, Año); }
                        break;

                }

            }

            //----------
            bool verificarCero=empCero.VerificarAportacionesZero(mensual, org, loc, mensualQ, tipoN, tipoSeccion);
            if (verificarCero==true)
            {
                //-----------SUBIR PENSIONES CERO---------------------------------------------------------
                if (empCero.AportacionesSNZero(mensual, loc, org, tipoN, mensualQ, tipoSeccion))
               {
                 
                   MessageBox.Show("Aportaciones en Cero -CARGADAS CON EXITO- en la tabla.");
                 
                }
               else
               {
                   MessageBox.Show("Nómina NO Liberada o Periodo NO Generado....");
               }
            }
            else
            {
                MessageBox.Show("Las Aportaciones del mes seleccionado YA SE CARGARON...");
            }
            DataTable resumenActivosCero = new DataTable();
            resumenActivosCero = empCero.AportacionesZeroResumen(mensual, loc, org, tipoN, mensualQ, tipoSeccion);
            if (resumenActivosCero.Rows.Count > 0)
            {
                fpc = Convert.ToDecimal(resumenActivosCero.Rows[0][4]);
                totempCero = Convert.ToInt32(resumenActivosCero.Rows[0][5]);
                TotalesFP(fp, fpc, totemp, totempCero);
                lblTotEmpCeroAplicado.Text = totempCero.ToString("N0");
                lblTotPenCeroAplicado.Text = "$ " + fpc.ToString("N2");
            }
            else
            {
                fpc = 0;
                totempCero = 0;
            }
        }

        private void cmdNominas_Click(object sender, EventArgs e)
        {
            frmBuscaNomina busca = new frmBuscaNomina();
            busca.Show();
        }

        private void cmdVerFP_Click(object sender, EventArgs e)
        {
            frmAplicado abrir = new frmAplicado();
            abrir.Show();
        }

       
    }
}
