using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppSISAC.util
{
    public static class Util
    {
        public static void LimpiarTextBox(string NombrePage,TabControl tbControl)
        {
            foreach (TabPage page in tbControl.TabPages)
            {
                if (page.Name == NombrePage)
                {
                    foreach (Control obj in page.Controls)
                    {
                        if (obj is TextBox)
                        {
                            obj.Text = string.Empty;
                        }
                    }
                }
            }
        }

        public static void MensajeError(string mensaje)
        {
            MessageBox.Show(null, mensaje, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public static void MensajeExito(string mensaje)
        {
            MessageBox.Show(null, mensaje, "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public static void LlenarComboBox( ComboBox combo, string DisplayMember,string ValueMember)
        {
            combo.DisplayMember = DisplayMember;
            combo.ValueMember = ValueMember;
            
        }

    }
}
