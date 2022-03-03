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

// GlobalValv is declared in the "Program.cs" file

namespace Lab4
{
    public partial class Form_question : Form
    {
        double score = 0; // Score out of 5
        int question_n = 0, timer_count = 0; // Question number and timer counter

        class question_
        {
            public string q_text;
            public string[] q_options = new string[3];
            public int answer; // 1,2,3

            public question_(string q_t, string q_opt1, string q_opt2, string q_opt3, int ans)
            {
                q_text = q_t;

                q_options[0] = q_opt1;
                q_options[1] = q_opt2;
                q_options[2] = q_opt3;

                answer = ans;
            }
        }

        question_[] qu = new question_[5]; // 5 objects for 5 questions

        public Form_question()
        {
            InitializeComponent();
        }

        void insert(int q_num, question_ qu_input) // Function to do all of tasks in order to insert a question's information in the form
        {
            lbl_qNumber.Text = q_num.ToString();

            lbl_question.Text = qu_input.q_text;

            rBtn_opt1.Text = qu_input.q_options[0];
            rBtn_opt2.Text = qu_input.q_options[1];
            rBtn_opt3.Text = qu_input.q_options[2];
        }

        private void Form_question_Load(object sender, EventArgs e)
        {
            btn_next.Enabled = false;

            // Uncheck all of the radiobuttons
            rBtn_opt1.AutoCheck = false;
            rBtn_opt1.AutoCheck = true;

            // Filling objects with question's information
            qu[0] = new question_("Which method is the correct method to declare a refrence \nfor an array of an ineteger?", "(A) int[] i;", "(B) int i[];", "(C) int new i[];", 1);
            qu[1] = new question_("What provides a collection of objects that can be dragged \nand dropped onto a form?", "(A) Solution Explorer", "(B) Properties Window", "(C) Toolbox", 3);
            qu[2] = new question_("How can we access the content of a textbox?", "(A) txtbox.Text", "(B) txtbox.Text()", "(C) txtbox.Content", 1);
            qu[3] = new question_("Which option is the correct one to show a modal form?", "(A) frm1.Show()", "(B) frm1.ShowDialog()", "(C) frm1.Display()", 2);
            qu[4] = new question_("Which library should be added to a program in order to \nuse 'Interaction.InputBox();'?", "(A) Microsof.Build", "(B) Microsoft.JScript", "(C) Microsoft.VisualBasic", 3);

            insert(1, qu[0]); // Put the question in the form
            progressBar1.Value = 1;

            timer1.Start();
            GlobalValv.rchTxt_result = new RichTextBox(); // A richtextbox to store the wrong questions with their correct answers
        }

        private void btn_next_Click(object sender, EventArgs e)
        {
            btn_submit.Enabled = true;
            btn_next.Enabled = false;

            lbl_tLeft.Text = "Time Left => 10 seconds";

            progressBar1.Value++;

            rBtn_opt1.Enabled = true;
            rBtn_opt2.Enabled = true;
            rBtn_opt3.Enabled = true;

            rBtn_opt1.Checked = false;
            rBtn_opt2.Checked = false;
            rBtn_opt3.Checked = false;

            insert(question_n + 1, qu[question_n]);

            timer_count = 0;
            timer1.Start();
        }

        private void btn_submit_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            btn_next.Enabled = true;
            btn_submit.Enabled = false;

            rBtn_opt1.Enabled = false;
            rBtn_opt2.Enabled = false;
            rBtn_opt3.Enabled = false;

            switch (qu[question_n].answer) // Checking the user's answer and calculate the mark for that question and write in the richtextbox if the answer was incorrect
            {
                case 1:
                    if (rBtn_opt1.Checked)
                        score++;
                    else
                        // If the answer was incorrect, write it in the richtextbox
                        GlobalValv.rchTxt_result.AppendText("Question: " + qu[question_n].q_text + "\nCorrect answer: " + qu[question_n].q_options[qu[question_n].answer - 1] + "\n\n");
                    break;

                case 2:
                    if (rBtn_opt2.Checked)
                        score++;
                    else
                        GlobalValv.rchTxt_result.AppendText("Question: " + qu[question_n].q_text + "\nCorrect answer: " + qu[question_n].q_options[qu[question_n].answer - 1] + "\n\n");
                    break;

                case 3:
                    if (rBtn_opt3.Checked)
                        score++;
                    else
                        GlobalValv.rchTxt_result.AppendText("Question: " + qu[question_n].q_text + "\nCorrect answer: " + qu[question_n].q_options[qu[question_n].answer - 1] + "\n\n");
                    break;
            }
            question_n++;

            if (question_n > 4) // Check if all of the questions were completed
            {
                btn_next.Enabled = false;

                rBtn_opt1.Enabled = false;
                rBtn_opt2.Enabled = false;
                rBtn_opt3.Enabled = false;

                btn_submit.Visible = false;
                btn_next.Visible = false;

                btn_result.Visible = true; // The button to open the result form

                GlobalValv.mark = (score / 5) * 100; // Calculating the mark in percentage

                StreamWriter result_file = new StreamWriter("test_result.txt", true); // Writing user's name, ID and mark in a text file

                result_file.WriteLine("Name: " + GlobalValv.user_);
                result_file.WriteLine("ID: " + GlobalValv.id);
                result_file.WriteLine("Score is: " + GlobalValv.mark.ToString("0.00") + "\n");

                result_file.Close();
            }
        }

        private void Form_question_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void btn_result_Click(object sender, EventArgs e)
        {
            GlobalValv.rchTxt_result.AppendText("Your score is: " + GlobalValv.mark.ToString("0.00") + "%\n");

            Form_result frm_result = new Form_result();
            this.Hide();
            frm_result.ShowDialog();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer_count++;
            lbl_tLeft.Text = "Time Left => " + (10 - timer_count) + " seconds";
            if (timer_count > 9)
            {
                timer1.Stop();

                rBtn_opt1.Checked = false;
                rBtn_opt2.Checked = false;
                rBtn_opt3.Checked = false;

                rBtn_opt1.Enabled = false;
                rBtn_opt2.Enabled = false;
                rBtn_opt3.Enabled = false;

                btn_submit.PerformClick();
                btn_submit.Enabled = false;

                btn_next.Enabled = true;
            }
        }
    }
}
