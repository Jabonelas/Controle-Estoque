namespace Controle_de_Estoque
{
    partial class Estoque
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Estoque));
            this.gunaControlBox1 = new Guna.UI.WinForms.GunaControlBox();
            this.gunaControlBox2 = new Guna.UI.WinForms.GunaControlBox();
            this.txtEstoqueCodBarra = new Guna.UI.WinForms.GunaTextBox();
            this.gunaLabel2 = new Guna.UI.WinForms.GunaLabel();
            this.txtEstoqueCodItem = new Guna.UI.WinForms.GunaTextBox();
            this.gunaLabel1 = new Guna.UI.WinForms.GunaLabel();
            this.txtEstoqueQuantidade = new Guna.UI.WinForms.GunaTextBox();
            this.gunaLabel3 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel4 = new Guna.UI.WinForms.GunaLabel();
            this.txtEstoqueLocal = new Guna.UI.WinForms.GunaTextBox();
            this.gunaLabel5 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel6 = new Guna.UI.WinForms.GunaLabel();
            this.txtEstoqueDescricao = new Guna.UI.WinForms.GunaTextBox();
            this.dgvEstoque = new Guna.UI.WinForms.GunaDataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtEstoqueDestino = new Guna.UI2.WinForms.Guna2ComboBox();
            this.guna2AnimateWindow1 = new Guna.UI2.WinForms.Guna2AnimateWindow(this.components);
            this.lblDestino = new Guna.UI.WinForms.GunaLabel();
            this.lblbarra = new Guna.UI.WinForms.GunaLabel();
            this.txtEstoqueLote = new Guna.UI.WinForms.GunaTextBox();
            this.gunaLabel7 = new Guna.UI.WinForms.GunaLabel();
            this.btnEstoqueConfirmar_Buscar = new Guna.UI.WinForms.GunaAdvenceButton();
            this.btnEstoqueCodBarra_Buscar = new Guna.UI.WinForms.GunaAdvenceButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEstoque)).BeginInit();
            this.SuspendLayout();
            // 
            // gunaControlBox1
            // 
            this.gunaControlBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.gunaControlBox1.AnimationHoverSpeed = 0.07F;
            this.gunaControlBox1.AnimationSpeed = 0.03F;
            this.gunaControlBox1.IconColor = System.Drawing.Color.Black;
            this.gunaControlBox1.IconSize = 15F;
            this.gunaControlBox1.Location = new System.Drawing.Point(1135, 0);
            this.gunaControlBox1.Name = "gunaControlBox1";
            this.gunaControlBox1.OnHoverBackColor = System.Drawing.Color.Gray;
            this.gunaControlBox1.OnHoverIconColor = System.Drawing.Color.White;
            this.gunaControlBox1.OnPressedColor = System.Drawing.Color.Black;
            this.gunaControlBox1.Size = new System.Drawing.Size(45, 29);
            this.gunaControlBox1.TabIndex = 1;
            // 
            // gunaControlBox2
            // 
            this.gunaControlBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.gunaControlBox2.AnimationHoverSpeed = 0.07F;
            this.gunaControlBox2.AnimationSpeed = 0.03F;
            this.gunaControlBox2.ControlBoxType = Guna.UI.WinForms.FormControlBoxType.MinimizeBox;
            this.gunaControlBox2.IconColor = System.Drawing.Color.Black;
            this.gunaControlBox2.IconSize = 15F;
            this.gunaControlBox2.Location = new System.Drawing.Point(1084, -1);
            this.gunaControlBox2.Name = "gunaControlBox2";
            this.gunaControlBox2.OnHoverBackColor = System.Drawing.Color.Gray;
            this.gunaControlBox2.OnHoverIconColor = System.Drawing.Color.White;
            this.gunaControlBox2.OnPressedColor = System.Drawing.Color.Black;
            this.gunaControlBox2.Size = new System.Drawing.Size(45, 29);
            this.gunaControlBox2.TabIndex = 2;
            // 
            // txtEstoqueCodBarra
            // 
            this.txtEstoqueCodBarra.BaseColor = System.Drawing.Color.White;
            this.txtEstoqueCodBarra.BorderColor = System.Drawing.Color.Silver;
            this.txtEstoqueCodBarra.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtEstoqueCodBarra.FocusedBaseColor = System.Drawing.Color.White;
            this.txtEstoqueCodBarra.FocusedBorderColor = System.Drawing.Color.Gray;
            this.txtEstoqueCodBarra.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtEstoqueCodBarra.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEstoqueCodBarra.Location = new System.Drawing.Point(114, 33);
            this.txtEstoqueCodBarra.Name = "txtEstoqueCodBarra";
            this.txtEstoqueCodBarra.PasswordChar = '\0';
            this.txtEstoqueCodBarra.SelectedText = "";
            this.txtEstoqueCodBarra.Size = new System.Drawing.Size(234, 32);
            this.txtEstoqueCodBarra.TabIndex = 3;
            this.txtEstoqueCodBarra.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtEstoqueCodBarra_KeyPress);
            // 
            // gunaLabel2
            // 
            this.gunaLabel2.AutoSize = true;
            this.gunaLabel2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel2.Location = new System.Drawing.Point(12, 94);
            this.gunaLabel2.Name = "gunaLabel2";
            this.gunaLabel2.Size = new System.Drawing.Size(101, 21);
            this.gunaLabel2.TabIndex = 6;
            this.gunaLabel2.Text = "Cód. do Item:";
            // 
            // txtEstoqueCodItem
            // 
            this.txtEstoqueCodItem.BaseColor = System.Drawing.Color.White;
            this.txtEstoqueCodItem.BorderColor = System.Drawing.Color.Silver;
            this.txtEstoqueCodItem.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtEstoqueCodItem.FocusedBaseColor = System.Drawing.Color.White;
            this.txtEstoqueCodItem.FocusedBorderColor = System.Drawing.Color.Gray;
            this.txtEstoqueCodItem.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtEstoqueCodItem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEstoqueCodItem.Location = new System.Drawing.Point(114, 83);
            this.txtEstoqueCodItem.Name = "txtEstoqueCodItem";
            this.txtEstoqueCodItem.PasswordChar = '\0';
            this.txtEstoqueCodItem.ReadOnly = true;
            this.txtEstoqueCodItem.SelectedText = "";
            this.txtEstoqueCodItem.Size = new System.Drawing.Size(234, 32);
            this.txtEstoqueCodItem.TabIndex = 8;
            // 
            // gunaLabel1
            // 
            this.gunaLabel1.AutoSize = true;
            this.gunaLabel1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel1.Location = new System.Drawing.Point(12, 44);
            this.gunaLabel1.Name = "gunaLabel1";
            this.gunaLabel1.Size = new System.Drawing.Size(106, 21);
            this.gunaLabel1.TabIndex = 9;
            this.gunaLabel1.Text = "Cód. de Barra:";
            // 
            // txtEstoqueQuantidade
            // 
            this.txtEstoqueQuantidade.BaseColor = System.Drawing.Color.White;
            this.txtEstoqueQuantidade.BorderColor = System.Drawing.Color.Silver;
            this.txtEstoqueQuantidade.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtEstoqueQuantidade.FocusedBaseColor = System.Drawing.Color.White;
            this.txtEstoqueQuantidade.FocusedBorderColor = System.Drawing.Color.Gray;
            this.txtEstoqueQuantidade.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtEstoqueQuantidade.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEstoqueQuantidade.Location = new System.Drawing.Point(114, 233);
            this.txtEstoqueQuantidade.Name = "txtEstoqueQuantidade";
            this.txtEstoqueQuantidade.PasswordChar = '\0';
            this.txtEstoqueQuantidade.ReadOnly = true;
            this.txtEstoqueQuantidade.SelectedText = "";
            this.txtEstoqueQuantidade.Size = new System.Drawing.Size(163, 32);
            this.txtEstoqueQuantidade.TabIndex = 12;
            // 
            // gunaLabel3
            // 
            this.gunaLabel3.AutoSize = true;
            this.gunaLabel3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel3.Location = new System.Drawing.Point(12, 294);
            this.gunaLabel3.Name = "gunaLabel3";
            this.gunaLabel3.Size = new System.Drawing.Size(49, 21);
            this.gunaLabel3.TabIndex = 13;
            this.gunaLabel3.Text = "Local:";
            // 
            // gunaLabel4
            // 
            this.gunaLabel4.AutoSize = true;
            this.gunaLabel4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel4.Location = new System.Drawing.Point(12, 348);
            this.gunaLabel4.Name = "gunaLabel4";
            this.gunaLabel4.Size = new System.Drawing.Size(66, 21);
            this.gunaLabel4.TabIndex = 14;
            this.gunaLabel4.Text = "Destino:";
            // 
            // txtEstoqueLocal
            // 
            this.txtEstoqueLocal.BaseColor = System.Drawing.Color.White;
            this.txtEstoqueLocal.BorderColor = System.Drawing.Color.Silver;
            this.txtEstoqueLocal.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtEstoqueLocal.FocusedBaseColor = System.Drawing.Color.White;
            this.txtEstoqueLocal.FocusedBorderColor = System.Drawing.Color.Gray;
            this.txtEstoqueLocal.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtEstoqueLocal.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEstoqueLocal.Location = new System.Drawing.Point(114, 283);
            this.txtEstoqueLocal.Name = "txtEstoqueLocal";
            this.txtEstoqueLocal.PasswordChar = '\0';
            this.txtEstoqueLocal.ReadOnly = true;
            this.txtEstoqueLocal.SelectedText = "";
            this.txtEstoqueLocal.Size = new System.Drawing.Size(163, 32);
            this.txtEstoqueLocal.TabIndex = 15;
            // 
            // gunaLabel5
            // 
            this.gunaLabel5.AutoSize = true;
            this.gunaLabel5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel5.Location = new System.Drawing.Point(12, 244);
            this.gunaLabel5.Name = "gunaLabel5";
            this.gunaLabel5.Size = new System.Drawing.Size(94, 21);
            this.gunaLabel5.TabIndex = 16;
            this.gunaLabel5.Text = "Quantidade:";
            // 
            // gunaLabel6
            // 
            this.gunaLabel6.AutoSize = true;
            this.gunaLabel6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel6.Location = new System.Drawing.Point(12, 194);
            this.gunaLabel6.Name = "gunaLabel6";
            this.gunaLabel6.Size = new System.Drawing.Size(80, 21);
            this.gunaLabel6.TabIndex = 17;
            this.gunaLabel6.Text = "Descrição:";
            // 
            // txtEstoqueDescricao
            // 
            this.txtEstoqueDescricao.BaseColor = System.Drawing.Color.White;
            this.txtEstoqueDescricao.BorderColor = System.Drawing.Color.Silver;
            this.txtEstoqueDescricao.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtEstoqueDescricao.FocusedBaseColor = System.Drawing.Color.White;
            this.txtEstoqueDescricao.FocusedBorderColor = System.Drawing.Color.Gray;
            this.txtEstoqueDescricao.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtEstoqueDescricao.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEstoqueDescricao.Location = new System.Drawing.Point(114, 183);
            this.txtEstoqueDescricao.Name = "txtEstoqueDescricao";
            this.txtEstoqueDescricao.PasswordChar = '\0';
            this.txtEstoqueDescricao.ReadOnly = true;
            this.txtEstoqueDescricao.SelectedText = "";
            this.txtEstoqueDescricao.Size = new System.Drawing.Size(691, 32);
            this.txtEstoqueDescricao.TabIndex = 18;
            // 
            // dgvEstoque
            // 
            this.dgvEstoque.AllowUserToResizeRows = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            this.dgvEstoque.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvEstoque.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvEstoque.BackgroundColor = System.Drawing.Color.White;
            this.dgvEstoque.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvEstoque.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvEstoque.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvEstoque.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvEstoque.ColumnHeadersHeight = 45;
            this.dgvEstoque.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvEstoque.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column4,
            this.Column3,
            this.Column5,
            this.Column6,
            this.Column8,
            this.Column7});
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvEstoque.DefaultCellStyle = dataGridViewCellStyle6;
            this.dgvEstoque.EnableHeadersVisualStyles = false;
            this.dgvEstoque.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvEstoque.Location = new System.Drawing.Point(16, 383);
            this.dgvEstoque.Name = "dgvEstoque";
            this.dgvEstoque.ReadOnly = true;
            this.dgvEstoque.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvEstoque.RowHeadersVisible = false;
            this.dgvEstoque.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvEstoque.Size = new System.Drawing.Size(1150, 142);
            this.dgvEstoque.StandardTab = true;
            this.dgvEstoque.TabIndex = 35;
            this.dgvEstoque.Theme = Guna.UI.WinForms.GunaDataGridViewPresetThemes.Guna;
            this.dgvEstoque.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvEstoque.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvEstoque.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvEstoque.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvEstoque.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvEstoque.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgvEstoque.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvEstoque.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.Gray;
            this.dgvEstoque.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            this.dgvEstoque.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dgvEstoque.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvEstoque.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvEstoque.ThemeStyle.HeaderStyle.Height = 45;
            this.dgvEstoque.ThemeStyle.ReadOnly = true;
            this.dgvEstoque.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvEstoque.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvEstoque.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dgvEstoque.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvEstoque.ThemeStyle.RowsStyle.Height = 22;
            this.dgvEstoque.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvEstoque.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Nota Fiscal";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Código do Item";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Descrição do Produto";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Quantidade";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "UN";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Local";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            // 
            // Column8
            // 
            this.Column8.HeaderText = "Lote";
            this.Column8.Name = "Column8";
            this.Column8.ReadOnly = true;
            // 
            // Column7
            // 
            this.Column7.HeaderText = "Código de Barra";
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            // 
            // txtEstoqueDestino
            // 
            this.txtEstoqueDestino.BackColor = System.Drawing.Color.Transparent;
            this.txtEstoqueDestino.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.txtEstoqueDestino.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txtEstoqueDestino.FocusedColor = System.Drawing.Color.Empty;
            this.txtEstoqueDestino.FocusedState.Parent = this.txtEstoqueDestino;
            this.txtEstoqueDestino.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEstoqueDestino.ForeColor = System.Drawing.Color.Black;
            this.txtEstoqueDestino.FormattingEnabled = true;
            this.txtEstoqueDestino.HoverState.Parent = this.txtEstoqueDestino;
            this.txtEstoqueDestino.ItemHeight = 30;
            this.txtEstoqueDestino.Items.AddRange(new object[] {
            "RECEBIMENTO",
            "EST. A - 1 - 1",
            "EST. A - 1 - 2",
            "EST. A - 2 - 1",
            "EST. A - 2 - 2",
            "EST. B - 1 - 1",
            "EST. B - 1 - 2",
            "EST. B - 2 - 1",
            "EST. B - 2 - 2",
            "EST. C - 1 - 1",
            "EST. C - 1 - 2",
            "EST. C - 2 - 1",
            "EST. C - 2 - 2",
            "PRODUÇÃO",
            ""});
            this.txtEstoqueDestino.ItemsAppearance.Parent = this.txtEstoqueDestino;
            this.txtEstoqueDestino.Location = new System.Drawing.Point(114, 333);
            this.txtEstoqueDestino.Name = "txtEstoqueDestino";
            this.txtEstoqueDestino.ShadowDecoration.Parent = this.txtEstoqueDestino;
            this.txtEstoqueDestino.Size = new System.Drawing.Size(163, 36);
            this.txtEstoqueDestino.TabIndex = 37;
            // 
            // lblDestino
            // 
            this.lblDestino.AutoSize = true;
            this.lblDestino.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDestino.ForeColor = System.Drawing.Color.Red;
            this.lblDestino.Location = new System.Drawing.Point(277, 338);
            this.lblDestino.Name = "lblDestino";
            this.lblDestino.Size = new System.Drawing.Size(0, 32);
            this.lblDestino.TabIndex = 38;
            // 
            // lblbarra
            // 
            this.lblbarra.AutoSize = true;
            this.lblbarra.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblbarra.ForeColor = System.Drawing.Color.Red;
            this.lblbarra.Location = new System.Drawing.Point(348, 35);
            this.lblbarra.Name = "lblbarra";
            this.lblbarra.Size = new System.Drawing.Size(0, 32);
            this.lblbarra.TabIndex = 39;
            // 
            // txtEstoqueLote
            // 
            this.txtEstoqueLote.BaseColor = System.Drawing.Color.White;
            this.txtEstoqueLote.BorderColor = System.Drawing.Color.Silver;
            this.txtEstoqueLote.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtEstoqueLote.FocusedBaseColor = System.Drawing.Color.White;
            this.txtEstoqueLote.FocusedBorderColor = System.Drawing.Color.Gray;
            this.txtEstoqueLote.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtEstoqueLote.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEstoqueLote.Location = new System.Drawing.Point(114, 133);
            this.txtEstoqueLote.Name = "txtEstoqueLote";
            this.txtEstoqueLote.PasswordChar = '\0';
            this.txtEstoqueLote.ReadOnly = true;
            this.txtEstoqueLote.SelectedText = "";
            this.txtEstoqueLote.Size = new System.Drawing.Size(234, 32);
            this.txtEstoqueLote.TabIndex = 40;
            // 
            // gunaLabel7
            // 
            this.gunaLabel7.AutoSize = true;
            this.gunaLabel7.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel7.Location = new System.Drawing.Point(12, 144);
            this.gunaLabel7.Name = "gunaLabel7";
            this.gunaLabel7.Size = new System.Drawing.Size(43, 21);
            this.gunaLabel7.TabIndex = 41;
            this.gunaLabel7.Text = "Lote:";
            // 
            // btnEstoqueConfirmar_Buscar
            // 
            this.btnEstoqueConfirmar_Buscar.Animated = true;
            this.btnEstoqueConfirmar_Buscar.AnimationHoverSpeed = 0.4F;
            this.btnEstoqueConfirmar_Buscar.AnimationSpeed = 0.03F;
            this.btnEstoqueConfirmar_Buscar.BackColor = System.Drawing.Color.DimGray;
            this.btnEstoqueConfirmar_Buscar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnEstoqueConfirmar_Buscar.BaseColor = System.Drawing.Color.Transparent;
            this.btnEstoqueConfirmar_Buscar.BorderColor = System.Drawing.Color.Black;
            this.btnEstoqueConfirmar_Buscar.CheckedBaseColor = System.Drawing.Color.Gray;
            this.btnEstoqueConfirmar_Buscar.CheckedBorderColor = System.Drawing.Color.Black;
            this.btnEstoqueConfirmar_Buscar.CheckedForeColor = System.Drawing.Color.White;
            this.btnEstoqueConfirmar_Buscar.CheckedImage = ((System.Drawing.Image)(resources.GetObject("btnEstoqueConfirmar_Buscar.CheckedImage")));
            this.btnEstoqueConfirmar_Buscar.CheckedLineColor = System.Drawing.Color.DimGray;
            this.btnEstoqueConfirmar_Buscar.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnEstoqueConfirmar_Buscar.FocusedColor = System.Drawing.Color.Empty;
            this.btnEstoqueConfirmar_Buscar.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEstoqueConfirmar_Buscar.ForeColor = System.Drawing.Color.White;
            this.btnEstoqueConfirmar_Buscar.Image = global::Controle_de_Estoque.Properties.Resources.ok;
            this.btnEstoqueConfirmar_Buscar.ImageSize = new System.Drawing.Size(20, 20);
            this.btnEstoqueConfirmar_Buscar.LineBottom = 4;
            this.btnEstoqueConfirmar_Buscar.LineColor = System.Drawing.Color.Transparent;
            this.btnEstoqueConfirmar_Buscar.Location = new System.Drawing.Point(573, 33);
            this.btnEstoqueConfirmar_Buscar.Name = "btnEstoqueConfirmar_Buscar";
            this.btnEstoqueConfirmar_Buscar.OnHoverBaseColor = System.Drawing.Color.Transparent;
            this.btnEstoqueConfirmar_Buscar.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnEstoqueConfirmar_Buscar.OnHoverForeColor = System.Drawing.Color.White;
            this.btnEstoqueConfirmar_Buscar.OnHoverImage = null;
            this.btnEstoqueConfirmar_Buscar.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnEstoqueConfirmar_Buscar.OnPressedColor = System.Drawing.Color.Black;
            this.btnEstoqueConfirmar_Buscar.Size = new System.Drawing.Size(125, 33);
            this.btnEstoqueConfirmar_Buscar.TabIndex = 36;
            this.btnEstoqueConfirmar_Buscar.Text = "Confirmar";
            this.btnEstoqueConfirmar_Buscar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnEstoqueConfirmar_Buscar.Click += new System.EventHandler(this.btnEstoqueConfirmar_Buscar_Click);
            // 
            // btnEstoqueCodBarra_Buscar
            // 
            this.btnEstoqueCodBarra_Buscar.Animated = true;
            this.btnEstoqueCodBarra_Buscar.AnimationHoverSpeed = 0.4F;
            this.btnEstoqueCodBarra_Buscar.AnimationSpeed = 0.03F;
            this.btnEstoqueCodBarra_Buscar.BackColor = System.Drawing.Color.DimGray;
            this.btnEstoqueCodBarra_Buscar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnEstoqueCodBarra_Buscar.BaseColor = System.Drawing.Color.Transparent;
            this.btnEstoqueCodBarra_Buscar.BorderColor = System.Drawing.Color.Black;
            this.btnEstoqueCodBarra_Buscar.CheckedBaseColor = System.Drawing.Color.Gray;
            this.btnEstoqueCodBarra_Buscar.CheckedBorderColor = System.Drawing.Color.Black;
            this.btnEstoqueCodBarra_Buscar.CheckedForeColor = System.Drawing.Color.White;
            this.btnEstoqueCodBarra_Buscar.CheckedImage = ((System.Drawing.Image)(resources.GetObject("btnEstoqueCodBarra_Buscar.CheckedImage")));
            this.btnEstoqueCodBarra_Buscar.CheckedLineColor = System.Drawing.Color.DimGray;
            this.btnEstoqueCodBarra_Buscar.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnEstoqueCodBarra_Buscar.FocusedColor = System.Drawing.Color.Empty;
            this.btnEstoqueCodBarra_Buscar.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEstoqueCodBarra_Buscar.ForeColor = System.Drawing.Color.White;
            this.btnEstoqueCodBarra_Buscar.Image = global::Controle_de_Estoque.Properties.Resources.lupa;
            this.btnEstoqueCodBarra_Buscar.ImageSize = new System.Drawing.Size(20, 20);
            this.btnEstoqueCodBarra_Buscar.LineBottom = 4;
            this.btnEstoqueCodBarra_Buscar.LineColor = System.Drawing.Color.Transparent;
            this.btnEstoqueCodBarra_Buscar.Location = new System.Drawing.Point(378, 33);
            this.btnEstoqueCodBarra_Buscar.Name = "btnEstoqueCodBarra_Buscar";
            this.btnEstoqueCodBarra_Buscar.OnHoverBaseColor = System.Drawing.Color.Transparent;
            this.btnEstoqueCodBarra_Buscar.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnEstoqueCodBarra_Buscar.OnHoverForeColor = System.Drawing.Color.White;
            this.btnEstoqueCodBarra_Buscar.OnHoverImage = null;
            this.btnEstoqueCodBarra_Buscar.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnEstoqueCodBarra_Buscar.OnPressedColor = System.Drawing.Color.Black;
            this.btnEstoqueCodBarra_Buscar.Size = new System.Drawing.Size(85, 32);
            this.btnEstoqueCodBarra_Buscar.TabIndex = 10;
            this.btnEstoqueCodBarra_Buscar.Text = "Buscar";
            this.btnEstoqueCodBarra_Buscar.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.btnEstoqueCodBarra_Buscar.Click += new System.EventHandler(this.btnEstoqueCodBarra_Buscar_Click);
            // 
            // Estoque
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1180, 537);
            this.Controls.Add(this.gunaLabel7);
            this.Controls.Add(this.txtEstoqueLote);
            this.Controls.Add(this.txtEstoqueDestino);
            this.Controls.Add(this.btnEstoqueConfirmar_Buscar);
            this.Controls.Add(this.dgvEstoque);
            this.Controls.Add(this.txtEstoqueDescricao);
            this.Controls.Add(this.gunaLabel6);
            this.Controls.Add(this.gunaLabel5);
            this.Controls.Add(this.txtEstoqueLocal);
            this.Controls.Add(this.gunaLabel4);
            this.Controls.Add(this.gunaLabel3);
            this.Controls.Add(this.txtEstoqueQuantidade);
            this.Controls.Add(this.btnEstoqueCodBarra_Buscar);
            this.Controls.Add(this.txtEstoqueCodItem);
            this.Controls.Add(this.gunaLabel2);
            this.Controls.Add(this.txtEstoqueCodBarra);
            this.Controls.Add(this.gunaControlBox2);
            this.Controls.Add(this.gunaControlBox1);
            this.Controls.Add(this.gunaLabel1);
            this.Controls.Add(this.lblbarra);
            this.Controls.Add(this.lblDestino);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Estoque";
            this.Text = "Buscar";
            this.Load += new System.EventHandler(this.Buscar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEstoque)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI.WinForms.GunaControlBox gunaControlBox1;
        private Guna.UI.WinForms.GunaControlBox gunaControlBox2;
        private Guna.UI.WinForms.GunaTextBox txtEstoqueCodBarra;
        private Guna.UI.WinForms.GunaLabel gunaLabel2;
        private Guna.UI.WinForms.GunaTextBox txtEstoqueCodItem;
        private Guna.UI.WinForms.GunaLabel gunaLabel1;
        private Guna.UI.WinForms.GunaAdvenceButton btnEstoqueCodBarra_Buscar;
        private Guna.UI.WinForms.GunaTextBox txtEstoqueQuantidade;
        private Guna.UI.WinForms.GunaLabel gunaLabel3;
        private Guna.UI.WinForms.GunaLabel gunaLabel4;
        private Guna.UI.WinForms.GunaTextBox txtEstoqueLocal;
        private Guna.UI.WinForms.GunaLabel gunaLabel5;
        private Guna.UI.WinForms.GunaLabel gunaLabel6;
        private Guna.UI.WinForms.GunaTextBox txtEstoqueDescricao;
        private Guna.UI.WinForms.GunaDataGridView dgvEstoque;
        private Guna.UI.WinForms.GunaAdvenceButton btnEstoqueConfirmar_Buscar;
        private Guna.UI2.WinForms.Guna2ComboBox txtEstoqueDestino;
        private Guna.UI2.WinForms.Guna2AnimateWindow guna2AnimateWindow1;
        private Guna.UI.WinForms.GunaLabel lblDestino;
        private Guna.UI.WinForms.GunaLabel lblbarra;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private Guna.UI.WinForms.GunaTextBox txtEstoqueLote;
        private Guna.UI.WinForms.GunaLabel gunaLabel7;
    }
}