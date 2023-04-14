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
    public partial class AuthForm : Form
    {
        public static string name = "";
        public static string secondname = "";
        public static bool Admin = false;
        public AuthForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string[] strs = File.ReadAllLines("users.txt");

            foreach (string str in strs)
           {
                string[] parts = str.Split(new string[] { ", " }, StringSplitOptions.None);
               //parts[0], parts[1], parts[2], parts[3]
               if(LoginTB.Text == parts[2] && PastTB.Text == parts[3])
              {
                  name = parts[0];
                  secondname = parts[1];
                  Admin = (parts[4] == "1");
                  Close();
                  return;
              }
           }
        }

        private void REGbutton_Click(object sender, EventArgs e)
        {
            RegForm reg = new RegForm();
            reg.ShowDialog();   
        }

        private void AuthForm_Load(object sender, EventArgs e)
        {

        }

        private void PastTB_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
