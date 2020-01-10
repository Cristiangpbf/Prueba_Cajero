using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Cajero
{
    public partial class LogIn : Form
    {
        public LogIn()
        {
            InitializeComponent();
        }
        
        public SqlConnection con = new SqlConnection("Data Source=DESKTOP-VHEG681;Initial Catalog=Cajero;Integrated Security=True");
        
        public void Logear(string num_tarj, string clave)
        {
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("Select ID_TARJ, ID_CUENTA, NUM_TARJ, CLAVE_TARJ FROM TARJETA WHERE NUM_TARJ = @NUMERO AND CLAVE_TARJ = @PASS",con);
                cmd.Parameters.AddWithValue("NUMERO", num_tarj);
                cmd.Parameters.AddWithValue("PASS", clave);
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                //Variables de datos de la sentencia SELECT
                int id_tarj = int.Parse(dt.Rows[0][0].ToString());
                int id_cuenta = int.Parse(dt.Rows[0][1].ToString());
                string numero_tarj = dt.Rows[0][2].ToString();
                string clave_tarj = dt.Rows[0][3].ToString();
                                               

                if (dt.Rows.Count == 1)
                {
                    this.Hide();
                    new Acciones(con,id_tarj).Show();
                }
                else
                {
                    MessageBox.Show("Número y/o contraseña incorrectos");
                    con.Close();
                }
            }
            catch(Exception e)
            {
                con.Close();
                MessageBox.Show(e.Message);                
            }           
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            
        }
               
        private void BotonAceptar_Click(object sender, EventArgs e)
        {
            Logear(this.textBox1.Text,this.textBox2.Text);
        }
    }
}
