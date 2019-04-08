using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
//using System.Linq;
using System.Reflection;
using System.Windows.Forms;

namespace OpenSkinDesigner.Frames
{
    partial class fAbout : Form
    {
        public fAbout()
        {
            InitializeComponent();
            this.Text = String.Format("Info über {0}", AssemblyTitle);
            this.labelProductName.Text = AssemblyProduct;
            this.labelVersion.Text = String.Format("Version {0}", AssemblyVersion);
            this.labelCopyright.Text = AssemblyCopyright;
            this.labelCompanyName.Text = AssemblyCompany;
            this.textBoxDescription.Text = AssemblyDescription + Environment.NewLine +
                Environment.NewLine + "Changelog:" + Environment.NewLine + Environment.NewLine +
                "v3.1.0.0 by Jason Hood" + Environment.NewLine +
                "- Add the GPLv3 license file" + Environment.NewLine +
                "- Replace 'Suchen' with 'Search'" + Environment.NewLine +
                "- Restore the cursor on leaving the preview" + Environment.NewLine +
                "- Tweak tree labels" + Environment.NewLine +
                "- Support for 'alias'" + Environment.NewLine +
                "- Add skin path if file doesn't exist" + Environment.NewLine +
                "- Disable 'Save As'" + Environment.NewLine +
                "- Allow Escape to reset the search" + Environment.NewLine +
                "- Support 'include' and 'panel' layout" + Environment.NewLine +
                "- Set resolution exactly, starting zoomed" + Environment.NewLine +
                "- Recognise undefined background color in properties" + Environment.NewLine +
                "- Fix typo in event duration converter" + Environment.NewLine +
                "- Use bright magenta (#ff00ff) for undefined colors" + Environment.NewLine +
                "- Recognise relative elements" + Environment.NewLine +
                "- Add 'ShortFullDate' converter" + Environment.NewLine +
                "- Fix setting colors" + Environment.NewLine +
                "- Fix conditional labels" + Environment.NewLine + Environment.NewLine +
                "v3.1.0.1 by Humax" + Environment.NewLine +
                "- Swapped tooltips 'Undo' and 'Delete Element' " + Environment.NewLine +
                "- 'Open Project' - dialog adapted" + Environment.NewLine +
                "- Bug fix - Zooming is only possible if a skin was loaded" + Environment.NewLine +
                // "- Bug fix - MinimumValue 'Trackbar' and 'NumericUpDown'" + Environment.NewLine +
                "- 'File' 'Open' - Button stays active even a skin was loaded" + Environment.NewLine +
                "- Tree-Image-Icon 'skin' fixed" + Environment.NewLine +
                "- Support for 'KravenFHDEventTime'" + Environment.NewLine +
                "- Bug fix in Fonts-Dialog (renaming Fonts-Name in ListView is no more possible - as it should be!)" + Environment.NewLine +
                "- Set minimum window-size's and don't allow to minimize / maximize the windows" + Environment.NewLine +
                "- Fixed 'Save as...'-Dialog" + Environment.NewLine +
                "- Support FHD-background-image (idea from digiteng)" + Environment.NewLine +
                "- Using variables for 'size' and 'position'" + Environment.NewLine +
                "- If a color has been defined twice, you can now decide if the color should be removed (recommended)." + Environment.NewLine +
                "  This will save the skin and reload it. Otherwise, the color will be removed if you save it manually," + Environment.NewLine +
                "  but in this case the color will be preserved in the Treeview until you reload!" + Environment.NewLine + Environment.NewLine +
                "v3.1.0.2 by Humax" + Environment.NewLine +
                "- Fixed font preview (a text box cannot display the font correctly, a picturebox can!)" + Environment.NewLine +
                "- Fixed unhandled exception when trying to save in Codeeditor when no line is selected" + Environment.NewLine +
                "- Fixed a bug that prevented searching for the specified fonts in the skin folder." + Environment.NewLine +
                "- Added Sliders in 'Color Settings Dialog' to adjust values for ARGB" + Environment.NewLine +
                "- Fixed some unhandled exceptions / bugs in 'Color Settings Dialog' - when no Color is selected or spaces are used in names" + Environment.NewLine +
                "- Fixed the 'remove'-color button in 'Color Settings Dialog' (previously it had no function)" + Environment.NewLine +
                "- In 'Color Settings Dialog' when choosing a color via Palette, the transparency is set to '0'" + Environment.NewLine +
                "- Fixed a bug that prevented searching for the specified fonts in the skin folder." + Environment.NewLine + Environment.NewLine +
                "v3.1.0.3 by Scrounger" + Environment.NewLine +
                "- Fonts: loading size from xml implemented" + Environment.NewLine +
                "- Loading predefined fonts from <fonts> added" + Environment.NewLine +
                "- Converter bug fixes: name ServiceX added - Exception in VerticalEPGView_FHD" + Environment.NewLine +
                "- Show dummy text for rendered elements added" + Environment.NewLine +
                "- Converter bug fix for AudioZap" + Environment.NewLine +
                "- Show dummy text for rendered elements " + Environment.NewLine +
                "- Show name or source attribute if available" + Environment.NewLine +
                "- Screen has not title attribute, fallback to name attribute" + Environment.NewLine +
                "- Render VRunningText added" + Environment.NewLine +
                "- Render MetrixReloadedScreenNameLabel added" + Environment.NewLine +
                "- Show picon bug fixed" + Environment.NewLine + Environment.NewLine +
                "v3.2.0.0 by Scrounger" + Environment.NewLine +
                "- Converter: support for 'FullDescription' added" + Environment.NewLine +
                "- resize picon on element size change" + Environment.NewLine +
                "- Use attribute scale for ePixmap & widget which have 'pixmap' attribute." + Environment.NewLine +
                "- Converter MovieInfo added" + Environment.NewLine +
                "- show images for widgets wiht any render and 'path' attribute" + Environment.NewLine +
                "- show EventImage if render attribute contains 'eventimage'" + Environment.NewLine +
                "- show XHDPicon if render attribute contains 'xhdpicon'" + Environment.NewLine +
                "- show images with 'pixmaps' attribute" + Environment.NewLine;
        }

        #region Assemblyattributaccessoren

        public string AssemblyTitle
        {
            get
            {
                object[] attributes = Assembly.GetExecutingAssembly().GetCustomAttributes(typeof(AssemblyTitleAttribute), false);
                if (attributes.Length > 0)
                {
                    AssemblyTitleAttribute titleAttribute = (AssemblyTitleAttribute)attributes[0];
                    if (titleAttribute.Title != "")
                    {
                        return titleAttribute.Title;
                    }
                }
                return System.IO.Path.GetFileNameWithoutExtension(Assembly.GetExecutingAssembly().CodeBase);
            }
        }

        public string AssemblyVersion
        {
            get
            {
                return Assembly.GetExecutingAssembly().GetName().Version.ToString();
            }
        }

        public string AssemblyDescription
        {
            get
            {
                object[] attributes = Assembly.GetExecutingAssembly().GetCustomAttributes(typeof(AssemblyDescriptionAttribute), false);
                if (attributes.Length == 0)
                {
                    return "";
                }
                return ((AssemblyDescriptionAttribute)attributes[0]).Description;
            }
        }

        public string AssemblyProduct
        {
            get
            {
                object[] attributes = Assembly.GetExecutingAssembly().GetCustomAttributes(typeof(AssemblyProductAttribute), false);
                if (attributes.Length == 0)
                {
                    return "";
                }
                return ((AssemblyProductAttribute)attributes[0]).Product;
            }
        }

        public string AssemblyCopyright
        {
            get
            {
                object[] attributes = Assembly.GetExecutingAssembly().GetCustomAttributes(typeof(AssemblyCopyrightAttribute), false);
                if (attributes.Length == 0)
                {
                    return "";
                }
                return ((AssemblyCopyrightAttribute)attributes[0]).Copyright;
            }
        }

        public string AssemblyCompany
        {
            get
            {
                object[] attributes = Assembly.GetExecutingAssembly().GetCustomAttributes(typeof(AssemblyCompanyAttribute), false);
                if (attributes.Length == 0)
                {
                    return "";
                }
                return ((AssemblyCompanyAttribute)attributes[0]).Company;
            }
        }
        #endregion

        private void okButton_Click(object sender, EventArgs e)
        {

        }
    }
}
