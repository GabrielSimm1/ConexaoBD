namespace testando
{
    partial class FormularioProduto
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblFoto = new System.Windows.Forms.Label();
            this.btnInserir = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.textBoxPreco = new System.Windows.Forms.TextBox();
            this.textBoxDescrição = new System.Windows.Forms.TextBox();
            this.textBoxID = new System.Windows.Forms.TextBox();
            this.textBoxQuantidade = new System.Windows.Forms.TextBox();
            this.dataValidade = new System.Windows.Forms.DateTimePicker();
            this.BoxFoto = new System.Windows.Forms.PictureBox();
            this.checkBoxPerecivel = new System.Windows.Forms.CheckBox();
            this.btnFoto = new System.Windows.Forms.Button();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.TabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dtProduto = new System.Windows.Forms.DataGridView();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxPesquisa = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.BoxFoto)).BeginInit();
            this.tabControl.SuspendLayout();
            this.TabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtProduto)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Código:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Descrição:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 92);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Preço:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 124);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "Quantidade:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 210);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 15);
            this.label5.TabIndex = 4;
            this.label5.Text = "Validade:";
            // 
            // lblFoto
            // 
            this.lblFoto.AutoSize = true;
            this.lblFoto.Location = new System.Drawing.Point(387, 264);
            this.lblFoto.Name = "lblFoto";
            this.lblFoto.Size = new System.Drawing.Size(38, 15);
            this.lblFoto.TabIndex = 5;
            this.lblFoto.Text = "label6";
            // 
            // btnInserir
            // 
            this.btnInserir.Location = new System.Drawing.Point(25, 260);
            this.btnInserir.Name = "btnInserir";
            this.btnInserir.Size = new System.Drawing.Size(75, 23);
            this.btnInserir.TabIndex = 5;
            this.btnInserir.Text = "Cadastrar";
            this.btnInserir.UseVisualStyleBackColor = true;
            this.btnInserir.Click += new System.EventHandler(this.btnInserir_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.Location = new System.Drawing.Point(130, 260);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(75, 23);
            this.btnEditar.TabIndex = 6;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.Location = new System.Drawing.Point(552, 68);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(75, 23);
            this.btnExcluir.TabIndex = 7;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // textBoxPreco
            // 
            this.textBoxPreco.Location = new System.Drawing.Point(96, 84);
            this.textBoxPreco.Name = "textBoxPreco";
            this.textBoxPreco.Size = new System.Drawing.Size(100, 23);
            this.textBoxPreco.TabIndex = 1;
            this.textBoxPreco.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxPreco_KeyPress);
            // 
            // textBoxDescrição
            // 
            this.textBoxDescrição.Location = new System.Drawing.Point(96, 54);
            this.textBoxDescrição.Name = "textBoxDescrição";
            this.textBoxDescrição.Size = new System.Drawing.Size(100, 23);
            this.textBoxDescrição.TabIndex = 0;
            // 
            // textBoxID
            // 
            this.textBoxID.Location = new System.Drawing.Point(96, 18);
            this.textBoxID.Name = "textBoxID";
            this.textBoxID.Size = new System.Drawing.Size(100, 23);
            this.textBoxID.TabIndex = 11;
            // 
            // textBoxQuantidade
            // 
            this.textBoxQuantidade.Location = new System.Drawing.Point(96, 116);
            this.textBoxQuantidade.Name = "textBoxQuantidade";
            this.textBoxQuantidade.Size = new System.Drawing.Size(100, 23);
            this.textBoxQuantidade.TabIndex = 2;
            this.textBoxQuantidade.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxQuantidade_KeyPress);
            // 
            // dataValidade
            // 
            this.dataValidade.Location = new System.Drawing.Point(76, 204);
            this.dataValidade.Name = "dataValidade";
            this.dataValidade.Size = new System.Drawing.Size(232, 23);
            this.dataValidade.TabIndex = 4;
            // 
            // BoxFoto
            // 
            this.BoxFoto.Location = new System.Drawing.Point(387, 18);
            this.BoxFoto.Name = "BoxFoto";
            this.BoxFoto.Size = new System.Drawing.Size(325, 213);
            this.BoxFoto.TabIndex = 14;
            this.BoxFoto.TabStop = false;
            // 
            // checkBoxPerecivel
            // 
            this.checkBoxPerecivel.AutoSize = true;
            this.checkBoxPerecivel.Location = new System.Drawing.Point(86, 159);
            this.checkBoxPerecivel.Name = "checkBoxPerecivel";
            this.checkBoxPerecivel.Size = new System.Drawing.Size(119, 19);
            this.checkBoxPerecivel.TabIndex = 3;
            this.checkBoxPerecivel.Text = "Produto perecivél";
            this.checkBoxPerecivel.UseVisualStyleBackColor = true;
            this.checkBoxPerecivel.Click += new System.EventHandler(this.checkBoxPerecivel_Click);
            // 
            // btnFoto
            // 
            this.btnFoto.Location = new System.Drawing.Point(240, 260);
            this.btnFoto.Name = "btnFoto";
            this.btnFoto.Size = new System.Drawing.Size(86, 23);
            this.btnFoto.TabIndex = 8;
            this.btnFoto.Text = "Inserir foto";
            this.btnFoto.UseVisualStyleBackColor = true;
            this.btnFoto.Click += new System.EventHandler(this.btnFoto_Click);
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.TabPage1);
            this.tabControl.Controls.Add(this.tabPage2);
            this.tabControl.Location = new System.Drawing.Point(12, 4);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(776, 444);
            this.tabControl.TabIndex = 15;
            // 
            // TabPage1
            // 
            this.TabPage1.Controls.Add(this.label1);
            this.TabPage1.Controls.Add(this.btnFoto);
            this.TabPage1.Controls.Add(this.label2);
            this.TabPage1.Controls.Add(this.BoxFoto);
            this.TabPage1.Controls.Add(this.checkBoxPerecivel);
            this.TabPage1.Controls.Add(this.lblFoto);
            this.TabPage1.Controls.Add(this.btnEditar);
            this.TabPage1.Controls.Add(this.dataValidade);
            this.TabPage1.Controls.Add(this.btnInserir);
            this.TabPage1.Controls.Add(this.label3);
            this.TabPage1.Controls.Add(this.label4);
            this.TabPage1.Controls.Add(this.textBoxID);
            this.TabPage1.Controls.Add(this.textBoxQuantidade);
            this.TabPage1.Controls.Add(this.label5);
            this.TabPage1.Controls.Add(this.textBoxDescrição);
            this.TabPage1.Controls.Add(this.textBoxPreco);
            this.TabPage1.Location = new System.Drawing.Point(4, 24);
            this.TabPage1.Name = "TabPage1";
            this.TabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.TabPage1.Size = new System.Drawing.Size(768, 416);
            this.TabPage1.TabIndex = 0;
            this.TabPage1.Text = "Cadastro";
            this.TabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.dtProduto);
            this.tabPage2.Controls.Add(this.btnPesquisar);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.textBoxPesquisa);
            this.tabPage2.Controls.Add(this.btnExcluir);
            this.tabPage2.Location = new System.Drawing.Point(4, 24);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(768, 416);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Lista";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // dtProduto
            // 
            this.dtProduto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtProduto.Location = new System.Drawing.Point(22, 97);
            this.dtProduto.Name = "dtProduto";
            this.dtProduto.RowTemplate.Height = 25;
            this.dtProduto.Size = new System.Drawing.Size(605, 292);
            this.dtProduto.TabIndex = 11;
            this.dtProduto.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtProduto_CellClick);
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.Location = new System.Drawing.Point(552, 39);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(75, 23);
            this.btnPesquisar.TabIndex = 10;
            this.btnPesquisar.Text = "Pesquisar";
            this.btnPesquisar.UseVisualStyleBackColor = true;
            this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(22, 56);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 15);
            this.label6.TabIndex = 9;
            this.label6.Text = "Produto:";
            // 
            // textBoxPesquisa
            // 
            this.textBoxPesquisa.Location = new System.Drawing.Point(81, 54);
            this.textBoxPesquisa.Name = "textBoxPesquisa";
            this.textBoxPesquisa.Size = new System.Drawing.Size(450, 23);
            this.textBoxPesquisa.TabIndex = 8;
            // 
            // FormularioProduto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl);
            this.Name = "FormularioProduto";
            this.Text = "FormularioProduto";
            this.Load += new System.EventHandler(this.FormularioProduto_Load);
            ((System.ComponentModel.ISupportInitialize)(this.BoxFoto)).EndInit();
            this.tabControl.ResumeLayout(false);
            this.TabPage1.ResumeLayout(false);
            this.TabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtProduto)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label lblFoto;
        private Button btnInserir;
        private Button btnEditar;
        private Button btnExcluir;
        private TextBox textBoxPreco;
        private TextBox textBoxDescrição;
        private TextBox textBoxID;
        private TextBox textBoxQuantidade;
        private DateTimePicker dataValidade;
        private PictureBox BoxFoto;
        private CheckBox checkBoxPerecivel;
        private Button btnFoto;
        private TabControl tabControl;
        private TabPage TabPage1;
        private TabPage tabPage2;
        private DataGridView dtProduto;
        private Button btnPesquisar;
        private Label label6;
        private TextBox textBoxPesquisa;
    }
}