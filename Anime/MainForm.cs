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
            filterForm.charactersClick(sender, e);
        }
        

        private void filterbutton_Click(object sender, EventArgs e)
        {
            filterForm filter = new filterForm();
            filter.ShowDialog();
        }
        private void Selectbutton_Click(object sender, EventArgs e)
        {
            SelectForm select = new SelectForm();
            select.Show();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
           
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {

        }

        private void MainForm_Load_1(object sender, EventArgs e)
        {
            filterForm.characters_list[0] = new charactersstruct("Ичиго Куросаки", "Человек", "Живой", "Мир людей");
            filterForm.characters_list[1] = new charactersstruct("Айзен Сосуке", "Душа", "Живой", "Он сам");
            filterForm.characters_list[2] = new charactersstruct("Киске Урахара", "Шинигами", "Неизвестно", "Общество душ");
            filterForm.characters_list[3] = new charactersstruct("Рукия Кучики", "Душа", "Живой", "Общество душ");
            filterForm.characters_list[4] = new charactersstruct("Хирако Шинджи", "Душа", "Живой", "Общество душ");
            filterForm.characters_list[5] = new charactersstruct("Ямамото Генрюсай", "Шинигами", "Живой", "Готей 13");
            filterForm.characters_list[6] = new charactersstruct("Унохана Рецу", "Шинигами", "Живой", "Готей 13");
            filterForm.characters_list[7] = new charactersstruct("Улькиорра Сифер", "Арранкар", "Мертвый", "Уэко Мундо");
            filterForm.characters_list[8] = new charactersstruct("Урю Исида", "Квинси", "Живой", "Мир людей");

        }
    }
}
