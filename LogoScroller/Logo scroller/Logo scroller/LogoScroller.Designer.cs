namespace Logo_scroller
{
    partial class LogoScroller
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

        #region Component Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.BF_Gauche = new BoutonFlèche.BoutonFlèche();
            this.BF_Droit = new BoutonFlèche.BoutonFlèche();
            this.FLPN_Container = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // BF_Gauche
            // 
            this.BF_Gauche.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.BF_Gauche.Apparence = BoutonFlèche.BoutonFlèche.ApparenceType.Normal;
            this.BF_Gauche.ClickColor = System.Drawing.Color.White;
            this.BF_Gauche.Direction = BoutonFlèche.BoutonFlèche.DirectionType.Gauche;
            this.BF_Gauche.EnterColor = System.Drawing.Color.LightGray;
            this.BF_Gauche.LeaveColor = System.Drawing.Color.Black;
            this.BF_Gauche.Location = new System.Drawing.Point(0, 16);
            this.BF_Gauche.Name = "BF_Gauche";
            this.BF_Gauche.Size = new System.Drawing.Size(43, 36);
            this.BF_Gauche.TabIndex = 0;
            this.BF_Gauche.MouseClick += new System.Windows.Forms.MouseEventHandler(this.BF_Gauche_MouseClick);
            // 
            // BF_Droit
            // 
            this.BF_Droit.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BF_Droit.Apparence = BoutonFlèche.BoutonFlèche.ApparenceType.Normal;
            this.BF_Droit.ClickColor = System.Drawing.Color.White;
            this.BF_Droit.Direction = BoutonFlèche.BoutonFlèche.DirectionType.Droit;
            this.BF_Droit.EnterColor = System.Drawing.Color.LightGray;
            this.BF_Droit.LeaveColor = System.Drawing.Color.Black;
            this.BF_Droit.Location = new System.Drawing.Point(851, 16);
            this.BF_Droit.Name = "BF_Droit";
            this.BF_Droit.Size = new System.Drawing.Size(43, 36);
            this.BF_Droit.TabIndex = 1;
            this.BF_Droit.EnabledChanged += new System.EventHandler(this.BF_Droit_EnabledChanged);
            this.BF_Droit.MouseClick += new System.Windows.Forms.MouseEventHandler(this.BF_Droit_MouseClick);
            // 
            // FLPN_Container
            // 
            this.FLPN_Container.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.FLPN_Container.Location = new System.Drawing.Point(46, 0);
            this.FLPN_Container.Name = "FLPN_Container";
            this.FLPN_Container.Size = new System.Drawing.Size(801, 67);
            this.FLPN_Container.TabIndex = 2;
            this.FLPN_Container.SizeChanged += new System.EventHandler(this.FLPN_Container_SizeChanged);
            // 
            // LogoScroller
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.FLPN_Container);
            this.Controls.Add(this.BF_Droit);
            this.Controls.Add(this.BF_Gauche);
            this.Name = "LogoScroller";
            this.Size = new System.Drawing.Size(894, 68);
            this.Load += new System.EventHandler(this.LogoScroller_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private BoutonFlèche.BoutonFlèche BF_Gauche;
        private BoutonFlèche.BoutonFlèche BF_Droit;
        private System.Windows.Forms.FlowLayoutPanel FLPN_Container;
        //private Oracle.DataAccess.Client.OracleConnection oracleConnection1;
    }
}
