namespace pairs
{
    partial class Pairs
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.menu_bar = new System.Windows.Forms.MenuStrip();
            this.game_menu_btn = new System.Windows.Forms.ToolStripMenuItem();
            this.new_game_menu_btn = new System.Windows.Forms.ToolStripMenuItem();
            this.sepToolStripMenuItem = new System.Windows.Forms.ToolStripSeparator();
            this.save_game_menu_btn = new System.Windows.Forms.ToolStripMenuItem();
            this.retrieve_game_menu_btn = new System.Windows.Forms.ToolStripMenuItem();
            this.serpToolStripMenuItem = new System.Windows.Forms.ToolStripSeparator();
            this.exit_menu_btn = new System.Windows.Forms.ToolStripMenuItem();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sizeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.x6ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.x10ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.x16ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.abouToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.show_cards_timer = new System.Windows.Forms.Timer(this.components);
            this.player_2_pnl = new System.Windows.Forms.Panel();
            this.player_2_cards_box = new System.Windows.Forms.GroupBox();
            this.player_2_second_card_png = new System.Windows.Forms.PictureBox();
            this.player_2_first_card_png = new System.Windows.Forms.PictureBox();
            this.player_2_name_txt = new System.Windows.Forms.TextBox();
            this.player_2_name_lbl = new System.Windows.Forms.Label();
            this.player_1_pnl = new System.Windows.Forms.Panel();
            this.player_1_cards_box = new System.Windows.Forms.GroupBox();
            this.player_1_second_card_png = new System.Windows.Forms.PictureBox();
            this.player_1_first_card_png = new System.Windows.Forms.PictureBox();
            this.player_1_name_txt = new System.Windows.Forms.TextBox();
            this.player_1_name_lbl = new System.Windows.Forms.Label();
            this.main_menu_lbl = new System.Windows.Forms.Label();
            this.main_menu_png = new System.Windows.Forms.PictureBox();
            this.player_1_pairs_lbl = new System.Windows.Forms.Label();
            this.player_1_score_txt = new System.Windows.Forms.TextBox();
            this.player_2_score_txt = new System.Windows.Forms.TextBox();
            this.player_2_pairs_lbl = new System.Windows.Forms.Label();
            this.player_1_turn_lbl = new System.Windows.Forms.Label();
            this.player_2_turn_lbl = new System.Windows.Forms.Label();
            this.show_picked_cards_timer = new System.Windows.Forms.Timer(this.components);
            this.match_message_lbl = new System.Windows.Forms.Label();
            this.label_fade_timer = new System.Windows.Forms.Timer(this.components);
            this.menu_bar.SuspendLayout();
            this.player_2_pnl.SuspendLayout();
            this.player_2_cards_box.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.player_2_second_card_png)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.player_2_first_card_png)).BeginInit();
            this.player_1_pnl.SuspendLayout();
            this.player_1_cards_box.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.player_1_second_card_png)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.player_1_first_card_png)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.main_menu_png)).BeginInit();
            this.SuspendLayout();
            // 
            // menu_bar
            // 
            this.menu_bar.BackColor = System.Drawing.Color.Azure;
            this.menu_bar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.game_menu_btn,
            this.settingsToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menu_bar.Location = new System.Drawing.Point(0, 0);
            this.menu_bar.Name = "menu_bar";
            this.menu_bar.Padding = new System.Windows.Forms.Padding(7, 2, 0, 2);
            this.menu_bar.Size = new System.Drawing.Size(1320, 33);
            this.menu_bar.TabIndex = 5;
            this.menu_bar.Text = "menuStrip1";
            // 
            // game_menu_btn
            // 
            this.game_menu_btn.BackColor = System.Drawing.Color.Azure;
            this.game_menu_btn.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.new_game_menu_btn,
            this.sepToolStripMenuItem,
            this.save_game_menu_btn,
            this.retrieve_game_menu_btn,
            this.serpToolStripMenuItem,
            this.exit_menu_btn});
            this.game_menu_btn.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.game_menu_btn.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.game_menu_btn.ImageTransparentColor = System.Drawing.Color.Azure;
            this.game_menu_btn.Name = "game_menu_btn";
            this.game_menu_btn.Size = new System.Drawing.Size(73, 29);
            this.game_menu_btn.Text = "Game";
            // 
            // new_game_menu_btn
            // 
            this.new_game_menu_btn.BackColor = System.Drawing.Color.Azure;
            this.new_game_menu_btn.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.new_game_menu_btn.Name = "new_game_menu_btn";
            this.new_game_menu_btn.Size = new System.Drawing.Size(205, 30);
            this.new_game_menu_btn.Text = "New Game";
            this.new_game_menu_btn.Click += new System.EventHandler(this.new_game_menu_btn_Click);
            // 
            // sepToolStripMenuItem
            // 
            this.sepToolStripMenuItem.BackColor = System.Drawing.Color.Azure;
            this.sepToolStripMenuItem.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.sepToolStripMenuItem.Name = "sepToolStripMenuItem";
            this.sepToolStripMenuItem.Size = new System.Drawing.Size(202, 6);
            // 
            // save_game_menu_btn
            // 
            this.save_game_menu_btn.BackColor = System.Drawing.Color.Azure;
            this.save_game_menu_btn.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.save_game_menu_btn.Name = "save_game_menu_btn";
            this.save_game_menu_btn.Size = new System.Drawing.Size(205, 30);
            this.save_game_menu_btn.Text = "Save Game";
            this.save_game_menu_btn.Click += new System.EventHandler(this.save_game_menu_btn_Click);
            // 
            // retrieve_game_menu_btn
            // 
            this.retrieve_game_menu_btn.BackColor = System.Drawing.Color.Azure;
            this.retrieve_game_menu_btn.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.retrieve_game_menu_btn.Name = "retrieve_game_menu_btn";
            this.retrieve_game_menu_btn.Size = new System.Drawing.Size(205, 30);
            this.retrieve_game_menu_btn.Text = "Retrieve Game";
            // 
            // serpToolStripMenuItem
            // 
            this.serpToolStripMenuItem.BackColor = System.Drawing.Color.Azure;
            this.serpToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.serpToolStripMenuItem.Name = "serpToolStripMenuItem";
            this.serpToolStripMenuItem.Size = new System.Drawing.Size(202, 6);
            // 
            // exit_menu_btn
            // 
            this.exit_menu_btn.BackColor = System.Drawing.Color.Azure;
            this.exit_menu_btn.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.exit_menu_btn.Name = "exit_menu_btn";
            this.exit_menu_btn.Size = new System.Drawing.Size(205, 30);
            this.exit_menu_btn.Text = "Exit";
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sizeToolStripMenuItem});
            this.settingsToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.settingsToolStripMenuItem.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(91, 29);
            this.settingsToolStripMenuItem.Text = "Settings";
            // 
            // sizeToolStripMenuItem
            // 
            this.sizeToolStripMenuItem.BackColor = System.Drawing.Color.Azure;
            this.sizeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.x6ToolStripMenuItem,
            this.x10ToolStripMenuItem,
            this.x16ToolStripMenuItem});
            this.sizeToolStripMenuItem.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.sizeToolStripMenuItem.Name = "sizeToolStripMenuItem";
            this.sizeToolStripMenuItem.Size = new System.Drawing.Size(118, 30);
            this.sizeToolStripMenuItem.Text = "Size";
            // 
            // x6ToolStripMenuItem
            // 
            this.x6ToolStripMenuItem.Checked = true;
            this.x6ToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.x6ToolStripMenuItem.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.x6ToolStripMenuItem.Name = "x6ToolStripMenuItem";
            this.x6ToolStripMenuItem.Size = new System.Drawing.Size(143, 30);
            this.x6ToolStripMenuItem.Text = "6 x 6";
            this.x6ToolStripMenuItem.Click += new System.EventHandler(this.x6ToolStripMenuItem_Click);
            // 
            // x10ToolStripMenuItem
            // 
            this.x10ToolStripMenuItem.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.x10ToolStripMenuItem.Name = "x10ToolStripMenuItem";
            this.x10ToolStripMenuItem.Size = new System.Drawing.Size(143, 30);
            this.x10ToolStripMenuItem.Text = "10 x 10";
            this.x10ToolStripMenuItem.Click += new System.EventHandler(this.x10ToolStripMenuItem_Click);
            // 
            // x16ToolStripMenuItem
            // 
            this.x16ToolStripMenuItem.BackColor = System.Drawing.Color.Azure;
            this.x16ToolStripMenuItem.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.x16ToolStripMenuItem.Name = "x16ToolStripMenuItem";
            this.x16ToolStripMenuItem.Size = new System.Drawing.Size(143, 30);
            this.x16ToolStripMenuItem.Text = "16 x 16";
            this.x16ToolStripMenuItem.Click += new System.EventHandler(this.x16ToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.abouToolStripMenuItem});
            this.helpToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.helpToolStripMenuItem.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(63, 29);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // abouToolStripMenuItem
            // 
            this.abouToolStripMenuItem.BackColor = System.Drawing.Color.Azure;
            this.abouToolStripMenuItem.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.abouToolStripMenuItem.Name = "abouToolStripMenuItem";
            this.abouToolStripMenuItem.Size = new System.Drawing.Size(135, 30);
            this.abouToolStripMenuItem.Text = "About";
            // 
            // show_cards_timer
            // 
            this.show_cards_timer.Interval = 10000;
            this.show_cards_timer.Tick += new System.EventHandler(this.show_cards_timer_Tick);
            // 
            // player_2_pnl
            // 
            this.player_2_pnl.BackColor = System.Drawing.Color.LightCyan;
            this.player_2_pnl.Controls.Add(this.player_2_turn_lbl);
            this.player_2_pnl.Controls.Add(this.player_2_score_txt);
            this.player_2_pnl.Controls.Add(this.player_2_cards_box);
            this.player_2_pnl.Controls.Add(this.player_2_pairs_lbl);
            this.player_2_pnl.Controls.Add(this.player_2_name_txt);
            this.player_2_pnl.Controls.Add(this.player_2_name_lbl);
            this.player_2_pnl.Dock = System.Windows.Forms.DockStyle.Right;
            this.player_2_pnl.Location = new System.Drawing.Point(1087, 33);
            this.player_2_pnl.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.player_2_pnl.Name = "player_2_pnl";
            this.player_2_pnl.Size = new System.Drawing.Size(233, 885);
            this.player_2_pnl.TabIndex = 6;
            // 
            // player_2_cards_box
            // 
            this.player_2_cards_box.Controls.Add(this.player_2_second_card_png);
            this.player_2_cards_box.Controls.Add(this.player_2_first_card_png);
            this.player_2_cards_box.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.player_2_cards_box.Location = new System.Drawing.Point(0, 510);
            this.player_2_cards_box.Name = "player_2_cards_box";
            this.player_2_cards_box.Size = new System.Drawing.Size(233, 375);
            this.player_2_cards_box.TabIndex = 14;
            this.player_2_cards_box.TabStop = false;
            this.player_2_cards_box.Text = "Cards Selected";
            // 
            // player_2_second_card_png
            // 
            this.player_2_second_card_png.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.player_2_second_card_png.Location = new System.Drawing.Point(98, 176);
            this.player_2_second_card_png.Name = "player_2_second_card_png";
            this.player_2_second_card_png.Size = new System.Drawing.Size(123, 165);
            this.player_2_second_card_png.TabIndex = 13;
            this.player_2_second_card_png.TabStop = false;
            this.player_2_second_card_png.Visible = false;
            // 
            // player_2_first_card_png
            // 
            this.player_2_first_card_png.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.player_2_first_card_png.Location = new System.Drawing.Point(15, 32);
            this.player_2_first_card_png.Name = "player_2_first_card_png";
            this.player_2_first_card_png.Size = new System.Drawing.Size(141, 171);
            this.player_2_first_card_png.TabIndex = 12;
            this.player_2_first_card_png.TabStop = false;
            // 
            // player_2_name_txt
            // 
            this.player_2_name_txt.BackColor = System.Drawing.Color.Azure;
            this.player_2_name_txt.Font = new System.Drawing.Font("Segoe UI", 14.25F);
            this.player_2_name_txt.ForeColor = System.Drawing.Color.Silver;
            this.player_2_name_txt.Location = new System.Drawing.Point(27, 51);
            this.player_2_name_txt.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.player_2_name_txt.Name = "player_2_name_txt";
            this.player_2_name_txt.Size = new System.Drawing.Size(179, 33);
            this.player_2_name_txt.TabIndex = 9;
            this.player_2_name_txt.Text = "Name";
            this.player_2_name_txt.Enter += new System.EventHandler(this.player_2_name_txt_Enter);
            this.player_2_name_txt.Leave += new System.EventHandler(this.player_2_name_txt_Leave);
            // 
            // player_2_name_lbl
            // 
            this.player_2_name_lbl.AutoSize = true;
            this.player_2_name_lbl.Font = new System.Drawing.Font("Segoe UI", 15.75F);
            this.player_2_name_lbl.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.player_2_name_lbl.Location = new System.Drawing.Point(39, 18);
            this.player_2_name_lbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.player_2_name_lbl.Name = "player_2_name_lbl";
            this.player_2_name_lbl.Size = new System.Drawing.Size(153, 30);
            this.player_2_name_lbl.TabIndex = 10;
            this.player_2_name_lbl.Text = "Player 2 Name:";
            // 
            // player_1_pnl
            // 
            this.player_1_pnl.BackColor = System.Drawing.Color.LightCyan;
            this.player_1_pnl.Controls.Add(this.player_1_turn_lbl);
            this.player_1_pnl.Controls.Add(this.player_1_score_txt);
            this.player_1_pnl.Controls.Add(this.player_1_pairs_lbl);
            this.player_1_pnl.Controls.Add(this.player_1_cards_box);
            this.player_1_pnl.Controls.Add(this.player_1_name_txt);
            this.player_1_pnl.Controls.Add(this.player_1_name_lbl);
            this.player_1_pnl.Dock = System.Windows.Forms.DockStyle.Left;
            this.player_1_pnl.Location = new System.Drawing.Point(0, 33);
            this.player_1_pnl.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.player_1_pnl.Name = "player_1_pnl";
            this.player_1_pnl.Size = new System.Drawing.Size(233, 885);
            this.player_1_pnl.TabIndex = 7;
            // 
            // player_1_cards_box
            // 
            this.player_1_cards_box.Controls.Add(this.player_1_second_card_png);
            this.player_1_cards_box.Controls.Add(this.player_1_first_card_png);
            this.player_1_cards_box.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.player_1_cards_box.Location = new System.Drawing.Point(0, 510);
            this.player_1_cards_box.Name = "player_1_cards_box";
            this.player_1_cards_box.Size = new System.Drawing.Size(233, 375);
            this.player_1_cards_box.TabIndex = 10;
            this.player_1_cards_box.TabStop = false;
            this.player_1_cards_box.Text = "Cards Selected";
            // 
            // player_1_second_card_png
            // 
            this.player_1_second_card_png.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.player_1_second_card_png.Location = new System.Drawing.Point(93, 176);
            this.player_1_second_card_png.Name = "player_1_second_card_png";
            this.player_1_second_card_png.Size = new System.Drawing.Size(125, 165);
            this.player_1_second_card_png.TabIndex = 13;
            this.player_1_second_card_png.TabStop = false;
            this.player_1_second_card_png.Visible = false;
            // 
            // player_1_first_card_png
            // 
            this.player_1_first_card_png.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.player_1_first_card_png.Location = new System.Drawing.Point(12, 32);
            this.player_1_first_card_png.Name = "player_1_first_card_png";
            this.player_1_first_card_png.Size = new System.Drawing.Size(141, 171);
            this.player_1_first_card_png.TabIndex = 12;
            this.player_1_first_card_png.TabStop = false;
            // 
            // player_1_name_txt
            // 
            this.player_1_name_txt.BackColor = System.Drawing.Color.Azure;
            this.player_1_name_txt.Font = new System.Drawing.Font("Segoe UI", 14.25F);
            this.player_1_name_txt.ForeColor = System.Drawing.Color.Silver;
            this.player_1_name_txt.Location = new System.Drawing.Point(26, 51);
            this.player_1_name_txt.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.player_1_name_txt.Name = "player_1_name_txt";
            this.player_1_name_txt.Size = new System.Drawing.Size(179, 33);
            this.player_1_name_txt.TabIndex = 11;
            this.player_1_name_txt.Text = "Name";
            this.player_1_name_txt.Enter += new System.EventHandler(this.player_1_name_txt_Enter);
            this.player_1_name_txt.Leave += new System.EventHandler(this.player_1_name_txt_Leave);
            // 
            // player_1_name_lbl
            // 
            this.player_1_name_lbl.AutoSize = true;
            this.player_1_name_lbl.Font = new System.Drawing.Font("Segoe UI", 15.75F);
            this.player_1_name_lbl.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.player_1_name_lbl.Location = new System.Drawing.Point(34, 18);
            this.player_1_name_lbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.player_1_name_lbl.Name = "player_1_name_lbl";
            this.player_1_name_lbl.Size = new System.Drawing.Size(153, 30);
            this.player_1_name_lbl.TabIndex = 8;
            this.player_1_name_lbl.Text = "Player 1 Name:";
            // 
            // main_menu_lbl
            // 
            this.main_menu_lbl.AutoSize = true;
            this.main_menu_lbl.Font = new System.Drawing.Font("Segoe UI", 36F);
            this.main_menu_lbl.Location = new System.Drawing.Point(486, 114);
            this.main_menu_lbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.main_menu_lbl.Name = "main_menu_lbl";
            this.main_menu_lbl.Size = new System.Drawing.Size(349, 130);
            this.main_menu_lbl.TabIndex = 8;
            this.main_menu_lbl.Text = "Pairs\r\nA Game of Two";
            this.main_menu_lbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // main_menu_png
            // 
            this.main_menu_png.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.main_menu_png.Location = new System.Drawing.Point(347, 258);
            this.main_menu_png.Name = "main_menu_png";
            this.main_menu_png.Size = new System.Drawing.Size(627, 536);
            this.main_menu_png.TabIndex = 9;
            this.main_menu_png.TabStop = false;
            // 
            // player_1_pairs_lbl
            // 
            this.player_1_pairs_lbl.AutoSize = true;
            this.player_1_pairs_lbl.Font = new System.Drawing.Font("Segoe UI", 15.75F);
            this.player_1_pairs_lbl.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.player_1_pairs_lbl.Location = new System.Drawing.Point(56, 114);
            this.player_1_pairs_lbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.player_1_pairs_lbl.Name = "player_1_pairs_lbl";
            this.player_1_pairs_lbl.Size = new System.Drawing.Size(120, 30);
            this.player_1_pairs_lbl.TabIndex = 12;
            this.player_1_pairs_lbl.Text = "Pairs Found";
            // 
            // player_1_score_txt
            // 
            this.player_1_score_txt.BackColor = System.Drawing.Color.Azure;
            this.player_1_score_txt.Font = new System.Drawing.Font("Segoe UI", 14.25F);
            this.player_1_score_txt.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.player_1_score_txt.Location = new System.Drawing.Point(26, 147);
            this.player_1_score_txt.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.player_1_score_txt.Name = "player_1_score_txt";
            this.player_1_score_txt.Size = new System.Drawing.Size(179, 33);
            this.player_1_score_txt.TabIndex = 13;
            this.player_1_score_txt.Text = "0";
            this.player_1_score_txt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // player_2_score_txt
            // 
            this.player_2_score_txt.BackColor = System.Drawing.Color.Azure;
            this.player_2_score_txt.Font = new System.Drawing.Font("Segoe UI", 14.25F);
            this.player_2_score_txt.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.player_2_score_txt.Location = new System.Drawing.Point(27, 147);
            this.player_2_score_txt.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.player_2_score_txt.Name = "player_2_score_txt";
            this.player_2_score_txt.Size = new System.Drawing.Size(179, 33);
            this.player_2_score_txt.TabIndex = 15;
            this.player_2_score_txt.Text = "0";
            this.player_2_score_txt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // player_2_pairs_lbl
            // 
            this.player_2_pairs_lbl.AutoSize = true;
            this.player_2_pairs_lbl.Font = new System.Drawing.Font("Segoe UI", 15.75F);
            this.player_2_pairs_lbl.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.player_2_pairs_lbl.Location = new System.Drawing.Point(57, 114);
            this.player_2_pairs_lbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.player_2_pairs_lbl.Name = "player_2_pairs_lbl";
            this.player_2_pairs_lbl.Size = new System.Drawing.Size(120, 30);
            this.player_2_pairs_lbl.TabIndex = 14;
            this.player_2_pairs_lbl.Text = "Pairs Found";
            // 
            // player_1_turn_lbl
            // 
            this.player_1_turn_lbl.AutoSize = true;
            this.player_1_turn_lbl.Font = new System.Drawing.Font("Segoe UI Black", 21.75F, System.Drawing.FontStyle.Bold);
            this.player_1_turn_lbl.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.player_1_turn_lbl.Location = new System.Drawing.Point(31, 246);
            this.player_1_turn_lbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.player_1_turn_lbl.Name = "player_1_turn_lbl";
            this.player_1_turn_lbl.Size = new System.Drawing.Size(171, 40);
            this.player_1_turn_lbl.TabIndex = 14;
            this.player_1_turn_lbl.Text = "Your Turn!";
            this.player_1_turn_lbl.Visible = false;
            // 
            // player_2_turn_lbl
            // 
            this.player_2_turn_lbl.AutoSize = true;
            this.player_2_turn_lbl.Font = new System.Drawing.Font("Segoe UI Black", 21.75F, System.Drawing.FontStyle.Bold);
            this.player_2_turn_lbl.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.player_2_turn_lbl.Location = new System.Drawing.Point(31, 246);
            this.player_2_turn_lbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.player_2_turn_lbl.Name = "player_2_turn_lbl";
            this.player_2_turn_lbl.Size = new System.Drawing.Size(171, 40);
            this.player_2_turn_lbl.TabIndex = 15;
            this.player_2_turn_lbl.Text = "Your Turn!";
            this.player_2_turn_lbl.Visible = false;
            // 
            // show_picked_cards_timer
            // 
            this.show_picked_cards_timer.Interval = 10000;
            this.show_picked_cards_timer.Tick += new System.EventHandler(this.show_picked_cards_timer_Tick);
            // 
            // match_message_lbl
            // 
            this.match_message_lbl.AutoSize = true;
            this.match_message_lbl.BackColor = System.Drawing.Color.Transparent;
            this.match_message_lbl.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.match_message_lbl.Location = new System.Drawing.Point(574, 427);
            this.match_message_lbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.match_message_lbl.Name = "match_message_lbl";
            this.match_message_lbl.Size = new System.Drawing.Size(187, 65);
            this.match_message_lbl.TabIndex = 10;
            this.match_message_lbl.Text = "Match!";
            this.match_message_lbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.match_message_lbl.Visible = false;
            // 
            // label_fade_timer
            // 
            this.label_fade_timer.Interval = 10;
            this.label_fade_timer.Tick += new System.EventHandler(this.label_fade_timer_Tick);
            // 
            // Pairs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(1320, 918);
            this.Controls.Add(this.match_message_lbl);
            this.Controls.Add(this.main_menu_png);
            this.Controls.Add(this.main_menu_lbl);
            this.Controls.Add(this.player_1_pnl);
            this.Controls.Add(this.player_2_pnl);
            this.Controls.Add(this.menu_bar);
            this.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menu_bar;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "Pairs";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pairs";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menu_bar.ResumeLayout(false);
            this.menu_bar.PerformLayout();
            this.player_2_pnl.ResumeLayout(false);
            this.player_2_pnl.PerformLayout();
            this.player_2_cards_box.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.player_2_second_card_png)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.player_2_first_card_png)).EndInit();
            this.player_1_pnl.ResumeLayout(false);
            this.player_1_pnl.PerformLayout();
            this.player_1_cards_box.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.player_1_second_card_png)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.player_1_first_card_png)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.main_menu_png)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menu_bar;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem game_menu_btn;
        private System.Windows.Forms.ToolStripMenuItem new_game_menu_btn;
        private System.Windows.Forms.ToolStripSeparator sepToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem save_game_menu_btn;
        private System.Windows.Forms.ToolStripMenuItem retrieve_game_menu_btn;
        private System.Windows.Forms.ToolStripSeparator serpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exit_menu_btn;
        private System.Windows.Forms.ToolStripMenuItem sizeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem x6ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem x10ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem x16ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem abouToolStripMenuItem;
        private System.Windows.Forms.Timer show_cards_timer;
        private System.Windows.Forms.Panel player_2_pnl;
        private System.Windows.Forms.Panel player_1_pnl;
        private System.Windows.Forms.Label player_1_name_lbl;
        private System.Windows.Forms.TextBox player_2_name_txt;
        private System.Windows.Forms.Label player_2_name_lbl;
        private System.Windows.Forms.TextBox player_1_name_txt;
        private System.Windows.Forms.Label main_menu_lbl;
        private System.Windows.Forms.PictureBox main_menu_png;
        private System.Windows.Forms.GroupBox player_1_cards_box;
        private System.Windows.Forms.PictureBox player_1_second_card_png;
        private System.Windows.Forms.PictureBox player_1_first_card_png;
        private System.Windows.Forms.GroupBox player_2_cards_box;
        private System.Windows.Forms.PictureBox player_2_second_card_png;
        private System.Windows.Forms.PictureBox player_2_first_card_png;
        private System.Windows.Forms.TextBox player_2_score_txt;
        private System.Windows.Forms.Label player_2_pairs_lbl;
        private System.Windows.Forms.TextBox player_1_score_txt;
        private System.Windows.Forms.Label player_1_pairs_lbl;
        private System.Windows.Forms.Label player_1_turn_lbl;
        private System.Windows.Forms.Label player_2_turn_lbl;
        private System.Windows.Forms.Timer show_picked_cards_timer;
        private System.Windows.Forms.Label match_message_lbl;
        private System.Windows.Forms.Timer label_fade_timer;
    }
}

