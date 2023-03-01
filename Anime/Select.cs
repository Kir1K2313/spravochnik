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
            int x = 40;
            int y = 200;

            foreach (characters characters in characters_list)
            {
               Button btn = new Button();
               btn.Text = characters.btn.Text;            
               btn.Font = new Font("Microsoft Sans Serif", 12F);
               btn.Location = new Point(x, y);
               btn.Size = new Size(150, 30);
               Controls.Add(btn);

               PictureBox pb = new PictureBox();
               pb.Image = characters.pb.Image;
               pb.Location = new Point(x, y);
               pb.Size = new Size(200, 150);
               pb.SizeMode = PictureBoxSizeMode.Zoom;
               Controls.Add(pb);

                /*  Label lbl = new Label();
                   lbl.Text = characters.btn.Text;
                   lbl.Font = new Font("Microsoft Sans Serif", 12F);
                   lbl.Location = new Point(x, y);
                   lbl.Size = new Size(150, 30);
                   Controls.Add(lbl);
                */
                x += 210;
                if (x > 620)
                {
                    x = 40;
                    y += 210;
                }
            }
        }




               private void Select_Load(object sender, EventArgs e)
                {

                }
            
         
    }
}
