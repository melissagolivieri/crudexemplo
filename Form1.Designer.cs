namespace crudexemplo
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            textboxnome = new TextBox();
            textboxsobrenome = new TextBox();
            textboxcurso = new TextBox();
            textboxano = new TextBox();
            textboxidade = new TextBox();
            textboxRM = new TextBox();
            bottomsalvar = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(45, 32);
            label1.Name = "label1";
            label1.Size = new Size(41, 15);
            label1.TabIndex = 0;
            label1.Text = "nome:";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(45, 76);
            label2.Name = "label2";
            label2.Size = new Size(70, 15);
            label2.TabIndex = 1;
            label2.Text = "sobrenome:";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(45, 104);
            label3.Name = "label3";
            label3.Size = new Size(39, 15);
            label3.TabIndex = 2;
            label3.Text = "curso:";
            label3.Click += label3_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(45, 140);
            label4.Name = "label4";
            label4.Size = new Size(30, 15);
            label4.TabIndex = 3;
            label4.Text = "ano:";
            label4.Click += label4_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(44, 174);
            label5.Name = "label5";
            label5.Size = new Size(39, 15);
            label5.TabIndex = 4;
            label5.Text = "idade:";
            label5.Click += label5_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(44, 214);
            label6.Name = "label6";
            label6.Size = new Size(28, 15);
            label6.TabIndex = 5;
            label6.Text = "RM:";
            label6.Click += label6_Click;
            // 
            // textboxnome
            // 
            textboxnome.Location = new Point(92, 32);
            textboxnome.Name = "textboxnome";
            textboxnome.Size = new Size(242, 23);
            textboxnome.TabIndex = 6;
            // 
            // textboxsobrenome
            // 
            textboxsobrenome.Location = new Point(121, 68);
            textboxsobrenome.Name = "textboxsobrenome";
            textboxsobrenome.Size = new Size(213, 23);
            textboxsobrenome.TabIndex = 7;
            // 
            // textboxcurso
            // 
            textboxcurso.Location = new Point(92, 101);
            textboxcurso.Name = "textboxcurso";
            textboxcurso.Size = new Size(242, 23);
            textboxcurso.TabIndex = 8;
            textboxcurso.TextChanged += textBox3_TextChanged;
            // 
            // textboxano
            // 
            textboxano.Location = new Point(81, 137);
            textboxano.Name = "textboxano";
            textboxano.Size = new Size(253, 23);
            textboxano.TabIndex = 9;
            textboxano.TextChanged += textBox4_TextChanged;
            // 
            // textboxidade
            // 
            textboxidade.Location = new Point(92, 171);
            textboxidade.Name = "textboxidade";
            textboxidade.Size = new Size(242, 23);
            textboxidade.TabIndex = 10;
            // 
            // textboxRM
            // 
            textboxRM.Location = new Point(78, 211);
            textboxRM.Name = "textboxRM";
            textboxRM.Size = new Size(256, 23);
            textboxRM.TabIndex = 11;
            // 
            // bottomsalvar
            // 
            bottomsalvar.BackColor = Color.RosyBrown;
            bottomsalvar.ForeColor = Color.LavenderBlush;
            bottomsalvar.Location = new Point(45, 257);
            bottomsalvar.Name = "bottomsalvar";
            bottomsalvar.Size = new Size(177, 41);
            bottomsalvar.TabIndex = 12;
            bottomsalvar.Text = "salvar ";
            bottomsalvar.UseVisualStyleBackColor = false;
            bottomsalvar.Click += bottomsalvar_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MistyRose;
            ClientSize = new Size(800, 450);
            Controls.Add(bottomsalvar);
            Controls.Add(textboxRM);
            Controls.Add(textboxidade);
            Controls.Add(textboxano);
            Controls.Add(textboxcurso);
            Controls.Add(textboxsobrenome);
            Controls.Add(textboxnome);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox textboxnome;
        private TextBox textboxsobrenome;
        private TextBox textboxcurso;
        private TextBox textboxano;
        private TextBox textboxidade;
        private TextBox textboxRM;
        private Button bottomsalvar;
    }
}
