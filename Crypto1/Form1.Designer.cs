namespace Crypto1
{
    partial class Form1
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
            this.sourceText = new System.Windows.Forms.TextBox();
            this.encryptedText = new System.Windows.Forms.TextBox();
            this.keyText = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.decryptedText = new System.Windows.Forms.TextBox();
            this.encryptButton = new System.Windows.Forms.Button();
            this.decyptButton = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.TrycemusMethod = new System.Windows.Forms.RadioButton();
            this.VigenerMethod = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // sourceText
            // 
            this.sourceText.Location = new System.Drawing.Point(12, 25);
            this.sourceText.Multiline = true;
            this.sourceText.Name = "sourceText";
            this.sourceText.Size = new System.Drawing.Size(482, 72);
            this.sourceText.TabIndex = 0;
            // 
            // encryptedText
            // 
            this.encryptedText.Location = new System.Drawing.Point(12, 166);
            this.encryptedText.Multiline = true;
            this.encryptedText.Name = "encryptedText";
            this.encryptedText.Size = new System.Drawing.Size(238, 72);
            this.encryptedText.TabIndex = 1;
            // 
            // keyText
            // 
            this.keyText.Location = new System.Drawing.Point(12, 116);
            this.keyText.Name = "keyText";
            this.keyText.Size = new System.Drawing.Size(176, 20);
            this.keyText.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Исходный текст";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Ключевое слово";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 150);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(123, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Зашифрованный текст";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(256, 150);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(129, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Расшифрованный текст";
            // 
            // decryptedText
            // 
            this.decryptedText.Location = new System.Drawing.Point(256, 166);
            this.decryptedText.Multiline = true;
            this.decryptedText.Name = "decryptedText";
            this.decryptedText.Size = new System.Drawing.Size(238, 72);
            this.decryptedText.TabIndex = 6;
            // 
            // encryptButton
            // 
            this.encryptButton.Location = new System.Drawing.Point(12, 244);
            this.encryptButton.Name = "encryptButton";
            this.encryptButton.Size = new System.Drawing.Size(123, 23);
            this.encryptButton.TabIndex = 8;
            this.encryptButton.Text = "Зашифровать";
            this.encryptButton.UseVisualStyleBackColor = true;
            this.encryptButton.Click += new System.EventHandler(this.encryptButton_Click);
            // 
            // decyptButton
            // 
            this.decyptButton.Location = new System.Drawing.Point(256, 244);
            this.decyptButton.Name = "decyptButton";
            this.decyptButton.Size = new System.Drawing.Size(138, 23);
            this.decyptButton.TabIndex = 9;
            this.decyptButton.Text = "Расшифровать";
            this.decyptButton.UseVisualStyleBackColor = true;
            this.decyptButton.Click += new System.EventHandler(this.decyptButton_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(506, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(106, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Метод шифрования";
            // 
            // TrycemusMethod
            // 
            this.TrycemusMethod.AutoSize = true;
            this.TrycemusMethod.Checked = true;
            this.TrycemusMethod.Location = new System.Drawing.Point(516, 37);
            this.TrycemusMethod.Name = "TrycemusMethod";
            this.TrycemusMethod.Size = new System.Drawing.Size(81, 17);
            this.TrycemusMethod.TabIndex = 11;
            this.TrycemusMethod.TabStop = true;
            this.TrycemusMethod.Text = "Трисемуса";
            this.TrycemusMethod.UseVisualStyleBackColor = true;
            // 
            // VigenerMethod
            // 
            this.VigenerMethod.AutoSize = true;
            this.VigenerMethod.Location = new System.Drawing.Point(516, 60);
            this.VigenerMethod.Name = "VigenerMethod";
            this.VigenerMethod.Size = new System.Drawing.Size(76, 17);
            this.VigenerMethod.TabIndex = 13;
            this.VigenerMethod.Text = "Виженера";
            this.VigenerMethod.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(720, 348);
            this.Controls.Add(this.VigenerMethod);
            this.Controls.Add(this.TrycemusMethod);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.decyptButton);
            this.Controls.Add(this.encryptButton);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.decryptedText);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.keyText);
            this.Controls.Add(this.encryptedText);
            this.Controls.Add(this.sourceText);
            this.Name = "Form1";
            this.Text = "Crypt 1.0";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox sourceText;
        private System.Windows.Forms.TextBox encryptedText;
        private System.Windows.Forms.TextBox keyText;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox decryptedText;
        private System.Windows.Forms.Button encryptButton;
        private System.Windows.Forms.Button decyptButton;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RadioButton TrycemusMethod;
        private System.Windows.Forms.RadioButton VigenerMethod;
    }
}

