using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pairs
{
    public partial class About : Form
    {
        public About(string str_Image_path, Form owner)
        {
            InitializeComponent();
            Owner = owner;
            this.CenterToParent();
            pears_png.BackgroundImage = Image.FromFile(str_Image_path + "pears.png");
        }

        private void ok_btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
