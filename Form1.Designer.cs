namespace SimplePaint
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.buttonSalvar = new System.Windows.Forms.Button();
            this.buttonLimpar = new System.Windows.Forms.Button();
            this.buttonApagar = new System.Windows.Forms.Button();
            this.comboBoxEspessura = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonCorDaCaneta = new System.Windows.Forms.Button();
            this.panelPintura = new System.Windows.Forms.Panel();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.buttonSalvar);
            this.groupBox1.Controls.Add(this.buttonLimpar);
            this.groupBox1.Controls.Add(this.buttonApagar);
            this.groupBox1.Controls.Add(this.comboBoxEspessura);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.buttonCorDaCaneta);
            this.groupBox1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(776, 94);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Peronalizar";
            // 
            // buttonSalvar
            // 
            this.buttonSalvar.BackColor = System.Drawing.Color.Black;
            this.buttonSalvar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSalvar.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSalvar.ForeColor = System.Drawing.Color.White;
            this.buttonSalvar.Location = new System.Drawing.Point(664, 39);
            this.buttonSalvar.Name = "buttonSalvar";
            this.buttonSalvar.Size = new System.Drawing.Size(92, 29);
            this.buttonSalvar.TabIndex = 9;
            this.buttonSalvar.Text = "Salvar";
            this.buttonSalvar.UseVisualStyleBackColor = false;
            this.buttonSalvar.Click += new System.EventHandler(this.buttonSalvar_Click);
            // 
            // buttonLimpar
            // 
            this.buttonLimpar.BackColor = System.Drawing.Color.Black;
            this.buttonLimpar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonLimpar.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLimpar.ForeColor = System.Drawing.Color.White;
            this.buttonLimpar.Location = new System.Drawing.Point(566, 39);
            this.buttonLimpar.Name = "buttonLimpar";
            this.buttonLimpar.Size = new System.Drawing.Size(92, 29);
            this.buttonLimpar.TabIndex = 8;
            this.buttonLimpar.Text = "Limpar";
            this.buttonLimpar.UseVisualStyleBackColor = false;
            this.buttonLimpar.Click += new System.EventHandler(this.buttonLimpar_Click);
            // 
            // buttonApagar
            // 
            this.buttonApagar.BackColor = System.Drawing.Color.Black;
            this.buttonApagar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonApagar.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonApagar.ForeColor = System.Drawing.Color.White;
            this.buttonApagar.Location = new System.Drawing.Point(445, 39);
            this.buttonApagar.Name = "buttonApagar";
            this.buttonApagar.Size = new System.Drawing.Size(115, 29);
            this.buttonApagar.TabIndex = 7;
            this.buttonApagar.Text = "Borracha";
            this.buttonApagar.UseVisualStyleBackColor = false;
            this.buttonApagar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.buttonApagar_MouseDown);
            // 
            // comboBoxEspessura
            // 
            this.comboBoxEspessura.FormattingEnabled = true;
            this.comboBoxEspessura.Location = new System.Drawing.Point(359, 41);
            this.comboBoxEspessura.Name = "comboBoxEspessura";
            this.comboBoxEspessura.Size = new System.Drawing.Size(67, 26);
            this.comboBoxEspessura.TabIndex = 6;
            this.comboBoxEspessura.SelectedIndexChanged += new System.EventHandler(this.comboBoxEspessura_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(193, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(160, 18);
            this.label2.TabIndex = 5;
            this.label2.Text = "Espessura da Caneta";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 18);
            this.label1.TabIndex = 4;
            this.label1.Text = "Cor da Caneta";
            // 
            // buttonCorDaCaneta
            // 
            this.buttonCorDaCaneta.BackColor = System.Drawing.Color.Blue;
            this.buttonCorDaCaneta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCorDaCaneta.Location = new System.Drawing.Point(129, 42);
            this.buttonCorDaCaneta.Name = "buttonCorDaCaneta";
            this.buttonCorDaCaneta.Size = new System.Drawing.Size(48, 23);
            this.buttonCorDaCaneta.TabIndex = 0;
            this.buttonCorDaCaneta.UseVisualStyleBackColor = false;
            this.buttonCorDaCaneta.Click += new System.EventHandler(this.CorDaCaneta_Click);
            // 
            // panelPintura
            // 
            this.panelPintura.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelPintura.BackColor = System.Drawing.Color.White;
            this.panelPintura.Location = new System.Drawing.Point(12, 112);
            this.panelPintura.Name = "panelPintura";
            this.panelPintura.Size = new System.Drawing.Size(776, 326);
            this.panelPintura.TabIndex = 1;
            this.panelPintura.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelPintura_MouseDown);
            this.panelPintura.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panelPintura_MouseMove);
            this.panelPintura.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panelPintura_MouseUp);
            this.panelPintura.Resize += new System.EventHandler(this.panelPintura_Resize);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panelPintura);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.ShowIcon = false;
            this.Text = "SimplePaint";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button buttonSalvar;
        private System.Windows.Forms.Button buttonLimpar;
        private System.Windows.Forms.Button buttonApagar;
        private System.Windows.Forms.ComboBox comboBoxEspessura;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonCorDaCaneta;
        private System.Windows.Forms.Panel panelPintura;
    }
}

