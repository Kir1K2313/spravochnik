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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        public void button_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            Characters characters = new Characters(btn.Text);
            characters.Show();
        }
        

        private void filterbutton_Click(object sender, EventArgs e)
        {
            filterForm filter = new filterForm();
            filter.Show();
        }
        private void Selectbutton_Click(object sender, EventArgs e)
        {
            Select select = new Select();
            select.Show();
        }

        private void MainForm_Load(object sender, EventArgs e, filterForm filterForm)
        {
            filterForm.characters_list[0] = new characters("Ичиго Куросаки", "Человек", "Живой", "Мир людей");
            filterForm.characters_list[1] = new characters("Айзен Сосуке", "Душа", "Живой", "Он сам");
            filterForm.characters_list[2] = new characters("Киске Урахара", "Шинигами", "Неизвестно", "Общество душ");
            filterForm.characters_list[3] = new characters("Рукия Кучики", "Душа", "Живой", "Общество душ");
            filterForm.characters_list[4] = new characters("Хирако Шинджи", "Душа", "Живой", "Общество душ");
            filterForm.characters_list[5] = new characters("Ямамото Генрюсай", "Шинигами", "Живой", "Готей 13");
            filterForm.characters_list[6] = new characters("Унохана Рецу", "Шинигами", "Живой", "Готей 13");
            filterForm.characters_list[7] = new characters("Улькиорра Сифер", "Арранкар", "Мертвый", "Уэко Мундо");
            filterForm.characters_list[8] = new characters("Урю Исида", "Квинси", "Живой", "Мир людей");
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {

        }

   
    }
}
