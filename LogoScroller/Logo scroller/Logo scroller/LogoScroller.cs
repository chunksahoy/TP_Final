﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;
using System.IO;

// ----- To DO ------------------------------------------------------------//
// ----- BitmapUtilities --------------------------------------------------//
// ----- Attributs --------------------------------------------------------//
// ----- To DO ------------------------------------------------------------//


namespace Logo_scroller
{
    public partial class LogoScroller: UserControl
    {
        #region "Attributs privés"
        // Index du FLPN_Container
        private int Index;
        // Liste d'élements contenu dans le PN_Container
        private List<FlashButton.FlashButton> ListeElements = new List<FlashButton.FlashButton>();
        // Elements size est le size des flash buttons
        private Size Elements_Size = new Size(50, 50);

        #endregion
        #region "Attributs publics"

        // Nombre d'élements (Flash Buttons)
        private int _NbElements = 5;
        // Liste de noms qui correspond au nom des images
        public List<string> ListeNomElements = new List<string>();

        #endregion

        
        [Description("Nombre d'éléments."),Category("Data")]
        public int NbElements
        {
            get { return _NbElements; }
            set { if (value <= 15 && value > 0) { _NbElements = value; } }
        }

        public LogoScroller()
        {
            InitializeComponent();
        }
        private void LogoScroller_Load(object sender, EventArgs e)
        {
            Index = 0;
            BF_Gauche.Enabled = false;
            if (ListeElements.Count() <= NbElements)
            {
                BF_Droit.Enabled = false;
            }
        }

        public void AddElement(string FilePath, string ImageName)
        {
            if(FilePath != "")
                AddElement(ConvertFilePathToImage(FilePath), ImageName);
        }
        private Image ConvertFilePathToImage(string FilePath)
        {
            FileStream Streamp = new FileStream(FilePath, FileMode.Open, FileAccess.Read);
            byte[] buffer1 = new byte[Streamp.Length];
            Streamp.Read(buffer1, 0, System.Convert.ToInt32(Streamp.Length));
            Image unLogo = Image.FromStream(Streamp);

            return unLogo;
        }
        public void AddElement(Image image, string ImageName)
        {
            FlashButton.FlashButton fb = new FlashButton.FlashButton();

            // Changement des paramêtres de l'image pour qu'il soit conforme au contrôle
            fb.ImageNeutral = image;
            fb.ImageOver = MakeOverImage(image);
            fb.ImageClick = MakeClickImage(image);
            fb.Size = Elements_Size;

            // Ajout de l'élement de la liste et resize de la marge dans le Flow layout panel
            ListeElements.Add(fb);
            ListeNomElements.Add(ImageName);
            UpdateControls();
        }

        public void RemoveElement(string NomElement)
        {
            if(ListeNomElements.Contains(NomElement))
            {
                bool aTrouve = false;
                int index = 0;
                for(int i = 0; i < ListeNomElements.Count && !aTrouve; ++i)
                {
                    if(NomElement == ListeNomElements[i])
                    {
                        aTrouve = true;
                        index = i;
                    }
                }
                ListeElements.RemoveAt(index);
                ListeNomElements.RemoveAt(index);
                if(Index > 0)
                    Index--;
            }
            else
            {
                MessageBox.Show("Erreur! Le logo scroller ne contient pas d'élément comportant le nom: " + NomElement + ".");
            }
            UpdateControls();
        }

        public void EditElement(string NomElement, string FilePath)
        {
            if(ListeNomElements.Contains(NomElement))
            {
                bool aTrouve = false;
                int index = 0;
                for(int i = 0; i < ListeNomElements.Count && !aTrouve; ++i)
                {
                    if(ListeNomElements[i] == NomElement)
                    {
                        aTrouve = true;
                        index = i;
                    }
                }
                if(FilePath != "")
                { 
                    Image image = ConvertFilePathToImage(FilePath);
                    ListeElements[index].ImageNeutral = image;
                    ListeElements[index].BackgroundImage = image;
                    ListeElements[index].ImageClick = MakeClickImage(image);
                    ListeElements[index].ImageOver = MakeOverImage(image);
                }
            }
            else 
            {
                MessageBox.Show("Erreur! Le logo scroller ne contient aucun élément portant le nom" + NomElement + ".");
            }
            UpdateControls();
        }

        #region "Modification sur les images"

        private Image MakeOverImage(Image image)
        {
            return ChangeBrightness(25, image);
        }
        private Image MakeClickImage(Image image)
        {
            return ChangeBrightness(75, image);
        }

        private Image ChangeBrightness(int value, Image image)
        {
            if (image != null)
            {
                Bitmap CopyImage = (Bitmap)image.Clone();

                // Change le brightness de toutes les pixels de l'image
                for (int i = 0; i < CopyImage.Width; ++i)
                {
                    for (int x = 0; x < CopyImage.Height; ++x)
                    {
                        Color pixel = CopyImage.GetPixel(i, x);
                        CopyImage.SetPixel(i,x,Color.FromArgb(pixel.A,
                                                              Valide(pixel.R + value),
                                                              Valide(pixel.G + value),
                                                              Valide(pixel.B + value)));
                    }
                }
                return CopyImage;
            }

            return image;
        }

        private int Valide(int p)
        {
            if (p < 0)
                p = 0;
            if (p > 255)
                p = 255;

            return p;
        }
        #endregion
        #region "Boutons Flèches"
        private void BF_Droit_MouseClick(object sender, MouseEventArgs e)
        {
            if (Index + NbElements < ListeElements.Count)
            {
                Index++;
            }

            UpdateControls();
        }

        private void BF_Gauche_MouseClick(object sender, MouseEventArgs e)
        {
            if (Index > 0)
            {
                Index--;
            }

            UpdateControls();
        }
        #endregion
        #region "Méthodes lié rafréchissement du LogoScroller"

        // Redimensionner redimensionne l'espace entre les éléments du Flow layout panel
        private void Redimensionner()
        {
            int MyMargin = 0;
            if (NbElements > ListeElements.Count && ListeElements.Count > 0)
                MyMargin = (FLPN_Container.Size.Width / ListeElements.Count) - Elements_Size.Width;
            else
                MyMargin = (FLPN_Container.Size.Width / NbElements) - Elements_Size.Width;
            for (int i = 0; i < FLPN_Container.Controls.Count; ++i)
            {
                FLPN_Container.Controls[i].Margin = new Padding(MyMargin/2, 0, MyMargin/2, 0);
            }
            FLPN_Container.Padding = new Padding(0, (FLPN_Container.Height - Elements_Size.Height) / 4, 0, (FLPN_Container.Height - Elements_Size.Height) / 4);
        }

        private void FLPN_Container_SizeChanged(object sender, EventArgs e)
        {
            Redimensionner();
        }

        public void UpdateControls()
        {
            FLPN_Container.Controls.Clear();

            for (int i = 0; i < NbElements; ++i)
            {
                if (ListeElements.Count() > (Index + i))
                {
                    FLPN_Container.Controls.Add(ListeElements[Index + i]);
                }
            }

            if (Index + NbElements < ListeElements.Count())
                BF_Droit.Enabled = true;
            else
                BF_Droit.Enabled = false;
            if (Index == 0)
                BF_Gauche.Enabled = false;
            else
                BF_Gauche.Enabled = true;

            if (!BF_Droit.Enabled)
                BF_Droit.Visible = false;
            else
                BF_Droit.Visible = true;
            if (!BF_Gauche.Enabled)
                BF_Gauche.Visible = false;
            else
                BF_Gauche.Visible = true;

            Redimensionner();

        }

        #endregion



        private void BF_Droit_EnabledChanged(object sender, EventArgs e)
        {
            int i = 0;
        }

    }

}
