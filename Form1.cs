﻿using System;
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
using DynamicUI;

namespace pain
{
    public partial class Form1 : Form
    {
        int[,] int_board = new int[6, 6];
        GImageArray gimagearray;
        string str_Image_path = Directory.GetCurrentDirectory() + "\\Cards\\";
        string str_player_1_name;
        string str_player_2_name;

        public Form1()
        {
            InitializeComponent();
            create_player_1_panel();
            create_player_2_panel();
            create_start_button();
            //MessageBox.Show(str_Image_path);
        }

        private void create_start_button()
        {
            var btn_start = new Button();
            btn_start.BackColor = Color.AliceBlue;
            btn_start.FlatStyle = FlatStyle.Flat;
            btn_start.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            btn_start.ForeColor = Color.DarkSlateGray;
            int Height = this.ClientSize.Height;
            btn_start.Name = "btn_start";
            btn_start.Size = new Size(194, 44);
            btn_start.TabIndex = 0;
            btn_start.Text = "Start!";
            btn_start.UseVisualStyleBackColor = false;
            //btn_start.Height = Height + 50;
            //btn_start.Anchor = AnchorStyles.Bottom; 
            btn_start.Left = (this.ClientSize.Width - btn_start.Width) / 2;
            btn_start.Top = (this.ClientSize.Height) - 50;
            btn_start.Click += new EventHandler(this.btn_start_Click);
            this.Controls.Add(btn_start);
        }

        private void create_player_1_panel()
        {
            //Creates player 1 panel on the left
            var player_1_panel = new TableLayoutPanel();
            player_1_panel.Dock = DockStyle.Left;
            player_1_panel.BackColor = Color.SkyBlue;
            player_1_panel.ColumnCount = 1;
            player_1_panel.RowCount = 0;

            player_1_panel.RowStyles.Add(new RowStyle(SizeType.Absolute, 50));
            player_1_panel.RowStyles.Add(new RowStyle(SizeType.Absolute, 75));
            player_1_panel.RowStyles.Add(new RowStyle(SizeType.Absolute, 50)); //changes the size of each column to add correct spacing
            player_1_panel.RowStyles.Add(new RowStyle(SizeType.Absolute, 50));
            player_1_panel.AutoScroll = true;

            // Creates player 1 label
            var player_1_title_label = new Label();
            player_1_title_label.AutoSize = true;
            player_1_title_label.Font = new Font("Microsoft Sans Serif", 16); //changes font 
            player_1_title_label.Text = "\nPlayer 1 Name:";
            player_1_title_label.Dock = player_1_panel.Dock;
            player_1_title_label.Dock = DockStyle.Top;
            
            // Creates player 1 label
            var player_1_pairs_label = new Label();
            player_1_pairs_label.AutoSize = true;
            player_1_pairs_label.Font = new Font("Microsoft Sans Serif", 16); //changes font 
            player_1_pairs_label.Text = "\nPairs:";
            player_1_pairs_label.Dock = player_1_panel.Dock;
            player_1_pairs_label.Dock = DockStyle.Top;


            //Creates text box for user to enter their name
            var player_1_name_textbox = new TextBox();
            player_1_name_textbox.BorderStyle = BorderStyle.Fixed3D;
            player_1_name_textbox.Dock = player_1_panel.Dock;
            player_1_name_textbox.Dock = DockStyle.Top;
            
            //Creates read only text box to show pairs this player has made
            var player_1_pairs_textbox = new TextBox();
            player_1_pairs_textbox.BorderStyle = BorderStyle.Fixed3D;
            player_1_pairs_textbox.Dock = player_1_panel.Dock;
            player_1_pairs_textbox.Dock = DockStyle.Top;
            player_1_pairs_textbox.ReadOnly = true;

            // Add controls
            player_1_panel.Controls.Add(player_1_title_label, 0, 0);
            player_1_panel.Controls.Add(player_1_name_textbox, 1, 0); //increments which column they are on
            player_1_panel.Controls.Add(player_1_pairs_label, 2, 0);
            player_1_panel.Controls.Add(player_1_pairs_textbox, 3, 0);
            this.Controls.Add(player_1_panel);
        }

        private void create_player_2_panel()
        {
            //Creates player 1 panel on the left
            var player_2_panel = new TableLayoutPanel();
            player_2_panel.Dock = DockStyle.Right;
            player_2_panel.BackColor = Color.SkyBlue;
            player_2_panel.ColumnCount = 1;
            player_2_panel.RowCount = 0;

            player_2_panel.RowStyles.Add(new RowStyle(SizeType.Absolute, 50));
            player_2_panel.RowStyles.Add(new RowStyle(SizeType.Absolute, 75));
            player_2_panel.RowStyles.Add(new RowStyle(SizeType.Absolute, 50)); //changes the size of each column to add correct spacing
            player_2_panel.RowStyles.Add(new RowStyle(SizeType.Absolute, 50));
            player_2_panel.AutoScroll = true;

            // Creates player 1 label
            var player_2_title_label = new Label();
            player_2_title_label.AutoSize = true;
            player_2_title_label.Font = new Font("Microsoft Sans Serif", 16); //changes font 
            player_2_title_label.Text = "\nPlayer 2 Name:";
            player_2_title_label.Dock = player_2_panel.Dock;
            player_2_title_label.Dock = DockStyle.Top;

            // Creates player 1 label
            var player_2_pairs_label = new Label();
            player_2_pairs_label.AutoSize = true;
            player_2_pairs_label.Font = new Font("Microsoft Sans Serif", 16); //changes font 
            player_2_pairs_label.Text = "\nPairs:";
            player_2_pairs_label.Dock = player_2_panel.Dock;
            player_2_pairs_label.Dock = DockStyle.Top;


            //Creates text box for user to enter their name
            var player_2_name_textbox = new TextBox();
            player_2_name_textbox.BorderStyle = BorderStyle.Fixed3D;
            player_2_name_textbox.Dock = player_2_panel.Dock;
            player_2_name_textbox.Dock = DockStyle.Top;

            //Creates read only text box to show pairs this player has made
            var player_2_pairs_textbox = new TextBox();
            player_2_pairs_textbox.BorderStyle = BorderStyle.Fixed3D;
            player_2_pairs_textbox.Dock = player_2_panel.Dock;
            player_2_pairs_textbox.Dock = DockStyle.Top;
            player_2_pairs_textbox.ReadOnly = true;

            // Add controls
            player_2_panel.Controls.Add(player_2_title_label, 0, 0);
            player_2_panel.Controls.Add(player_2_name_textbox, 1, 0); //increments which column they are on
            player_2_panel.Controls.Add(player_2_pairs_label, 2, 0);
            player_2_panel.Controls.Add(player_2_pairs_textbox, 3, 0);
            this.Controls.Add(player_2_panel);
        }

        int[] instances = new int[53];

        private int get_card()
        {
            Random rnd = new Random();
            int card = rnd.Next(1, 19); ; //random number between 1 and 18

            if (check_card(card, 2))
            {
                //true
                instances[card]++;
                return card;
            }
            else
            {
                //get new card
                //get_card();
            }
            return 0;
        }

        private bool check_card(int card, int max_cards)
        {
            if (instances[card]<max_cards)
            {
                return true;
            }
            else
            {
                return false;
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            for (int Row = 0; Row <= 5; Row++)
            {
                for(int Column = 0; Column <= 5; Column++)
                {
                    if ((Column == 0) && (Row == 0))
                    {
                        int_board[Row, Column] = 55;
                    }
                    else
                    if (Column > 0)
                    {
                        if (int_board[Row, Column - 1] == 55) //55 is blue back of card
                        {
                            int_board[Row, Column] = 56; //56 is red back of card
                        }
                        else
                        {
                            int_board[Row, Column] = 55;
                        }
                    }
                    if (Row > 0)
                    {
                        if (int_board[Row - 1, Column] == 55)
                        {
                            int_board[Row, Column] = 56;
                        }
                        else
                        {
                            int_board[Row, Column] = 55;
                        }
                    }     
                    
                }
            }
        }

        int[] array1D = new int[36];

        private void uh()
        {
            for (int i=0; i<=5; i++)
            {
                for (int j=0; j<=5; j++)
                {
                    Random rnd = new Random();
                    int card = rnd.Next(36);
                    int_board[i, j] = array1D[card];
                }
            }

            for (int i = 0; i < 36; i++)
            {
                array1D[i] = i/2;
            }

            MessageBox.Show(int_board[0,0].ToString());
        }

        private void set_cards()
        {
            for (int i = 0; i < 36; i++)
            {
                
                array1D[i] = i / 2;
            }

            List<int> picked = new List<int>();
            Random rnd = new Random();

            for (int Row = 0; Row <= 5; Row++)
            {
                for (int Column = 0; Column <= 5; Column++)
                {
                    bool CardAssigned = false;
                    while (!CardAssigned)
                    {
                        int card = rnd.Next(36);
                        bool alreadyexists = picked.Contains(card);
                        if (!alreadyexists)
                        {
                            picked.Add(card);
                            int_board[Row, Column] = array1D[card];
                            CardAssigned = true;
                        }
                    }
                }
            }
        }
        
        private void btn_start_Click(object sender, EventArgs e)
        {
            //for (int row = 0; row < 6; row++)
            //{
            //    for (int col = 0; col < 6; col++)
            //    {
            //        int_board[row, col] = get_card();
            //    }
            //}
            set_cards();
            gimagearray = new GImageArray(this, int_board,10,10,10,300,20,str_Image_path);
            gimagearray.Which_Element_Clicked += new GImageArray.ImageClickedEventHandler(Which_Element_Clicked);
            gimagearray.UpDateImages(int_board);
            //btn_start.Visible = false;
        }
        
        private void Which_Element_Clicked(object sender, EventArgs e)
        {
            int Int_Row = gimagearray.Get_Row(sender);
            int Int_Col = gimagearray.Get_Col(sender);

            txtB_Row.Text = Convert.ToString(Int_Row);
            txtB_Col.Text = Convert.ToString(Int_Col);

            if (int_board[Int_Row,Int_Col] == 56)
            {
                int_board[Int_Row, Int_Col] = 55;
            }
            else
            {
                int_board[Int_Row, Int_Col] = 56;
            }
            //int_board[Int_Row, Int_Col] = 0;
            gimagearray.UpDateImages(int_board);
        }

    }
}