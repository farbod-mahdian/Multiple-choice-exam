
namespace Lab4
{
    partial class Form_inst
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_inst));
            this.lbl_inst = new System.Windows.Forms.Label();
            this.btn_start = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_inst
            // 
            this.lbl_inst.AutoSize = true;
            this.lbl_inst.BackColor = System.Drawing.Color.SeaShell;
            this.lbl_inst.Location = new System.Drawing.Point(28, 20);
            this.lbl_inst.Name = "lbl_inst";
            this.lbl_inst.Size = new System.Drawing.Size(259, 221);
            this.lbl_inst.TabIndex = 0;
            this.lbl_inst.Text = resources.GetString("lbl_inst.Text");
            // 
            // btn_start
            // 
            this.btn_start.Location = new System.Drawing.Point(30, 249);
            this.btn_start.Name = "btn_start";
            this.btn_start.Size = new System.Drawing.Size(256, 23);
            this.btn_start.TabIndex = 1;
            this.btn_start.Text = "Start";
            this.btn_start.UseVisualStyleBackColor = true;
            this.btn_start.Click += new System.EventHandler(this.btn_start_Click);
            // 
            // Form_inst
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(315, 277);
            this.Controls.Add(this.btn_start);
            this.Controls.Add(this.lbl_inst);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form_inst";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Instruction";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_inst;
        private System.Windows.Forms.Button btn_start;
    }
}

