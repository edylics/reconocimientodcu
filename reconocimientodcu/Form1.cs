using Emgu.CV;
using Emgu.CV.Structure;
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
    public partial class Form1 : Form
    {


        static readonly CascadeClassifier cascadeClassifier = new CascadeClassifier("haarcascade_frontalface_alt_tree.xml");
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog() { Multiselect = false, Filter = "JPEG, PNG|*.JPG;*.PNG" })
            {
                if (ofd.ShowDialog() == DialogResult.OK)
                {

                    pictureBox1.Image = Image.FromFile(ofd.FileName);
                    Bitmap bitmap = new Bitmap(pictureBox1.Image);
                    Image<Rgb, Byte> grayImage = new Image<Rgb, Byte>(bitmap);
                    Rectangle[] rectangles = cascadeClassifier.DetectMultiScale(grayImage, 1.4, 0);

                    foreach (Rectangle rectangulo in rectangles)
                    {
                        using (Graphics graphics = Graphics.FromImage(bitmap))
                        {
                            using (Pen lapiz = new Pen(Color.BlueViolet, 4))
                            {
                                graphics.DrawRectangle(lapiz, rectangulo);
                            }
                        }
                    }
                    pictureBox1.Image = bitmap;


                }
            }
        }


        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                OleDbConnection cnx = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0; Data Source =colegio.accdb;");
                OleDbCommand cmd = new OleDbCommand();

                cmd.Connection = cnx;
                cmd.CommandText = "INSERT INTO estudiantes Values (@num_unico, @Imagen, @Nombre, @Correo, @Telefono)";

                cmd.Parameters.Add("@num_unico", OleDbType.VarChar);
                cmd.Parameters.Add("@Imagen", OleDbType.VarBinary);
                cmd.Parameters.Add("@Nombre", OleDbType.VarChar);
                cmd.Parameters.Add("@Correo", OleDbType.VarChar);
                cmd.Parameters.Add("@Telefono", OleDbType.VarChar);

                cmd.Parameters["@num_unico"].Value = txtNum.Text;
                cmd.Parameters["@Nombre"].Value = txtNombre.Text;
                cmd.Parameters["@Correo"].Value = txtCorreo.Text;
                cmd.Parameters["@Telefono"].Value = txtTelefono.Text;

                System.IO.MemoryStream ms = new System.IO.MemoryStream();
                pictureBox1.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                cmd.Parameters["@Imagen"].Value = ms.GetBuffer();

                cnx.Open();
                cmd.ExecuteNonQuery();
                cnx.Close();

                MessageBox.Show("Agregado con exito!");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

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

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();

            Form2 frm = new Form2();

            frm.Show();
        }
    }
}
