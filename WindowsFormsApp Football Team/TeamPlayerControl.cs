using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp_Football_Team
{
    public partial class TeamPlayerControl : UserControl
    {
        public const int NumberOfPlayersExceptGoalKeeper = 10;

        private string _positionName;
        private readonly List<string> _playerPositionColors = new List<string> { "#f40000", "#D1AC00", "#004643", "#38b000" };

        public TeamPlayerControl()
        {
            InitializeComponent();
        }

        public int PlayerNumber
        {
            get
            {
                if(!string.IsNullOrWhiteSpace(PlayerNumberTxtBx.Text))
                    return Convert.ToInt32(PlayerNumberTxtBx.Text);

                return -1;
            }            
        }
        public string PlayerName { get { return PlayerNameTxtBx.Text; }  }
        public string PositionName
        {
            get { return _positionName; }
            set
            {
                _positionName = value;
                PlayerPositionBtn.Text = value;
                ChangePlayerPositionBtnColor(value);
            }
        }

        private void ChangePlayerPositionBtnColor(string value)
        {

            if (value == PositionNames.Forward)
                PlayerPositionBtn.FillColor = ColorTranslator.FromHtml(_playerPositionColors[PositionIndexes.Forward]);
            else if (value == PositionNames.MiddleForward)
                PlayerPositionBtn.FillColor = ColorTranslator.FromHtml(_playerPositionColors[PositionIndexes.MiddleForward]);
            else if (value == PositionNames.Back)
                PlayerPositionBtn.FillColor = ColorTranslator.FromHtml(_playerPositionColors[PositionIndexes.Back]);
            else
                PlayerPositionBtn.FillColor = ColorTranslator.FromHtml(_playerPositionColors[PositionIndexes.GoalKeeper]);

        }

        private void PlayerNumberTxtBx_KeyPress(object sender, KeyPressEventArgs e)
        {        
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void PlayerNumberTxtBx_TextChanged(object sender, EventArgs e)
        {
            if (PlayerNumberTxtBx.Text.Length == 1 && PlayerNumberTxtBx.Text[0] == '0')
            {
                PlayerNumberTxtBx.Text = "";
            }

            else if (System.Text.RegularExpressions.Regex.IsMatch(PlayerNumberTxtBx.Text, "[^0-9]"))
            {                
                PlayerNumberTxtBx.Text = PlayerNumberTxtBx.Text.Remove(PlayerNumberTxtBx.Text.Length - 1);
            }
        }
    }
}
