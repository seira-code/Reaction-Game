
namespace TIMER
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
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.mmss = new System.Windows.Forms.Label();
            this.point = new System.Windows.Forms.Label();
            this.Points = new System.Windows.Forms.Label();
            this.points1 = new System.Windows.Forms.Label();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.hard = new System.Windows.Forms.RadioButton();
            this.medium = new System.Windows.Forms.RadioButton();
            this.easy = new System.Windows.Forms.RadioButton();
            this.nickname = new System.Windows.Forms.TextBox();
            this.nicknametext = new System.Windows.Forms.Label();
            this.leaderbord = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(281, 356);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Start";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // mmss
            // 
            this.mmss.AutoSize = true;
            this.mmss.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mmss.Location = new System.Drawing.Point(276, 288);
            this.mmss.Name = "mmss";
            this.mmss.Size = new System.Drawing.Size(84, 25);
            this.mmss.TabIndex = 1;
            this.mmss.Text = "label1";
            // 
            // point
            // 
            this.point.AutoSize = true;
            this.point.BackColor = System.Drawing.Color.Transparent;
            this.point.Font = new System.Drawing.Font("Verdana", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.point.Location = new System.Drawing.Point(598, 174);
            this.point.Name = "point";
            this.point.Size = new System.Drawing.Size(85, 116);
            this.point.TabIndex = 1;
            this.point.Text = ".";
            this.point.Click += new System.EventHandler(this.point_Click);
            // 
            // Points
            // 
            this.Points.AutoSize = true;
            this.Points.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Points.Location = new System.Drawing.Point(527, 9);
            this.Points.Name = "Points";
            this.Points.Size = new System.Drawing.Size(93, 25);
            this.Points.TabIndex = 1;
            this.Points.Text = "Points:";
            // 
            // points1
            // 
            this.points1.AutoSize = true;
            this.points1.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.points1.Location = new System.Drawing.Point(620, 9);
            this.points1.Name = "points1";
            this.points1.Size = new System.Drawing.Size(0, 25);
            this.points1.TabIndex = 1;
            // 
            // timer2
            // 
            this.timer2.Enabled = true;
            this.timer2.Interval = 600;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // hard
            // 
            this.hard.AutoSize = true;
            this.hard.ForeColor = System.Drawing.SystemColors.ControlText;
            this.hard.Location = new System.Drawing.Point(421, 313);
            this.hard.Name = "hard";
            this.hard.Size = new System.Drawing.Size(64, 17);
            this.hard.TabIndex = 2;
            this.hard.TabStop = true;
            this.hard.Text = "Сложно";
            this.hard.UseVisualStyleBackColor = true;
            this.hard.CheckedChanged += new System.EventHandler(this.hard_CheckedChanged);
            // 
            // medium
            // 
            this.medium.AutoSize = true;
            this.medium.Location = new System.Drawing.Point(421, 336);
            this.medium.Name = "medium";
            this.medium.Size = new System.Drawing.Size(62, 17);
            this.medium.TabIndex = 2;
            this.medium.TabStop = true;
            this.medium.Text = "Средне";
            this.medium.UseVisualStyleBackColor = true;
            this.medium.CheckedChanged += new System.EventHandler(this.medium_CheckedChanged);
            // 
            // easy
            // 
            this.easy.AutoSize = true;
            this.easy.Location = new System.Drawing.Point(421, 359);
            this.easy.Name = "easy";
            this.easy.Size = new System.Drawing.Size(56, 17);
            this.easy.TabIndex = 2;
            this.easy.TabStop = true;
            this.easy.Text = "Легко";
            this.easy.UseVisualStyleBackColor = true;
            this.easy.CheckedChanged += new System.EventHandler(this.easy_CheckedChanged);
            // 
            // nickname
            // 
            this.nickname.Location = new System.Drawing.Point(68, 350);
            this.nickname.MaxLength = 8;
            this.nickname.Name = "nickname";
            this.nickname.Size = new System.Drawing.Size(117, 20);
            this.nickname.TabIndex = 3;
            this.nickname.TabStop = false;
            this.nickname.Text = "Ник";
            // 
            // nicknametext
            // 
            this.nicknametext.AutoSize = true;
            this.nicknametext.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nicknametext.Location = new System.Drawing.Point(86, 325);
            this.nicknametext.Name = "nicknametext";
            this.nicknametext.Size = new System.Drawing.Size(79, 18);
            this.nicknametext.TabIndex = 1;
            this.nicknametext.Text = "Ваш Ник";
            // 
            // leaderbord
            // 
            this.leaderbord.AutoSize = true;
            this.leaderbord.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.leaderbord.Location = new System.Drawing.Point(502, 336);
            this.leaderbord.Name = "leaderbord";
            this.leaderbord.Size = new System.Drawing.Size(154, 18);
            this.leaderbord.TabIndex = 1;
            this.leaderbord.Text = "Таблица лидеров";
            this.leaderbord.Click += new System.EventHandler(this.leaderbord_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(668, 389);
            this.Controls.Add(this.nickname);
            this.Controls.Add(this.easy);
            this.Controls.Add(this.medium);
            this.Controls.Add(this.hard);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.points1);
            this.Controls.Add(this.Points);
            this.Controls.Add(this.leaderbord);
            this.Controls.Add(this.nicknametext);
            this.Controls.Add(this.mmss);
            this.Controls.Add(this.point);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label mmss;
        private System.Windows.Forms.Label point;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.RadioButton hard;
        private System.Windows.Forms.RadioButton medium;
        private System.Windows.Forms.RadioButton easy;
        private System.Windows.Forms.TextBox nickname;
        private System.Windows.Forms.Label nicknametext;
        private System.Windows.Forms.Label leaderbord;
        public System.Windows.Forms.Label Points;
        public System.Windows.Forms.Label points1;
    }
}

