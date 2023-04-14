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
    public partial class RegForm : Form
    {
        public RegForm()
        {
            InitializeComponent();
        }

        private void RegForm_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (NameTB.Text == "" || SecondNameTB.Text == ""
                || LoginTB.Text == "" || PasTB.Text == "" || Pas2TB.Text == "" )
            {
                MessageBox.Show("Заполните все поля!");
            }
            else
            if(PasTB.Text == Pas2TB.Text)
            {
                File.AppendAllText("users.txt",
                              NameTB.Text + ", " +
                              SecondNameTB.Text + ", " +
                              LoginTB.Text + ", " +
                              PasTB.Text + ", 0 " +
                              Environment.NewLine);
                MessageBox.Show("Регистрация успешно завершена!");
                Close();
            }
            else
            {
                MessageBox.Show("Пароли не совпадают");
            }
        }
    }
}
