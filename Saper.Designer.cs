
namespace saper
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
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.новаяИграToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.уровеньСложностиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.легкийToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.среднийToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сложныйToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.справкаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выходToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel = new System.Windows.Forms.Panel();
            this.richTextBox_for_scores = new System.Windows.Forms.RichTextBox();
            this.menuStrip.SuspendLayout();
            this.panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.новаяИграToolStripMenuItem,
            this.уровеньСложностиToolStripMenuItem,
            this.справкаToolStripMenuItem,
            this.выходToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(783, 30);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "menuStrip1";
            // 
            // новаяИграToolStripMenuItem
            // 
            this.новаяИграToolStripMenuItem.Name = "новаяИграToolStripMenuItem";
            this.новаяИграToolStripMenuItem.Size = new System.Drawing.Size(103, 26);
            this.новаяИграToolStripMenuItem.Text = "Новая игра";
            this.новаяИграToolStripMenuItem.Click += new System.EventHandler(this.новаяИграToolStripMenuItem_Click);
            // 
            // уровеньСложностиToolStripMenuItem
            // 
            this.уровеньСложностиToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.легкийToolStripMenuItem,
            this.среднийToolStripMenuItem,
            this.сложныйToolStripMenuItem});
            this.уровеньСложностиToolStripMenuItem.Name = "уровеньСложностиToolStripMenuItem";
            this.уровеньСложностиToolStripMenuItem.Size = new System.Drawing.Size(162, 26);
            this.уровеньСложностиToolStripMenuItem.Text = "Уровень сложности";
            // 
            // легкийToolStripMenuItem
            // 
            this.легкийToolStripMenuItem.Name = "легкийToolStripMenuItem";
            this.легкийToolStripMenuItem.Size = new System.Drawing.Size(158, 26);
            this.легкийToolStripMenuItem.Text = "Легкий";
            this.легкийToolStripMenuItem.Click += new System.EventHandler(this.легкийToolStripMenuItem_Click);
            // 
            // среднийToolStripMenuItem
            // 
            this.среднийToolStripMenuItem.Name = "среднийToolStripMenuItem";
            this.среднийToolStripMenuItem.Size = new System.Drawing.Size(158, 26);
            this.среднийToolStripMenuItem.Text = "Средний";
            this.среднийToolStripMenuItem.Click += new System.EventHandler(this.среднийToolStripMenuItem_Click);
            // 
            // сложныйToolStripMenuItem
            // 
            this.сложныйToolStripMenuItem.Name = "сложныйToolStripMenuItem";
            this.сложныйToolStripMenuItem.Size = new System.Drawing.Size(158, 26);
            this.сложныйToolStripMenuItem.Text = "Сложный";
            this.сложныйToolStripMenuItem.Click += new System.EventHandler(this.сложныйToolStripMenuItem_Click);
            // 
            // справкаToolStripMenuItem
            // 
            this.справкаToolStripMenuItem.Name = "справкаToolStripMenuItem";
            this.справкаToolStripMenuItem.Size = new System.Drawing.Size(81, 26);
            this.справкаToolStripMenuItem.Text = "Справка";
            this.справкаToolStripMenuItem.Click += new System.EventHandler(this.справкаToolStripMenuItem_Click);
            // 
            // выходToolStripMenuItem
            // 
            this.выходToolStripMenuItem.Name = "выходToolStripMenuItem";
            this.выходToolStripMenuItem.Size = new System.Drawing.Size(67, 26);
            this.выходToolStripMenuItem.Text = "Выход";
            this.выходToolStripMenuItem.Click += new System.EventHandler(this.выходToolStripMenuItem_Click);
            // 
            // panel
            // 
            this.panel.Controls.Add(this.richTextBox_for_scores);
            this.panel.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel.Location = new System.Drawing.Point(567, 30);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(216, 548);
            this.panel.TabIndex = 1;
            // 
            // richTextBox_for_scores
            // 
            this.richTextBox_for_scores.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.richTextBox_for_scores.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox_for_scores.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBox_for_scores.Location = new System.Drawing.Point(0, 0);
            this.richTextBox_for_scores.Name = "richTextBox_for_scores";
            this.richTextBox_for_scores.ReadOnly = true;
            this.richTextBox_for_scores.Size = new System.Drawing.Size(216, 548);
            this.richTextBox_for_scores.TabIndex = 0;
            this.richTextBox_for_scores.Text = "";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(783, 578);
            this.Controls.Add(this.panel);
            this.Controls.Add(this.menuStrip);
            this.MainMenuStrip = this.menuStrip;
            this.Name = "MainForm";
            this.Text = "Minesweeper by Dina";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.panel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem новаяИграToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem уровеньСложностиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem легкийToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem среднийToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сложныйToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem справкаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem выходToolStripMenuItem;
        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.RichTextBox richTextBox_for_scores;
    }
}

