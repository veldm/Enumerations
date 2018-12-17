namespace Casting
{
    partial class Form1
    {
        /// <summary>
        /// Требуется переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.SQL_CB = new System.Windows.Forms.CheckBox();
            this.Lisp_CB = new System.Windows.Forms.CheckBox();
            this.Ruby_CB = new System.Windows.Forms.CheckBox();
            this.Python_CB = new System.Windows.Forms.CheckBox();
            this.Java_CB = new System.Windows.Forms.CheckBox();
            this.VB_CB = new System.Windows.Forms.CheckBox();
            this.Assembler_CB = new System.Windows.Forms.CheckBox();
            this.CPP_CB = new System.Windows.Forms.CheckBox();
            this.CS_CB = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.RequireInputTB = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.OutputTB = new System.Windows.Forms.TextBox();
            this.RunButton = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Monotype Corsiva", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(63, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(294, 36);
            this.label1.TabIndex = 0;
            this.label1.Text = "Подбор программистов";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.SQL_CB);
            this.groupBox1.Controls.Add(this.Lisp_CB);
            this.groupBox1.Controls.Add(this.Ruby_CB);
            this.groupBox1.Controls.Add(this.Python_CB);
            this.groupBox1.Controls.Add(this.Java_CB);
            this.groupBox1.Controls.Add(this.VB_CB);
            this.groupBox1.Controls.Add(this.Assembler_CB);
            this.groupBox1.Controls.Add(this.CPP_CB);
            this.groupBox1.Controls.Add(this.CS_CB);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.RequireInputTB);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox1.Location = new System.Drawing.Point(16, 58);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(393, 148);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Требования";
            // 
            // SQL_CB
            // 
            this.SQL_CB.AutoSize = true;
            this.SQL_CB.Location = new System.Drawing.Point(322, 106);
            this.SQL_CB.Name = "SQL_CB";
            this.SQL_CB.Size = new System.Drawing.Size(60, 24);
            this.SQL_CB.TabIndex = 12;
            this.SQL_CB.Text = "SQL";
            this.SQL_CB.UseVisualStyleBackColor = true;
            // 
            // Lisp_CB
            // 
            this.Lisp_CB.AutoSize = true;
            this.Lisp_CB.Location = new System.Drawing.Point(255, 106);
            this.Lisp_CB.Name = "Lisp_CB";
            this.Lisp_CB.Size = new System.Drawing.Size(57, 24);
            this.Lisp_CB.TabIndex = 11;
            this.Lisp_CB.Text = "Lisp";
            this.Lisp_CB.UseVisualStyleBackColor = true;
            // 
            // Ruby_CB
            // 
            this.Ruby_CB.AutoSize = true;
            this.Ruby_CB.Location = new System.Drawing.Point(170, 106);
            this.Ruby_CB.Name = "Ruby_CB";
            this.Ruby_CB.Size = new System.Drawing.Size(65, 24);
            this.Ruby_CB.TabIndex = 10;
            this.Ruby_CB.Text = "Ruby";
            this.Ruby_CB.UseVisualStyleBackColor = true;
            // 
            // Python_CB
            // 
            this.Python_CB.AutoSize = true;
            this.Python_CB.Location = new System.Drawing.Point(87, 106);
            this.Python_CB.Name = "Python_CB";
            this.Python_CB.Size = new System.Drawing.Size(77, 24);
            this.Python_CB.TabIndex = 9;
            this.Python_CB.Text = "Python";
            this.Python_CB.UseVisualStyleBackColor = true;
            // 
            // Java_CB
            // 
            this.Java_CB.AutoSize = true;
            this.Java_CB.Location = new System.Drawing.Point(19, 106);
            this.Java_CB.Name = "Java_CB";
            this.Java_CB.Size = new System.Drawing.Size(61, 24);
            this.Java_CB.TabIndex = 8;
            this.Java_CB.Text = "Java";
            this.Java_CB.UseVisualStyleBackColor = true;
            // 
            // VB_CB
            // 
            this.VB_CB.AutoSize = true;
            this.VB_CB.Location = new System.Drawing.Point(268, 67);
            this.VB_CB.Name = "VB_CB";
            this.VB_CB.Size = new System.Drawing.Size(114, 24);
            this.VB_CB.TabIndex = 7;
            this.VB_CB.Text = "Visual Basic";
            this.VB_CB.UseVisualStyleBackColor = true;
            // 
            // Assembler_CB
            // 
            this.Assembler_CB.AutoSize = true;
            this.Assembler_CB.Location = new System.Drawing.Point(159, 67);
            this.Assembler_CB.Name = "Assembler_CB";
            this.Assembler_CB.Size = new System.Drawing.Size(103, 24);
            this.Assembler_CB.TabIndex = 6;
            this.Assembler_CB.Text = "Assembler";
            this.Assembler_CB.UseVisualStyleBackColor = true;
            // 
            // CPP_CB
            // 
            this.CPP_CB.AutoSize = true;
            this.CPP_CB.Location = new System.Drawing.Point(87, 67);
            this.CPP_CB.Name = "CPP_CB";
            this.CPP_CB.Size = new System.Drawing.Size(57, 24);
            this.CPP_CB.TabIndex = 5;
            this.CPP_CB.Text = "C++";
            this.CPP_CB.UseVisualStyleBackColor = true;
            // 
            // CS_CB
            // 
            this.CS_CB.AutoSize = true;
            this.CS_CB.Location = new System.Drawing.Point(19, 67);
            this.CS_CB.Name = "CS_CB";
            this.CS_CB.Size = new System.Drawing.Size(48, 24);
            this.CS_CB.TabIndex = 4;
            this.CS_CB.Text = "C#";
            this.CS_CB.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(261, 29);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(126, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "из этих языков:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Владение";
            // 
            // RequireInputTB
            // 
            this.RequireInputTB.FormattingEnabled = true;
            this.RequireInputTB.Items.AddRange(new object[] {
            "всеми",
            "одним из"});
            this.RequireInputTB.Location = new System.Drawing.Point(101, 26);
            this.RequireInputTB.Name = "RequireInputTB";
            this.RequireInputTB.Size = new System.Drawing.Size(154, 28);
            this.RequireInputTB.TabIndex = 0;
            this.RequireInputTB.Text = "всеми";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(113, 218);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(198, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Подходящие кандидаты";
            // 
            // OutputTB
            // 
            this.OutputTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.OutputTB.Location = new System.Drawing.Point(16, 252);
            this.OutputTB.Multiline = true;
            this.OutputTB.Name = "OutputTB";
            this.OutputTB.Size = new System.Drawing.Size(393, 171);
            this.OutputTB.TabIndex = 3;
            // 
            // RunButton
            // 
            this.RunButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RunButton.Location = new System.Drawing.Point(137, 434);
            this.RunButton.Name = "RunButton";
            this.RunButton.Size = new System.Drawing.Size(151, 40);
            this.RunButton.TabIndex = 4;
            this.RunButton.Text = "Готово";
            this.RunButton.UseVisualStyleBackColor = true;
            this.RunButton.Click += new System.EventHandler(this.RunButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(421, 486);
            this.Controls.Add(this.RunButton);
            this.Controls.Add(this.OutputTB);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox RequireInputTB;
        private System.Windows.Forms.CheckBox Assembler_CB;
        private System.Windows.Forms.CheckBox CPP_CB;
        private System.Windows.Forms.CheckBox CS_CB;
        private System.Windows.Forms.CheckBox Java_CB;
        private System.Windows.Forms.CheckBox VB_CB;
        private System.Windows.Forms.CheckBox Ruby_CB;
        private System.Windows.Forms.CheckBox Python_CB;
        private System.Windows.Forms.CheckBox SQL_CB;
        private System.Windows.Forms.CheckBox Lisp_CB;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox OutputTB;
        private System.Windows.Forms.Button RunButton;
    }
}

