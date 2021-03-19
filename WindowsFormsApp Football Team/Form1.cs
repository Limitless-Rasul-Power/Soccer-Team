using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp_Football_Team
{
    public partial class Form1 : Form
    {
        private readonly List<string> _cultureList = CountriesHelper.GetAllCountries();
        private readonly Dictionary<string, string> _countriesNameAndCodes = CountriesHelper.GetCountriesNameAndCode();
        private readonly List<string> _alignments = new List<string> { "4-4-2", "4-3-3", "5-3-2" };
        private readonly List<TeamPlayerControl> _teamPlayerControls = new List<TeamPlayerControl>();
        private int _currentY = default;

        private readonly List<Player> _players = new List<Player>();

        public Form1()
        {
            InitializeComponent();
            CountriesCmbBx.DataSource = _cultureList;
            AlignmentCmbBx.DataSource = _alignments;
        }

        private void ConfigureUserControls(string alignment)
        {
            for (int i = 0; i < _teamPlayerControls.Count; i++)
                Controls.Remove(_teamPlayerControls[i]);

            _teamPlayerControls.Clear();

            var alignmentNumbers = new List<int>();

            foreach (var number in alignment.Split('-'))
            {
                alignmentNumbers.Add(Convert.ToInt32(number));
            }

            _currentY = PositionNameLbl.Location.Y - 40;

            for (int i = 0; i < TeamPlayerControl.NumberOfPlayersExceptGoalKeeper; i++)
            {

                _currentY += 50;

                _teamPlayerControls.Add(new TeamPlayerControl());

                _teamPlayerControls[i].Location = new Point(205, _currentY);

                if (i < alignmentNumbers[2])
                    _teamPlayerControls[i].PositionName = PositionNames.Forward;
                else if (i >= alignmentNumbers[2] && i < alignmentNumbers[1] + alignmentNumbers[2])
                    _teamPlayerControls[i].PositionName = PositionNames.MiddleForward;
                else
                    _teamPlayerControls[i].PositionName = PositionNames.Back;

                Controls.Add(_teamPlayerControls[i]);

            }

            _currentY += 50;
            _teamPlayerControls.Add(new TeamPlayerControl());
            _teamPlayerControls[_teamPlayerControls.Count - 1].PositionName = PositionNames.GoalKeeper;
            _teamPlayerControls[_teamPlayerControls.Count - 1].Location = new Point(205, _currentY);
            Controls.Add(_teamPlayerControls[_teamPlayerControls.Count - 1]);
            _currentY += 80;

            GenerateGradBtn.Location = new Point(728, _currentY);
            GenerateGradBtn.Visible = true;
        }
        private void AlignmentCmbBx_SelectedIndexChanged(object sender, EventArgs e)
        {
            ConfigureUserControls(AlignmentCmbBx.SelectedItem as string);
        }

        private void GenerateGradBtn_MouseHover(object sender, EventArgs e)
        {
            GenerateGradBtn.FillColor = Color.FromArgb(185, 43, 39);
            GenerateGradBtn.FillColor2 = Color.FromArgb(21, 101, 192);
        }

        private void GenerateGradBtn_MouseLeave(object sender, EventArgs e)
        {
            GenerateGradBtn.FillColor = Color.FromArgb(21, 101, 192);
            GenerateGradBtn.FillColor2 = Color.FromArgb(185, 43, 39);
        }

        private bool IsAnyTeamMemberNumberOverlapsWithAnotherTeamMember()
        {
            for (int i = 0; i < _teamPlayerControls.Count; i++)
            {
                for (int j = 0; j < _teamPlayerControls.Count; j++)
                {
                    if (_teamPlayerControls[i].PlayerNumber == _teamPlayerControls[j].PlayerNumber && i != j)
                    {
                        MessageBox.Show($"{_teamPlayerControls[j].PlayerName} contains same number with team member {_teamPlayerControls[i].PlayerName}, Please change.");
                        return true;
                    }
                }
            }
            return false;
        }
        private void GenerateGradBtn_Click(object sender, EventArgs e)
        {
            TeamPlayerControl tpc = _teamPlayerControls.Find(tp => tp.PlayerNumber == -1);
            if (tpc != null)
            {
                if (!string.IsNullOrWhiteSpace(tpc.PlayerName))
                    MessageBox.Show($"{tpc.PlayerName} doesn't contain any number, please assign it.");
                else
                    MessageBox.Show($"Your team member doesn't contain any number, please assign it.");

                return;
            }

            if (!IsAnyTeamMemberNumberOverlapsWithAnotherTeamMember())
            {
                _players.Clear();

                for (int i = 0; i < _teamPlayerControls.Count; i++)
                {
                    _players.Add
                        (

                            new Player
                            {
                                Number = _teamPlayerControls[i].PlayerNumber,
                                Name = _teamPlayerControls[i].PlayerName
                            }

                        );
                }

                this.Hide();
                Form2 form = new Form2();
                string alignment = AlignmentCmbBx.SelectedItem as string;

                string countryCode = _countriesNameAndCodes[CountriesCmbBx.SelectedItem as string];

                DialogResult result = form.ShowDialog(_players, alignment, new List<string> { countryCode, CountriesCmbBx.SelectedItem as string });

                if (result == DialogResult.Cancel)
                {

                    form.Close();
                    this.Show();
                }


            }

        }

        private void ExitBtn_MouseHover(object sender, EventArgs e)
        {            
            ExitBtn.FillColor = ColorTranslator.FromHtml("#f20505");
        }

        private void ExitBtn_MouseLeave(object sender, EventArgs e)
        {
            ExitBtn.FillColor = Color.Transparent;
        }

        private void ExitBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();            
        }
    }
}
