using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
//using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Xml;
using OpenSkinDesigner.Logic;
using OpenSkinDesigner.Structures;

namespace OpenSkinDesigner.Frames
{
    public partial class fColors : Form
    {
        const Int32 COL_NAME = 0;
        const Int32 COL_VALUE_AS_STRING = 1;
        const Int32 COL_VALUE = 2;

        private cXMLHandler pXmlHandler = null;
        // Eingefügt wenn Veränderungen an Farben gemacht wurde, damit man speichern und neu laden kann. 
        public bool Edited = false;

        public fColors()
        {
            InitializeComponent();
        }

        private void refresh()
        {
            listView1.Items.Clear();

            sColor[] colors = (sColor[])cDataBase.pColors.getArray();

            foreach (sColor color in colors)
            {
                System.Windows.Forms.ListViewItem.ListViewSubItem[] subtitems = new System.Windows.Forms.ListViewItem.ListViewSubItem[3];

                subtitems[COL_NAME] = new System.Windows.Forms.ListViewItem.ListViewSubItem();
                subtitems[COL_NAME].Text = color.pName;

                subtitems[COL_VALUE_AS_STRING] = new System.Windows.Forms.ListViewItem.ListViewSubItem();
                if (color.isNamedColor)
                    continue; //subtitems[COL_VALUE_AS_STRING].Text = color.pValueName;
                else
                    subtitems[COL_VALUE_AS_STRING].Text = "#" + color.pValue.ToString("x8");

                subtitems[COL_VALUE] = new System.Windows.Forms.ListViewItem.ListViewSubItem();
                subtitems[COL_VALUE].BackColor = color.ColorAlpha; 
                subtitems[COL_VALUE].Text = "    ";

                ListViewItem item = new ListViewItem(subtitems, 0);
                item.UseItemStyleForSubItems = false;
                listView1.Items.Add(item);
            }
            // Falls keine Farben definiert sind, crasht es... deshalb hier geändert
            if (listView1.Items.Count > 0)
                listView1.RedrawItems(0, listView1.Items.Count - 1, false);
        }

        public void setup(cXMLHandler xmlhandler)
        {
            pXmlHandler = xmlhandler;

            refresh();
        }


        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                textBoxName.Text = listView1.SelectedItems[0].SubItems[COL_NAME].Text;
                Color color = listView1.SelectedItems[0].SubItems[COL_VALUE].BackColor;
                color = Color.FromArgb(255 - color.A, color); 
                textBoxValue.Text = color.ToArgb().ToString("x8");
                // Changing the above causes all the others to be changed.
            }
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem item in listView1.Items)
            {
                String itmName = item.SubItems[COL_NAME].Text;
                String itmValueAsString = item.SubItems[COL_VALUE_AS_STRING].Text;
                if (itmValueAsString[0] == '#')
                    cDataBase.pColors.add((Object)new sColor(itmName, Convert.ToUInt32(itmValueAsString.Substring(1), 16)));
                else
                    cDataBase.pColors.add((Object)new sColor(itmName, itmValueAsString));
            }

            refresh();

            cDataBase.pColors.sync(pXmlHandler);
            if (Edited == true)
            {
                String Message = "You've made some changes, which will only take effect (show the color in the treeview)," ;
                Message += "\n" + "after you have saved and reloaded the skin!";
                Message += "\n";
                Message += "\n" + "Do you want to save and reload the skin now?";
                Message += "\n";
                Message += "\n" + "Remember, however, that this will also save all previous changes you made!";

                if (MessageBox.Show(Message,"Save and reload",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question,
                    MessageBoxDefaultButton.Button1) == DialogResult.Yes)
                {
                    MyGlobaleVariables.Reload = true;
                }
            }
            
            Hide();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            textBoxName.Text = textBoxName.Text.Replace(" ", ""); // Textboxtext trimmen, damit kein 'leerer' Farbname angewendet werden kann
            if (textBoxName.Text.Length == 0)
            {
                MessageBox.Show("Name of the Color cannot be empty!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (textBoxValue.Text.Length == 0)
            {
                MessageBox.Show("Value of the Color cannot be empty!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else
            {
                List<string> Liste = new List<string>();
                for (int i = 0; i < listView1.Items.Count; i++)
                    Liste.Add(listView1.Items[i].SubItems[0].ToString().ToUpper());

                if (Liste.Contains("LISTVIEWSUBITEM: {" + textBoxName.Text.ToUpper() + "}"))
                {
                    MessageBox.Show("This Color already exists!" + "\n" + "You can update this Color by pressing the 'Change'-Button.","Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                else
                {
                    String itmName = textBoxName.Text;
                    UInt32 itmColor = Convert.ToUInt32(textBoxValue.Text, 16);

                    cDataBase.pColors.add((Object)new sColor(itmName, itmColor));
                    Edited = true;
                }
                
                

                
            }

            refresh();
           

        }

        private void textBoxValue_TextChanged(object sender, EventArgs e)
        {
            String colorString = "0";
            UInt32 color = 0;
            try
            {
                colorString = textBoxValue.Text.Length > 0 ? textBoxValue.Text.Replace(" ", "") : "0";
                if (colorString.Length > 8)
                    colorString = colorString.Substring(0, 8);
                color = Convert.ToUInt32(colorString, 16);
            }
            catch (Exception error)
            {
                String errormessage = error.Message + ":\n\n";
                errormessage += "Invalid format for value hexadecimal value!" + "\n";
                errormessage += error.Message;

                MessageBox.Show(errormessage,
                    error.Message,
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information,
                    MessageBoxDefaultButton.Button1);

                return;
            }
            int alpha = (int)(color >> 24) & 0xff; 
            textBoxAlpha.Text = alpha.ToString();
            int red = (int)(color >> 16) & 0xff;
            textBoxRed.Text = red.ToString();
            int green = (int)(color >> 8) & 0xff;
            textBoxGreen.Text = green.ToString();
            int blue = (int)color & 0xff;
            textBoxBlue.Text = blue.ToString();
            pictureBoxColor.BackColor = Color.FromArgb(255 - alpha, red, green, blue); 
            try // TRY eingefügt, da es crasht wenn vorher kein Item in dem Listview ausgewählt wurde.
            {
                listView1.SelectedItems[0].SubItems[COL_VALUE_AS_STRING].Text = "#" + textBoxValue.Text;
                listView1.SelectedItems[0].SubItems[COL_VALUE].BackColor = pictureBoxColor.BackColor;
            }
            catch (Exception) 
            {
            }
             
        }

        private void textBoxAlpha_TextChanged(object sender, EventArgs e)
        {
            UInt32 alpha = 0;
            UInt32 red = 0;
            UInt32 green = 0;
            UInt32 blue = 0;
            int help = 0;

            Int32.TryParse(textBoxAlpha.Text, out help);
            trackBar_Alpha.Value = help;
            Int32.TryParse(textBoxRed.Text, out help);
            trackBarRed.Value = help;
            Int32.TryParse(textBoxBlue.Text, out help);
            trackBarBlue.Value = help;
            Int32.TryParse(textBoxGreen.Text, out help);
            trackBarGreen.Value = help;
            try
            {
                String alphaString = textBoxAlpha.Text.Length > 0 ? textBoxAlpha.Text.Trim() : "0";
                alpha = Convert.ToUInt32(alphaString);
                alpha &= 0xFF;
            }
            catch (Exception error)
            {
                String errormessage = error.Message + ":\n\n";
                errormessage += "Invalid format for value alpha!" + "\n";
                errormessage += error.Message;

                MessageBox.Show(errormessage,
                    error.Message,
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information,
                    MessageBoxDefaultButton.Button1);

                return;
            }

            try
            {
                String redString = textBoxRed.Text.Length > 0 ? textBoxRed.Text.Trim() : "0";
                red = Convert.ToUInt32(redString);
                red &= 0xFF;
            }
            catch (Exception error)
            {
                String errormessage = error.Message + ":\n\n";
                errormessage += "Invalid format for value red!" + "\n";
                errormessage += error.Message;

                MessageBox.Show(errormessage,
                    error.Message,
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information,
                    MessageBoxDefaultButton.Button1);

                return;
            }

            try
            {
                String greenString = textBoxGreen.Text.Length > 0 ? textBoxGreen.Text.Trim() : "0";
                green = Convert.ToUInt32(greenString);
                green &= 0xFF;
            }
            catch (Exception error)
            {
                String errormessage = error.Message + ":\n\n";
                errormessage += "Invalid format for value green!" + "\n";
                errormessage += error.Message;

                MessageBox.Show(errormessage,
                    error.Message,
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information,
                    MessageBoxDefaultButton.Button1);

                return;
            }

            try
            {
                String blueString = textBoxBlue.Text.Length > 0 ? textBoxBlue.Text.Trim() : "0";
                blue = Convert.ToUInt32(blueString);
                blue &= 0xFF;
            }
            catch (Exception error)
            {
                String errormessage = error.Message + ":\n\n";
                errormessage += "Invalid format for value blue!" + "\n";
                errormessage += error.Message;

                MessageBox.Show(errormessage,
                    error.Message,
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information,
                    MessageBoxDefaultButton.Button1);

                return;
            }

            UInt32 value = /*Convert.ToUInt32*/((alpha * 0x01000000) + (red * 0x00010000) + (green * 0x00000100) + blue);
            textBoxValue.Text = value.ToString("x8");
            pictureBoxColor.BackColor = Color.FromArgb(255 - (int)alpha, (int)red, (int)green, (int)blue); 
        }

        private void buttonPallete_Click(object sender, EventArgs e)
        {
            colorDialog.AllowFullOpen = true;
            colorDialog.AnyColor = true;
            colorDialog.FullOpen = true;
            colorDialog.SolidColorOnly = false;
            UInt32 color = (Convert.ToUInt32(textBoxValue.Text,16)&0x00FFFFFF);
            UInt32 colorSwap = color;
            colorSwap |= (((colorSwap >> 16) & 0xFF) << 24);
            colorSwap &= 0xFF00FFFF;
            colorSwap |= (((colorSwap >> 0) & 0xFF) << 16);
            colorSwap &= 0xFFFFFF00;
            colorSwap |= (((colorSwap >> 24) & 0xFF) << 0);
            colorSwap &= 0x00FFFFFF;
            colorDialog.CustomColors = new int[] { (Int32)colorSwap, };
            colorDialog.Color = Color.FromArgb((Int32)color );
            DialogResult rst = colorDialog.ShowDialog();
            if (rst == DialogResult.OK)
            {
                textBoxRed.Text = Convert.ToString(colorDialog.Color.R);
                textBoxGreen.Text = Convert.ToString(colorDialog.Color.G);
                textBoxBlue.Text = Convert.ToString(colorDialog.Color.B);
                textBoxAlpha.Text = "0"; // Wenn Auswahl in der Palette die Transparenz zurücksetzen
            }
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            Hide();
        }

        private void buttonRemove_Click(object sender, EventArgs e)
        { // Info hinzugefügt, dass hier nichts passiert
            // Dieser Button hat ursprünglich nichts gemacht, nur Hinweis, dass nicht benutzte Farben entfernt werden, was aber nicht stimmt!
            // MessageBox.Show("Unused colors are removed automatically (NOT TRUE!).\n\nThis Button is doing NOTHING!", "Information",MessageBoxButtons.OK,MessageBoxIcon.Information);
            if (listView1.SelectedItems.Count < 1) // Eingefügt, sonst crash, wenn noch kein Item ausgewählt wurde!
            {
                MessageBox.Show("To do this, you must select a Color in the listview!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                cDataBase.pColors.removeColor(pXmlHandler, listView1.SelectedItems[0].SubItems[COL_NAME].Text, textBoxName.Text);
                listView1.Items.Remove(listView1.SelectedItems[0]);
                Refresh();
                Edited = true;
            }
        }



        private void buttonRename_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count < 1) // Eingefügt, sonst crash, wenn noch kein Item ausgewählt wurde!
            {
                MessageBox.Show("To do this, you must select a Color in the listview!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else // oder der Farbname auf "" gesetzt wird wenn Textbox leer ist.  
            {
                textBoxName.Text = textBoxName.Text.Replace(" ", ""); // Textboxtext trimmen, damit kein 'leerer' Farbname angewendet werden kann
                if (textBoxName.Text.Length > 0) 
                {
                    cDataBase.pColors.rename(pXmlHandler, listView1.SelectedItems[0].SubItems[COL_NAME].Text, textBoxName.Text);
                    listView1.SelectedItems[0].SubItems[COL_NAME].Text = textBoxName.Text;
                    Refresh();
                    Edited = true;
                }
                else
                {
                    MessageBox.Show("Name of the Color cannot be empty!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
                       
        }

        private void textBoxValue_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            String Message = "Hints:" + "\n\n";
            Message += "- The color in the 'listview' can only be displayed without an alpha channel,";
            Message += "i.e. the color representation is only displayed correctly (with transparency) in the 'picturebox' in the left lower corner!" + "\n\n";
            Message += "- Alpha = transparency! I.e. the more alpha the more transparent the color becomes.";
            MessageBox.Show(Message,"Hints",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }

        private void trackBar1_ValueChanged(object sender, EventArgs e)
        {
            textBoxAlpha.Text = trackBar_Alpha.Value.ToString(); 
        }

        private void trackBarBlue_Scroll(object sender, EventArgs e)
        {
            textBoxBlue.Text = trackBarBlue.Value.ToString();
        }

        private void trackBarGreen_Scroll(object sender, EventArgs e)
        {
            textBoxGreen.Text = trackBarGreen.Value.ToString();
        }

        private void trackBarRed_Scroll(object sender, EventArgs e)
        {
            textBoxRed.Text = trackBarRed.Value.ToString();
        }
    }
}
