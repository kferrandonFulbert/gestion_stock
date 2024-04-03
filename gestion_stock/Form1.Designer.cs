namespace gestion_stock
{
    partial class frm_accueil
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_prd = new System.Windows.Forms.Button();
            this.btn_livraison = new System.Windows.Forms.Button();
            this.btn_frs = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_prd
            // 
            this.btn_prd.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_prd.Location = new System.Drawing.Point(32, 156);
            this.btn_prd.Name = "btn_prd";
            this.btn_prd.Size = new System.Drawing.Size(184, 209);
            this.btn_prd.TabIndex = 0;
            this.btn_prd.Text = "Gestion Produits";
            this.btn_prd.UseVisualStyleBackColor = true;
            // 
            // btn_livraison
            // 
            this.btn_livraison.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_livraison.Location = new System.Drawing.Point(266, 156);
            this.btn_livraison.Name = "btn_livraison";
            this.btn_livraison.Size = new System.Drawing.Size(184, 209);
            this.btn_livraison.TabIndex = 1;
            this.btn_livraison.Text = "Livraison";
            this.btn_livraison.UseVisualStyleBackColor = true;
            // 
            // btn_frs
            // 
            this.btn_frs.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_frs.Location = new System.Drawing.Point(488, 156);
            this.btn_frs.Name = "btn_frs";
            this.btn_frs.Size = new System.Drawing.Size(251, 209);
            this.btn_frs.TabIndex = 2;
            this.btn_frs.Text = "Gestion Fournisseurs";
            this.btn_frs.UseVisualStyleBackColor = true;
            this.btn_frs.Click += new System.EventHandler(this.btn_frs_Click);
            // 
            // frm_accueil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_frs);
            this.Controls.Add(this.btn_livraison);
            this.Controls.Add(this.btn_prd);
            this.Name = "frm_accueil";
            this.Text = "Accueil";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_prd;
        private System.Windows.Forms.Button btn_livraison;
        private System.Windows.Forms.Button btn_frs;
    }
}

