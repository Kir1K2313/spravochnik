namespace Anime
{
    partial class filterForm
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
            this.Findbutton = new System.Windows.Forms.Button();
            this.Раса = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.rasaCombobox = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.NameCombobox = new System.Windows.Forms.ComboBox();
            this.statusComboBox = new System.Windows.Forms.ComboBox();
            this.mirComboBox = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.namecheckedListBox = new System.Windows.Forms.CheckedListBox();
            this.filterpanel = new System.Windows.Forms.Panel();
            this.Hidebutton = new System.Windows.Forms.Button();
            this.charpanel = new System.Windows.Forms.Panel();
            this.filterpanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // Findbutton
            // 
            this.Findbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Findbutton.Location = new System.Drawing.Point(861, 26);
            this.Findbutton.Name = "Findbutton";
            this.Findbutton.Size = new System.Drawing.Size(133, 55);
            this.Findbutton.TabIndex = 10;
            this.Findbutton.Text = "Показать";
            this.Findbutton.UseVisualStyleBackColor = true;
            this.Findbutton.Click += new System.EventHandler(this.Findbutton_Click);
            // 
            // Раса
            // 
            this.Раса.AutoSize = true;
            this.Раса.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Раса.Location = new System.Drawing.Point(12, 99);
            this.Раса.Name = "Раса";
            this.Раса.Size = new System.Drawing.Size(54, 25);
            this.Раса.TabIndex = 11;
            this.Раса.Text = "Раса";
            this.Раса.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(3, 130);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 25);
            this.label2.TabIndex = 13;
            this.label2.Text = "Статус";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(-5, 155);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 25);
            this.label3.TabIndex = 14;
            this.label3.Text = "Фракция";
            // 
            // rasaCombobox
            // 
            this.rasaCombobox.FormattingEnabled = true;
            this.rasaCombobox.Items.AddRange(new object[] {
            "Шинигами",
            "Человек",
            "Душа",
            "Квинси",
            "Арранкар"});
            this.rasaCombobox.Location = new System.Drawing.Point(104, 99);
            this.rasaCombobox.Name = "rasaCombobox";
            this.rasaCombobox.Size = new System.Drawing.Size(124, 24);
            this.rasaCombobox.TabIndex = 15;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(12, 67);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 25);
            this.label4.TabIndex = 16;
            this.label4.Text = "Имя";
            // 
            // NameCombobox
            // 
            this.NameCombobox.FormattingEnabled = true;
            this.NameCombobox.Items.AddRange(new object[] {
            "Ичиго Куросаки",
            "Киске Урахара",
            "Рукия Кучики"});
            this.NameCombobox.Location = new System.Drawing.Point(720, 96);
            this.NameCombobox.Name = "NameCombobox";
            this.NameCombobox.Size = new System.Drawing.Size(124, 24);
            this.NameCombobox.TabIndex = 17;
            // 
            // statusComboBox
            // 
            this.statusComboBox.FormattingEnabled = true;
            this.statusComboBox.Items.AddRange(new object[] {
            "Живой ",
            "Неизвестно",
            "Мертвый"});
            this.statusComboBox.Location = new System.Drawing.Point(104, 129);
            this.statusComboBox.Name = "statusComboBox";
            this.statusComboBox.Size = new System.Drawing.Size(121, 24);
            this.statusComboBox.TabIndex = 18;
            // 
            // mirComboBox
            // 
            this.mirComboBox.FormattingEnabled = true;
            this.mirComboBox.Items.AddRange(new object[] {
            "Мир людей",
            "Общество душ",
            "Уэко Мундо",
            "Готей 13"});
            this.mirComboBox.Location = new System.Drawing.Point(105, 156);
            this.mirComboBox.Name = "mirComboBox";
            this.mirComboBox.Size = new System.Drawing.Size(120, 24);
            this.mirComboBox.TabIndex = 19;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(340, 34);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(33, 16);
            this.label5.TabIndex = 20;
            this.label5.Text = "Имя";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(105, 71);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(124, 22);
            this.textBox1.TabIndex = 21;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // namecheckedListBox
            // 
            this.namecheckedListBox.FormattingEnabled = true;
            this.namecheckedListBox.Items.AddRange(new object[] {
            "Ичиго Куросаки",
            "Киске Урахара",
            "Рукия Кучики",
            "Айзен Сосуке",
            "Улькиорра Сифер",
            "Унохана Рецу",
            "Хирако Шинджи",
            "Ямамото Генрюсай",
            "Урю Исида"});
            this.namecheckedListBox.Location = new System.Drawing.Point(392, 34);
            this.namecheckedListBox.Name = "namecheckedListBox";
            this.namecheckedListBox.Size = new System.Drawing.Size(150, 89);
            this.namecheckedListBox.TabIndex = 22;
            this.namecheckedListBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.namecheckedListBox_KeyDown);
            // 
            // filterpanel
            // 
            this.filterpanel.Controls.Add(this.Hidebutton);
            this.filterpanel.Controls.Add(this.label4);
            this.filterpanel.Controls.Add(this.namecheckedListBox);
            this.filterpanel.Controls.Add(this.Findbutton);
            this.filterpanel.Controls.Add(this.textBox1);
            this.filterpanel.Controls.Add(this.Раса);
            this.filterpanel.Controls.Add(this.label5);
            this.filterpanel.Controls.Add(this.label2);
            this.filterpanel.Controls.Add(this.mirComboBox);
            this.filterpanel.Controls.Add(this.label3);
            this.filterpanel.Controls.Add(this.statusComboBox);
            this.filterpanel.Controls.Add(this.rasaCombobox);
            this.filterpanel.Controls.Add(this.NameCombobox);
            this.filterpanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.filterpanel.Location = new System.Drawing.Point(0, 0);
            this.filterpanel.Name = "filterpanel";
            this.filterpanel.Size = new System.Drawing.Size(1070, 183);
            this.filterpanel.TabIndex = 23;
            this.filterpanel.Paint += new System.Windows.Forms.PaintEventHandler(this.filterpanel_Paint);
            // 
            // Hidebutton
            // 
            this.Hidebutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Hidebutton.Location = new System.Drawing.Point(17, 7);
            this.Hidebutton.Name = "Hidebutton";
            this.Hidebutton.Size = new System.Drawing.Size(169, 32);
            this.Hidebutton.TabIndex = 23;
            this.Hidebutton.Text = "Скрыть панель";
            this.Hidebutton.UseVisualStyleBackColor = true;
            this.Hidebutton.Click += new System.EventHandler(this.Hidebutton_Click);
            // 
            // charpanel
            // 
            this.charpanel.AutoScroll = true;
            this.charpanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.charpanel.Location = new System.Drawing.Point(0, 183);
            this.charpanel.Name = "charpanel";
            this.charpanel.Size = new System.Drawing.Size(1070, 380);
            this.charpanel.TabIndex = 23;
            this.charpanel.Paint += new System.Windows.Forms.PaintEventHandler(this.charpanel_Paint);
            this.charpanel.Resize += new System.EventHandler(this.charpanel_Resize);
            // 
            // filterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1070, 563);
            this.Controls.Add(this.charpanel);
            this.Controls.Add(this.filterpanel);
            this.Name = "filterForm";
            this.Text = "фильтр";
            this.Load += new System.EventHandler(this.filterForm_Load);
            this.filterpanel.ResumeLayout(false);
            this.filterpanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button Findbutton;
        private System.Windows.Forms.Label Раса;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox rasaCombobox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox NameCombobox;
        private System.Windows.Forms.ComboBox statusComboBox;
        private System.Windows.Forms.ComboBox mirComboBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.CheckedListBox namecheckedListBox;
        private System.Windows.Forms.Panel filterpanel;
        private System.Windows.Forms.Panel charpanel;
        private System.Windows.Forms.Button Hidebutton;
    }
}