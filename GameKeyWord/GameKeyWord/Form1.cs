using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GameKeyWord
{
    public partial class Form1 : Form
    {
        Random random = new Random();
        Stats stats = new Stats();
        //Timer timer1 = new Timer();
        
        class Stats
        {
            public int Total = 0;
            public int Missed = 0;
            public int Correct = 0;
            public int Accuracy = 0;

            public void Update(bool correctKey)
            {
                Total++;
                if (!correctKey)
                {
                    Missed++;
                }
                else
                {
                    Correct++;
                }
                Accuracy = 100 * Correct / (Missed + Correct);
            }
        }

        public Form1()
        {
            InitializeComponent();
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //Добавим случайную клавишу к элементу ListBox
              
            listBox1.Items.Add((Keys)random.Next(65, 90)); 
            this.KeyPreview = true;
            if (listBox1.Items.Count > 7)
            {
                listBox1.Items.Clear();
                listBox1.Items.Add("Игра окончена");
                timer1.Stop();
            }
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            //Если пользователь правильно нажимает клавишу, удалите букву из ListBox
            //и увеличьте скорость появления букв
            if (listBox1.Items.Contains(e.KeyCode))
            {
                listBox1.Items.Remove(e.KeyCode);
                listBox1.Refresh();
                if (timer1.Interval > 400)
                    timer1.Interval -= 10;
                if (timer1.Interval > 250)
                    timer1.Interval -= 7;
                if (timer1.Interval > 100)
                    timer1.Interval -= 2;
                difficultyProgressBar.Value = 800 - timer1.Interval;
                //При правильном нажатии клавиши обновляем обьект Stats
                //вызывая метод Update() с аргументом true
                stats.Update(true);
            }
            else
            {
                //При неправильном нажатии клавиши обновляем обьект Stats
                //вызывая метод Update() с аргументом false
                stats.Update(false);
            }
                correctLabel.Text = "Correct: " + stats.Correct;
                missedLabel.Text = "Missed: " + stats.Missed;
                totalLabel.Text = "Total: " + stats.Total;
                accuracyLabel.Text = "Accuracy: " + stats.Accuracy + "%";
            }
        }
    

    

}

