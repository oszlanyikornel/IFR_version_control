namespace week7
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
            this.label1 = new System.Windows.Forms.Label();
            this.endYearInput = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.fileTxtBox = new System.Windows.Forms.TextBox();
            this.brosweBtn = new System.Windows.Forms.Button();
            this.startBtn = new System.Windows.Forms.Button();
            this.resutRichTxtBox = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.endYearInput)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Záróév";
            // 
            // endYearInput
            // 
            this.endYearInput.Location = new System.Drawing.Point(60, 12);
            this.endYearInput.Maximum = new decimal(new int[] {
            2050,
            0,
            0,
            0});
            this.endYearInput.Minimum = new decimal(new int[] {
            2005,
            0,
            0,
            0});
            this.endYearInput.Name = "endYearInput";
            this.endYearInput.Size = new System.Drawing.Size(65, 20);
            this.endYearInput.TabIndex = 1;
            this.endYearInput.Value = new decimal(new int[] {
            2025,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(157, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Népesség fájl";
            // 
            // fileTxtBox
            // 
            this.fileTxtBox.Location = new System.Drawing.Point(236, 10);
            this.fileTxtBox.Name = "fileTxtBox";
            this.fileTxtBox.Size = new System.Drawing.Size(100, 20);
            this.fileTxtBox.TabIndex = 3;
            // 
            // brosweBtn
            // 
            this.brosweBtn.Location = new System.Drawing.Point(371, 9);
            this.brosweBtn.Name = "brosweBtn";
            this.brosweBtn.Size = new System.Drawing.Size(75, 23);
            this.brosweBtn.TabIndex = 4;
            this.brosweBtn.Text = "Broswe";
            this.brosweBtn.UseVisualStyleBackColor = true;
            this.brosweBtn.Click += new System.EventHandler(this.brosweBtn_Click);
            // 
            // startBtn
            // 
            this.startBtn.Location = new System.Drawing.Point(469, 9);
            this.startBtn.Name = "startBtn";
            this.startBtn.Size = new System.Drawing.Size(75, 23);
            this.startBtn.TabIndex = 5;
            this.startBtn.Text = "Start";
            this.startBtn.UseVisualStyleBackColor = true;
            this.startBtn.Click += new System.EventHandler(this.startBtn_Click);
            // 
            // resutRichTxtBox
            // 
            this.resutRichTxtBox.Location = new System.Drawing.Point(13, 65);
            this.resutRichTxtBox.Name = "resutRichTxtBox";
            this.resutRichTxtBox.Size = new System.Drawing.Size(533, 348);
            this.resutRichTxtBox.TabIndex = 6;
            this.resutRichTxtBox.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.resutRichTxtBox);
            this.Controls.Add(this.startBtn);
            this.Controls.Add(this.brosweBtn);
            this.Controls.Add(this.fileTxtBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.endYearInput);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.endYearInput)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown endYearInput;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox fileTxtBox;
        private System.Windows.Forms.Button brosweBtn;
        private System.Windows.Forms.Button startBtn;
        private System.Windows.Forms.RichTextBox resutRichTxtBox;
    }
}

