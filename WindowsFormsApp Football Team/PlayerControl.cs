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
    public partial class PlayerControl : UserControl
    {
        public PlayerControl()
        {
            InitializeComponent();
        }

        public void SetGoalKeeperImageAndBackColorOfNumber(string path)
        {
            if (!string.IsNullOrWhiteSpace(path))
            {
                PlayerPctBx.Image = new Bitmap(path);
                NumberLbl.BackColor = Color.Red;
            }
            else
                throw new InvalidOperationException("Path is invalid");
        }
        public void SetPlayerName(string name)
        {
            if (!string.IsNullOrWhiteSpace(name))
                NameLbl.Text = name;
        }

        public void SetPlayerNumber(int number)
        {
            if (number > 0 && number < 100)
                NumberLbl.Text = $"{number}";
        }


    }
}
