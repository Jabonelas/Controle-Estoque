namespace Controle_de_Estoque
{
    partial class Buscar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Buscar));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.gunaControlBox1 = new Guna.UI.WinForms.GunaControlBox();
            this.gunaControlBox2 = new Guna.UI.WinForms.GunaControlBox();
            this.lblBuscarCodItem_NF = new Guna.UI.WinForms.GunaLabel();
            this.txtBuscarCodItem_NF = new Guna.UI.WinForms.GunaTextBox();
            this.btnBuscarCodItem_Buscar = new Guna.UI.WinForms.GunaAdvenceButton();
            this.dgvBuscar = new Guna.UI.WinForms.GunaDataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblErroBuscar = new Guna.UI.WinForms.GunaLabel();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBuscar)).BeginInit();
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
            this.gunaControlBox1.TabIndex = 109;
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
            this.gunaControlBox2.TabIndex = 108;
            // 
            // lblBuscarCodItem_NF
            // 
            this.lblBuscarCodItem_NF.AutoSize = true;
            this.lblBuscarCodItem_NF.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBuscarCodItem_NF.Location = new System.Drawing.Point(12, 42);
            this.lblBuscarCodItem_NF.Name = "lblBuscarCodItem_NF";
            this.lblBuscarCodItem_NF.Size = new System.Drawing.Size(101, 21);
            this.lblBuscarCodItem_NF.TabIndex = 5;
            this.lblBuscarCodItem_NF.Text = "Cód. do Item:";
            // 
            // txtBuscarCodItem_NF
            // 
            this.txtBuscarCodItem_NF.BaseColor = System.Drawing.Color.White;
            this.txtBuscarCodItem_NF.BorderColor = System.Drawing.Color.Silver;
            this.txtBuscarCodItem_NF.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtBuscarCodItem_NF.FocusedBaseColor = System.Drawing.Color.White;
            this.txtBuscarCodItem_NF.FocusedBorderColor = System.Drawing.Color.Gray;
            this.txtBuscarCodItem_NF.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtBuscarCodItem_NF.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBuscarCodItem_NF.Location = new System.Drawing.Point(114, 33);
            this.txtBuscarCodItem_NF.Name = "txtBuscarCodItem_NF";
            this.txtBuscarCodItem_NF.PasswordChar = '\0';
            this.txtBuscarCodItem_NF.SelectedText = "";
            this.txtBuscarCodItem_NF.Size = new System.Drawing.Size(234, 32);
            this.txtBuscarCodItem_NF.TabIndex = 98;
            this.txtBuscarCodItem_NF.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBuscarCodItem_NF_KeyPress);
            // 
            // btnBuscarCodItem_Buscar
            // 
            this.btnBuscarCodItem_Buscar.Animated = true;
            this.btnBuscarCodItem_Buscar.AnimationHoverSpeed = 0.4F;
            this.btnBuscarCodItem_Buscar.AnimationSpeed = 0.03F;
            this.btnBuscarCodItem_Buscar.BackColor = System.Drawing.Color.DimGray;
            this.btnBuscarCodItem_Buscar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBuscarCodItem_Buscar.BaseColor = System.Drawing.Color.Transparent;
            this.btnBuscarCodItem_Buscar.BorderColor = System.Drawing.Color.Black;
            this.btnBuscarCodItem_Buscar.CheckedBaseColor = System.Drawing.Color.Gray;
            this.btnBuscarCodItem_Buscar.CheckedBorderColor = System.Drawing.Color.Black;
            this.btnBuscarCodItem_Buscar.CheckedForeColor = System.Drawing.Color.White;
            this.btnBuscarCodItem_Buscar.CheckedImage = ((System.Drawing.Image)(resources.GetObject("btnBuscarCodItem_Buscar.CheckedImage")));
            this.btnBuscarCodItem_Buscar.CheckedLineColor = System.Drawing.Color.DimGray;
            this.btnBuscarCodItem_Buscar.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnBuscarCodItem_Buscar.FocusedColor = System.Drawing.Color.Empty;
            this.btnBuscarCodItem_Buscar.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscarCodItem_Buscar.ForeColor = System.Drawing.Color.White;
            this.btnBuscarCodItem_Buscar.Image = global::Controle_de_Estoque.Properties.Resources.lupa;
            this.btnBuscarCodItem_Buscar.ImageSize = new System.Drawing.Size(20, 20);
            this.btnBuscarCodItem_Buscar.LineBottom = 4;
            this.btnBuscarCodItem_Buscar.LineColor = System.Drawing.Color.Transparent;
            this.btnBuscarCodItem_Buscar.Location = new System.Drawing.Point(373, 33);
            this.btnBuscarCodItem_Buscar.Name = "btnBuscarCodItem_Buscar";
            this.btnBuscarCodItem_Buscar.OnHoverBaseColor = System.Drawing.Color.Transparent;
            this.btnBuscarCodItem_Buscar.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnBuscarCodItem_Buscar.OnHoverForeColor = System.Drawing.Color.White;
            this.btnBuscarCodItem_Buscar.OnHoverImage = null;
            this.btnBuscarCodItem_Buscar.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnBuscarCodItem_Buscar.OnPressedColor = System.Drawing.Color.Black;
            this.btnBuscarCodItem_Buscar.Size = new System.Drawing.Size(85, 32);
            this.btnBuscarCodItem_Buscar.TabIndex = 98;
            this.btnBuscarCodItem_Buscar.Text = "Buscar";
            this.btnBuscarCodItem_Buscar.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.btnBuscarCodItem_Buscar.Click += new System.EventHandler(this.btnBuscarCodItem_Buscar_Click);
            // 
            // dgvBuscar
            // 
            this.dgvBuscar.AllowUserToResizeRows = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            this.dgvBuscar.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvBuscar.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvBuscar.BackgroundColor = System.Drawing.Color.White;
            this.dgvBuscar.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvBuscar.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvBuscar.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvBuscar.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvBuscar.ColumnHeadersHeight = 45;
            this.dgvBuscar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvBuscar.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
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
            this.dgvBuscar.DefaultCellStyle = dataGridViewCellStyle6;
            this.dgvBuscar.EnableHeadersVisualStyles = false;
            this.dgvBuscar.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvBuscar.Location = new System.Drawing.Point(14, 83);
            this.dgvBuscar.Name = "dgvBuscar";
            this.dgvBuscar.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvBuscar.RowHeadersVisible = false;
            this.dgvBuscar.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvBuscar.Size = new System.Drawing.Size(1152, 442);
            this.dgvBuscar.StandardTab = true;
            this.dgvBuscar.TabIndex = 34;
            this.dgvBuscar.Theme = Guna.UI.WinForms.GunaDataGridViewPresetThemes.Guna;
            this.dgvBuscar.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvBuscar.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvBuscar.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvBuscar.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvBuscar.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvBuscar.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgvBuscar.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvBuscar.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.Gray;
            this.dgvBuscar.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            this.dgvBuscar.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dgvBuscar.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvBuscar.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvBuscar.ThemeStyle.HeaderStyle.Height = 45;
            this.dgvBuscar.ThemeStyle.ReadOnly = false;
            this.dgvBuscar.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvBuscar.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvBuscar.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dgvBuscar.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvBuscar.ThemeStyle.RowsStyle.Height = 22;
            this.dgvBuscar.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvBuscar.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Nota Fiscal";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Código do Item";
            this.Column2.Name = "Column2";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Descrição do Produto";
            this.Column4.Name = "Column4";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Quantidade";
            this.Column3.Name = "Column3";
            // 
            // Column5
            // 
            this.Column5.HeaderText = "UN";
            this.Column5.Name = "Column5";
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Local";
            this.Column6.Name = "Column6";
            // 
            // Column8
            // 
            this.Column8.HeaderText = "Lote";
            this.Column8.Name = "Column8";
            // 
            // Column7
            // 
            this.Column7.HeaderText = "Código de Barra";
            this.Column7.Name = "Column7";
            // 
            // lblErroBuscar
            // 
            this.lblErroBuscar.AutoSize = true;
            this.lblErroBuscar.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblErroBuscar.ForeColor = System.Drawing.Color.Red;
            this.lblErroBuscar.Location = new System.Drawing.Point(348, 34);
            this.lblErroBuscar.Name = "lblErroBuscar";
            this.lblErroBuscar.Size = new System.Drawing.Size(0, 32);
            this.lblErroBuscar.TabIndex = 110;
            // 
            // Buscar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1180, 537);
            this.Controls.Add(this.dgvBuscar);
            this.Controls.Add(this.btnBuscarCodItem_Buscar);
            this.Controls.Add(this.txtBuscarCodItem_NF);
            this.Controls.Add(this.lblBuscarCodItem_NF);
            this.Controls.Add(this.gunaControlBox2);
            this.Controls.Add(this.gunaControlBox1);
            this.Controls.Add(this.lblErroBuscar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Buscar";
            this.Text = "Estoque";
            this.Load += new System.EventHandler(this.Estoque_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBuscar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI.WinForms.GunaControlBox gunaControlBox1;
        private Guna.UI.WinForms.GunaControlBox gunaControlBox2;
        private Guna.UI.WinForms.GunaLabel lblBuscarCodItem_NF;
        private Guna.UI.WinForms.GunaTextBox txtBuscarCodItem_NF;
        private Guna.UI.WinForms.GunaAdvenceButton btnBuscarCodItem_Buscar;
        private Guna.UI.WinForms.GunaDataGridView dgvBuscar;
        private Guna.UI.WinForms.GunaLabel lblErroBuscar;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
    }
}