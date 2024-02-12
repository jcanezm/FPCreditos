using System;
using System.IO;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace FPcreditos.clases
{
        enum ConnectionStrings
        {
            Ingresos,
            SipesDb
        }
        class conexionI
        {
            protected SqlCommand comm = new SqlCommand();
            protected SqlCommandBuilder build = new SqlCommandBuilder();
            protected DataTable Dt = new DataTable();
            protected SqlDataAdapter adapt = new SqlDataAdapter();
            protected SqlDataReader read;


            public string strSql { get; set; }

            protected SqlConnection GetConnection(ConnectionStrings connectionString)
            {

                var str = string.Empty;

                switch (connectionString)
                {
                    case ConnectionStrings.Ingresos:
                        str = "server=ISSSTESON01;database=ingresos;User Id=ingresos;Pwd=ingresos";
                        break;
                    case ConnectionStrings.SipesDb:
                        str = "server=ISSSTESON01;database=ingresos;User Id=ingresos;Pwd=ingresos";
                        break;
                    default:
                        MessageBox.Show("Su coneccion a fallado o no esta conectado a internet", "..:: MENSAJE DEL SISTEMA ::..", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        break;
                }
                return new SqlConnection(str);

            }
        }
    
}
