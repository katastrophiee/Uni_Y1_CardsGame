using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using GUIImageArray;

namespace pain
{
    public partial class Form1 : Form
    {
        int[,] int_board = new int[8, 8];
        GImageArray gimagearray;
        string str_Image_path = Directory.GetCurrentDirectory() + "\\images\\";
        string str_player_1_name;
        string str_player_2_name;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            

            for (int Row = 0; Row <= 7; Row++)
            {
                for(int Column = 0; Column <= 7; Column++)
                {
                    if ((Column == 0) && (Row == 0))
                    {
                        int_board[Row, Column] = 1;
                    }
                    else
                    if (Column > 0)
                    {
                        if (int_board[Row, Column - 1] == 1)
                        {
                            int_board[Row, Column] = 0;
                        }
                        else
                        {
                            int_board[Row, Column] = 1;
                        }
                    }
                    if (Row > 0)
                    {
                        if (int_board[Row - 1, Column] == 1)
                        {
                            int_board[Row, Column] = 0;
                        }
                        else
                        {
                            int_board[Row, Column] = 1;
                        }
                    }     
                    
                }
            }
        }



        private void btn_start_Click(object sender, EventArgs e)
        {
            gimagearray = new GImageArray(this, int_board,10,10,10,100,0,str_Image_path);
            gimagearray.Which_Element_Clicked += new GImageArray.ImageClickedEventHandler(Which_Element_Clicked);
            btn_start.Visible = false;
            btn_stop.Visible = true;
        }
        
        private void Which_Element_Clicked(object sender, EventArgs e)
        {
            int Int_Row = gimagearray.Get_Row(sender);
            int Int_Col = gimagearray.Get_Col(sender);

            txtB_Row.Text = Convert.ToString(Int_Row);
            txtB_Col.Text = Convert.ToString(Int_Col);

            if (int_board[Int_Row,Int_Col] == 0)
            {
                int_board[Int_Row, Int_Col] = 1;
            }
            else
            {
                int_board[Int_Row, Int_Col] = 0;
            }
            //int_board[Int_Row, Int_Col] = 0;
            gimagearray.UpDateImages(int_board);
        }

        private void btn_stop_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }
    }
}
