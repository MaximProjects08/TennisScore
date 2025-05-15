using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tennis.Score
{
    public partial class NewGameForm : Form
    {
        public NewGameForm()
        {
            InitializeComponent();
        }

        public (string, int) FirstPlayer { get; set; }

        public (string, int) SecondPlayer { get; set; }

        private void ButtonSaveGameClick(object sender, EventArgs e)
        {
            string firstPlayerName = textBox1.Text.Trim();
            int firstPlayerPoints = (int)numericUpDown1.Value;

            string secondPlayerName = textBox2.Text.Trim();
            int secondPlayerPoints = (int)numericUpDown2.Value;

            FirstPlayer = (firstPlayerName, firstPlayerPoints);
            SecondPlayer = (secondPlayerName, secondPlayerPoints);

            if(!CheckIfInputsAreValid())
            {
                ValidateChildren(ValidationConstraints.Enabled);
                return;
            }
            this.DialogResult = DialogResult.OK;
        }

        private bool CheckIfInputsAreValid()
            => !checkIfPlayerNamesAreEmpty() && !checkIfPlayerNamesAreSame();

        private bool checkIfPlayerNamesAreEmpty()
            => string.IsNullOrEmpty(this.FirstPlayer.Item1) || string.IsNullOrEmpty(this.SecondPlayer.Item1);

        private bool checkIfPlayerNamesAreSame()
            => string.IsNullOrEmpty(this.FirstPlayer.Item1) || string.IsNullOrEmpty(this.SecondPlayer.Item1);


        private void ValidatePlayerName(object sender, CancelEventArgs e)
        {
            TextBox textBox = (TextBox)sender;

            if(string.IsNullOrWhiteSpace(textBox.Text))
            {
                e.Cancel = true;
                textBox.Focus();
                ShowEmptyErrorMessage(textBox);
            }
            else
            {
                e.Cancel = false;
                RemoveErrorMessages(textBox);
                ShowErrorOnSameNames();
            }
        }

        private void ShowEmptyErrorMessage(TextBox textBox)
        {
            var errorText = "Player Name should not be left blank!";

            if(textBox == this.textBox1)
            {
                this.errorProvider1.SetError(textBox, errorText); 
                this.textBox1.Text = "First " + errorText;
            }
            else if (textBox == this.textBox2)
            {
                this.errorProvider2.SetError(textBox, errorText);
                this.textBox2.Text = "Second " + errorText;
            }
        }

        private void RemoveErrorMessages(TextBox textBox)
        {
            if (textBox == this.textBox1)
            {
                this.errorProvider1.SetError(textBox, "");
                this.textBox1.Text = string.Empty;
            }
            else if (textBox == this.textBox2)
            {
                this.errorProvider2.SetError(textBox, "");
                this.textBox2.Text = string.Empty;
            }
        }
        private void ShowErrorOnSameNames()
        {
            if(checkIfPlayerNamesAreSame())
            {
                this.label5.Text = string.Empty;
            }
        }
    }
}
