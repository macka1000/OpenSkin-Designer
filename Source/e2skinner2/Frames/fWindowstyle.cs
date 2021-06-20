using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
//using System.Linq;
using System.Text;
using System.Windows.Forms;
using OpenSkinDesigner.Logic;
using OpenSkinDesigner.Structures;

namespace OpenSkinDesigner.Frames
{
    public partial class fWindowstyle : Form
    {
        private cXMLHandler pXmlHandler = null;
        private cDesigner pDesigner = null;


        public fWindowstyle()
        {
            InitializeComponent();
            SetLanguage();
            pDesigner = new cDesigner(pictureBoxPreview.CreateGraphics());
        }

        private void SetLanguage()
        {
            this.Text = fMain.GetTranslation("Window-Style settings");
            labelStyle.Text = fMain.GetTranslation("Style");
            labelPreview.Text = fMain.GetTranslation("Style");
            tabControl1.TabPages[0].Text = fMain.GetTranslation("Table");
            tabControl1.TabPages[1].Text = fMain.GetTranslation("View");
        }
        public void setup(cXMLHandler xmlhandler)
        {
            pXmlHandler = xmlhandler;
            
            refresh();
        }

        private void refresh()
        {
            sWindowStyle style = (sWindowStyle)cDataBase.pWindowstyles.get();
            foreach (sWindowStyle.sBorderSet borderset in style.pBorderSets.Values)
            {
                comboBoxStyles.Items.Add(borderset.pName);
            }
            if (comboBoxStyles.Items.Count>0)
                comboBoxStyles.SelectedIndex = 0;

            //refreshStyle();
        }

        private void refreshStyle()
        {
            sWindowStyle style = (sWindowStyle)cDataBase.pWindowstyles.get();
            sWindowStyle.sBorderSet borderset = (sWindowStyle.sBorderSet)style.pBorderSets[comboBoxStyles.SelectedItem.ToString()];

            propertyGridTable.SelectedObject = borderset;
            // MOD: fixed Unhandled Exception when a file(borderset) not found...
            // MOD: Clear Textboxes and Pictureboxes
            if (borderset.pbpTopLeftName.Length > 0 && System.IO.File.Exists(cDataBase.getPath(borderset.pbpTopLeftName)))
            {
                if (Path.GetExtension(cDataBase.getPath(borderset.pbpTopLeftName)).ToLower() == ".svg")
                {
                    string PNGPath = cDataBase.getPNGPath(cDataBase.getPath(borderset.pbpTopLeftName));
                    if (File.Exists(PNGPath))
                    {
                        textBoxTopLeft.Text = borderset.pbpTopLeftName.ToLower().Replace(".svg",".png");
                        pictureBoxTopLeft.Image = Image.FromFile(PNGPath);
                    }
                }
                else
                {
                    textBoxTopLeft.Text = borderset.pbpTopLeftName;
                    pictureBoxTopLeft.Image = Image.FromFile(cDataBase.getPath(borderset.pbpTopLeftName));
                }
                    
            }
            else
            {
                textBoxTopLeft.Text = string.Empty;
                pictureBoxTopLeft.Image = null;
            }
            if (borderset.pbpTopName.Length > 0 && System.IO.File.Exists(cDataBase.getPath(borderset.pbpTopName)))
            {
                if (Path.GetExtension(cDataBase.getPath(borderset.pbpTopName)).ToLower() == ".svg")
                {
                    string PNGPath = cDataBase.getPNGPath(cDataBase.getPath(borderset.pbpTopName));
                    if (File.Exists(PNGPath))
                    {
                        textBoxTop.Text = borderset.pbpTopName.ToLower().Replace(".svg", ".png");                        
                        pictureBoxTop.Image = Image.FromFile(PNGPath);
                    }
                }
                else
                {
                    textBoxTop.Text = borderset.pbpTopName;
                    pictureBoxTop.Image = Image.FromFile(cDataBase.getPath(borderset.pbpTopName));
                }
            }            
            else
            {
                textBoxTop.Text = string.Empty;
                pictureBoxTop.Image = null;
            }
            if (borderset.pbpTopRightName.Length > 0 && System.IO.File.Exists(cDataBase.getPath(borderset.pbpTopRightName)))
            {
                if (Path.GetExtension(cDataBase.getPath(borderset.pbpTopRightName)).ToLower() == ".svg")
                {
                    string PNGPath = cDataBase.getPNGPath(cDataBase.getPath(borderset.pbpTopRightName));
                    if (File.Exists(PNGPath))
                    {
                        textBoxTopRight.Text = borderset.pbpTopRightName.ToLower().Replace(".svg", ".png");
                        pictureBoxTopRight.Image = Image.FromFile(PNGPath);
                    }
                }
                else
                {
                    textBoxTopRight.Text = borderset.pbpTopRightName;
                    pictureBoxTopRight.Image = Image.FromFile(cDataBase.getPath(borderset.pbpTopRightName));
                }
            }
            else
            {
                textBoxTopRight.Text = string.Empty;
                pictureBoxTopRight.Image = null;
            }

            if (borderset.pbpLeftName.Length > 0 && System.IO.File.Exists(cDataBase.getPath(borderset.pbpLeftName)))
            {
                if (Path.GetExtension(cDataBase.getPath(borderset.pbpLeftName)).ToLower() == ".svg")
                {
                    string PNGPath = cDataBase.getPNGPath(cDataBase.getPath(borderset.pbpLeftName));
                    if (File.Exists(PNGPath))
                    {
                        textBoxLeft.Text = borderset.pbpLeftName.ToLower().Replace(".svg", ".png");
                        pictureBoxLeft.Image = Image.FromFile(PNGPath);
                    }
                }
                else
                {
                    textBoxLeft.Text = borderset.pbpLeftName;
                    pictureBoxLeft.Image = Image.FromFile(cDataBase.getPath(borderset.pbpLeftName));
                }
                    
            }
            else
            {
                textBoxLeft.Text = string.Empty;
                pictureBoxLeft.Image = null;
            }
            if (borderset.pbpRightName.Length > 0 && System.IO.File.Exists(cDataBase.getPath(borderset.pbpRightName)))
            {
                if (Path.GetExtension(cDataBase.getPath(borderset.pbpRightName)).ToLower() == ".svg")
                {
                    string PNGPath = cDataBase.getPNGPath(cDataBase.getPath(borderset.pbpRightName));
                    if (File.Exists(PNGPath))
                    {
                        textBoxRight.Text = borderset.pbpRightName.ToLower().Replace(".svg", ".png");
                        pictureBoxRight.Image = Image.FromFile(PNGPath);
                    }
                }
                else
                {
                    textBoxRight.Text = borderset.pbpRightName;
                    pictureBoxRight.Image = Image.FromFile(cDataBase.getPath(borderset.pbpRightName));
                }

            }
            else
            {
                textBoxRight.Text = string.Empty;
                pictureBoxRight.Image = null;
            }
            if (borderset.pbpBottomLeftName.Length > 0 && System.IO.File.Exists(cDataBase.getPath(borderset.pbpBottomLeftName)))
            {
                if (Path.GetExtension(cDataBase.getPath(borderset.pbpBottomLeftName)).ToLower() == ".svg")
                {
                    string PNGPath = cDataBase.getPNGPath(cDataBase.getPath(borderset.pbpBottomLeftName));
                    if (File.Exists(PNGPath))
                    {
                        textBoxBottomLeft.Text = borderset.pbpBottomLeftName.ToLower().Replace(".svg", ".png");
                        pictureBoxBottomLeft.Image = Image.FromFile(PNGPath);
                    }
                }
                else
                {
                    textBoxBottomLeft.Text = borderset.pbpBottomLeftName;
                    pictureBoxBottomLeft.Image = Image.FromFile(cDataBase.getPath(borderset.pbpBottomLeftName));
                }

            }
            else
            {
                textBoxBottomLeft.Text = string.Empty;
                pictureBoxBottomLeft.Image = null;
            }
            if (borderset.pbpBottomName.Length > 0 && System.IO.File.Exists(cDataBase.getPath(borderset.pbpBottomName)))
            {
                if (Path.GetExtension(cDataBase.getPath(borderset.pbpBottomName)).ToLower() == ".svg")
                {
                    string PNGPath = cDataBase.getPNGPath(cDataBase.getPath(borderset.pbpBottomName));
                    if (File.Exists(PNGPath))
                    {
                        textBoxBottom.Text = borderset.pbpBottomName.ToLower().Replace(".svg", ".png");
                        pictureBoxBottom.Image = Image.FromFile(PNGPath);
                    }
                }
                else
                {
                    textBoxBottom.Text = borderset.pbpBottomName;
                    pictureBoxBottom.Image = Image.FromFile(cDataBase.getPath(borderset.pbpBottomName));
                }

            }
            else
            {
                textBoxBottom.Text = string.Empty;
                pictureBoxBottom.Image = null;
            }
            if (borderset.pbpBottomRightName.Length > 0 && System.IO.File.Exists(cDataBase.getPath(borderset.pbpBottomRightName)))
            {
                if (Path.GetExtension(cDataBase.getPath(borderset.pbpBottomRightName)).ToLower() == ".svg")
                {
                    string PNGPath = cDataBase.getPNGPath(cDataBase.getPath(borderset.pbpBottomRightName));
                    if (File.Exists(PNGPath))
                    {
                        textBoxBottomRight.Text = borderset.pbpBottomRightName.ToLower().Replace(".svg", ".png");
                        pictureBoxBottomRight.Image = Image.FromFile(PNGPath);
                    }
                }
                else
                {
                    textBoxBottomRight.Text = borderset.pbpBottomRightName;
                    pictureBoxBottomRight.Image = Image.FromFile(cDataBase.getPath(borderset.pbpBottomRightName));
                }

            }
            else
            {
                textBoxBottomRight.Text = string.Empty;
                pictureBoxBottomRight.Image = null;
            }


            sAttributeScreen attr = new sAttributeScreen(null);
            attr.pZPosition = -100;

            attr.pAbsolutX = attr.pRelativX = 50;
            attr.pAbsolutY = attr.pRelativY = 50;

            attr.pWidth = 200;
            attr.pHeight = 200;

            attr.pBackgroundColor = (sColor)((sWindowStyle)cDataBase.pWindowstyles.get()).pColors["Background"];

            attr.pLabelForegroundColor = (sColor)((sWindowStyle)cDataBase.pWindowstyles.get()).pColors["LabelForeground"];

            attr.pTitle = "Title";

            attr.pTitleFont = ((sWindowStyle)cDataBase.pWindowstyles.get()).pFont;
            attr.pTitleSize = ((sWindowStyle)cDataBase.pWindowstyles.get()).pTitleSize * (((float)attr.pTitleFont.Scale) / 100.0F);

            attr.pTitleXOff = ((sWindowStyle)cDataBase.pWindowstyles.get()).pXOff;
            attr.pTitleYOff = ((sWindowStyle)cDataBase.pWindowstyles.get()).pYOff;

            attr.pbpTopLeft = borderset.pbpTopLeft;
            attr.pbpTop = borderset.pbpTop;
            attr.pbpTopRight = borderset.pbpTopRight;

            attr.pbpLeft = borderset.pbpLeft;
            attr.pbpRight = borderset.pbpRight;

            attr.pbpBottomLeft = borderset.pbpBottomLeft;
            attr.pbpBottom = borderset.pbpBottom;
            attr.pbpBottomRight = borderset.pbpBottomRight;

            //attr.Flags = "wfBorder";

            pDesigner.clear();
            pDesigner.draw(attr);
        }





        //########################################################################

        private void comboBoxStyles_SelectedIndexChanged(object sender, EventArgs e)
        {
            refreshStyle();
            pictureBoxPreview.Invalidate();
        }

        private void pictureBoxPreview_Paint(object sender, PaintEventArgs e)
        {
            pDesigner.paint(sender, e);
        }
    }
}
