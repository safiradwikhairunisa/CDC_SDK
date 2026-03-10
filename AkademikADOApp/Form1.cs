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
using System.Configuration;

namespace AkademikADOApp
{
    public partial class Form1 : Form
    {
        // Connection String
        string connString = "Data Source=PIREE\\FIRA;Initial Catalog=AkademikDB;Integrated Security=True";

        //Object SQL Connection
        SqlConnection conn;

        public Form1()
        {
            InitializeComponent();
        }
    }
}
