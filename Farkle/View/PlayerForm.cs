using FarkleLib;
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text.RegularExpressions;
using System.Threading;
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
            add { btnStart.Click += value; }
            remove { btnStart.Click -= value; }
        }

        public event EventHandler BtnAddPlayer
        {
            add { btnSave.Click += value; }
            remove { btnSave.Click -= value; }
        }

        public event CancelEventHandler NameValidatingPlayer1
        {
            add { textNameP1.Validating += value; }
            remove { textNameP1.Validating -= value; }
        }

        public event CancelEventHandler NameValidatingPlayer2
        {
            add { textNameP2.Validating += value; }
            remove { textNameP2.Validating -= value; }
        }

        public event EventHandler NameValidatedPlayer1
        {
            add { textNameP1.Validated += value; }
            remove { textNameP1.Validated -= value; }
        }

        public event EventHandler NameValidatedPlayer2
        {
            add { textNameP2.Validated += value; }
            remove { textNameP2.Validated -= value; }
        }

        public event EventHandler ComboLang
        {
            add { comboBox1.SelectedIndexChanged += value; }
            remove { comboBox1.SelectedIndexChanged -= value; }
        }

        /// <summary>
        /// Verifies if input name is not empty or doesn't contain numbers.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void ValidateNamePlayer1(object sender, CancelEventArgs e)
        {
            //Regex.IsMatch(textNameP1.Text, @"^[a-zA-Z]+$")
            if (String.IsNullOrWhiteSpace(textNameP1.Text))
            {
                errorProvider1.SetError((TextBox)sender, 
                    $"ERROR: Enter your name without any space, numbers or symbols.");
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
        /// Verifies if input name is not empty or doesn't contain numbers.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void ValidateNamePlayer2(object sender, CancelEventArgs e)
        {
            //Regex.IsMatch(textNameP1.Text, @"^[a-zA-Z]+$")
            if (String.IsNullOrWhiteSpace(textNameP2.Text))
            {
                errorProvider1.SetError((TextBox)sender,
                    $"ERROR: Enter your name without any space, numbers or symbols.");
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

        /// <summary>
        /// Binds textNameP1 to property Name of Player 1.
        /// </summary>
        /// <param name="b"></param>
        public void SetP1NameDataBinding(Binding b)
        {
            textNameP1.DataBindings.Add(b);
        }

        /// <summary>
        /// Binds textNameP1 to property Name of Player 2.
        /// </summary>
        /// <param name="b"></param>
        public void SetP2NameDataBinding(Binding b)
        {
            textNameP2.DataBindings.Add(b);
        }

        /// <summary>
        /// Enables the Play button.
        /// </summary>
        public void ShowPlayButton()
        {
            btnStart.Enabled = true;
        }

        /// <summary>
        /// Add a player to the list of players.
        /// </summary>
        /// <param name="list"></param>
        /// <param name="p"></param>
        public void AddPlayer(List<IPlayer> list, IPlayer p)
        {
            list.Add(p);
        }

        /// <summary>
        /// Adds languages to ComboBox.
        /// </summary>
        /// <param name="lang"></param>
        public void AddLangCombo(string lang)
        {
            comboBox1.Items.Add(lang);
        }

        /// <summary>
        /// Changes the language in the UI.
        /// </summary>
        public void ChangeLang()
        {
            switch (comboBox1.SelectedIndex)
            {
                case 0:
                    Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo("fr");
                    break;

                case 1:
                    Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo("en");
                    break;

                default:
                    break;
            }
            this.Controls.Clear();
            InitializeComponent();
        }
    }
}
