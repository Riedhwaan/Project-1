namespace Question_4
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
            this.label2 = new System.Windows.Forms.Label();
            this.txtBox_1 = new System.Windows.Forms.TextBox();
            this.txtBox_2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_ADD = new System.Windows.Forms.Button();
            this.btn_SUBTRACT = new System.Windows.Forms.Button();
            this.btn_MULTIPLY = new System.Windows.Forms.Button();
            this.btn_CLEAR = new System.Windows.Forms.Button();
            this.btn_EXIT = new System.Windows.Forms.Button();
            this.rBtn_IWantToAdd = new System.Windows.Forms.RadioButton();
            this.rBtn_IWantToSubtract = new System.Windows.Forms.RadioButton();
            this.rBtn_IWantToMultiply = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "First Number";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(36, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Second Number";
            // 
            // txtBox_1
            // 
            this.txtBox_1.Location = new System.Drawing.Point(190, 48);
            this.txtBox_1.Name = "txtBox_1";
            this.txtBox_1.Size = new System.Drawing.Size(134, 22);
            this.txtBox_1.TabIndex = 2;
            // 
            // txtBox_2
            // 
            this.txtBox_2.Location = new System.Drawing.Point(190, 107);
            this.txtBox_2.Name = "txtBox_2";
            this.txtBox_2.Size = new System.Drawing.Size(134, 22);
            this.txtBox_2.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(449, 51);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(209, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Choose an arithmetic operation:";
            // 
            // btn_ADD
            // 
            this.btn_ADD.Location = new System.Drawing.Point(39, 308);
            this.btn_ADD.Name = "btn_ADD";
            this.btn_ADD.Size = new System.Drawing.Size(95, 23);
            this.btn_ADD.TabIndex = 5;
            this.btn_ADD.Text = "ADD";
            this.btn_ADD.UseVisualStyleBackColor = true;
            this.btn_ADD.Click += new System.EventHandler(this.btn_ADD_Click);
            // 
            // btn_SUBTRACT
            // 
            this.btn_SUBTRACT.Location = new System.Drawing.Point(190, 308);
            this.btn_SUBTRACT.Name = "btn_SUBTRACT";
            this.btn_SUBTRACT.Size = new System.Drawing.Size(95, 23);
            this.btn_SUBTRACT.TabIndex = 6;
            this.btn_SUBTRACT.Text = "SUBTRACT";
            this.btn_SUBTRACT.UseVisualStyleBackColor = true;
            this.btn_SUBTRACT.Click += new System.EventHandler(this.btn_SUBTRACT_Click);
            // 
            // btn_MULTIPLY
            // 
            this.btn_MULTIPLY.Location = new System.Drawing.Point(353, 308);
            this.btn_MULTIPLY.Name = "btn_MULTIPLY";
            this.btn_MULTIPLY.Size = new System.Drawing.Size(95, 23);
            this.btn_MULTIPLY.TabIndex = 7;
            this.btn_MULTIPLY.Text = "MULTIPLY";
            this.btn_MULTIPLY.UseVisualStyleBackColor = true;
            this.btn_MULTIPLY.Click += new System.EventHandler(this.btn_MULTIPLY_Click);
            // 
            // btn_CLEAR
            // 
            this.btn_CLEAR.Location = new System.Drawing.Point(39, 390);
            this.btn_CLEAR.Name = "btn_CLEAR";
            this.btn_CLEAR.Size = new System.Drawing.Size(95, 23);
            this.btn_CLEAR.TabIndex = 8;
            this.btn_CLEAR.Text = "CLEAR";
            this.btn_CLEAR.UseVisualStyleBackColor = true;
            this.btn_CLEAR.Click += new System.EventHandler(this.btn_CLEAR_Click);
            // 
            // btn_EXIT
            // 
            this.btn_EXIT.Location = new System.Drawing.Point(190, 390);
            this.btn_EXIT.Name = "btn_EXIT";
            this.btn_EXIT.Size = new System.Drawing.Size(95, 23);
            this.btn_EXIT.TabIndex = 9;
            this.btn_EXIT.Text = "EXIT";
            this.btn_EXIT.UseVisualStyleBackColor = true;
            this.btn_EXIT.Click += new System.EventHandler(this.btn_EXIT_Click);
            // 
            // rBtn_IWantToAdd
            // 
            this.rBtn_IWantToAdd.AutoSize = true;
            this.rBtn_IWantToAdd.Location = new System.Drawing.Point(452, 107);
            this.rBtn_IWantToAdd.Name = "rBtn_IWantToAdd";
            this.rBtn_IWantToAdd.Size = new System.Drawing.Size(114, 21);
            this.rBtn_IWantToAdd.TabIndex = 10;
            this.rBtn_IWantToAdd.TabStop = true;
            this.rBtn_IWantToAdd.Text = "I want to ADD";
            this.rBtn_IWantToAdd.UseVisualStyleBackColor = true;
            this.rBtn_IWantToAdd.CheckedChanged += new System.EventHandler(this.rBtn_IWantToAdd_CheckedChanged);
            // 
            // rBtn_IWantToSubtract
            // 
            this.rBtn_IWantToSubtract.AutoSize = true;
            this.rBtn_IWantToSubtract.Location = new System.Drawing.Point(452, 170);
            this.rBtn_IWantToSubtract.Name = "rBtn_IWantToSubtract";
            this.rBtn_IWantToSubtract.Size = new System.Drawing.Size(159, 21);
            this.rBtn_IWantToSubtract.TabIndex = 11;
            this.rBtn_IWantToSubtract.TabStop = true;
            this.rBtn_IWantToSubtract.Text = "I want to SUBTRACT";
            this.rBtn_IWantToSubtract.UseVisualStyleBackColor = true;
            this.rBtn_IWantToSubtract.CheckedChanged += new System.EventHandler(this.rBtn_IWantToSubtract_CheckedChanged);
            // 
            // rBtn_IWantToMultiply
            // 
            this.rBtn_IWantToMultiply.AutoSize = true;
            this.rBtn_IWantToMultiply.Location = new System.Drawing.Point(452, 235);
            this.rBtn_IWantToMultiply.Name = "rBtn_IWantToMultiply";
            this.rBtn_IWantToMultiply.Size = new System.Drawing.Size(152, 21);
            this.rBtn_IWantToMultiply.TabIndex = 12;
            this.rBtn_IWantToMultiply.TabStop = true;
            this.rBtn_IWantToMultiply.Text = "I want to MULTIPLY";
            this.rBtn_IWantToMultiply.UseVisualStyleBackColor = true;
            this.rBtn_IWantToMultiply.CheckedChanged += new System.EventHandler(this.rBtn_IWantToMultiply_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.rBtn_IWantToMultiply);
            this.Controls.Add(this.rBtn_IWantToSubtract);
            this.Controls.Add(this.rBtn_IWantToAdd);
            this.Controls.Add(this.btn_EXIT);
            this.Controls.Add(this.btn_CLEAR);
            this.Controls.Add(this.btn_MULTIPLY);
            this.Controls.Add(this.btn_SUBTRACT);
            this.Controls.Add(this.btn_ADD);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtBox_2);
            this.Controls.Add(this.txtBox_1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "My_Calculator";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtBox_1;
        private System.Windows.Forms.TextBox txtBox_2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_ADD;
        private System.Windows.Forms.Button btn_SUBTRACT;
        private System.Windows.Forms.Button btn_MULTIPLY;
        private System.Windows.Forms.Button btn_CLEAR;
        private System.Windows.Forms.Button btn_EXIT;
        private System.Windows.Forms.RadioButton rBtn_IWantToAdd;
        private System.Windows.Forms.RadioButton rBtn_IWantToSubtract;
        private System.Windows.Forms.RadioButton rBtn_IWantToMultiply;
    }
}

