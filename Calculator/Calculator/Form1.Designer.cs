
namespace Calculator
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.sonuc = new System.Windows.Forms.Label();
            this.bol = new System.Windows.Forms.Button();
            this.carp = new System.Windows.Forms.Button();
            this.cikar = new System.Windows.Forms.Button();
            this.topla = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // sonuc
            // 
            this.sonuc.AutoSize = true;
            this.sonuc.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.sonuc.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.sonuc.Location = new System.Drawing.Point(23, 107);
            this.sonuc.Name = "sonuc";
            this.sonuc.Size = new System.Drawing.Size(85, 25);
            this.sonuc.TabIndex = 12;
            this.sonuc.Text = "Sonuç : ";
            // 
            // bol
            // 
            this.bol.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.bol.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bol.Location = new System.Drawing.Point(194, 56);
            this.bol.Name = "bol";
            this.bol.Size = new System.Drawing.Size(44, 38);
            this.bol.TabIndex = 11;
            this.bol.Text = "/";
            this.bol.UseVisualStyleBackColor = false;
            this.bol.Click += new System.EventHandler(this.bol_Click);
            // 
            // carp
            // 
            this.carp.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.carp.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.carp.Location = new System.Drawing.Point(144, 56);
            this.carp.Name = "carp";
            this.carp.Size = new System.Drawing.Size(44, 38);
            this.carp.TabIndex = 10;
            this.carp.Text = "*";
            this.carp.UseVisualStyleBackColor = false;
            this.carp.Click += new System.EventHandler(this.carp_Click);
            // 
            // cikar
            // 
            this.cikar.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.cikar.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cikar.Location = new System.Drawing.Point(194, 12);
            this.cikar.Name = "cikar";
            this.cikar.Size = new System.Drawing.Size(44, 38);
            this.cikar.TabIndex = 9;
            this.cikar.Text = "-";
            this.cikar.UseVisualStyleBackColor = false;
            this.cikar.Click += new System.EventHandler(this.cikar_Click);
            // 
            // topla
            // 
            this.topla.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.topla.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.topla.Location = new System.Drawing.Point(144, 12);
            this.topla.Name = "topla";
            this.topla.Size = new System.Drawing.Size(44, 38);
            this.topla.TabIndex = 7;
            this.topla.Text = "+";
            this.topla.UseVisualStyleBackColor = false;
            this.topla.Click += new System.EventHandler(this.topla_Click);
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox2.Location = new System.Drawing.Point(8, 57);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(128, 38);
            this.textBox2.TabIndex = 8;
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox1.Location = new System.Drawing.Point(8, 13);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(128, 38);
            this.textBox1.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.OliveDrab;
            this.ClientSize = new System.Drawing.Size(250, 163);
            this.Controls.Add(this.sonuc);
            this.Controls.Add(this.bol);
            this.Controls.Add(this.carp);
            this.Controls.Add(this.cikar);
            this.Controls.Add(this.topla);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Name = "Form1";
            this.Text = "Calculator Pro";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label sonuc;
        private System.Windows.Forms.Button bol;
        private System.Windows.Forms.Button carp;
        private System.Windows.Forms.Button cikar;
        private System.Windows.Forms.Button topla;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
    }
}

