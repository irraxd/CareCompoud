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
        public partial class Form1 : Form
    {
        SQLiteConnection conexion;


        public Form1()
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
    }
}
