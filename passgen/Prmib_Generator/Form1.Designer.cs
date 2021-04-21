namespace Prmib_Generator
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.Pbox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Vbox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Tbox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.GenerateButton = new System.Windows.Forms.Button();
            this.DigitsCheck = new System.Windows.Forms.CheckBox();
            this.SpecialCheck = new System.Windows.Forms.CheckBox();
            this.RuAplhaCheck = new System.Windows.Forms.CheckBox();
            this.PasswordBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.Lbox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.GeneratedBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.Alabel = new System.Windows.Forms.Label();
            this.PassCount = new System.Windows.Forms.Label();
            this.ExportButton = new System.Windows.Forms.Button();
            this.HelpButton = new System.Windows.Forms.Button();
            this.MinuteCheck = new System.Windows.Forms.CheckBox();
            this.DayCheck = new System.Windows.Forms.CheckBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.DictionaryButton = new System.Windows.Forms.Button();
            this.AddEnglishAlpha = new System.Windows.Forms.CheckBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.CustomBox = new System.Windows.Forms.CheckBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.LboxCustom = new System.Windows.Forms.TextBox();
            this.DelSpace = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(200, 11);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(438, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Генератор паролей соответствующих требованию безопасности";
            // 
            // Pbox
            // 
            this.Pbox.Location = new System.Drawing.Point(75, 130);
            this.Pbox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Pbox.Name = "Pbox";
            this.Pbox.ShortcutsEnabled = false;
            this.Pbox.Size = new System.Drawing.Size(132, 22);
            this.Pbox.TabIndex = 1;
            this.Pbox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Pbox_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(72, 110);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(142, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "P(Ввод в виде n*x^y)";
            // 
            // Vbox
            // 
            this.Vbox.Location = new System.Drawing.Point(75, 201);
            this.Vbox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Vbox.Name = "Vbox";
            this.Vbox.ShortcutsEnabled = false;
            this.Vbox.Size = new System.Drawing.Size(132, 22);
            this.Vbox.TabIndex = 3;
            this.Vbox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Vbox_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(128, 181);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(17, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "V";
            // 
            // Tbox
            // 
            this.Tbox.Location = new System.Drawing.Point(75, 298);
            this.Tbox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Tbox.Name = "Tbox";
            this.Tbox.ShortcutsEnabled = false;
            this.Tbox.Size = new System.Drawing.Size(132, 22);
            this.Tbox.TabIndex = 5;
            this.Tbox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Tbox_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 278);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(276, 17);
            this.label4.TabIndex = 6;
            this.label4.Text = "Т (Время действия пароля, в виде дней)";
            // 
            // GenerateButton
            // 
            this.GenerateButton.Location = new System.Drawing.Point(325, 412);
            this.GenerateButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.GenerateButton.Name = "GenerateButton";
            this.GenerateButton.Size = new System.Drawing.Size(136, 53);
            this.GenerateButton.TabIndex = 7;
            this.GenerateButton.Text = "Сгенерировать пароль";
            this.GenerateButton.UseVisualStyleBackColor = true;
            this.GenerateButton.Click += new System.EventHandler(this.GenerateButton_Click);
            // 
            // DigitsCheck
            // 
            this.DigitsCheck.AutoSize = true;
            this.DigitsCheck.Location = new System.Drawing.Point(311, 194);
            this.DigitsCheck.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.DigitsCheck.Name = "DigitsCheck";
            this.DigitsCheck.Size = new System.Drawing.Size(143, 21);
            this.DigitsCheck.TabIndex = 8;
            this.DigitsCheck.Text = "Добавить цифры";
            this.DigitsCheck.UseVisualStyleBackColor = true;
            this.DigitsCheck.CheckedChanged += new System.EventHandler(this.DigitsCheck_CheckedChanged);
            // 
            // SpecialCheck
            // 
            this.SpecialCheck.AutoSize = true;
            this.SpecialCheck.Location = new System.Drawing.Point(308, 242);
            this.SpecialCheck.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.SpecialCheck.Name = "SpecialCheck";
            this.SpecialCheck.Size = new System.Drawing.Size(190, 21);
            this.SpecialCheck.TabIndex = 9;
            this.SpecialCheck.Text = "Добавить спец.символы";
            this.SpecialCheck.UseVisualStyleBackColor = true;
            this.SpecialCheck.CheckedChanged += new System.EventHandler(this.SpecialCheck_CheckedChanged);
            // 
            // RuAplhaCheck
            // 
            this.RuAplhaCheck.AutoSize = true;
            this.RuAplhaCheck.Location = new System.Drawing.Point(311, 297);
            this.RuAplhaCheck.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.RuAplhaCheck.Name = "RuAplhaCheck";
            this.RuAplhaCheck.Size = new System.Drawing.Size(193, 21);
            this.RuAplhaCheck.TabIndex = 10;
            this.RuAplhaCheck.Text = "Добавить русские буквы";
            this.RuAplhaCheck.UseVisualStyleBackColor = true;
            this.RuAplhaCheck.CheckedChanged += new System.EventHandler(this.RuAplhaCheck_CheckedChanged);
            // 
            // PasswordBox
            // 
            this.PasswordBox.Location = new System.Drawing.Point(33, 501);
            this.PasswordBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.PasswordBox.Name = "PasswordBox";
            this.PasswordBox.Size = new System.Drawing.Size(547, 22);
            this.PasswordBox.TabIndex = 11;
            this.PasswordBox.TextChanged += new System.EventHandler(this.PasswordBox_TextChanged);
            this.PasswordBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.PasswordBox_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(249, 481);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(170, 17);
            this.label5.TabIndex = 12;
            this.label5.Text = "Сгенерированый пароль";
            // 
            // Lbox
            // 
            this.Lbox.Location = new System.Drawing.Point(75, 60);
            this.Lbox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Lbox.Name = "Lbox";
            this.Lbox.ShortcutsEnabled = false;
            this.Lbox.Size = new System.Drawing.Size(132, 22);
            this.Lbox.TabIndex = 13;
            this.Lbox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Lbox_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(128, 28);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(50, 17);
            this.label6.TabIndex = 14;
            this.label6.Text = "L(<50)";
            // 
            // GeneratedBox
            // 
            this.GeneratedBox.Location = new System.Drawing.Point(311, 122);
            this.GeneratedBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.GeneratedBox.Multiline = true;
            this.GeneratedBox.Name = "GeneratedBox";
            this.GeneratedBox.Size = new System.Drawing.Size(631, 64);
            this.GeneratedBox.TabIndex = 15;
            this.GeneratedBox.TextChanged += new System.EventHandler(this.GeneratedBox_TextChanged);
            this.GeneratedBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.GeneratedBox_KeyPress);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(347, 89);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(336, 17);
            this.label7.TabIndex = 16;
            this.label7.Text = "Символы, которые входят в генерацию пароля(A)";
            // 
            // Alabel
            // 
            this.Alabel.AutoSize = true;
            this.Alabel.Location = new System.Drawing.Point(641, 199);
            this.Alabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Alabel.Name = "Alabel";
            this.Alabel.Size = new System.Drawing.Size(25, 17);
            this.Alabel.TabIndex = 17;
            this.Alabel.Text = "A=";
            // 
            // PassCount
            // 
            this.PassCount.AutoSize = true;
            this.PassCount.Location = new System.Drawing.Point(604, 510);
            this.PassCount.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.PassCount.Name = "PassCount";
            this.PassCount.Size = new System.Drawing.Size(175, 17);
            this.PassCount.TabIndex = 18;
            this.PassCount.Text = "Кол-во символов пароля:";
            // 
            // ExportButton
            // 
            this.ExportButton.Location = new System.Drawing.Point(763, 322);
            this.ExportButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ExportButton.Name = "ExportButton";
            this.ExportButton.Size = new System.Drawing.Size(180, 96);
            this.ExportButton.TabIndex = 19;
            this.ExportButton.Text = "Экспортировать сгенерированный пароль в .txt файл";
            this.ExportButton.UseVisualStyleBackColor = true;
            this.ExportButton.Click += new System.EventHandler(this.ExportButton_Click);
            // 
            // HelpButton
            // 
            this.HelpButton.Location = new System.Drawing.Point(16, 5);
            this.HelpButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.HelpButton.Name = "HelpButton";
            this.HelpButton.Size = new System.Drawing.Size(100, 28);
            this.HelpButton.TabIndex = 20;
            this.HelpButton.Text = "Помощь";
            this.HelpButton.UseVisualStyleBackColor = true;
            this.HelpButton.Click += new System.EventHandler(this.HelpButton_Click);
            // 
            // MinuteCheck
            // 
            this.MinuteCheck.AutoSize = true;
            this.MinuteCheck.Location = new System.Drawing.Point(3, 6);
            this.MinuteCheck.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MinuteCheck.Name = "MinuteCheck";
            this.MinuteCheck.Size = new System.Drawing.Size(96, 21);
            this.MinuteCheck.TabIndex = 21;
            this.MinuteCheck.Text = "В минутах";
            this.MinuteCheck.UseVisualStyleBackColor = true;
            this.MinuteCheck.Click += new System.EventHandler(this.MinuteCheck_Click);
            // 
            // DayCheck
            // 
            this.DayCheck.AutoSize = true;
            this.DayCheck.Location = new System.Drawing.Point(4, 4);
            this.DayCheck.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.DayCheck.Name = "DayCheck";
            this.DayCheck.Size = new System.Drawing.Size(73, 21);
            this.DayCheck.TabIndex = 22;
            this.DayCheck.Text = "В днях";
            this.DayCheck.UseVisualStyleBackColor = true;
            this.DayCheck.CheckedChanged += new System.EventHandler(this.DayCheck_CheckedChanged);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.MinuteCheck);
            this.panel1.Location = new System.Drawing.Point(19, 233);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(109, 34);
            this.panel1.TabIndex = 23;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.DayCheck);
            this.panel2.Location = new System.Drawing.Point(132, 235);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(96, 36);
            this.panel2.TabIndex = 24;
            // 
            // DictionaryButton
            // 
            this.DictionaryButton.Location = new System.Drawing.Point(781, 245);
            this.DictionaryButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.DictionaryButton.Name = "DictionaryButton";
            this.DictionaryButton.Size = new System.Drawing.Size(145, 57);
            this.DictionaryButton.TabIndex = 25;
            this.DictionaryButton.Text = "Импортировать словарь в A";
            this.DictionaryButton.UseVisualStyleBackColor = true;
            this.DictionaryButton.Click += new System.EventHandler(this.DictionaryButton_Click);
            // 
            // AddEnglishAlpha
            // 
            this.AddEnglishAlpha.AutoSize = true;
            this.AddEnglishAlpha.Location = new System.Drawing.Point(311, 334);
            this.AddEnglishAlpha.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.AddEnglishAlpha.Name = "AddEnglishAlpha";
            this.AddEnglishAlpha.Size = new System.Drawing.Size(234, 21);
            this.AddEnglishAlpha.TabIndex = 26;
            this.AddEnglishAlpha.Text = "Добавить английский алфавит";
            this.AddEnglishAlpha.UseVisualStyleBackColor = true;
            this.AddEnglishAlpha.CheckedChanged += new System.EventHandler(this.AddEnglishAlpha_CheckedChanged);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.Pbox);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.panel2);
            this.panel3.Controls.Add(this.Vbox);
            this.panel3.Controls.Add(this.panel1);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.Tbox);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.Lbox);
            this.panel3.Location = new System.Drawing.Point(1, 41);
            this.panel3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(301, 364);
            this.panel3.TabIndex = 27;
            // 
            // CustomBox
            // 
            this.CustomBox.AutoSize = true;
            this.CustomBox.Location = new System.Drawing.Point(13, 412);
            this.CustomBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.CustomBox.Name = "CustomBox";
            this.CustomBox.Size = new System.Drawing.Size(272, 21);
            this.CustomBox.TabIndex = 28;
            this.CustomBox.Text = "Сгенерировать пароль без формулы";
            this.CustomBox.UseVisualStyleBackColor = true;
            this.CustomBox.CheckedChanged += new System.EventHandler(this.CustomBox_CheckedChanged);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.label8);
            this.panel4.Controls.Add(this.LboxCustom);
            this.panel4.Location = new System.Drawing.Point(16, 432);
            this.panel4.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(301, 44);
            this.panel4.TabIndex = 29;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(61, -1);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(152, 17);
            this.label8.TabIndex = 1;
            this.label8.Text = "Введите длину(до 50)";
            // 
            // LboxCustom
            // 
            this.LboxCustom.Location = new System.Drawing.Point(60, 16);
            this.LboxCustom.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.LboxCustom.Name = "LboxCustom";
            this.LboxCustom.ShortcutsEnabled = false;
            this.LboxCustom.Size = new System.Drawing.Size(132, 22);
            this.LboxCustom.TabIndex = 0;
            this.LboxCustom.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.LboxCustom_KeyPress);
            // 
            // DelSpace
            // 
            this.DelSpace.Location = new System.Drawing.Point(763, 89);
            this.DelSpace.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.DelSpace.Name = "DelSpace";
            this.DelSpace.Size = new System.Drawing.Size(164, 28);
            this.DelSpace.TabIndex = 30;
            this.DelSpace.Text = "Убрать пробелы";
            this.DelSpace.UseVisualStyleBackColor = true;
            this.DelSpace.Click += new System.EventHandler(this.DelSpace_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(979, 554);
            this.Controls.Add(this.DelSpace);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.CustomBox);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.AddEnglishAlpha);
            this.Controls.Add(this.DictionaryButton);
            this.Controls.Add(this.HelpButton);
            this.Controls.Add(this.ExportButton);
            this.Controls.Add(this.PassCount);
            this.Controls.Add(this.Alabel);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.GeneratedBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.PasswordBox);
            this.Controls.Add(this.RuAplhaCheck);
            this.Controls.Add(this.SpecialCheck);
            this.Controls.Add(this.DigitsCheck);
            this.Controls.Add(this.GenerateButton);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Генератор пароля ";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Pbox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Vbox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Tbox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button GenerateButton;
        private System.Windows.Forms.CheckBox DigitsCheck;
        private System.Windows.Forms.CheckBox SpecialCheck;
        private System.Windows.Forms.CheckBox RuAplhaCheck;
        private System.Windows.Forms.TextBox PasswordBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox Lbox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox GeneratedBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label Alabel;
        private System.Windows.Forms.Label PassCount;
        private System.Windows.Forms.Button ExportButton;
        private System.Windows.Forms.Button HelpButton;
        private System.Windows.Forms.CheckBox MinuteCheck;
        private System.Windows.Forms.CheckBox DayCheck;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button DictionaryButton;
        private System.Windows.Forms.CheckBox AddEnglishAlpha;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.CheckBox CustomBox;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox LboxCustom;
        private System.Windows.Forms.Button DelSpace;
    }
}

