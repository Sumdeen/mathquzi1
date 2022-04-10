
namespace MathQuiz__01
{
    partial class Form1
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
            this.lblScore = new System.Windows.Forms.Label();
            this.lblNumA = new System.Windows.Forms.Label();
            this.lblSymbol = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblNumB = new System.Windows.Forms.Label();
            this.lblAnswer = new System.Windows.Forms.Label();
            this.txtAnswer = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblScore
            // 
            this.lblScore.AutoSize = true;
            this.lblScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblScore.ForeColor = System.Drawing.Color.Maroon;
            this.lblScore.Location = new System.Drawing.Point(33, 30);
            this.lblScore.Name = "lblScore";
            this.lblScore.Size = new System.Drawing.Size(76, 20);
            this.lblScore.TabIndex = 0;
            this.lblScore.Text = "Score: 0";
            // 
            // lblNumA
            // 
            this.lblNumA.AutoSize = true;
            this.lblNumA.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumA.Location = new System.Drawing.Point(30, 79);
            this.lblNumA.Name = "lblNumA";
            this.lblNumA.Size = new System.Drawing.Size(51, 36);
            this.lblNumA.TabIndex = 1;
            this.lblNumA.Text = "00";
            // 
            // lblSymbol
            // 
            this.lblSymbol.AutoSize = true;
            this.lblSymbol.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSymbol.Location = new System.Drawing.Point(99, 79);
            this.lblSymbol.Name = "lblSymbol";
            this.lblSymbol.Size = new System.Drawing.Size(33, 36);
            this.lblSymbol.TabIndex = 2;
            this.lblSymbol.Text = "+";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(227, 79);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 36);
            this.label4.TabIndex = 3;
            this.label4.Text = "=";
            // 
            // lblNumB
            // 
            this.lblNumB.AutoSize = true;
            this.lblNumB.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumB.Location = new System.Drawing.Point(138, 82);
            this.lblNumB.Name = "lblNumB";
            this.lblNumB.Size = new System.Drawing.Size(51, 36);
            this.lblNumB.TabIndex = 4;
            this.lblNumB.Text = "00";
            // 
            // lblAnswer
            // 
            this.lblAnswer.AutoSize = true;
            this.lblAnswer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAnswer.ForeColor = System.Drawing.Color.LawnGreen;
            this.lblAnswer.Location = new System.Drawing.Point(32, 142);
            this.lblAnswer.Name = "lblAnswer";
            this.lblAnswer.Size = new System.Drawing.Size(68, 20);
            this.lblAnswer.TabIndex = 5;
            this.lblAnswer.Text = "Correct";
            this.lblAnswer.Click += new System.EventHandler(this.lblAnswer_Click);
            // 
            // txtAnswer
            // 
            this.txtAnswer.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAnswer.Location = new System.Drawing.Point(275, 79);
            this.txtAnswer.Name = "txtAnswer";
            this.txtAnswer.Size = new System.Drawing.Size(94, 41);
            this.txtAnswer.TabIndex = 6;
            this.txtAnswer.TextChanged += new System.EventHandler(this.CheckAnswer);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(391, 79);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(93, 41);
            this.button1.TabIndex = 7;
            this.button1.Text = "Check";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.RoyalBlue;
            this.ClientSize = new System.Drawing.Size(555, 286);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtAnswer);
            this.Controls.Add(this.lblAnswer);
            this.Controls.Add(this.lblNumB);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblSymbol);
            this.Controls.Add(this.lblNumA);
            this.Controls.Add(this.lblScore);
            this.Name = "Form1";
            this.Text = "Maths Quiz Game";
            this.Click += new System.EventHandler(this.CheckButton);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblScore;
        private System.Windows.Forms.Label lblNumA;
        private System.Windows.Forms.Label lblSymbol;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblNumB;
        private System.Windows.Forms.Label lblAnswer;
        private System.Windows.Forms.TextBox txtAnswer;
        private System.Windows.Forms.Button button1;
    }
}

