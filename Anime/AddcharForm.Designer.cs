namespace Anime
{
    partial class AddcharForm
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
            this.Namelabel = new System.Windows.Forms.Label();
            this.rasalabel = new System.Windows.Forms.Label();
            this.statuslabel = new System.Windows.Forms.Label();
            this.fraklabel = new System.Windows.Forms.Label();
            this.NameTB = new System.Windows.Forms.TextBox();
            this.statusTB = new System.Windows.Forms.TextBox();
            this.frakTB = new System.Windows.Forms.TextBox();
            this.Savebutton = new System.Windows.Forms.Button();
            this.rasaCB = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // Namelabel
            // 
            this.Namelabel.AutoSize = true;
            this.Namelabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Namelabel.Location = new System.Drawing.Point(12, 40);
            this.Namelabel.Name = "Namelabel";
            this.Namelabel.Size = new System.Drawing.Size(206, 25);
            this.Namelabel.TabIndex = 0;
            this.Namelabel.Text = "Название персонажа";
            // 
            // rasalabel
            // 
            this.rasalabel.AutoSize = true;
            this.rasalabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rasalabel.Location = new System.Drawing.Point(79, 77);
            this.rasalabel.Name = "rasalabel";
            this.rasalabel.Size = new System.Drawing.Size(54, 25);
            this.rasalabel.TabIndex = 1;
            this.rasalabel.Text = "Раса";
            // 
            // statuslabel
            // 
            this.statuslabel.AutoSize = true;
            this.statuslabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.statuslabel.Location = new System.Drawing.Point(65, 107);
            this.statuslabel.Name = "statuslabel";
            this.statuslabel.Size = new System.Drawing.Size(78, 25);
            this.statuslabel.TabIndex = 2;
            this.statuslabel.Text = "Статус";
            this.statuslabel.Click += new System.EventHandler(this.statuslabel_Click);
            // 
            // fraklabel
            // 
            this.fraklabel.AutoSize = true;
            this.fraklabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.fraklabel.Location = new System.Drawing.Point(65, 143);
            this.fraklabel.Name = "fraklabel";
            this.fraklabel.Size = new System.Drawing.Size(96, 25);
            this.fraklabel.TabIndex = 3;
            this.fraklabel.Text = "Фракция";
            // 
            // NameTB
            // 
            this.NameTB.Location = new System.Drawing.Point(247, 40);
            this.NameTB.Name = "NameTB";
            this.NameTB.Size = new System.Drawing.Size(232, 22);
            this.NameTB.TabIndex = 4;
            this.NameTB.TextChanged += new System.EventHandler(this.NameTB_TextChanged);
            // 
            // statusTB
            // 
            this.statusTB.Location = new System.Drawing.Point(182, 110);
            this.statusTB.Name = "statusTB";
            this.statusTB.Size = new System.Drawing.Size(232, 22);
            this.statusTB.TabIndex = 6;
            // 
            // frakTB
            // 
            this.frakTB.Location = new System.Drawing.Point(182, 143);
            this.frakTB.Name = "frakTB";
            this.frakTB.Size = new System.Drawing.Size(232, 22);
            this.frakTB.TabIndex = 7;
            // 
            // Savebutton
            // 
            this.Savebutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Savebutton.Location = new System.Drawing.Point(238, 377);
            this.Savebutton.Name = "Savebutton";
            this.Savebutton.Size = new System.Drawing.Size(232, 47);
            this.Savebutton.TabIndex = 8;
            this.Savebutton.Text = "Сохранить";
            this.Savebutton.UseVisualStyleBackColor = true;
            this.Savebutton.Click += new System.EventHandler(this.Savebutton_Click);
            // 
            // rasaCB
            // 
            this.rasaCB.FormattingEnabled = true;
            this.rasaCB.Items.AddRange(new object[] {
            "Шинигами",
            "Квинси",
            "Арранкар",
            "Душа",
            "Человек"});
            this.rasaCB.Location = new System.Drawing.Point(182, 81);
            this.rasaCB.Name = "rasaCB";
            this.rasaCB.Size = new System.Drawing.Size(232, 24);
            this.rasaCB.TabIndex = 9;
            // 
            // AddcharForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.rasaCB);
            this.Controls.Add(this.Savebutton);
            this.Controls.Add(this.frakTB);
            this.Controls.Add(this.statusTB);
            this.Controls.Add(this.NameTB);
            this.Controls.Add(this.fraklabel);
            this.Controls.Add(this.statuslabel);
            this.Controls.Add(this.rasalabel);
            this.Controls.Add(this.Namelabel);
            this.Name = "AddcharForm";
            this.Text = "AddcharForm";
            this.Load += new System.EventHandler(this.AddcharForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Namelabel;
        private System.Windows.Forms.Label rasalabel;
        private System.Windows.Forms.Label statuslabel;
        private System.Windows.Forms.Label fraklabel;
        private System.Windows.Forms.TextBox NameTB;
        private System.Windows.Forms.TextBox statusTB;
        private System.Windows.Forms.TextBox frakTB;
        private System.Windows.Forms.Button Savebutton;
        private System.Windows.Forms.ComboBox rasaCB;
    }
}