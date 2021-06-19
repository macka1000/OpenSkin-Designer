﻿using System;
using System.Collections.Generic;
//using System.Linq;
using System.Text;
using System.Collections;
using System.Drawing;
using System.Windows.Forms;
using OpenSkinDesigner.Logic;

namespace OpenSkinDesigner.Structures
{
    public class sWindowStyle
    {
        public class sBorderSet
        {
            public String pName;

            public enum ePosition
            {
                bpTopLeft, bpTop, bpTopRight,
                bpLeft, bpRight,
                bpBottomLeft, bpBottom, bpBottomRight
            };

            public String pbpTopLeftName;
            public String pbpTopName;
            public String pbpTopRightName;
            public String pbpLeftName;
            public String pbpRightName;
            public String pbpBottomLeftName;
            public String pbpBottomName;
            public String pbpBottomRightName;

            public Size pbpTopLeft;
            public Size pbpTop;
            public Size pbpTopRight;
            public Size pbpLeft;
            public Size pbpRight;
            public Size pbpBottomLeft;
            public Size pbpBottom;
            public Size pbpBottomRight;

            public sBorderSet(String name,
                                String bpTopLeftName,
                                String bpTopName,
                                String bpTopRightName,
                                String bpLeftName,
                                String bpRightName,
                                String bpBottomLeftName,
                                String bpBottomName,
                                String bpBottomRightName)
            {
                pName = name;

                pbpTopLeftName = bpTopLeftName;
                pbpTopName = bpTopName;
                pbpTopRightName = bpTopRightName;
                pbpLeftName = bpLeftName;
                pbpRightName = bpRightName;
                pbpBottomLeftName = bpBottomLeftName;
                pbpBottomName = bpBottomName;
                pbpBottomRightName = bpBottomRightName;

                // MOD: fixed Unhandled Exception when a file(borderset) not found... And display a message
                int anz = 0;
                if (pbpTopLeftName.Length > 0 && !System.IO.File.Exists(cDataBase.getPath(pbpTopLeftName)))
                {
                    anz += 1;
                }
                if (pbpTopName.Length > 0 && !System.IO.File.Exists(cDataBase.getPath(pbpTopName)))
                {
                    anz += 1;
                }
                if (pbpTopRightName.Length > 0 && !System.IO.File.Exists(cDataBase.getPath(pbpTopRightName)))
                {
                    anz += 1;
                }
                if (pbpLeftName.Length > 0 && !System.IO.File.Exists(cDataBase.getPath(pbpLeftName)))
                {
                    anz += 1;
                }
                if (pbpRightName.Length > 0 && !System.IO.File.Exists(cDataBase.getPath(pbpRightName)))
                {
                    anz += 1;
                }
                if (pbpBottomLeftName.Length > 0 && !System.IO.File.Exists(cDataBase.getPath(pbpBottomLeftName)))
                {
                    anz += 1;
                }
                if (pbpBottomName.Length > 0 && !System.IO.File.Exists(cDataBase.getPath(pbpBottomName)))
                {
                    anz += 1;
                }
                if (pbpBottomRightName.Length > 0 && !System.IO.File.Exists(cDataBase.getPath(pbpBottomRightName)))
                {
                    anz += 1;
                }
                if (anz > 0)
                {
                    MessageBox.Show("Some borderset-files from '" + pName + "' are not existing!" + "\n\n",
                    "File(s) not found",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                }
                bool shown = false; // Only show ones
                if (pbpTopLeftName.Length > 0 && System.IO.File.Exists(cDataBase.getPath(pbpTopLeftName)))
                {
                    if (cDataBase.getPath(pbpTopLeftName).EndsWith("svg"))
                        if (shown==false)
                        {
                            shown = true;
                            MessageBox.Show("'.svg'-images are not supported!");
                            Application.Exit();
                        }
                        else
                        {

                        }
                    else
                    {
                        Image pixmap = Image.FromFile(cDataBase.getPath(pbpTopLeftName));
                        pbpTopLeft = pixmap.Size;
                        pixmap.Dispose();
                    }
                        
                }
                if (pbpTopName.Length > 0 && System.IO.File.Exists(cDataBase.getPath(pbpTopName)))
                {
                    if (cDataBase.getPath(pbpTopName).EndsWith("svg"))
                        if (shown == false)
                        {
                            shown = true;
                            MessageBox.Show("'.svg'-images are not supported!");
                            Application.Exit();
                        }
                        else
                        {
                        }
                    else

                    {
                        Image pixmap = Image.FromFile(cDataBase.getPath(pbpTopName));
                        pbpTop = pixmap.Size;
                        pixmap.Dispose();
                    }
                    
                }
                if (pbpTopRightName.Length > 0 && System.IO.File.Exists(cDataBase.getPath(pbpTopRightName)))
                {
                    if (cDataBase.getPath(pbpTopRightName).EndsWith("svg"))
                        if (shown == false)
                        {
                            shown = true;
                            MessageBox.Show("'.svg'-images are not supported!");
                            Application.Exit();
                        }
                        else
                        { 
                        }
                    else

                    {
                        Image pixmap = Image.FromFile(cDataBase.getPath(pbpTopRightName));
                        pbpTopRight = pixmap.Size;
                        pixmap.Dispose();
                    }
                    
                }


                if (pbpLeftName.Length > 0 && System.IO.File.Exists(cDataBase.getPath(pbpLeftName)))
                {
                    if (cDataBase.getPath(pbpLeftName).EndsWith("svg"))
                        if (shown == false)
                        {
                            shown = true;
                            MessageBox.Show("'.svg'-images are not supported!");
                            Application.Exit();
                        }

                        else
                        {

                        }
                    else
                    {
                        Image pixmap = Image.FromFile(cDataBase.getPath(pbpLeftName));
                        pbpLeft = pixmap.Size;
                        pixmap.Dispose();
                    }
                    
                }
                if (pbpRightName.Length > 0 && System.IO.File.Exists(cDataBase.getPath(pbpRightName)))
                {
                    if (cDataBase.getPath(pbpRightName).EndsWith("svg"))
                        if (shown == false)
                        {
                            shown = true;
                            MessageBox.Show("'.svg'-images are not supported!");
                            Application.Exit();
                        }

                        else
                        {

                        }
                    else
                    {
                        Image pixmap = Image.FromFile(cDataBase.getPath(pbpRightName));
                        pbpRight = pixmap.Size;
                        pixmap.Dispose();
                    }
                    
                }


                if (pbpBottomLeftName.Length > 0 && System.IO.File.Exists(cDataBase.getPath(pbpBottomLeftName)))
                {
                    if (cDataBase.getPath(pbpBottomLeftName).EndsWith("svg"))
                        if (shown == false)
                        {
                            shown = true;
                            MessageBox.Show("'.svg'-images are not supported!");
                            Application.Exit();
                        }
                        else
                        {

                        }
                    else
                    {
                        Image pixmap = Image.FromFile(cDataBase.getPath(pbpBottomLeftName));
                        pbpBottomLeft = pixmap.Size;
                        pixmap.Dispose();
                    }
                    
                }
                if (pbpBottomName.Length > 0 && System.IO.File.Exists(cDataBase.getPath(pbpBottomName)))
                {
                    if (cDataBase.getPath(pbpBottomName).EndsWith("svg"))
                        if (shown == false)
                        {
                            shown = true;
                            MessageBox.Show("'.svg'-images are not supported!");
                            Application.Exit();
                        }
                        else
                        {

                        }
                    else
                    {
                        Image pixmap = Image.FromFile(cDataBase.getPath(pbpBottomName));
                        pbpBottom = pixmap.Size;
                        pixmap.Dispose();
                    }
                   
                }
                if (pbpBottomRightName.Length > 0 && System.IO.File.Exists(cDataBase.getPath(pbpBottomRightName)))
                {
                    if (cDataBase.getPath(pbpBottomRightName).EndsWith("svg"))
                        if (shown == false)
                        {
                            shown = true;
                            MessageBox.Show("'.svg'-images are not supported!");
                            Application.Exit();
                        }

                        else
                        {

                        }
                    else
                    {
                        Image pixmap = Image.FromFile(cDataBase.getPath(pbpBottomRightName));
                        pbpBottomRight = pixmap.Size;
                        pixmap.Dispose();
                    }
                    
                }
            }
        }

        public sFont pFont;
        public float pTitleSize;
        public Int32 pXOff;
        public Int32 pYOff;
        public Hashtable pColors;
        public Hashtable pBorderSets;

        public sWindowStyle(sFont font, float titlesize, Int32 xOff, Int32 yOff, Hashtable colors, sBorderSet[] bordersets)
        {
            pFont = font;
            pTitleSize = titlesize;
            pXOff = xOff;
            pYOff = yOff;

            pColors = colors;/*new Hashtable();
            foreach (sColor color in colors)
                pColors.Add(color.pName, color);*/

            pBorderSets = new Hashtable();
            foreach (sBorderSet borderset in bordersets)
                pBorderSets.Add(borderset.pName, borderset);
        }
    }
}