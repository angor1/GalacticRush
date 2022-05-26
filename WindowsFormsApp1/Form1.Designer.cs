namespace WindowsFormsApp1
{
    partial class Form1
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
            this.mainPlayer = new System.Windows.Forms.PictureBox();
            this.LeftMoveT = new System.Windows.Forms.Timer(this.components);
            this.RightMoveT = new System.Windows.Forms.Timer(this.components);
            this.UpMoveT = new System.Windows.Forms.Timer(this.components);
            this.DownMoveT = new System.Windows.Forms.Timer(this.components);
            this.MoveBulletT = new System.Windows.Forms.Timer(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.labelLevel = new System.Windows.Forms.Label();
            this.labelScore = new System.Windows.Forms.Label();
            this.mainPlayer2 = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.mainPlayer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainPlayer2)).BeginInit();
            this.SuspendLayout();
            // 
            // mainPlayer
            // 
            this.mainPlayer.BackColor = System.Drawing.Color.Transparent;
            this.mainPlayer.Image = global::WindowsFormsApp1.Properties.Resources._667;
            this.mainPlayer.Location = new System.Drawing.Point(115, 456);
            this.mainPlayer.Name = "mainPlayer";
            this.mainPlayer.Size = new System.Drawing.Size(255, 62);
            this.mainPlayer.TabIndex = 0;
            this.mainPlayer.TabStop = false;
            // 
            // LeftMoveT
            // 
            this.LeftMoveT.Interval = 10;
            this.LeftMoveT.Tick += new System.EventHandler(this.LeftMoveT_Tick);
            // 
            // RightMoveT
            // 
            this.RightMoveT.Interval = 10;
            this.RightMoveT.Tick += new System.EventHandler(this.RightMoveT_Tick);
            // 
            // UpMoveT
            // 
            this.UpMoveT.Interval = 10;
            this.UpMoveT.Tick += new System.EventHandler(this.UpMoveT_Tick);
            // 
            // DownMoveT
            // 
            this.DownMoveT.Interval = 10;
            this.DownMoveT.Tick += new System.EventHandler(this.DownMoveT_Tick);
            // 
            // MoveBulletT
            // 
            this.MoveBulletT.Enabled = true;
            this.MoveBulletT.Interval = 10;
            this.MoveBulletT.Tick += new System.EventHandler(this.MoveBulletT_Tick);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 10;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick_2);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Britannic Bold", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkRed;
            this.label1.Location = new System.Drawing.Point(453, 238);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(385, 133);
            this.label1.TabIndex = 1;
            this.label1.Text = "label1";
            this.label1.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Britannic Bold", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(797, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(139, 52);
            this.label2.TabIndex = 2;
            this.label2.Text = "Level:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Britannic Bold", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(1006, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(152, 52);
            this.label3.TabIndex = 3;
            this.label3.Text = "Score:";
            // 
            // labelLevel
            // 
            this.labelLevel.AutoSize = true;
            this.labelLevel.BackColor = System.Drawing.Color.Transparent;
            this.labelLevel.Font = new System.Drawing.Font("Britannic Bold", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLevel.ForeColor = System.Drawing.Color.White;
            this.labelLevel.Location = new System.Drawing.Point(920, 9);
            this.labelLevel.Name = "labelLevel";
            this.labelLevel.Size = new System.Drawing.Size(80, 52);
            this.labelLevel.TabIndex = 4;
            this.labelLevel.Text = "01";
            // 
            // labelScore
            // 
            this.labelScore.AutoSize = true;
            this.labelScore.BackColor = System.Drawing.Color.Transparent;
            this.labelScore.Font = new System.Drawing.Font("Britannic Bold", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelScore.ForeColor = System.Drawing.Color.White;
            this.labelScore.Location = new System.Drawing.Point(1144, 9);
            this.labelScore.Name = "labelScore";
            this.labelScore.Size = new System.Drawing.Size(80, 52);
            this.labelScore.TabIndex = 5;
            this.labelScore.Text = "00";
            // 
            // mainPlayer2
            // 
            this.mainPlayer2.BackColor = System.Drawing.Color.Transparent;
            this.mainPlayer2.Location = new System.Drawing.Point(12, 12);
            this.mainPlayer2.Name = "mainPlayer2";
            this.mainPlayer2.Size = new System.Drawing.Size(10, 652);
            this.mainPlayer2.TabIndex = 6;
            this.mainPlayer2.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(28, 12);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(524, 32);
            this.label4.TabIndex = 7;
            this.label4.Text = "Esc - для того чтобы вернуться в меню";
            this.label4.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WindowsFormsApp1.Properties.Resources._5;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1262, 673);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.mainPlayer2);
            this.Controls.Add(this.labelScore);
            this.Controls.Add(this.labelLevel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.mainPlayer);
            this.DoubleBuffered = true;
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            ((System.ComponentModel.ISupportInitialize)(this.mainPlayer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainPlayer2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox mainPlayer;
        private System.Windows.Forms.Timer LeftMoveT;
        private System.Windows.Forms.Timer RightMoveT;
        private System.Windows.Forms.Timer UpMoveT;
        private System.Windows.Forms.Timer DownMoveT;
        private System.Windows.Forms.Timer MoveBulletT;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labelLevel;
        private System.Windows.Forms.Label labelScore;
        private System.Windows.Forms.PictureBox mainPlayer2;
        private System.Windows.Forms.Label label4;
    }
}

