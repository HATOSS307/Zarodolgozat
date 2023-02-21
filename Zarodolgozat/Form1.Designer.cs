namespace Zarodolgozat
{
    partial class form_nyit
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
            this.textBox_id = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox1_felhasznalonev = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1_jelszo = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.button_bejelentkez = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(151, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(232, 68);
            this.label1.TabIndex = 0;
            this.label1.Text = "Bejelentkezés";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBox_id
            // 
            this.textBox_id.Location = new System.Drawing.Point(224, 150);
            this.textBox_id.Name = "textBox_id";
            this.textBox_id.ReadOnly = true;
            this.textBox_id.Size = new System.Drawing.Size(59, 20);
            this.textBox_id.TabIndex = 76;
            this.textBox_id.Visible = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(199, 153);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(19, 13);
            this.label5.TabIndex = 75;
            this.label5.Text = "Id:";
            this.label5.Visible = false;
            // 
            // textBox1_felhasznalonev
            // 
            this.textBox1_felhasznalonev.AccessibleRole = System.Windows.Forms.AccessibleRole.SplitButton;
            this.textBox1_felhasznalonev.Location = new System.Drawing.Point(224, 176);
            this.textBox1_felhasznalonev.Name = "textBox1_felhasznalonev";
            this.textBox1_felhasznalonev.Size = new System.Drawing.Size(138, 20);
            this.textBox1_felhasznalonev.TabIndex = 74;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(134, 179);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 13);
            this.label2.TabIndex = 73;
            this.label2.Text = "Felhasználónév:";
            // 
            // textBox1_jelszo
            // 
            this.textBox1_jelszo.AccessibleRole = System.Windows.Forms.AccessibleRole.SplitButton;
            this.textBox1_jelszo.Location = new System.Drawing.Point(224, 202);
            this.textBox1_jelszo.Name = "textBox1_jelszo";
            this.textBox1_jelszo.Size = new System.Drawing.Size(138, 20);
            this.textBox1_jelszo.TabIndex = 78;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(179, 205);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 13);
            this.label3.TabIndex = 77;
            this.label3.Text = "Jelszó:";
            // 
            // button_bejelentkez
            // 
            this.button_bejelentkez.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_bejelentkez.ForeColor = System.Drawing.Color.Blue;
            this.button_bejelentkez.Location = new System.Drawing.Point(224, 259);
            this.button_bejelentkez.Name = "button_bejelentkez";
            this.button_bejelentkez.Size = new System.Drawing.Size(122, 38);
            this.button_bejelentkez.TabIndex = 79;
            this.button_bejelentkez.Text = "Bejelentkezés";
            this.button_bejelentkez.UseVisualStyleBackColor = true;
            // 
            // form_nyit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(514, 367);
            this.Controls.Add(this.button_bejelentkez);
            this.Controls.Add(this.textBox1_jelszo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox_id);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBox1_felhasznalonev);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "form_nyit";
            this.Text = "Kezdőlap";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_id;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox1_felhasznalonev;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1_jelszo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button_bejelentkez;
    }
}

