namespace PoIBe
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
            this.textBox_openText = new System.Windows.Forms.TextBox();
            this.button_shifr = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.загрузитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.загрузитьОткрытыйТекстToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.загрузитьЗакрытыйТекстToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.загрузитьКлючToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сохранитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сохранитьОткрытыйТекстToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сохранитьЗакрытыйТекстToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сохранитьКлючToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.button_razshifr = new System.Windows.Forms.Button();
            this.textBox_openHEX = new System.Windows.Forms.TextBox();
            this.textBox_closeText = new System.Windows.Forms.TextBox();
            this.textBox_key = new System.Windows.Forms.TextBox();
            this.button_getkey = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.button_test = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox_openText
            // 
            this.textBox_openText.Location = new System.Drawing.Point(6, 21);
            this.textBox_openText.Multiline = true;
            this.textBox_openText.Name = "textBox_openText";
            this.textBox_openText.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox_openText.Size = new System.Drawing.Size(500, 214);
            this.textBox_openText.TabIndex = 0;
            // 
            // button_shifr
            // 
            this.button_shifr.Location = new System.Drawing.Point(670, 450);
            this.button_shifr.Name = "button_shifr";
            this.button_shifr.Size = new System.Drawing.Size(273, 81);
            this.button_shifr.TabIndex = 1;
            this.button_shifr.Text = "Зашифровать";
            this.button_shifr.UseVisualStyleBackColor = true;
            this.button_shifr.Click += new System.EventHandler(this.button_shifr_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.загрузитьToolStripMenuItem,
            this.сохранитьToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1303, 30);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // загрузитьToolStripMenuItem
            // 
            this.загрузитьToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.загрузитьОткрытыйТекстToolStripMenuItem,
            this.загрузитьЗакрытыйТекстToolStripMenuItem,
            this.загрузитьКлючToolStripMenuItem});
            this.загрузитьToolStripMenuItem.Name = "загрузитьToolStripMenuItem";
            this.загрузитьToolStripMenuItem.Size = new System.Drawing.Size(91, 26);
            this.загрузитьToolStripMenuItem.Text = "Загрузить";
            // 
            // загрузитьОткрытыйТекстToolStripMenuItem
            // 
            this.загрузитьОткрытыйТекстToolStripMenuItem.Name = "загрузитьОткрытыйТекстToolStripMenuItem";
            this.загрузитьОткрытыйТекстToolStripMenuItem.Size = new System.Drawing.Size(270, 26);
            this.загрузитьОткрытыйТекстToolStripMenuItem.Text = "Загрузить открытый текст";
            this.загрузитьОткрытыйТекстToolStripMenuItem.Click += new System.EventHandler(this.загрузитьОткрытыйТекстToolStripMenuItem_Click);
            // 
            // загрузитьЗакрытыйТекстToolStripMenuItem
            // 
            this.загрузитьЗакрытыйТекстToolStripMenuItem.Name = "загрузитьЗакрытыйТекстToolStripMenuItem";
            this.загрузитьЗакрытыйТекстToolStripMenuItem.Size = new System.Drawing.Size(270, 26);
            this.загрузитьЗакрытыйТекстToolStripMenuItem.Text = "Загрузить закрытый текст";
            this.загрузитьЗакрытыйТекстToolStripMenuItem.Click += new System.EventHandler(this.загрузитьЗакрытыйТекстToolStripMenuItem_Click);
            // 
            // загрузитьКлючToolStripMenuItem
            // 
            this.загрузитьКлючToolStripMenuItem.Name = "загрузитьКлючToolStripMenuItem";
            this.загрузитьКлючToolStripMenuItem.Size = new System.Drawing.Size(270, 26);
            this.загрузитьКлючToolStripMenuItem.Text = "Загрузить ключ";
            this.загрузитьКлючToolStripMenuItem.Click += new System.EventHandler(this.загрузитьКлючToolStripMenuItem_Click);
            // 
            // сохранитьToolStripMenuItem
            // 
            this.сохранитьToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.сохранитьОткрытыйТекстToolStripMenuItem,
            this.сохранитьЗакрытыйТекстToolStripMenuItem,
            this.сохранитьКлючToolStripMenuItem});
            this.сохранитьToolStripMenuItem.Name = "сохранитьToolStripMenuItem";
            this.сохранитьToolStripMenuItem.Size = new System.Drawing.Size(97, 26);
            this.сохранитьToolStripMenuItem.Text = "Сохранить";
            // 
            // сохранитьОткрытыйТекстToolStripMenuItem
            // 
            this.сохранитьОткрытыйТекстToolStripMenuItem.Name = "сохранитьОткрытыйТекстToolStripMenuItem";
            this.сохранитьОткрытыйТекстToolStripMenuItem.Size = new System.Drawing.Size(276, 26);
            this.сохранитьОткрытыйТекстToolStripMenuItem.Text = "Сохранить открытый текст";
            // 
            // сохранитьЗакрытыйТекстToolStripMenuItem
            // 
            this.сохранитьЗакрытыйТекстToolStripMenuItem.Name = "сохранитьЗакрытыйТекстToolStripMenuItem";
            this.сохранитьЗакрытыйТекстToolStripMenuItem.Size = new System.Drawing.Size(276, 26);
            this.сохранитьЗакрытыйТекстToolStripMenuItem.Text = "Сохранить закрытый текст";
            // 
            // сохранитьКлючToolStripMenuItem
            // 
            this.сохранитьКлючToolStripMenuItem.Name = "сохранитьКлючToolStripMenuItem";
            this.сохранитьКлючToolStripMenuItem.Size = new System.Drawing.Size(276, 26);
            this.сохранитьКлючToolStripMenuItem.Text = "Сохранить ключ";
            // 
            // button_razshifr
            // 
            this.button_razshifr.Location = new System.Drawing.Point(949, 450);
            this.button_razshifr.Name = "button_razshifr";
            this.button_razshifr.Size = new System.Drawing.Size(263, 81);
            this.button_razshifr.TabIndex = 3;
            this.button_razshifr.Text = "Разшифровать";
            this.button_razshifr.UseVisualStyleBackColor = true;
            this.button_razshifr.Click += new System.EventHandler(this.button_razshifr_Click);
            // 
            // textBox_openHEX
            // 
            this.textBox_openHEX.Location = new System.Drawing.Point(6, 21);
            this.textBox_openHEX.Multiline = true;
            this.textBox_openHEX.Name = "textBox_openHEX";
            this.textBox_openHEX.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox_openHEX.Size = new System.Drawing.Size(494, 214);
            this.textBox_openHEX.TabIndex = 4;
            // 
            // textBox_closeText
            // 
            this.textBox_closeText.Location = new System.Drawing.Point(6, 21);
            this.textBox_closeText.Multiline = true;
            this.textBox_closeText.Name = "textBox_closeText";
            this.textBox_closeText.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox_closeText.Size = new System.Drawing.Size(536, 208);
            this.textBox_closeText.TabIndex = 5;
            // 
            // textBox_key
            // 
            this.textBox_key.Location = new System.Drawing.Point(6, 21);
            this.textBox_key.Multiline = true;
            this.textBox_key.Name = "textBox_key";
            this.textBox_key.Size = new System.Drawing.Size(295, 37);
            this.textBox_key.TabIndex = 6;
            // 
            // button_getkey
            // 
            this.button_getkey.Location = new System.Drawing.Point(1025, 354);
            this.button_getkey.Name = "button_getkey";
            this.button_getkey.Size = new System.Drawing.Size(187, 58);
            this.button_getkey.TabIndex = 7;
            this.button_getkey.Text = "Сгенерировать ключ";
            this.button_getkey.UseVisualStyleBackColor = true;
            this.button_getkey.Click += new System.EventHandler(this.button_getkey_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBox_openText);
            this.groupBox1.Location = new System.Drawing.Point(12, 55);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(512, 241);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Открытый текст";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.textBox_closeText);
            this.groupBox2.Location = new System.Drawing.Point(664, 55);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(548, 235);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Закрытый текст в HEX";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.textBox_openHEX);
            this.groupBox3.Location = new System.Drawing.Point(18, 348);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(506, 241);
            this.groupBox3.TabIndex = 10;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Открытый текст в HEX";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.textBox_key);
            this.groupBox4.Location = new System.Drawing.Point(670, 348);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(307, 64);
            this.groupBox4.TabIndex = 11;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Ключ HEX";
            // 
            // button_test
            // 
            this.button_test.Location = new System.Drawing.Point(800, 609);
            this.button_test.Name = "button_test";
            this.button_test.Size = new System.Drawing.Size(143, 54);
            this.button_test.TabIndex = 12;
            this.button_test.Text = "button1";
            this.button_test.UseVisualStyleBackColor = true;
            this.button_test.Click += new System.EventHandler(this.button_test_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1303, 720);
            this.Controls.Add(this.button_test);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button_getkey);
            this.Controls.Add(this.button_razshifr);
            this.Controls.Add(this.button_shifr);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_openText;
        private System.Windows.Forms.Button button_shifr;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem загрузитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem загрузитьОткрытыйТекстToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem загрузитьЗакрытыйТекстToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem загрузитьКлючToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сохранитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сохранитьОткрытыйТекстToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сохранитьЗакрытыйТекстToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сохранитьКлючToolStripMenuItem;
        private System.Windows.Forms.Button button_razshifr;
        private System.Windows.Forms.TextBox textBox_openHEX;
        private System.Windows.Forms.TextBox textBox_closeText;
        private System.Windows.Forms.TextBox textBox_key;
        private System.Windows.Forms.Button button_getkey;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button button_test;
    }
}

