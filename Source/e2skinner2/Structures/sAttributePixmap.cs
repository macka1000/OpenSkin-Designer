using System;
using System.Collections.Generic;
//using System.Linq;
using System.Text;
using System.Drawing;
using OpenSkinDesigner.Logic;
using System.Xml;
using System.IO;
using System.ComponentModel;
using System.Windows.Forms;

namespace OpenSkinDesigner.Structures
{
    class sAttributePixmap : sAttribute
    {
        private const String entryName = "Pixmap";

        public String pPixmapName;
        public Size pPixmap;
        public bool pHide = false;
        //public Image pPixmap = null;


        public cProperty.eAlphatest pAlphatest = cProperty.eAlphatest.off;

        [CategoryAttribute(entryName)]
        public String Path
        {
            get { return pPixmapName; }
            set
            {
                pPixmapName = value;
                if (pPixmapName != null && pPixmapName.Length > 0)
                {
                    if (myNode.Attributes["pixmap"] != null)
                        myNode.Attributes["pixmap"].Value = pPixmapName;
                    else
                    {
                        myNode.Attributes.Append(myNode.OwnerDocument.CreateAttribute("pixmap"));
                        myNode.Attributes["pixmap"].Value = pPixmapName;
                    }
                }
                else
                    if (myNode.Attributes["pixmap"] != null)
                    myNode.Attributes.RemoveNamedItem("pixmap");
            }
        }

        [CategoryAttribute(entryName),
        ReadOnlyAttribute(true)]
        public Size Resolution
        {
            get { return new Size(pPixmap.Width, pPixmap.Height); }
        }

        [TypeConverter(typeof(cProperty.AlphatestConverter)),
        CategoryAttribute(entryName)]
        public String Alphatest
        {
            get { return pAlphatest.ToString(); }
            set
            {
                if (value != null && value == cProperty.eAlphatest.on.ToString()) pAlphatest = cProperty.eAlphatest.on;
                else if (value != null && value == cProperty.eAlphatest.blend.ToString()) pAlphatest = cProperty.eAlphatest.blend;
                else pAlphatest = cProperty.eAlphatest.off;

                if (myNode.Attributes["alphatest"] != null)
                    myNode.Attributes["alphatest"].Value = "off";
                else
                {
                    myNode.Attributes.Append(myNode.OwnerDocument.CreateAttribute("alphatest"));
                    myNode.Attributes["alphatest"].Value = "off";
                }

                if (pAlphatest == cProperty.eAlphatest.on) myNode.Attributes["alphatest"].Value = "on";
                else if (pAlphatest == cProperty.eAlphatest.blend) myNode.Attributes["alphatest"].Value = "blend";
                else myNode.Attributes["alphatest"].Value = "off";
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="parent"></param>
        /// <param name="node"></param>

        ~sAttributePixmap()
        {
            //if (pPixmap != null) pPixmap.Dispose();
        }

        public sAttributePixmap(sAttribute parent, XmlNode node)
            : base(parent, node)
        {
            // ePixmap or widget element with attribute 'pixmap' (= path to image)
            if (node.Attributes["pixmap"] != null)
            {
                pPixmapName = node.Attributes["pixmap"].Value;
                try
                {
                    //PVMC Workaround
                    if (pPixmapName.Contains("ProjectValerie"))
                    {
                        pPixmapName = pPixmapName.Substring(pPixmapName.IndexOf("ProjectValerie/skins/") + "ProjectValerie/skins/".Length);
                    }
                    Image pixmap = Image.FromFile(cDataBase.getPath(pPixmapName));

                    // Element has scale attribute -> take size attribute
                    if (node.Attributes["scale"] != null)
                    {
                        pPixmap = new Size(this.Size.Width, this.Size.Height);
                    }
                    else
                    {
                        pPixmap = pixmap.Size;
                    }
                    pixmap.Dispose();
                }
                catch (FileNotFoundException)
                {
                    Image pixmap = Image.FromFile(Application.StartupPath + cProperties.getProperty("path_skins").Replace("./", "\\").Replace("/", "\\") + "broken.png", true);
                    pPixmap = pixmap.Size;
                    pixmap.Dispose();
                    pPixmapName = "@broken.png";
                }
            }
            else if (node.Attributes["pixmaps"] != null)
            {
                pPixmapName = node.Attributes["pixmaps"].Value.Split(',')[0];
                try
                {
                    Image pixmap = Image.FromFile(cDataBase.getPath(pPixmapName));

                    // Element has scale attribute -> take size attribute
                    if (node.Attributes["scale"] != null)
                    {
                        pPixmap = new Size(this.Size.Width, this.Size.Height);
                    }
                    else
                    {
                        pPixmap = pixmap.Size;
                    }
                    pixmap.Dispose();
                }
                catch (FileNotFoundException)
                {
                    Image pixmap = Image.FromFile(Application.StartupPath + cProperties.getProperty("path_skins").Replace("./", "\\").Replace("/", "\\") + "broken.png", true);
                    pPixmap = pixmap.Size;
                    pixmap.Dispose();
                    pPixmapName = "@broken.png";
                }
            }
            else if (node.Attributes["path"] != null)
            {
                //Any Render that use path attribute
                String path = node.Attributes["path"].Value;
                try
                {
                    // take random picture in path
                    string[] filePaths = null;
                    try
                    {
                        filePaths = Directory.GetFiles(@cDataBase.getPath(path));
                    }
                    catch
                    {
                        // Bug Fix: falls skin path bestandteil von path ist
                        path = path.Replace(cProperties.getProperty("path_skin"), "");
                        filePaths = Directory.GetFiles(@cDataBase.getPath(path));
                    }

                    pPixmapName = cProperties.getProperty("path_skin").Replace("./", "\\").Replace("/", "\\") + "/" + path + "/" + System.IO.Path.GetFileName(filePaths[0]);
                    Image pixmap = Image.FromFile(cDataBase.getPath(pPixmapName));

                    // Element has scale attribute -> take size attribute
                    if (node.Attributes["scale"] != null)
                    {
                        pPixmap = new Size(this.Size.Width, this.Size.Height);
                    }
                    else
                    {
                        pPixmap = pixmap.Size;
                    }
                    pixmap.Dispose();
                }
                catch (FileNotFoundException)
                {
                    Image pixmap = Image.FromFile(Application.StartupPath + cProperties.getProperty("path_skins").Replace("./", "\\").Replace("/", "\\") + "broken.png", true);
                    pPixmap = pixmap.Size;
                    pixmap.Dispose();
                    pPixmapName = "@broken.png";
                }

                //MessageBox.Show(node.Attributes["path"].Value);
            }
            else if (node.Attributes["render"] != null && node.Attributes["render"].Value.ToLower().Contains("picon"))
            {
                try
                {
                    String piconFileName = "picon.png";

                    if (node.Attributes["render"].Value.ToLower().Contains("xpicon"))
                    {
                        piconFileName = "xpicon.png";
                    }
                    else if (node.Attributes["render"].Value.ToLower().Contains("xhdpicon"))
                    {
                        piconFileName = "xhdpicon.png";
                    }

                    Image pixmap = Image.FromFile(Application.StartupPath + cProperties.getProperty("path_skins").Replace("./", "\\").Replace("/", "\\") + piconFileName, true);

                    // size of root element (= size of a widget)
                    pPixmap = new Size(this.Size.Width, this.Size.Height);

                    pixmap.Dispose();
                    pPixmapName = "@" + piconFileName;
                }
                catch (FileNotFoundException)
                {
                    Image pixmap = Image.FromFile(Application.StartupPath + cProperties.getProperty("path_skins").Replace("./", "\\").Replace("/", "\\") + "broken.png", true);
                    pPixmap = pixmap.Size;
                    pixmap.Dispose();
                    pPixmapName = "@broken.png";
                }
            }
            else if (node.Attributes["render"] != null && node.Attributes["render"].Value.ToLower().Contains("eventimage"))
            {
                try
                {
                    String eventImageFileName = "eventimage.jpg";

                    Image pixmap = Image.FromFile(Application.StartupPath + cProperties.getProperty("path_skins").Replace("./", "\\").Replace("/", "\\") + eventImageFileName, true);

                    // size of root element (= size of a widget)
                    pPixmap = new Size(this.Size.Width, this.Size.Height);

                    pixmap.Dispose();
                    pPixmapName = "@" + eventImageFileName;
                }
                catch (FileNotFoundException)
                {
                    Image pixmap = Image.FromFile(Application.StartupPath + cProperties.getProperty("path_skins").Replace("./", "\\").Replace("/", "\\") + "broken.png", true);
                    pPixmap = pixmap.Size;
                    pixmap.Dispose();
                    pPixmapName = "@broken.png";
                }
            }


                if (node.Attributes["alphatest"] != null)
                pAlphatest = node.Attributes["alphatest"].Value.ToLower() == "on" ? cProperty.eAlphatest.on :
                    node.Attributes["alphatest"].Value.ToLower() == "blend" ? cProperty.eAlphatest.blend :
                    cProperty.eAlphatest.off;
        }
    }
}
