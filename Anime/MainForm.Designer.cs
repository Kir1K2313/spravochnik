namespace Anime
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.filterbutton = new System.Windows.Forms.Button();
            this.pictureBox8 = new System.Windows.Forms.PictureBox();
            this.Selectbutton = new System.Windows.Forms.Button();
            this.AddcharcontextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.добавитьГерояToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.удалитьГерояToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpbutton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.UserLabel = new System.Windows.Forms.Label();
            this.Feedbackbutton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).BeginInit();
            this.AddcharcontextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(758, 150);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(221, 153);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(738, 428);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(221, 153);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(73, 46);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(202, 153);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 5;
            this.pictureBox3.TabStop = false;
            // 
            // filterbutton
            // 
            this.filterbutton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.filterbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.filterbutton.Location = new System.Drawing.Point(125, 296);
            this.filterbutton.Name = "filterbutton";
            this.filterbutton.Size = new System.Drawing.Size(164, 63);
            this.filterbutton.TabIndex = 8;
            this.filterbutton.Text = "Выберите персонажа";
            this.filterbutton.UseVisualStyleBackColor = false;
            this.filterbutton.Click += new System.EventHandler(this.filterbutton_Click);
            // 
            // pictureBox8
            // 
            this.pictureBox8.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox8.Image")));
            this.pictureBox8.Location = new System.Drawing.Point(166, 463);
            this.pictureBox8.Name = "pictureBox8";
            this.pictureBox8.Size = new System.Drawing.Size(193, 167);
            this.pictureBox8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox8.TabIndex = 16;
            this.pictureBox8.TabStop = false;
            // 
            // Selectbutton
            // 
            this.Selectbutton.BackColor = System.Drawing.Color.Black;
            this.Selectbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Selectbutton.ForeColor = System.Drawing.Color.Transparent;
            this.Selectbutton.Location = new System.Drawing.Point(129, 365);
            this.Selectbutton.Name = "Selectbutton";
            this.Selectbutton.Size = new System.Drawing.Size(146, 54);
            this.Selectbutton.TabIndex = 19;
            this.Selectbutton.Text = "Избранное";
            this.Selectbutton.UseVisualStyleBackColor = false;
            this.Selectbutton.Click += new System.EventHandler(this.Selectbutton_Click);
            // 
            // AddcharcontextMenuStrip1
            // 
            this.AddcharcontextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.AddcharcontextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.добавитьГерояToolStripMenuItem,
            this.удалитьГерояToolStripMenuItem});
            this.AddcharcontextMenuStrip1.Name = "contextMenuStrip1";
            this.AddcharcontextMenuStrip1.Size = new System.Drawing.Size(190, 52);
            // 
            // добавитьГерояToolStripMenuItem
            // 
            this.добавитьГерояToolStripMenuItem.Name = "добавитьГерояToolStripMenuItem";
            this.добавитьГерояToolStripMenuItem.Size = new System.Drawing.Size(189, 24);
            this.добавитьГерояToolStripMenuItem.Text = "Добавить героя";
            this.добавитьГерояToolStripMenuItem.Click += new System.EventHandler(this.добавитьГерояToolStripMenuItem_Click);
            // 
            // удалитьГерояToolStripMenuItem
            // 
            this.удалитьГерояToolStripMenuItem.Name = "удалитьГерояToolStripMenuItem";
            this.удалитьГерояToolStripMenuItem.Size = new System.Drawing.Size(189, 24);
            this.удалитьГерояToolStripMenuItem.Text = "Удалить героя";
            this.удалитьГерояToolStripMenuItem.Click += new System.EventHandler(this.удалитьГерояToolStripMenuItem_Click);
            // 
            // helpbutton
            // 
            this.helpbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.helpbutton.Location = new System.Drawing.Point(447, 396);
            this.helpbutton.Name = "helpbutton";
            this.helpbutton.Size = new System.Drawing.Size(160, 44);
            this.helpbutton.TabIndex = 20;
            this.helpbutton.Text = "Помощь";
            this.helpbutton.UseVisualStyleBackColor = true;
            this.helpbutton.Click += new System.EventHandler(this.helpbutton_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(868, 25);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(157, 53);
            this.button1.TabIndex = 21;
            this.button1.Text = "Войти";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // UserLabel
            // 
            this.UserLabel.AutoSize = true;
            this.UserLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.UserLabel.Location = new System.Drawing.Point(466, 9);
            this.UserLabel.Name = "UserLabel";
            this.UserLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.UserLabel.Size = new System.Drawing.Size(0, 25);
            this.UserLabel.TabIndex = 22;
            // 
            // Feedbackbutton
            // 
            this.Feedbackbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Feedbackbutton.Location = new System.Drawing.Point(865, 652);
            this.Feedbackbutton.Name = "Feedbackbutton";
            this.Feedbackbutton.Size = new System.Drawing.Size(160, 63);
            this.Feedbackbutton.TabIndex = 23;
            this.Feedbackbutton.Text = "техническая поддержка";
            this.Feedbackbutton.UseVisualStyleBackColor = true;
            this.Feedbackbutton.Click += new System.EventHandler(this.Feedbackbutton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1125, 793);
            this.ContextMenuStrip = this.AddcharcontextMenuStrip1;
            this.Controls.Add(this.Feedbackbutton);
            this.Controls.Add(this.UserLabel);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.helpbutton);
            this.Controls.Add(this.Selectbutton);
            this.Controls.Add(this.pictureBox8);
            this.Controls.Add(this.filterbutton);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.MainForm_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).EndInit();
            this.AddcharcontextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Button filterbutton;
        private System.Windows.Forms.PictureBox pictureBox8;
        private System.Windows.Forms.Button Selectbutton;
        private System.Windows.Forms.ContextMenuStrip AddcharcontextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem добавитьГерояToolStripMenuItem;
        private System.Windows.Forms.Button helpbutton;
        private System.Windows.Forms.ToolStripMenuItem удалитьГерояToolStripMenuItem;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label UserLabel;
        private System.Windows.Forms.Button Feedbackbutton;
    }
}

