using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace FPcreditos.clases
{
    class clsData:conexionI
    {
        public DataTable searchMod(int loc, int org, int vig, string gen, int sts)
        {
            string strSql = "select * from  where idlocalidad = " + loc + " and idorganismo = " + org + " and vigencia = " + vig + " and status=" + sts + " and idtipogenera='" + gen + "'";
            var cns = GetConnection(ConnectionStrings.Ingresos);
            adapt.SelectCommand = new SqlCommand(strSql, cns);
            var DtCts = Dt.Copy();

            try
            {
                cns.Open();
                adapt.Fill(DtCts);
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Ocurrió el SIguiente Error : " + ex.Message.ToString(), "..:: MENSAJE DESDE LA CLASE CONVENIOS ::..", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió el SIguiente Error : " + ex.Message.ToString(), "..:: MENSAJE DESDE LA CLASE CONVENIOS ::..", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                cns.Close();
            }

            return DtCts;
        }

        public DataTable Organismos()
        {
            string query = "select * from organismos order by descripcion";
            var cns = GetConnection(ConnectionStrings.Ingresos);
            adapt.SelectCommand = new SqlCommand(query, cns);
            var DtOrg = Dt.Copy();

            try
            {
                cns.Open();
                adapt.Fill(DtOrg);
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Ocurrió el SIguiente Error : " + ex.Message.ToString(), "..:: MENSAJE DESDE LA CLASE DATA ::..", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió el SIguiente Error : " + ex.Message.ToString(), "..:: MENSAJE DESDE LA CLASE DATA ::..", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                cns.Close();
            }

            return DtOrg;
           


        }
        public DataTable Localidades()
        {
            string query = "select * from localidades order by descripcion";
            var cns = GetConnection(ConnectionStrings.Ingresos);
            adapt.SelectCommand = new SqlCommand(query, cns);
            var DtLoc = Dt.Copy();
            try
            {
                cns.Open();
                adapt.Fill(DtLoc);
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Ocurrió el SIguiente Error : " + ex.Message.ToString(), "..:: MENSAJE DESDE LA CLASE DATA ::..", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió el SIguiente Error : " + ex.Message.ToString(), "..:: MENSAJE DESDE LA CLASE DATA ::..", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                cns.Close();
            }

            return DtLoc;

        }
        public DataTable años()
        {
            string StrSql = "select distinct left(mensual,4) año  from liquidacion  order by año desc";
            var cns = GetConnection(ConnectionStrings.Ingresos);
            adapt.SelectCommand = new SqlCommand(StrSql, cns);
            var DtYears = Dt.Copy();
            try
            {
                cns.Open();
                adapt.Fill(DtYears);
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Ocurrió el SIguiente Error : " + ex.Message.ToString(), "..:: MENSAJE DESDE LA CLASE DATA ::..", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió el SIguiente Error : " + ex.Message.ToString(), "..:: MENSAJE DESDE LA CLASE DATA ::..", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                cns.Close();
            }

            return DtYears;
           
        }
        public DataTable months()
        {
            DataTable dtm = new DataTable();
            dtm.Columns.Add("id");
            dtm.Columns.Add("mes");

            string[] mes = new string[13];
            mes[1] = "ENERO";
            mes[2] = "FEBRERO";
            mes[3] = "MARZO";
            mes[4] = "ABRIL";
            mes[5] = "MAYO";
            mes[6] = "JUNIO";
            mes[7] = "JULIO";
            mes[8] = "AGOSTO";
            mes[9] = "SEPTIEMBRE";
            mes[10] = "OCTUBRE";
            mes[11] = "NOVIEMBRE";
            mes[12] = "DICIEMBRE";



            for (int i = 1; i <= 12; i++)
            {
                DataRow row = dtm.NewRow();
                row["id"] = i;
                row["mes"] = mes[i];
                dtm.Rows.Add(row);
            }

            return dtm;
        }
        public DataTable TipoNominaData()
        {
            DataTable dtm = new DataTable();
            dtm.Columns.Add("id");
            dtm.Columns.Add("nom");

            string[] nom = new string[4];
            nom[1] = "QUINCENA 1";
            nom[2] = "QUINCENA 2";
            nom[3] = "MENSUAL";

            string[] nomId = new string[4];
            nomId[1] = "1";
            nomId[2] = "2";
            nomId[3] = "M";



            for (int i = 1; i <= 3; i++)
            {
                DataRow row = dtm.NewRow();
                row["id"] = nomId[i];
                row["nom"] = nom[i];
                dtm.Rows.Add(row);
            }

            return dtm;
        }
        public DataTable PeriodoIni()
        {
            string query = "select Distinct(mensual) from ingresos.dbo.liquidacion order by mensual desc";
            var cns = GetConnection(ConnectionStrings.Ingresos);
            adapt.SelectCommand = new SqlCommand(query, cns);
            var DtContenido = Dt.Copy();

            try
            {
                cns.Open();
                adapt.Fill(DtContenido);
            }
            catch (SqlException ex)
            {
                MessageBox.Show("No se pudo consultar la base de datos, error : " + ex.Message, "..:: MENSAJE DESDE LA CLASE DATA ::..", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió el siguiente error :" + ex.Message, "..:: MENSAJE DESDE LA CLASE DATA ::..", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                cns.Close();
            }
            return DtContenido;

        }
        public DataTable PeriodoFin()
        {
            string query = "select Distinct(mensual) from ingresos.dbo.liquidacion order by mensual desc";
            var cns = GetConnection(ConnectionStrings.Ingresos);
            adapt.SelectCommand = new SqlCommand(query, cns);
            var DtContenido = Dt.Copy();

            try
            {
                cns.Open();
                adapt.Fill(DtContenido);
            }
            catch (SqlException ex)
            {
                MessageBox.Show("No se pudo consultar la base de datos, error : " + ex.Message, "..:: MENSAJE DESDE LA CLASE DATA ::..", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió el siguiente error :" + ex.Message, "..:: MENSAJE DESDE LA CLASE DATA ::..", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                cns.Close();
            }
            return DtContenido;


        }
        public DataTable ResumenPersonasconNumeroPension(int loc, int org, int mensual, string tipoNomina,string seccion)
        {
            string seccionVariable = "";

            switch (seccion)
            {
                case "RETENCION": seccionVariable = "and T_cobro=1";
                    break;
                case "RECURSOS PROPIOS": seccionVariable = "and T_cobro=2";
                    break;
                case "EVENTUALES": seccionVariable = "and T_cobro=3";
                    break;
                case "OTROS": seccionVariable = "and T_cobro=4";
                    break;
            }

            string query = "select count(*) as 'No_pension', sum(c_fondopens) as 'Total_pension' from liquidacion where organismo=" + org +
                               "and localidad=" + loc + " and " +
                               "mensual=" + mensual + " and tqna='" + tipoNomina + "' and tipoGeneracion not in ('I','P') and " +
                               "pension<>0 and control<>0 "+seccionVariable;
            var cns = GetConnection(ConnectionStrings.Ingresos);
            adapt.SelectCommand = new SqlCommand(query, cns);
            var DtContenido = Dt.Copy();

            try
            {
                cns.Open();
                adapt.Fill(DtContenido);
            }
            catch (SqlException ex)
            {
                MessageBox.Show("No se pudo consultar la base de datos, error : " + ex.Message, "..:: MENSAJE DESDE LA CLASE DATA ::..", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió el siguiente error :" + ex.Message, "..:: MENSAJE DESDE LA CLASE DATA ::..", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                cns.Close();
            }
            return DtContenido;
           
        }
        public DataTable ResumenPersonasconPensionCero(int loc, int org, int mensual, string tipoNomina, string seccion)
        {
            string seccionVariable = "";

            switch (seccion)
            {
                case "RETENCION": seccionVariable = "and T_cobro=1";
                    break;
                case "RECURSOS PROPIOS": seccionVariable = "and T_cobro=2";
                    break;
                case "EVENTUALES": seccionVariable = "and T_cobro=3";
                    break;
                case "OTROS": seccionVariable = "and T_cobro=4";
                    break;
                default: seccionVariable = "and t_cobro not in(5,6)";
                    break;
            }

            string query = "select count(*) as 'No_pension', sum(c_fondopens) as 'Total_pension' from liquidacion where organismo=" + org +
                              " and localidad=" + loc + " and " +
                              "mensual=" + mensual + " and tqna='" + tipoNomina + "' and " +
                              "pension=0 " + seccionVariable;


            var cns = GetConnection(ConnectionStrings.Ingresos);
            adapt.SelectCommand = new SqlCommand(query, cns);
            var DtContenidoCero = Dt.Copy();

            try
            {
                cns.Open();
                adapt.Fill(DtContenidoCero);
            }
            catch (SqlException ex)
            {
                MessageBox.Show("No se pudo consultar la base de datos, error : " + ex.Message, "..:: MENSAJE DESDE LA CLASE DATA ::..", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió el siguiente error :" + ex.Message, "..:: MENSAJE DESDE LA CLASE DATA ::..", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                cns.Close();
            }
            return DtContenidoCero;
        }
        public DataTable NominasLiberadas(int filtro, int loc, int org, int mensual, int mensualFinal, int ActivarPeriodo,string secc)
        { 
           string strSql = "",seccionGroup="", seccionVariable="", seleccionCase="";
           
           switch (secc)
           {
              case "TODOS": seccionVariable = "";
              seccionGroup = "T_cobro,";
              seleccionCase = ",case t_cobro when 1 then 'RETENCION' when 2 then 'RECURSOS PROPIOS' when 3 then 'EVENTUALES' when 4 then 'OTROS' ELSE 'SIN TIPO' END AS Seccion";
              break;
              case "RETENCION": seccionVariable="and T_cobro=1";
              seccionGroup = "T_cobro,";
              seleccionCase = ",case t_cobro when 1 then 'RETENCION' when 2 then 'RECURSOS PROPIOS' when 3 then 'EVENTUALES' when 4 then 'OTROS' ELSE 'SIN TIPO' END AS Seccion";
              break;
              case "RECURSOS PROPIOS": seccionVariable = "and T_cobro=2";
              seccionGroup = "T_cobro,";
              seleccionCase = ",case t_cobro when 1 then 'RETENCION' when 2 then 'RECURSOS PROPIOS' when 3 then 'EVENTUALES' when 4 then 'OTROS' ELSE 'SIN TIPO' END AS Seccion";
              break;
              case "EVENTUALES": seccionVariable = "and T_cobro=3";
              seccionGroup = "T_cobro,";
              seleccionCase = ",case t_cobro when 1 then 'RETENCION' when 2 then 'RECURSOS PROPIOS' when 3 then 'EVENTUALES' when 4 then 'OTROS' ELSE 'SIN TIPO' END AS Seccion";
              break;
              case "OTROS": seccionVariable = "and T_cobro=4";
              seccionGroup = "T_cobro,";
              seleccionCase = ",case t_cobro when 1 then 'RETENCION' when 2 then 'RECURSOS PROPIOS' when 3 then 'EVENTUALES' when 4 then 'OTROS' ELSE 'SIN TIPO' END AS Seccion";
              break;
           }

           switch (filtro)
           {
             case 1: if (ActivarPeriodo == 1)
                   { strSql = "select localidad,organismo,nomlocalidad as 'Localidades',nomOrganismo as 'Organismos',mensual as 'Periodo',count(*) as 'No. empleados',CONVERT(varchar(50),CONVERT(money,sum(C_FondoPens)), 1) as 'Total F.P.',case tqna when 'M' then 'MENSUAL' when '1' then 'QUINCENA 1' when '2' then 'QUINCENA 2' END AS Nomina, Fechapagado as 'Fecha Subido', case visto when 0 then 'No Revisado' when 1 then 'Revisado' end as 'Acción' " + seleccionCase + " from liquidacion where pagado=1 and tipoGeneracion not in ('I','P') and C_fondoPens <> 0 and localidad=" + loc + " and mensual between " + mensual + " and " + mensualFinal + " " + seccionVariable + " group by " + seccionGroup + " organismo,localidad,nomlocalidad,nomorganismo,mensual, tqna,fechapagado,visto order by fechapagado desc,mensual desc, localidad, organismo"; }
                     else
                   { strSql = "select localidad,organismo,nomlocalidad as 'Localidades',nomOrganismo as 'Organismos',mensual as 'Periodo',count(*) as 'No. empleados',CONVERT(varchar(50),CONVERT(money,sum(C_FondoPens)), 1) as 'Total F.P.',case tqna when 'M' then 'MENSUAL' when '1' then 'QUINCENA 1' when '2' then 'QUINCENA 2' END AS Nomina, Fechapagado as 'Fecha Subido', case visto when 0 then 'No Revisado' when 1 then 'Revisado' end as 'Acción' " + seleccionCase + " from liquidacion where pagado=1 and tipoGeneracion not in ('I','P') and C_fondoPens <> 0 and localidad=" + loc + " and mensual=" + mensual + "" + seccionVariable + " group by " + seccionGroup + " organismo,localidad,nomlocalidad,nomorganismo,mensual, tqna,fechapagado,visto order by fechapagado desc,mensual desc, localidad, organismo"; }
             break;
             case 2: if (ActivarPeriodo == 1)
             { strSql = "select localidad,organismo,nomlocalidad as 'Localidades',nomOrganismo as 'Organismos',mensual as 'Periodo',count(*) as 'No. empleados',CONVERT(varchar(50),CONVERT(money,sum(C_FondoPens)), 1) as 'Total F.P.',case tqna when 'M' then 'MENSUAL' when '1' then 'QUINCENA 1' when '2' then 'QUINCENA 2' END AS Nomina, Fechapagado as 'Fecha Subido', case visto when 0 then 'No Revisado' when 1 then 'Revisado' end as 'Acción' " + seleccionCase + " from liquidacion where pagado=1 and tipoGeneracion not in ('I','P') and C_fondoPens <> 0 and organismo=" + org + " and mensual between " + mensual + "" + seccionVariable + " and " + mensualFinal + "" + seccionVariable + "group by  " + seccionGroup + " organismo,localidad,nomlocalidad,nomorganismo,mensual, tqna,fechapagado,visto order by fechapagado desc,mensual desc, localidad, organismo"; }
                     else
             { strSql = "select localidad,organismo,nomlocalidad as 'Localidades',nomOrganismo as 'Organismos',mensual as 'Periodo',count(*) as 'No. empleados',CONVERT(varchar(50),CONVERT(money,sum(C_FondoPens)), 1) as 'Total F.P.',case tqna when 'M' then 'MENSUAL' when '1' then 'QUINCENA 1' when '2' then 'QUINCENA 2' END AS Nomina, Fechapagado as 'Fecha Subido', case visto when 0 then 'No Revisado' when 1 then 'Revisado' end as 'Acción' " + seleccionCase + " from liquidacion where pagado=1 and tipoGeneracion not in ('I','P') and C_fondoPens <> 0 and organismo=" + org + " and mensual=" + mensual + "" + seccionVariable + " group by " + seccionGroup + " organismo,localidad,nomlocalidad,nomorganismo,mensual, tqna,fechapagado,visto order by fechapagado desc,mensual desc, localidad, organismo"; }
             break;
             case 4: if (ActivarPeriodo == 1)
             { strSql = "select localidad,organismo,nomlocalidad as 'Localidades',nomOrganismo as 'Organismos',mensual as 'Periodo',count(*) as 'No. empleados',CONVERT(varchar(50),CONVERT(money,sum(C_FondoPens)), 1) as 'Total F.P.',case tqna when 'M' then 'MENSUAL' when '1' then 'QUINCENA 1' when '2' then 'QUINCENA 2' END AS Nomina, Fechapagado as 'Fecha Subido', case visto when 0 then 'No Revisado' when 1 then 'Revisado' end as 'Acción' " + seleccionCase + " from liquidacion where pagado=1 and tipoGeneracion not in ('I','P') and C_fondoPens <> 0 and localidad=" + loc + " and organismo=" + org + " and mensual between " + mensual + " and " + mensualFinal + "" + seccionVariable + " group by " + seccionGroup + "organismo,localidad,nomlocalidad,nomorganismo,mensual, tqna,fechapagado,visto order by fechapagado desc,mensual desc, localidad, organismo"; }
                        else
             { strSql = "select localidad,organismo,nomlocalidad as 'Localidades',nomOrganismo as 'Organismos',mensual as 'Periodo',count(*) as 'No. empleados',CONVERT(varchar(50),CONVERT(money,sum(C_FondoPens)), 1) as 'Total F.P.',case tqna when 'M' then 'MENSUAL' when '1' then 'QUINCENA 1' when '2' then 'QUINCENA 2' END AS Nomina, Fechapagado as 'Fecha Subido', case visto when 0 then 'No Revisado' when 1 then 'Revisado' end as 'Acción' " + seleccionCase + " from liquidacion where pagado=1 and tipoGeneracion not in ('I','P') and C_fondoPens <> 0 and localidad=" + loc + " and organismo=" + org + " and mensual=" + mensual + "" + seccionVariable + " group by " + seccionGroup + " organismo,localidad,nomlocalidad,nomorganismo,mensual, tqna,fechapagado,visto order by fechapagado desc,mensual desc, localidad, organismo"; }
             break;
             default: strSql = "select localidad,organismo,nomlocalidad as 'Localidades',nomOrganismo as 'Organismos',mensual as 'Periodo',count(*) as 'No. empleados',CONVERT(varchar(50),CONVERT(money,sum(C_FondoPens)), 1) as 'Total F.P.',case tqna when 'M' then 'MENSUAL' when '1' then 'QUINCENA 1' when '2' then 'QUINCENA 2' END AS Nomina, Fechapagado as 'Fecha Subido', case visto when 0 then 'No Revisado' when 1 then 'Revisado' end as 'Acción' " + seleccionCase + " from liquidacion where pagado=1 and tipoGeneracion not in ('I','P') and C_fondoPens <> 0  " + seccionVariable + "group by " + seccionGroup + " organismo,localidad,nomlocalidad,nomorganismo,mensual, tqna,fechapagado,visto order by fechapagado desc,mensual desc, localidad, organismo";
             break;
            }
           var cns = GetConnection(ConnectionStrings.Ingresos);
           adapt.SelectCommand = new SqlCommand(strSql, cns);
           var DtContenido = Dt.Copy();

           try
           {
               cns.Open();
               adapt.Fill(DtContenido);
           }
           catch (SqlException ex)
           {
               MessageBox.Show("No se pudo consultar la base de datos, error : " + ex.Message, "..:: MENSAJE DESDE LA CLASE DATA ::..", MessageBoxButtons.OK, MessageBoxIcon.Error);
           }
           catch (Exception ex)
           {
               MessageBox.Show("Ocurrió el siguiente error :" + ex.Message, "..:: MENSAJE DESDE LA CLASE DATA ::..", MessageBoxButtons.OK, MessageBoxIcon.Error);
           }
           finally
           {
               //cns.Close();
           }
           return DtContenido;
            
        }
        public DataTable NominasLiberadasdos(int filtro,int intPeriodo,string tipoperiodo,string tipoSeccion)
        {
            string strSql = "", seccionGroup = "", seccionVariable = "", seleccionCase = "", PeriodoVariable="";

            switch (tipoSeccion)
            {
                case "TODOS": seccionVariable = "";
                    seccionGroup = "T_cobro,";
                    seleccionCase = ",case t_cobro when 1 then 'RETENCION' when 2 then 'RECURSOS PROPIOS' when 3 then 'EVENTUALES' when 4 then 'OTROS' ELSE 'SIN TIPO' END AS Seccion";
                    break;
                case "RETENCION": seccionVariable = "and T_cobro=1";
                    seccionGroup = "T_cobro,";
                    seleccionCase = ",case t_cobro when 1 then 'RETENCION' when 2 then 'RECURSOS PROPIOS' when 3 then 'EVENTUALES' when 4 then 'OTROS' ELSE 'SIN TIPO' END AS Seccion";
                    break;
                case "RECURSOS PROPIOS": seccionVariable = "and T_cobro=2";
                    seccionGroup = "T_cobro,";
                    seleccionCase = ",case t_cobro when 1 then 'RETENCION' when 2 then 'RECURSOS PROPIOS' when 3 then 'EVENTUALES' when 4 then 'OTROS' ELSE 'SIN TIPO' END AS Seccion";
                    break;
                case "EVENTUALES": seccionVariable = "and T_cobro=3";
                    seccionGroup = "T_cobro,";
                    seleccionCase = ",case t_cobro when 1 then 'RETENCION' when 2 then 'RECURSOS PROPIOS' when 3 then 'EVENTUALES' when 4 then 'OTROS' ELSE 'SIN TIPO' END AS Seccion";
                    break;
                case "OTROS": seccionVariable = "and T_cobro=4";
                    seccionGroup = "T_cobro,";
                    seleccionCase = ",case t_cobro when 1 then 'RETENCION' when 2 then 'RECURSOS PROPIOS' when 3 then 'EVENTUALES' when 4 then 'OTROS' ELSE 'SIN TIPO' END AS Seccion";
                    break;
            }
            switch (tipoperiodo)
            {
                case "TODOS": PeriodoVariable = "";
                    break;
                case "AYUNTAMIENTOS": PeriodoVariable = " and organismo=3";
                    break;
                case "ORGANISMOS": PeriodoVariable = " and organismo<>3";
                    break;
                default: PeriodoVariable = "";
                    break;
                
            }

            switch (filtro)
            {
                case 1:
                     strSql = "select TOP(30) localidad,organismo,nomlocalidad as 'Localidades',nomOrganismo as 'Organismos',mensual as 'Periodo',count(*) as 'No. empleados',CONVERT(varchar(50),CONVERT(money,sum(C_FondoPens)), 1) as 'Total F.P.',case tqna when 'M' then 'MENSUAL' when '1' then 'QUINCENA 1' when '2' then 'QUINCENA 2' END AS Nomina," +
                        "Fechapagado as 'Fecha Subido', case visto when 0 then 'No Revisado' when 1 then 'Revisado' end as 'Acción' " + seleccionCase + " from liquidacion where pagado=1 and tipoGeneracion not in ('I','P') and C_fondoPens <> 0 and visto=0 " + seccionVariable + "" + PeriodoVariable +
                        " group by " + seccionGroup + " organismo,localidad,nomlocalidad,nomorganismo,mensual, tqna,fechapagado,visto "+
                        " order by fechapagado desc,mensual desc, localidad, organismo";
                    break;
                case 2: 
                     strSql = "select localidad,organismo,nomlocalidad as 'Localidades',nomOrganismo as 'Organismos',mensual as 'Periodo',count(*) as 'No. empleados',CONVERT(varchar(50),CONVERT(money,sum(C_FondoPens)), 1) as 'Total F.P.',case tqna when 'M' then 'MENSUAL' when '1' then 'QUINCENA 1' when '2' then 'QUINCENA 2' END AS Nomina," +
                          "Fechapagado as 'Fecha Subido', case visto when 0 then 'No Revisado' when 1 then 'Revisado' end as 'Acción' " + seleccionCase + " from liquidacion where pagado=1 and tipoGeneracion not in ('I','P') and C_fondoPens <> 0  and mensual=" + intPeriodo + "" + seccionVariable + "" + PeriodoVariable +
                          " group by " + seccionGroup + " organismo,localidad,nomlocalidad,nomorganismo,mensual, tqna,fechapagado,visto " +
                          " order by fechapagado desc,mensual desc, localidad, organismo";
                    break;
               
            }
            var cns = GetConnection(ConnectionStrings.Ingresos);
            adapt.SelectCommand = new SqlCommand(strSql, cns);
            var DtContenido = Dt.Copy();

            try
            {
                cns.Open();
                adapt.Fill(DtContenido);
            }
            catch (SqlException ex)
            {
                MessageBox.Show("No se pudo consultar la base de datos, error : " + ex.Message, "..:: MENSAJE DESDE LA CLASE DATA ::..", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió el siguiente error :" + ex.Message, "..:: MENSAJE DESDE LA CLASE DATA ::..", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                cns.Close();
            }
            return DtContenido;

        }
        public DataTable NominasLiberadasInicio()
        {
           
            string strSql = "";
            strSql = "select localidad,organismo,nomlocalidad as 'Localidades',nomOrganismo as 'Organismos',mensual as 'Periodo',count(*) as 'No. empleados',CONVERT(varchar(50),CONVERT(money,sum(C_FondoPens)), 1) as 'Total F.P.',case tqna when 'M' then 'MENSUAL' when '1' then 'QUINCENA 1' when '2' then 'QUINCENA 2' END AS Nomina, Fechapagado as 'Fecha Subido', case visto when 0 then 'No Revisado' when 1 then 'Revisado' end as 'Acción' from liquidacion where pagado=1 and t_cobro not in(5,6) and C_fondoPens <> 0 group by  organismo,localidad,nomlocalidad,nomorganismo,mensual, tqna,fechapagado,visto order by fechapagado desc,mensual desc, localidad, organismo";
            var cns = GetConnection(ConnectionStrings.Ingresos);
            adapt.SelectCommand = new SqlCommand(strSql, cns);
            var DtContenido = Dt.Copy();

            try
            {
                cns.Open();
                adapt.Fill(DtContenido);
            }
            catch (SqlException ex)
            {
                MessageBox.Show("No se pudo consultar la base de datos, error : " + ex.Message, "..:: MENSAJE DESDE LA CLASE DATA ::..", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió el siguiente error :" + ex.Message, "..:: MENSAJE DESDE LA CLASE DATA ::..", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                cns.Close();
            }
            return DtContenido;
        }
        public bool NominasRevisadas(int loc, int org, int periodo, string nomina, int seccion)
        {
            string strSql = "", secc="";
            switch(seccion)
            {
                case 1: secc = " and T_cobro=1";
                break;
                case 2: secc = " and T_cobro=2";
                break;
                case 3: secc = " and T_cobro=3";
                break;
            }

            strSql = "update liquidacion set visto=1 where localidad=" + loc + " and organismo=" + org + " and mensual=" + periodo + " and tqna='" + nomina + "' "+secc;
            var cns = GetConnection(ConnectionStrings.Ingresos);
            adapt.SelectCommand = new SqlCommand(strSql, cns);
            var DtContenido = Dt.Copy();
            bool respuesta=false;
            try
            {
                cns.Open();
                adapt.Fill(DtContenido);
            }
            catch (SqlException ex)
            {
                MessageBox.Show("No se pudo consultar la base de datos, error : " + ex.Message, "..:: MENSAJE DESDE LA CLASE DATA ::..", MessageBoxButtons.OK, MessageBoxIcon.Error);
                respuesta=false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió el siguiente error :" + ex.Message, "..:: MENSAJE DESDE LA CLASE DATA ::..", MessageBoxButtons.OK, MessageBoxIcon.Error);
                respuesta=false;
            }
            finally
            {
                cns.Close();
                respuesta=true;
            }

            return respuesta;
        }
        public DataTable AportacionesAplicadas(int loc, int org, int fecha1, int fecha2, string tn)
        {
            string strSql = "select a.alocalidad as locInt, a.aorganismo as orgInt,l.descripcion as Localidad,o.descripcion as Organismo,"+
           "CONVERT(VARCHAR,CAST(sum(a.aimporte) AS MONEY),1) as TFP, count(*) as 'No. empleados', a.aquincena as Periodo ,"+
           "a.atipodecotizacion as Nomina,"+
           " case alocalidadini when '999' then 'RETENCION' when '992' then 'RECURSOS PROPIOS' when '993' then 'EVENTUALES' when '994' then 'OTROS' ELSE 'SIN TIPO' END AS Seccion"+
           " from creditos.dbo.aportaciones a inner join ingresos.dbo.localidades l on a.alocalidad=l.codigo"+
           " inner join ingresos.dbo.organismos o on a.aorganismo=o.codigo where atipodemovto='FP' and "+
           " aquincena between " + fecha1 + " and " + fecha2 + " and aorganismo = " + org +
           " and alocalidad=" + loc + " and atipodecotizacion='"+tn+"' group by a.alocalidad,a.aorganismo,l.descripcion,o.descripcion,a.aquincena,a.atipodecotizacion,alocalidadini";
          var cns = GetConnection(ConnectionStrings.Ingresos);
          adapt.SelectCommand = new SqlCommand(strSql, cns);
          var DtContenido = Dt.Copy();
        
          try
          {
              cns.Open();
              adapt.Fill(DtContenido);
          }
          catch (SqlException ex)
          {
              MessageBox.Show("No se pudo consultar la base de datos, error : " + ex.Message, "..:: MENSAJE DESDE LA CLASE DATA ::..", MessageBoxButtons.OK, MessageBoxIcon.Error);
          }
          catch (Exception ex)
          {
              MessageBox.Show("Ocurrió el siguiente error :" + ex.Message, "..:: MENSAJE DESDE LA CLASE DATA ::..", MessageBoxButtons.OK, MessageBoxIcon.Error); 
          }
          finally
          {
              cns.Close();
          }

          return DtContenido;

           
        }
        public DataTable AportacionesAplicadasXorganismos(int org, int fecha1, int fecha2,string tn)
        {
            string strSql = "select a.alocalidad as locInt, a.aorganismo as orgInt,l.descripcion as Localidad,o.descripcion as Organismo,"+
           "CONVERT(VARCHAR,CAST(sum(a.aimporte) AS MONEY),1) as TFP, count(*) as 'No. empleados', a.aquincena as Periodo ,"+
           "a.atipodecotizacion as Nomina,"+
           " case alocalidadini when '999' then 'RETENCION' when '992' then 'RECURSOS PROPIOS' when '993' then 'EVENTUALES' when '994' then 'OTROS' ELSE 'SIN TIPO' END AS Seccion"+
           " from creditos.dbo.aportaciones a inner join ingresos.dbo.localidades l on a.alocalidad=l.codigo"+
           " inner join ingresos.dbo.organismos o on a.aorganismo=o.codigo where atipodemovto='FP' and "+
           " aquincena between " + fecha1 + " and " + fecha2 + " and aorganismo = " + org +" and atipodecotizacion="+tn+
                                " group by a.alocalidad,a.aorganismo,l.descripcion,o.descripcion,a.aquincena,a.atipodecotizacion,alocalidadini";

            var cns = GetConnection(ConnectionStrings.Ingresos);
            adapt.SelectCommand = new SqlCommand(strSql, cns);
            var DtContenido = Dt.Copy();

            try
            {
                cns.Open();
                adapt.Fill(DtContenido);
            }
            catch (SqlException ex)
            {
                MessageBox.Show("No se pudo consultar la base de datos, error : " + ex.Message, "..:: MENSAJE DESDE LA CLASE DATA ::..", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió el siguiente error :" + ex.Message, "..:: MENSAJE DESDE LA CLASE DATA ::..", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                cns.Close();
            }

            return DtContenido;
        }
        public DataTable AportacionesCeroAplicadas(int loc, int org, int fecha1, int fecha2,string tn)
        {
            string strSql = "  select a.apclocalidad,a.apcorganismo,l.descripcion,o.descripcion,count(*) as 'N° Empleados', sum(a.apcimporte) as Total,a.apcquincena as Periodo, a.apctipodecotizacion as Nomina from " +
            "creditos.dbo.aportac_pencero a inner join ingresos.dbo.localidades l on a.apclocalidad=l.codigo inner join ingresos.dbo.organismos o on a.apcorganismo=o.codigo " +
            " where apclocalidad="+loc+" and apcorganismo="+org+" and apcquincena between "+fecha1+" and "+fecha2+" and apctipodemovto='FP' and apctipodecotizacion='"+tn+"' " +
            " group by a.apcquincena,a.apcorganismo, a.apclocalidad,a.apctipodecotizacion,l.descripcion,o.descripcion ";
            var cns = GetConnection(ConnectionStrings.Ingresos);
            adapt.SelectCommand = new SqlCommand(strSql, cns);
            var DtContenido = Dt.Copy();

            try
            {
                cns.Open();
                adapt.Fill(DtContenido);
            }
            catch (SqlException ex)
            {
                MessageBox.Show("No se pudo consultar la base de datos, error : " + ex.Message, "..:: MENSAJE DESDE LA CLASE DATA ::..", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió el siguiente error :" + ex.Message, "..:: MENSAJE DESDE LA CLASE DATA ::..", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                cns.Close();
            }

            return DtContenido;
        }
        public DataTable AportacionesCeroAplicadasXorganismos(int org, int fecha1, int fecha2,string tn)
        {

            string strSql = "select count(*) as 'N° Empleados', sum(apcimporte) as Total,apcquincena as Periodo,apclocalidad,apcorganismo ,apctipodecotizacion as Nomina from creditos.dbo.aportac_pencero " +
                                "where apcorganismo=" + org + " and apcquincena between " + fecha1 + " and " + fecha2 + " and apctipodemovto='FP' " + " and apctipodecotizacion='" + tn +"'"+
                                "group by apcquincena,apcorganismo,apclocalidad,apctipodecotizacion";

           var cns = GetConnection(ConnectionStrings.Ingresos);
           adapt.SelectCommand = new SqlCommand(strSql, cns);
           var DtContenido = Dt.Copy();

           try
           {
               cns.Open();
               adapt.Fill(DtContenido);
           }
           catch (SqlException ex)
           {
               MessageBox.Show("No se pudo consultar la base de datos, error : " + ex.Message, "..:: MENSAJE DESDE LA CLASE DATA ::..", MessageBoxButtons.OK, MessageBoxIcon.Error);
           }
           catch (Exception ex)
           {
               MessageBox.Show("Ocurrió el siguiente error :" + ex.Message, "..:: MENSAJE DESDE LA CLASE DATA ::..", MessageBoxButtons.OK, MessageBoxIcon.Error);
           }
           finally
           {
               cns.Close();
           }

           return DtContenido;

        }
        public DataTable DetallesAportaciones(int loc, int org, int mensual,string tn, string tc)
        {
            switch (tc)
            {
                case "TODOS": tc = "999";
                    break;
                case "RETENCION": tc = "999";
                    break;
                case "RECURSOS PROPIOS": tc = "992";
                    break;
                case "EVENTUALES": tc = "993";
                    break;
                case "OTROS": tc = "994";
                    break;
            }


            string strSql = "select a.alocalidad as locInt, a.aorganismo as orgInt,l.descripcion as Localidad,o.descripcion as Organismo,"+
           "a.apension as 'No. Pensión',V.tpaterno,V.tmaterno,V.tnombre,a.aimporte as TFP,a.aquincena as Periodo,a.atipodecotizacion as Nomina,alocalidadini from creditos.dbo.aportaciones a "+
           "inner join sipesdb.dbo.trabajadores V on V.tpension= a.apension "+
           "inner join ingresos.dbo.localidades l on a.alocalidad=l.codigo "+
           "inner join ingresos.dbo.organismos o on a.aorganismo=o.codigo "+
           "where aquincena="+mensual+" and alocalidad in("+loc+") and aorganismo="+org+" and atipodecotizacion='"+tn+"' and alocalidadini="+tc+" order by alocalidadini";
            var cns = GetConnection(ConnectionStrings.Ingresos);
            adapt.SelectCommand = new SqlCommand(strSql, cns);
            var DtContenido = Dt.Copy();

            try
            {
                cns.Open();
                adapt.Fill(DtContenido);
            }
            catch (SqlException ex)
            {
                MessageBox.Show("No se pudo consultar la base de datos, error : " + ex.Message, "..:: MENSAJE DESDE LA CLASE DATA ::..", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió el siguiente error :" + ex.Message, "..:: MENSAJE DESDE LA CLASE DATA ::..", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                cns.Close();
            }

            return DtContenido;
        }
        public DataTable DetallesAportacionesZero(int loc, int org, int mensual, string tn, string tc)
        {

            switch (tc)
            {
                case "TODOS": tc = "999";
                    break;
                case "RETENCION": tc = "999";
                    break;
                case "RECURSOS PROPIOS": tc = "992";
                    break;
                case "EVENTUALES": tc = "993";
                    break;
                case "OTROS": tc = "994";
                    break;
            }
            string strSql = "select a.apclocalidad as locInt, a.apcorganismo as orgInt,l.descripcion as Localidad,o.descripcion as Organismo, " +
            "a.apcpension as 'No. Pensión',a.apcnombre as 'Empleado',a.apcimporte as TFP,a.apcquincena as Periodo " +
            " from creditos.dbo.aportac_pencero a inner join ingresos.dbo.localidades l on a.apclocalidad=l.codigo " +
            " inner join ingresos.dbo.organismos o on a.apcorganismo=o.codigo where apcquincena="+mensual+" and " +
            " apclocalidad in("+loc+") and apcorganismo="+org+" and apctipodecotizacion='"+tn+"' and apcingresos="+tc;
       
            var cns = GetConnection(ConnectionStrings.Ingresos);
            adapt.SelectCommand = new SqlCommand(strSql, cns);
            var DtContenido = Dt.Copy();

            try
            {
                cns.Open();
                adapt.Fill(DtContenido);
            }
            catch (SqlException ex)
            {
                MessageBox.Show("No se pudo consultar la base de datos, error : " + ex.Message, "..:: MENSAJE DESDE LA CLASE DATA ::..", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió el siguiente error :" + ex.Message, "..:: MENSAJE DESDE LA CLASE DATA ::..", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                cns.Close();
            }

            return DtContenido;
            
        }
        public bool VerificarAportaciones(int org, int loc, int mensual, int mensualQ, string nomina, string seccion)
        {
            string strSql = "";
            string seccionVariable = "";
            string tipoNomina = "";
            int periodo = 0;
            switch (seccion)
            {
                case "RETENCION": seccionVariable = "and alocalidadini=999";
                    break;
                case "RECURSOS PROPIOS": seccionVariable = "and alocalidadini=992";
                    break;
                case "EVENTUALES": seccionVariable = "and alocalidadini=993";
                    break;
                case "OTROS": seccionVariable = "and alocalidadini=994";
                    break;
                default: seccionVariable = "and alocalidadini=999";
                    break;
            }
            if (nomina == "M")
            {
                tipoNomina = "M";
                periodo = mensual;
            }
            else
            {
                tipoNomina = "Q";
                periodo = mensualQ;
            }
          
            //creditos.dbo.aportaciones

            
            strSql = "select * from creditos.dbo.aportaciones where aquincena=" + periodo + " and alocalidad in(" + loc + ") and aorganismo=" + org + " and atipodecotizacion='"+tipoNomina+"' " + seccionVariable;
               
           
            var cns = GetConnection(ConnectionStrings.Ingresos);
            adapt.SelectCommand = new SqlCommand(strSql, cns);
            var DtCheckAportaciones = Dt.Copy();

            try
            {
                cns.Open();
                adapt.Fill(DtCheckAportaciones);
            }
            catch (SqlException ex)
            {
                MessageBox.Show("No se pudo consultar la base de datos, error : " + ex.Message, "..:: MENSAJE DESDE LA CLASE DATA ::..", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió el siguiente error :" + ex.Message, "..:: MENSAJE DESDE LA CLASE DATA ::..", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                cns.Close();
            }
            if (DtCheckAportaciones.Rows.Count == 0) { return true; }
            else { return false; }
        }
        public bool AportacionesSN(int mensual, int loc, int org, string nomina, int mensualQ, string seccion)
        {
            string seccionVariable = "";

            switch (seccion)
            {
                case "RETENCION": seccionVariable = "and T_cobro=1";
                    break;
                case "RECURSOS PROPIOS": seccionVariable = "and T_cobro=2";
                    break;
                case "EVENTUALES": seccionVariable = "and T_cobro=3";
                    break;
            }
            DataTable dtLiquidacion = new DataTable();
            DataTable dtAportaTabla = new DataTable();
            bool respuesta = false;
            string strSql = "";
            int cont = 0, tipoCobro=0;
            strSql = "select * from ingresos.dbo.liquidacion where mensual = " + mensual + " and organismo = " + org + " and pension <> 0 " +
                          " and tipoGeneracion not in ('I','P') and localidad in (" + loc + ") and pagado=1 and C_fondoPens <> 0 and tqna='" + nomina + "' " + seccionVariable;
            var cns = GetConnection(ConnectionStrings.Ingresos);
            adapt.SelectCommand = new SqlCommand(strSql, cns);
            //var DtCheckLiquidacion = Dt.Copy();
            dtLiquidacion = Dt.Copy();
           // adapt.SelectCommand.CommandTimeout = 500;
            try
            {
                cns.Open();
                adapt.Fill(dtLiquidacion);

            }
            catch (SqlException ex)
            {
                MessageBox.Show("No se pudo consultar la base de datos, error : " + ex.Message, "..:: MENSAJE DESDE LA CLASE DATA ::..", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió el siguiente error :" + ex.Message, "..:: MENSAJE DESDE LA CLASE DATA ::..", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
             cns.Close();
             if (dtLiquidacion.Rows.Count != 0)
             {
                 string strSqlEstruct = "select top 1 * from creditos.dbo.aportaciones";
                 var con = GetConnection(ConnectionStrings.Ingresos);
                 adapt.SelectCommand = new SqlCommand(strSqlEstruct, con);
                 dtAportaTabla = Dt.Copy();
                 adapt.SelectCommand.CommandTimeout = 9000;
     
                 try
                 {
                     con.Open();
                     adapt.Fill(dtAportaTabla);
                     dtAportaTabla.Rows.Clear();

                     foreach (DataRow row in dtLiquidacion.Rows)
                     {

                         DataRow rowFiltro = dtAportaTabla.NewRow();
                         rowFiltro["aconsecutivo"] = row["control"];
                         rowFiltro["apension"] = row["pension"];
                         rowFiltro["alocalidad"] = row["localidad"];
                         rowFiltro["aimporte"] = row["c_fondopens"];
                         rowFiltro["atipodemovto"] = "FP";
                         if (nomina == "M")
                         {
                             rowFiltro["atipodecotizacion"] = "M";
                             rowFiltro["aquincena"] = row["mensual"];
                         }
                         else
                         {
                             rowFiltro["atipodecotizacion"] = "Q";
                             rowFiltro["aquincena"] = mensualQ;
                         }

                         rowFiltro["aorganismo"] = row["organismo"];

                         rowFiltro["aconceptonom"] = 1;
                         string tqna = "";
                         tqna = row["tqna"].ToString();
                         
                         tipoCobro = Convert.ToInt32(row["T_cobro"]);
                         
                         if (tipoCobro == 1)
                         {
                           rowFiltro["alocalidadini"] = 999;
                         }
                         else if (tipoCobro == 2)
                         {
                            rowFiltro["alocalidadini"] = 992;
                         }
                         else if (tipoCobro == 3)
                         {
                            rowFiltro["alocalidadini"] = 993;
                         }
                         else if (tipoCobro == 4)
                         {
                            rowFiltro["alocalidadini"] = 994;
                         }
                         else
                         {
                             rowFiltro["alocalidadini"] = 999;
                         }

                         dtAportaTabla.Rows.Add(rowFiltro);
                         cont = cont + 1;

                     }
                     using (var sqlBulk = new SqlBulkCopy(con))
                     {
                         sqlBulk.DestinationTableName = "creditos.dbo.aportaciones";
                         sqlBulk.WriteToServer(dtAportaTabla);
                     }
                     respuesta = true;

                 }
                 catch (SqlException ex)
                 {
                     MessageBox.Show("No se pudo consultar la base de datos, error : " + ex.Message, "..:: MENSAJE DESDE LA CLASE DATA ::..", MessageBoxButtons.OK, MessageBoxIcon.Error);
                 }
                 catch (Exception ex)
                 {
                     MessageBox.Show("Ocurrió el siguiente error :" + ex.Message, "..:: MENSAJE DESDE LA CLASE DATA ::..", MessageBoxButtons.OK, MessageBoxIcon.Error);
                 }
                 finally
                 {
                     con.Close();
                 }
             }
             else
             {
                 //MessageBox.Show("Periodo No generado!..." , "..:: MENSAJE DESDE LA CLASE DATA ::..", MessageBoxButtons.OK, MessageBoxIcon.Error);
                 respuesta = false;
             }


            }


            return respuesta; 
        }
        public bool AportacionesSNZero(int mensual, int loc, int org, string nomina, int mensualQ,string seccion)
        {
           string strSql = "";
           string seccionVariable = "";

           switch (seccion)
           {
               case "RETENCION": seccionVariable = "and T_cobro=1";
                   break;
               case "RECURSOS PROPIOS": seccionVariable = "and T_cobro=2";
                   break;
               case "EVENTUALES": seccionVariable = "and T_cobro=3";
                   break;
               case "OTROS": seccionVariable = "and T_cobro=4";
                   break;
               default : seccionVariable = "and T_cobro=1";
                   break;
           }
           DataTable dtLiquidacion = new DataTable();
           DataTable dtAportaTabla = new DataTable();
           bool respuesta = false;
           int cont = 0;
           strSql = "select * from ingresos.dbo.liquidacion where mensual = " + mensual + " and organismo = " + org +
                    " and tipoGeneracion not in ('I','P') and localidad in (" + loc + ") and pagado=1 and pension=0 and tqna='" + nomina + "' " + seccionVariable ;

           var cns = GetConnection(ConnectionStrings.Ingresos);
           adapt.SelectCommand = new SqlCommand(strSql, cns);
           dtLiquidacion = Dt.Copy();
            try
            {
                cns.Open();
                adapt.Fill(dtLiquidacion);

            }
            catch (SqlException ex)
            {
                MessageBox.Show("No se pudo consultar la base de datos, error : " + ex.Message, "..:: MENSAJE DESDE LA CLASE DATA ::..", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió el siguiente error :" + ex.Message, "..:: MENSAJE DESDE LA CLASE DATA ::..", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                cns.Close();
                if (dtLiquidacion.Rows.Count != 0)
                {
                    string strSqlEstruct = "select top 1 * from creditos.dbo.aportac_pencero";
                    var con = GetConnection(ConnectionStrings.Ingresos);
                    adapt.SelectCommand = new SqlCommand(strSqlEstruct, con);
                    dtAportaTabla = Dt.Copy();
                    try
                    {
                        con.Open();
                        adapt.Fill(dtAportaTabla);
                        dtAportaTabla.Rows.Clear();

                        foreach (DataRow row in dtLiquidacion.Rows)
                        {

                            DataRow rowFiltro = dtAportaTabla.NewRow();
                            rowFiltro["apcpension"] = 0;
                            rowFiltro["apcnombre"] = row["nombre"];
                            rowFiltro["apclocalidad"] = row["localidad"];
                            rowFiltro["apcorganismo"] = row["organismo"];
                            if (nomina != "M")
                            {
                                rowFiltro["apcquincena"] = mensualQ;
                                rowFiltro["apctipodecotizacion"] = "Q";
                            }
                            else
                            {
                                rowFiltro["apcquincena"] = row["mensual"];
                                rowFiltro["apctipodecotizacion"] = "M";
                            }
                            rowFiltro["apcimporte"] = row["C_FondoPens"];
                            rowFiltro["apctipodemovto"] = "FP";
                            rowFiltro["apcconceptonom"] = 1;
                            int tipoCobro = Convert.ToInt32(row["T_cobro"]);
                               
                            if (tipoCobro == 1)
                            {
                               rowFiltro["apcingresos"] = 999;
                            }
                            else if (tipoCobro == 2)
                            {
                               rowFiltro["apcingresos"] = 992;
                            }
                            else if (tipoCobro == 3)
                            {
                               rowFiltro["apcingresos"] = 993;
                            }
                            else if (tipoCobro == 4)
                            {
                                rowFiltro["apcingresos"] = 994;
                            }
                            else
                            {
                               rowFiltro["apcingresos"] = 999;
                            }
                                    
                                
                                
                         

                            dtAportaTabla.Rows.Add(rowFiltro);
                            cont = cont + 1;

                        }
                        using (var sqlBulk = new SqlBulkCopy(con))
                        {
                            sqlBulk.DestinationTableName = "creditos.dbo.aportac_pencero";
                            sqlBulk.WriteToServer(dtAportaTabla);
                        }
                        respuesta = true;

                    }
                    catch (SqlException ex)
                    {
                        MessageBox.Show("No se pudo consultar la base de datos, error : " + ex.Message, "..:: MENSAJE DESDE LA CLASE DATA ::..", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Ocurrió el siguiente error :" + ex.Message, "..:: MENSAJE DESDE LA CLASE DATA ::..", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally
                    {
                        con.Close();
                    }
                }
                else
                {
                    //MessageBox.Show("Periodo No generado!..." , "..:: MENSAJE DESDE LA CLASE DATA ::..", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    respuesta = false;
                }
            }
            return respuesta; 
        }
        public DataTable AportacionesResumen(int mensual, int loc, int org, string nomina, int mensualQ, string seccion)
        {
            string seccionVariable = "";
            switch (seccion)
            {
                case "RETENCION": seccionVariable = "999";
                    break;
                case "RECURSOS PROPIOS": seccionVariable = "992";
                    break;
                case "EVENTUALES": seccionVariable = "993";
                    break;
                case "OTROS": seccionVariable = "994";
                    break;
                default: seccionVariable = "999";
                    break;
            }

           string strSql = "";
           if (nomina != "M")
            {
                mensual = mensualQ;
               nomina="Q";
            }
           strSql = "select a.alocalidad as locInt, a.aorganismo as orgInt,l.descripcion as Localidad,o.descripcion as Organismo,sum(a.aimporte) as TFP, count(*) as 'No. empleados', a.aquincena as Periodo from creditos.dbo.aportaciones a inner join ingresos.dbo.localidades l on a.alocalidad=l.codigo inner join ingresos.dbo.organismos o on a.aorganismo=o.codigo where aquincena = " + mensual + " and aorganismo = " + org +
                        " and alocalidad in (" + loc + ") and alocalidadini='" + seccionVariable + "' and atipodecotizacion='"+nomina+"' group by a.alocalidad,a.aorganismo,l.descripcion,o.descripcion,a.aquincena";
           
           var con = GetConnection(ConnectionStrings.Ingresos);
           adapt.SelectCommand = new SqlCommand(strSql, con);
           var DtResumen= Dt.Copy();
           try
           {
               con.Open();
               adapt.Fill(DtResumen);
           }
           catch (SqlException ex)
           {
               MessageBox.Show("No se pudo consultar la base de datos, error : " + ex.Message, "..:: MENSAJE DESDE LA CLASE DATA ::..", MessageBoxButtons.OK, MessageBoxIcon.Error);
           }
           catch (Exception ex)
           {
               MessageBox.Show("Ocurrió el siguiente error :" + ex.Message, "..:: MENSAJE DESDE LA CLASE DATA ::..", MessageBoxButtons.OK, MessageBoxIcon.Error);
           }
           finally
           {
               con.Close();
           }
           return DtResumen;

         
        }
        public DataTable AportacionesZeroResumen(int mensual, int loc, int org, string nomina, int mensualQ, string seccion)
        {
            string seccionVariable = "", tipoNomina="";
            int periodo = 0;
            switch (seccion)
            {
                case "RETENCION": seccionVariable = "999";
                    break;
                case "RECURSOS PROPIOS": seccionVariable = "992";
                    break;
                case "EVENTUALES": seccionVariable = "993";
                    break;
                case "OTROS": seccionVariable = "994";
                    break;
                default: seccionVariable = "999";
                    break;
            }
            //Organismos 
            if (nomina != "M")
            {
                periodo = mensualQ;
                tipoNomina = "Q";
                
            }
            else 
            {
                periodo = mensual;
                tipoNomina = "M";
            }
            string strSql = "";
           
            strSql = "select a.apclocalidad as locInt, a.apcorganismo as orgInt,l.descripcion as Localidad,o.descripcion as Organismo,sum(a.apcimporte) as TFP, count(*) as 'No. empleados', a.apcquincena as Periodo from creditos.dbo.aportac_pencero a inner join ingresos.dbo.localidades l on a.apclocalidad=l.codigo inner join ingresos.dbo.organismos o on a.apcorganismo=o.codigo where apcquincena = " + periodo + " and apcorganismo = " + org +
                      " and apclocalidad in (" + loc + ") and apcconceptonom=1 and apcingresos="+seccionVariable+" and apctipodecotizacion='"+tipoNomina+"' group by a.apclocalidad,a.apcorganismo,l.descripcion,o.descripcion,a.apcquincena";
            
            var con = GetConnection(ConnectionStrings.Ingresos);
            adapt.SelectCommand = new SqlCommand(strSql, con);
            var DtResumen = Dt.Copy();
            try
            {
                con.Open();
                adapt.Fill(DtResumen);
            }
            catch (SqlException ex)
            {
                MessageBox.Show("No se pudo consultar la base de datos, error : " + ex.Message, "..:: MENSAJE DESDE LA CLASE DATA ::..", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió el siguiente error :" + ex.Message, "..:: MENSAJE DESDE LA CLASE DATA ::..", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                con.Close();
            }
            return DtResumen;

           
        }
        public bool VerificarAportacionesZero(int mes, int org, int loc, int mensualQ, string nomina, string seccion)
        {
            string strSql = "";
            string seccionVariable = "";
            string tipoNomina = "";
            int periodo = 0;
            switch (seccion)
            {
                case "RETENCION": seccionVariable = "and apcingresos IN(999)";
                    break;
                case "RECURSOS PROPIOS": seccionVariable = "and apcingresos=992";
                    break;
                case "EVENTUALES": seccionVariable = "and apcingresos=993";
                    break;
                case "OTROS": seccionVariable = "and apcingresos=994";
                    break;
            }
            if (nomina == "M")
            {
                tipoNomina = "M";
                periodo = mes;
            }
            else
            {
                tipoNomina = "Q";
                periodo = mensualQ;
            }
            //Aytos individual creditos.dbo.aportac_pencero
           
           strSql = "select * from creditos.dbo.aportac_pencero where apctipodecotizacion='"+tipoNomina+"' and apcquincena=" + periodo+ " and apclocalidad in(" + loc + ") and apcorganismo=" + org + " " + seccionVariable;
                    
              
           

            var con = GetConnection(ConnectionStrings.Ingresos);
            adapt.SelectCommand = new SqlCommand(strSql, con);
            var DtVerificarCero = Dt.Copy();
            try
            {
                con.Open();
                adapt.Fill(DtVerificarCero);
            }
            catch (SqlException ex)
            {
                MessageBox.Show("No se pudo consultar la base de datos, error : " + ex.Message, "..:: MENSAJE DESDE LA CLASE DATA ::..", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió el siguiente error :" + ex.Message, "..:: MENSAJE DESDE LA CLASE DATA ::..", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                con.Close();
            }
            if (DtVerificarCero.Rows.Count == 0) { return true; }
            else { return false; }
             
            
        }







    }


}
