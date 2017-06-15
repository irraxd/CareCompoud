using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;

namespace CareCompoud_SQLite
{
        public partial class Login : Form
    {
        SQLiteConnection conexion;


        public Login()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
              try
            {
                conexion = new SQLiteConnection("Data Source= CareCompoud.sqlite");
                conexion.Open();
                MessageBox.Show("Conexión Exitosa");
            }
            catch (SQLiteException ex)
            {
                MessageBox.Show(ex.Message,"Error de Conexión");
            }
        }

        private void btnIniciar_Click(object sender, EventArgs e)
        {
            string usuario = txtUsuario.Text;
            string pass = txtPass.Text;

            MessageBox.Show("Bienvenido Usuario : "+usuario+"\n"+"Ventana");

            string query = "";
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
