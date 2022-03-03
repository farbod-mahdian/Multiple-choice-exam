
namespace Lab4
{
    partial class Form_question
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.lbl_qNumber = new System.Windows.Forms.Label();
            this.lbl_question = new System.Windows.Forms.Label();
            this.rBtn_opt1 = new System.Windows.Forms.RadioButton();
            this.rBtn_opt2 = new System.Windows.Forms.RadioButton();
            this.rBtn_opt3 = new System.Windows.Forms.RadioButton();
            this.lbl_tLeft = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.btn_submit = new System.Windows.Forms.Button();
            this.btn_next = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.btn_result = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_qNumber
            // 
            this.lbl_qNumber.AutoSize = true;
            this.lbl_qNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_qNumber.Location = new System.Drawing.Point(121, 9);
            this.lbl_qNumber.Name = "lbl_qNumber";
            this.lbl_qNumber.Size = new System.Drawing.Size(24, 25);
            this.lbl_qNumber.TabIndex = 0;
            this.lbl_qNumber.Text = "1";
            // 
            // lbl_question
            // 
            this.lbl_question.AutoSize = true;
            this.lbl_question.Location = new System.Drawing.Point(12, 39);
            this.lbl_question.Name = "lbl_question";
            this.lbl_question.Size = new System.Drawing.Size(55, 13);
            this.lbl_question.TabIndex = 1;
            this.lbl_question.Text = "Question1";
            // 
            // rBtn_opt1
            // 
            this.rBtn_opt1.AutoSize = true;
            this.rBtn_opt1.Location = new System.Drawing.Point(38, 90);
            this.rBtn_opt1.Name = "rBtn_opt1";
            this.rBtn_opt1.Size = new System.Drawing.Size(85, 17);
            this.rBtn_opt1.TabIndex = 2;
            this.rBtn_opt1.TabStop = true;
            this.rBtn_opt1.Text = "radioButton1";
            this.rBtn_opt1.UseVisualStyleBackColor = true;
            // 
            // rBtn_opt2
            // 
            this.rBtn_opt2.AutoSize = true;
            this.rBtn_opt2.Location = new System.Drawing.Point(38, 113);
            this.rBtn_opt2.Name = "rBtn_opt2";
            this.rBtn_opt2.Size = new System.Drawing.Size(85, 17);
            this.rBtn_opt2.TabIndex = 3;
            this.rBtn_opt2.TabStop = true;
            this.rBtn_opt2.Text = "radioButton2";
            this.rBtn_opt2.UseVisualStyleBackColor = true;
            // 
            // rBtn_opt3
            // 
            this.rBtn_opt3.AutoSize = true;
            this.rBtn_opt3.Location = new System.Drawing.Point(38, 136);
            this.rBtn_opt3.Name = "rBtn_opt3";
            this.rBtn_opt3.Size = new System.Drawing.Size(85, 17);
            this.rBtn_opt3.TabIndex = 4;
            this.rBtn_opt3.TabStop = true;
            this.rBtn_opt3.Text = "radioButton3";
            this.rBtn_opt3.UseVisualStyleBackColor = true;
            // 
            // lbl_tLeft
            // 
            this.lbl_tLeft.AutoSize = true;
            this.lbl_tLeft.Location = new System.Drawing.Point(35, 200);
            this.lbl_tLeft.Name = "lbl_tLeft";
            this.lbl_tLeft.Size = new System.Drawing.Size(124, 13);
            this.lbl_tLeft.TabIndex = 5;
            this.lbl_tLeft.Text = "Time Left => 10 seconds";
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(180, 196);
            this.progressBar1.Maximum = 5;
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(100, 23);
            this.progressBar1.Step = 1;
            this.progressBar1.TabIndex = 6;
            // 
            // btn_submit
            // 
            this.btn_submit.Location = new System.Drawing.Point(48, 243);
            this.btn_submit.Name = "btn_submit";
            this.btn_submit.Size = new System.Drawing.Size(75, 23);
            this.btn_submit.TabIndex = 7;
            this.btn_submit.Text = "Submit";
            this.btn_submit.UseVisualStyleBackColor = true;
            this.btn_submit.Click += new System.EventHandler(this.btn_submit_Click);
            // 
            // btn_next
            // 
            this.btn_next.Location = new System.Drawing.Point(188, 243);
            this.btn_next.Name = "btn_next";
            this.btn_next.Size = new System.Drawing.Size(75, 23);
            this.btn_next.TabIndex = 8;
            this.btn_next.Text = "Next";
            this.btn_next.UseVisualStyleBackColor = true;
            this.btn_next.Click += new System.EventHandler(this.btn_next_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(10, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 25);
            this.label1.TabIndex = 9;
            this.label1.Text = "Question #";
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(200, 184);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 12);
            this.label2.TabIndex = 10;
            this.label2.Text = "% Completed";
            // 
            // btn_result
            // 
            this.btn_result.Location = new System.Drawing.Point(49, 244);
            this.btn_result.Name = "btn_result";
            this.btn_result.Size = new System.Drawing.Size(215, 23);
            this.btn_result.TabIndex = 12;
            this.btn_result.Text = "Result";
            this.btn_result.UseVisualStyleBackColor = true;
            this.btn_result.Visible = false;
            this.btn_result.Click += new System.EventHandler(this.btn_result_Click);
            // 
            // Form_question
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(320, 277);
            this.Controls.Add(this.btn_result);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbl_qNumber);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_next);
            this.Controls.Add(this.btn_submit);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.lbl_tLeft);
            this.Controls.Add(this.rBtn_opt3);
            this.Controls.Add(this.rBtn_opt2);
            this.Controls.Add(this.rBtn_opt1);
            this.Controls.Add(this.lbl_question);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form_question";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Test";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form_question_FormClosed);
            this.Load += new System.EventHandler(this.Form_question_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_qNumber;
        private System.Windows.Forms.Label lbl_question;
        private System.Windows.Forms.RadioButton rBtn_opt1;
        private System.Windows.Forms.RadioButton rBtn_opt2;
        private System.Windows.Forms.RadioButton rBtn_opt3;
        private System.Windows.Forms.Label lbl_tLeft;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Button btn_submit;
        private System.Windows.Forms.Button btn_next;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_result;
    }
}