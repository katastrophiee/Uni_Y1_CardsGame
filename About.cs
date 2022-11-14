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

namespace pain
{
    public partial class About : Form
    {
        string str_Image_path = Directory.GetCurrentDirectory() + "\\Cards\\";
        public About()
        {
            InitializeComponent();
            pears_png.BackgroundImage = Image.FromFile(str_Image_path + "pears.png");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
