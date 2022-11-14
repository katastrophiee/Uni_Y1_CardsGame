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
using MyDialogs;
using pain;

namespace pairs
{

    public partial class Pairs : Form
    {
        int[,] int_board = new int[6, 6];
        int[,] card_placement = new int[6, 6];
        int[] card_placement_1d = new int[36];
        int first_card_selected_row = -1;
        int second_card_selected_row = -1;
        int first_card_selected_column = -1;
        int second_card_selected_column = -1;
        int player_1_score = 0;
        int player_2_score = 0;
        int row_amount = 5;
        int column_amount = 5;
        GImageArray gimagearray;
        string str_Image_path = Directory.GetCurrentDirectory() + "\\Cards\\";
        bool player_1_turn = false;
        int board_size = 36;
        int max_score = 18;
        bool game_started = false;

        public Pairs()
        {
            InitializeComponent();
            main_menu_png.BackgroundImage = Image.FromFile(str_Image_path + "pears.png");
            //create_player_1_panel();
            //create_player_2_panel();
            // create_image();
            //MessageBox.Show(str_Image_path);
            // center_label();
        }

        private void create_image()
        {
            var center_image = new PictureBox();
            center_image.Name = "center_image_png";
            center_image.Size = new Size(1000, 1000);
            center_image.BackColor = Color.Transparent;
            center_image.BackgroundImage = Image.FromFile(str_Image_path + "pears.png");
            center_image.SizeMode = PictureBoxSizeMode.AutoSize;
            center_image.BackgroundImageLayout = ImageLayout.Zoom;

            center_image.Location = new Point((Screen.FromControl(this).Bounds.Width / 2) - (center_image.Width / 2), (Screen.FromControl(this).Bounds.Height / 2) - (center_image.Height / 2));

            this.Controls.Add(center_image);
        }

        private void center_label()
        {
            var center_label = new Label();
            center_label.AutoSize = true;
            center_label.Location = new Point(((this.Width - center_label.Width) / 2) - 200, 30);
            center_label.Font = new Font("Microsoft Sans Serif", 50); //changes font 
            center_label.TextAlign = ContentAlignment.MiddleCenter;
            center_label.Text = "Pairs\nA Game of Two";
            center_label.Name = "center_label_lbl";
            this.Controls.Add(center_label);
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
            player_1_name_textbox.Name = "player_1_name_txt"; //names it so i can reference it later

            //Creates read only text box to show pairs this player has made
            var player_1_pairs_textbox = new TextBox();
            player_1_pairs_textbox.BorderStyle = BorderStyle.Fixed3D;
            player_1_pairs_textbox.Dock = player_1_panel.Dock;
            player_1_pairs_textbox.Dock = DockStyle.Top;
            player_1_pairs_textbox.Text = "0";
            player_1_pairs_textbox.Name = "player_1_pairs_txt";
            player_1_pairs_textbox.ReadOnly = true;

            //Groupbox
            var player1group_box = new GroupBox();

            // Add controls
            player_1_panel.Controls.Add(player_1_title_label, 0, 0);
            player_1_panel.Controls.Add(player_1_name_textbox, 1, 0); //increments which column they are on
            player_1_panel.Controls.Add(player_1_pairs_label, 2, 0);
            player_1_panel.Controls.Add(player_1_pairs_textbox, 3, 0);
            player_1_panel.Controls.Add(player1group_box, 4, 0);
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
            var player_2_title_label = new System.Windows.Forms.Label();
            player_2_title_label.AutoSize = true;
            player_2_title_label.Font = new Font("Microsoft Sans Serif", 16); //changes font 
            player_2_title_label.Text = "\nPlayer 2 Name:";
            player_2_title_label.Dock = player_2_panel.Dock;
            player_2_title_label.Dock = DockStyle.Top;

            // Creates player 1 label
            var player_2_pairs_label = new System.Windows.Forms.Label();
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
            player_2_name_textbox.Name = "player_2_name_txt"; //names it so i can reference it later

            //Creates read only text box to show pairs this player has made
            var player_2_pairs_textbox = new TextBox();
            player_2_pairs_textbox.BorderStyle = BorderStyle.Fixed3D;
            player_2_pairs_textbox.Dock = player_2_panel.Dock;
            player_2_pairs_textbox.Dock = DockStyle.Top;
            player_2_pairs_textbox.Text = "0";
            player_2_pairs_textbox.ReadOnly = true;
            player_2_pairs_textbox.Name = "player_2_pairs_txt";

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

        private int[] assign_card()
        {
            int[] cards = new int[(board_size / 2)]; //makes array containing half the amount of total cards
            Random rnd = new Random(); //makes random

            for (int count = 0; count != (board_size / 2); count++) //does a count up to half the amount of total cards
            {
                int card = rnd.Next(54); //generates random number between 1 and 54 

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
            for (int Row = 0; Row <= row_amount; Row++) //iterates through each row
            {
                for (int Column = 0; Column <= column_amount; Column++) //iterates through each column
                {
                    int_board[Row, Column] = cards[item]; //assigns this picture with the correct card
                    if (item != amount_of_cards) //checks we've not run out of cards to set the picture for
                    {
                        item += 1; //moves on to the next item
                    }
                }
            }

            gimagearray.UpDateImages(int_board);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            int multiplier = this.Width / 1336;
            main_menu_lbl.Width *= multiplier;
            main_menu_lbl.Left = (this.Width - main_menu_lbl.Width) / 2;
            main_menu_png.Width *= multiplier;
            main_menu_png.Left = (this.Width - main_menu_png.Width) / 2;
            //for (int Row = 0; Row <= row_amount; Row++)
            //{
            //    for (int Column = 0; Column <= column_amount; Column++)
            //    {
            //        //if ((Column == 0) && (Row == 0))
            //        //{
            //        //    int_board[Row, Column] = 55;
            //        //}
            //        //else
            //        //if (Column > 0)
            //        //{
            //        //    if (int_board[Row, Column - 1] == 55) //55 is blue back of card
            //        //    {
            //        //        int_board[Row, Column] = 56; //56 is red back of card
            //        //    }
            //        //    else
            //        //    {
            //        //        int_board[Row, Column] = 55;
            //        //    }
            //        //}
            //        //if (Row > 0)
            //        //{
            //        //    if (int_board[Row - 1, Column] == 55)
            //        //    {
            //        //        int_board[Row, Column] = 56;
            //        //    }
            //        //    else
            //        //    {
            //        //        int_board[Row, Column] = 55;
            //        //    }
            //        //}     

            //        int_board[Row, Column] = 56;
            //    }
            //}
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
            if (show_cards_timer.Enabled == false)
            {
                if (show_picked_cards_timer.Enabled == false)
                {
                    int Int_Row = gimagearray.Get_Row(sender);
                    int Int_Col = gimagearray.Get_Col(sender);

                    // txtB_Row.Text = Convert.ToString(Int_Row);
                    // txtB_Col.Text = Convert.ToString(Int_Col);

                    if (int_board[Int_Row, Int_Col] != 55) //checks card doesnt have a blue back (means its already been paired then)
                    {
                        int_board[Int_Row, Int_Col] = card_placement[Int_Row, Int_Col]; //changes the image to flip the card
                        gimagearray.UpDateImages(int_board); //updattes rthe image

                        if (first_card_selected_row == -1 && first_card_selected_column == -1)
                        {
                            first_card_selected_row = Int_Row;
                            first_card_selected_column = Int_Col;
                            if (player_1_turn == true)
                            {
                                player_1_first_card_png.BackgroundImage = Image.FromFile(str_Image_path + Convert.ToString(card_placement[first_card_selected_row, first_card_selected_column]) + ".png");
                                player_1_second_card_png.BackgroundImage = Image.FromFile(str_Image_path + Convert.ToString(card_placement[first_card_selected_row, first_card_selected_column]) + ".png");
                            }
                            else
                            {
                                player_2_first_card_png.BackgroundImage = Image.FromFile(str_Image_path + Convert.ToString(card_placement[first_card_selected_row, first_card_selected_column]) + ".png");
                                player_2_second_card_png.BackgroundImage = Image.FromFile(str_Image_path + Convert.ToString(card_placement[first_card_selected_row, first_card_selected_column]) + ".png");
                            }
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

                                if (player_1_turn == true)
                                {
                                    player_1_second_card_png.BackgroundImage = Image.FromFile(str_Image_path + Convert.ToString(card_placement[second_card_selected_row, second_card_selected_column]) + ".png");
                                    cards_selected_player_1_timer.Start();


                                }
                                else
                                {
                                    player_2_second_card_png.BackgroundImage = Image.FromFile(str_Image_path + Convert.ToString(card_placement[second_card_selected_row, second_card_selected_column]) + ".png");
                                    cards_selected_player_2_timer.Start();
                                }
                                show_picked_cards_timer.Start();

                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("This card has already been matched, use a different one."); //error message if cards already been used in a pair
                    }
                }
            }
            //else
            //{
            //    if (player_1_score < player_2_score)
            //    {
            //        MessageBox.Show($"{str_player_2_name} wins!");
            //    }
            //    else if (player_2_score < player_1_score)
            //    {
            //        MessageBox.Show($"{str_player_1_name} wins!");
            //    }
            //    else
            //    {
            //        MessageBox.Show("It's a draw!");
            //    }
            //}



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
            if (card_placement[first_card_selected_row, first_card_selected_column]
                == card_placement[second_card_selected_row, second_card_selected_column])
            {
                return true;
            }
            else
            {
                return false;
            }
        }


        //private void turn_card_back(object sender, EventArgs e)
        //{
        //    int Int_Row = gimagearray.Get_Row(sender);
        //    int Int_Col = gimagearray.Get_Col(sender);

        //    txtB_Row.Text = Convert.ToString(Int_Row);
        //    txtB_Col.Text = Convert.ToString(Int_Col);

        //    int_board[Int_Row, Int_Col] = 55;
        //    //if (int_board[Int_Row,Int_Col] != 56 && int_board[Int_Row, Int_Col] != 55)
        //    //{
        //    //    int_board[Int_Row, Int_Col] = 55;
        //    //}
        //    //{
        //    //    int_board[Int_Row, Int_Col] = 55;
        //    //}
        //    //else
        //    //{
        //    //    int_board[Int_Row, Int_Col] = 56;
        //    //}
        //    //int_board[Int_Row, Int_Col] = 0;

        //    //gimagearray.Which_Element_Clicked -= new GImageArray.ImageClickedEventHandler(turn_card_back);
        //    //gimagearray.Which_Element_Clicked += new GImageArray.ImageClickedEventHandler(Which_Element_Clicked);
        //    MessageBox.Show("i am shocked this ran :)");
        //    gimagearray.UpDateImages(int_board);
        //}

        private void change_turn()
        {
            if (player_1_turn == true) // checks if its player 1s turn
            {
                player_1_turn_lbl.Visible = false;
                player_1_turn = false; //makes player 2s turn
                player_2_turn_lbl.Visible = true;
            }
            else
            {
                player_2_turn_lbl.Visible = false;
                player_1_turn = true;
                player_1_turn_lbl.Visible = true;
            }
        }

        //private void newGameToolStripMenuItem_Click(object sender, EventArgs e)
        //{
        //    game_started = true;
        //    //for (int ix = this.Controls.Count - 1; ix >= 0; ix--)
        //    //{
        //    //    try
        //    //    {
        //    //        if (this.Controls[ix] is PictureBox && this.Controls[ix].Name != "center_image_png")
        //    //        {
        //    //            this.Controls[ix].Dispose();
        //    //        }
        //    //    }
        //    //    catch
        //    //    {
        //    //        MessageBox.Show("Error.");
        //    //    }
        //    //}
        //    TextBox player_1_name = (TextBox)Controls.Find("player_1_name_txt", true)[0]; //gets the value for player 1's name
        //    TextBox player_2_name = (TextBox)Controls.Find("player_2_name_txt", true)[0]; //does same for player 2
        //    Random rnd = new Random(); //random
        //    player_1_turn = rnd.NextDouble() >= 0.5; //randomly decides whos turn it is to start

        //    if (String.IsNullOrEmpty(player_1_name.Text)) //player_1_name.Text == "") //checks if player 1 name is empty
        //    {
        //       // MessageBox.Show("Player 1 must have a name before the game starts"); //error message if so
        //        player_1_name.Text = My_Dialogs.InputBox("Player 1 does not have a name, please enter one here:");
        //    }
        //    else if (String.IsNullOrEmpty(player_2_name.Text)) //checks if player 2 name is empty
        //    {
        //        player_2_name.Text = My_Dialogs.InputBox("Player 2 does not have a name, please enter one here:"); //error message if so //change to message box with input
        //    }
        //    else
        //    {
        //        //MessageBox.Show(Convert.ToString(board_size));

        //        player_2_name.ReadOnly = true; 
        //        player_1_name.ReadOnly = true; //makes read only so the names can't be editted once started

        //        Label title = (Label)Controls.Find("center_label_lbl", true)[0]; //looks for image and background and hides them
        //       PictureBox background_image = (PictureBox)Controls.Find("center_image_png", true)[0];
        //        title.Visible = false;
        //        background_image.Visible = false;

        //        str_player_1_name = player_1_name.Text; 
        //        str_player_2_name = player_2_name.Text; //stores names
        //        if (player_1_turn == true) 
        //        {
        //            MessageBox.Show("Player 1 starts!"); 
        //        }
        //        else //appropriate message box based on whos turn it is
        //        {
        //            MessageBox.Show("Player 2 starts!");
        //        }

        //        //MessageBox.Show("Cards show");

        //        if (x6ToolStripMenuItem.Checked == true)
        //        {
        //            show_cards_timer.Interval = 10000;
        //            gimagearray = new GImageArray(this, int_board, 10, 10, 10, 150, 10, str_Image_path); //lays out the cards and picture boxes
        //            card_placement = Make2DArray(card_placement_1d, 6, 6); //makes the card placement a 2d array
        //            gimagearray.Which_Element_Clicked += new GImageArray.ImageClickedEventHandler(Which_Element_Clicked);
        //        }
        //        else if (x10ToolStripMenuItem.Checked == true)
        //        {
        //            show_cards_timer.Interval = 15000;
        //            gimagearray = new GImageArray(this, int_board, 10, 10, 10, 150, 10, str_Image_path); //lays out the cards and picture boxes
        //            card_placement = Make2DArray(card_placement_1d, 10, 10); //makes the card placement a 2d array
        //            gimagearray.Which_Element_Clicked += new GImageArray.ImageClickedEventHandler(Which_Element_Clicked);
        //        }
        //        else
        //        {
        //            show_cards_timer.Interval = 20000;
        //            gimagearray = new GImageArray(this, int_board, 10, 10, 10, 150, 10, str_Image_path); //lays out the cards and picture boxes
        //            card_placement = Make2DArray(card_placement_1d, 16, 16); //makes the card placement a 2d array
        //            gimagearray.Which_Element_Clicked += new GImageArray.ImageClickedEventHandler(Which_Element_Clicked);
        //        }

        //        //// BOTCHED MATHS ////
        //        if (board_size == 256)
        //        {
        //            board_size = 106;
        //        }

        //        card_placement_1d = assign_card(); // gets the placement for the cards on the board

        //        if (board_size == 106)
        //        {
        //            card_placement_1d = card_placement_1d.Concat(card_placement_1d).ToArray(); //duplicates all of the items in the list to get 2 of each card

        //            board_size = 44;

        //            int[] left_over = assign_card();

        //            card_placement_1d = card_placement_1d.Concat(left_over).ToArray(); //duplicates all of the items in the list to get 2 of each card
        //            card_placement_1d = card_placement_1d.OrderBy(x => rnd.Next()).ToArray();

        //            board_size = 256;
        //        }
        //        //// BOTCHED MATHS ////

        //        //gimagearray.Which_Element_Clicked += new GImageArray.ImageClickedEventHandler(Which_Element_Clicked); //adds events to the pictures for when clicked
        //        set_board_to_cards(board_size, card_placement_1d); // sets all the cards on the board to be face up
        //        //gimagearray.Which_Element_Clicked -= new GImageArray.ImageClickedEventHandler(Which_Element_Clicked);
        //        gimagearray.UpDateImages(int_board);
        //        for (int ix = this.Controls.Count - 1; ix >= 0; ix--)
        //        {
        //            if (this.Controls[ix] is PictureBox)
        //            {
        //                this.Controls[ix].Enabled = false;
        //            }
        //        }
        //        show_cards_timer.Start();
        //    }
        //}

        private void new_game_menu_btn_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(player_1_name_txt.Text) || player_1_name_txt.Text == "Name") //player_1_name.Text == "") //checks if player 1 name is empty
            {
                player_1_name_txt.Text = "";
                player_1_name_txt.ForeColor = Color.DarkSlateGray;
                player_1_name_txt.Text = My_Dialogs.InputBox("Player 1 does not have a name, please enter one here:"); //error message if so
                if (player_1_name_txt.Text == "Name")
                {
                    player_1_name_txt.ForeColor = Color.Silver;
                }
            }
            else if (String.IsNullOrEmpty(player_2_name_txt.Text) || player_2_name_txt.Text == "Name") //checks if player 2 name is empty
            {
                player_2_name_txt.Text = "";
                player_2_name_txt.ForeColor = Color.DarkSlateGray;
                player_2_name_txt.Text = My_Dialogs.InputBox("Player 2 does not have a name, please enter one here:"); //error message if so
                if (player_2_name_txt.Text == "Name")
                {
                    player_2_name_txt.ForeColor = Color.Silver;
                }
            }
            else
            {
                player_2_name_txt.ReadOnly = true;
                player_1_name_txt.ReadOnly = true;
                game_started = true;
                Random rnd = new Random(); //random
                player_1_turn = rnd.NextDouble() >= 0.5; //randomly decides whos turn it is to start
                main_menu_lbl.Visible = false;
                main_menu_png.Visible = false;

                //makes read only so the names can't be editted once started

                //Label title = (Label)Controls.Find("center_label_lbl", true)[0]; //looks for image and background and hides them

                //PictureBox background_image = (PictureBox)Controls.Find("center_image_png", true)[0];
                //title.Visible = false;

                if (player_1_turn == true)
                {
                    MessageBox.Show("Player 1 starts!");
                    player_1_turn_lbl.Visible = true;
                }
                else //appropriate message box based on whos turn it is
                {
                    MessageBox.Show("Player 2 starts!");
                    player_2_turn_lbl.Visible = true;
                }

                // MessageBox.Show("Cards show");




                ////MATH////
                if (board_size == 256)
                {
                    board_size = 106;
                }
                card_placement_1d = assign_card(); // gets the placement for the cards on the board
                if (board_size == 106)
                {
                    card_placement_1d = card_placement_1d.Concat(card_placement_1d).ToArray(); //duplicates all of the items in the list to get 2 of each card

                    board_size = 44;

                    int[] left_over = assign_card();

                    card_placement_1d = card_placement_1d.Concat(left_over).ToArray(); //duplicates all of the items in the list to get 2 of each card
                    card_placement_1d = card_placement_1d.OrderBy(x => rnd.Next()).ToArray();

                    board_size = 256;
                }
                ////MATH////





                if (x6ToolStripMenuItem.Checked == true)
                {
                    show_cards_timer.Interval = 10000;
                    gimagearray = new GImageArray(this, int_board, 50, 50, 50, 300, 10, str_Image_path, player_1_pnl); //lays out the cards and picture boxes
                    card_placement = Make2DArray(card_placement_1d, 6, 6); //makes the card placement a 2d array
                }
                else if (x10ToolStripMenuItem.Checked == true)
                {
                    show_cards_timer.Interval = 15000;
                    gimagearray = new GImageArray(this, int_board, 50, 20, 10, 300, 10, str_Image_path, player_1_pnl); //lays out the cards and picture boxes
                    card_placement = Make2DArray(card_placement_1d, 10, 10); //makes the card placement a 2d array
                }
                else
                {
                    show_cards_timer.Interval = 20000;
                    gimagearray = new GImageArray(this, int_board, 50, 50, 150, 300, 5, str_Image_path, player_1_pnl); //lays out the cards and picture boxes
                    card_placement = Make2DArray(card_placement_1d, 16, 16); //makes the card placement a 2d array
                }

                gimagearray.Which_Element_Clicked += new GImageArray.ImageClickedEventHandler(Which_Element_Clicked); //adds events to the pictures for when clicked
                set_board_to_cards(board_size, card_placement_1d); // sets all the cards on the board to be face up
                gimagearray.UpDateImages(int_board);
                show_cards_timer.Start();
            }
        }


        private void x6ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            x6ToolStripMenuItem.Checked = true;
            x10ToolStripMenuItem.Checked = false;
            x16ToolStripMenuItem.Checked = false;
            board_size = 36;
            max_score = 18;
            int_board = new int[6, 6];
            card_placement = new int[6, 6];
            card_placement_1d = new int[36];
            row_amount = 5;
            column_amount = 5;
        }

        private void x10ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            x6ToolStripMenuItem.Checked = false;
            x10ToolStripMenuItem.Checked = true;
            x16ToolStripMenuItem.Checked = false;
            board_size = 100;
            max_score = 50;
            int_board = new int[10, 10];
            card_placement = new int[10, 10];
            card_placement_1d = new int[100];
            row_amount = 9;
            column_amount = 9;
        }

        private void x16ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            x6ToolStripMenuItem.Checked = false;
            x10ToolStripMenuItem.Checked = false;
            x16ToolStripMenuItem.Checked = true;
            board_size = 256;
            max_score = 128;
            int_board = new int[16, 16];
            card_placement = new int[16, 16];
            card_placement_1d = new int[256];
            row_amount = 15;
            column_amount = 15;
        }

        private void show_cards_timer_Tick(object sender, EventArgs e)
        {
            for (int Row = 0; Row <= row_amount; Row++)
            {
                for (int Column = 0; Column <= column_amount; Column++)
                {
                    int_board[Row, Column] = 56;
                }
            }
            gimagearray.UpDateImages(int_board);
            show_cards_timer.Stop();
        }

        private bool check_games_finished()
        {
            if (player_1_score + player_2_score == max_score)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private void reset_board()
        {
            //Application.Restart();

            main_menu_lbl.Visible = true;
            player_1_name_txt.ReadOnly = false;
            player_1_name_txt.Text = "Name";
            player_2_name_txt.ReadOnly = false;
            player_2_name_txt.Text = "Name";
            game_started = false;

            for (int ix = this.Controls.Count - 1; ix >= 0; ix--)
            {
                if (this.Controls[ix] is PictureBox && this.Controls[ix] != main_menu_png)
                {
                    this.Controls[ix].Dispose();
                }
            }
            create_image();
        }

        private void save_game_menu_btn_Click(object sender, EventArgs e)
        {
            if (game_started)
            {

            }
            else
            {
                MessageBox.Show("No game is in progress, start a game to save the progress.");
            }
        }

        private void player_1_name_txt_Leave(object sender, EventArgs e)
        {
            if (player_1_name_txt.Text == "")
            {
                player_1_name_txt.Text = "Name";
                player_1_name_txt.ForeColor = Color.Silver;
            }
        }

        private void player_1_name_txt_Enter(object sender, EventArgs e)
        {
            if (player_1_name_txt.Text == "Name")
            {
                player_1_name_txt.Text = "";
                player_1_name_txt.ForeColor = Color.DarkSlateGray;
            }
        }

        private void player_2_name_txt_Leave(object sender, EventArgs e)
        {
            if (player_2_name_txt.Text == "")
            {
                player_2_name_txt.Text = "Name";
                player_2_name_txt.ForeColor = Color.Silver;
            }
        }

        private void player_2_name_txt_Enter(object sender, EventArgs e)
        {
            if (player_2_name_txt.Text == "Name")
            {
                player_2_name_txt.Text = "";
                player_2_name_txt.ForeColor = Color.DarkSlateGray;
            }
        }

        private void show_picked_cards_timer_Tick(object sender, EventArgs e)
        {
            if (!check_for_match())
            {
                int_board[first_card_selected_row, first_card_selected_column] = 56;
                int_board[second_card_selected_row, second_card_selected_column] = 56;
                gimagearray.UpDateImages(int_board);
                change_turn();
            }
            else
            {
                if (player_1_turn == true)
                {
                    player_1_score += 1;
                    player_1_score_txt.Text = Convert.ToString(player_1_score);
                }
                else
                {
                    player_2_score += 1;
                    player_2_score_txt.Text = Convert.ToString(player_2_score);
                }

                int_board[first_card_selected_row, first_card_selected_column] = 55;
                int_board[second_card_selected_row, second_card_selected_column] = 55;
                gimagearray.UpDateImages(int_board);

                if (check_games_finished())
                {
                    if (player_1_score < player_2_score)
                    {
                        MessageBox.Show($"{player_2_name_txt.Text} wins!");
                    }
                    else if (player_2_score < player_1_score)
                    {
                        MessageBox.Show($"{player_1_name_txt.Text} wins!");
                    }
                    else
                    {
                        MessageBox.Show("It's a draw!");
                    }
                    game_started = false;
                    reset_board();
                }
            }
            first_card_selected_row = -1;
            second_card_selected_row = -1;
            first_card_selected_column = -1;
            second_card_selected_column = -1;
            show_picked_cards_timer.Stop();
        }

        private void Pairs_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (game_started)
            {
                DialogResult save_game = MessageBox.Show("Are you sure you want to exit?\nYour game will not be saved.", "Save Game?", MessageBoxButtons.YesNo);
                if (save_game == DialogResult.Yes)
                {

                }
                else if (save_game == DialogResult.No)
                {
                    //do saving subroutine :)

                }
            }
        }

        private void Pairs_SizeChanged(object sender, EventArgs e)
        {
            int multiplier = this.Width / 1336;
            main_menu_lbl.Width *= multiplier;
            main_menu_lbl.Left = (this.Width - main_menu_lbl.Width) / 2;
            main_menu_png.Width *= multiplier;
            main_menu_png.Left = (this.Width - main_menu_png.Width) / 2;
        }

        private void about_btn_Click(object sender, EventArgs e)
        {
            Form about_box = new About();
            about_box.Show();
        }

        private void cards_selected_player_1_timer_Tick(object sender, EventArgs e)
        {
            player_1_first_card_png.BackgroundImage = null;
            player_1_second_card_png.BackgroundImage = null;
            cards_selected_player_1_timer.Stop();
        }

        private void cards_selected_player_2_timer_Tick(object sender, EventArgs e)
        {
            player_2_first_card_png.BackgroundImage = null;
            player_2_second_card_png.BackgroundImage = null;
            cards_selected_player_2_timer.Stop();
        }

        private void save_game()
        {
            using (StreamWriter writetext = new StreamWriter("write.txt"))
            {
                writetext.WriteLine("writing in text file");
            }
        }

        //private void label_fade_timer_Tick(object sender, EventArgs e)
        //{
        //    int fadingSpeed = 1;
        //    match_message_lbl.ForeColor = Color.FromArgb(match_message_lbl.ForeColor.R + fadingSpeed, match_message_lbl.ForeColor.G + fadingSpeed, match_message_lbl.ForeColor.B + fadingSpeed);

        //    if (match_message_lbl.ForeColor.R >= this.BackColor.R)
        //    {
        //        label_fade_timer.Stop();
        //        match_message_lbl.Visible = false;
        //    }
        //}
    }
}