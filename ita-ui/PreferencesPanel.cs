using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using iTunesAgent.UI.Properties;
using System.Threading;
using System.Globalization;

namespace iTunesAgent.UI
{
    public partial class PreferencesPanel : UserControl
    {
        public PreferencesPanel()
        {
            InitializeComponent();
            FillLanguages();
        }

        private void ChangeLanguage(string language)
        {
            if (Application.CurrentCulture.Parent.ToString() == new CultureInfo(language).Parent.ToString())
                return;
            Application.CurrentCulture = new CultureInfo(language);

            Settings.Default.Language = language;
            Settings.Default.Save();

            MessageBox.Show(Resources.StrRestartApplicationSoSettingsTakeEffect);
            Application.Exit();
        }

        private void FillLanguages()
        {
            cbxLanguage.Items.Clear();
            cbxLanguage.Items.Add(Resources.LangEnglish);
            cbxLanguage.Items.Add(Resources.LangGerman);
            if (Settings.Default.Language == "en-GB")
                cbxLanguage.SelectedIndex = 0;
            else if (Settings.Default.Language == "de-DE")
                cbxLanguage.SelectedIndex = 1;
            else
                cbxLanguage.SelectedIndex = 0;

        }

        private void cbxLanguage_SelectedIndexChanged(object sender, EventArgs e)
        {
            // this is not the "nice" way to do it. A "LanguageItem" class would be the best solution
            if (cbxLanguage.SelectedIndex == 0)
                ChangeLanguage("en-GB");
            if (cbxLanguage.SelectedIndex == 1)
                ChangeLanguage("de-DE");

        }


    }
}
