namespace TP.Aula08.Async
{
    partial class Calcular
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
            this.lblFolha = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.gpbResultado = new System.Windows.Forms.GroupBox();
            this.lblImpostos = new System.Windows.Forms.Label();
            this.lblReceitas = new System.Windows.Forms.Label();
            this.lblDespesas = new System.Windows.Forms.Label();
            this.lblTempo = new System.Windows.Forms.Label();
            this.gpbResultado.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblFolha
            // 
            this.lblFolha.AutoSize = true;
            this.lblFolha.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblFolha.Location = new System.Drawing.Point(20, 43);
            this.lblFolha.Name = "lblFolha";
            this.lblFolha.Size = new System.Drawing.Size(0, 22);
            this.lblFolha.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(102, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(425, 38);
            this.label2.TabIndex = 2;
            this.label2.Text = "Pressione o botão para executar os cáculos\r\nde Folha de pagamento, Impostos, Rece" +
    "itas, Despesas";
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(569, 40);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(91, 41);
            this.btnCalcular.TabIndex = 3;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // gpbResultado
            // 
            this.gpbResultado.Controls.Add(this.lblTempo);
            this.gpbResultado.Controls.Add(this.lblDespesas);
            this.gpbResultado.Controls.Add(this.lblReceitas);
            this.gpbResultado.Controls.Add(this.lblImpostos);
            this.gpbResultado.Controls.Add(this.lblFolha);
            this.gpbResultado.Location = new System.Drawing.Point(66, 176);
            this.gpbResultado.Name = "gpbResultado";
            this.gpbResultado.Size = new System.Drawing.Size(687, 262);
            this.gpbResultado.TabIndex = 4;
            this.gpbResultado.TabStop = false;
            // 
            // lblImpostos
            // 
            this.lblImpostos.AutoSize = true;
            this.lblImpostos.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblImpostos.Location = new System.Drawing.Point(20, 84);
            this.lblImpostos.Name = "lblImpostos";
            this.lblImpostos.Size = new System.Drawing.Size(0, 22);
            this.lblImpostos.TabIndex = 2;
            // 
            // lblReceitas
            // 
            this.lblReceitas.AutoSize = true;
            this.lblReceitas.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblReceitas.Location = new System.Drawing.Point(20, 127);
            this.lblReceitas.Name = "lblReceitas";
            this.lblReceitas.Size = new System.Drawing.Size(0, 22);
            this.lblReceitas.TabIndex = 3;
            // 
            // lblDespesas
            // 
            this.lblDespesas.AutoSize = true;
            this.lblDespesas.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblDespesas.Location = new System.Drawing.Point(20, 168);
            this.lblDespesas.Name = "lblDespesas";
            this.lblDespesas.Size = new System.Drawing.Size(0, 22);
            this.lblDespesas.TabIndex = 4;
            // 
            // lblTempo
            // 
            this.lblTempo.AutoSize = true;
            this.lblTempo.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTempo.Location = new System.Drawing.Point(20, 210);
            this.lblTempo.Name = "lblTempo";
            this.lblTempo.Size = new System.Drawing.Size(0, 22);
            this.lblTempo.TabIndex = 5;
            // 
            // Calcular
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.gpbResultado);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.label2);
            this.Name = "Calcular";
            this.Text = "Calcular";
            this.gpbResultado.ResumeLayout(false);
            this.gpbResultado.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblFolha;
        private Label label2;
        private Button btnCalcular;
        private GroupBox gpbResultado;
        private Label lblDespesas;
        private Label lblReceitas;
        private Label lblImpostos;
        private Label lblTempo;
    }
}