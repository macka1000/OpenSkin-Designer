using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
//using System.Linq;
using System.Text;
using System.Windows.Forms;
using OpenSkinDesigner.Logic;
using OpenSkinDesigner.Structures;
using System.Drawing.Text;
using System.IO;

namespace OpenSkinDesigner.Frames
{
    public partial class fFonts : Form
    {
        private cXMLHandler pXmlHandler = null;
        Font MyFont = new Font("Arial", 30.25F, FontStyle.Regular, GraphicsUnit.Pixel);
        
        public fFonts()
        {
            InitializeComponent();
        }

        public void setup(cXMLHandler xmlhandler)
        {
            pXmlHandler = xmlhandler;

            sFont[] fonts = cDataBase.getFonts();

            //listView1.Clear();
            foreach (sFont font in fonts)
            {
                System.Windows.Forms.ListViewItem.ListViewSubItem[] subtitems = new System.Windows.Forms.ListViewItem.ListViewSubItem[7];

                subtitems[0] = new System.Windows.Forms.ListViewItem.ListViewSubItem();
                subtitems[0].Text = font.Name;
                subtitems[1] = new System.Windows.Forms.ListViewItem.ListViewSubItem();
                subtitems[1].Text = font.Filename;
                subtitems[2] = new System.Windows.Forms.ListViewItem.ListViewSubItem();
                subtitems[2].Text = Convert.ToString(font.Size);
                subtitems[3] = new System.Windows.Forms.ListViewItem.ListViewSubItem();
                subtitems[3].Text = font.Path;
                subtitems[4] = new System.Windows.Forms.ListViewItem.ListViewSubItem();
                subtitems[4].Text = Convert.ToString(font.Scale);
                subtitems[5] = new System.Windows.Forms.ListViewItem.ListViewSubItem();
                subtitems[5].Text = Convert.ToString(font.Replacement);
                subtitems[6] = new System.Windows.Forms.ListViewItem.ListViewSubItem();
                subtitems[6].Text = "0";

                ListViewItem item = new ListViewItem(subtitems, 0);
                listView1.Items.Add(item);
            }
            listView1.RedrawItems(0, listView1.Items.Count - 1, false);
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBoxPreview.Visible = false;
            if (listView1.SelectedItems.Count > 0)
            {
                textBoxName.Text = listView1.SelectedItems[0].SubItems[0].Text;
                textBoxPath.Text = listView1.SelectedItems[0].SubItems[3].Text;
                textBoxScale.Text = listView1.SelectedItems[0].SubItems[4].Text;
                checkBoxReplacement.Checked = Convert.ToBoolean(listView1.SelectedItems[0].SubItems[5].Text);

                float pSize = 40.25F;
                sFont pFont = cDataBase.getFont(textBoxName.Text);
                
                // System.Drawing.Font font = null;
                String name = "";
                try
                {
                    if (pFont.FontFamily != null) //Only do this if the font is valid
                    {
                        name = pFont.FontFamily.GetName(0);
                        // font = new System.Drawing.Font(pFont.FontFamily, pSize, pFont.FontStyle, GraphicsUnit.Pixel);
                        MyFont = new System.Drawing.Font(pFont.FontFamily, pSize, pFont.FontStyle, GraphicsUnit.Pixel);
                        pictureBox1.Invalidate();
                    }
                    else
                    {
                        Console.WriteLine("Font painting failed! (" + pFont.Name + ")");
                        textBoxPreview.Visible = true;
                    }
                }
                catch (Exception error)
                {
                    Console.WriteLine("Font painting failed! (" + pFont.Name + ")\n" + error);
                    textBoxPreview.Visible = true;
                    return;
                }

                
            }
        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawString("Test-String Sky 1234567890 !#?ÜÄÖ", MyFont, Brushes.Black, 10, 10);
        }
    }
}
