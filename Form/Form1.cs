using FactsPro;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFs
{
    public partial class Form1 : Form
    {
        DBClass Db = new DBClass();
        public Form1()
        {
            InitializeComponent();
        }
        private int
        private void label1_Click(object sender, EventArgs e)
        {
            openFileDialog1.InitialDirectory = @"C:\\";
            openFileDialog1.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp|All Files|*.*";
            openFileDialog1.FilterIndex = 1;
            openFileDialog1.RestoreDirectory = true;

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {

                string filePath = openFileDialog1.FileName;
                byte[] imageData = File.ReadAllBytes(filePath);
                int id = Db.sendImage(imageData);
                pictureBox1.Image = Image.FromStream(Db.getImage(id));
                
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // pictureBox1.Image = Image.FromStream(Db.getImage());
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            string query = "";
            openFileDialog1.InitialDirectory = @"C:\\";
            openFileDialog1.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp|All Files|*.*";
            openFileDialog1.FilterIndex = 1;
            openFileDialog1.RestoreDirectory = true;

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {

                string filePath = openFileDialog1.FileName;
                byte[] imageData = File.ReadAllBytes(filePath);
                Db.updateImage( , imageData);
                pictureBox1.Image = Image.FromStream(Db.getImage(id));

            }
        }
    }
}
