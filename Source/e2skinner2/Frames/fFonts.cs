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

        public string PreviewText { get; private set; } //MOD
        public string PreviewText2 { get; private set; }//MOD
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
                System.Windows.Forms.ListViewItem.ListViewSubItem[] subtitems = new System.Windows.Forms.ListViewItem.ListViewSubItem[9];

                subtitems[0] = new System.Windows.Forms.ListViewItem.ListViewSubItem();
                subtitems[0].Text = font.isAlias == true ? "X" : "";
                subtitems[1] = new System.Windows.Forms.ListViewItem.ListViewSubItem();
                subtitems[1].Text = font.Name;
                subtitems[2] = new System.Windows.Forms.ListViewItem.ListViewSubItem();
                subtitems[2].Text = font.Filename;
                subtitems[3] = new System.Windows.Forms.ListViewItem.ListViewSubItem();
                subtitems[3].Text = font.FontName;
                subtitems[4] = new System.Windows.Forms.ListViewItem.ListViewSubItem();
                subtitems[4].Text = Convert.ToString(font.Size);
                subtitems[5] = new System.Windows.Forms.ListViewItem.ListViewSubItem();
                subtitems[5].Text = font.Path;
                subtitems[6] = new System.Windows.Forms.ListViewItem.ListViewSubItem();
                subtitems[6].Text = Convert.ToString(font.Scale);
                subtitems[7] = new System.Windows.Forms.ListViewItem.ListViewSubItem();
                subtitems[7].Text = Convert.ToString(font.Replacement);
                subtitems[8] = new System.Windows.Forms.ListViewItem.ListViewSubItem();
                subtitems[8].Text = "0";

                ListViewItem item = new ListViewItem(subtitems, 0);
                listView1.Items.Add(item);
            }
            if (listView1.Items.Count>0) //MOD
                listView1.RedrawItems(0, listView1.Items.Count - 1, false);
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                textBoxName.Text = listView1.SelectedItems[0].SubItems[1].Text;
                textBoxPath.Text = listView1.SelectedItems[0].SubItems[5].Text;
                textBoxScale.Text = listView1.SelectedItems[0].SubItems[6].Text;
                textBox1.Text = listView1.SelectedItems[0].SubItems[4].Text;
                checkBoxReplacement.Checked = Convert.ToBoolean(listView1.SelectedItems[0].SubItems[7].Text);

                float pSize = Convert.ToSingle(textBox1.Text);
                sFont pFont = cDataBase.getFont(textBoxName.Text);

                // System.Drawing.Font font = null;
                String name = "";
                bool found = true;
                try
                {
                    if (pFont.FontFamily != null) //Only do this if the font is valid
                    {
                        name = pFont.FontFamily.GetName(0);
                        found = pFont.Found; //MOD
                        if (found == true) //MOD
                        {
                            PreviewText = "This is a preview-text to show the font";
                            PreviewText2 = "Test-String SKY 1234567890 !#?ÜÖÄ$%/()";
                            if (pSize == 0) //MOD if Size=0 set Size and show preview-text
                            {
                                pSize = 20;
                                PreviewText = "To be able to show this preview, the font size";
                                PreviewText2 = "was temporarily changed from 0 to 20";
                            }
                            // font = new System.Drawing.Font(pFont.FontFamily, pSize, pFont.FontStyle, GraphicsUnit.Pixel);
                            MyFont = new System.Drawing.Font(pFont.FontFamily, pSize, pFont.FontStyle, GraphicsUnit.Pixel);
                            pictureBox1.Invalidate();
                            pictureBox2.Invalidate(); //MOD
                            textBoxPreview.Visible = false;
                        }
                        else
                        {
                            Console.WriteLine("Font painting failed! (" + pFont.Name + ")");
                            textBoxPreview.Text = "The font '" + pFont.Name + "' was not found." + Environment.NewLine + "Probably this is a default font on the image of your box";
                            textBoxPreview.Visible = true; //MOD
                        }

                    }
                    else
                    {
                        Console.WriteLine("Font painting failed! (" + pFont.Name + ")");
                        textBoxPreview.Text = "The font '" + pFont.Name + "' was not found." + Environment.NewLine + "Probably this is a default font on the image of your box";
                        textBoxPreview.Visible = true; //MOD
                    }
                }
                catch (Exception error)
                {
                    Console.WriteLine("Font painting failed! (" + pFont.Name + ")\n" + error);
                    textBoxPreview.Text = error.Message;
                    textBoxPreview.Visible = true; //MOD 
                    return;
                }


            }
        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            if (listView1.SelectedItems.Count > 0) //MOD Do not show on Form load
            {
                e.Graphics.DrawString(PreviewText, MyFont, Brushes.Black, 10, 10);
            }
        }

        private void pictureBox2_Paint(object sender, PaintEventArgs e)
        {
            if (listView1.SelectedItems.Count > 0) //MOD Do not show on Form load
            {
                e.Graphics.DrawString(PreviewText2, MyFont, Brushes.Black, 10, 10);
            }
        }

        private void checkBoxReplacement_Click(object sender, EventArgs e)
        {
            if (checkBoxReplacement.Checked == true)
                checkBoxReplacement.Checked = false;
            else
                checkBoxReplacement.Checked = true;
        }
    }
}
