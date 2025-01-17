﻿using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

using System.Timers;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Net.Mime.MediaTypeNames;


namespace PoIBe
{

    public partial class Form1 : Form
    {
        string dataOPEN = "";
        string dataCLOSE = "";
        string key = "";
        char symbol;
        int symbolValue;
       
        public Form1()
        {
            InitializeComponent();
        }

  
        private void загрузитьОткрытыйТекстToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*"; // Установка фильтров для файлов

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string filePath = openFileDialog1.FileName; // Получение пути к файлу        
                textBox_openText.Text = File.ReadAllText(filePath);// Чтение содержимого файла
            }
        }

        private void загрузитьЗакрытыйТекстToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*"; 

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string filePath = openFileDialog1.FileName;       
                textBox_closeText.Text = File.ReadAllText(filePath);
            }
        }

        private void загрузитьКлючToolStripMenuItem_Click(object sender, EventArgs e)
        {

            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string filePath = openFileDialog1.FileName;        
                textBox_key.Text = File.ReadAllText(filePath);
            }
        }

        private void button_getkey_Click(object sender, EventArgs e)//сгенерировать ключ
        {
            Random rand = new Random();

            int Min1 = 97, Max1 = 122;    // Диапазоны
            int Min2 = 48, Max2 = 57;
            StringBuilder key = new StringBuilder();

            for (int i=0; i<8; i++)
            {
                 int randomNumber;

                // Определяем, какой диапазон выбрать
                int randomRangeSelector = rand.Next(2);  // 0 или 1

                if (randomRangeSelector == 0)
                {
                    // Генерация случайного числа в первом диапазоне
                    randomNumber = rand.Next(Min1, Max1 + 1);  
                }
                else
                {
                    // Генерация случайного числа во втором диапазоне
                    randomNumber = rand.Next(Min2, Max2 + 1);
                }

                char getkey = (char)randomNumber;
                key.Append(getkey);
            }
           
            textBox_key.Text = key.ToString();
        }





        private void button_shifr_Click(object sender, EventArgs e)
        {
            textBox_closeText.Text = "";
            if (string.IsNullOrEmpty(textBox_openText.Text))
            {
                MessageBox.Show("Загрузите или введите открытый текст");
            }
            else if (string.IsNullOrEmpty(textBox_key.Text))
            {
                MessageBox.Show("Сгенерируйте или загрузите ключ");
            }
            else  //шифрование//
            {
                dataOPEN = textBox_openText.Text;
                key = textBox_key.Text;
                dataCLOSE = Shifr(dataOPEN, key);
                textBox_closeText.Text = dataCLOSE;

                StringBuilder dataOpenHEX = new StringBuilder();

                for (int i = 0; i < dataOPEN.Length; i++)
                {
                    dataOpenHEX.Append(CharToHex(dataOPEN[i]));
                }
                textBox_openHEX.Text = dataOpenHEX.ToString();
            }
        }

        static string Shifr(string text, string key)
        {
            StringBuilder result = new StringBuilder();

            for (int i = 0; i < text.Length; i++)
            {
                char shifrSymb = (char)(text[i] ^ key[i % key.Length]);  //  XOR 
                result.Append(CharToHex(shifrSymb));
            }
            return result.ToString();
        }

        // Функция расшифровки из шестнадцатеричной строки обратно в текст
        static string DeShifr(string hexText, string key)
        {
 
            StringBuilder result = new StringBuilder();
            try
            {
                for (int i = 0; i < hexText.Length; i += 2)  // Расшифровываем по два символа (байт в 16c.c занимает 2 символа)
                {
                    string hexChar = hexText.Substring(i, 2);
                    int shifrSymbValue = Convert.ToInt32(hexChar, 16);

                    char deshifrSymb = (char)(shifrSymbValue ^ key[(i / 2) % key.Length]);// XOR
                    result.Append(deshifrSymb);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка при расшифровке: " + ex.Message);
            }

            return result.ToString();
        }

        // Функция для перевода символа в шестнадцатеричную строку
        static string CharToHex(char c)
        {
            return ((int)c).ToString("X2");
        }


        private void button_razshifr_Click(object sender, EventArgs e)
        {
            textBox_openText.Text = ""; 
            if (string.IsNullOrEmpty(textBox_closeText.Text))
            {
                MessageBox.Show("Загрузите или введите закрытый текст");

            }
            else if (string.IsNullOrEmpty(textBox_key.Text))
            {
                MessageBox.Show("Сгенерируйте или загрузите ключ");

            }
            else  //дешифрование///
            {
                dataCLOSE = textBox_closeText.Text;
                key = textBox_key.Text;
                dataOPEN = DeShifr(dataCLOSE, key);
                textBox_openText.ForeColor = Color.Red;
                textBox_openText.Text = dataOPEN;

            }
        }



    
        private void button_test_Click_1(object sender, EventArgs e)
        {
            string testText = "Hello, World!";
            string testKey = "mysecret";  // Достаточно длинный ключ

            string encrypted = Shifr(testText, testKey);
            string decrypted = DeShifr(encrypted, testKey);

            MessageBox.Show($"Original: {testText}\nEncrypted: {encrypted}\nDecrypted: {decrypted}");
        }
    }
}
