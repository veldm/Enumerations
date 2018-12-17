using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Enumerations;

namespace Casting
{
    public partial class Form1 : Form
    {
        public static Person[] Candidats = new Person[1];

        public Form1()
        {
            InitializeComponent();
            try
            {
                StreamReader F = new StreamReader("Candidats.txt");
                int i = 0; string S = "";
                while (S != null)
                {
                    S = F.ReadLine();
                    if (S == null)
                    {
                        if (i == 0)
                        {
                            MessageBox.Show("Файл с данными о кандидатах пуст", "Ошибка",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                        break;
                    }
                    if (i > 0) Array.Resize<Person>(ref Candidats, Candidats.Length + 1);
                    try
                    {
                        string[] BufMas = S.Split(' ');
                        Candidats[i] = new Person((Languages)int.Parse(BufMas[1]), BufMas[0]);
                        i++;
                    }
                    catch
                    {
                        MessageBox.Show("Невозможно корректно прочитать данные из файла" + (char)13 +
                            "Возможно файл недоступен или данные были записаны некорректно", "Ошибка",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                        Candidats = null;
                        return;
                    }
                }
            }
            catch
            {
                MessageBox.Show("Отсутствует текстовый файл с данными о кандидатах",
                    "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Candidats = null;
                return;
            }
        }

        private void RunButton_Click(object sender, EventArgs e)
        {
            bool RequireAll;
            if (RequireInputTB.Text == "всеми") RequireAll = true;
            else if (RequireInputTB.Text == "одним из") RequireAll = false;
            else
            {
                MessageBox.Show("Некорректно задана строгость требований к кандидатам" + (char)13 +
                    "Выберите вариант из списка", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            OutputTB.Text = "";
            int Pattern = 0;
            if (CS_CB.Checked) Pattern += 1;
            if (CPP_CB.Checked) Pattern += 2;
            if (VB_CB.Checked) Pattern += 4;
            if (Assembler_CB.Checked) Pattern += 8;
            if (Java_CB.Checked) Pattern += 16;
            if (Python_CB.Checked) Pattern += 32;
            if (Ruby_CB.Checked) Pattern += 64;
            if (Lisp_CB.Checked) Pattern += 128;
            if (SQL_CB.Checked) Pattern += 256;
            if (Pattern == 0)
            {
                MessageBox.Show("Требования не заданы", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                for (int i = 0; i < Candidats.Length; i++)
                {
                    if ((RequireAll && Candidats[i].IsEqual((Languages)Pattern)) ||
                        (!RequireAll && Candidats[i].IsPartialyEqual((Languages)Pattern)))
                        OutputTB.Text += Candidats[i].Name + '\r' + '\n';
                }
                if (OutputTB.Text == "") OutputTB.Text =
                        "Кандидатов, удовлетворяющих заданным требованиям в списке не обнаружено";
            }
        }
    }
}
