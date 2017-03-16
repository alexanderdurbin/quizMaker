namespace Math_Quiz
{
    partial class Form2
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
            this.qTypeLbl = new System.Windows.Forms.Label();
            this.answerLbl = new System.Windows.Forms.Label();
            this.typeInput = new System.Windows.Forms.TextBox();
            this.answerInput = new System.Windows.Forms.TextBox();
            this.questionSubmitBtn = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.imageLoadBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // qTypeLbl
            // 
            this.qTypeLbl.AutoSize = true;
            this.qTypeLbl.Location = new System.Drawing.Point(527, 12);
            this.qTypeLbl.Name = "qTypeLbl";
            this.qTypeLbl.Size = new System.Drawing.Size(243, 13);
            this.qTypeLbl.TabIndex = 0;
            this.qTypeLbl.Text = "Question Type (separate multiple types by comma)";
            // 
            // answerLbl
            // 
            this.answerLbl.AutoSize = true;
            this.answerLbl.Location = new System.Drawing.Point(527, 51);
            this.answerLbl.Name = "answerLbl";
            this.answerLbl.Size = new System.Drawing.Size(42, 13);
            this.answerLbl.TabIndex = 1;
            this.answerLbl.Text = "Answer";
            // 
            // typeInput
            // 
            this.typeInput.Location = new System.Drawing.Point(613, 28);
            this.typeInput.Name = "typeInput";
            this.typeInput.Size = new System.Drawing.Size(148, 20);
            this.typeInput.TabIndex = 2;
            // 
            // answerInput
            // 
            this.answerInput.Location = new System.Drawing.Point(613, 67);
            this.answerInput.Name = "answerInput";
            this.answerInput.Size = new System.Drawing.Size(148, 20);
            this.answerInput.TabIndex = 3;
            // 
            // questionSubmitBtn
            // 
            this.questionSubmitBtn.Location = new System.Drawing.Point(613, 287);
            this.questionSubmitBtn.Name = "questionSubmitBtn";
            this.questionSubmitBtn.Size = new System.Drawing.Size(148, 23);
            this.questionSubmitBtn.TabIndex = 4;
            this.questionSubmitBtn.Text = "Next Question";
            this.questionSubmitBtn.UseVisualStyleBackColor = true;
            this.questionSubmitBtn.Click += new System.EventHandler(this.questionSubmitBtn_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(487, 346);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(613, 316);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(148, 42);
            this.button1.TabIndex = 6;
            this.button1.Text = "Finish";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // imageLoadBtn
            // 
            this.imageLoadBtn.Location = new System.Drawing.Point(613, 256);
            this.imageLoadBtn.Name = "imageLoadBtn";
            this.imageLoadBtn.Size = new System.Drawing.Size(148, 25);
            this.imageLoadBtn.TabIndex = 7;
            this.imageLoadBtn.Text = "Load New Image";
            this.imageLoadBtn.UseVisualStyleBackColor = true;
            this.imageLoadBtn.Click += new System.EventHandler(this.imageLoadBtn_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(773, 401);
            this.Controls.Add(this.imageLoadBtn);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.questionSubmitBtn);
            this.Controls.Add(this.answerInput);
            this.Controls.Add(this.typeInput);
            this.Controls.Add(this.answerLbl);
            this.Controls.Add(this.qTypeLbl);
            this.Name = "Form2";
            this.Text = "Add Questions";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label qTypeLbl;
        private System.Windows.Forms.Label answerLbl;
        private System.Windows.Forms.TextBox typeInput;
        private System.Windows.Forms.TextBox answerInput;
        private System.Windows.Forms.Button questionSubmitBtn;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button imageLoadBtn;
    }
}