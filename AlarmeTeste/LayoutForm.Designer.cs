namespace AlarmeTeste
{
    partial class LayoutForm
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
            this.components = new System.ComponentModel.Container();
            this.btnProgramar = new System.Windows.Forms.Button();
            this.btnParar = new System.Windows.Forms.Button();
            this.mtbProgram = new System.Windows.Forms.MaskedTextBox();
            this.lblRelogio = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnProgramar
            // 
            this.btnProgramar.Location = new System.Drawing.Point(227, 142);
            this.btnProgramar.Name = "btnProgramar";
            this.btnProgramar.Size = new System.Drawing.Size(117, 23);
            this.btnProgramar.TabIndex = 0;
            this.btnProgramar.Text = "Programar";
            this.btnProgramar.UseVisualStyleBackColor = true;
            this.btnProgramar.Click += new System.EventHandler(this.btnProgramar_Click);
            // 
            // btnParar
            // 
            this.btnParar.Enabled = false;
            this.btnParar.Location = new System.Drawing.Point(352, 142);
            this.btnParar.Name = "btnParar";
            this.btnParar.Size = new System.Drawing.Size(117, 23);
            this.btnParar.TabIndex = 1;
            this.btnParar.Text = "Parar";
            this.btnParar.UseVisualStyleBackColor = true;
            this.btnParar.Click += new System.EventHandler(this.btnParar_Click);
            // 
            // mtbProgram
            // 
            this.mtbProgram.BackColor = System.Drawing.SystemColors.Control;
            this.mtbProgram.Location = new System.Drawing.Point(28, 144);
            this.mtbProgram.Name = "mtbProgram";
            this.mtbProgram.Size = new System.Drawing.Size(193, 20);
            this.mtbProgram.TabIndex = 2;
            this.mtbProgram.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.mtbProgram_MaskInputRejected);
            // 
            // lblRelogio
            // 
            this.lblRelogio.AutoSize = true;
            this.lblRelogio.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRelogio.Location = new System.Drawing.Point(159, 41);
            this.lblRelogio.Name = "lblRelogio";
            this.lblRelogio.Size = new System.Drawing.Size(118, 25);
            this.lblRelogio.TabIndex = 3;
            this.lblRelogio.Text = "00:00:00";
            this.lblRelogio.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblRelogio.Click += new System.EventHandler(this.lblRelogio_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblRelogio);
            this.groupBox1.Location = new System.Drawing.Point(28, 24);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(441, 101);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            // 
            // LayoutForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(509, 192);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.mtbProgram);
            this.Controls.Add(this.btnParar);
            this.Controls.Add(this.btnProgramar);
            this.Name = "LayoutForm";
            this.Text = "Alarm Ponto Mais";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnProgramar;
        private System.Windows.Forms.Button btnParar;
        private System.Windows.Forms.MaskedTextBox mtbProgram;
        private System.Windows.Forms.Label lblRelogio;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}

