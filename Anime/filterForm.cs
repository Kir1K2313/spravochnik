using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Anime
{
     public struct characters
    {
       public string Name;
       public string rasa;
       public string stutus;
       public string mir;
       public Button btn;   
       public characters(string _Name, string _rasa, string _stutus, string _mir, Button _btn)
        {
            Name = _Name;
            rasa = _rasa;
            stutus = _stutus;
            mir = _mir;
            btn = _btn;
        }
        

    }

    public partial class filterForm : Form
    {
        characters[] characters_list = new characters[3];
        public filterForm()
        {
            InitializeComponent();

             characters_list[0] = new characters("Ичиго Куросаги", "Шинигами,Квинси,Пустой,Подчинитель,Вайзард","Живой","Мир людей");
             characters_list[1] = new characters("Киске Урахара", "Шинигами", "Живой", "Общество душ");
             characters_list[2] = new characters("Рукия Кучики", "Душа,Шинигами", "Живой", "Общество душ");
        }
        private void filterForm_Load(object sender, EventArgs e)
        {

        }

        private void Findbutton_Click(object sender, EventArgs e)
        {
            for(int i=0; i<3; i++)
            {
                if(comboBox1.Text == characters_list[i].rasa)
                {
                    MessageBox.Show(characters_list[i].rasa);
                }
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
