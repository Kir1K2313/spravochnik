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
            this.Savebutton = new System.Windows.Forms.Button();
            this.rasaCB = new System.Windows.Forms.ComboBox();
            this.statusCB = new System.Windows.Forms.ComboBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.frakCB = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Namelabel
            // 
            this.Namelabel.AutoSize = true;
            this.Namelabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Namelabel.Location = new System.Drawing.Point(58, 95);
            this.Namelabel.Name = "Namelabel";
            this.Namelabel.Size = new System.Drawing.Size(99, 25);
            this.Namelabel.TabIndex = 0;
            this.Namelabel.Text = "Название";
            // 
            // rasalabel
            // 
            this.rasalabel.AutoSize = true;
            this.rasalabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rasalabel.Location = new System.Drawing.Point(84, 129);
            this.rasalabel.Name = "rasalabel";
            this.rasalabel.Size = new System.Drawing.Size(54, 25);
            this.rasalabel.TabIndex = 1;
            this.rasalabel.Text = "Раса";
            // 
            // statuslabel
            // 
            this.statuslabel.AutoSize = true;
            this.statuslabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.statuslabel.Location = new System.Drawing.Point(79, 170);
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
            this.fraklabel.Location = new System.Drawing.Point(61, 223);
            this.fraklabel.Name = "fraklabel";
            this.fraklabel.Size = new System.Drawing.Size(96, 25);
            this.fraklabel.TabIndex = 3;
            this.fraklabel.Text = "Фракция";
            // 
            // NameTB
            // 
            this.NameTB.Location = new System.Drawing.Point(187, 99);
            this.NameTB.Name = "NameTB";
            this.NameTB.Size = new System.Drawing.Size(232, 22);
            this.NameTB.TabIndex = 4;
            this.NameTB.TextChanged += new System.EventHandler(this.NameTB_TextChanged);
            // 
            // Savebutton
            // 
            this.Savebutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Savebutton.Location = new System.Drawing.Point(103, 391);
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
            this.rasaCB.Location = new System.Drawing.Point(187, 133);
            this.rasaCB.Name = "rasaCB";
            this.rasaCB.Size = new System.Drawing.Size(232, 24);
            this.rasaCB.TabIndex = 9;
            this.rasaCB.SelectedIndexChanged += new System.EventHandler(this.rasaCB_SelectedIndexChanged);
            // 
            // statusCB
            // 
            this.statusCB.FormattingEnabled = true;
            this.statusCB.Items.AddRange(new object[] {
            "Живой ",
            "Мертвый",
            "Неизвестно"});
            this.statusCB.Location = new System.Drawing.Point(187, 174);
            this.statusCB.Name = "statusCB";
            this.statusCB.Size = new System.Drawing.Size(232, 24);
            this.statusCB.TabIndex = 10;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(443, 27);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(330, 396);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(128, 305);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(149, 68);
            this.button1.TabIndex = 12;
            this.button1.Text = "Выберите картинку";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // frakCB
            // 
            this.frakCB.FormattingEnabled = true;
            this.frakCB.Items.AddRange(new object[] {
            "Общество душ",
            "Уэко Мундо",
            "Мир людей",
            "Он сам",
            "Готей 13"});
            this.frakCB.Location = new System.Drawing.Point(187, 227);
            this.frakCB.Name = "frakCB";
            this.frakCB.Size = new System.Drawing.Size(232, 24);
            this.frakCB.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(43, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(234, 25);
            this.label1.TabIndex = 14;
            this.label1.Text = "Добавление персонажа";
            // 
            // AddcharForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.frakCB);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.statusCB);
            this.Controls.Add(this.rasaCB);
            this.Controls.Add(this.Savebutton);
            this.Controls.Add(this.NameTB);
            this.Controls.Add(this.fraklabel);
            this.Controls.Add(this.statuslabel);
            this.Controls.Add(this.rasalabel);
            this.Controls.Add(this.Namelabel);
            this.Name = "AddcharForm";
            this.Text = "AddcharForm";
            this.Load += new System.EventHandler(this.AddcharForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Namelabel;
        private System.Windows.Forms.Label rasalabel;
        private System.Windows.Forms.Label statuslabel;
        private System.Windows.Forms.Label fraklabel;
        private System.Windows.Forms.TextBox NameTB;
        private System.Windows.Forms.Button Savebutton;
        private System.Windows.Forms.ComboBox rasaCB;
        private System.Windows.Forms.ComboBox statusCB;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.ComboBox frakCB;
        private System.Windows.Forms.Label label1;
    }
}