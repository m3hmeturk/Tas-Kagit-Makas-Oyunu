namespace WindowsFormsApp24
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
            this.components = new System.ComponentModel.Container();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.labelSonuc = new System.Windows.Forms.Label();
            this.buttonTas = new System.Windows.Forms.Button();
            this.buttonKagıt = new System.Windows.Forms.Button();
            this.buttonMakas = new System.Windows.Forms.Button();
            this.labelBotSkor = new System.Windows.Forms.Label();
            this.labelmySkor = new System.Windows.Forms.Label();
            this.labelKazanan = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.Enabled = false;
            this.button1.Location = new System.Drawing.Point(12, 10);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Taş";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.White;
            this.button2.Enabled = false;
            this.button2.Location = new System.Drawing.Point(12, 39);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "Kağıt";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.White;
            this.button3.Enabled = false;
            this.button3.Location = new System.Drawing.Point(12, 68);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 2;
            this.button3.Text = "Makas";
            this.button3.UseVisualStyleBackColor = false;
            // 
            // labelSonuc
            // 
            this.labelSonuc.AutoSize = true;
            this.labelSonuc.Location = new System.Drawing.Point(105, 49);
            this.labelSonuc.Name = "labelSonuc";
            this.labelSonuc.Size = new System.Drawing.Size(0, 13);
            this.labelSonuc.TabIndex = 3;
            // 
            // buttonTas
            // 
            this.buttonTas.Location = new System.Drawing.Point(171, 10);
            this.buttonTas.Name = "buttonTas";
            this.buttonTas.Size = new System.Drawing.Size(75, 23);
            this.buttonTas.TabIndex = 6;
            this.buttonTas.Text = "Taş";
            this.buttonTas.UseVisualStyleBackColor = true;
            this.buttonTas.Click += new System.EventHandler(this.buttonTas_Click);
            // 
            // buttonKagıt
            // 
            this.buttonKagıt.Location = new System.Drawing.Point(171, 39);
            this.buttonKagıt.Name = "buttonKagıt";
            this.buttonKagıt.Size = new System.Drawing.Size(75, 23);
            this.buttonKagıt.TabIndex = 5;
            this.buttonKagıt.Text = "Kağıt";
            this.buttonKagıt.UseVisualStyleBackColor = true;
            this.buttonKagıt.Click += new System.EventHandler(this.kagıt_Click);
            // 
            // buttonMakas
            // 
            this.buttonMakas.Location = new System.Drawing.Point(171, 68);
            this.buttonMakas.Name = "buttonMakas";
            this.buttonMakas.Size = new System.Drawing.Size(75, 23);
            this.buttonMakas.TabIndex = 4;
            this.buttonMakas.Text = "Makas";
            this.buttonMakas.UseVisualStyleBackColor = true;
            this.buttonMakas.Click += new System.EventHandler(this.buttonMakas_Click);
            // 
            // labelBotSkor
            // 
            this.labelBotSkor.AutoSize = true;
            this.labelBotSkor.Location = new System.Drawing.Point(76, 105);
            this.labelBotSkor.Name = "labelBotSkor";
            this.labelBotSkor.Size = new System.Drawing.Size(0, 13);
            this.labelBotSkor.TabIndex = 7;
            // 
            // labelmySkor
            // 
            this.labelmySkor.AutoSize = true;
            this.labelmySkor.Location = new System.Drawing.Point(233, 105);
            this.labelmySkor.Name = "labelmySkor";
            this.labelmySkor.Size = new System.Drawing.Size(0, 13);
            this.labelmySkor.TabIndex = 8;
            // 
            // labelKazanan
            // 
            this.labelKazanan.AutoSize = true;
            this.labelKazanan.Location = new System.Drawing.Point(105, 142);
            this.labelKazanan.Name = "labelKazanan";
            this.labelKazanan.Size = new System.Drawing.Size(0, 13);
            this.labelKazanan.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(311, 215);
            this.Controls.Add(this.labelKazanan);
            this.Controls.Add(this.labelmySkor);
            this.Controls.Add(this.labelBotSkor);
            this.Controls.Add(this.buttonTas);
            this.Controls.Add(this.buttonKagıt);
            this.Controls.Add(this.buttonMakas);
            this.Controls.Add(this.labelSonuc);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label labelSonuc;
        private System.Windows.Forms.Button buttonTas;
        private System.Windows.Forms.Button buttonKagıt;
        private System.Windows.Forms.Button buttonMakas;
        private System.Windows.Forms.Label labelBotSkor;
        private System.Windows.Forms.Label labelmySkor;
        private System.Windows.Forms.Label labelKazanan;
    }
}

