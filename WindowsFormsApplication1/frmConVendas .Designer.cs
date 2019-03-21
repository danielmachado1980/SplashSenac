namespace WindowsFormsApplication1
{
    partial class frmConVendas
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
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.lstviewVendas = new System.Windows.Forms.ListView();
            this.label2 = new System.Windows.Forms.Label();
            this.txtValorDe = new System.Windows.Forms.MaskedTextBox();
            this.txtValorAte = new System.Windows.Forms.MaskedTextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 20);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "De";
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.Location = new System.Drawing.Point(604, 39);
            this.btnPesquisar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(100, 28);
            this.btnPesquisar.TabIndex = 4;
            this.btnPesquisar.Text = "Pesquisar";
            this.btnPesquisar.UseVisualStyleBackColor = true;
            this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click);
            // 
            // lstviewVendas
            // 
            this.lstviewVendas.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lstviewVendas.GridLines = true;
            this.lstviewVendas.Location = new System.Drawing.Point(0, 129);
            this.lstviewVendas.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lstviewVendas.Name = "lstviewVendas";
            this.lstviewVendas.Size = new System.Drawing.Size(720, 264);
            this.lstviewVendas.TabIndex = 5;
            this.lstviewVendas.UseCompatibleStateImageBehavior = false;
            this.lstviewVendas.View = System.Windows.Forms.View.Details;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(98, 20);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 17);
            this.label2.TabIndex = 7;
            this.label2.Text = "Até";
            // 
            // txtValorDe
            // 
            this.txtValorDe.Location = new System.Drawing.Point(13, 39);
            this.txtValorDe.Mask = "000,000.00";
            this.txtValorDe.Name = "txtValorDe";
            this.txtValorDe.Size = new System.Drawing.Size(68, 22);
            this.txtValorDe.TabIndex = 8;
            // 
            // txtValorAte
            // 
            this.txtValorAte.Location = new System.Drawing.Point(101, 39);
            this.txtValorAte.Mask = "000,000.00";
            this.txtValorAte.Name = "txtValorAte";
            this.txtValorAte.Size = new System.Drawing.Size(68, 22);
            this.txtValorAte.TabIndex = 9;
            // 
            // frmConVendas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(720, 393);
            this.Controls.Add(this.txtValorAte);
            this.Controls.Add(this.txtValorDe);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lstviewVendas);
            this.Controls.Add(this.btnPesquisar);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmConVendas";
            this.ShowIcon = false;
            this.Text = "Consulta de Vendas";
            this.Load += new System.EventHandler(this.frmConClientes_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.ListView lstviewVendas;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MaskedTextBox txtValorDe;
        private System.Windows.Forms.MaskedTextBox txtValorAte;
    }
}