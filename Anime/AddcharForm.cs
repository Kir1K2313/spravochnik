using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Anime
{
    public partial class AddcharForm : Form
    {
        public AddcharForm()
        {
            InitializeComponent();
            Text = "Добавление персонажа";
        }

        private void AddcharForm_Load(object sender, EventArgs e)
        {

        }

        private void NameTB_TextChanged(object sender, EventArgs e)
        {

        }

        private void statuslabel_Click(object sender, EventArgs e)
        {

        }

        private void Savebutton_Click(object sender, EventArgs e)
        {
            if(NameTB.Text == "")
            {
                MessageBox.Show("Заполните поля");
                return;
            }
            File.AppendAllText("characters.txt",
                 Environment.NewLine +
                 NameTB.Text + ", " +
                 rasaCB.Text + ", " +
                 statusCB.Text + ", " +
                 frakTB.Text);

            if (filename != "")
            {
                File.Copy(filename, "../../Pictures/" + NameTB.Text + ".jpg");
            }

            MessageBox.Show("Сохранено успешно");
            Close();
        }

        private void rasaCB_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

       private void frakTB_TextChanged(object sender, EventArgs e)
        {

        }
        string filename = "";
        private void button1_Click(object sender, EventArgs e)
        {
            if(openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                filename = openFileDialog1.FileName;
                pictureBox1.Load(filename);
            }
        }
    }
}
