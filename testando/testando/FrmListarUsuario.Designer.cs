namespace testando
{
    partial class FrmListarUsuario
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
            btnPesquisar = new Button();
            dtUsuario = new DataGridView();
            textBoxPesquisa = new TextBox();
            btnImprimir = new Button();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dtUsuario).BeginInit();
            SuspendLayout();
            // 
            // btnPesquisar
            // 
            btnPesquisar.Location = new Point(257, 307);
            btnPesquisar.Name = "btnPesquisar";
            btnPesquisar.Size = new Size(100, 23);
            btnPesquisar.TabIndex = 0;
            btnPesquisar.Text = "Pesquisar";
            btnPesquisar.UseVisualStyleBackColor = true;
            btnPesquisar.Click += btnPesquisar_Click;
            // 
            // dtUsuario
            // 
            dtUsuario.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtUsuario.Location = new Point(191, 123);
            dtUsuario.Name = "dtUsuario";
            dtUsuario.RowTemplate.Height = 25;
            dtUsuario.Size = new Size(432, 165);
            dtUsuario.TabIndex = 1;
            // 
            // textBoxPesquisa
            // 
            textBoxPesquisa.Location = new Point(308, 71);
            textBoxPesquisa.Name = "textBoxPesquisa";
            textBoxPesquisa.Size = new Size(179, 23);
            textBoxPesquisa.TabIndex = 2;
            // 
            // btnImprimir
            // 
            btnImprimir.Location = new Point(470, 307);
            btnImprimir.Name = "btnImprimir";
            btnImprimir.Size = new Size(94, 23);
            btnImprimir.TabIndex = 3;
            btnImprimir.Text = "Imprimir";
            btnImprimir.UseVisualStyleBackColor = true;
            btnImprimir.Click += btnImprimir_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(245, 74);
            label1.Name = "label1";
            label1.Size = new Size(60, 15);
            label1.TabIndex = 4;
            label1.Text = "Pesquisar:";
            // 
            // FrmListarUsuario
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(btnImprimir);
            Controls.Add(textBoxPesquisa);
            Controls.Add(dtUsuario);
            Controls.Add(btnPesquisar);
            Name = "FrmListarUsuario";
            Text = "FrmListarUsuario";
            Load += FrmListarUsuario_Load;
            ((System.ComponentModel.ISupportInitialize)dtUsuario).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnPesquisar;
        private DataGridView dtUsuario;
        private TextBox textBoxPesquisa;
        private Button btnImprimir;
        private Label label1;
    }
}