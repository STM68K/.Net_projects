using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace Prmib_Generator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Alabel.Text = "A=0";
            PassCount.Text = "Кол-во символов:0";
            panel4.Enabled = false;
            
        }
        
        private void GenerateButton_Click(object sender, EventArgs e)
        {
            PasswordBox.Clear();
            Lbox.Clear();
            double t = 0;
            double v = 0;
            double l = 1;
            double pbox = 0;
            bool Tvalidated = false;
            bool Vvalidated = false;
            bool Pvalidated = false;
            bool Avalidated = false;
            double res = 0;
            int Klength = 0;
            double tick = 0;
            double A = GeneratedBox.Text.Count();
            bool IsTimeChecked = false;
            bool IsPassCracked = false;
            bool CheckBoxForDigit = false;
            bool CheckBoxForChar = false;
            bool CheckBoxForSpec = false;
            if (Tbox.Text == "" && !CustomBox.Checked) { MessageBox.Show("Ошибка,введите параметр T", "Ошибка ввода", MessageBoxButtons.OK, MessageBoxIcon.Error); }
            else if ( !CustomBox.Checked&&Convert.ToDouble(Tbox.Text) == 0 ) { MessageBox.Show("Ошибка,параметр T не может быть 0", "Ошибка ввода", MessageBoxButtons.OK, MessageBoxIcon.Error); }
           else  if (Tbox.Text != ""&& Convert.ToDouble(Tbox.Text)!=0 && !CustomBox.Checked) { t = Convert.ToDouble(Tbox.Text); Tvalidated = true; }
             if (Vbox.Text == "" && !CustomBox.Checked) { MessageBox.Show("Ошибка,введите параметр V", "Ошибка ввода", MessageBoxButtons.OK, MessageBoxIcon.Error); }
            else if ( !CustomBox.Checked&&Convert.ToDouble(Vbox.Text) == 0 ) { MessageBox.Show("Ошибка,параметр V не может быть 0", "Ошибка ввода", MessageBoxButtons.OK, MessageBoxIcon.Error); }
             else if (Vbox.Text != "" && Convert.ToDouble(Vbox.Text)!=0 && !CustomBox.Checked) { v = Convert.ToDouble(Vbox.Text); Vvalidated = true; }
            if (Pbox.Text == "" && !CustomBox.Checked) { MessageBox.Show("Ошибка,введите параметр P", "Ошибка ввода", MessageBoxButtons.OK, MessageBoxIcon.Error); }

            if (Pbox.Text.Contains('^')&& Pbox.Text.Contains('*'))
            {
                string[] separator = Pbox.Text.Split('^','*');
               double pbox1 = Convert.ToDouble(separator[0]);
               pbox = Math.Pow(Convert.ToDouble(separator[1]), Convert.ToDouble(separator[2]));
                pbox *= pbox1; 

            }
            else if(Pbox.Text!="" && !CustomBox.Checked) { MessageBox.Show("Введите число в виде n*x^y","Ввод",MessageBoxButtons.OK,MessageBoxIcon.Information); }

            if (!CustomBox.Checked && pbox == 0||pbox>=1 ) { MessageBox.Show("Ошибка,параметр P не может быть 0 или больше, это значит что пароль взломан", "Ошибка ввода", MessageBoxButtons.OK, MessageBoxIcon.Error); }
            else  {  Pvalidated = true; }

            if (GeneratedBox.Text == "") { MessageBox.Show("Введите символы, которые будут использоватся при генерации пароля(A)", "Ошибка ввода", MessageBoxButtons.OK, MessageBoxIcon.Error); }
            else { Avalidated = true; }

            if (CustomBox.Checked&& Avalidated==true)
            {
                bool cusval = false;
                if (LboxCustom.Text == "") { MessageBox.Show("Введите длину пароля", "Ошибка ввода", MessageBoxButtons.OK, MessageBoxIcon.Error); }
                else if (Convert.ToInt32(LboxCustom.Text) <= 0) { MessageBox.Show("Длина пароля не может быть 0 или <0", "Ошибка ввода", MessageBoxButtons.OK, MessageBoxIcon.Error); }
                else if (Convert.ToInt32(LboxCustom.Text) > 50) { MessageBox.Show("Длина пароля не может быть больше 50", "Ошибка ввода", MessageBoxButtons.OK, MessageBoxIcon.Error); }
                else cusval = true;
                if (cusval == true)
                {
                    Klength = Convert.ToInt32(LboxCustom.Text);
                    string allowedchars = GeneratedBox.Text;
                    for (int z = 0; z < allowedchars.Length; z++)
                    {
                        char c = allowedchars[z];
                        if (Char.IsDigit(c)) { CheckBoxForDigit = true; }
                        if (Char.IsLetter(c)) { CheckBoxForChar = true; }
                        if (Char.IsSymbol(c) || Char.IsPunctuation(c)) { CheckBoxForSpec = true; }
                    }
                    Random randNum = new Random((int)DateTime.Now.Ticks);
                    char[] chars = new char[Klength];
                passgen:
                    string final = "";
                    for (int i = 0; i < Klength; i++)
                    {
                        chars[i] = allowedchars[randNum.Next(allowedchars.Length)];
                        final += chars[i];


                    }
                    bool ValidDigit = false;
                    bool ValidSpec = false;
                    bool ValidLetter = false;
                    for (int x = 0; x < final.Length; x++)
                    {
                        if (Char.IsDigit(final[x]) && CheckBoxForDigit == true) { ValidDigit = true; }
                        if (Char.IsLetter(final[x]) && CheckBoxForChar == true) { ValidLetter = true; }
                        if (Char.IsSymbol(final[x]) || Char.IsPunctuation(final[x]) && CheckBoxForSpec == true) { ValidSpec = true; }
                    }
                    if (ValidDigit == false && CheckBoxForDigit == true) { goto passgen; }
                    if (ValidSpec == false && CheckBoxForSpec == true) { goto passgen; }
                    if (ValidLetter == false && CheckBoxForChar == true) { goto passgen; }
                    PasswordBox.Text = final;

                    if (IsPassCracked == false) { MessageBox.Show("Пароль успешно сгенерирован", "Генерация завершена", MessageBoxButtons.OK, MessageBoxIcon.Information); }
                }
            }


            if (Tvalidated == true && Vvalidated == true && Pvalidated == true&&Avalidated==true)
            {
                
                if (MinuteCheck.Checked) { res = (v * 60 * t * 24) / pbox; IsTimeChecked = true;   }
                else if (DayCheck.Checked) { res = (v * 60 * 24 * t * 24) / pbox; IsTimeChecked = true; panel1.Enabled=false; }
                else { MessageBox.Show("Выберите размерность V(минуты/дни)", "Ошибка ввода", MessageBoxButtons.OK, MessageBoxIcon.Information); }
               
                if (IsTimeChecked == true&& !CustomBox.Checked)
                {
                    
                    for (int k = 0; k < 50; k++)
                    {
                        tick++;
                        l = Math.Pow(A, tick);
                        Klength++;
                        if (l >= res) { Lbox.Text = Convert.ToString(Klength); break; } //MessageBox.Show(Convert.ToString(l) + "-" + Convert.ToString(res) + "=" + Convert.ToString(l - res)); 
                    }
                    if (l < res) { Lbox.Text = Convert.ToString(Klength); IsPassCracked = true; MessageBox.Show("К сожалению взломщик слишком силен,и пароль будет взломан быстро\n" + "A=" + GeneratedBox.Text.Count() + "\nL=" + Convert.ToInt32(Klength - 1) + "\nA^L=" + l + "\nS*=" + res, "Информация(", MessageBoxButtons.OK, MessageBoxIcon.Information); }
                    string allowedchars = GeneratedBox.Text;
                    for(int z=0; z<allowedchars.Length; z++)
                    {
                        char c = allowedchars[z];
                        if (Char.IsDigit(c)) { CheckBoxForDigit = true; }
                        if (Char.IsLetter(c)) { CheckBoxForChar = true; }
                        if (Char.IsSymbol(c)||Char.IsPunctuation(c)) { CheckBoxForSpec = true; }
                    }
                    Random randNum = new Random((int)DateTime.Now.Ticks);
                    char[] chars = new char[Klength];
                passgen:
                    string final = "";
                    for (int i = 0; i < Klength; i++)
                    {
                        chars[i] = allowedchars[randNum.Next(allowedchars.Length)];
                        final += chars[i];


                    }
                    bool ValidDigit = false;
                    bool ValidSpec = false;
                    bool ValidLetter = false;
                    for(int x=0;x<final.Length; x++)
                    {
                        if (Char.IsDigit(final[x]) && CheckBoxForDigit == true) { ValidDigit = true; }
                        if(Char.IsLetter(final[x])&& CheckBoxForChar == true) { ValidLetter = true; }
                        if(Char.IsSymbol(final[x])|| Char.IsPunctuation(final[x])&& CheckBoxForSpec == true) { ValidSpec = true; }
                    }
                    if (ValidDigit == false&& CheckBoxForDigit==true) { goto passgen; }
                    if(ValidSpec==false && CheckBoxForSpec == true) { goto passgen; }
                    if(ValidLetter==false && CheckBoxForChar == true) { goto passgen; }
                        PasswordBox.Text =final;
                    
                    if (IsPassCracked == false) { MessageBox.Show("Пароль успешно сгенерирован", "Генерация завершена", MessageBoxButtons.OK, MessageBoxIcon.Information); }


                }
            }

        }

        private void Lbox_KeyPress(object sender, KeyPressEventArgs e)
        {
           
                e.Handled = true;
        }

        private void Pbox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != 8 && e.KeyChar!='^' && e.KeyChar!='-'&&e.KeyChar!='*')
                e.Handled = true;
        }

        private void Vbox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != 8)
                e.Handled = true;
        }

        private void Tbox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != 8)
                e.Handled = true;
        }

        private void PasswordBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void DigitsCheck_CheckedChanged(object sender, EventArgs e)
        {
            if (DigitsCheck.Checked) { GeneratedBox.Text += "0123456789"; }
            else {  string refstring=GeneratedBox.Text; string finalstring = ""; for (int t = 0; t < refstring.Length; t++) { if (Char.IsDigit(refstring[t])) { } else finalstring += refstring[t]; } GeneratedBox.Text = finalstring; }
        }

        private void SpecialCheck_CheckedChanged(object sender, EventArgs e)
        {
            if (SpecialCheck.Checked) { GeneratedBox.Text += "!#$%&_-"; }
            else {  string refstring = GeneratedBox.Text; string finalstring = ""; for (int t = 0; t < refstring.Length; t++) { if (Char.IsSymbol(refstring[t])||Char.IsPunctuation(refstring[t])||Char.IsWhiteSpace(refstring[t])) { } else finalstring += refstring[t]; } GeneratedBox.Text = finalstring; }
        }

        private void RuAplhaCheck_CheckedChanged(object sender, EventArgs e)
        {
            if (RuAplhaCheck.Checked) { GeneratedBox.Text += "абвгдеёжзийклмнопрстуфхцчшщъыьэюяАБВГДЕЁЖЗИЙКЛМНОПРСТУФХЦЧШЩЪЫЬЭЮЯ"; }
            else { string refstring = GeneratedBox.Text; string finalstring=""; string truefinalstring = ""; for (int t = 0; t < refstring.Length; t++) { if (Char.IsLetter(refstring[t]) && refstring[t] >= 'А' && refstring[t] <= 'Я' || refstring[t] >= 'а' && refstring[t] <= 'я') { } else finalstring += refstring[t]; } for (int z = 0; z < finalstring.Length; z++) { if (finalstring[z] == 'Ё' || finalstring[z] == 'ё') { } else truefinalstring += finalstring[z]; }  GeneratedBox.Text = truefinalstring;  }
        }

        private void GeneratedBox_KeyPress(object sender, KeyPressEventArgs e)
        {
          if(e.KeyChar==' ') e.Handled = true;
        }

        private void GeneratedBox_TextChanged(object sender, EventArgs e)
        {
            Alabel.Text = "A="+Convert.ToString(GeneratedBox.Text.Count());
        }

        private void PasswordBox_TextChanged(object sender, EventArgs e)
        {
            PassCount.Text = "Кол-во символов:" + Convert.ToString(PasswordBox.Text.Count());
        }

        private void ExportButton_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.Title = "Сохранение пароля";
            saveFileDialog1.Filter = "Текстовые файлы (*.txt)|*.txt";
            saveFileDialog1.CheckPathExists = true;
         
            if (PasswordBox.Text == "") { MessageBox.Show("Ошибка,пароль не сгенерирован", "Ошибка сохранения", MessageBoxButtons.OK, MessageBoxIcon.Error); }
           else if (saveFileDialog1.ShowDialog() == DialogResult.OK) { string filename = saveFileDialog1.FileName; string savedmessage = "SavedAt:"+Convert.ToString(DateTime.Today.ToShortDateString())+" Пароль: "+PasswordBox.Text+"  "+PassCount.Text; System.IO.File.WriteAllText(filename,savedmessage); MessageBox.Show("Файл успешно сохранен","Отчет о сохранении",MessageBoxButtons.OK,MessageBoxIcon.Information); }
            
            
        }

        private void HelpButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Программа создана в соответствии с алгоритмом подбора оптимального пароля заданого в лабораторной работе\nДля работы необходимо внести значения P,V,T, после этого программа рассчитает кол-во необходимых символов(L<=50) в соответсвтвии с мощностью алфавита(A) для соответствия тождеству S* ≤ A^L\nТак же есть возможность экспортировать сгенерированный пароль при помощи кнопки, импортировать словарь в .txt ", "Справка", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

      

        private void MinuteCheck_Click(object sender, EventArgs e)
        {
            if (MinuteCheck.Checked) { panel2.Enabled = false; }
            else panel2.Enabled = true;
        }

        private void DayCheck_CheckedChanged(object sender, EventArgs e)
        {
            if (DayCheck.Checked) { panel1.Enabled = false; }
            else panel1.Enabled = true;
        }

        private void DictionaryButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.Title = "Импортировать словарь";
            openFileDialog1.Filter = "Текстовые файлы (*.txt)|*.txt";
            openFileDialog1.CheckPathExists = true;
            if (openFileDialog1.ShowDialog() == DialogResult.OK) { string filename = openFileDialog1.FileName; string filetext = System.IO.File.ReadAllText(filename);   GeneratedBox.Text = filetext.Trim(); MessageBox.Show("Импорт произведен успешно", "Словарь импортирован", MessageBoxButtons.OK, MessageBoxIcon.Information); }
        }

        private void AddEnglishAlpha_CheckedChanged(object sender, EventArgs e)
        {
            if (AddEnglishAlpha.Checked) { GeneratedBox.Text += "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ"; }
            else { string refstring = GeneratedBox.Text; string finalstring = ""; for (int t = 0; t < refstring.Length; t++) { if (Char.IsLetter(refstring[t])&& refstring[t]>='A' && refstring[t]<='Z'|| refstring[t]>='a'&&refstring[t]<='z') { } else finalstring += refstring[t]; } GeneratedBox.Text = finalstring; }
        }

        private void LboxCustom_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != 8)
                e.Handled = true;
        }

        private void CustomBox_CheckedChanged(object sender, EventArgs e)
        {
            if (CustomBox.Checked) { panel3.Enabled = false;  panel4.Enabled = true; }
            else { panel3.Enabled = true;  panel4.Enabled = false; LboxCustom.Clear(); }
        }

        private void DelSpace_Click(object sender, EventArgs e)
        {
            string text = GeneratedBox.Text;
            string finaltext = "";
            for(int z=0; z<text.Length; z++)
            {
                if (Char.IsWhiteSpace(text[z])) { } else finaltext += text[z];
            }
            GeneratedBox.Text = finaltext;
        }
    }
    }

