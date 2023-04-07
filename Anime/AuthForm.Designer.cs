namespace Anime
{
    partial class AuthForm
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
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.LoginTB = new System.Windows.Forms.TextBox();
            this.PastTB = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.REGbutton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(0, 378);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(282, 82);
            this.button1.TabIndex = 0;
            this.button1.Text = "Войти";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(25, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(149, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Введите логин";
            // 
            // LoginTB
            // 
            this.LoginTB.Location = new System.Drawing.Point(30, 48);
            this.LoginTB.Name = "LoginTB";
            this.LoginTB.Size = new System.Drawing.Size(213, 22);
            this.LoginTB.TabIndex = 2;
            // 
            // PastTB
            // 
            this.PastTB.Location = new System.Drawing.Point(30, 142);
            this.PastTB.Name = "PastTB";
            this.PastTB.Size = new System.Drawing.Size(213, 22);
            this.PastTB.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(25, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(161, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "Введите пароль";
            // 
            // REGbutton
            // 
            this.REGbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.REGbutton.Location = new System.Drawing.Point(30, 313);
            this.REGbutton.Name = "REGbutton";
            this.REGbutton.Size = new System.Drawing.Size(229, 47);
            this.REGbutton.TabIndex = 5;
            this.REGbutton.Text = "Зарегистрироваться";
            this.REGbutton.UseVisualStyleBackColor = true;
            this.REGbutton.Click += new System.EventHandler(this.REGbutton_Click);
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(30, 230);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(229, 65);
            this.label3.TabIndex = 6;
            this.label3.Text = "Для авторизации зарегистрируйтесь";
            // 
            // AuthForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(282, 460);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.REGbutton);
            this.Controls.Add(this.PastTB);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.LoginTB);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Name = "AuthForm";
            this.Text = "AuthForm";
            this.Load += new System.EventHandler(this.AuthForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox LoginTB;
        private System.Windows.Forms.TextBox PastTB;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button REGbutton;
        private System.Windows.Forms.Label label3;
    }
}