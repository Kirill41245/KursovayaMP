namespace Kursovaya_MP
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.открытьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сохранитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.редактированиеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.включитьРедактированиеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выключитьРедактированиеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.уменьшитьЦенуНаКнигиУКоторыхОстатокПревышаетКоличествоПроданныхБолееЧемВ2РазаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.анализToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.отчет1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.отчет2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.средняяЦенаОднойКнигиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.суммарнуюСтоимостьКнигПроданныхКаждымМагазиномToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.удалитьСведенияОКнигахСЦенойНижеЗаданнойToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.LightGray;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem,
            this.редактированиеToolStripMenuItem,
            this.анализToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(941, 29);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.открытьToolStripMenuItem,
            this.сохранитьToolStripMenuItem});
            this.файлToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(59, 25);
            this.файлToolStripMenuItem.Text = "Файл";
            // 
            // открытьToolStripMenuItem
            // 
            this.открытьToolStripMenuItem.Name = "открытьToolStripMenuItem";
            this.открытьToolStripMenuItem.Size = new System.Drawing.Size(156, 26);
            this.открытьToolStripMenuItem.Text = "Открыть";
            this.открытьToolStripMenuItem.Click += new System.EventHandler(this.открытьToolStripMenuItem_Click);
            // 
            // сохранитьToolStripMenuItem
            // 
            this.сохранитьToolStripMenuItem.Name = "сохранитьToolStripMenuItem";
            this.сохранитьToolStripMenuItem.Size = new System.Drawing.Size(156, 26);
            this.сохранитьToolStripMenuItem.Text = "Сохранить";
            this.сохранитьToolStripMenuItem.Click += new System.EventHandler(this.сохранитьToolStripMenuItem_Click);
            // 
            // редактированиеToolStripMenuItem
            // 
            this.редактированиеToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.включитьРедактированиеToolStripMenuItem,
            this.выключитьРедактированиеToolStripMenuItem,
            this.уменьшитьЦенуНаКнигиУКоторыхОстатокПревышаетКоличествоПроданныхБолееЧемВ2РазаToolStripMenuItem,
            this.удалитьСведенияОКнигахСЦенойНижеЗаданнойToolStripMenuItem});
            this.редактированиеToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.редактированиеToolStripMenuItem.Name = "редактированиеToolStripMenuItem";
            this.редактированиеToolStripMenuItem.Size = new System.Drawing.Size(140, 25);
            this.редактированиеToolStripMenuItem.Text = "Редактирование";
            // 
            // включитьРедактированиеToolStripMenuItem
            // 
            this.включитьРедактированиеToolStripMenuItem.Name = "включитьРедактированиеToolStripMenuItem";
            this.включитьРедактированиеToolStripMenuItem.Size = new System.Drawing.Size(799, 26);
            this.включитьРедактированиеToolStripMenuItem.Text = "Включить редактирование";
            this.включитьРедактированиеToolStripMenuItem.Click += new System.EventHandler(this.включитьРедактированиеToolStripMenuItem_Click);
            // 
            // выключитьРедактированиеToolStripMenuItem
            // 
            this.выключитьРедактированиеToolStripMenuItem.Name = "выключитьРедактированиеToolStripMenuItem";
            this.выключитьРедактированиеToolStripMenuItem.Size = new System.Drawing.Size(799, 26);
            this.выключитьРедактированиеToolStripMenuItem.Text = "Выключить редактирование";
            this.выключитьРедактированиеToolStripMenuItem.Click += new System.EventHandler(this.выключитьРедактированиеToolStripMenuItem_Click);
            // 
            // уменьшитьЦенуНаКнигиУКоторыхОстатокПревышаетКоличествоПроданныхБолееЧемВ2РазаToolStripMenuItem
            // 
            this.уменьшитьЦенуНаКнигиУКоторыхОстатокПревышаетКоличествоПроданныхБолееЧемВ2РазаToolStripMenuItem.Name = "уменьшитьЦенуНаКнигиУКоторыхОстатокПревышаетКоличествоПроданныхБолееЧемВ2РазаTool" +
    "StripMenuItem";
            this.уменьшитьЦенуНаКнигиУКоторыхОстатокПревышаетКоличествоПроданныхБолееЧемВ2РазаToolStripMenuItem.Size = new System.Drawing.Size(799, 26);
            this.уменьшитьЦенуНаКнигиУКоторыхОстатокПревышаетКоличествоПроданныхБолееЧемВ2РазаToolStripMenuItem.Text = "Уменьшить цену на книги, у которых остаток превышает количество проданных более ч" +
    "ем в 2 раза";
            this.уменьшитьЦенуНаКнигиУКоторыхОстатокПревышаетКоличествоПроданныхБолееЧемВ2РазаToolStripMenuItem.Click += new System.EventHandler(this.уменьшитьЦенуНаКнигиУКоторыхОстатокПревышаетКоличествоПроданныхБолееЧемВ2РазаToolStripMenuItem_Click);
            // 
            // анализToolStripMenuItem
            // 
            this.анализToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.отчет1ToolStripMenuItem,
            this.отчет2ToolStripMenuItem,
            this.средняяЦенаОднойКнигиToolStripMenuItem,
            this.суммарнуюСтоимостьКнигПроданныхКаждымМагазиномToolStripMenuItem});
            this.анализToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.анализToolStripMenuItem.Name = "анализToolStripMenuItem";
            this.анализToolStripMenuItem.Size = new System.Drawing.Size(73, 25);
            this.анализToolStripMenuItem.Text = "Анализ";
            // 
            // отчет1ToolStripMenuItem
            // 
            this.отчет1ToolStripMenuItem.Name = "отчет1ToolStripMenuItem";
            this.отчет1ToolStripMenuItem.Size = new System.Drawing.Size(508, 26);
            this.отчет1ToolStripMenuItem.Text = "Количество проданных книг в магазине";
            this.отчет1ToolStripMenuItem.Click += new System.EventHandler(this.отчет1ToolStripMenuItem_Click);
            // 
            // отчет2ToolStripMenuItem
            // 
            this.отчет2ToolStripMenuItem.Name = "отчет2ToolStripMenuItem";
            this.отчет2ToolStripMenuItem.Size = new System.Drawing.Size(508, 26);
            this.отчет2ToolStripMenuItem.Text = "Стоимость всех непроданных книг";
            this.отчет2ToolStripMenuItem.Click += new System.EventHandler(this.отчет2ToolStripMenuItem_Click);
            // 
            // средняяЦенаОднойКнигиToolStripMenuItem
            // 
            this.средняяЦенаОднойКнигиToolStripMenuItem.Name = "средняяЦенаОднойКнигиToolStripMenuItem";
            this.средняяЦенаОднойКнигиToolStripMenuItem.Size = new System.Drawing.Size(508, 26);
            this.средняяЦенаОднойКнигиToolStripMenuItem.Text = "Средняя цена одной книги";
            this.средняяЦенаОднойКнигиToolStripMenuItem.Click += new System.EventHandler(this.средняяЦенаОднойКнигиToolStripMenuItem_Click);
            // 
            // суммарнуюСтоимостьКнигПроданныхКаждымМагазиномToolStripMenuItem
            // 
            this.суммарнуюСтоимостьКнигПроданныхКаждымМагазиномToolStripMenuItem.Name = "суммарнуюСтоимостьКнигПроданныхКаждымМагазиномToolStripMenuItem";
            this.суммарнуюСтоимостьКнигПроданныхКаждымМагазиномToolStripMenuItem.Size = new System.Drawing.Size(508, 26);
            this.суммарнуюСтоимостьКнигПроданныхКаждымМагазиномToolStripMenuItem.Text = "Суммарная стоимость книг, проданных каждым магазином";
            this.суммарнуюСтоимостьКнигПроданныхКаждымМагазиномToolStripMenuItem.Click += new System.EventHandler(this.суммарнуюСтоимостьКнигПроданныхКаждымМагазиномToolStripMenuItem_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AccessibleRole = System.Windows.Forms.AccessibleRole.Alert;
            this.dataGridView1.AllowDrop = true;
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6});
            this.dataGridView1.Location = new System.Drawing.Point(7, 98);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(905, 341);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.DragDrop += new System.Windows.Forms.DragEventHandler(this.dataGridView1_DragDrop);
            this.dataGridView1.DragEnter += new System.Windows.Forms.DragEventHandler(this.dataGridView1_DragEnter);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Название книги";
            this.Column1.Name = "Column1";
            this.Column1.Width = 170;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Фамилия автора";
            this.Column2.Name = "Column2";
            this.Column2.Width = 170;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Номер магазина";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Цена";
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Продано";
            this.Column5.Name = "Column5";
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Остаток";
            this.Column6.Name = "Column6";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.label1.Location = new System.Drawing.Point(12, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(275, 26);
            this.label1.TabIndex = 2;
            this.label1.Text = "Сведения о продаже книг";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.button1.Location = new System.Drawing.Point(17, 456);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(162, 49);
            this.button1.TabIndex = 3;
            this.button1.Text = "Добавить данные";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.button2.Location = new System.Drawing.Point(17, 511);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(162, 49);
            this.button2.TabIndex = 4;
            this.button2.Text = "Удалить строку";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // удалитьСведенияОКнигахСЦенойНижеЗаданнойToolStripMenuItem
            // 
            this.удалитьСведенияОКнигахСЦенойНижеЗаданнойToolStripMenuItem.Name = "удалитьСведенияОКнигахСЦенойНижеЗаданнойToolStripMenuItem";
            this.удалитьСведенияОКнигахСЦенойНижеЗаданнойToolStripMenuItem.Size = new System.Drawing.Size(799, 26);
            this.удалитьСведенияОКнигахСЦенойНижеЗаданнойToolStripMenuItem.Text = "Удалить сведения о книгах с ценой ниже заданной";
            this.удалитьСведенияОКнигахСЦенойНижеЗаданнойToolStripMenuItem.Click += new System.EventHandler(this.удалитьСведенияОКнигахСЦенойНижеЗаданнойToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(941, 575);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem открытьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сохранитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem редактированиеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem включитьРедактированиеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem анализToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem отчет1ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem отчет2ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem средняяЦенаОднойКнигиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem суммарнуюСтоимостьКнигПроданныхКаждымМагазиномToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
        internal System.Windows.Forms.Button button1;
        internal System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.ToolStripMenuItem выключитьРедактированиеToolStripMenuItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.ToolStripMenuItem уменьшитьЦенуНаКнигиУКоторыхОстатокПревышаетКоличествоПроданныхБолееЧемВ2РазаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem удалитьСведенияОКнигахСЦенойНижеЗаданнойToolStripMenuItem;
    }
}

