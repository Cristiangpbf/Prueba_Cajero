﻿using System;
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
    public partial class Retirar : Form
    {
        public Retirar(SqlConnection con)
        {
            InitializeComponent();

        }

        private void Retirar_Load(object sender, EventArgs e)
        {

        }
    }
}
