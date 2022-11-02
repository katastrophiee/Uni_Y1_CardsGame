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
using DynamicUI;

namespace pain
{
    public partial class Form1 : Form
    {
        int[,] int_board = new int[6, 6];
        int[,] card_placement = new int[6, 6];
        int first_card_selected_row = -1;
        int second_card_selected_row = -1;
        int first_card_selected_column = -1;
        int second_card_selected_column = -1;
        GImageArray gimagearray;
        string str_Image_path = Directory.GetCurrentDirectory() + "\\Cards\\";
        string str_player_1_name;
        string str_player_2_name;

        public Form1()
        {
            InitializeComponent();
            create_player_1_panel();
            create_player_2_panel();
            //MessageBox.Show(str_Image_path);
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

        //int[] instances = new int[53];

        //private int get_card()
        //{
        //    Random rnd = new Random();
        //    int card = rnd.Next(1, 36); //random number between 1 and 18

        //    do {
        //        card = rnd.Next(1, 36);
        //        if (check_card(card, 2))
        //        {
        //            card = rnd.Next(1, 36);
        //            //true
        //            instances[card]++;
        //            return card;

        //        }
        //        //else
        //        //{
        //        //    //get new card
        //        //    card = rnd.Next(1, 19);
        //        //    instances[card]++;//random number between 1 and 18
        //        //}
        //    }
        //    while (check_card(card, 36));
        //    return 0;
        //}

        //private bool check_card(int card, int max_cards)
        //{
        //    if (instances[card]<max_cards)
        //    {
        //        instances[card]++;
        //        return true;
        //    }
        //    else
        //    {
        //        return false;
        //    }

        //}

        private bool check_box_empty(TextBox name)
        {
            if (name.Text == "")
            {
                MessageBox.Show("Please populate both names before starting.");
                return false;
            }
            else
            {
                return true;
            }
        }

        private int[] assign_card(int amount_of_cards)
        {
            int[] cards = new int[amount_of_cards / 2]; //makes array containing half the amount of total cards
            Random rnd = new Random(); //makes random

            for (int count = 0; count != (amount_of_cards / 2); count++) //does a count up to half the amount of total cards
            {
                int card = rnd.Next(53); //generates random number between 1 and 53 

                if (!cards.Contains(card)) //checks that this card has not already been added to the array
                {
                    cards[count] = card; //adds it if not
                }
                else
                {
                    count -= 1; //minuses count by 1 as no card has been added
                }
            }

            cards = cards.Concat(cards).ToArray(); //duplicates all of the items in the list to get 2 of each card
            cards = cards.OrderBy(x => rnd.Next()).ToArray(); //randomises the order of the numbers within the list




            return cards; //returns the card placement
        }

        private void set_board_to_cards(int amount_of_cards, int[] cards)
        {
            int item = 0; //starts item to know which card we're on
            for (int Row = 0; Row <= 5; Row++) //iterates through each row
            {
                for (int Column = 0; Column <= 5; Column++) //iterates through each column
                {
                    int_board[Row, Column] = cards[item]; //assigns this picture with the correct card
                    if (item != amount_of_cards) //checks we've not run out of cards to set the picture for
                    {
                        item += 1; //moves on to the next item
                    }
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            for (int Row = 0; Row <= 5; Row++)
            {
                for (int Column = 0; Column <= 5; Column++)
                {
                    //if ((Column == 0) && (Row == 0))
                    //{
                    //    int_board[Row, Column] = 55;
                    //}
                    //else
                    //if (Column > 0)
                    //{
                    //    if (int_board[Row, Column - 1] == 55) //55 is blue back of card
                    //    {
                    //        int_board[Row, Column] = 56; //56 is red back of card
                    //    }
                    //    else
                    //    {
                    //        int_board[Row, Column] = 55;
                    //    }
                    //}
                    //if (Row > 0)
                    //{
                    //    if (int_board[Row - 1, Column] == 55)
                    //    {
                    //        int_board[Row, Column] = 56;
                    //    }
                    //    else
                    //    {
                    //        int_board[Row, Column] = 55;
                    //    }
                    //}     

                    int_board[Row, Column] = 56;
                }
            }
        }

        //int[] array1D = new int[36];

        //private void uh()
        //{
        //    for (int i=0; i<=5; i++)
        //    {
        //        for (int j=0; j<=5; j++)
        //        {
        //            Random rnd = new Random();
        //            int card = rnd.Next(36);
        //            int_board[i, j] = array1D[card];
        //        }
        //    }

        //    for (int i = 0; i < 36; i++)
        //    {
        //        array1D[i] = i/2;
        //    }

        //    MessageBox.Show(int_board[0,0].ToString());
        //}

        //private void set_cards()
        //{
        //    for (int i = 0; i < 36; i++)
        //    {
        //        array1D[i] = i / 2;
        //    }

        //    List<int> picked = new List<int>();
        //    Random rnd = new Random();

        //    for (int Row = 0; Row <= 5; Row++)
        //    {
        //        for (int Column = 0; Column <= 5; Column++)
        //        {
        //            bool CardAssigned = false;
        //            while (!CardAssigned)
        //            {
        //                int card = rnd.Next(36);
        //                bool alreadyexists = picked.Contains(card);
        //                if (!alreadyexists)
        //                {
        //                    picked.Add(card);
        //                    int_board[Row, Column] = array1D[card];
        //                    CardAssigned = true;
        //                }
        //            }
        //        }
        //    }
        //}

        private static T[,] Make2DArray<T>(T[] input, int height, int width)
        {
            T[,] output = new T[height, width];
            for (int i = 0; i < height; i++)
            {
                for (int j = 0; j < width; j++)
                {
                    output[i, j] = input[i * width + j];
                }
            }
            return output;
        }

        private void Which_Element_Clicked(object sender, EventArgs e)
        {
            int Int_Row = gimagearray.Get_Row(sender);
            int Int_Col = gimagearray.Get_Col(sender);

            txtB_Row.Text = Convert.ToString(Int_Row);
            txtB_Col.Text = Convert.ToString(Int_Col);

            if (int_board[Int_Row, Int_Col] != 55)
            {
                int_board[Int_Row, Int_Col] = card_placement[Int_Row, Int_Col];
                gimagearray.UpDateImages(int_board);

                if (first_card_selected_row == -1 && first_card_selected_column == -1)
                {
                    first_card_selected_row = Int_Row;
                    first_card_selected_column = Int_Col;
                }
                else
                {
                    if (first_card_selected_row == Int_Row && first_card_selected_column == Int_Col)
                    {
                        MessageBox.Show("Please select a different card!");
                    }
                    else
                    {
                        second_card_selected_row = Int_Row;
                        second_card_selected_column = Int_Col;

                        bool cards_match = check_for_match();

                        if (!cards_match)
                        {
                            MessageBox.Show("Not a match");
                            int_board[first_card_selected_row, first_card_selected_column] = 56;
                            int_board[second_card_selected_row, second_card_selected_column] = 56;

                            first_card_selected_row = -1;
                            second_card_selected_row = -1;
                            first_card_selected_column = -1;
                            second_card_selected_column = -1;
                            gimagearray.UpDateImages(int_board);
                        }
                        else
                        {
                            MessageBox.Show("It's a match! 1 point to name!");

                            int_board[first_card_selected_row, first_card_selected_column] = 55;
                            int_board[second_card_selected_row, second_card_selected_column] = 55;

                            first_card_selected_row = -1;
                            second_card_selected_row = -1;
                            first_card_selected_column = -1;
                            second_card_selected_column = -1;
                            gimagearray.UpDateImages(int_board);
                            //cards = cards.Concat(cards).ToArray();

                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("This card has already been matched, use a different one.");
            }


            //if (int_board[Int_Row,Int_Col] != 56 && int_board[Int_Row, Int_Col] != 55)
            //{
            //    int_board[Int_Row, Int_Col] = 55;
            //}
            //{
            //    int_board[Int_Row, Int_Col] = 55;
            //}
            //else
            //{
            //    int_board[Int_Row, Int_Col] = 56;
            //}
            //int_board[Int_Row, Int_Col] = 0;


        }


        private bool check_for_match()
        {
            if (card_placement[first_card_selected_row, first_card_selected_column] == card_placement[second_card_selected_row, second_card_selected_column])
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private void turn_card_back(object sender, EventArgs e)
        {
            int Int_Row = gimagearray.Get_Row(sender);
            int Int_Col = gimagearray.Get_Col(sender);

            txtB_Row.Text = Convert.ToString(Int_Row);
            txtB_Col.Text = Convert.ToString(Int_Col);

            int_board[Int_Row, Int_Col] = 55;
            //if (int_board[Int_Row,Int_Col] != 56 && int_board[Int_Row, Int_Col] != 55)
            //{
            //    int_board[Int_Row, Int_Col] = 55;
            //}
            //{
            //    int_board[Int_Row, Int_Col] = 55;
            //}
            //else
            //{
            //    int_board[Int_Row, Int_Col] = 56;
            //}
            //int_board[Int_Row, Int_Col] = 0;

            //gimagearray.Which_Element_Clicked -= new GImageArray.ImageClickedEventHandler(turn_card_back);
            //gimagearray.Which_Element_Clicked += new GImageArray.ImageClickedEventHandler(Which_Element_Clicked);
            MessageBox.Show("i am shocked this ran :)");
            gimagearray.UpDateImages(int_board);
        }

        private void newGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int[] card_arrangement = assign_card(36); // gets the placement for the cards on the board
            //set_board_to_cards(36, card_arrangement); // sets all the cards on the board to be face up

            //if (check_box_empty(player_1_name_textbox))
            //{

            //}

            gimagearray = new GImageArray(this, int_board, 10, 10, 10, 300, 20, str_Image_path);
            gimagearray.Which_Element_Clicked += new GImageArray.ImageClickedEventHandler(Which_Element_Clicked);
            gimagearray.UpDateImages(int_board);

            card_placement = Make2DArray(card_arrangement, 6, 6);

            //btn_start.Visible = false;
        }

        private void loadGameToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void abouToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}