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
using Pairs;

namespace pairs
{
    public partial class Pairs : Form
    {
        int[,] int_board = new int[6, 6];
        int[,] backs_of_the_cards = new int[6, 6];
        int[,] card_placement = new int[6, 6];
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
            main_menu_png.BackgroundImage = Image.FromFile(str_Image_path + "pears.png"); //sets main menu image
            for (int Row = 0; Row <= row_amount; Row++)
            {
                for (int Column = 0; Column <= column_amount; Column++)
                {
                    backs_of_the_cards[Row, Column] = 56; //initialises all the backs of the cards to be red (unmatched)
                }
            }
        }

        private int[] assign_cards()
        {
            int[] cards = new int[(board_size / 2)]; //makes array containing half the amount of total cards
            Random rnd = new Random(); //makes random

            for (int count = 0; count != (board_size / 2); count++) //does a count up to half the amount of total cards
            {
                int card = rnd.Next(55); //generates random number between 1 and 54 

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

        private void face_cards_up(int amount_of_cards, int[,] cards)
        {
            int item = 0; //starts item to know which card we're on
            for (int Row = 0; Row <= row_amount; Row++) //iterates through each row
            {
                for (int Column = 0; Column <= column_amount; Column++) //iterates through each column
                {
                    if (backs_of_the_cards[Row, Column] == 56) //checks cards not already been matched
                    {
                        int_board[Row, Column] = cards[Row, Column]; //assigns this picture with the correct card
                    }
                    else
                    {
                        int_board[Row, Column] = 55; //keeps card face down if already used in a match
                    }

                    if (item != amount_of_cards) //checks we've not run out of cards to set the picture for
                    {
                        item += 1; //moves on to the next item
                    }
                }
            }
            gimagearray.UpDateImages(int_board); //updates the board pictures
            show_cards_timer.Start(); //starts the timer for the cards showing
        }

        private void Pairs_Load(object sender, EventArgs e)
        {
            main_menu_lbl.Left = (this.Width - main_menu_lbl.Width) / 2; //centers the label when size changes
            main_menu_png.Left = (this.Width - main_menu_png.Width) / 2; //centers the picture when size changes
        }

        private static int[,] make_array_2d<T>(T[] input_1d_array, int array_height, int array_width) //takes values for the 1d array, as well as the width and height for the 2d array
        {
            int[,] output_2d_array = new int[array_height, array_width]; //creates new 2d array using the sizes passed to it
            for (int Row = 0; Row < array_height; Row++) //iterates through each row
            {
                for (int Column = 0; Column < array_width; Column++) //iterates through each column
                {
                    output_2d_array[Row, Column] = Convert.ToInt32(input_1d_array[Row * array_width + Column]); //adds the value to the final outputted 2d array
                }
            }
            return output_2d_array; //returns the 2d array
        }

        private void Which_Element_Clicked(object sender, EventArgs e)
        {
            if (!show_cards_timer.Enabled && !show_picked_cards_timer.Enabled) //checks timers aren't running
            {
                int Int_Row = gimagearray.Get_Row(sender); //gets row of just selected card
                int Int_Col = gimagearray.Get_Col(sender); //gets column of just selected card

                if (int_board[Int_Row, Int_Col] != 55) //checks card doesnt have a blue back (means its already been paired then)
                {
                    int_board[Int_Row, Int_Col] = card_placement[Int_Row, Int_Col]; //changes the image to the front of the card to flip the card
                    gimagearray.UpDateImages(int_board); //updates the images

                    if (first_card_selected_row == -1 && first_card_selected_column == -1) //checks if the player has selected their first card already
                    {
                        first_card_selected_row = Int_Row; //assign the row and column if not 
                        first_card_selected_column = Int_Col;
                        set_selected_card_images(); //changes the first selected cards images
                    }
                    else
                    {
                        if (first_card_selected_row == Int_Row && first_card_selected_column == Int_Col) //checks if the first and second card are not the same as to not match a card to itself 
                        {
                            MessageBox.Show("Please select a different card!"); //error message if they are the same
                        }
                        else
                        {
                            second_card_selected_row = Int_Row; //assigns to the second card if the first ones already selected
                            second_card_selected_column = Int_Col;

                            if (player_1_turn == true) //checks if its player 1's turn
                            {
                                player_1_second_card_png.BackgroundImage = Image.FromFile(str_Image_path + Convert.ToString(card_placement[second_card_selected_row, second_card_selected_column]) + ".png");
                                //assigns the player 1's second selected card
                                player_1_second_card_png.Visible = true; //makes the picture box visible
                            }
                            else
                            {
                                player_2_second_card_png.BackgroundImage = Image.FromFile(str_Image_path + Convert.ToString(card_placement[second_card_selected_row, second_card_selected_column]) + ".png");
                                //assigns the player 2's second selected card
                                player_2_second_card_png.Visible = true; //makes the picture box visible
                            }
                            show_picked_cards_timer.Start(); //shows the picked cards for a second
                        }
                    }
                }
                else
                {
                    MessageBox.Show("This card has already been matched, use a different one."); //error message if cards already been used in a pair
                }
                
            }
        }

        private void set_selected_card_images()
        {
            if (first_card_selected_row != -1 && first_card_selected_column != -1) //checks the first card has been selected (for when a games loaded)
            {
                if (player_1_turn == true) //checks if its player 1's turn
                {
                    player_1_first_card_png.BackgroundImage = Image.FromFile(str_Image_path + Convert.ToString(card_placement[first_card_selected_row, first_card_selected_column]) + ".png");
                    //assigns the player 1's first selected card
                }
                else
                {
                    player_2_first_card_png.BackgroundImage = Image.FromFile(str_Image_path + Convert.ToString(card_placement[first_card_selected_row, first_card_selected_column]) + ".png");
                    //assigns the player 2's first selected card
                }
            }
        }

        private bool check_for_match()
        {
            if (card_placement[first_card_selected_row, first_card_selected_column] //checks if the first card is the same as the second
                == card_placement[second_card_selected_row, second_card_selected_column])
            {
                return true; //true if match
            }
            else
            {
                return false; //false if not a match
            }
        }

        private void change_turn()
        {
            if (player_1_turn == true) // checks if its player 1s turn
            {
                player_1_turn_lbl.Visible = false; //makes the label not visible
                player_1_turn = false; //makes player 2's turn
                player_2_turn_lbl.Visible = true; //makes player 2's visible as it's now their turn
            }
            else
            {
                player_2_turn_lbl.Visible = false; //makes the label not visible
                player_1_turn = true; //makes player 1's turn
                player_1_turn_lbl.Visible = true; //makes player 1's visible as it's now their turn
            }
        }

        private void new_game_menu_btn_Click(object sender, EventArgs e)
        {
            if (!check_games_started(true))
            {
                if (String.IsNullOrEmpty(player_1_name_txt.Text) || player_1_name_txt.Text == "Name") //checks if player 1 name is empty
                {
                    player_1_name_txt.Text = ""; //clears the text in the text box 
                    player_1_name_txt.ForeColor = Color.DarkSlateGray; //changes back to normal colour 
                    player_1_name_txt.Text = My_Dialogs.InputBox("Player 1 does not have a name, please enter one here:"); //shows input box to input the users name
                    if (String.IsNullOrEmpty(player_1_name_txt.Text) || player_1_name_txt.Text == "Name") //checks if the user inputted anything
                    {
                        player_1_name_txt.Text = "Name";
                        player_1_name_txt.ForeColor = Color.Silver; //changes to ghost text colour if nothings entered
                    }
                    else
                    {
                        if (String.IsNullOrEmpty(player_2_name_txt.Text) || player_2_name_txt.Text == "Name") //checks if player 2 name is empty
                        {
                            player_2_name_txt.Text = ""; //clears the text in the text box 
                            player_2_name_txt.ForeColor = Color.DarkSlateGray; //changes back to normal colour 
                            player_2_name_txt.Text = My_Dialogs.InputBox("Player 2 does not have a name, please enter one here:"); //error message if so
                            if (String.IsNullOrEmpty(player_2_name_txt.Text) || player_2_name_txt.Text == "Name") //checks if the user inputted anything
                            {
                                player_2_name_txt.Text = "Name"; //sets back to ghost text
                                player_2_name_txt.ForeColor = Color.Silver; //changes to ghost text colour if nothings entered
                            }
                            else
                            {
                                int[] card_placement_1d = create_new_game(); //gets card placement as a 1d array
                                card_placement = make_array_2d(card_placement_1d, (row_amount + 1), (column_amount + 1)); //converts it to a 2d array
                                create_board(); //creates a new gimagearray
                                start_game(); //starts game
                            }
                        }
                        else
                        {
                            int[] card_placement_1d = create_new_game(); //gets card placement as a 1d array
                            card_placement = make_array_2d(card_placement_1d, (row_amount + 1), (column_amount + 1)); //converts it to a 2d array
                            create_board(); //creates a new gimagearray
                            start_game(); //starts game
                        }
                    }
                }
                else //if player 1 name is not empty
                {
                    if (String.IsNullOrEmpty(player_2_name_txt.Text) || player_2_name_txt.Text == "Name") //checks if player 2 name is empty
                    {
                        player_2_name_txt.Text = "";
                        player_2_name_txt.ForeColor = Color.DarkSlateGray; //does same as before
                        player_2_name_txt.Text = My_Dialogs.InputBox("Player 2 does not have a name, please enter one here:");
                        if (player_2_name_txt.Text == "Name")
                        {
                            player_2_name_txt.Text = "Name";
                            player_2_name_txt.ForeColor = Color.Silver;
                        }
                        else
                        {
                            int[] card_placement_1d = create_new_game();
                            card_placement = make_array_2d(card_placement_1d, (row_amount + 1), (column_amount + 1));
                            create_board();
                            start_game();
                        }
                    }
                    else
                    {
                        int[] card_placement_1d = create_new_game();
                        card_placement = make_array_2d(card_placement_1d, (row_amount + 1), (column_amount + 1));
                        create_board();
                        start_game();
                    }
                }
            }
        }

        private void start_game()
        {
            player_1_name_txt.ForeColor = Color.DarkSlateGray; //sets to not ghost text colour
            player_2_name_txt.ForeColor = Color.DarkSlateGray;
            if (player_1_turn == true) //checks if it's player 1's turn 
            {
                MessageBox.Show("Player 1 starts!"); //message box if so
                player_1_turn_lbl.Visible = true; //shows its their turn
            }
            else //appropriate message box based on whos turn it is
            {
                MessageBox.Show("Player 2 starts!"); //message box 
                player_2_turn_lbl.Visible = true; //shows its their turn
            }
            face_cards_up(board_size, card_placement); //makes cards face up
        }

        private void create_board()
        {
            if (board_size == 36) //checks what size the board is 
            {
                show_cards_timer.Interval = 10000; //changes timer interval appropriately 
                gimagearray = new GImageArray(this, int_board, 50, 50, 50, 300, 10, str_Image_path, player_1_pnl); //lays out the cards and picture boxes for this size
            }
            else if (board_size == 100)
            {
                show_cards_timer.Interval = 15000; //does the same
                gimagearray = new GImageArray(this, int_board, 50, 20, 10, 300, 10, str_Image_path, player_1_pnl); 
            }
            else if (board_size == 256)
            {
                show_cards_timer.Interval = 20000; //and again
                gimagearray = new GImageArray(this, int_board, 50, 50, 150, 300, 5, str_Image_path, player_1_pnl);
            }
            gimagearray.Which_Element_Clicked += new GImageArray.ImageClickedEventHandler(Which_Element_Clicked); //adds click events to the pictures for when clicked
            face_cards_up(board_size, card_placement); // sets all the cards on the board to be face up
        }

        private void x6ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            x6ToolStripMenuItem.Checked = true;
            x10ToolStripMenuItem.Checked = false; //unchecks other two options 
            x16ToolStripMenuItem.Checked = false;
            board_size = 36;
            max_score = 18; //changes all values to work for a 6 by 6 board
            int_board = new int[6, 6];
            backs_of_the_cards = new int[6, 6];
            card_placement = new int[6, 6];
            row_amount = 5;
            column_amount = 5;
        }

        private void x10ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            x6ToolStripMenuItem.Checked = false;
            x10ToolStripMenuItem.Checked = true; //unchecks other two options 
            x16ToolStripMenuItem.Checked = false;
            board_size = 100;
            max_score = 50; //changes all values to work for a 10 by 10 board
            int_board = new int[10, 10];
            backs_of_the_cards = new int[10, 10];
            card_placement = new int[10, 10];
            row_amount = 9;
            column_amount = 9;
        }

        private void x16ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            x6ToolStripMenuItem.Checked = false;
            x10ToolStripMenuItem.Checked = false; //unchecks other two options 
            x16ToolStripMenuItem.Checked = true;
            board_size = 256;
            max_score = 128; //changes all values to work for a 16 by 16 board
            int_board = new int[16, 16];
            backs_of_the_cards = new int[16, 16];
            card_placement = new int[16, 16];
            row_amount = 15;
            column_amount = 15;
        }

        private void show_cards_timer_Tick(object sender, EventArgs e)
        {
            for (int Row = 0; Row <= row_amount; Row++)
            {
                for (int Column = 0; Column <= column_amount; Column++)
                {
                    if (Row == first_card_selected_row && Column == first_card_selected_column)
                    //checks if card has been selected
                    {
                        int_board[Row, Column] = card_placement[Row, Column];
                        //keeps it face up if so
                    }
                    else
                    {
                        int_board[Row, Column] = backs_of_the_cards[Row, Column];
                        //makes it face down otherwise
                    }
                    //flips all the cards to show the back
                }
            }
            gimagearray.UpDateImages(int_board); //updaes the images
            show_cards_timer.Stop(); //stops the timer
        }

        private bool check_games_finished()
        {
            if (player_1_score + player_2_score == max_score) //adds the scores
            {
                return true; //true if at max 
            }
            else
            {
                return false; //false otherwise 
            }
        }

        private void reset_board()
        {
            main_menu_lbl.Visible = true;
            main_menu_png.Visible = true; //shows main menu items again
            player_1_name_txt.Text = "Name"; //resets name text boxes
            player_1_name_txt.ForeColor = Color.Silver;
            player_1_name_txt.ReadOnly = false;
            player_2_name_txt.Text = "Name";
            player_2_name_txt.ForeColor = Color.Silver;
            player_2_name_txt.ReadOnly = false;
            game_started = false; //makes so no game is started
            player_1_score = 0;
            player_1_score_txt.Text = "0";
            player_2_score = 0; //resets player scores
            player_2_score_txt.Text = "0";
            first_card_selected_row = -1;
            first_card_selected_column = -1; //resets any selected cards
            second_card_selected_row = -1;
            second_card_selected_column = -1;
            player_1_first_card_png.BackgroundImage = null; //removes any selected card pictures 
            player_2_first_card_png.BackgroundImage = null;
            for (int Row = 0; Row <= row_amount; Row++)
            {
                for (int Column = 0; Column <= column_amount; Column++)
                {
                    backs_of_the_cards[Row, Column] = 56; //resets all the backs of the cards
                }
            }
            gimagearray.Delete(); //deletes the cards and board
        }

        private void save_game_menu_btn_Click(object sender, EventArgs e)
        {
            if (game_started) //checks theres a started game to save
            {
                if (!show_picked_cards_timer.Enabled)
                // checks timers arent enabled
                {
                    save_game(); //save if not
                }
            }
            else
            {
                MessageBox.Show("No game is in progress, start a game to save the progress.");
                //error if not
            }
        }

        private void player_1_name_txt_Leave(object sender, EventArgs e)
        {
            if (player_1_name_txt.Text == "")
            {
                player_1_name_txt.Text = "Name"; //ghost text
                player_1_name_txt.ForeColor = Color.Silver;
            }
        }

        private void player_1_name_txt_Enter(object sender, EventArgs e)
        {
            if (player_1_name_txt.Text == "Name")
            {
                player_1_name_txt.Text = ""; //ghost text
                player_1_name_txt.ForeColor = Color.DarkSlateGray;
            }
        }

        private void player_2_name_txt_Leave(object sender, EventArgs e)
        {
            if (player_2_name_txt.Text == "")
            {
                player_2_name_txt.Text = "Name"; //ghost text
                player_2_name_txt.ForeColor = Color.Silver;
            }
        }

        private void player_2_name_txt_Enter(object sender, EventArgs e)
        {
            if (player_2_name_txt.Text == "Name")
            {
                player_2_name_txt.Text = ""; //ghost text
                player_2_name_txt.ForeColor = Color.DarkSlateGray;
            }
        }

        private void show_picked_cards_timer_Tick(object sender, EventArgs e)
        {
            if (!check_for_match()) //checks if cards dont match
            {
                int_board[first_card_selected_row, first_card_selected_column] = 56;
                int_board[second_card_selected_row, second_card_selected_column] = 56;
                //turns red if not a match
                gimagearray.UpDateImages(int_board); //updates images
                change_turn(); //changes who's turn it is
            }
            else //if it's a match
            {
                if (player_1_turn == true) //if its p1 turn
                {
                    player_1_score += 1; //add 1 to p1 score
                    player_1_score_txt.Text = Convert.ToString(player_1_score); //change p1 score text box 
                }
                else //if p2 turn
                {
                    player_2_score += 1; //add 1 to p2 turn
                    player_2_score_txt.Text = Convert.ToString(player_2_score); //changes p2 score text box
                }
                int_board[first_card_selected_row, first_card_selected_column] = 55;
                backs_of_the_cards[first_card_selected_row, first_card_selected_column] = 55; 
                int_board[second_card_selected_row, second_card_selected_column] = 55; //changes backs to blue
                backs_of_the_cards[second_card_selected_row, second_card_selected_column] = 55;
                gimagearray.UpDateImages(int_board); //updates pictures 
                if (check_games_finished()) //if the game is over
                {
                    if (player_1_score < player_2_score) //if p2's score is higher
                    {
                        MessageBox.Show($"{player_2_name_txt.Text} wins!"); //p2 wins
                    }
                    else if (player_2_score < player_1_score) //if p1's score is higher
                    {
                        MessageBox.Show($"{player_1_name_txt.Text} wins!"); //p1 wins
                    }
                    else //if the same
                    {
                        MessageBox.Show("It's a draw!"); //draw
                    }
                    game_started = false; //game ends
                    reset_board(); //resets board
                }
            } 
            first_card_selected_row = -1;
            second_card_selected_row = -1; //resets picked cards
            first_card_selected_column = -1;
            second_card_selected_column = -1;
            player_1_first_card_png.BackgroundImage = null; //resets card images
            player_1_second_card_png.BackgroundImage = null;
            player_1_second_card_png.Visible = false; //hides second card picture boxes
            player_2_first_card_png.BackgroundImage = null;
            player_2_second_card_png.BackgroundImage = null;
            player_2_second_card_png.Visible = false;
            show_picked_cards_timer.Stop(); //stops the timer 
        }

        private void Pairs_FormClosing(object sender, FormClosingEventArgs e)
        {
            prompt_user_to_save(); //ask user if they want to save
        }

        private void prompt_user_to_save()
        {
            if (game_started) //checks if game is in progress 
            {
                DialogResult save_bool = MessageBox.Show("A game is in progress, would you like to save it before exiting?", "Save Game?", MessageBoxButtons.YesNo);
                //asks if they want to save
                if (save_bool == DialogResult.Yes) //if yes
                {
                    save_game(); //save their game
                }
            }
        }

        private void Pairs_SizeChanged(object sender, EventArgs e)
        {
            main_menu_lbl.Left = (this.Width - main_menu_lbl.Width) / 2;
            //centers the main menu items
            main_menu_png.Left = (this.Width - main_menu_png.Width) / 2;
        }

        private void about_btn_Click(object sender, EventArgs e)
        {
            Form about_box = new About(str_Image_path, this); //creates new about box
            about_box.Show(); //shows it
        }

        private void save_game()
        {
            try //try in case of error
            {
                using (SaveFileDialog saveFileDialog = new SaveFileDialog()) //using a file explorer to save the file
                {
                    saveFileDialog.InitialDirectory = "c:\\";
                    saveFileDialog.Filter = "Text Files | *.txt";
                    saveFileDialog.DefaultExt = "txt"; //defaults the file to be a text file
                    saveFileDialog.FilterIndex = 2;
                    saveFileDialog.RestoreDirectory = true;

                    if (saveFileDialog.ShowDialog() == DialogResult.OK) //if the user selects ok
                    {
                        Stream fileStream = saveFileDialog.OpenFile(); //opens file
                        using (var sw = new StreamWriter(fileStream)) //uses the open file
                        {
                            sw.WriteLine(Convert.ToString(board_size)); //writes the first line as board size
                            for (int Row = 0; Row <= row_amount; Row++) 
                            {
                                for (int Column = 0; Column <= column_amount; Column++)
                                {
                                    sw.WriteLine(backs_of_the_cards[Row, Column]); //writes all the backs of cards
                                }
                            }
                            for (int Row = 0; Row <= row_amount; Row++)
                            {
                                for (int Column = 0; Column <= column_amount; Column++)
                                {
                                    sw.WriteLine(card_placement[Row, Column]); //writes all the card placements 
                                }
                            }
                            sw.WriteLine(first_card_selected_row); //writes first select cards to the file
                            sw.WriteLine(first_card_selected_column); //cant use save function when second is selected so no need to save it
                            sw.WriteLine(player_1_score); //writes the player scores
                            sw.WriteLine(player_2_score);
                            sw.WriteLine(player_1_name_txt.Text); //writes the player name
                            sw.WriteLine(player_2_name_txt.Text);
                            sw.WriteLine(player_1_turn); //writes whos turn it is
                            sw.Flush(); //clears the writer
                            sw.Close(); //closes the writer
                        }
                    }
                }
            }
            catch
            {
                MessageBox.Show("Error"); //error message
            }
        }

        private int[] create_new_game()
        {
            Random rnd = new Random(); //random
            player_1_turn = rnd.NextDouble() >= 0.5; //decides who turn it is randomly
            player_2_name_txt.ReadOnly = true; //sets name
            player_1_name_txt.ReadOnly = true;
            game_started = true;
            main_menu_lbl.Visible = false;
            main_menu_png.Visible = false;

            //maths for 16x16
            if (board_size == 256) //checks if board is 16x16
            {
                board_size = 108; 
                //sets to 108, as theres a max of 53 card pictures
                //so in pairs that is 54*2=108
            }
            int [] card_placement_1d = assign_cards(); // gets the placement for the cards on the board
            if (board_size == 108) //checks if the board size is 108 (256)
            {
                card_placement_1d = card_placement_1d.Concat(card_placement_1d).ToArray(); 
                //duplicates all of the items in the list to get 2 of each card, as 256-108=148
                //meaning we can get another 108, 148-108 = 40
                //meaning we have a left over of 40
                board_size = 40; //meaning we need to do it again with 40

                int[] left_over = assign_cards(); //save the left over to an array

                card_placement_1d = card_placement_1d.Concat(left_over).ToArray();
                //then concatenate the left over onto the cards we already have
                card_placement_1d = card_placement_1d.OrderBy(x => rnd.Next()).ToArray();
                //then randomly assort them

                board_size = 256; //set board size back to normal
            }
            //maths for 16x16

            for (int Row = 0; Row <= row_amount; Row++)
            {
                for (int Column = 0; Column <= column_amount; Column++)
                {
                    int_board[Row, Column] = 56; //sets all the cards backs to be 56
                    backs_of_the_cards[Row, Column] = 56;
                }
            }
            return card_placement_1d; //returns the card placements as a 1d array
          //  card_placement = make_array_2d(card_placement_1d, 6, 6);
        }

        private bool load_game()
        {
            bool valid_file = true; //initialises valid file to be false
            try //try in case of errors
            {
                using (OpenFileDialog openFileDialog = new OpenFileDialog()) 
                //creates a new file explorer to open a file
                {
                    openFileDialog.InitialDirectory = "c:\\";
                    openFileDialog.Filter = "Text Files | *.txt";
                    openFileDialog.FilterIndex = 2; //sets it to look for text files 
                    openFileDialog.RestoreDirectory = true;
                    if (openFileDialog.ShowDialog() == DialogResult.OK)
                    //if the user selects ok
                    {
                        //reads the contents of the file into a stream
                        var fileStream = openFileDialog.OpenFile();
                        using (StreamReader reader = new StreamReader(fileStream))
                        //uses the reader and stream
                        {
                            board_size = Convert.ToInt32(reader.ReadLine());
                            //reads line by line, first line is board size
                            if (!game_started) //checks if games not started
                            {
                                if (board_size == 36)
                                {
                                    //initialises values to be for a 6x6 board
                                    x6ToolStripMenuItem.Checked = true;
                                    x10ToolStripMenuItem.Checked = false;
                                    x16ToolStripMenuItem.Checked = false;
                                    show_cards_timer.Interval = 10000;
                                    int_board = new int[6, 6];
                                    backs_of_the_cards = new int[6, 6];
                                    card_placement = new int[6, 6];
                                    row_amount = 5;
                                    column_amount = 5;
                                    max_score = 18;
                                }
                                else if (board_size == 100)
                                {
                                    //initialises values to be for a 10x10 board
                                    x6ToolStripMenuItem.Checked = false;
                                    x10ToolStripMenuItem.Checked = true;
                                    x16ToolStripMenuItem.Checked = false;
                                    show_cards_timer.Interval = 15000;
                                    int_board = new int[10, 10];
                                    backs_of_the_cards = new int[10, 10];
                                    card_placement = new int[10, 10];
                                    row_amount = 9;
                                    column_amount = 9;
                                    max_score = 50;
                                }
                                else if (board_size == 256)
                                {
                                    //initialises values to be for a 16x16 board
                                    x6ToolStripMenuItem.Checked = false;
                                    x10ToolStripMenuItem.Checked = false;
                                    x16ToolStripMenuItem.Checked = true;
                                    show_cards_timer.Interval = 20000;
                                    int_board = new int[16, 16];
                                    backs_of_the_cards = new int[16, 16];
                                    card_placement = new int[16, 16];
                                    row_amount = 15;
                                    column_amount = 15;
                                    max_score = 128;
                                }
                                else
                                {
                                    MessageBox.Show("Invalid file, please use a different one.");
                                    //error message
                                    valid_file = false;
                                    //invalid file
                                }
                            }
                            if (valid_file) //if file loaded is valid
                            {
                                create_board(); //creates the gimagearray
                                game_started = true; //sets game started to true
                                for (int Row = 0; Row <= row_amount; Row++)
                                {
                                    for (int Column = 0; Column <= column_amount; Column++)
                                    {
                                        int card_back = Convert.ToInt32(reader.ReadLine());
                                        //stores the card back
                                        if (card_back != 55 && card_back != 56) //checks card backs are valid
                                        {
                                            reset_board(); //resets the board if not
                                            throw new Exception(); //throws an error to run the catch
                                        }
                                        //assigns the card back to a variable line by line
                                        int_board[Row, Column] = card_back;
                                        //adds the card to both of the arrays
                                        backs_of_the_cards[Row, Column] = card_back;
                                    }
                                }
                                
                                gimagearray.UpDateImages(int_board); //updates the images
                                for (int Row = 0; Row <= row_amount; Row++)
                                {
                                    for (int Column = 0; Column <= column_amount; Column++)
                                    {
                                        int card = Convert.ToInt32(reader.ReadLine());
                                        //stores card front
                                        if (card < 1 || card > 55) //checks cards front are valid 
                                        {
                                            reset_board(); //does the same as before
                                            throw new Exception();
                                        }
                                        card_placement[Row, Column] = card;
                                        //sets all of the values for the card placement, reads it line by line
                                    }
                                }
                                first_card_selected_row = Convert.ToInt32(reader.ReadLine());
                                if (first_card_selected_row < -1 || first_card_selected_row > 55)
                                //checks card is valid
                                {
                                    reset_board();
                                    throw new Exception();
                                }
                                first_card_selected_column = Convert.ToInt32(reader.ReadLine());
                                //gets first selected cards
                                if (first_card_selected_column < -1 || first_card_selected_column > 55)
                                //checks card is valid
                                {
                                    reset_board();
                                    throw new Exception();
                                }
                                player_1_score = Convert.ToInt32(reader.ReadLine());
                                if (player_1_score < 0 || player_1_score > max_score)
                                //checks player 1's score is valid
                                {
                                    reset_board();
                                    throw new Exception();
                                }
                                //gets scores
                                player_2_score = Convert.ToInt32(reader.ReadLine());
                                if (player_2_score < 0 || player_2_score > max_score)
                                //checks player 2's score is valid
                                {
                                    reset_board();
                                    throw new Exception();
                                }
                                player_1_name_txt.Text = reader.ReadLine();
                                player_1_name_txt.ForeColor = Color.DarkSlateGray;
                                //gets names
                                player_2_name_txt.Text = reader.ReadLine();
                                player_2_name_txt.ForeColor = Color.DarkSlateGray;
                                player_1_turn = Convert.ToBoolean(reader.ReadLine());
                                //gets whos turn it is
                                set_values(); //sets variables to have the correct values
                                return true; //returns that the save is valid
                            }
                        }
                    }
                }
            }
            catch
            {
                MessageBox.Show("Error, please use a valid file."); //error message
                return false; //returns saves not valid
            }
            return false; //so all paths return
        }

        private bool check_games_started(bool show_message)
        {
            if (game_started) //checks if games started
            {
                if (show_message) //checks if error message should be displayed
                {
                    MessageBox.Show("A game is already in progress, please exit first.");
                    //error message if so
                }
                return true; //returns that game has started
            }
            else //if games not started
            {
                return false; //returns that game has not started
            }
        }

        private void set_values() 
        {
            player_2_name_txt.ReadOnly = true;
            player_1_name_txt.ReadOnly = true;
            //makes names read only so they cannot be changed mid game
            player_1_name_txt.ForeColor = Color.DarkSlateGray;
            player_2_name_txt.ForeColor = Color.DarkSlateGray;
            //changes to non ghost text colour
            game_started = true; 
            //sets game to started
            main_menu_lbl.Visible = false;
            main_menu_png.Visible = false;
            //hides main menu items
            player_1_score_txt.Text = Convert.ToString(player_1_score);
            player_2_score_txt.Text = Convert.ToString(player_2_score);
            //puts the scores on 
            start_game(); //starts the game
        }

        private void exit_menu_btn_Click(object sender, EventArgs e)
        {
            if (check_games_started(false)) //checks if game is running
            //false as i dont want the error message to show
            {
                prompt_user_to_save(); //asks the user if they want to save
                reset_board(); //resets the board

            }
        }

        private void retrieve_game_menu_btn_Click(object sender, EventArgs e)
        {
            if (!check_games_started(true))//checks if game is running
            //true as i do want the error message to show
            {
                if (load_game()) //checks if it was able to load
                {
                    set_selected_card_images(); 
                    //sets the pictures if so
                }
            }
        }
    }
}