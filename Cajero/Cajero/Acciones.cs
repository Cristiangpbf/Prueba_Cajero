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


namespace Cajero
{
    
    public partial class Acciones : Form
    {
        
        string a, b, c;
        public Acciones(SqlConnection con, int id_tarj)
        {
            InitializeComponent();
            groupConsulta.Hide();
            SqlCommand cmd_nombre = new SqlCommand("select * from USUARIO,CUENTA,TARJETA where usuario.ID_USER = CUENTA.ID_USER and CUENTA.ID_CUENTA =TARJETA.ID_CUENTA and TARJETA.ID_TARJ = @CUENTA;", con);
            cmd_nombre.Parameters.AddWithValue("CUENTA", id_tarj);
            SqlDataAdapter sda2 = new SqlDataAdapter(cmd_nombre);
            DataTable dt_nombre = new DataTable();
            sda2.Fill(dt_nombre);

            labelNombre.Text = (dt_nombre.Rows[0][1].ToString())+"  "+(dt_nombre.Rows[0][2].ToString());
            //new Consulta(dt_nombre.Rows[0][9].ToString(), dt_nombre.Rows[0][8].ToString(), dt_nombre.Rows[0][10].ToString()).Hide();
            a = dt_nombre.Rows[0][9].ToString();
            b = dt_nombre.Rows[0][8].ToString();
            c = dt_nombre.Rows[0][10].ToString();
        }

        private void Acciones_Load(object sender, EventArgs e)
        {

        }

        private void buttonVolver_Click(object sender, EventArgs e)
        {
            groupConsulta.Hide();

        }

        private void buttonSalirConsulta_Click(object sender, EventArgs e)
        {            
            this.Hide();
            new LogIn().Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            groupConsulta.Show();
            label_cuenta.Text = a;
            label_tipoCuenta.Text = b;
            label_saldo.Text = c;
            //buttonConsulta.Hide();
            //buttonRetiro.Hide();
            //buttonSalir.Hide();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            
        }
    }
}
