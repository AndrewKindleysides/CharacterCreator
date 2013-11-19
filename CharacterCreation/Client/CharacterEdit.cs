using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Characters;
using DataAccessLayer;

namespace Client
{
    public partial class CharacterEdit : Form
    {
        private Character _character;
        private DataAccess _dataAccess;

        public CharacterEdit(Character character)
        {
            InitializeComponent();
            _character = character;
            _dataAccess = new DataAccess();
        }

        private void CharacterEdit_Load(object sender, EventArgs e)
        {
            nameTextbox.Text = _character.Name;
            raceDropdown.Text = _character.Race.Name;
            classDropdown.Text = _character.Class.Name;
            critTextBox.Text = _character.Crit.ToString();
            hitTextBox.Text = _character.Hit.ToString();
            staminaTextBox.Text = _character.Stamina.ToString();
            defenceTextBox.Text = _character.Defence.ToString();
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            _character.Name = nameTextbox.Text;
            _character.Race.Name = raceDropdown.Text;
            _character.Class.Name = classDropdown.Text;

            _character.Crit = Convert.ToInt32(critTextBox.Text);
            _character.Hit = Convert.ToInt32(hitTextBox.Text);
            _character.Stamina = Convert.ToInt32(staminaTextBox.Text);
            _character.Defence = Convert.ToInt32(defenceTextBox.Text);
            
            _dataAccess.Update(_character);
            Close();
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            _dataAccess.Delete(_character.Id);
            Close();
        }

        private void raceDropdown_SelectedIndexChanged(object sender, EventArgs e)
        {
            raceIcon.ImageLocation = string.Format("./icons/race/{0}.png", raceDropdown.Text);
        }

        private void classDropdown_SelectedIndexChanged(object sender, EventArgs e)
        {
            classIcon.ImageLocation = string.Format("./icons/class/{0}.png", classDropdown.Text);
        }
    }
}
