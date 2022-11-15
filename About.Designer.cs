namespace pain
{
    partial class About
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(About));
            this.pears_png = new System.Windows.Forms.PictureBox();
            this.player_1_name_lbl = new System.Windows.Forms.Label();
            this.description_txt = new System.Windows.Forms.RichTextBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pears_png)).BeginInit();
            this.SuspendLayout();
            // 
            // pears_png
            // 
            this.pears_png.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pears_png.Location = new System.Drawing.Point(39, 39);
            this.pears_png.Name = "pears_png";
            this.pears_png.Size = new System.Drawing.Size(285, 218);
            this.pears_png.TabIndex = 0;
            this.pears_png.TabStop = false;
            // 
            // player_1_name_lbl
            // 
            this.player_1_name_lbl.AutoSize = true;
            this.player_1_name_lbl.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.player_1_name_lbl.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.player_1_name_lbl.Location = new System.Drawing.Point(331, 39);
            this.player_1_name_lbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.player_1_name_lbl.Name = "player_1_name_lbl";
            this.player_1_name_lbl.Size = new System.Drawing.Size(106, 30);
            this.player_1_name_lbl.TabIndex = 9;
            this.player_1_name_lbl.Text = "Pairs v1.0";
            // 
            // description_txt
            // 
            this.description_txt.BackColor = System.Drawing.Color.LightCyan;
            this.description_txt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.description_txt.Cursor = System.Windows.Forms.Cursors.Default;
            this.description_txt.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.description_txt.Location = new System.Drawing.Point(330, 72);
            this.description_txt.Name = "description_txt";
            this.description_txt.ReadOnly = true;
            this.description_txt.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.ForcedVertical;
            this.description_txt.Size = new System.Drawing.Size(255, 185);
            this.description_txt.TabIndex = 10;
            this.description_txt.Text = resources.GetString("description_txt.Text");
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.LightBlue;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(233, 276);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(161, 34);
            this.button1.TabIndex = 11;
            this.button1.Text = "OK";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // About
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCyan;
            this.ClientSize = new System.Drawing.Size(627, 321);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.description_txt);
            this.Controls.Add(this.player_1_name_lbl);
            this.Controls.Add(this.pears_png);
            this.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "About";
            this.Text = "About";
            ((System.ComponentModel.ISupportInitialize)(this.pears_png)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pears_png;
        private System.Windows.Forms.Label player_1_name_lbl;
        private System.Windows.Forms.RichTextBox description_txt;
        private System.Windows.Forms.Button button1;
    }
}