namespace DataBase2
{
    partial class Form1
    {
        /// <summary>
        /// Требуется переменная конструктора.
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
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.показатьТаблицуToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.показатьТаблицуToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.показатьТаблицуToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.выходToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.выполнитьЗапросНаВыводВШахматномПорядкеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(979, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.показатьТаблицуToolStripMenuItem,
            this.показатьТаблицуToolStripMenuItem1,
            this.показатьТаблицуToolStripMenuItem2,
            this.выполнитьЗапросНаВыводВШахматномПорядкеToolStripMenuItem,
            this.выходToolStripMenuItem});
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(57, 24);
            this.файлToolStripMenuItem.Text = "Файл";
            // 
            // показатьТаблицуToolStripMenuItem
            // 
            this.показатьТаблицуToolStripMenuItem.Name = "показатьТаблицуToolStripMenuItem";
            this.показатьТаблицуToolStripMenuItem.Size = new System.Drawing.Size(443, 26);
            this.показатьТаблицуToolStripMenuItem.Text = "Показать таблицу \"CITY\"";
            this.показатьТаблицуToolStripMenuItem.Click += new System.EventHandler(this.показатьТаблицуToolStripMenuItem_Click);
            // 
            // показатьТаблицуToolStripMenuItem1
            // 
            this.показатьТаблицуToolStripMenuItem1.Name = "показатьТаблицуToolStripMenuItem1";
            this.показатьТаблицуToolStripMenuItem1.Size = new System.Drawing.Size(443, 26);
            this.показатьТаблицуToolStripMenuItem1.Text = "Показать таблицу \"FIRM\"";
            this.показатьТаблицуToolStripMenuItem1.Click += new System.EventHandler(this.показатьТаблицуToolStripMenuItem1_Click);
            // 
            // показатьТаблицуToolStripMenuItem2
            // 
            this.показатьТаблицуToolStripMenuItem2.Name = "показатьТаблицуToolStripMenuItem2";
            this.показатьТаблицуToolStripMenuItem2.Size = new System.Drawing.Size(443, 26);
            this.показатьТаблицуToolStripMenuItem2.Text = "Показать таблицу \"DOCUMENT\"";
            this.показатьТаблицуToolStripMenuItem2.Click += new System.EventHandler(this.показатьТаблицуToolStripMenuItem2_Click);
            // 
            // выходToolStripMenuItem
            // 
            this.выходToolStripMenuItem.Name = "выходToolStripMenuItem";
            this.выходToolStripMenuItem.Size = new System.Drawing.Size(443, 26);
            this.выходToolStripMenuItem.Text = "Выход";
            this.выходToolStripMenuItem.Click += new System.EventHandler(this.выходToolStripMenuItem_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 91);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(955, 392);
            this.dataGridView1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(179, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Введите название фирмы";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(198, 34);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(186, 22);
            this.textBox1.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(412, 31);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(130, 54);
            this.button1.TabIndex = 4;
            this.button1.Text = "Выполнить запрос";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // выполнитьЗапросНаВыводВШахматномПорядкеToolStripMenuItem
            // 
            this.выполнитьЗапросНаВыводВШахматномПорядкеToolStripMenuItem.Name = "выполнитьЗапросНаВыводВШахматномПорядкеToolStripMenuItem";
            this.выполнитьЗапросНаВыводВШахматномПорядкеToolStripMenuItem.Size = new System.Drawing.Size(443, 26);
            this.выполнитьЗапросНаВыводВШахматномПорядкеToolStripMenuItem.Text = "Выполнить запрос на вывод в шахматном порядке";
            this.выполнитьЗапросНаВыводВШахматномПорядкеToolStripMenuItem.Click += new System.EventHandler(this.выполнитьЗапросНаВыводВШахматномПорядкеToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(979, 495);
            this.ControlBox = false;
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Выполнил Крутько Константин Владимирович";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem показатьТаблицуToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem показатьТаблицуToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem показатьТаблицуToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem выполнитьЗапросНаВыводВШахматномПорядкеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem выходToolStripMenuItem;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
    }
}

