namespace Controle_de_Estoque
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.guna2ControlBox1 = new Guna.UI2.WinForms.Guna2ControlBox();
            this.guna2ControlBox3 = new Guna.UI2.WinForms.Guna2ControlBox();
            this.gunaPanel1 = new Guna.UI.WinForms.GunaPanel();
            this.gunaLabel1 = new Guna.UI.WinForms.GunaLabel();
            this.gunaPanel2 = new Guna.UI.WinForms.GunaPanel();
            this.gunaLabel2 = new Guna.UI.WinForms.GunaLabel();
            this.guna2DragControl1 = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.gunaPanel3 = new Guna.UI.WinForms.GunaPanel();
            this.gunaLabel3 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel5 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel4 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel_name1 = new Guna.UI.WinForms.GunaLabel();
            this.TelaInicial = new Guna.UI.WinForms.GunaPanel();
            this.btnSaidaNF = new Guna.UI.WinForms.GunaAdvenceButton();
            this.btnEntradaNF = new Guna.UI.WinForms.GunaAdvenceButton();
            this.btnBuscar = new Guna.UI.WinForms.GunaAdvenceButton();
            this.btnEstoque = new Guna.UI.WinForms.GunaAdvenceButton();
            this.gunaCirclePictureBox1 = new Guna.UI.WinForms.GunaCirclePictureBox();
            this.guna2DragControl2 = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.gunaPanel1.SuspendLayout();
            this.gunaPanel2.SuspendLayout();
            this.gunaPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gunaCirclePictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2ControlBox1
            // 
            this.guna2ControlBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2ControlBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.guna2ControlBox1.FillColor = System.Drawing.Color.Transparent;
            this.guna2ControlBox1.HoverState.Parent = this.guna2ControlBox1;
            this.guna2ControlBox1.IconColor = System.Drawing.Color.White;
            this.guna2ControlBox1.Location = new System.Drawing.Point(1153, -2);
            this.guna2ControlBox1.Name = "guna2ControlBox1";
            this.guna2ControlBox1.ShadowDecoration.Parent = this.guna2ControlBox1;
            this.guna2ControlBox1.Size = new System.Drawing.Size(45, 29);
            this.guna2ControlBox1.TabIndex = 0;
            // 
            // guna2ControlBox3
            // 
            this.guna2ControlBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2ControlBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.guna2ControlBox3.ControlBoxType = Guna.UI2.WinForms.Enums.ControlBoxType.MinimizeBox;
            this.guna2ControlBox3.FillColor = System.Drawing.Color.Transparent;
            this.guna2ControlBox3.HoverState.Parent = this.guna2ControlBox3;
            this.guna2ControlBox3.IconColor = System.Drawing.Color.White;
            this.guna2ControlBox3.Location = new System.Drawing.Point(1111, 0);
            this.guna2ControlBox3.Name = "guna2ControlBox3";
            this.guna2ControlBox3.ShadowDecoration.Parent = this.guna2ControlBox3;
            this.guna2ControlBox3.Size = new System.Drawing.Size(45, 29);
            this.guna2ControlBox3.TabIndex = 2;
            // 
            // gunaPanel1
            // 
            this.gunaPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gunaPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.gunaPanel1.Controls.Add(this.gunaLabel1);
            this.gunaPanel1.Controls.Add(this.guna2ControlBox3);
            this.gunaPanel1.Location = new System.Drawing.Point(-9, -2);
            this.gunaPanel1.Name = "gunaPanel1";
            this.gunaPanel1.Size = new System.Drawing.Size(1265, 30);
            this.gunaPanel1.TabIndex = 3;
            // 
            // gunaLabel1
            // 
            this.gunaLabel1.AutoSize = true;
            this.gunaLabel1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel1.ForeColor = System.Drawing.Color.White;
            this.gunaLabel1.Location = new System.Drawing.Point(27, 7);
            this.gunaLabel1.Name = "gunaLabel1";
            this.gunaLabel1.Size = new System.Drawing.Size(81, 19);
            this.gunaLabel1.TabIndex = 15;
            this.gunaLabel1.Text = "Inventory";
            // 
            // gunaPanel2
            // 
            this.gunaPanel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.gunaPanel2.Controls.Add(this.gunaLabel2);
            this.gunaPanel2.Location = new System.Drawing.Point(-9, 26);
            this.gunaPanel2.Name = "gunaPanel2";
            this.gunaPanel2.Size = new System.Drawing.Size(105, 30);
            this.gunaPanel2.TabIndex = 4;
            // 
            // gunaLabel2
            // 
            this.gunaLabel2.AutoSize = true;
            this.gunaLabel2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel2.ForeColor = System.Drawing.Color.White;
            this.gunaLabel2.Location = new System.Drawing.Point(32, 1);
            this.gunaLabel2.Name = "gunaLabel2";
            this.gunaLabel2.Size = new System.Drawing.Size(66, 19);
            this.gunaLabel2.TabIndex = 16;
            this.gunaLabel2.Text = "Control";
            // 
            // guna2DragControl1
            // 
            this.guna2DragControl1.TargetControl = this;
            // 
            // gunaPanel3
            // 
            this.gunaPanel3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gunaPanel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.gunaPanel3.Controls.Add(this.gunaLabel3);
            this.gunaPanel3.Controls.Add(this.gunaLabel5);
            this.gunaPanel3.Controls.Add(this.gunaLabel4);
            this.gunaPanel3.Controls.Add(this.gunaLabel_name1);
            this.gunaPanel3.Location = new System.Drawing.Point(9, 116);
            this.gunaPanel3.Name = "gunaPanel3";
            this.gunaPanel3.Size = new System.Drawing.Size(1180, 26);
            this.gunaPanel3.TabIndex = 16;
            // 
            // gunaLabel3
            // 
            this.gunaLabel3.AutoSize = true;
            this.gunaLabel3.BackColor = System.Drawing.Color.Transparent;
            this.gunaLabel3.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.gunaLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.gunaLabel3.Location = new System.Drawing.Point(673, 5);
            this.gunaLabel3.Name = "gunaLabel3";
            this.gunaLabel3.Size = new System.Drawing.Size(65, 16);
            this.gunaLabel3.TabIndex = 23;
            this.gunaLabel3.Text = "Estoque";
            // 
            // gunaLabel5
            // 
            this.gunaLabel5.AutoSize = true;
            this.gunaLabel5.BackColor = System.Drawing.Color.Transparent;
            this.gunaLabel5.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.gunaLabel5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.gunaLabel5.Location = new System.Drawing.Point(452, 5);
            this.gunaLabel5.Name = "gunaLabel5";
            this.gunaLabel5.Size = new System.Drawing.Size(56, 16);
            this.gunaLabel5.TabIndex = 22;
            this.gunaLabel5.Text = "Buscar";
            // 
            // gunaLabel4
            // 
            this.gunaLabel4.AutoSize = true;
            this.gunaLabel4.BackColor = System.Drawing.Color.Transparent;
            this.gunaLabel4.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.gunaLabel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.gunaLabel4.Location = new System.Drawing.Point(907, 5);
            this.gunaLabel4.Name = "gunaLabel4";
            this.gunaLabel4.Size = new System.Drawing.Size(68, 16);
            this.gunaLabel4.TabIndex = 24;
            this.gunaLabel4.Text = "Saida NF";
            // 
            // gunaLabel_name1
            // 
            this.gunaLabel_name1.AutoSize = true;
            this.gunaLabel_name1.BackColor = System.Drawing.Color.Transparent;
            this.gunaLabel_name1.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.gunaLabel_name1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.gunaLabel_name1.Location = new System.Drawing.Point(198, 5);
            this.gunaLabel_name1.Name = "gunaLabel_name1";
            this.gunaLabel_name1.Size = new System.Drawing.Size(84, 16);
            this.gunaLabel_name1.TabIndex = 21;
            this.gunaLabel_name1.Text = "Entrada NF";
            // 
            // TelaInicial
            // 
            this.TelaInicial.BackgroundImage = global::Controle_de_Estoque.Properties.Resources.Imagem_Inicial1;
            this.TelaInicial.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.TelaInicial.Location = new System.Drawing.Point(9, 149);
            this.TelaInicial.Name = "TelaInicial";
            this.TelaInicial.Size = new System.Drawing.Size(1180, 537);
            this.TelaInicial.TabIndex = 21;
            // 
            // btnSaidaNF
            // 
            this.btnSaidaNF.Animated = true;
            this.btnSaidaNF.AnimationHoverSpeed = 0.4F;
            this.btnSaidaNF.AnimationSpeed = 0.03F;
            this.btnSaidaNF.BackColor = System.Drawing.Color.Transparent;
            this.btnSaidaNF.BackgroundImage = global::Controle_de_Estoque.Properties.Resources.Saida_de_NF;
            this.btnSaidaNF.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSaidaNF.BaseColor = System.Drawing.Color.Transparent;
            this.btnSaidaNF.BorderColor = System.Drawing.Color.Black;
            this.btnSaidaNF.CheckedBaseColor = System.Drawing.Color.Gray;
            this.btnSaidaNF.CheckedBorderColor = System.Drawing.Color.Black;
            this.btnSaidaNF.CheckedForeColor = System.Drawing.Color.White;
            this.btnSaidaNF.CheckedImage = ((System.Drawing.Image)(resources.GetObject("btnSaidaNF.CheckedImage")));
            this.btnSaidaNF.CheckedLineColor = System.Drawing.Color.DimGray;
            this.btnSaidaNF.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnSaidaNF.FocusedColor = System.Drawing.Color.Empty;
            this.btnSaidaNF.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaidaNF.ForeColor = System.Drawing.Color.White;
            this.btnSaidaNF.Image = null;
            this.btnSaidaNF.ImageSize = new System.Drawing.Size(20, 20);
            this.btnSaidaNF.LineBottom = 4;
            this.btnSaidaNF.LineColor = System.Drawing.Color.Transparent;
            this.btnSaidaNF.Location = new System.Drawing.Point(900, 30);
            this.btnSaidaNF.Name = "btnSaidaNF";
            this.btnSaidaNF.OnHoverBaseColor = System.Drawing.Color.Transparent;
            this.btnSaidaNF.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnSaidaNF.OnHoverForeColor = System.Drawing.Color.White;
            this.btnSaidaNF.OnHoverImage = null;
            this.btnSaidaNF.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnSaidaNF.OnPressedColor = System.Drawing.Color.Black;
            this.btnSaidaNF.Size = new System.Drawing.Size(87, 80);
            this.btnSaidaNF.TabIndex = 104;
            this.btnSaidaNF.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnSaidaNF.Click += new System.EventHandler(this.SaidaNF_Click);
            // 
            // btnEntradaNF
            // 
            this.btnEntradaNF.Animated = true;
            this.btnEntradaNF.AnimationHoverSpeed = 0.4F;
            this.btnEntradaNF.AnimationSpeed = 0.03F;
            this.btnEntradaNF.BackColor = System.Drawing.Color.Transparent;
            this.btnEntradaNF.BackgroundImage = global::Controle_de_Estoque.Properties.Resources.Entrada_de_NF;
            this.btnEntradaNF.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnEntradaNF.BaseColor = System.Drawing.Color.Transparent;
            this.btnEntradaNF.BorderColor = System.Drawing.Color.Black;
            this.btnEntradaNF.CheckedBaseColor = System.Drawing.Color.Gray;
            this.btnEntradaNF.CheckedBorderColor = System.Drawing.Color.Black;
            this.btnEntradaNF.CheckedForeColor = System.Drawing.Color.White;
            this.btnEntradaNF.CheckedImage = ((System.Drawing.Image)(resources.GetObject("btnEntradaNF.CheckedImage")));
            this.btnEntradaNF.CheckedLineColor = System.Drawing.Color.DimGray;
            this.btnEntradaNF.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnEntradaNF.FocusedColor = System.Drawing.Color.Empty;
            this.btnEntradaNF.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEntradaNF.ForeColor = System.Drawing.Color.White;
            this.btnEntradaNF.Image = null;
            this.btnEntradaNF.ImageSize = new System.Drawing.Size(20, 20);
            this.btnEntradaNF.LineBottom = 4;
            this.btnEntradaNF.LineColor = System.Drawing.Color.Transparent;
            this.btnEntradaNF.Location = new System.Drawing.Point(200, 30);
            this.btnEntradaNF.Name = "btnEntradaNF";
            this.btnEntradaNF.OnHoverBaseColor = System.Drawing.Color.Transparent;
            this.btnEntradaNF.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnEntradaNF.OnHoverForeColor = System.Drawing.Color.White;
            this.btnEntradaNF.OnHoverImage = null;
            this.btnEntradaNF.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnEntradaNF.OnPressedColor = System.Drawing.Color.Black;
            this.btnEntradaNF.Size = new System.Drawing.Size(87, 80);
            this.btnEntradaNF.TabIndex = 100;
            this.btnEntradaNF.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnEntradaNF.Click += new System.EventHandler(this.EntradaNF_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Animated = true;
            this.btnBuscar.AnimationHoverSpeed = 0.4F;
            this.btnBuscar.AnimationSpeed = 0.03F;
            this.btnBuscar.BackColor = System.Drawing.Color.Transparent;
            this.btnBuscar.BackgroundImage = global::Controle_de_Estoque.Properties.Resources.pesquisa1;
            this.btnBuscar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBuscar.BaseColor = System.Drawing.Color.Transparent;
            this.btnBuscar.BorderColor = System.Drawing.Color.Black;
            this.btnBuscar.CheckedBaseColor = System.Drawing.Color.Gray;
            this.btnBuscar.CheckedBorderColor = System.Drawing.Color.Black;
            this.btnBuscar.CheckedForeColor = System.Drawing.Color.White;
            this.btnBuscar.CheckedImage = ((System.Drawing.Image)(resources.GetObject("btnBuscar.CheckedImage")));
            this.btnBuscar.CheckedLineColor = System.Drawing.Color.DimGray;
            this.btnBuscar.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnBuscar.FocusedColor = System.Drawing.Color.Empty;
            this.btnBuscar.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.ForeColor = System.Drawing.Color.White;
            this.btnBuscar.Image = null;
            this.btnBuscar.ImageSize = new System.Drawing.Size(20, 20);
            this.btnBuscar.LineBottom = 4;
            this.btnBuscar.LineColor = System.Drawing.Color.Transparent;
            this.btnBuscar.Location = new System.Drawing.Point(445, 30);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.OnHoverBaseColor = System.Drawing.Color.Transparent;
            this.btnBuscar.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnBuscar.OnHoverForeColor = System.Drawing.Color.White;
            this.btnBuscar.OnHoverImage = null;
            this.btnBuscar.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnBuscar.OnPressedColor = System.Drawing.Color.Black;
            this.btnBuscar.Size = new System.Drawing.Size(87, 80);
            this.btnBuscar.TabIndex = 101;
            this.btnBuscar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnBuscar.Click += new System.EventHandler(this.Estoque_Click);
            // 
            // btnEstoque
            // 
            this.btnEstoque.Animated = true;
            this.btnEstoque.AnimationHoverSpeed = 0.4F;
            this.btnEstoque.AnimationSpeed = 0.03F;
            this.btnEstoque.BackColor = System.Drawing.Color.Transparent;
            this.btnEstoque.BackgroundImage = global::Controle_de_Estoque.Properties.Resources.Local;
            this.btnEstoque.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnEstoque.BaseColor = System.Drawing.Color.Transparent;
            this.btnEstoque.BorderColor = System.Drawing.Color.Black;
            this.btnEstoque.CheckedBaseColor = System.Drawing.Color.Gray;
            this.btnEstoque.CheckedBorderColor = System.Drawing.Color.Black;
            this.btnEstoque.CheckedForeColor = System.Drawing.Color.White;
            this.btnEstoque.CheckedImage = ((System.Drawing.Image)(resources.GetObject("btnEstoque.CheckedImage")));
            this.btnEstoque.CheckedLineColor = System.Drawing.Color.DimGray;
            this.btnEstoque.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnEstoque.FocusedColor = System.Drawing.Color.Empty;
            this.btnEstoque.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEstoque.ForeColor = System.Drawing.Color.White;
            this.btnEstoque.Image = null;
            this.btnEstoque.ImageSize = new System.Drawing.Size(20, 20);
            this.btnEstoque.LineBottom = 4;
            this.btnEstoque.LineColor = System.Drawing.Color.Transparent;
            this.btnEstoque.Location = new System.Drawing.Point(670, 30);
            this.btnEstoque.Name = "btnEstoque";
            this.btnEstoque.OnHoverBaseColor = System.Drawing.Color.Transparent;
            this.btnEstoque.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnEstoque.OnHoverForeColor = System.Drawing.Color.White;
            this.btnEstoque.OnHoverImage = null;
            this.btnEstoque.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnEstoque.OnPressedColor = System.Drawing.Color.Black;
            this.btnEstoque.Size = new System.Drawing.Size(87, 80);
            this.btnEstoque.TabIndex = 103;
            this.btnEstoque.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnEstoque.Click += new System.EventHandler(this.Buscar_Click);
            // 
            // gunaCirclePictureBox1
            // 
            this.gunaCirclePictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.gunaCirclePictureBox1.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.gunaCirclePictureBox1.Location = new System.Drawing.Point(65, 1);
            this.gunaCirclePictureBox1.Name = "gunaCirclePictureBox1";
            this.gunaCirclePictureBox1.Size = new System.Drawing.Size(61, 55);
            this.gunaCirclePictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.gunaCirclePictureBox1.TabIndex = 5;
            this.gunaCirclePictureBox1.TabStop = false;
            this.gunaCirclePictureBox1.UseTransfarantBackground = false;
            // 
            // guna2DragControl2
            // 
            this.guna2DragControl2.TargetControl = this.gunaPanel1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.ClientSize = new System.Drawing.Size(1200, 698);
            this.Controls.Add(this.TelaInicial);
            this.Controls.Add(this.btnEstoque);
            this.Controls.Add(this.btnSaidaNF);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.btnEntradaNF);
            this.Controls.Add(this.gunaPanel2);
            this.Controls.Add(this.guna2ControlBox1);
            this.Controls.Add(this.gunaPanel1);
            this.Controls.Add(this.gunaCirclePictureBox1);
            this.Controls.Add(this.gunaPanel3);
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gunaPanel1.ResumeLayout(false);
            this.gunaPanel1.PerformLayout();
            this.gunaPanel2.ResumeLayout(false);
            this.gunaPanel2.PerformLayout();
            this.gunaPanel3.ResumeLayout(false);
            this.gunaPanel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gunaCirclePictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox1;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox3;
        private Guna.UI.WinForms.GunaPanel gunaPanel1;
        private Guna.UI.WinForms.GunaPanel gunaPanel2;
        private Guna.UI.WinForms.GunaCirclePictureBox gunaCirclePictureBox1;
        private Guna.UI2.WinForms.Guna2DragControl guna2DragControl1;
        private Guna.UI.WinForms.GunaAdvenceButton btnEstoque;
        private Guna.UI.WinForms.GunaAdvenceButton btnSaidaNF;
        private Guna.UI.WinForms.GunaAdvenceButton btnEntradaNF;
        private Guna.UI.WinForms.GunaAdvenceButton btnBuscar;
        private Guna.UI.WinForms.GunaLabel gunaLabel1;
        private Guna.UI.WinForms.GunaLabel gunaLabel2;
        private Guna.UI.WinForms.GunaPanel gunaPanel3;
        private Guna.UI.WinForms.GunaPanel TelaInicial;
        private Guna.UI.WinForms.GunaLabel gunaLabel4;
        private Guna.UI.WinForms.GunaLabel gunaLabel3;
        private Guna.UI.WinForms.GunaLabel gunaLabel5;
        private Guna.UI.WinForms.GunaLabel gunaLabel_name1;
        private Guna.UI2.WinForms.Guna2DragControl guna2DragControl2;
    }
}

