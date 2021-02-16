
namespace S2_Lab01
{
    partial class Calculator
    {
        /// <summary>
        /// Обязательная переменная конструктора.
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
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.Button00 = new System.Windows.Forms.Button();
            this.DataOut = new System.Windows.Forms.TextBox();
            this.Button05 = new System.Windows.Forms.Button();
            this.ButtonSin = new System.Windows.Forms.Button();
            this.Button01 = new System.Windows.Forms.Button();
            this.Button02 = new System.Windows.Forms.Button();
            this.Button03 = new System.Windows.Forms.Button();
            this.Button04 = new System.Windows.Forms.Button();
            this.Button06 = new System.Windows.Forms.Button();
            this.Button07 = new System.Windows.Forms.Button();
            this.Button08 = new System.Windows.Forms.Button();
            this.Button09 = new System.Windows.Forms.Button();
            this.ButtonCos = new System.Windows.Forms.Button();
            this.ButtonTan = new System.Windows.Forms.Button();
            this.ButtonCot = new System.Windows.Forms.Button();
            this.ButtonArcSin = new System.Windows.Forms.Button();
            this.ButtonArcCos = new System.Windows.Forms.Button();
            this.ButtonArcTan = new System.Windows.Forms.Button();
            this.ButtonArcCot = new System.Windows.Forms.Button();
            this.ButtonMinus = new System.Windows.Forms.Button();
            this.ButtonPoint = new System.Windows.Forms.Button();
            this.ButtonMemoryIn = new System.Windows.Forms.Button();
            this.ButtonMemoryOut = new System.Windows.Forms.Button();
            this.ButtonPow = new System.Windows.Forms.Button();
            this.ButtonReset = new System.Windows.Forms.Button();
            this.ButtonPow2 = new System.Windows.Forms.Button();
            this.ButtonPow3 = new System.Windows.Forms.Button();
            this.ButtonEnter = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Button00
            // 
            this.Button00.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Button00.Location = new System.Drawing.Point(78, 291);
            this.Button00.Name = "Button00";
            this.Button00.Size = new System.Drawing.Size(60, 60);
            this.Button00.TabIndex = 0;
            this.Button00.Text = "0";
            this.Button00.UseVisualStyleBackColor = true;
            this.Button00.Click += new System.EventHandler(this.ButtonNumber_Click);
            // 
            // DataOut
            // 
            this.DataOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DataOut.Location = new System.Drawing.Point(12, 12);
            this.DataOut.Multiline = true;
            this.DataOut.Name = "DataOut";
            this.DataOut.ReadOnly = true;
            this.DataOut.Size = new System.Drawing.Size(636, 75);
            this.DataOut.TabIndex = 3;
            this.DataOut.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // Button05
            // 
            this.Button05.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Button05.Location = new System.Drawing.Point(78, 159);
            this.Button05.Name = "Button05";
            this.Button05.Size = new System.Drawing.Size(60, 60);
            this.Button05.TabIndex = 4;
            this.Button05.Text = "5";
            this.Button05.UseVisualStyleBackColor = true;
            this.Button05.Click += new System.EventHandler(this.ButtonNumber_Click);
            // 
            // ButtonSin
            // 
            this.ButtonSin.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ButtonSin.Location = new System.Drawing.Point(276, 93);
            this.ButtonSin.Name = "ButtonSin";
            this.ButtonSin.Size = new System.Drawing.Size(100, 60);
            this.ButtonSin.TabIndex = 5;
            this.ButtonSin.Text = "sin";
            this.ButtonSin.UseVisualStyleBackColor = true;
            this.ButtonSin.Click += new System.EventHandler(this.ButtonTrigonometry_Click);
            // 
            // Button01
            // 
            this.Button01.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Button01.Location = new System.Drawing.Point(12, 225);
            this.Button01.Name = "Button01";
            this.Button01.Size = new System.Drawing.Size(60, 60);
            this.Button01.TabIndex = 9;
            this.Button01.Text = "1";
            this.Button01.UseVisualStyleBackColor = true;
            this.Button01.Click += new System.EventHandler(this.ButtonNumber_Click);
            // 
            // Button02
            // 
            this.Button02.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Button02.Location = new System.Drawing.Point(78, 225);
            this.Button02.Name = "Button02";
            this.Button02.Size = new System.Drawing.Size(60, 60);
            this.Button02.TabIndex = 10;
            this.Button02.Text = "2";
            this.Button02.UseVisualStyleBackColor = true;
            this.Button02.Click += new System.EventHandler(this.ButtonNumber_Click);
            // 
            // Button03
            // 
            this.Button03.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Button03.Location = new System.Drawing.Point(144, 225);
            this.Button03.Name = "Button03";
            this.Button03.Size = new System.Drawing.Size(60, 60);
            this.Button03.TabIndex = 11;
            this.Button03.Text = "3";
            this.Button03.UseVisualStyleBackColor = true;
            this.Button03.Click += new System.EventHandler(this.ButtonNumber_Click);
            // 
            // Button04
            // 
            this.Button04.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Button04.Location = new System.Drawing.Point(12, 159);
            this.Button04.Name = "Button04";
            this.Button04.Size = new System.Drawing.Size(60, 60);
            this.Button04.TabIndex = 12;
            this.Button04.Text = "4";
            this.Button04.UseVisualStyleBackColor = true;
            this.Button04.Click += new System.EventHandler(this.ButtonNumber_Click);
            // 
            // Button06
            // 
            this.Button06.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Button06.Location = new System.Drawing.Point(144, 159);
            this.Button06.Name = "Button06";
            this.Button06.Size = new System.Drawing.Size(60, 60);
            this.Button06.TabIndex = 13;
            this.Button06.Text = "6";
            this.Button06.UseVisualStyleBackColor = true;
            this.Button06.Click += new System.EventHandler(this.ButtonNumber_Click);
            // 
            // Button07
            // 
            this.Button07.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Button07.Location = new System.Drawing.Point(12, 93);
            this.Button07.Name = "Button07";
            this.Button07.Size = new System.Drawing.Size(60, 60);
            this.Button07.TabIndex = 14;
            this.Button07.Text = "7";
            this.Button07.UseVisualStyleBackColor = true;
            this.Button07.Click += new System.EventHandler(this.ButtonNumber_Click);
            // 
            // Button08
            // 
            this.Button08.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Button08.Location = new System.Drawing.Point(78, 93);
            this.Button08.Name = "Button08";
            this.Button08.Size = new System.Drawing.Size(60, 60);
            this.Button08.TabIndex = 15;
            this.Button08.Text = "8";
            this.Button08.UseVisualStyleBackColor = true;
            this.Button08.Click += new System.EventHandler(this.ButtonNumber_Click);
            // 
            // Button09
            // 
            this.Button09.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Button09.Location = new System.Drawing.Point(144, 93);
            this.Button09.Name = "Button09";
            this.Button09.Size = new System.Drawing.Size(60, 60);
            this.Button09.TabIndex = 16;
            this.Button09.Text = "9";
            this.Button09.UseVisualStyleBackColor = true;
            this.Button09.Click += new System.EventHandler(this.ButtonNumber_Click);
            // 
            // ButtonCos
            // 
            this.ButtonCos.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ButtonCos.Location = new System.Drawing.Point(276, 159);
            this.ButtonCos.Name = "ButtonCos";
            this.ButtonCos.Size = new System.Drawing.Size(100, 60);
            this.ButtonCos.TabIndex = 17;
            this.ButtonCos.Text = "cos";
            this.ButtonCos.UseVisualStyleBackColor = true;
            this.ButtonCos.Click += new System.EventHandler(this.ButtonTrigonometry_Click);
            // 
            // ButtonTan
            // 
            this.ButtonTan.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ButtonTan.Location = new System.Drawing.Point(276, 225);
            this.ButtonTan.Name = "ButtonTan";
            this.ButtonTan.Size = new System.Drawing.Size(100, 60);
            this.ButtonTan.TabIndex = 18;
            this.ButtonTan.Text = "tan";
            this.ButtonTan.UseVisualStyleBackColor = true;
            this.ButtonTan.Click += new System.EventHandler(this.ButtonTrigonometry_Click);
            // 
            // ButtonCot
            // 
            this.ButtonCot.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ButtonCot.Location = new System.Drawing.Point(276, 291);
            this.ButtonCot.Name = "ButtonCot";
            this.ButtonCot.Size = new System.Drawing.Size(100, 60);
            this.ButtonCot.TabIndex = 19;
            this.ButtonCot.Text = "cot";
            this.ButtonCot.UseVisualStyleBackColor = true;
            this.ButtonCot.Click += new System.EventHandler(this.ButtonTrigonometry_Click);
            // 
            // ButtonArcSin
            // 
            this.ButtonArcSin.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ButtonArcSin.Location = new System.Drawing.Point(382, 93);
            this.ButtonArcSin.Name = "ButtonArcSin";
            this.ButtonArcSin.Size = new System.Drawing.Size(130, 60);
            this.ButtonArcSin.TabIndex = 20;
            this.ButtonArcSin.Text = "arcsin";
            this.ButtonArcSin.UseVisualStyleBackColor = true;
            this.ButtonArcSin.Click += new System.EventHandler(this.ButtonTrigonometry_Click);
            // 
            // ButtonArcCos
            // 
            this.ButtonArcCos.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ButtonArcCos.Location = new System.Drawing.Point(382, 159);
            this.ButtonArcCos.Name = "ButtonArcCos";
            this.ButtonArcCos.Size = new System.Drawing.Size(130, 60);
            this.ButtonArcCos.TabIndex = 21;
            this.ButtonArcCos.Text = "arccos";
            this.ButtonArcCos.UseVisualStyleBackColor = true;
            this.ButtonArcCos.Click += new System.EventHandler(this.ButtonTrigonometry_Click);
            // 
            // ButtonArcTan
            // 
            this.ButtonArcTan.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ButtonArcTan.Location = new System.Drawing.Point(382, 225);
            this.ButtonArcTan.Name = "ButtonArcTan";
            this.ButtonArcTan.Size = new System.Drawing.Size(130, 60);
            this.ButtonArcTan.TabIndex = 22;
            this.ButtonArcTan.Text = "arctan";
            this.ButtonArcTan.UseVisualStyleBackColor = true;
            this.ButtonArcTan.Click += new System.EventHandler(this.ButtonTrigonometry_Click);
            // 
            // ButtonArcCot
            // 
            this.ButtonArcCot.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ButtonArcCot.Location = new System.Drawing.Point(382, 291);
            this.ButtonArcCot.Name = "ButtonArcCot";
            this.ButtonArcCot.Size = new System.Drawing.Size(130, 60);
            this.ButtonArcCot.TabIndex = 23;
            this.ButtonArcCot.Text = "arccot";
            this.ButtonArcCot.UseVisualStyleBackColor = true;
            this.ButtonArcCot.Click += new System.EventHandler(this.ButtonTrigonometry_Click);
            // 
            // ButtonMinus
            // 
            this.ButtonMinus.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ButtonMinus.Location = new System.Drawing.Point(12, 291);
            this.ButtonMinus.Name = "ButtonMinus";
            this.ButtonMinus.Size = new System.Drawing.Size(60, 60);
            this.ButtonMinus.TabIndex = 26;
            this.ButtonMinus.Text = "-";
            this.ButtonMinus.UseVisualStyleBackColor = true;
            this.ButtonMinus.Click += new System.EventHandler(this.ButtonMinus_Click);
            // 
            // ButtonPoint
            // 
            this.ButtonPoint.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ButtonPoint.Location = new System.Drawing.Point(144, 291);
            this.ButtonPoint.Name = "ButtonPoint";
            this.ButtonPoint.Size = new System.Drawing.Size(60, 60);
            this.ButtonPoint.TabIndex = 27;
            this.ButtonPoint.Text = ".";
            this.ButtonPoint.UseVisualStyleBackColor = true;
            this.ButtonPoint.Click += new System.EventHandler(this.ButtonNumber_Click);
            // 
            // ButtonMemoryIn
            // 
            this.ButtonMemoryIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ButtonMemoryIn.Location = new System.Drawing.Point(518, 93);
            this.ButtonMemoryIn.Name = "ButtonMemoryIn";
            this.ButtonMemoryIn.Size = new System.Drawing.Size(130, 60);
            this.ButtonMemoryIn.TabIndex = 28;
            this.ButtonMemoryIn.Text = "M IN";
            this.ButtonMemoryIn.UseVisualStyleBackColor = true;
            this.ButtonMemoryIn.Click += new System.EventHandler(this.ButtonMemoryIn_Click);
            // 
            // ButtonMemoryOut
            // 
            this.ButtonMemoryOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ButtonMemoryOut.Location = new System.Drawing.Point(518, 159);
            this.ButtonMemoryOut.Name = "ButtonMemoryOut";
            this.ButtonMemoryOut.Size = new System.Drawing.Size(130, 60);
            this.ButtonMemoryOut.TabIndex = 29;
            this.ButtonMemoryOut.Text = "M OUT";
            this.ButtonMemoryOut.UseVisualStyleBackColor = true;
            this.ButtonMemoryOut.Click += new System.EventHandler(this.ButtonMemoryOut_Click);
            // 
            // ButtonPow
            // 
            this.ButtonPow.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ButtonPow.Location = new System.Drawing.Point(210, 93);
            this.ButtonPow.Name = "ButtonPow";
            this.ButtonPow.Size = new System.Drawing.Size(60, 60);
            this.ButtonPow.TabIndex = 30;
            this.ButtonPow.Text = "^";
            this.ButtonPow.UseVisualStyleBackColor = true;
            this.ButtonPow.Click += new System.EventHandler(this.ButtonPow_Click);
            // 
            // ButtonReset
            // 
            this.ButtonReset.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ButtonReset.Location = new System.Drawing.Point(518, 225);
            this.ButtonReset.Name = "ButtonReset";
            this.ButtonReset.Size = new System.Drawing.Size(128, 60);
            this.ButtonReset.TabIndex = 31;
            this.ButtonReset.Text = "Reset";
            this.ButtonReset.UseVisualStyleBackColor = true;
            this.ButtonReset.Click += new System.EventHandler(this.ButtonReset_Click);
            // 
            // ButtonPow2
            // 
            this.ButtonPow2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ButtonPow2.Location = new System.Drawing.Point(210, 159);
            this.ButtonPow2.Name = "ButtonPow2";
            this.ButtonPow2.Size = new System.Drawing.Size(60, 60);
            this.ButtonPow2.TabIndex = 32;
            this.ButtonPow2.Text = "^2";
            this.ButtonPow2.UseVisualStyleBackColor = true;
            this.ButtonPow2.Click += new System.EventHandler(this.ButtonPow_Click);
            // 
            // ButtonPow3
            // 
            this.ButtonPow3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ButtonPow3.Location = new System.Drawing.Point(210, 225);
            this.ButtonPow3.Name = "ButtonPow3";
            this.ButtonPow3.Size = new System.Drawing.Size(60, 60);
            this.ButtonPow3.TabIndex = 33;
            this.ButtonPow3.Text = "^3";
            this.ButtonPow3.UseVisualStyleBackColor = true;
            this.ButtonPow3.Click += new System.EventHandler(this.ButtonPow_Click);
            // 
            // ButtonEnter
            // 
            this.ButtonEnter.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ButtonEnter.Location = new System.Drawing.Point(210, 291);
            this.ButtonEnter.Name = "ButtonEnter";
            this.ButtonEnter.Size = new System.Drawing.Size(60, 60);
            this.ButtonEnter.TabIndex = 34;
            this.ButtonEnter.Text = "=";
            this.ButtonEnter.UseVisualStyleBackColor = true;
            this.ButtonEnter.Click += new System.EventHandler(this.ButtonEnter_Click);
            // 
            // Calculator
            // 
            this.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(658, 363);
            this.Controls.Add(this.ButtonEnter);
            this.Controls.Add(this.ButtonPow3);
            this.Controls.Add(this.ButtonPow2);
            this.Controls.Add(this.ButtonReset);
            this.Controls.Add(this.ButtonPow);
            this.Controls.Add(this.ButtonMemoryOut);
            this.Controls.Add(this.ButtonMemoryIn);
            this.Controls.Add(this.ButtonPoint);
            this.Controls.Add(this.ButtonMinus);
            this.Controls.Add(this.ButtonArcCot);
            this.Controls.Add(this.ButtonArcTan);
            this.Controls.Add(this.ButtonArcCos);
            this.Controls.Add(this.ButtonArcSin);
            this.Controls.Add(this.ButtonCot);
            this.Controls.Add(this.ButtonTan);
            this.Controls.Add(this.ButtonCos);
            this.Controls.Add(this.Button09);
            this.Controls.Add(this.Button08);
            this.Controls.Add(this.Button07);
            this.Controls.Add(this.Button06);
            this.Controls.Add(this.Button04);
            this.Controls.Add(this.Button03);
            this.Controls.Add(this.Button02);
            this.Controls.Add(this.Button01);
            this.Controls.Add(this.ButtonSin);
            this.Controls.Add(this.Button05);
            this.Controls.Add(this.DataOut);
            this.Controls.Add(this.Button00);
            this.MaximumSize = new System.Drawing.Size(676, 410);
            this.MinimumSize = new System.Drawing.Size(676, 410);
            this.Name = "Calculator";
            this.Text = "Mega Super Calculator 3000";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Button00;
        private System.Windows.Forms.TextBox DataOut;
        private System.Windows.Forms.Button Button05;
        private System.Windows.Forms.Button ButtonSin;
        private System.Windows.Forms.Button Button01;
        private System.Windows.Forms.Button Button02;
        private System.Windows.Forms.Button Button03;
        private System.Windows.Forms.Button Button04;
        private System.Windows.Forms.Button Button06;
        private System.Windows.Forms.Button Button07;
        private System.Windows.Forms.Button Button08;
        private System.Windows.Forms.Button Button09;
        private System.Windows.Forms.Button ButtonCos;
        private System.Windows.Forms.Button ButtonTan;
        private System.Windows.Forms.Button ButtonCot;
        private System.Windows.Forms.Button ButtonArcSin;
        private System.Windows.Forms.Button ButtonArcCos;
        private System.Windows.Forms.Button ButtonArcTan;
        private System.Windows.Forms.Button ButtonArcCot;
        private System.Windows.Forms.Button ButtonMinus;
        private System.Windows.Forms.Button ButtonPoint;
        private System.Windows.Forms.Button ButtonMemoryIn;
        private System.Windows.Forms.Button ButtonMemoryOut;
        private System.Windows.Forms.Button ButtonPow;
        private System.Windows.Forms.Button ButtonReset;
        private System.Windows.Forms.Button ButtonPow2;
        private System.Windows.Forms.Button ButtonPow3;
        private System.Windows.Forms.Button ButtonEnter;
    }
}

