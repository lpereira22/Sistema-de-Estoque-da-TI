namespace Controle_de_Estoque_TI
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
            movimentacao = new TabControl();
            tabPage1 = new TabPage();
            label10 = new Label();
            label9 = new Label();
            dataGridView2 = new DataGridView();
            itemMovimenta = new DataGridViewTextBoxColumn();
            tipoMovimenta = new DataGridViewTextBoxColumn();
            QtdMovimenta = new DataGridViewTextBoxColumn();
            motivoMovimenta = new DataGridViewTextBoxColumn();
            dataMovimenta = new DataGridViewTextBoxColumn();
            dataGridView1 = new DataGridView();
            Item = new DataGridViewTextBoxColumn();
            QtdMinima = new DataGridViewTextBoxColumn();
            Categoria = new DataGridViewTextBoxColumn();
            Qtd = new DataGridViewTextBoxColumn();
            panel3 = new Panel();
            label8 = new Label();
            label4 = new Label();
            pictureBox4 = new PictureBox();
            panel2 = new Panel();
            label7 = new Label();
            labelEstoqueBaixo = new Label();
            pictureBox3 = new PictureBox();
            panel1 = new Panel();
            label6 = new Label();
            LabelTiposCadastrados = new Label();
            pictureBox1 = new PictureBox();
            TotalItens = new Panel();
            LabelTotalItens = new Label();
            label5 = new Label();
            pictureBox2 = new PictureBox();
            itensEstoque = new TabPage();
            itensCadastrados = new GroupBox();
            dataGridView3 = new DataGridView();
            CadastrarItem = new GroupBox();
            comboBox1 = new ComboBox();
            DescItem = new Label();
            textBox7 = new TextBox();
            LocalItem = new Label();
            textBox6 = new TextBox();
            label15 = new Label();
            textBox5 = new TextBox();
            qtsItens = new Label();
            textBox4 = new TextBox();
            label13 = new Label();
            label12 = new Label();
            textBox2 = new TextBox();
            nomeItem = new Label();
            textBox1 = new TextBox();
            CancelarItem = new Button();
            SalvarItem = new Button();
            Adicionar = new Button();
            Editar = new Button();
            Excluir = new Button();
            tabPage2 = new TabPage();
            ultimaMovimentacao = new GroupBox();
            dataGridView4 = new DataGridView();
            itemMovimento = new DataGridViewTextBoxColumn();
            tipoMovimento = new DataGridViewTextBoxColumn();
            qtdMovimento = new DataGridViewTextBoxColumn();
            motivoMovimento = new DataGridViewTextBoxColumn();
            responsavelMovimento = new DataGridViewTextBoxColumn();
            dataMovimento = new DataGridViewTextBoxColumn();
            btnNovaMovimentacao = new Button();
            registraMovimento = new GroupBox();
            cancelarMovimentacao = new Button();
            registrarMovimentacao = new Button();
            textBoxResponsavelMovimentacao = new TextBox();
            ResponsavelMovimentacao = new Label();
            textBoxMotivoMovimentacao = new TextBox();
            MotivoMovimentacao = new Label();
            textBoxQuantidadeMovimentacao = new TextBox();
            QuantidadeMovimentacao = new Label();
            comboBoxTipoMovimentacao = new ComboBox();
            TipoMovimentacao = new Label();
            comboBox2 = new ComboBox();
            ItemMovimentacao = new Label();
            historicoMovimento = new GroupBox();
            IDItensCadastrados = new DataGridViewTextBoxColumn();
            nomeCadastro = new DataGridViewTextBoxColumn();
            CategoriaCadastro = new DataGridViewTextBoxColumn();
            quantidadeCadastro = new DataGridViewTextBoxColumn();
            minimaCadastro = new DataGridViewTextBoxColumn();
            LocalCadastro = new DataGridViewTextBoxColumn();
            StatusCadastro = new DataGridViewComboBoxColumn();
            movimentacao.SuspendLayout();
            tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            TotalItens.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            itensEstoque.SuspendLayout();
            itensCadastrados.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView3).BeginInit();
            CadastrarItem.SuspendLayout();
            tabPage2.SuspendLayout();
            ultimaMovimentacao.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView4).BeginInit();
            registraMovimento.SuspendLayout();
            SuspendLayout();
            // 
            // movimentacao
            // 
            movimentacao.Controls.Add(tabPage1);
            movimentacao.Controls.Add(itensEstoque);
            movimentacao.Controls.Add(tabPage2);
            movimentacao.Location = new Point(0, 1);
            movimentacao.Name = "movimentacao";
            movimentacao.SelectedIndex = 0;
            movimentacao.Size = new Size(844, 523);
            movimentacao.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(label10);
            tabPage1.Controls.Add(label9);
            tabPage1.Controls.Add(dataGridView2);
            tabPage1.Controls.Add(dataGridView1);
            tabPage1.Controls.Add(panel3);
            tabPage1.Controls.Add(panel2);
            tabPage1.Controls.Add(panel1);
            tabPage1.Controls.Add(TotalItens);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(836, 495);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Dashboard";
            tabPage1.UseVisualStyleBackColor = true;
            tabPage1.Click += tabPage1_Click;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(10, 283);
            label10.Name = "label10";
            label10.Size = new Size(130, 15);
            label10.TabIndex = 5;
            label10.Text = "Ultima Movimentações";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(10, 81);
            label9.Name = "label9";
            label9.Size = new Size(125, 15);
            label9.TabIndex = 4;
            label9.Text = "Itens de Estoque Baixo";
            // 
            // dataGridView2
            // 
            dataGridView2.AllowUserToAddRows = false;
            dataGridView2.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Columns.AddRange(new DataGridViewColumn[] { itemMovimenta, tipoMovimenta, QtdMovimenta, motivoMovimenta, dataMovimenta });
            dataGridView2.Location = new Point(8, 301);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.ReadOnly = true;
            dataGridView2.Size = new Size(820, 99);
            dataGridView2.TabIndex = 3;
            // 
            // itemMovimenta
            // 
            itemMovimenta.HeaderText = "Item";
            itemMovimenta.Name = "itemMovimenta";
            itemMovimenta.ReadOnly = true;
            // 
            // tipoMovimenta
            // 
            tipoMovimenta.HeaderText = "Tipo";
            tipoMovimenta.Name = "tipoMovimenta";
            tipoMovimenta.ReadOnly = true;
            // 
            // QtdMovimenta
            // 
            QtdMovimenta.HeaderText = "Qtd";
            QtdMovimenta.Name = "QtdMovimenta";
            QtdMovimenta.ReadOnly = true;
            // 
            // motivoMovimenta
            // 
            motivoMovimenta.HeaderText = "Motivo";
            motivoMovimenta.Name = "motivoMovimenta";
            motivoMovimenta.ReadOnly = true;
            // 
            // dataMovimenta
            // 
            dataMovimenta.HeaderText = "Data";
            dataMovimenta.Name = "dataMovimenta";
            dataMovimenta.ReadOnly = true;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Item, QtdMinima, Categoria, Qtd });
            dataGridView1.Location = new Point(8, 99);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.Size = new Size(820, 176);
            dataGridView1.TabIndex = 2;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // Item
            // 
            Item.HeaderText = "Item";
            Item.Name = "Item";
            Item.ReadOnly = true;
            // 
            // QtdMinima
            // 
            QtdMinima.HeaderText = "Qtd Mínima";
            QtdMinima.Name = "QtdMinima";
            QtdMinima.ReadOnly = true;
            // 
            // Categoria
            // 
            Categoria.HeaderText = "Categoria";
            Categoria.Name = "Categoria";
            Categoria.ReadOnly = true;
            // 
            // Qtd
            // 
            Qtd.HeaderText = "Qtd Atual";
            Qtd.Name = "Qtd";
            Qtd.ReadOnly = true;
            // 
            // panel3
            // 
            panel3.BorderStyle = BorderStyle.Fixed3D;
            panel3.Controls.Add(label8);
            panel3.Controls.Add(label4);
            panel3.Controls.Add(pictureBox4);
            panel3.Location = new Point(474, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(149, 71);
            panel3.TabIndex = 1;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 7F);
            label8.Location = new Point(54, 14);
            label8.Name = "label8";
            label8.Size = new Size(75, 12);
            label8.TabIndex = 5;
            label8.Text = "Movimentações";
            label8.Click += label8_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(88, 38);
            label4.Name = "label4";
            label4.Size = new Size(13, 15);
            label4.TabIndex = 3;
            label4.Text = "0";
            // 
            // pictureBox4
            // 
            pictureBox4.BorderStyle = BorderStyle.Fixed3D;
            pictureBox4.Image = Properties.Resources.icone_download;
            pictureBox4.Location = new Point(3, 3);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(45, 38);
            pictureBox4.TabIndex = 2;
            pictureBox4.TabStop = false;
            // 
            // panel2
            // 
            panel2.BorderStyle = BorderStyle.Fixed3D;
            panel2.Controls.Add(label7);
            panel2.Controls.Add(labelEstoqueBaixo);
            panel2.Controls.Add(pictureBox3);
            panel2.Location = new Point(319, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(149, 71);
            panel2.TabIndex = 1;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 7F);
            label7.Location = new Point(64, 14);
            label7.Name = "label7";
            label7.Size = new Size(67, 12);
            label7.TabIndex = 4;
            label7.Text = "Estoque Baixo";
            // 
            // labelEstoqueBaixo
            // 
            labelEstoqueBaixo.AutoSize = true;
            labelEstoqueBaixo.Location = new Point(86, 38);
            labelEstoqueBaixo.Name = "labelEstoqueBaixo";
            labelEstoqueBaixo.Size = new Size(13, 15);
            labelEstoqueBaixo.TabIndex = 2;
            labelEstoqueBaixo.Text = "0";
            labelEstoqueBaixo.Click += label3_Click;
            // 
            // pictureBox3
            // 
            pictureBox3.BorderStyle = BorderStyle.Fixed3D;
            pictureBox3.Image = Properties.Resources.icone_alerta;
            pictureBox3.Location = new Point(3, 3);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(45, 38);
            pictureBox3.TabIndex = 2;
            pictureBox3.TabStop = false;
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.Fixed3D;
            panel1.Controls.Add(label6);
            panel1.Controls.Add(LabelTiposCadastrados);
            panel1.Controls.Add(pictureBox1);
            panel1.Location = new Point(164, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(149, 71);
            panel1.TabIndex = 1;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 7F);
            label6.Location = new Point(54, 14);
            label6.Name = "label6";
            label6.Size = new Size(84, 12);
            label6.TabIndex = 3;
            label6.Text = "Tipos Cadastrados";
            // 
            // LabelTiposCadastrados
            // 
            LabelTiposCadastrados.AutoSize = true;
            LabelTiposCadastrados.Location = new Point(87, 38);
            LabelTiposCadastrados.Name = "LabelTiposCadastrados";
            LabelTiposCadastrados.Size = new Size(13, 15);
            LabelTiposCadastrados.TabIndex = 1;
            LabelTiposCadastrados.Text = "0";
            LabelTiposCadastrados.Click += label1_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BorderStyle = BorderStyle.Fixed3D;
            pictureBox1.Image = Properties.Resources.icone_monitor;
            pictureBox1.Location = new Point(3, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(45, 38);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // TotalItens
            // 
            TotalItens.BorderStyle = BorderStyle.Fixed3D;
            TotalItens.Controls.Add(LabelTotalItens);
            TotalItens.Controls.Add(label5);
            TotalItens.Controls.Add(pictureBox2);
            TotalItens.Location = new Point(9, 0);
            TotalItens.Name = "TotalItens";
            TotalItens.Size = new Size(149, 71);
            TotalItens.TabIndex = 0;
            TotalItens.Paint += panel1_Paint;
            // 
            // LabelTotalItens
            // 
            LabelTotalItens.AutoSize = true;
            LabelTotalItens.Location = new Point(92, 38);
            LabelTotalItens.Name = "LabelTotalItens";
            LabelTotalItens.Size = new Size(13, 15);
            LabelTotalItens.TabIndex = 6;
            LabelTotalItens.Text = "0";
            LabelTotalItens.Click += LabelTotalItens_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 7F);
            label5.Location = new Point(65, 14);
            label5.Name = "label5";
            label5.Size = new Size(62, 12);
            label5.TabIndex = 2;
            label5.Text = "Total de itens";
            label5.Click += label5_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.BorderStyle = BorderStyle.Fixed3D;
            pictureBox2.Image = Properties.Resources.icone_caixa;
            pictureBox2.Location = new Point(3, 3);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(45, 38);
            pictureBox2.TabIndex = 1;
            pictureBox2.TabStop = false;
            // 
            // itensEstoque
            // 
            itensEstoque.Controls.Add(itensCadastrados);
            itensEstoque.Controls.Add(CadastrarItem);
            itensEstoque.Controls.Add(Adicionar);
            itensEstoque.Controls.Add(Editar);
            itensEstoque.Controls.Add(Excluir);
            itensEstoque.Location = new Point(4, 24);
            itensEstoque.Name = "itensEstoque";
            itensEstoque.Padding = new Padding(3);
            itensEstoque.Size = new Size(836, 495);
            itensEstoque.TabIndex = 1;
            itensEstoque.Text = "Itens de Estoque";
            itensEstoque.UseVisualStyleBackColor = true;
            itensEstoque.Click += tabPage2_Click;
            // 
            // itensCadastrados
            // 
            itensCadastrados.Controls.Add(dataGridView3);
            itensCadastrados.Location = new Point(13, 277);
            itensCadastrados.Name = "itensCadastrados";
            itensCadastrados.Size = new Size(817, 212);
            itensCadastrados.TabIndex = 4;
            itensCadastrados.TabStop = false;
            itensCadastrados.Text = "Itens Cadastrados";
            itensCadastrados.Enter += itensCadastrados_Enter;
            // 
            // dataGridView3
            // 
            dataGridView3.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView3.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView3.Columns.AddRange(new DataGridViewColumn[] { IDItensCadastrados, nomeCadastro, CategoriaCadastro, quantidadeCadastro, minimaCadastro, LocalCadastro, StatusCadastro });
            dataGridView3.Location = new Point(6, 22);
            dataGridView3.Name = "dataGridView3";
            dataGridView3.Size = new Size(805, 184);
            dataGridView3.TabIndex = 0;
            dataGridView3.CellContentClick += dataGridView3_CellContentClick;
            // 
            // CadastrarItem
            // 
            CadastrarItem.BackColor = Color.White;
            CadastrarItem.Controls.Add(comboBox1);
            CadastrarItem.Controls.Add(DescItem);
            CadastrarItem.Controls.Add(textBox7);
            CadastrarItem.Controls.Add(LocalItem);
            CadastrarItem.Controls.Add(textBox6);
            CadastrarItem.Controls.Add(label15);
            CadastrarItem.Controls.Add(textBox5);
            CadastrarItem.Controls.Add(qtsItens);
            CadastrarItem.Controls.Add(textBox4);
            CadastrarItem.Controls.Add(label13);
            CadastrarItem.Controls.Add(label12);
            CadastrarItem.Controls.Add(textBox2);
            CadastrarItem.Controls.Add(nomeItem);
            CadastrarItem.Controls.Add(textBox1);
            CadastrarItem.Controls.Add(CancelarItem);
            CadastrarItem.Controls.Add(SalvarItem);
            CadastrarItem.ForeColor = Color.CornflowerBlue;
            CadastrarItem.Location = new Point(13, 35);
            CadastrarItem.Name = "CadastrarItem";
            CadastrarItem.Size = new Size(820, 236);
            CadastrarItem.TabIndex = 3;
            CadastrarItem.TabStop = false;
            CadastrarItem.Text = "Cadastrar Item";
            CadastrarItem.Visible = false;
            CadastrarItem.Enter += groupBox1_Enter;
            // 
            // comboBox1
            // 
            comboBox1.ForeColor = SystemColors.ActiveCaptionText;
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Ativo", "Inativo" });
            comboBox1.Location = new Point(530, 44);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(213, 23);
            comboBox1.TabIndex = 16;
            comboBox1.Text = "None";
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // DescItem
            // 
            DescItem.AutoSize = true;
            DescItem.ForeColor = SystemColors.ActiveCaptionText;
            DescItem.Location = new Point(24, 142);
            DescItem.Name = "DescItem";
            DescItem.Size = new Size(58, 15);
            DescItem.TabIndex = 15;
            DescItem.Text = "Descrição";
            // 
            // textBox7
            // 
            textBox7.ForeColor = SystemColors.ActiveCaptionText;
            textBox7.Location = new Point(24, 160);
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(719, 23);
            textBox7.TabIndex = 14;
            textBox7.TextChanged += textBox7_TextChanged;
            // 
            // LocalItem
            // 
            LocalItem.AutoSize = true;
            LocalItem.ForeColor = SystemColors.ActiveCaptionText;
            LocalItem.Location = new Point(530, 80);
            LocalItem.Name = "LocalItem";
            LocalItem.Size = new Size(35, 15);
            LocalItem.TabIndex = 13;
            LocalItem.Text = "Local";
            // 
            // textBox6
            // 
            textBox6.ForeColor = SystemColors.ActiveCaptionText;
            textBox6.Location = new Point(530, 98);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(213, 23);
            textBox6.TabIndex = 12;
            textBox6.TextChanged += textBox6_TextChanged;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.ForeColor = SystemColors.ActiveCaptionText;
            label15.Location = new Point(276, 80);
            label15.Name = "label15";
            label15.Size = new Size(96, 15);
            label15.TabIndex = 11;
            label15.Text = "Quantidade Min.";
            // 
            // textBox5
            // 
            textBox5.ForeColor = SystemColors.ActiveCaptionText;
            textBox5.Location = new Point(276, 98);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(213, 23);
            textBox5.TabIndex = 10;
            textBox5.TextChanged += textBox5_TextChanged;
            // 
            // qtsItens
            // 
            qtsItens.AutoSize = true;
            qtsItens.ForeColor = SystemColors.ActiveCaptionText;
            qtsItens.Location = new Point(24, 80);
            qtsItens.Name = "qtsItens";
            qtsItens.Size = new Size(69, 15);
            qtsItens.TabIndex = 9;
            qtsItens.Text = "Quantidade";
            // 
            // textBox4
            // 
            textBox4.ForeColor = SystemColors.ActiveCaptionText;
            textBox4.Location = new Point(24, 98);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(213, 23);
            textBox4.TabIndex = 8;
            textBox4.TextChanged += textBox4_TextChanged;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.ForeColor = SystemColors.ActiveCaptionText;
            label13.Location = new Point(530, 26);
            label13.Name = "label13";
            label13.Size = new Size(44, 15);
            label13.TabIndex = 7;
            label13.Text = "Status*";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.ForeColor = SystemColors.ActiveCaptionText;
            label12.Location = new Point(276, 26);
            label12.Name = "label12";
            label12.Size = new Size(63, 15);
            label12.TabIndex = 5;
            label12.Text = "Categoria*";
            // 
            // textBox2
            // 
            textBox2.ForeColor = SystemColors.ActiveCaptionText;
            textBox2.Location = new Point(276, 44);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(213, 23);
            textBox2.TabIndex = 4;
            // 
            // nomeItem
            // 
            nomeItem.AutoSize = true;
            nomeItem.ForeColor = SystemColors.ActiveCaptionText;
            nomeItem.Location = new Point(24, 26);
            nomeItem.Name = "nomeItem";
            nomeItem.Size = new Size(45, 15);
            nomeItem.TabIndex = 3;
            nomeItem.Text = "Nome*";
            nomeItem.Click += label11_Click;
            // 
            // textBox1
            // 
            textBox1.ForeColor = SystemColors.ActiveCaptionText;
            textBox1.Location = new Point(24, 44);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(213, 23);
            textBox1.TabIndex = 2;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // CancelarItem
            // 
            CancelarItem.Cursor = Cursors.Hand;
            CancelarItem.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            CancelarItem.ForeColor = Color.Black;
            CancelarItem.Location = new Point(87, 207);
            CancelarItem.Name = "CancelarItem";
            CancelarItem.Size = new Size(75, 23);
            CancelarItem.TabIndex = 1;
            CancelarItem.Text = "Cancelar";
            CancelarItem.UseVisualStyleBackColor = true;
            CancelarItem.Click += CancelarItem_Click;
            // 
            // SalvarItem
            // 
            SalvarItem.Cursor = Cursors.Hand;
            SalvarItem.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            SalvarItem.ForeColor = Color.Black;
            SalvarItem.Location = new Point(6, 207);
            SalvarItem.Name = "SalvarItem";
            SalvarItem.Size = new Size(75, 23);
            SalvarItem.TabIndex = 0;
            SalvarItem.Text = "Salvar";
            SalvarItem.UseVisualStyleBackColor = true;
            SalvarItem.Click += SalvarItem_Click;
            // 
            // Adicionar
            // 
            Adicionar.Cursor = Cursors.Hand;
            Adicionar.Location = new Point(6, 6);
            Adicionar.Name = "Adicionar";
            Adicionar.Size = new Size(75, 23);
            Adicionar.TabIndex = 2;
            Adicionar.Text = "Adicionar";
            Adicionar.UseVisualStyleBackColor = true;
            Adicionar.Click += Adicionar_Click;
            // 
            // Editar
            // 
            Editar.Cursor = Cursors.Hand;
            Editar.Location = new Point(89, 6);
            Editar.Name = "Editar";
            Editar.Size = new Size(75, 23);
            Editar.TabIndex = 1;
            Editar.Text = "Editar";
            Editar.UseVisualStyleBackColor = true;
            Editar.Click += Editar_Click;
            // 
            // Excluir
            // 
            Excluir.Cursor = Cursors.Hand;
            Excluir.Location = new Point(170, 6);
            Excluir.Name = "Excluir";
            Excluir.Size = new Size(75, 23);
            Excluir.TabIndex = 0;
            Excluir.Text = "Excluir";
            Excluir.UseVisualStyleBackColor = true;
            Excluir.Click += Excluir_Click;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(ultimaMovimentacao);
            tabPage2.Controls.Add(btnNovaMovimentacao);
            tabPage2.Controls.Add(registraMovimento);
            tabPage2.Controls.Add(historicoMovimento);
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(836, 495);
            tabPage2.TabIndex = 2;
            tabPage2.Text = "Movimentação";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // ultimaMovimentacao
            // 
            ultimaMovimentacao.Controls.Add(dataGridView4);
            ultimaMovimentacao.Location = new Point(13, 232);
            ultimaMovimentacao.Name = "ultimaMovimentacao";
            ultimaMovimentacao.Size = new Size(814, 257);
            ultimaMovimentacao.TabIndex = 3;
            ultimaMovimentacao.TabStop = false;
            ultimaMovimentacao.Text = "Ultimas Movimentações";
            ultimaMovimentacao.Enter += ultimaMovimentacao_Enter;
            // 
            // dataGridView4
            // 
            dataGridView4.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView4.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView4.Columns.AddRange(new DataGridViewColumn[] { itemMovimento, tipoMovimento, qtdMovimento, motivoMovimento, responsavelMovimento, dataMovimento });
            dataGridView4.Location = new Point(13, 19);
            dataGridView4.Name = "dataGridView4";
            dataGridView4.Size = new Size(793, 232);
            dataGridView4.TabIndex = 1;
            // 
            // itemMovimento
            // 
            itemMovimento.HeaderText = "Item";
            itemMovimento.Name = "itemMovimento";
            // 
            // tipoMovimento
            // 
            tipoMovimento.HeaderText = "Tipo";
            tipoMovimento.Name = "tipoMovimento";
            // 
            // qtdMovimento
            // 
            qtdMovimento.HeaderText = "Quantidade";
            qtdMovimento.Name = "qtdMovimento";
            // 
            // motivoMovimento
            // 
            motivoMovimento.HeaderText = "Motivo";
            motivoMovimento.Name = "motivoMovimento";
            // 
            // responsavelMovimento
            // 
            responsavelMovimento.HeaderText = "Responsável";
            responsavelMovimento.Name = "responsavelMovimento";
            // 
            // dataMovimento
            // 
            dataMovimento.HeaderText = "Data";
            dataMovimento.Name = "dataMovimento";
            // 
            // btnNovaMovimentacao
            // 
            btnNovaMovimentacao.Cursor = Cursors.Hand;
            btnNovaMovimentacao.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnNovaMovimentacao.Location = new Point(8, 6);
            btnNovaMovimentacao.Name = "btnNovaMovimentacao";
            btnNovaMovimentacao.Size = new Size(154, 34);
            btnNovaMovimentacao.TabIndex = 0;
            btnNovaMovimentacao.Text = "+ Nova Movimentação";
            btnNovaMovimentacao.UseVisualStyleBackColor = true;
            btnNovaMovimentacao.Click += btnNovaMovimentacao_Click;
            // 
            // registraMovimento
            // 
            registraMovimento.Controls.Add(cancelarMovimentacao);
            registraMovimento.Controls.Add(registrarMovimentacao);
            registraMovimento.Controls.Add(textBoxResponsavelMovimentacao);
            registraMovimento.Controls.Add(ResponsavelMovimentacao);
            registraMovimento.Controls.Add(textBoxMotivoMovimentacao);
            registraMovimento.Controls.Add(MotivoMovimentacao);
            registraMovimento.Controls.Add(textBoxQuantidadeMovimentacao);
            registraMovimento.Controls.Add(QuantidadeMovimentacao);
            registraMovimento.Controls.Add(comboBoxTipoMovimentacao);
            registraMovimento.Controls.Add(TipoMovimentacao);
            registraMovimento.Controls.Add(comboBox2);
            registraMovimento.Controls.Add(ItemMovimentacao);
            registraMovimento.Location = new Point(13, 46);
            registraMovimento.Name = "registraMovimento";
            registraMovimento.Size = new Size(807, 180);
            registraMovimento.TabIndex = 1;
            registraMovimento.TabStop = false;
            registraMovimento.Text = "Registrar Movimentação";
            registraMovimento.Visible = false;
            registraMovimento.Enter += registraMovimento_Enter;
            // 
            // cancelarMovimentacao
            // 
            cancelarMovimentacao.Cursor = Cursors.Hand;
            cancelarMovimentacao.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            cancelarMovimentacao.Location = new Point(126, 148);
            cancelarMovimentacao.Name = "cancelarMovimentacao";
            cancelarMovimentacao.Size = new Size(75, 23);
            cancelarMovimentacao.TabIndex = 11;
            cancelarMovimentacao.Text = "X Cancelar";
            cancelarMovimentacao.UseVisualStyleBackColor = true;
            cancelarMovimentacao.Click += cancelarMovimentacao_Click;
            // 
            // registrarMovimentacao
            // 
            registrarMovimentacao.Cursor = Cursors.Hand;
            registrarMovimentacao.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            registrarMovimentacao.Location = new Point(28, 148);
            registrarMovimentacao.Name = "registrarMovimentacao";
            registrarMovimentacao.Size = new Size(75, 23);
            registrarMovimentacao.TabIndex = 10;
            registrarMovimentacao.Text = "↑ Registrar";
            registrarMovimentacao.UseVisualStyleBackColor = true;
            // 
            // textBoxResponsavelMovimentacao
            // 
            textBoxResponsavelMovimentacao.Location = new Point(285, 102);
            textBoxResponsavelMovimentacao.Name = "textBoxResponsavelMovimentacao";
            textBoxResponsavelMovimentacao.Size = new Size(231, 23);
            textBoxResponsavelMovimentacao.TabIndex = 9;
            // 
            // ResponsavelMovimentacao
            // 
            ResponsavelMovimentacao.AutoSize = true;
            ResponsavelMovimentacao.Location = new Point(285, 84);
            ResponsavelMovimentacao.Name = "ResponsavelMovimentacao";
            ResponsavelMovimentacao.Size = new Size(77, 15);
            ResponsavelMovimentacao.TabIndex = 8;
            ResponsavelMovimentacao.Text = "Responsável*";
            // 
            // textBoxMotivoMovimentacao
            // 
            textBoxMotivoMovimentacao.Location = new Point(28, 102);
            textBoxMotivoMovimentacao.Name = "textBoxMotivoMovimentacao";
            textBoxMotivoMovimentacao.Size = new Size(231, 23);
            textBoxMotivoMovimentacao.TabIndex = 7;
            // 
            // MotivoMovimentacao
            // 
            MotivoMovimentacao.AutoSize = true;
            MotivoMovimentacao.Location = new Point(28, 84);
            MotivoMovimentacao.Name = "MotivoMovimentacao";
            MotivoMovimentacao.Size = new Size(45, 15);
            MotivoMovimentacao.TabIndex = 6;
            MotivoMovimentacao.Text = "Motivo";
            // 
            // textBoxQuantidadeMovimentacao
            // 
            textBoxQuantidadeMovimentacao.Location = new Point(549, 49);
            textBoxQuantidadeMovimentacao.Name = "textBoxQuantidadeMovimentacao";
            textBoxQuantidadeMovimentacao.Size = new Size(231, 23);
            textBoxQuantidadeMovimentacao.TabIndex = 5;
            // 
            // QuantidadeMovimentacao
            // 
            QuantidadeMovimentacao.AutoSize = true;
            QuantidadeMovimentacao.Location = new Point(549, 31);
            QuantidadeMovimentacao.Name = "QuantidadeMovimentacao";
            QuantidadeMovimentacao.Size = new Size(74, 15);
            QuantidadeMovimentacao.TabIndex = 4;
            QuantidadeMovimentacao.Text = "Quantidade*";
            // 
            // comboBoxTipoMovimentacao
            // 
            comboBoxTipoMovimentacao.FormattingEnabled = true;
            comboBoxTipoMovimentacao.Items.AddRange(new object[] { "Entrada ↑", "Saída ↓" });
            comboBoxTipoMovimentacao.Location = new Point(285, 49);
            comboBoxTipoMovimentacao.Name = "comboBoxTipoMovimentacao";
            comboBoxTipoMovimentacao.Size = new Size(231, 23);
            comboBoxTipoMovimentacao.TabIndex = 3;
            comboBoxTipoMovimentacao.Text = "-";
            // 
            // TipoMovimentacao
            // 
            TipoMovimentacao.AutoSize = true;
            TipoMovimentacao.Location = new Point(282, 31);
            TipoMovimentacao.Name = "TipoMovimentacao";
            TipoMovimentacao.Size = new Size(35, 15);
            TipoMovimentacao.TabIndex = 2;
            TipoMovimentacao.Text = "Tipo*";
            TipoMovimentacao.Click += label11_Click_1;
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(28, 49);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(231, 23);
            comboBox2.TabIndex = 1;
            // 
            // ItemMovimentacao
            // 
            ItemMovimentacao.AutoSize = true;
            ItemMovimentacao.Location = new Point(25, 31);
            ItemMovimentacao.Name = "ItemMovimentacao";
            ItemMovimentacao.Size = new Size(36, 15);
            ItemMovimentacao.TabIndex = 0;
            ItemMovimentacao.Text = "Item*";
            // 
            // historicoMovimento
            // 
            historicoMovimento.Location = new Point(13, 46);
            historicoMovimento.Name = "historicoMovimento";
            historicoMovimento.Size = new Size(807, 180);
            historicoMovimento.TabIndex = 2;
            historicoMovimento.TabStop = false;
            historicoMovimento.Text = "Histórico de Movimentação";
            historicoMovimento.Visible = false;
            historicoMovimento.Enter += historicoMovimento_Enter;
            // 
            // IDItensCadastrados
            // 
            IDItensCadastrados.HeaderText = "ID";
            IDItensCadastrados.Name = "IDItensCadastrados";
            // 
            // nomeCadastro
            // 
            nomeCadastro.HeaderText = "Nome";
            nomeCadastro.Name = "nomeCadastro";
            // 
            // CategoriaCadastro
            // 
            CategoriaCadastro.HeaderText = "Categoria";
            CategoriaCadastro.Name = "CategoriaCadastro";
            // 
            // quantidadeCadastro
            // 
            quantidadeCadastro.HeaderText = "Quantidade";
            quantidadeCadastro.Name = "quantidadeCadastro";
            // 
            // minimaCadastro
            // 
            minimaCadastro.HeaderText = "Qtd Mínima";
            minimaCadastro.Name = "minimaCadastro";
            // 
            // LocalCadastro
            // 
            LocalCadastro.HeaderText = "Local";
            LocalCadastro.Name = "LocalCadastro";
            // 
            // StatusCadastro
            // 
            StatusCadastro.HeaderText = "Status";
            StatusCadastro.Name = "StatusCadastro";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveBorder;
            ClientSize = new Size(844, 526);
            Controls.Add(movimentacao);
            Name = "Form1";
            Text = "Controle de Estoque -TI";
            Load += Form1_Load;
            movimentacao.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            TotalItens.ResumeLayout(false);
            TotalItens.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            itensEstoque.ResumeLayout(false);
            itensCadastrados.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView3).EndInit();
            CadastrarItem.ResumeLayout(false);
            CadastrarItem.PerformLayout();
            tabPage2.ResumeLayout(false);
            ultimaMovimentacao.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView4).EndInit();
            registraMovimento.ResumeLayout(false);
            registraMovimento.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TabControl movimentacao;
        private TabPage tabPage1;
        private TabPage itensEstoque;
        private Panel TotalItens;
        private Panel panel3;
        private PictureBox pictureBox4;
        private Panel panel2;
        private PictureBox pictureBox3;
        private Panel panel1;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private Label LabelTiposCadastrados;
        private Label label4;
        private Label labelEstoqueBaixo;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private DataGridView dataGridView1;
        private DataGridView dataGridView2;
        private Label label10;
        private Label label9;
        private Button Adicionar;
        private Button Editar;
        private Button Excluir;
        private DataGridViewTextBoxColumn Item;
        private DataGridViewTextBoxColumn QtdMinima;
        private DataGridViewTextBoxColumn Categoria;
        private DataGridViewTextBoxColumn Qtd;
        private DataGridViewTextBoxColumn itemMovimenta;
        private DataGridViewTextBoxColumn tipoMovimenta;
        private DataGridViewTextBoxColumn QtdMovimenta;
        private DataGridViewTextBoxColumn motivoMovimenta;
        private DataGridViewTextBoxColumn dataMovimenta;
        private TabPage tabPage2;
        private GroupBox CadastrarItem;
        private Button CancelarItem;
        private Button SalvarItem;
        private Label nomeItem;
        private TextBox textBox1;
        private Label DescItem;
        private TextBox textBox7;
        private Label LocalItem;
        private TextBox textBox6;
        private Label label15;
        private TextBox textBox5;
        private Label qtsItens;
        private TextBox textBox4;
        private Label label13;
        private Label label12;
        private TextBox textBox2;
        private ComboBox comboBox1;
        private GroupBox itensCadastrados;
        private DataGridView dataGridView3;
        private Button btnNovaMovimentacao;
        private GroupBox registraMovimento;
        private GroupBox historicoMovimento;
        private Label ItemMovimentacao;
        private ComboBox comboBoxTipoMovimentacao;
        private Label TipoMovimentacao;
        private ComboBox comboBox2;
        private TextBox textBoxQuantidadeMovimentacao;
        private Label QuantidadeMovimentacao;
        private TextBox textBoxResponsavelMovimentacao;
        private Label ResponsavelMovimentacao;
        private TextBox textBoxMotivoMovimentacao;
        private Label MotivoMovimentacao;
        private Button cancelarMovimentacao;
        private Button registrarMovimentacao;
        private GroupBox ultimaMovimentacao;
        private DataGridView dataGridView4;
        private DataGridViewTextBoxColumn itemMovimento;
        private DataGridViewTextBoxColumn tipoMovimento;
        private DataGridViewTextBoxColumn qtdMovimento;
        private DataGridViewTextBoxColumn motivoMovimento;
        private DataGridViewTextBoxColumn responsavelMovimento;
        private DataGridViewTextBoxColumn dataMovimento;
        private Label LabelTotalItens;
        private DataGridViewTextBoxColumn IDItensCadastrados;
        private DataGridViewTextBoxColumn nomeCadastro;
        private DataGridViewTextBoxColumn CategoriaCadastro;
        private DataGridViewTextBoxColumn quantidadeCadastro;
        private DataGridViewTextBoxColumn minimaCadastro;
        private DataGridViewTextBoxColumn LocalCadastro;
        private DataGridViewComboBoxColumn StatusCadastro;
    }
}
