using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace Farkle.View
{
    public partial class PlayerForm : Form, IPlayerForm
    {
        public PlayerForm()
        {
            InitializeComponent();
        }

        // Delegates
        public event EventHandler BtnPlay
        {
            add
            {
                btnStart.Click += value;
            }
            remove
            {
                btnStart.Click += value;
            }
        }

        public event EventHandler BtnSave
        {
            add
            {
                btnSave.Click += value;
            }
            remove
            {
                btnSave.Click -= value;
            }
        }

        public event CancelEventHandler NameValidating
        {
            add
            {
                textName.Validating += value;
            }
            remove
            {
                textName.Validating -= value;
            }
        }

        public event EventHandler NameValidated
        {
            add
            {
                textName.Validated += value;
            }
            remove
            {
                textName.Validated += value;
            }
        }

        /// <summary>
        /// Verifies if input name is not empty or doesn't contain numbers.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void ValidateName(object sender, CancelEventArgs e)
        {
            if (String.IsNullOrWhiteSpace(textName.Text))
            {
                errorProvider1.SetError((TextBox)sender, $"ERROR: Enter your name without any space or numbers.");
                btnSave.Enabled = false;
                e.Cancel = true;
            }
            else
            {
                btnSave.Enabled = true;
                e.Cancel = false;
            }
        }

        /// <summary>
        /// Clears the error provider.
        /// </summary>
        public void ClearErrorMessage()
        {
            errorProvider1.Clear();
        }
    }
}
