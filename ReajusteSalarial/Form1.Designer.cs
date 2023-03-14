namespace ReajusteSalarial
{
    partial class ReajusteSalarial
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.categoria = new System.Windows.Forms.GroupBox();
            this.rbnVeterano = new System.Windows.Forms.RadioButton();
            this.rbnCalouro = new System.Windows.Forms.RadioButton();
            this.Turno = new System.Windows.Forms.GroupBox();
            this.rbnNoturno = new System.Windows.Forms.RadioButton();
            this.rbnVespertino = new System.Windows.Forms.RadioButton();
            this.RbnMatutino = new System.Windows.Forms.RadioButton();
            this.lblResultado = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.txtHorasTrabalhadas = new System.Windows.Forms.TextBox();
            this.lblAnalise = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.categoria.SuspendLayout();
            this.Turno.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label1.Location = new System.Drawing.Point(12, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Salário Minimo:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label2.Location = new System.Drawing.Point(10, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 19);
            this.label2.TabIndex = 2;
            this.label2.Text = "Horas Trabalhadas:";
            // 
            // categoria
            // 
            this.categoria.BackColor = System.Drawing.Color.MediumTurquoise;
            this.categoria.Controls.Add(this.rbnVeterano);
            this.categoria.Controls.Add(this.rbnCalouro);
            this.categoria.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.categoria.ForeColor = System.Drawing.Color.White;
            this.categoria.Location = new System.Drawing.Point(13, 75);
            this.categoria.Name = "categoria";
            this.categoria.Size = new System.Drawing.Size(260, 53);
            this.categoria.TabIndex = 3;
            this.categoria.TabStop = false;
            this.categoria.Text = "Categoria";
            this.categoria.Enter += new System.EventHandler(this.categoria_Enter);
            // 
            // rbnVeterano
            // 
            this.rbnVeterano.AutoSize = true;
            this.rbnVeterano.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.rbnVeterano.Location = new System.Drawing.Point(98, 19);
            this.rbnVeterano.Name = "rbnVeterano";
            this.rbnVeterano.Size = new System.Drawing.Size(68, 17);
            this.rbnVeterano.TabIndex = 1;
            this.rbnVeterano.TabStop = true;
            this.rbnVeterano.Text = "Veterano";
            this.rbnVeterano.UseVisualStyleBackColor = true;
            this.rbnVeterano.CheckedChanged += new System.EventHandler(this.rbnVeterano_CheckedChanged);
            // 
            // rbnCalouro
            // 
            this.rbnCalouro.AutoSize = true;
            this.rbnCalouro.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.rbnCalouro.Location = new System.Drawing.Point(6, 19);
            this.rbnCalouro.Name = "rbnCalouro";
            this.rbnCalouro.Size = new System.Drawing.Size(61, 17);
            this.rbnCalouro.TabIndex = 0;
            this.rbnCalouro.TabStop = true;
            this.rbnCalouro.Text = "Calouro";
            this.rbnCalouro.UseVisualStyleBackColor = true;
            this.rbnCalouro.CheckedChanged += new System.EventHandler(this.rbnCalouro_CheckedChanged);
            // 
            // Turno
            // 
            this.Turno.BackColor = System.Drawing.Color.MediumTurquoise;
            this.Turno.Controls.Add(this.rbnNoturno);
            this.Turno.Controls.Add(this.rbnVespertino);
            this.Turno.Controls.Add(this.RbnMatutino);
            this.Turno.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Turno.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.Turno.ForeColor = System.Drawing.Color.White;
            this.Turno.Location = new System.Drawing.Point(296, 12);
            this.Turno.Name = "Turno";
            this.Turno.Size = new System.Drawing.Size(125, 116);
            this.Turno.TabIndex = 4;
            this.Turno.TabStop = false;
            this.Turno.Text = "Turno";
            this.Turno.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // rbnNoturno
            // 
            this.rbnNoturno.AutoSize = true;
            this.rbnNoturno.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.rbnNoturno.Location = new System.Drawing.Point(6, 65);
            this.rbnNoturno.Name = "rbnNoturno";
            this.rbnNoturno.Size = new System.Drawing.Size(69, 19);
            this.rbnNoturno.TabIndex = 2;
            this.rbnNoturno.TabStop = true;
            this.rbnNoturno.Text = "Noturno";
            this.rbnNoturno.UseVisualStyleBackColor = true;
            this.rbnNoturno.CheckedChanged += new System.EventHandler(this.rbnNoturno_CheckedChanged);
            // 
            // rbnVespertino
            // 
            this.rbnVespertino.AutoSize = true;
            this.rbnVespertino.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.rbnVespertino.Location = new System.Drawing.Point(6, 42);
            this.rbnVespertino.Name = "rbnVespertino";
            this.rbnVespertino.Size = new System.Drawing.Size(83, 19);
            this.rbnVespertino.TabIndex = 1;
            this.rbnVespertino.TabStop = true;
            this.rbnVespertino.Text = "Vespertino";
            this.rbnVespertino.UseVisualStyleBackColor = true;
            this.rbnVespertino.CheckedChanged += new System.EventHandler(this.radioButton3_CheckedChanged);
            // 
            // RbnMatutino
            // 
            this.RbnMatutino.AutoSize = true;
            this.RbnMatutino.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.RbnMatutino.Location = new System.Drawing.Point(6, 19);
            this.RbnMatutino.Name = "RbnMatutino";
            this.RbnMatutino.Size = new System.Drawing.Size(73, 19);
            this.RbnMatutino.TabIndex = 0;
            this.RbnMatutino.TabStop = true;
            this.RbnMatutino.Text = "Matutino";
            this.RbnMatutino.UseVisualStyleBackColor = true;
            this.RbnMatutino.CheckedChanged += new System.EventHandler(this.radioButton4_CheckedChanged);
            // 
            // lblResultado
            // 
            this.lblResultado.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblResultado.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblResultado.Font = new System.Drawing.Font("Segoe UI Black", 13F, System.Drawing.FontStyle.Bold);
            this.lblResultado.ForeColor = System.Drawing.Color.DarkOrange;
            this.lblResultado.Image = global::ReajusteSalarial.Properties.Resources.b4d42a316e2510dec5a1e6950414cca3;
            this.lblResultado.Location = new System.Drawing.Point(0, 131);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(449, 232);
            this.lblResultado.TabIndex = 5;
            this.lblResultado.Click += new System.EventHandler(this.label3_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(128, 18);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(145, 20);
            this.textBox1.TabIndex = 6;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txtHorasTrabalhadas
            // 
            this.txtHorasTrabalhadas.Location = new System.Drawing.Point(138, 49);
            this.txtHorasTrabalhadas.Name = "txtHorasTrabalhadas";
            this.txtHorasTrabalhadas.Size = new System.Drawing.Size(135, 20);
            this.txtHorasTrabalhadas.TabIndex = 7;
            this.txtHorasTrabalhadas.TextChanged += new System.EventHandler(this.txtHorasTrabalhadas_TextChanged);
            // 
            // lblAnalise
            // 
            this.lblAnalise.BackColor = System.Drawing.Color.MediumTurquoise;
            this.lblAnalise.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblAnalise.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblAnalise.Location = new System.Drawing.Point(16, 322);
            this.lblAnalise.Name = "lblAnalise";
            this.lblAnalise.Size = new System.Drawing.Size(299, 22);
            this.lblAnalise.TabIndex = 8;
            this.lblAnalise.Click += new System.EventHandler(this.lblAnalise_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.MediumTurquoise;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button1.Location = new System.Drawing.Point(337, 322);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 25);
            this.button1.TabIndex = 9;
            this.button1.Text = "Calcular";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = global::ReajusteSalarial.Properties.Resources.b4d42a316e2510dec5a1e6950414cca3;
            this.pictureBox1.InitialImage = global::ReajusteSalarial.Properties.Resources.b4d42a316e2510dec5a1e6950414cca3;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(449, 363);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // ReajusteSalarial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(449, 363);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblAnalise);
            this.Controls.Add(this.txtHorasTrabalhadas);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lblResultado);
            this.Controls.Add(this.Turno);
            this.Controls.Add(this.categoria);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "ReajusteSalarial";
            this.Text = "ReajusteSalarial";
            this.categoria.ResumeLayout(false);
            this.categoria.PerformLayout();
            this.Turno.ResumeLayout(false);
            this.Turno.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox categoria;
        private System.Windows.Forms.RadioButton rbnVeterano;
        private System.Windows.Forms.RadioButton rbnCalouro;
        private System.Windows.Forms.GroupBox Turno;
        private System.Windows.Forms.RadioButton rbnVespertino;
        private System.Windows.Forms.RadioButton RbnMatutino;
        private System.Windows.Forms.RadioButton rbnNoturno;
        private System.Windows.Forms.Label lblResultado;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox txtHorasTrabalhadas;
        private System.Windows.Forms.Label lblAnalise;
        private System.Windows.Forms.Button button1;
    }
}

