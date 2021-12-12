using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace reconocimientodcu
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            listaEstudiantes(dataGridView1);
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        public static void listaEstudiantes(DataGridView data)
        {
            OleDbConnection cnx = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0; Data Source =colegio.accdb;");
            OleDbCommand cmd = new OleDbCommand();

            cmd.Connection = cnx;
            cnx.Open();
            OleDbCommand comando = new OleDbCommand("SELECT * FROM estudiantes", cnx);
            comando.Connection = cnx;
            comando.ExecuteNonQuery();
            DataTable dt = new DataTable();
            OleDbDataAdapter da = new OleDbDataAdapter(comando);
            
            da.Fill(dt);
            data.DataSource = dt;
            data.Columns[0].Width = 100;
            data.Columns[1].Width = 165;
            data.Columns[2].Width = 100;
            data.Columns[3].Width = 125;
            data.Columns[4].Width = 100;
            data.Columns[4].Width = 100;
            int cont = data.RowCount;
            int i;
            for (i = 0; i < cont; i++)
            {
                data.Rows[i].Height = 110;

            }


            cnx.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();

            Form1 frm = new Form1();

            frm.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DialogResult dialogo = MessageBox.Show("¿Desea cerrar el programa?",
                    "Cerrar el programa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogo == DialogResult.No)
            {

            }
            else
            {
                Application.Exit();
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }
    }
}
