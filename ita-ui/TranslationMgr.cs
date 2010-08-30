using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using System.Globalization;
using iTunesAgent.UI.Properties;
using System.Threading;
using System.ComponentModel;

namespace iTunesAgent.UI
{
    public class TranslationMgr
    {
        static public void Attach(Form form)
        {
            Attach(form as Control);
        }

        static public void Attach(UserControl control)
        {
            Attach(control as Control);
        }

        static protected void Attach(Control control)
        {
            if (Attached == null)
                Attached = new List<Control>();
            Attached.Add(control);
            control.VisibleChanged += HandleControl_VisibleChanged;
            if (control is ITranslatable)
                (control as ITranslatable).OnTranslate();
        }

        static public event EventHandler Translate;

        static public void RaiseTranslate()
        {
            if (Translate != null)
                Translate(null, EventArgs.Empty);
        }

        static protected void HandleControl_VisibleChanged(object sender, EventArgs e)
        {
            if (sender is Control && (sender as Control).Visible && (sender as Control).Tag != null && (sender as Control).Tag.ToString() == "pending")
            {
                ApplyTranslation(sender as Control);
            }
        }

        static protected void ApplyTranslation(Control parent)
        {
            if (parent == null)
                return;

            ComponentResourceManager resources = new ComponentResourceManager(parent.GetType());

            if (resources == null)
                return;

            resources.ApplyResources(parent, "$this");
            foreach (Control control in parent.Controls)
            {
                resources.ApplyResources(control, control.Name);
                if (control.Controls.Count > 0)
                    ApplyTranslation(control, parent);
            }
            if (parent is ITranslatable)
                (parent as ITranslatable).OnTranslate();
            parent.Tag = null;
        }

        static protected void ApplyTranslation(Control sub, Control parent)
        {
            if (parent == null)
                return;

            ComponentResourceManager resources = new ComponentResourceManager(parent.GetType());

            if (resources == null)
                return;

            foreach (Control control in sub.Controls)
            {
                resources.ApplyResources(control, control.Name);
                if (control.Controls.Count > 0)
                    ApplyTranslation(control, parent);
            }
            if (sub is ITranslatable)
                (sub as ITranslatable).OnTranslate();
        }

        static public void ChangeLanguage(string language)
        {
            if (Attached == null)
                return;

            if (Application.CurrentCulture.Parent.ToString() == new CultureInfo(language).Parent.ToString())
                return;
            Application.CurrentCulture = new CultureInfo(language);
            Thread.CurrentThread.CurrentUICulture = Application.CurrentCulture;

            Settings.Default.Language = language;
            Settings.Default.Save();

            foreach (var control in Attached)
            {
                control.Tag = "pending";
                if (control.Visible)
                    HandleControl_VisibleChanged(control, EventArgs.Empty);
            }
        }

        static public void Detach(Form form)
        {
            Detach(form as Control);
        }

        static public void Detach(UserControl control)
        {
            Detach(control as Control);
        }

        static protected void Detach(Control control)
        {
            control.VisibleChanged -= HandleControl_VisibleChanged;
            Attached.Remove(control);
        }

        static private List<Control> Attached { get; set; }

    }
}
