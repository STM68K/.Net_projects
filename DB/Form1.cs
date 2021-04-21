using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace WindowsFormsApp3
{


    public partial class Form1 : Form
    {
       Patient currOwner = null;
        Medic currCar = null;
        Diagnose currWorker = null;
        Visit currWork = null;
        public enum social { Студент, Пенсионер, Работает, Безработный }
        public enum sex { M,Ж}
        class Patient
        {
            public int Patkey { get; set; }
            public string Family { get; set; }
            public string Name { get; set; }
            public int BirthYear { get; set; }
            public string sex { get; set; }
            public string social { get; set; }






            public Patient(int patkey, string family, string name, int birthyear, string sexx, string a)
            {
                Patkey = patkey;
                Family = family;
                Name = name;
                BirthYear = birthyear;
                sex = sexx;
                social = a;

            }
        }
        class Medic
        {
            public int Medkey { get; set; }
            public string FIO { get; set; }
            public string Spec { get; set; }





            public Medic(int medkey, string fio, string spec)
            {
                Medkey = medkey;
                FIO = fio;
                Spec = spec;
            }
        }
        class Diagnose
        {
            public int DiagKey { get; set; }
            public string DiagName { get; set; }
            public string DiagSpec { get; set; }



            public Diagnose(int diagkey, string diagname, string diagspec)
            {
                DiagKey = diagkey;
                DiagName = diagname;
                DiagSpec = diagspec;
            }

        }
        class Visit
        {
            public int PatientKey { get; set; }
            public int MedToPatKey { get; set; }
            public int DiagToPatKey { get; set; }
            public DateTime DateVisit { get; set; }
            public int Bolntime { get; set; }



            public Visit(int patientopkey, int medtopatkey, int diagtopatkey, DateTime dateVisit, int bolntime)
            {
                PatientKey = patientopkey;
                MedToPatKey = medtopatkey;
                DiagToPatKey = diagtopatkey;
                DateVisit = dateVisit;
                Bolntime = bolntime;

            }
        }
        public int Id;
        public int Id1;
        public int Id2;

        static List<Patient> Lst1 = new List<Patient>();
        static List<Medic> Lst2 = new List<Medic>();
        static List<Diagnose> Lst3 = new List<Diagnose>();
        static List<Visit> Lst4 = new List<Visit>();
        private void Form1_Load(object sender, EventArgs e)
        {
            
            dataGridView1.DataSource = Lst1;
      
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.CurrentCell = dataGridView1.FirstDisplayedCell;
            dataGridView1.Columns[0].Visible = false;
            dataGridView1.Columns[1].HeaderText = "Фамилия";
            dataGridView1.Columns[1].Width = 100;
            dataGridView1.Columns[2].HeaderText = "Имя";
            dataGridView1.Columns[2].Width = 100;
            dataGridView1.Columns[3].HeaderText = "Год рождения";
            dataGridView1.Columns[3].Width = 100;
            dataGridView1.Columns[4].HeaderText = "Пол";
            dataGridView1.Columns[4].Width = 100;
            dataGridView1.Columns[5].HeaderText = "Социальное положение";
            dataGridView1.Columns[5].Width = 100;

            dataGridView2.DataSource = Lst2;
            dataGridView2.Columns[0].Visible = false;
            dataGridView2.Columns[1].HeaderText = "ФИО врача";
            dataGridView2.Columns[1].Width = 100;
            dataGridView2.Columns[2].HeaderText = "Специализация врача";
            dataGridView2.Columns[2].Width = 100;


            dataGridView3.DataSource = Lst3;
            dataGridView3.Columns[0].Visible = false;
            dataGridView3.Columns[1].HeaderText = "Название диагноза";
            dataGridView3.Columns[1].Width = 100;
            dataGridView3.Columns[2].HeaderText = "Вид диагноза";
            dataGridView3.Columns[2].Width = 100;



            comboBox1.DisplayMember = "Family";
            comboBox1.ValueMember = "Patkey";
            comboBox1.DataSource = Lst1;
            comboBox2.DisplayMember = "FIO";
            comboBox2.ValueMember = "Medkey";
            comboBox2.DataSource = Lst2;
            comboBox3.DisplayMember = "DiagName";
            comboBox3.ValueMember = "DiagKey";
            comboBox3.DataSource = Lst3;
            dataGridView4.AutoGenerateColumns = false;
            Column1.DisplayMember = "Family";
            Column1.ValueMember = "Patkey";
            Column1.DataSource = Lst1;
            Column2.DisplayMember = "FIO";
            Column2.ValueMember = "Medkey";
            Column2.DataSource = Lst2;
            Column6.DisplayMember = "DiagName";
            Column6.ValueMember = "DiagKey";
            Column6.DataSource = Lst3;
            dataGridView4.DataSource = Lst4;
            panel1.Enabled = false;
            panel4.Enabled = false;
            panel6.Enabled = false;
            panel7.Enabled = false;
            panel8.Enabled = false;
            comboBox4.DisplayMember = "Spec";
            comboBox4.ValueMember = "Medkey";
            comboBox4.DataSource = Lst2;
            comboBox6.DisplayMember = "FIO";
            comboBox6.ValueMember = "Medkey";
            comboBox6.DataSource = Lst2;
            comboBox5.DisplayMember = "Family";
            comboBox5.ValueMember = "Patkey";
            comboBox5.DataSource = Lst1;
         








        }

        public Form1()
        {

            string str;
            StreamReader ToCol = new StreamReader("Patient.txt", Encoding.UTF8);
            while ((str = ToCol.ReadLine()) != null)
            {

                string[] ms = str.Split('|');// разделение массива данніх на отдельніе строки
                this.Id = Convert.ToInt32(ms[0]);
                Lst1.Add(new Patient(Convert.ToInt32(ms[0]), Convert.ToString(ms[1]), Convert.ToString(ms[2]), Convert.ToInt32(ms[3]), Convert.ToString(ms[4]), Convert.ToString(ms[5])));
                //запись данніх в коллекцию

            }
            ToCol.Close();

            StreamReader ToCol1 = new StreamReader("Medic.txt", Encoding.UTF8);
            while ((str = ToCol1.ReadLine()) != null)
            {

                string[] ms = str.Split('|'); // разделение массива данніх на отдельніе строки
                this.Id1 = Convert.ToInt32(ms[0]);
                Lst2.Add(new Medic(Convert.ToInt32(ms[0]), ms[1], ms[2]));


            }
            StreamReader ToCol3 = new StreamReader("Diagnose.txt", Encoding.UTF8);
            while ((str = ToCol3.ReadLine()) != null)
            {

                string[] ms = str.Split('|');// разделение массива данніх на отдельніе строки
                this.Id2 = Convert.ToInt32(ms[0]);
                Lst3.Add(new Diagnose(Convert.ToInt32(ms[0]), ms[1], ms[2]));

                //запись данніх в коллекцию

            }
            StreamReader ToCol4 = new StreamReader("Visit.txt", Encoding.UTF8);
            while ((str = ToCol4.ReadLine()) != null)
            {

                string[] ms = str.Split('|');// разделение массива данніх на отдельніе строки
                Lst4.Add(new Visit(Convert.ToInt32(ms[0]), Convert.ToInt32(ms[1]), Convert.ToInt32(ms[2]), Convert.ToDateTime(ms[3]), Convert.ToInt32(ms[4])));

                //запись данніх в коллекцию
            }
            InitializeComponent();

        }

        private void button5_Click(object sender, EventArgs e) // Запрос для нахождения пациентов у врача по фио врача
        {
            var fio = comboBox6.Text;
            MessageBox.Show("Пациенты врача " + fio);
            var Patientfromname =
                                  from pat in Lst1
                                  from med in Lst2
                                  from diag in Lst3
                                  from visit in Lst4
                                  where pat.Patkey == visit.PatientKey && fio == med.FIO && visit.MedToPatKey == med.Medkey && diag.DiagKey == visit.DiagToPatKey
                                  select new { ФиоПациента = pat.Family, ДиагнозПациента = diag.DiagName };

            dataGridView5.DataSource = Patientfromname.ToList();

        }

        private void button6_Click(object sender, EventArgs e)// Запрос для нахождения врачей у пациента по фамилии пациента
        {
            var fam = comboBox5.Text;
            MessageBox.Show("Врачи по ФИО " + fam);
            var MedFromName =
                from pat in Lst1
                from med in Lst2
                from visit in Lst4
                where pat.Patkey == visit.PatientKey && med.Medkey == visit.MedToPatKey && fam == pat.Family
                select new { ФамилияМедика = med.FIO, СпециализацияМедика = med.Spec };

            dataGridView5.DataSource = MedFromName.ToList();
        }

        private void button8_Click(object sender, EventArgs e)//Запрос для нахождения пациентов по заданной специализации
        {

            var specs = comboBox4.Text;
            MessageBox.Show("Пациенты по специализации " + specs);

            var SpecsDocs =
                from pat in Lst1
                from med in Lst2
                from Diag in Lst3
                from visit in Lst4
                where pat.Patkey == visit.PatientKey && med.Medkey == visit.MedToPatKey && Diag.DiagKey == visit.DiagToPatKey && specs == med.Spec
                select new { ФиоВрача = med.FIO, ПациентВрача = pat.Family, ДиагнозВрача = Diag.DiagName };
            dataGridView5.DataSource = SpecsDocs.ToList();
        }

        private void dataGridView1_RowEnter(object sender, DataGridViewCellEventArgs e)// Метод присваивания значений из dataGridRow1 в textbox,combobox,etc...
        {
            textBox2.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            textBox3.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            textBox1.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            comboBox7.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
            comboBox8.Text = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();

        }

        private void dataGridView3_RowEnter(object sender, DataGridViewCellEventArgs e)// Метод присваивания значений из dataGridRow3 в textbox,combobox,etc...
        {
            textBox5.Text = dataGridView3.Rows[e.RowIndex].Cells[1].Value.ToString();
            textBox6.Text = dataGridView3.Rows[e.RowIndex].Cells[2].Value.ToString();
            
        }

        private void dataGridView2_RowEnter_1(object sender, DataGridViewCellEventArgs e)// Метод присваивания значений из dataGridRow2 в textbox,combobox,etc...
        {
            textBox7.Text = dataGridView2.Rows[e.RowIndex].Cells[1].Value.ToString();
            textBox10.Text = dataGridView2.Rows[e.RowIndex].Cells[2].Value.ToString();

        }

        private void dataGridView4_RowEnter_1(object sender, DataGridViewCellEventArgs e)// Метод присваивания значений из dataGridRow4 в textbox,combobox,etc...
        {
            comboBox1.SelectedIndex = Lst1.FindIndex(d => d.Patkey == Convert.ToInt32(dataGridView4.Rows[e.RowIndex].Cells[0].Value));
            comboBox2.SelectedIndex = Lst2.FindIndex(c => c.Medkey == Convert.ToInt32(dataGridView4.Rows[e.RowIndex].Cells[1].Value));
            comboBox3.SelectedIndex = Lst3.FindIndex(w => w.DiagKey == Convert.ToInt32(dataGridView4.Rows[e.RowIndex].Cells[2].Value));
            textBox13.Text = dataGridView4.Rows[e.RowIndex].Cells[4].Value.ToString();
            dateTimePicker1.Value = (DateTime)dataGridView4.Rows[e.RowIndex].Cells[3].Value;

        }



        private void button3_Click(object sender, EventArgs e)// Метод удаления врача из коллекции и тхт файла
        {
            int id_own = (int)dataGridView1.CurrentRow.Cells[0].Value;
            string message = (Lst1.Count(w => (w.Patkey == id_own)) > 0) ?
                "У данного пациента есть врач! Вы действительно хотите удалить пациента вместе с врачом?" :
                "Вы действительно хотите удалить пациента?";

            if (MessageBox.Show(message, "Подтверждение удаления", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                dataGridView4.DataSource = null;
                Column1.DataSource = null;
                Column2.DataSource = null;
                Lst1.RemoveAt(Lst1.FindIndex(d => (d.Patkey == id_own)));
                Lst2.RemoveAll(w => (w.Medkey == id_own));
                dataGridView1.DataSource = null;
                dataGridView1.DataSource = Lst1;
                dataGridView1.CurrentCell = dataGridView1.FirstDisplayedCell;
                Column1.DataSource = Lst1;
                Column2.DataSource = Lst2;
                Column1.DisplayMember = "Family";
                Column2.DisplayMember = "FIO";
                Column1.ValueMember = "Patkey";
                Column2.ValueMember = "Medkey";
                dataGridView4.DataSource = Lst4;
                comboBox1.DataSource = Lst1;
                comboBox1.DisplayMember = "Family";
                comboBox1.ValueMember = "Patkey";
                comboBox2.DataSource = Lst2;
                comboBox2.DisplayMember = "FIO";
                comboBox2.ValueMember = "Medkey";
            }
        }

        private void button1_Click(object sender, EventArgs e)//Кнопка добавления пациента в коллекцию и после в тхт файл(октрывает доступ к главной кнопке добавить/изменить)
        {


            panel1.Enabled = true;
            panel2.Enabled = false;
            button18.Text = button1.Text;
            textBox2.Text = null;
            textBox3.Text = null;
            dataGridView1.Enabled = false;
        }

        private void button19_Click(object sender, EventArgs e)//Кнопка отменить(возвращениe на базовые значения)
        {
            panel1.Enabled = false;
            panel2.Enabled = true;
            dataGridView1.Enabled = true;
            button18.Text = button2.Text;
            textBox2.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            textBox3.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
        }

        private void button18_Click(object sender, EventArgs e)// Кнопка добавить/изменить(в зависимости от контекста) для добавления или же изменения состояния коллекции и тхт файла
        {
            if (currOwner == null) // Добавляем отдел
            {
                int golden = this.Id + 1;

                Patient o = new Patient(golden, textBox3.Text, textBox2.Text, Convert.ToInt32(textBox1.Text), comboBox7.Text, comboBox8.Text);
                Lst1.Add(o);
                dataGridView1.CurrentCell = dataGridView1.FirstDisplayedCell;
                dataGridView1.Columns[0].Visible = false;
                dataGridView1.Columns[1].HeaderText = "Фамилия";
                dataGridView1.Columns[1].Width = 100;
                dataGridView1.Columns[2].HeaderText = "Имя";
                dataGridView1.Columns[2].Width = 100;
                dataGridView1.Columns[3].HeaderText = "Год рождения";
                dataGridView1.Columns[3].Width = 100;
                dataGridView1.Columns[4].HeaderText = "Пол";
                dataGridView1.Columns[4].Width = 100;
                dataGridView1.Columns[5].HeaderText = "Социальное положение";
                dataGridView1.Columns[5].Width = 100;
                dataGridView1.DataSource = null;
                dataGridView1.DataSource = Lst1;
                button18.Text = button2.Text;
                dataGridView1.Enabled = true;
                dataGridView1.CurrentCell = dataGridView1[1, dataGridView1.Rows.Count - 1];
            }
            else // Изменяем название отдела
            {
                currOwner.Name = textBox2.Text;
                currOwner.Family = textBox3.Text;
                currOwner.BirthYear = Convert.ToInt32(textBox1.Text);
                currOwner.sex = comboBox7.Text;
                currOwner.social = comboBox8.Text;
                dataGridView1.Enabled = true;
                dataGridView1.Refresh();
            }
            panel1.Enabled = false;
            panel2.Enabled = true;
        }

        private void button2_Click(object sender, EventArgs e)// Метод изменения данных в коллекции
        {
            panel1.Enabled = true;
            panel2.Enabled = false;
            currOwner = Lst1.Find(d => d.Patkey == (int)dataGridView1.CurrentRow.Cells[0].Value);
            dataGridView1.Enabled = false;
        }

        private void button4_Click(object sender, EventArgs e)// Метод перечитки тхт файлов и внесения их в dataGridView
        {
            dataGridView1.DataSource = null;
            dataGridView2.DataSource = null;
            dataGridView3.DataSource = null;
            dataGridView4.DataSource = null;
            Column1.DataSource = null;
            Column2.DataSource = null;
            Column6.DataSource = null;
            Lst1.Clear();
            Lst2.Clear();
            Lst3.Clear();
            Lst4.Clear();

            string str;
            using (StreamReader ToCol = new StreamReader("Patient.txt", Encoding.UTF8))
            {
                while ((str = ToCol.ReadLine()) != null)
                {

                    string[] ms = str.Split('|');// разделение массива данніх на отдельніе строки
                    this.Id = Convert.ToInt32(ms[0]);
                    Lst1.Add(new Patient(Convert.ToInt32(ms[0]), Convert.ToString(ms[1]), Convert.ToString(ms[2]), Convert.ToInt32(ms[3]), Convert.ToString(ms[4]), Convert.ToString(ms[5])));
                    //запись данніх в коллекцию

                }
            }
            

            using (StreamReader ToCol1 = new StreamReader("Medic.txt", Encoding.UTF8))
            {
                while ((str = ToCol1.ReadLine()) != null)
                {

                    string[] ms = str.Split('|'); // разделение массива данніх на отдельніе строки
                    this.Id1 = Convert.ToInt32(ms[0]);
                    Lst2.Add(new Medic(Convert.ToInt32(ms[0]), ms[1], ms[2]));


                }
            }
            using (StreamReader ToCol3 = new StreamReader("Diagnose.txt", Encoding.UTF8))
            {
                while ((str = ToCol3.ReadLine()) != null)
                {

                    string[] ms = str.Split('|');// разделение массива данніх на отдельніе строки
                    this.Id2 = Convert.ToInt32(ms[0]);
                    Lst3.Add(new Diagnose(Convert.ToInt32(ms[0]), ms[1], ms[2]));

                    //запись данніх в коллекцию

                }
            }
            using (StreamReader ToCol4 = new StreamReader("Visit.txt", Encoding.UTF8))
            {
                while ((str = ToCol4.ReadLine()) != null)
                {

                    string[] ms = str.Split('|');// разделение массива данніх на отдельніе строки
                    Lst4.Add(new Visit(Convert.ToInt32(ms[0]), Convert.ToInt32(ms[1]), Convert.ToInt32(ms[2]), Convert.ToDateTime(ms[3]), Convert.ToInt32(ms[4])));

                    //запись данніх в коллекцию
                }
            }
            dataGridView1.DataSource = Lst1;
            dataGridView2.DataSource = Lst2;
            dataGridView3.DataSource = Lst3;
            Column1.DisplayMember = "Family";
            Column1.ValueMember = "Patkey";
            Column1.DataSource = Lst1;
            Column2.DisplayMember = "FIO";
            Column2.ValueMember = "Medkey";
            Column2.DataSource = Lst2;
            Column6.DisplayMember = "DiagName";
            Column6.ValueMember = "DiagKey";
            Column6.DataSource = Lst3;
            dataGridView4.DataSource = Lst4;
           
            comboBox1.DisplayMember = "Family";
            comboBox1.ValueMember = "Patkey";
            comboBox1.DataSource = Lst1;
            comboBox2.DisplayMember = "FIO";
            comboBox2.ValueMember = "Medkey";
            comboBox2.DataSource = Lst2;
            comboBox3.DisplayMember = "DiagName";
            comboBox3.ValueMember = "DiagKey";
            comboBox3.DataSource = Lst3;
            /*emplComboBox.Items.Clear();
            foreach (Person p in ent.List_Person)
            {
                emplComboBox.Items.Add(p);
            }
            deptComboBox.Items.Clear();
            foreach (Department d in ent.List_Department)
            {
                deptComboBox.Items.Add(d);
            }
            postComboBox.Items.Clear();
            foreach (Post p in ent.List_Post)
            {
                postComboBox.Items.Add(p);
            }*/
            dataGridView1.CurrentCell = dataGridView1.FirstDisplayedCell;
            dataGridView2.CurrentCell = dataGridView2.FirstDisplayedCell;
            dataGridView3.CurrentCell = dataGridView3.FirstDisplayedCell;
            dataGridView4.CurrentCell = dataGridView4.FirstDisplayedCell;
            dataGridView3.Columns[0].Visible = false;
            dataGridView3.Columns[1].HeaderText = "Название диагноза";
            dataGridView3.Columns[1].Width = 100;
            dataGridView3.Columns[2].HeaderText = "Вид диагноза";
            dataGridView3.Columns[2].Width = 100;
            dataGridView2.Columns[0].Visible = false;
            dataGridView2.Columns[1].HeaderText = "ФИО врача";
            dataGridView2.Columns[1].Width = 100;
            dataGridView2.Columns[2].HeaderText = "Специализация врача";
            dataGridView2.Columns[2].Width = 100;


        }

        private void button7_Click(object sender, EventArgs e)// Метод записи текущего состояния dataGridView and lists в txt файл для дальнейшего считывания
        {
            using (StreamWriter WToCol = new StreamWriter("Patient.txt", false, Encoding.UTF8))
            {
                foreach (Patient b in Lst1)
                {
                    WToCol.WriteLine(b.Patkey + "|" + b.Family + "|" + b.Name+"|"+b.BirthYear+"|"+b.sex+"|"+b.social);
                }
            }
            using (StreamWriter WtoCol = new StreamWriter("Medic.txt", false, Encoding.UTF8))
            {
                foreach (Medic c in Lst2)
                {
                    WtoCol.WriteLine(c.Medkey + "|" + c.FIO + "|" + c.Spec);
                }
            }
            using (StreamWriter WtoCol = new StreamWriter("Diagnose.txt", false, Encoding.UTF8))
            {
                foreach (Diagnose w in Lst3)
                {
                    WtoCol.WriteLine(w.DiagKey + "|" + w.DiagName + "|" + w.DiagSpec);
                }
            }
            using (StreamWriter WtoCol = new StreamWriter("Visit.txt", false, Encoding.UTF8))
            {
                foreach (Visit ww in Lst4)
                {
                    WtoCol.WriteLine(ww.PatientKey + "|" + ww.MedToPatKey + "|" + ww.DiagToPatKey + "|" + ww.DateVisit + "|" + ww.Bolntime);
                }
            }





        }

        private void button11_Click(object sender, EventArgs e)//Метод добавления врача в коллекцию и после в тхт файл(октрывает доступ к главной кнопке добавить/изменить)
        {
            panel4.Enabled = true;
            panel3.Enabled = false;
            button20.Text = button11.Text;
            textBox7.Text = null;
            textBox10.Text = null;
            dataGridView2.Enabled = false;
        }

        private void button20_Click(object sender, EventArgs e)// Метод добавления/изменения( в зависимости от контекста) врача в коллекцию
        {
            if (currCar == null) // Добавляем отдел
            {
                int golden1 = this.Id1;
                Medic c = new Medic(golden1+1,textBox7.Text,textBox10.Text);
                Lst2.Add(c);
                dataGridView2.Columns[0].Visible = false;
                dataGridView2.Columns[1].HeaderText = "ФИО врача";
                dataGridView2.Columns[1].Width = 100;
                dataGridView2.Columns[2].HeaderText = "Специализация врача";
                dataGridView2.Columns[2].Width = 100;
                dataGridView2.DataSource = null;
                dataGridView2.DataSource = Lst2;
                button20.Text = button11.Text;
                dataGridView2.Enabled = true;
     
                //dataGridView2.CurrentCell = dataGridView2[1, dataGridView2.Rows.Count - 1];

            }
            else // Изменяем название отдела
            {
                currCar.FIO = textBox7.Text;
                currCar.Spec = textBox10.Text;
                dataGridView2.Enabled = true;
                dataGridView2.Refresh();
            }
            panel4.Enabled = false;
            panel3.Enabled = true;
        }

        private void button21_Click(object sender, EventArgs e)// Метод отмены состояния изменения/добавления и возврат к текущим позициям в dataGridView
        {
            panel4.Enabled = false;
            panel3.Enabled = true;
            dataGridView2.Enabled = true;
            button20.Text = button10.Text;
            textBox7.Text = dataGridView2.CurrentRow.Cells[1].Value.ToString();
            textBox10.Text = dataGridView2.CurrentRow.Cells[2].Value.ToString();
        }

        private void button9_Click(object sender, EventArgs e)// Метод удаления врача вместе с ассоциативным ему пациентом и очисткой коллекций
        {
            int id_own = (int)dataGridView2.CurrentRow.Cells[0].Value;
            string message = (Lst2.Count(w => (w.Medkey == id_own)) > 0) ?
                "У данного  врача есть пациент! Вы действительно хотите удалить врача вместе с пациентом?" :
                "Вы действительно хотите удалить врача?";

            if (MessageBox.Show(message, "Подтверждение удаления", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                dataGridView4.DataSource = null;
                Column1.DataSource = null;
                Column2.DataSource = null;
                Lst2.RemoveAt(Lst2.FindIndex(d => (d.Medkey == id_own)));
                Lst1.RemoveAll(w => (w.Patkey == id_own));
                dataGridView2.DataSource = null;
                dataGridView2.DataSource = Lst2;
                dataGridView2.CurrentCell = dataGridView2.FirstDisplayedCell;
                Column1.DataSource = Lst1;
                Column2.DataSource = Lst2;
                Column1.DisplayMember = "Family";
                Column2.DisplayMember = "FIO";
                Column1.ValueMember = "Patkey";
                Column2.ValueMember = "Medkey";
                dataGridView4.DataSource = Lst4;
                comboBox1.DataSource = Lst1;
                comboBox1.DisplayMember = "Family";
                comboBox1.ValueMember = "Medkey";
                comboBox2.DataSource = Lst2;
                comboBox2.DisplayMember = "FIO";
                comboBox2.ValueMember = "Medkey";
                dataGridView1.Columns[0].Visible = false;
                dataGridView1.Columns[1].HeaderText = "Фамилия";
                dataGridView1.Columns[1].Width = 100;
                dataGridView1.Columns[2].HeaderText = "Имя";
                dataGridView1.Columns[2].Width = 100;
                dataGridView1.Columns[3].HeaderText = "Год рождения";
                dataGridView1.Columns[3].Width = 100;
                dataGridView1.Columns[4].HeaderText = "Пол";
                dataGridView1.Columns[4].Width = 100;
                dataGridView1.Columns[5].HeaderText = "Социальное положение";
                dataGridView1.Columns[5].Width = 100;

            }
        }

        private void button10_Click(object sender, EventArgs e)// Метод, который открывает доступ к кнопке изменить
        {
            panel4.Enabled = true;
            panel3.Enabled = false;
            currCar = Lst2.Find(d => d.Medkey == (int)dataGridView2.CurrentRow.Cells[0].Value);
            dataGridView1.Enabled = false;
            button20.Text = button10.Text;
        }

        private void button14_Click(object sender, EventArgs e)//Метод добавления диагноза в коллекцию(октрывает доступ к главной кнопке добавить/изменить)
        {
            panel6.Enabled = true;
            panel5.Enabled = false;
            button22.Text = button14.Text;
            textBox5.Text = null;
            textBox6.Text = null;
            dataGridView3.Enabled = false;
        }

        private void button22_Click(object sender, EventArgs e)// Метод добавления/изменения(в зависимости от контекста) диагноза в коллекцию и dataGridView
        {
            if (currWorker == null) 
            {
                int golden2 = this.Id2 + 1;

                Diagnose w = new Diagnose(golden2,textBox5.Text,textBox6.Text);
                Lst3.Add(w);
                dataGridView3.Columns[0].Visible = false;
                dataGridView3.Columns[1].HeaderText = "Название диагноза";
                dataGridView3.Columns[1].Width = 100;
                dataGridView3.Columns[2].HeaderText = "Вид диагноза";
                dataGridView3.Columns[2].Width = 100;
                dataGridView3.DataSource = null;
                dataGridView3.DataSource = Lst3;
                button22.Text = button14.Text;
                dataGridView3.Enabled = true;
                dataGridView3.CurrentCell = dataGridView3[1, dataGridView3.Rows.Count - 1];
            }
            else // Изменяем название отдела
            {
                currWorker.DiagName = textBox5.Text;
                currWorker.DiagSpec = textBox6.Text;
                dataGridView3.Enabled = true;
                dataGridView3.Refresh();
            }
            panel6.Enabled = false;
            panel5.Enabled = true;
        }

        private void button13_Click(object sender, EventArgs e)// Метод изменить, который открывает доступ к главной кнопке изменить
        {
            panel6.Enabled = true;
            panel5.Enabled = false;
            currWorker = Lst3.Find(w => w.DiagKey == (int)dataGridView3.CurrentRow.Cells[0].Value);
            dataGridView3.Enabled = false;
            button22.Text = button13.Text;
        }

        private void button23_Click(object sender, EventArgs e)// Метод отмены, который откатывает пользователя от главной кнопки изменить/удалить и возвращает текущие данные
        {
            panel6.Enabled = false;
            panel5.Enabled = true;
            dataGridView3.Enabled = true;
            button22.Text = button14.Text;
            textBox5.Text = dataGridView3.CurrentRow.Cells[1].Value.ToString();
            textBox6.Text = dataGridView3.CurrentRow.Cells[2].Value.ToString();

        }

        private void button12_Click(object sender, EventArgs e)// Метод удаления диагноза из коллекций и dataGridView
        {
            int id_work = (int)dataGridView3.CurrentRow.Cells[0].Value;
            string message = (Lst3.Count(w => (w.DiagKey == id_work)) > 0) ?
                "У данного  диагноза есть пациент! Вы действительно хотите удалить диагноз?" :
                "Вы действительно хотите удалить диагноз??";

            if (MessageBox.Show(message, "Подтверждение удаления", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                dataGridView4.DataSource = null;
                Column1.DataSource = null;
                Column2.DataSource = null;
                Lst3.RemoveAt(Lst3.FindIndex(d => (d.DiagKey == id_work)));
                Lst4.RemoveAll(w => (w.DiagToPatKey == id_work));
                dataGridView3.DataSource = null;
                dataGridView3.DataSource = Lst3;
                dataGridView3.CurrentCell = dataGridView3.FirstDisplayedCell;
                Column1.DataSource = Lst1;
                Column2.DataSource = Lst2;
                Column1.DisplayMember = "Family";
                Column2.DisplayMember = "FIO";
                Column1.ValueMember = "Patkey";
                Column2.ValueMember = "Medkey";
                dataGridView4.DataSource = Lst4;
                comboBox1.DataSource = Lst1;
                comboBox1.DisplayMember = "Family";
                comboBox1.ValueMember = "Patkey";
                comboBox2.DataSource = Lst2;
                comboBox2.DisplayMember = "FIO";
                comboBox2.ValueMember = "Medkey";
                dataGridView3.Columns[0].Visible = false;
                dataGridView3.Columns[1].HeaderText = "Название диагноза";
                dataGridView3.Columns[1].Width = 100;
                dataGridView3.Columns[2].HeaderText = "Вид диагноза";
                dataGridView3.Columns[2].Width = 100;

            }
        }

        private void button17_Click(object sender, EventArgs e)//Метод добавления, который открывает доступ к панели с главной кнопкой изменить/удалить( в зависимости от контекста)
        {
            panel7.Enabled = true;
            panel8.Enabled = true;
            panel9.Enabled = false;
           comboBox1.SelectedIndex = -1;
            comboBox2.SelectedIndex = -1;
            comboBox3.SelectedIndex = -1;
            textBox13.Text = null;
            dateTimePicker1.Text = null;
            dataGridView4.Enabled = false;
        }

        private void button16_Click(object sender, EventArgs e)// Метод изменения, который открывает доступ к панели с главной кнопкой изменения
        {
           panel8.Enabled = true;
            panel9.Enabled = false;
            panel7.Enabled = true;
            dataGridView4.Enabled = false;
        }

        private void button15_Click(object sender, EventArgs e)// Метод удаления записи о работе сотрудника
        {
            if (MessageBox.Show("Вы действительно хотите удалить запись о работе сотрудника?", "Подтверждение удаления", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Lst4.RemoveAt(dataGridView4.CurrentCellAddress.Y);
                dataGridView4.DataSource = null;
                dataGridView4.DataSource = Lst4;
               dataGridView4.CurrentCell = dataGridView4.FirstDisplayedCell;
            }

        }

        private void button24_Click(object sender, EventArgs e)// Метод добавления работы сотрудника
        {
            if (currWork==null) // Добавляем работу сотрудника
            {
               
                
               dataGridView4.DataSource = null;
                dataGridView4.DataSource = Lst4;
                button24.Text = button17.Text;
                dataGridView4.Enabled = true;
                dataGridView4.CurrentCell = dataGridView4[1, dataGridView4.Rows.Count - 1];
            }
            else // Изменяем работу сотрудника
            {
         
                currWork.MedToPatKey =(int)(comboBox2.SelectedValue);
                currWork.PatientKey = (int)(comboBox1.SelectedValue);
                currWork.DiagToPatKey = (int)(comboBox3.SelectedValue);
                currWork.Bolntime = Convert.ToInt32(textBox13.Text);
                currWork.DateVisit = dateTimePicker1.Value;
                dataGridView4.Enabled = true;
                dataGridView4.Refresh();
            }
           panel8.Enabled = false;
            panel7.Enabled = false;
            panel6.Enabled = true;
        }

        private void button25_Click(object sender, EventArgs e)// Метод отмены и перенос доступа пользователя от главного меню к побочным и откат изменений с возвратом к прежним данным
        {
            panel8.Enabled = false;
            panel7.Enabled=true;
            panel6.Enabled=true;
            dataGridView4.Enabled = true;
            button24.Text = button16.Text;
            comboBox1.SelectedIndex = Lst4.FindIndex(p => p.PatientKey == (int)dataGridView4.CurrentRow.Cells[0].Value);
            comboBox2.SelectedIndex = Lst4.FindIndex(d => d.MedToPatKey == (int)dataGridView4.CurrentRow.Cells[1].Value);
            comboBox3.SelectedIndex = Lst4.FindIndex(p => p.DiagToPatKey == (int)dataGridView4.CurrentRow.Cells[5].Value);
           textBox13.Text = dataGridView4.CurrentRow.Cells[2].Value.ToString();
            dateTimePicker1.Value = (DateTime)dataGridView4.CurrentRow.Cells[4].Value;
        }
        }
    }


        
    








   

