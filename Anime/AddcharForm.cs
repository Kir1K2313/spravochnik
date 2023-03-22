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
            File.AppendAllText("characters.txt",
                 Environment.NewLine +
                 NameTB.Text + ", " +
                 rasaCB.Text + ", " +
                 statusTB.Text + ", " +
                 frakTB.Text);

            MessageBox.Show("Сохранено успешно");
        }
    }
}
