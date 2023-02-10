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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.rasaCombobox = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.NameCombobox = new System.Windows.Forms.ComboBox();
            this.statusComboBox = new System.Windows.Forms.ComboBox();
            this.mirComboBox = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // Findbutton
            // 
            this.Findbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Findbutton.Location = new System.Drawing.Point(862, 31);
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
            this.Раса.Location = new System.Drawing.Point(38, 65);
            this.Раса.Name = "Раса";
            this.Раса.Size = new System.Drawing.Size(39, 16);
            this.Раса.TabIndex = 11;
            this.Раса.Text = "Раса";
            this.Раса.Click += new System.EventHandler(this.label1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 16);
            this.label1.TabIndex = 12;
            this.label1.Text = "label1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(36, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 16);
            this.label2.TabIndex = 13;
            this.label2.Text = "Статус";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(36, 143);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 16);
            this.label3.TabIndex = 14;
            this.label3.Text = "Мир";
            // 
            // rasaCombobox
            // 
            this.rasaCombobox.FormattingEnabled = true;
            this.rasaCombobox.Items.AddRange(new object[] {
            "Шинигами",
            "Человек",
            "Душа"});
            this.rasaCombobox.Location = new System.Drawing.Point(90, 62);
            this.rasaCombobox.Name = "rasaCombobox";
            this.rasaCombobox.Size = new System.Drawing.Size(124, 24);
            this.rasaCombobox.TabIndex = 15;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(38, 31);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 16);
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
            this.NameCombobox.Location = new System.Drawing.Point(90, 31);
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
            this.statusComboBox.Location = new System.Drawing.Point(95, 101);
            this.statusComboBox.Name = "statusComboBox";
            this.statusComboBox.Size = new System.Drawing.Size(121, 24);
            this.statusComboBox.TabIndex = 18;
            // 
            // mirComboBox
            // 
            this.mirComboBox.FormattingEnabled = true;
            this.mirComboBox.Items.AddRange(new object[] {
            "Мир людей",
            "Общество душ"});
            this.mirComboBox.Location = new System.Drawing.Point(94, 143);
            this.mirComboBox.Name = "mirComboBox";
            this.mirComboBox.Size = new System.Drawing.Size(120, 24);
            this.mirComboBox.TabIndex = 19;
            // 
            // filterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1070, 563);
            this.Controls.Add(this.mirComboBox);
            this.Controls.Add(this.statusComboBox);
            this.Controls.Add(this.NameCombobox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.rasaCombobox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Раса);
            this.Controls.Add(this.Findbutton);
            this.Name = "filterForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.filterForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button Findbutton;
        private System.Windows.Forms.Label Раса;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox rasaCombobox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox NameCombobox;
        private System.Windows.Forms.ComboBox statusComboBox;
        private System.Windows.Forms.ComboBox mirComboBox;
    }
}