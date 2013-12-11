namespace TeamScroller
{
    partial class Scroller
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

        #region Code généré par le Concepteur de composants

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas 
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.BTN_Begin = new BoutonFlèche.BoutonFlèche();
            this.BTN_Previous = new BoutonFlèche.BoutonFlèche();
            this.BTN_End = new BoutonFlèche.BoutonFlèche();
            this.BTN_Next = new BoutonFlèche.BoutonFlèche();
            this.SuspendLayout();
            // 
            // BTN_Begin
            // 
            this.BTN_Begin.Apparence = BoutonFlèche.BoutonFlèche.ApparenceType.Aigu;
            this.BTN_Begin.ClickColor = System.Drawing.Color.White;
            this.BTN_Begin.Direction = BoutonFlèche.BoutonFlèche.DirectionType.Gauche;
            this.BTN_Begin.EnterColor = System.Drawing.Color.LightGray;
            this.BTN_Begin.LeaveColor = System.Drawing.Color.Black;
            this.BTN_Begin.Location = new System.Drawing.Point(2, 0);
            this.BTN_Begin.Name = "BTN_Begin";
            this.BTN_Begin.Size = new System.Drawing.Size(43, 30);
            this.BTN_Begin.TabIndex = 0;
            this.BTN_Begin.Click += new System.EventHandler(this.BTN_Begin_Click);
            // 
            // BTN_Previous
            // 
            this.BTN_Previous.Apparence = BoutonFlèche.BoutonFlèche.ApparenceType.Triangle;
            this.BTN_Previous.ClickColor = System.Drawing.Color.White;
            this.BTN_Previous.Direction = BoutonFlèche.BoutonFlèche.DirectionType.Gauche;
            this.BTN_Previous.EnterColor = System.Drawing.Color.LightGray;
            this.BTN_Previous.LeaveColor = System.Drawing.Color.Black;
            this.BTN_Previous.Location = new System.Drawing.Point(51, 0);
            this.BTN_Previous.Name = "BTN_Previous";
            this.BTN_Previous.Size = new System.Drawing.Size(43, 30);
            this.BTN_Previous.TabIndex = 0;
            this.BTN_Previous.Click += new System.EventHandler(this.BTN_Previous_Click);
            // 
            // BTN_End
            // 
            this.BTN_End.Apparence = BoutonFlèche.BoutonFlèche.ApparenceType.Aigu;
            this.BTN_End.ClickColor = System.Drawing.Color.White;
            this.BTN_End.Direction = BoutonFlèche.BoutonFlèche.DirectionType.Droit;
            this.BTN_End.EnterColor = System.Drawing.Color.LightGray;
            this.BTN_End.LeaveColor = System.Drawing.Color.Black;
            this.BTN_End.Location = new System.Drawing.Point(149, 0);
            this.BTN_End.Name = "BTN_End";
            this.BTN_End.Size = new System.Drawing.Size(43, 30);
            this.BTN_End.TabIndex = 0;
            this.BTN_End.Click += new System.EventHandler(this.BTN_End_Click);
            // 
            // BTN_Next
            // 
            this.BTN_Next.Apparence = BoutonFlèche.BoutonFlèche.ApparenceType.Triangle;
            this.BTN_Next.ClickColor = System.Drawing.Color.White;
            this.BTN_Next.Direction = BoutonFlèche.BoutonFlèche.DirectionType.Droit;
            this.BTN_Next.EnterColor = System.Drawing.Color.LightGray;
            this.BTN_Next.LeaveColor = System.Drawing.Color.Black;
            this.BTN_Next.Location = new System.Drawing.Point(100, 0);
            this.BTN_Next.Name = "BTN_Next";
            this.BTN_Next.Size = new System.Drawing.Size(43, 30);
            this.BTN_Next.TabIndex = 0;
            this.BTN_Next.Click += new System.EventHandler(this.BTN_Next_Click);
            // 
            // Scroller
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.BTN_End);
            this.Controls.Add(this.BTN_Next);
            this.Controls.Add(this.BTN_Previous);
            this.Controls.Add(this.BTN_Begin);
            this.Name = "Scroller";
            this.Size = new System.Drawing.Size(196, 37);
            this.ResumeLayout(false);

        }

        #endregion

        private BoutonFlèche.BoutonFlèche BTN_Begin;
        private BoutonFlèche.BoutonFlèche BTN_Previous;
        private BoutonFlèche.BoutonFlèche BTN_End;
        private BoutonFlèche.BoutonFlèche BTN_Next;
    }
}
