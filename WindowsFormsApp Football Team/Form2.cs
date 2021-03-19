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
    public partial class Form2 : Form
    {
        private List<Coordinate> _coordinates = new List<Coordinate>();
        private readonly List<PlayerControl> _playersControls = new List<PlayerControl>();
        public Form2()
        {
            InitializeComponent();
        }


        public DialogResult ShowDialog(List<Player> players, string alignment, List<string> dataAboutCountry)
        {
            if (players != null)
            {
                JsonFileHelper.JSONDeSerialization(ref _coordinates, alignment);
                CountryPctBx.ImageLocation = $@"https://www.countryflags.io/{dataAboutCountry[0]}/shiny/64.png";
                this.Text = dataAboutCountry[1];


                for (int i = 0; i < TeamPlayerControl.NumberOfPlayersExceptGoalKeeper + 1; i++)
                {
                    _playersControls.Add(new PlayerControl());

                    _playersControls[i].SetPlayerName(players[i].Name);
                    _playersControls[i].SetPlayerNumber(players[i].Number);

                    _playersControls[i].Location = new Point(_coordinates[i].X, _coordinates[i].Y);


                    if (i < TeamPlayerControl.NumberOfPlayersExceptGoalKeeper + 1)
                        StadiumPctBx.Controls.Add(_playersControls[i]);
                }

                _playersControls[TeamPlayerControl.NumberOfPlayersExceptGoalKeeper].SetGoalKeeperImageAndBackColorOfNumber("../../Photos/Goal Keeper.png");

                StadiumPctBx.Controls.Add(_playersControls[TeamPlayerControl.NumberOfPlayersExceptGoalKeeper]);

                return ShowDialog();
            }

            throw new InvalidOperationException("Players are null");
        }

    }
}
