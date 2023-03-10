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
    public partial class Select : Form
    {
        public static List<characters> characters_list = new List<characters>();

        public Select()
        {
            InitializeComponent();
            int x = 10;
            int y = 10;

            foreach (characters characters in characters_list)
            {
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

                y += 210;
            
            }
        }




               private void Select_Load(object sender, EventArgs e)
                {

                }
            
         
    }
}
