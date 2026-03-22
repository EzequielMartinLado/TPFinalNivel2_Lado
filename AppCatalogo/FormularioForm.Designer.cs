namespace AppCatalogo
{
    partial class FormularioForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormularioForm));
            this.VolverAMenuButton = new System.Windows.Forms.Button();
            this.CodigoLabel = new System.Windows.Forms.Label();
            this.NombreLabel = new System.Windows.Forms.Label();
            this.DescripcionLabel = new System.Windows.Forms.Label();
            this.MarcaLabel = new System.Windows.Forms.Label();
            this.CategoriaLabel = new System.Windows.Forms.Label();
            this.ImagenLabel = new System.Windows.Forms.Label();
            this.PrecioLabel = new System.Windows.Forms.Label();
            this.MarcaComboBox = new System.Windows.Forms.ComboBox();
            this.CategoriaComboBox = new System.Windows.Forms.ComboBox();
            this.CodigoTextBox = new System.Windows.Forms.TextBox();
            this.NombreTextBox = new System.Windows.Forms.TextBox();
            this.DescripcionTextBox = new System.Windows.Forms.TextBox();
            this.ImagenTextBox = new System.Windows.Forms.TextBox();
            this.PrecioTextBox = new System.Windows.Forms.TextBox();
            this.ImagenPictureBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.ImagenPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // VolverAMenuButton
            // 
            this.VolverAMenuButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.VolverAMenuButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.VolverAMenuButton.Location = new System.Drawing.Point(713, 415);
            this.VolverAMenuButton.Name = "VolverAMenuButton";
            this.VolverAMenuButton.Size = new System.Drawing.Size(75, 23);
            this.VolverAMenuButton.TabIndex = 1;
            this.VolverAMenuButton.Text = "Menú";
            this.VolverAMenuButton.UseVisualStyleBackColor = true;
            this.VolverAMenuButton.Click += new System.EventHandler(this.VolverAMenuButton_Click);
            // 
            // CodigoLabel
            // 
            this.CodigoLabel.AutoSize = true;
            this.CodigoLabel.Location = new System.Drawing.Point(64, 68);
            this.CodigoLabel.Name = "CodigoLabel";
            this.CodigoLabel.Size = new System.Drawing.Size(40, 13);
            this.CodigoLabel.TabIndex = 2;
            this.CodigoLabel.Text = "Código";
            // 
            // NombreLabel
            // 
            this.NombreLabel.AutoSize = true;
            this.NombreLabel.Location = new System.Drawing.Point(64, 100);
            this.NombreLabel.Name = "NombreLabel";
            this.NombreLabel.Size = new System.Drawing.Size(44, 13);
            this.NombreLabel.TabIndex = 3;
            this.NombreLabel.Text = "Nombre";
            // 
            // DescripcionLabel
            // 
            this.DescripcionLabel.AutoSize = true;
            this.DescripcionLabel.Location = new System.Drawing.Point(64, 132);
            this.DescripcionLabel.Name = "DescripcionLabel";
            this.DescripcionLabel.Size = new System.Drawing.Size(63, 13);
            this.DescripcionLabel.TabIndex = 4;
            this.DescripcionLabel.Text = "Descripción";
            // 
            // MarcaLabel
            // 
            this.MarcaLabel.AutoSize = true;
            this.MarcaLabel.Location = new System.Drawing.Point(64, 164);
            this.MarcaLabel.Name = "MarcaLabel";
            this.MarcaLabel.Size = new System.Drawing.Size(37, 13);
            this.MarcaLabel.TabIndex = 5;
            this.MarcaLabel.Text = "Marca";
            // 
            // CategoriaLabel
            // 
            this.CategoriaLabel.AutoSize = true;
            this.CategoriaLabel.Location = new System.Drawing.Point(64, 196);
            this.CategoriaLabel.Name = "CategoriaLabel";
            this.CategoriaLabel.Size = new System.Drawing.Size(54, 13);
            this.CategoriaLabel.TabIndex = 6;
            this.CategoriaLabel.Text = "Categoría";
            // 
            // ImagenLabel
            // 
            this.ImagenLabel.AutoSize = true;
            this.ImagenLabel.Location = new System.Drawing.Point(64, 228);
            this.ImagenLabel.Name = "ImagenLabel";
            this.ImagenLabel.Size = new System.Drawing.Size(42, 13);
            this.ImagenLabel.TabIndex = 7;
            this.ImagenLabel.Text = "Imagen";
            // 
            // PrecioLabel
            // 
            this.PrecioLabel.AutoSize = true;
            this.PrecioLabel.Location = new System.Drawing.Point(64, 260);
            this.PrecioLabel.Name = "PrecioLabel";
            this.PrecioLabel.Size = new System.Drawing.Size(37, 13);
            this.PrecioLabel.TabIndex = 8;
            this.PrecioLabel.Text = "Precio";
            // 
            // MarcaComboBox
            // 
            this.MarcaComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.MarcaComboBox.FormattingEnabled = true;
            this.MarcaComboBox.Location = new System.Drawing.Point(161, 162);
            this.MarcaComboBox.Name = "MarcaComboBox";
            this.MarcaComboBox.Size = new System.Drawing.Size(134, 21);
            this.MarcaComboBox.TabIndex = 9;
            // 
            // CategoriaComboBox
            // 
            this.CategoriaComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CategoriaComboBox.FormattingEnabled = true;
            this.CategoriaComboBox.Location = new System.Drawing.Point(161, 194);
            this.CategoriaComboBox.Name = "CategoriaComboBox";
            this.CategoriaComboBox.Size = new System.Drawing.Size(134, 21);
            this.CategoriaComboBox.TabIndex = 10;
            // 
            // CodigoTextBox
            // 
            this.CodigoTextBox.Location = new System.Drawing.Point(161, 69);
            this.CodigoTextBox.Name = "CodigoTextBox";
            this.CodigoTextBox.Size = new System.Drawing.Size(134, 20);
            this.CodigoTextBox.TabIndex = 11;
            // 
            // NombreTextBox
            // 
            this.NombreTextBox.Location = new System.Drawing.Point(161, 100);
            this.NombreTextBox.Name = "NombreTextBox";
            this.NombreTextBox.Size = new System.Drawing.Size(134, 20);
            this.NombreTextBox.TabIndex = 12;
            // 
            // DescripcionTextBox
            // 
            this.DescripcionTextBox.Location = new System.Drawing.Point(161, 131);
            this.DescripcionTextBox.Name = "DescripcionTextBox";
            this.DescripcionTextBox.Size = new System.Drawing.Size(134, 20);
            this.DescripcionTextBox.TabIndex = 13;
            // 
            // ImagenTextBox
            // 
            this.ImagenTextBox.Location = new System.Drawing.Point(161, 226);
            this.ImagenTextBox.Name = "ImagenTextBox";
            this.ImagenTextBox.Size = new System.Drawing.Size(134, 20);
            this.ImagenTextBox.TabIndex = 14;
            // 
            // PrecioTextBox
            // 
            this.PrecioTextBox.Location = new System.Drawing.Point(161, 257);
            this.PrecioTextBox.Name = "PrecioTextBox";
            this.PrecioTextBox.Size = new System.Drawing.Size(134, 20);
            this.PrecioTextBox.TabIndex = 15;
            // 
            // ImagenPictureBox
            // 
            this.ImagenPictureBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ImagenPictureBox.ErrorImage = ((System.Drawing.Image)(resources.GetObject("ImagenPictureBox.ErrorImage")));
            this.ImagenPictureBox.Location = new System.Drawing.Point(495, 53);
            this.ImagenPictureBox.Name = "ImagenPictureBox";
            this.ImagenPictureBox.Size = new System.Drawing.Size(224, 224);
            this.ImagenPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ImagenPictureBox.TabIndex = 16;
            this.ImagenPictureBox.TabStop = false;
            // 
            // FormularioForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.VolverAMenuButton;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ImagenPictureBox);
            this.Controls.Add(this.PrecioTextBox);
            this.Controls.Add(this.ImagenTextBox);
            this.Controls.Add(this.DescripcionTextBox);
            this.Controls.Add(this.NombreTextBox);
            this.Controls.Add(this.CodigoTextBox);
            this.Controls.Add(this.CategoriaComboBox);
            this.Controls.Add(this.MarcaComboBox);
            this.Controls.Add(this.PrecioLabel);
            this.Controls.Add(this.ImagenLabel);
            this.Controls.Add(this.CategoriaLabel);
            this.Controls.Add(this.MarcaLabel);
            this.Controls.Add(this.DescripcionLabel);
            this.Controls.Add(this.NombreLabel);
            this.Controls.Add(this.CodigoLabel);
            this.Controls.Add(this.VolverAMenuButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormularioForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Formulario";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormularioForm_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.ImagenPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button VolverAMenuButton;
        private System.Windows.Forms.Label CodigoLabel;
        private System.Windows.Forms.Label NombreLabel;
        private System.Windows.Forms.Label DescripcionLabel;
        private System.Windows.Forms.Label MarcaLabel;
        private System.Windows.Forms.Label CategoriaLabel;
        private System.Windows.Forms.Label ImagenLabel;
        private System.Windows.Forms.Label PrecioLabel;
        private System.Windows.Forms.ComboBox MarcaComboBox;
        private System.Windows.Forms.ComboBox CategoriaComboBox;
        private System.Windows.Forms.TextBox CodigoTextBox;
        private System.Windows.Forms.TextBox NombreTextBox;
        private System.Windows.Forms.TextBox DescripcionTextBox;
        private System.Windows.Forms.TextBox ImagenTextBox;
        private System.Windows.Forms.TextBox PrecioTextBox;
        private System.Windows.Forms.PictureBox ImagenPictureBox;
    }
}