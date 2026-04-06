namespace AppCatalogo
{
    partial class MainMenuForm
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainMenuForm));
            this.CatalogoButton = new System.Windows.Forms.Button();
            this.AgregarButton = new System.Windows.Forms.Button();
            this.ModificarButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // CatalogoButton
            // 
            this.CatalogoButton.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.CatalogoButton.BackColor = System.Drawing.Color.Silver;
            this.CatalogoButton.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.CatalogoButton.FlatAppearance.BorderSize = 0;
            this.CatalogoButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CatalogoButton.Image = ((System.Drawing.Image)(resources.GetObject("CatalogoButton.Image")));
            this.CatalogoButton.Location = new System.Drawing.Point(306, 93);
            this.CatalogoButton.Name = "CatalogoButton";
            this.CatalogoButton.Size = new System.Drawing.Size(188, 66);
            this.CatalogoButton.TabIndex = 0;
            this.CatalogoButton.Text = "Catálogo";
            this.CatalogoButton.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.CatalogoButton.UseVisualStyleBackColor = false;
            this.CatalogoButton.Click += new System.EventHandler(this.CatalogoButton_Click);
            // 
            // AgregarButton
            // 
            this.AgregarButton.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.AgregarButton.BackColor = System.Drawing.Color.Silver;
            this.AgregarButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AgregarButton.Image = ((System.Drawing.Image)(resources.GetObject("AgregarButton.Image")));
            this.AgregarButton.Location = new System.Drawing.Point(306, 192);
            this.AgregarButton.Name = "AgregarButton";
            this.AgregarButton.Size = new System.Drawing.Size(188, 66);
            this.AgregarButton.TabIndex = 1;
            this.AgregarButton.Text = "Agregar";
            this.AgregarButton.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.AgregarButton.UseVisualStyleBackColor = false;
            this.AgregarButton.Click += new System.EventHandler(this.AgregarButton_Click);
            // 
            // ModificarButton
            // 
            this.ModificarButton.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.ModificarButton.BackColor = System.Drawing.Color.Silver;
            this.ModificarButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ModificarButton.Image = ((System.Drawing.Image)(resources.GetObject("ModificarButton.Image")));
            this.ModificarButton.Location = new System.Drawing.Point(306, 291);
            this.ModificarButton.Name = "ModificarButton";
            this.ModificarButton.Size = new System.Drawing.Size(188, 66);
            this.ModificarButton.TabIndex = 2;
            this.ModificarButton.Text = "Modificar";
            this.ModificarButton.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.ModificarButton.UseVisualStyleBackColor = false;
            this.ModificarButton.Click += new System.EventHandler(this.ModificarButton_Click);
            // 
            // MainMenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ModificarButton);
            this.Controls.Add(this.AgregarButton);
            this.Controls.Add(this.CatalogoButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.IsMdiContainer = true;
            this.Name = "MainMenuForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menú principal";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Button CatalogoButton;
        public System.Windows.Forms.Button AgregarButton;
        public System.Windows.Forms.Button ModificarButton;
    }
}

