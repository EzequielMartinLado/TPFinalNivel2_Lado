namespace AppCatalogo
{
    partial class CatalogoForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CatalogoForm));
            this.VolverAMenuButton = new System.Windows.Forms.Button();
            this.CatalogoDataGridView = new System.Windows.Forms.DataGridView();
            this.FiltrarButton = new System.Windows.Forms.Button();
            this.CategoriaFiltroComboBox = new System.Windows.Forms.ComboBox();
            this.MarcaFiltroComboBox = new System.Windows.Forms.ComboBox();
            this.CategoriaFiltroLabel = new System.Windows.Forms.Label();
            this.MarcaFiltroLabel = new System.Windows.Forms.Label();
            this.FiltroLabel = new System.Windows.Forms.Label();
            this.BuscarLabel = new System.Windows.Forms.Label();
            this.FiltroTextBox = new System.Windows.Forms.TextBox();
            this.CatalogoPictureBox = new System.Windows.Forms.PictureBox();
            this.AdvertenciaLabel = new System.Windows.Forms.Label();
            this.LimpiarButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.CatalogoDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CatalogoPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // VolverAMenuButton
            // 
            this.VolverAMenuButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.VolverAMenuButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.VolverAMenuButton.Location = new System.Drawing.Point(997, 618);
            this.VolverAMenuButton.Name = "VolverAMenuButton";
            this.VolverAMenuButton.Size = new System.Drawing.Size(75, 23);
            this.VolverAMenuButton.TabIndex = 0;
            this.VolverAMenuButton.Text = "Menú";
            this.VolverAMenuButton.UseVisualStyleBackColor = true;
            this.VolverAMenuButton.Click += new System.EventHandler(this.VolverAMenuButton_Click);
            // 
            // CatalogoDataGridView
            // 
            this.CatalogoDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.CatalogoDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.CatalogoDataGridView.Location = new System.Drawing.Point(28, 161);
            this.CatalogoDataGridView.Name = "CatalogoDataGridView";
            this.CatalogoDataGridView.Size = new System.Drawing.Size(683, 310);
            this.CatalogoDataGridView.TabIndex = 1;
            this.CatalogoDataGridView.SelectionChanged += new System.EventHandler(this.CatalogoDataGridView_SelectionChanged);
            // 
            // FiltrarButton
            // 
            this.FiltrarButton.Location = new System.Drawing.Point(386, 104);
            this.FiltrarButton.Name = "FiltrarButton";
            this.FiltrarButton.Size = new System.Drawing.Size(75, 23);
            this.FiltrarButton.TabIndex = 3;
            this.FiltrarButton.Text = "Filtrar";
            this.FiltrarButton.UseVisualStyleBackColor = true;
            this.FiltrarButton.Click += new System.EventHandler(this.FiltrarButton_Click);
            // 
            // CategoriaFiltroComboBox
            // 
            this.CategoriaFiltroComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CategoriaFiltroComboBox.FormattingEnabled = true;
            this.CategoriaFiltroComboBox.Location = new System.Drawing.Point(85, 104);
            this.CategoriaFiltroComboBox.Name = "CategoriaFiltroComboBox";
            this.CategoriaFiltroComboBox.Size = new System.Drawing.Size(121, 21);
            this.CategoriaFiltroComboBox.TabIndex = 1;
            // 
            // MarcaFiltroComboBox
            // 
            this.MarcaFiltroComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.MarcaFiltroComboBox.FormattingEnabled = true;
            this.MarcaFiltroComboBox.Location = new System.Drawing.Point(255, 104);
            this.MarcaFiltroComboBox.Name = "MarcaFiltroComboBox";
            this.MarcaFiltroComboBox.Size = new System.Drawing.Size(121, 21);
            this.MarcaFiltroComboBox.TabIndex = 2;
            // 
            // CategoriaFiltroLabel
            // 
            this.CategoriaFiltroLabel.AutoSize = true;
            this.CategoriaFiltroLabel.Location = new System.Drawing.Point(25, 112);
            this.CategoriaFiltroLabel.Name = "CategoriaFiltroLabel";
            this.CategoriaFiltroLabel.Size = new System.Drawing.Size(54, 13);
            this.CategoriaFiltroLabel.TabIndex = 5;
            this.CategoriaFiltroLabel.Text = "Categoría";
            // 
            // MarcaFiltroLabel
            // 
            this.MarcaFiltroLabel.AutoSize = true;
            this.MarcaFiltroLabel.Location = new System.Drawing.Point(212, 112);
            this.MarcaFiltroLabel.Name = "MarcaFiltroLabel";
            this.MarcaFiltroLabel.Size = new System.Drawing.Size(37, 13);
            this.MarcaFiltroLabel.TabIndex = 6;
            this.MarcaFiltroLabel.Text = "Marca";
            // 
            // FiltroLabel
            // 
            this.FiltroLabel.AutoSize = true;
            this.FiltroLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FiltroLabel.Location = new System.Drawing.Point(25, 69);
            this.FiltroLabel.Name = "FiltroLabel";
            this.FiltroLabel.Size = new System.Drawing.Size(180, 24);
            this.FiltroLabel.TabIndex = 7;
            this.FiltroLabel.Text = "Búsqueda con filtros";
            // 
            // BuscarLabel
            // 
            this.BuscarLabel.AutoSize = true;
            this.BuscarLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BuscarLabel.Location = new System.Drawing.Point(26, 9);
            this.BuscarLabel.Name = "BuscarLabel";
            this.BuscarLabel.Size = new System.Drawing.Size(96, 24);
            this.BuscarLabel.TabIndex = 8;
            this.BuscarLabel.Text = "Búsqueda";
            // 
            // FiltroTextBox
            // 
            this.FiltroTextBox.Location = new System.Drawing.Point(30, 42);
            this.FiltroTextBox.Name = "FiltroTextBox";
            this.FiltroTextBox.Size = new System.Drawing.Size(147, 20);
            this.FiltroTextBox.TabIndex = 0;
            // 
            // CatalogoPictureBox
            // 
            this.CatalogoPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("CatalogoPictureBox.Image")));
            this.CatalogoPictureBox.Location = new System.Drawing.Point(738, 161);
            this.CatalogoPictureBox.Name = "CatalogoPictureBox";
            this.CatalogoPictureBox.Size = new System.Drawing.Size(313, 310);
            this.CatalogoPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.CatalogoPictureBox.TabIndex = 10;
            this.CatalogoPictureBox.TabStop = false;
            // 
            // AdvertenciaLabel
            // 
            this.AdvertenciaLabel.AutoSize = true;
            this.AdvertenciaLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AdvertenciaLabel.ForeColor = System.Drawing.Color.Red;
            this.AdvertenciaLabel.Location = new System.Drawing.Point(480, 108);
            this.AdvertenciaLabel.Name = "AdvertenciaLabel";
            this.AdvertenciaLabel.Size = new System.Drawing.Size(0, 17);
            this.AdvertenciaLabel.TabIndex = 11;
            // 
            // LimpiarButton
            // 
            this.LimpiarButton.Location = new System.Drawing.Point(386, 132);
            this.LimpiarButton.Name = "LimpiarButton";
            this.LimpiarButton.Size = new System.Drawing.Size(75, 23);
            this.LimpiarButton.TabIndex = 4;
            this.LimpiarButton.Text = "Limpiar";
            this.LimpiarButton.UseVisualStyleBackColor = true;
            this.LimpiarButton.Click += new System.EventHandler(this.LimpiarButton_Click);
            // 
            // CatalogoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.VolverAMenuButton;
            this.ClientSize = new System.Drawing.Size(1084, 653);
            this.Controls.Add(this.LimpiarButton);
            this.Controls.Add(this.AdvertenciaLabel);
            this.Controls.Add(this.CatalogoPictureBox);
            this.Controls.Add(this.FiltroTextBox);
            this.Controls.Add(this.BuscarLabel);
            this.Controls.Add(this.FiltroLabel);
            this.Controls.Add(this.MarcaFiltroLabel);
            this.Controls.Add(this.CategoriaFiltroLabel);
            this.Controls.Add(this.MarcaFiltroComboBox);
            this.Controls.Add(this.CategoriaFiltroComboBox);
            this.Controls.Add(this.FiltrarButton);
            this.Controls.Add(this.CatalogoDataGridView);
            this.Controls.Add(this.VolverAMenuButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CatalogoForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Catálogo";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.CatalogoForms_FormClosed);
            this.Load += new System.EventHandler(this.CatalogoForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.CatalogoDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CatalogoPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button VolverAMenuButton;
        private System.Windows.Forms.DataGridView CatalogoDataGridView;
        private System.Windows.Forms.Button FiltrarButton;
        private System.Windows.Forms.ComboBox CategoriaFiltroComboBox;
        private System.Windows.Forms.ComboBox MarcaFiltroComboBox;
        private System.Windows.Forms.Label CategoriaFiltroLabel;
        private System.Windows.Forms.Label MarcaFiltroLabel;
        private System.Windows.Forms.Label FiltroLabel;
        private System.Windows.Forms.Label BuscarLabel;
        private System.Windows.Forms.TextBox FiltroTextBox;
        private System.Windows.Forms.PictureBox CatalogoPictureBox;
        private System.Windows.Forms.Label AdvertenciaLabel;
        private System.Windows.Forms.Button LimpiarButton;
    }
}