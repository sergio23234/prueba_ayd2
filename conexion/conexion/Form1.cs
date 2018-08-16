using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Conexion
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MySqlConnection conexion = new MySqlConnection("server=35.202.163.254;database=pensum;uid=admin;pwd=1234");
            String usuario = textBox1.Text;
            String pass = textBox2.Text;
            conexion.Open();

            MySqlCommand comando = new MySqlCommand("select nombre from usuario where usuario = '"+usuario+"' and password = '"+pass+"';", conexion);
            MySqlDataReader myreader = comando.ExecuteReader();
            myreader.Read();
            try
            {
                String strnombre = myreader["nombre"].ToString();
                MessageBox.Show("Bien");
            }
            catch(Exception ex)
            {
                MessageBox.Show("Mal");
            }
            
            
        }
    }
}
