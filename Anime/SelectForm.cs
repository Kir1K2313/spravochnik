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
    public partial class SelectForm : Form
    {
        public static Dictionary<charactersstruct, int> characters_list = new Dictionary<charactersstruct, int>();

        public SelectForm()
        {
            InitializeComponent();
            ReDraw();
        }
        void ReDraw()
        {
            Controls.Clear();
            int x = 10;
            int y = 10;

            foreach (KeyValuePair<charactersstruct, int> mycharac in characters_list)
            {
                charactersstruct characters = mycharac.Key;
                #region картинка
                PictureBox pb = new PictureBox();
                pb.Image = characters.pb.Image;
                pb.Location = new Point(x, y);
                pb.Size = new Size(200, 150);
                pb.SizeMode = PictureBoxSizeMode.Zoom;
                Controls.Add(pb);
                #endregion
                #region парамет
                Label lbl_name = new Label();
                lbl_name.Text = "Имя: " + characters.Name;
                lbl_name.Font = new Font("Microsoft Sans Serif", 12F);
                lbl_name.Location = new Point(x + 250, y);
                lbl_name.Size = new Size(250, 30);
                Controls.Add(lbl_name);

                Label lbl_rasa = new Label();
                lbl_rasa.Text = "Раса: " + characters.rasa;
                lbl_rasa.Font = new Font("Microsoft Sans Serif", 12F);
                lbl_rasa.Location = new Point(x + 250, y + 50);
                lbl_rasa.Size = new Size(150, 30);
                Controls.Add(lbl_rasa);

                Label lbl_status = new Label();
                lbl_status.Text = "Статус: " + characters.status;
                lbl_status.Font = new Font("Microsoft Sans Serif", 12F);
                lbl_status.Location = new Point(x + 250, y + 100);
                lbl_status.Size = new Size(150, 30);
                Controls.Add(lbl_status);

                Label lbl_frak = new Label();
                lbl_frak.Text = "Фракция: " + characters.frak;
                lbl_frak.Font = new Font("Microsoft Sans Serif", 12F);
                lbl_frak.Location = new Point(x + 250, y + 150);
                lbl_frak.Size = new Size(250, 30);
                Controls.Add(lbl_frak);
                #endregion
                #region кнопка              
                Button btn = new Button();
                btn.Text = characters.btn.Text;
                btn.Font = new Font("Microsoft Sans Serif", 12F);
                btn.Location = new Point(x + 200, y + 200);
                btn.Size = new Size(250, 30);
                btn.Click += new EventHandler(filterForm.charactersClick);
                Controls.Add(btn);
                #endregion
                #region Удаление
                Button btnDelete = new Button();
                btnDelete.Text = "Удалить";
                btnDelete.Font = new Font("Microsoft Sans Serif", 12F);
                btnDelete.Location = new Point(x + 490, y);
                btnDelete.Size = new Size(150, 30);
                btnDelete.Click += new EventHandler(DeleteClick);
                Controls.Add(btnDelete);
                #endregion

                y += 210;

            }
        }

        void DeleteClick(object sender, EventArgs e)
        {
            int i = 0;
            Button btn =  (Button)sender;
            Dictionary<charactersstruct, int> mycharac1 = new Dictionary<charactersstruct, int>();
            foreach (KeyValuePair <charactersstruct, int> mycharac in characters_list)
            {
                charactersstruct characters = mycharac.Key;
                if (btn.Location == new Point(500, 210*i + 10))
                {

                }
                else
                {
                    mycharac1[mycharac.Key] = mycharac.Value;
                }
                i++;
            }
            characters_list = mycharac1;
            ReDraw();
        }

               private void Select_Load(object sender, EventArgs e)
                {

                }

        private void SelectForm_Load(object sender, EventArgs e)
        {

        }
    }
}
