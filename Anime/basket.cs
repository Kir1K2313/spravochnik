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
    public partial class basket : Form
    {
        public static List<characters> characters_list = new List<characters>();    
        public basket()
        {
            InitializeComponent();
        }

        private void basket_Load(object sender, EventArgs e)
        {

        }
    }
}
