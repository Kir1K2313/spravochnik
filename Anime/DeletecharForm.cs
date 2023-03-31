using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Security.AccessControl;

namespace Anime
{
    public partial class DeletecharForm : Form
    {
        public DeletecharForm()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void DeletecharForm_Load(object sender, EventArgs e)
        {
            File.Delete("characters.txt");
            for (int i=0; i< filterForm.characters_list.Count; i++)
            {
                if (textBox1.Text == filterForm.characters_list[i].Name)
                {

                }
                else
                {
                    File.AppendAllText("characters.txt",
                    filterForm.characters_list[i].Name + ", " +
                    filterForm.characters_list[i].rasa + ", " +
                    filterForm.characters_list[i].status + ", " +
                    filterForm.characters_list[i].frak +
                    Environment.NewLine);
                }
            }
            MessageBox.Show("Удалено успешно");
            Close();
        }
    }
}
