namespace Calculadora_Grafica
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">verdade se for necessário descartar os recursos gerenciados; caso contrário, falso.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte do Designer - não modifique
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.gbCalculos = new System.Windows.Forms.GroupBox();
            this.rbVolume = new System.Windows.Forms.RadioButton();
            this.rbPerimetro = new System.Windows.Forms.RadioButton();
            this.rbArea = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.txtRaio = new System.Windows.Forms.TextBox();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.lbResultado = new System.Windows.Forms.Label();
            this.pnDesenho = new System.Windows.Forms.Panel();
            this.opDesenhar = new System.Windows.Forms.CheckBox();
            this.gbCalculos.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbCalculos
            // 
            this.gbCalculos.BackColor = System.Drawing.Color.Transparent;
            this.gbCalculos.Controls.Add(this.rbVolume);
            this.gbCalculos.Controls.Add(this.rbPerimetro);
            this.gbCalculos.Controls.Add(this.rbArea);
            this.gbCalculos.Location = new System.Drawing.Point(145, 23);
            this.gbCalculos.Name = "gbCalculos";
            this.gbCalculos.Size = new System.Drawing.Size(146, 86);
            this.gbCalculos.TabIndex = 0;
            this.gbCalculos.TabStop = false;
            this.gbCalculos.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // rbVolume
            // 
            this.rbVolume.AutoSize = true;
            this.rbVolume.Location = new System.Drawing.Point(7, 58);
            this.rbVolume.Name = "rbVolume";
            this.rbVolume.Size = new System.Drawing.Size(123, 17);
            this.rbVolume.TabIndex = 3;
            this.rbVolume.Text = "VOLUME CIRCULO";
            this.rbVolume.UseVisualStyleBackColor = true;
            this.rbVolume.CheckedChanged += new System.EventHandler(this.radioButton3_CheckedChanged);
            // 
            // rbPerimetro
            // 
            this.rbPerimetro.AutoSize = true;
            this.rbPerimetro.Location = new System.Drawing.Point(7, 34);
            this.rbPerimetro.Name = "rbPerimetro";
            this.rbPerimetro.Size = new System.Drawing.Size(138, 17);
            this.rbPerimetro.TabIndex = 2;
            this.rbPerimetro.Text = "PERIMETRO CIRCULO";
            this.rbPerimetro.UseVisualStyleBackColor = true;
            // 
            // rbArea
            // 
            this.rbArea.AutoSize = true;
            this.rbArea.Checked = true;
            this.rbArea.ForeColor = System.Drawing.Color.DarkOrange;
            this.rbArea.Location = new System.Drawing.Point(7, 11);
            this.rbArea.Name = "rbArea";
            this.rbArea.Size = new System.Drawing.Size(106, 17);
            this.rbArea.TabIndex = 1;
            this.rbArea.TabStop = true;
            this.rbArea.Text = "AREA CIRCULO";
            this.rbArea.UseVisualStyleBackColor = true;
            this.rbArea.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(12, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "DIGITE O RAIO:";
            // 
            // txtRaio
            // 
            this.txtRaio.Location = new System.Drawing.Point(15, 49);
            this.txtRaio.Name = "txtRaio";
            this.txtRaio.Size = new System.Drawing.Size(87, 20);
            this.txtRaio.TabIndex = 2;
            // 
            // btnCalcular
            // 
            this.btnCalcular.BackColor = System.Drawing.Color.DarkOrange;
            this.btnCalcular.ForeColor = System.Drawing.Color.White;
            this.btnCalcular.Location = new System.Drawing.Point(15, 75);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(87, 23);
            this.btnCalcular.TabIndex = 3;
            this.btnCalcular.Text = "CALCULAR";
            this.btnCalcular.UseVisualStyleBackColor = false;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // lbResultado
            // 
            this.lbResultado.BackColor = System.Drawing.Color.Transparent;
            this.lbResultado.Location = new System.Drawing.Point(13, 263);
            this.lbResultado.Name = "lbResultado";
            this.lbResultado.Size = new System.Drawing.Size(278, 26);
            this.lbResultado.TabIndex = 4;
            this.lbResultado.Text = "RESPOSTA = 0";
            this.lbResultado.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lbResultado.Click += new System.EventHandler(this.lbResultado_Click);
            // 
            // pnDesenho
            // 
            this.pnDesenho.BackColor = System.Drawing.Color.Transparent;
            this.pnDesenho.Location = new System.Drawing.Point(16, 115);
            this.pnDesenho.Name = "pnDesenho";
            this.pnDesenho.Size = new System.Drawing.Size(274, 145);
            this.pnDesenho.TabIndex = 5;
            // 
            // opDesenhar
            // 
            this.opDesenhar.AutoSize = true;
            this.opDesenhar.BackColor = System.Drawing.Color.Transparent;
            this.opDesenhar.Checked = true;
            this.opDesenhar.CheckState = System.Windows.Forms.CheckState.Checked;
            this.opDesenhar.Location = new System.Drawing.Point(16, 262);
            this.opDesenhar.Name = "opDesenhar";
            this.opDesenhar.Size = new System.Drawing.Size(74, 17);
            this.opDesenhar.TabIndex = 6;
            this.opDesenhar.Text = "Desenhar";
            this.opDesenhar.UseVisualStyleBackColor = false;
            this.opDesenhar.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(301, 293);
            this.Controls.Add(this.opDesenhar);
            this.Controls.Add(this.pnDesenho);
            this.Controls.Add(this.lbResultado);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.txtRaio);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gbCalculos);
            this.Font = new System.Drawing.Font("Rockwell", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.DarkOrange;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CALCULADORA GRÁFICA";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gbCalculos.ResumeLayout(false);
            this.gbCalculos.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbCalculos;
        private System.Windows.Forms.RadioButton rbArea;
        private System.Windows.Forms.RadioButton rbVolume;
        private System.Windows.Forms.RadioButton rbPerimetro;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtRaio;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Label lbResultado;
        private System.Windows.Forms.Panel pnDesenho;
        private System.Windows.Forms.CheckBox opDesenhar;
    }
}

