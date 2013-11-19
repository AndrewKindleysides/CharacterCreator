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
    public partial class MainWindow : Form
    {
        public Character _selectedCharacter { get; set; }

        public DataAccess _DataAccess { get; set; }

        public MainWindow()
        {
            InitializeComponent();
            _DataAccess = new DataAccess();
        }

        private void createButton_Click(object sender, EventArgs e)
        {
            var character = new Character()
            {
                CharacterId = Guid.NewGuid().ToString(),
                Name = nameBox.Text,
                Class = new Class() { Name = classListBox.Text},
                Race = new Race() { Name = raceListBox.Text},
                
                Stamina = Convert.ToInt32(staminaBox.Text),
                Defence = Convert.ToInt32(defenceBox.Text),
                Hit = Convert.ToInt32(hitBox.Text),
                Crit = Convert.ToInt32(critBox.Text),
                
                Inventory = new List<Item>()
                    {
                        new Item()
                        {
                            Name = "Sword",
                            Attack = 5,
                            Defence = 0
                        }
                    }
            };

            _DataAccess.Save(character);
            GridRefresh();
            GridRefresh();
            GridRefresh();
        }

        private void MainWindow_Load(object sender, EventArgs e)
        {
            raceListBox.SelectedIndex = 0;
            classListBox.SelectedIndex = 0;
            GridRefresh();
        }

        private void GridRefresh()
        {
            currentCharactersGrid.Rows.Clear();
            
            var results = _DataAccess.Load();
            foreach (var result in results)
            {
                currentCharactersGrid.Rows.Add(result.Name, result.Race.Name,result.Class.Name);
            }
            currentCharactersGrid.Update();
        }

        private void refreshButton_Click(object sender, EventArgs e)
        {
            GridRefresh();
        }

        private void currentCharactersGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            _selectedCharacter = _DataAccess.Load(currentCharactersGrid[0, e.RowIndex].Value.ToString()).FirstOrDefault();
            var characterEdit = new CharacterEdit(_selectedCharacter);
            characterEdit.ShowDialog();
            GridRefresh();
        }

        private void classListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            classIcon.ImageLocation = string.Format("./icons/class/{0}.png", classListBox.Text);
        }

        private void raceListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            raceIcon.ImageLocation = string.Format("./icons/race/{0}.png", raceListBox.Text);
        }
    }
}
