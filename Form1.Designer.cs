namespace Exercicio
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
            this.txtNome = new System.Windows.Forms.TextBox();
            this.gbPao = new System.Windows.Forms.GroupBox();
            this.rdbFrances = new System.Windows.Forms.RadioButton();
            this.rdbAmericano = new System.Windows.Forms.RadioButton();
            this.gbCarne = new System.Windows.Forms.GroupBox();
            this.rdbContra = new System.Windows.Forms.RadioButton();
            this.rdbPicanha = new System.Windows.Forms.RadioButton();
            this.gbComplemento = new System.Windows.Forms.GroupBox();
            this.ckbMaionese = new System.Windows.Forms.CheckBox();
            this.ckbCebola = new System.Windows.Forms.CheckBox();
            this.ckbPicles = new System.Windows.Forms.CheckBox();
            this.ckbAlface = new System.Windows.Forms.CheckBox();
            this.btnFechado = new System.Windows.Forms.Button();
            this.lblResultado = new System.Windows.Forms.Label();
            this.btnPesquisa = new System.Windows.Forms.Button();
            this.gbPao.SuspendLayout();
            this.gbCarne.SuspendLayout();
            this.gbComplemento.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Usúario:";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(86, 43);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(132, 20);
            this.txtNome.TabIndex = 1;
            // 
            // gbPao
            // 
            this.gbPao.BackColor = System.Drawing.Color.IndianRed;
            this.gbPao.Controls.Add(this.rdbFrances);
            this.gbPao.Controls.Add(this.rdbAmericano);
            this.gbPao.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbPao.Location = new System.Drawing.Point(16, 132);
            this.gbPao.Name = "gbPao";
            this.gbPao.Size = new System.Drawing.Size(280, 96);
            this.gbPao.TabIndex = 2;
            this.gbPao.TabStop = false;
            this.gbPao.Text = "Pão";
            // 
            // rdbFrances
            // 
            this.rdbFrances.AutoSize = true;
            this.rdbFrances.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbFrances.Location = new System.Drawing.Point(138, 44);
            this.rdbFrances.Name = "rdbFrances";
            this.rdbFrances.Size = new System.Drawing.Size(77, 21);
            this.rdbFrances.TabIndex = 3;
            this.rdbFrances.TabStop = true;
            this.rdbFrances.Text = "Francês";
            this.rdbFrances.UseVisualStyleBackColor = true;
            // 
            // rdbAmericano
            // 
            this.rdbAmericano.AutoSize = true;
            this.rdbAmericano.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbAmericano.Location = new System.Drawing.Point(6, 44);
            this.rdbAmericano.Name = "rdbAmericano";
            this.rdbAmericano.Size = new System.Drawing.Size(93, 21);
            this.rdbAmericano.TabIndex = 0;
            this.rdbAmericano.TabStop = true;
            this.rdbAmericano.Text = "Americano";
            this.rdbAmericano.UseVisualStyleBackColor = true;
            // 
            // gbCarne
            // 
            this.gbCarne.BackColor = System.Drawing.Color.Salmon;
            this.gbCarne.Controls.Add(this.rdbContra);
            this.gbCarne.Controls.Add(this.rdbPicanha);
            this.gbCarne.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbCarne.Location = new System.Drawing.Point(16, 260);
            this.gbCarne.Name = "gbCarne";
            this.gbCarne.Size = new System.Drawing.Size(280, 96);
            this.gbCarne.TabIndex = 3;
            this.gbCarne.TabStop = false;
            this.gbCarne.Text = "Carne";
            // 
            // rdbContra
            // 
            this.rdbContra.AutoSize = true;
            this.rdbContra.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbContra.Location = new System.Drawing.Point(138, 44);
            this.rdbContra.Name = "rdbContra";
            this.rdbContra.Size = new System.Drawing.Size(95, 21);
            this.rdbContra.TabIndex = 3;
            this.rdbContra.TabStop = true;
            this.rdbContra.Text = "Contra-Filé";
            this.rdbContra.UseVisualStyleBackColor = true;
            // 
            // rdbPicanha
            // 
            this.rdbPicanha.AutoSize = true;
            this.rdbPicanha.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbPicanha.Location = new System.Drawing.Point(6, 44);
            this.rdbPicanha.Name = "rdbPicanha";
            this.rdbPicanha.Size = new System.Drawing.Size(77, 21);
            this.rdbPicanha.TabIndex = 0;
            this.rdbPicanha.TabStop = true;
            this.rdbPicanha.Text = "Picanha";
            this.rdbPicanha.UseVisualStyleBackColor = true;
            // 
            // gbComplemento
            // 
            this.gbComplemento.BackColor = System.Drawing.Color.Pink;
            this.gbComplemento.Controls.Add(this.ckbMaionese);
            this.gbComplemento.Controls.Add(this.ckbCebola);
            this.gbComplemento.Controls.Add(this.ckbPicles);
            this.gbComplemento.Controls.Add(this.ckbAlface);
            this.gbComplemento.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbComplemento.Location = new System.Drawing.Point(376, 132);
            this.gbComplemento.Name = "gbComplemento";
            this.gbComplemento.Size = new System.Drawing.Size(200, 224);
            this.gbComplemento.TabIndex = 4;
            this.gbComplemento.TabStop = false;
            this.gbComplemento.Text = "Complementos";
            // 
            // ckbMaionese
            // 
            this.ckbMaionese.AutoSize = true;
            this.ckbMaionese.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckbMaionese.Location = new System.Drawing.Point(20, 188);
            this.ckbMaionese.Name = "ckbMaionese";
            this.ckbMaionese.Size = new System.Drawing.Size(130, 21);
            this.ckbMaionese.TabIndex = 3;
            this.ckbMaionese.Text = "Maionese Verde";
            this.ckbMaionese.UseVisualStyleBackColor = true;
            // 
            // ckbCebola
            // 
            this.ckbCebola.AutoSize = true;
            this.ckbCebola.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckbCebola.Location = new System.Drawing.Point(20, 140);
            this.ckbCebola.Name = "ckbCebola";
            this.ckbCebola.Size = new System.Drawing.Size(107, 21);
            this.ckbCebola.TabIndex = 2;
            this.ckbCebola.Text = "Cebola Roxa";
            this.ckbCebola.UseVisualStyleBackColor = true;
            // 
            // ckbPicles
            // 
            this.ckbPicles.AutoSize = true;
            this.ckbPicles.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckbPicles.Location = new System.Drawing.Point(20, 96);
            this.ckbPicles.Name = "ckbPicles";
            this.ckbPicles.Size = new System.Drawing.Size(64, 21);
            this.ckbPicles.TabIndex = 1;
            this.ckbPicles.Text = "Picles";
            this.ckbPicles.UseVisualStyleBackColor = true;
            // 
            // ckbAlface
            // 
            this.ckbAlface.AutoSize = true;
            this.ckbAlface.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckbAlface.Location = new System.Drawing.Point(20, 47);
            this.ckbAlface.Name = "ckbAlface";
            this.ckbAlface.Size = new System.Drawing.Size(66, 21);
            this.ckbAlface.TabIndex = 0;
            this.ckbAlface.Text = "Alface";
            this.ckbAlface.UseVisualStyleBackColor = true;
            // 
            // btnFechado
            // 
            this.btnFechado.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFechado.Location = new System.Drawing.Point(605, 320);
            this.btnFechado.Name = "btnFechado";
            this.btnFechado.Size = new System.Drawing.Size(166, 36);
            this.btnFechado.TabIndex = 5;
            this.btnFechado.Text = "Pedido Fechado";
            this.btnFechado.UseVisualStyleBackColor = true;
            this.btnFechado.Click += new System.EventHandler(this.btnFechado_Click);
            // 
            // lblResultado
            // 
            this.lblResultado.AutoSize = true;
            this.lblResultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResultado.Location = new System.Drawing.Point(19, 405);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(0, 17);
            this.lblResultado.TabIndex = 6;
            // 
            // btnPesquisa
            // 
            this.btnPesquisa.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPesquisa.Location = new System.Drawing.Point(605, 375);
            this.btnPesquisa.Name = "btnPesquisa";
            this.btnPesquisa.Size = new System.Drawing.Size(166, 43);
            this.btnPesquisa.TabIndex = 8;
            this.btnPesquisa.Text = "Pesquisa";
            this.btnPesquisa.UseVisualStyleBackColor = true;
            this.btnPesquisa.Click += new System.EventHandler(this.btnPesquisa_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PeachPuff;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnPesquisa);
            this.Controls.Add(this.lblResultado);
            this.Controls.Add(this.btnFechado);
            this.Controls.Add(this.gbComplemento);
            this.Controls.Add(this.gbCarne);
            this.Controls.Add(this.gbPao);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "Form1";
            this.Text = "Fast Food";
            this.gbPao.ResumeLayout(false);
            this.gbPao.PerformLayout();
            this.gbCarne.ResumeLayout(false);
            this.gbCarne.PerformLayout();
            this.gbComplemento.ResumeLayout(false);
            this.gbComplemento.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.GroupBox gbPao;
        private System.Windows.Forms.RadioButton rdbFrances;
        private System.Windows.Forms.RadioButton rdbAmericano;
        private System.Windows.Forms.GroupBox gbCarne;
        private System.Windows.Forms.RadioButton rdbContra;
        private System.Windows.Forms.RadioButton rdbPicanha;
        private System.Windows.Forms.GroupBox gbComplemento;
        private System.Windows.Forms.CheckBox ckbMaionese;
        private System.Windows.Forms.CheckBox ckbCebola;
        private System.Windows.Forms.CheckBox ckbPicles;
        private System.Windows.Forms.CheckBox ckbAlface;
        private System.Windows.Forms.Button btnFechado;
        private System.Windows.Forms.Label lblResultado;
        private System.Windows.Forms.Button btnPesquisa;
    }
}

