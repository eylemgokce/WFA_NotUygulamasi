namespace WFA_NotUygulamasi
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
            this.textBox1_vize = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox2_final = new System.Windows.Forms.TextBox();
            this.button1_hesapla = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5_sonuc = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(41, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(353, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Not Hesaplama Uygulaması";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(36, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(179, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Vize notunuzu giriniz : ";
            // 
            // textBox1_vize
            // 
            this.textBox1_vize.Location = new System.Drawing.Point(257, 102);
            this.textBox1_vize.Name = "textBox1_vize";
            this.textBox1_vize.Size = new System.Drawing.Size(173, 22);
            this.textBox1_vize.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(36, 139);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(183, 18);
            this.label3.TabIndex = 1;
            this.label3.Text = "Final notunuzu giriniz : ";
            // 
            // textBox2_final
            // 
            this.textBox2_final.Location = new System.Drawing.Point(257, 139);
            this.textBox2_final.Name = "textBox2_final";
            this.textBox2_final.Size = new System.Drawing.Size(173, 22);
            this.textBox2_final.TabIndex = 2;
            // 
            // button1_hesapla
            // 
            this.button1_hesapla.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button1_hesapla.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1_hesapla.Location = new System.Drawing.Point(333, 186);
            this.button1_hesapla.Name = "button1_hesapla";
            this.button1_hesapla.Size = new System.Drawing.Size(97, 36);
            this.button1_hesapla.TabIndex = 3;
            this.button1_hesapla.Text = "Hesapla";
            this.button1_hesapla.UseVisualStyleBackColor = false;
            this.button1_hesapla.Click += new System.EventHandler(this.button1_hesapla_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(36, 281);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 18);
            this.label4.TabIndex = 4;
            this.label4.Text = "Sonuç : ";
            // 
            // label5_sonuc
            // 
            this.label5_sonuc.AutoSize = true;
            this.label5_sonuc.Location = new System.Drawing.Point(113, 283);
            this.label5_sonuc.Name = "label5_sonuc";
            this.label5_sonuc.Size = new System.Drawing.Size(22, 16);
            this.label5_sonuc.TabIndex = 5;
            this.label5_sonuc.Text = ".....";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(511, 343);
            this.Controls.Add(this.label5_sonuc);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button1_hesapla);
            this.Controls.Add(this.textBox2_final);
            this.Controls.Add(this.textBox1_vize);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1_vize;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox2_final;
        private System.Windows.Forms.Button button1_hesapla;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5_sonuc;
    }
}

