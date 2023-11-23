using Microsoft.AspNetCore.Http;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace APIGenerator
{
    public partial class TestConnection : Form
    {
        private readonly APIGenerator _parent;

        public TestConnection(APIGenerator parent)
        {
            InitializeComponent();
            _parent = parent;


        }

        private void button3_Click(object sender, EventArgs e)
        {
            APIGenerator parentForm = new APIGenerator();

            string ConnectionString = "Server=tcp:" + txtServerName.Text.ToString() + ",1433;Initial Catalog=api_generator;Persist Security Info=False;User ID=" + txtUserName.Text.ToString() + ";Password=" + txtPassword.Text.ToString() + ";MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;";

            try
            {
                SqlConnection cnn = new SqlConnection(ConnectionString);
                cnn.Open();
                DialogResult result = MessageBox.Show("Connection Tested Succesfully !", "Success", MessageBoxButtons.OK);

                if (result == DialogResult.OK)
                {
                    
                    _parent.txtConnectionString.Text = ConnectionString;
                    _parent.txtConnectionString.ReadOnly = true;
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Connection failed! Please try with Valid credentials", "Failed", MessageBoxButtons.OK);
            }
        }

    }
}
