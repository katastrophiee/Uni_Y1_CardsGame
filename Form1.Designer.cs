namespace pain
{
    partial class Form1
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
            this.btn_start = new System.Windows.Forms.Button();
            this.txtB_Row = new System.Windows.Forms.TextBox();
            this.txtB_Col = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_start
            // 
            this.btn_start.BackColor = System.Drawing.Color.AliceBlue;
            this.btn_start.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_start.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_start.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.btn_start.Location = new System.Drawing.Point(434, 690);
            this.btn_start.Name = "btn_start";
            this.btn_start.Size = new System.Drawing.Size(194, 44);
            this.btn_start.TabIndex = 0;
            this.btn_start.Text = "Start!";
            this.btn_start.UseVisualStyleBackColor = false;
            this.btn_start.Click += new System.EventHandler(this.btn_start_Click);
            // 
            // txtB_Row
            // 
            this.txtB_Row.Location = new System.Drawing.Point(634, 714);
            this.txtB_Row.Name = "txtB_Row";
            this.txtB_Row.Size = new System.Drawing.Size(70, 20);
            this.txtB_Row.TabIndex = 1;
            // 
            // txtB_Col
            // 
            this.txtB_Col.Location = new System.Drawing.Point(710, 714);
            this.txtB_Col.Name = "txtB_Col";
            this.txtB_Col.Size = new System.Drawing.Size(70, 20);
            this.txtB_Col.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(635, 698);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Row";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(1063, 738);
            this.Controls.Add(this.btn_start);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtB_Col);
            this.Controls.Add(this.txtB_Row);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_start;
        private System.Windows.Forms.TextBox txtB_Row;
        private System.Windows.Forms.TextBox txtB_Col;
        private System.Windows.Forms.Label label2;
    }
}

