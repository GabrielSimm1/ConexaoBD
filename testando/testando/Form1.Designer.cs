namespace testando
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
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.textBoxNome = new System.Windows.Forms.TextBox();
            this.textBoxSenha = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxID = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnConexao = new System.Windows.Forms.Button();
            this.dtUsuario = new System.Windows.Forms.DataGridView();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnListar = new System.Windows.Forms.Button();
            this.cboPerfil = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtUsuario)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(66, 165);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(66, 262);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Cadastrar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBoxNome
            // 
            this.textBoxNome.Location = new System.Drawing.Point(115, 162);
            this.textBoxNome.Name = "textBoxNome";
            this.textBoxNome.Size = new System.Drawing.Size(121, 23);
            this.textBoxNome.TabIndex = 2;
            // 
            // textBoxSenha
            // 
            this.textBoxSenha.Location = new System.Drawing.Point(115, 191);
            this.textBoxSenha.Name = "textBoxSenha";
            this.textBoxSenha.Size = new System.Drawing.Size(121, 23);
            this.textBoxSenha.TabIndex = 3;
            this.textBoxSenha.TextChanged += new System.EventHandler(this.textBoxSenha_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(67, 194);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "Senha:";
            // 
            // textBoxID
            // 
            this.textBoxID.Location = new System.Drawing.Point(115, 133);
            this.textBoxID.Name = "textBoxID";
            this.textBoxID.Size = new System.Drawing.Size(121, 23);
            this.textBoxID.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(88, 136);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(21, 15);
            this.label2.TabIndex = 6;
            this.label2.Text = "ID:";
            // 
            // btnConexao
            // 
            this.btnConexao.Location = new System.Drawing.Point(629, 318);
            this.btnConexao.Name = "btnConexao";
            this.btnConexao.Size = new System.Drawing.Size(89, 23);
            this.btnConexao.TabIndex = 7;
            this.btnConexao.Text = "Conexão";
            this.btnConexao.UseVisualStyleBackColor = true;
            this.btnConexao.Click += new System.EventHandler(this.button2_Click);
            // 
            // dtUsuario
            // 
            this.dtUsuario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtUsuario.Location = new System.Drawing.Point(396, 67);
            this.dtUsuario.Name = "dtUsuario";
            this.dtUsuario.RowTemplate.Height = 25;
            this.dtUsuario.Size = new System.Drawing.Size(547, 231);
            this.dtUsuario.TabIndex = 8;
            this.dtUsuario.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtUsuario_CellClick);
            // 
            // btnExcluir
            // 
            this.btnExcluir.Location = new System.Drawing.Point(436, 318);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(85, 23);
            this.btnExcluir.TabIndex = 9;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.Location = new System.Drawing.Point(810, 318);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(89, 23);
            this.btnEditar.TabIndex = 10;
            this.btnEditar.Text = "Atualizar";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnListar
            // 
            this.btnListar.Location = new System.Drawing.Point(192, 262);
            this.btnListar.Name = "btnListar";
            this.btnListar.Size = new System.Drawing.Size(100, 23);
            this.btnListar.TabIndex = 11;
            this.btnListar.Text = "Listar Usuário";
            this.btnListar.UseVisualStyleBackColor = true;
            this.btnListar.Click += new System.EventHandler(this.btnListar_Click);
            // 
            // cboPerfil
            // 
            this.cboPerfil.FormattingEnabled = true;
            this.cboPerfil.Location = new System.Drawing.Point(115, 220);
            this.cboPerfil.Name = "cboPerfil";
            this.cboPerfil.Size = new System.Drawing.Size(121, 23);
            this.cboPerfil.TabIndex = 12;
            this.cboPerfil.SelectedIndexChanged += new System.EventHandler(this.cboPerfil_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(72, 223);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 15);
            this.label4.TabIndex = 13;
            this.label4.Text = "Perfil:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.ClientSize = new System.Drawing.Size(966, 484);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cboPerfil);
            this.Controls.Add(this.btnListar);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.dtUsuario);
            this.Controls.Add(this.btnConexao);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxID);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxSenha);
            this.Controls.Add(this.textBoxNome);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtUsuario)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Button button1;
        private TextBox textBoxNome;
        private Label label2;
        private TextBox textBoxID;
        private Button btnConexao;
        private TextBox textBoxSenha;
        private Label label3;
        private DataGridView dtUsuario;
        private Button btnExcluir;
        private Button btnEditar;
        private Button btnListar;
        private ComboBox cboPerfil;
        private Label label4;
    }
}