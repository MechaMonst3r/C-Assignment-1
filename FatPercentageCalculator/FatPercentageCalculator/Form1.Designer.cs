namespace FatPercentageCalculator
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
            this.userCalories = new System.Windows.Forms.TextBox();
            this.userFat = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Calculate = new System.Windows.Forms.Button();
            this.chkLowFat = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.Result1 = new System.Windows.Forms.Label();
            this.Result2 = new System.Windows.Forms.Label();
            this.Result3 = new System.Windows.Forms.Label();
            this.Exit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // userCalories
            // 
            this.userCalories.Location = new System.Drawing.Point(142, 29);
            this.userCalories.Name = "userCalories";
            this.userCalories.Size = new System.Drawing.Size(87, 20);
            this.userCalories.TabIndex = 0;
            // 
            // userFat
            // 
            this.userFat.Location = new System.Drawing.Point(142, 95);
            this.userFat.Name = "userFat";
            this.userFat.Size = new System.Drawing.Size(87, 20);
            this.userFat.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(79, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(202, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Enter total number of calories: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(100, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(181, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Enter number of fat grams: ";
            // 
            // Calculate
            // 
            this.Calculate.Location = new System.Drawing.Point(103, 144);
            this.Calculate.Name = "Calculate";
            this.Calculate.Size = new System.Drawing.Size(178, 23);
            this.Calculate.TabIndex = 4;
            this.Calculate.Text = "Calculate";
            this.Calculate.UseVisualStyleBackColor = true;
            this.Calculate.Click += new System.EventHandler(this.Calculate_Click);
            // 
            // chkLowFat
            // 
            this.chkLowFat.AutoSize = true;
            this.chkLowFat.Location = new System.Drawing.Point(142, 121);
            this.chkLowFat.Name = "chkLowFat";
            this.chkLowFat.Size = new System.Drawing.Size(102, 17);
            this.chkLowFat.TabIndex = 5;
            this.chkLowFat.Text = "See if it\'s low fat";
            this.chkLowFat.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(151, 204);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "RESULTS";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(111, 231);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(170, 16);
            this.label4.TabIndex = 7;
            this.label4.Text = "Number of calories from fat:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(100, 279);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(192, 16);
            this.label5.TabIndex = 8;
            this.label5.Text = "Percentage of calories from fat:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(158, 347);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 16);
            this.label6.TabIndex = 9;
            this.label6.Text = "  Is low fat?";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // Result1
            // 
            this.Result1.AutoSize = true;
            this.Result1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Result1.Location = new System.Drawing.Point(167, 256);
            this.Result1.Name = "Result1";
            this.Result1.Size = new System.Drawing.Size(0, 13);
            this.Result1.TabIndex = 10;
            this.Result1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Result2
            // 
            this.Result2.AutoSize = true;
            this.Result2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Result2.Location = new System.Drawing.Point(167, 305);
            this.Result2.Name = "Result2";
            this.Result2.Size = new System.Drawing.Size(0, 13);
            this.Result2.TabIndex = 11;
            this.Result2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Result3
            // 
            this.Result3.AutoSize = true;
            this.Result3.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Result3.Location = new System.Drawing.Point(167, 374);
            this.Result3.Name = "Result3";
            this.Result3.Size = new System.Drawing.Size(0, 13);
            this.Result3.TabIndex = 12;
            this.Result3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Exit
            // 
            this.Exit.Location = new System.Drawing.Point(154, 404);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(87, 23);
            this.Exit.TabIndex = 13;
            this.Exit.Text = "Exit";
            this.Exit.UseVisualStyleBackColor = true;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(366, 457);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.Result3);
            this.Controls.Add(this.Result2);
            this.Controls.Add(this.Result1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.chkLowFat);
            this.Controls.Add(this.Calculate);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.userFat);
            this.Controls.Add(this.userCalories);
            this.Name = "Form1";
            this.Text = "Fat Percentage Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox userCalories;
        private System.Windows.Forms.TextBox userFat;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Calculate;
        private System.Windows.Forms.CheckBox chkLowFat;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label Result1;
        private System.Windows.Forms.Label Result2;
        private System.Windows.Forms.Label Result3;
        private System.Windows.Forms.Button Exit;
    }
}

