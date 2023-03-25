using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CosmosDBConnect
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void btnImportReadTable(object sender, EventArgs e)
        {

        }

        private void btnExportPostToDB(object sender, EventArgs e)
        {

        }

        private void btnCheaper(object sender, EventArgs e)
        {

        }

        private void btnOrderId(object sender, EventArgs e)
        {

        }

        private void btnImportNorthwind(object sender, EventArgs e)
        {
            /*//-------------------  Function to read a table from DB  --------------------
            //              --------------    -------------------
            public static DataTable DBGetTable(string SqlQuery)
            {
                //New DataTable
                DataTable dt = new DataTable();
                //Create a connection
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    //Execute the query
                    using (SqlCommand cmd = new SqlCommand(SqlQuery, con))
                    {
                        //Read the data
                        con.Open();
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            //Load the data into the DataTable
                            dt.Load(reader);
                        }
                    }
                }
                //return the DataTable with the data read from DB
                return dt;
            }*/
        }
    }
}
