namespace Tennis.Score
{
    public partial class Form1 : Form
    {
        private static Dictionary<string, int> playersWithPoints = new()
        {
            {"R. Federer", 4},
            {"G. Dimitrov", 5},
            {"R. Nadal", 6}
        };

        private static Dictionary<(string, int), List<(string, int)>> games = new()
        {
            { ("G. Dimitrov", 3), new List<(string, int)>{("R. Nadal", 2) } },
            { ("G. Dimitrov", 1), new List<(string, int)>{("R. Federer", 3) } },
            
        };

        private void OnLoad(object sender, EventArgs e)
        {
            FillRankingListView();
            FillLatestGamesListView();
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void FillRankingListView()
        {
            this.listView1.Items.Clear();

            foreach (var player in playersWithPoints.OrderByDescending(x => x.Value))
            {
                string playerName = player.Key;
                string playerPoints = player.Value.ToString();

                ListViewItem rollInRankingListView = new ListViewItem();

                rollInRankingListView.SubItems[0].Text = playerName;
                rollInRankingListView.SubItems.Add(playerPoints);

                this.listView1.Items.Add(rollInRankingListView);
            }
        }

        private void FillLatestGamesListView()
        {
            this.listView2.Items.Clear();

            foreach (var game in games.Reverse())
            {
                foreach (var item in game.Value)
                {
                    FillListView(game.Key, item);
                }
            }
        }

        private void FillListView((string, int) firstPlayer, (string, int) secondPlayer)
        {
            string winner = GetWinner(firstPlayer, secondPlayer);

            ListViewItem rollInLatestGamesListView = new ListViewItem();

            rollInLatestGamesListView.SubItems[0].Text = firstPlayer.Item1;
            rollInLatestGamesListView.SubItems.Add(secondPlayer.Item1);
            rollInLatestGamesListView.SubItems.Add(winner);
            rollInLatestGamesListView.SubItems.Add($"{firstPlayer.Item2} - {secondPlayer.Item2}");

            this.listView2.Items.Add(rollInLatestGamesListView);
        }

        private string GetWinner((string, int) firstPlayer, (string, int) secondPlayer)
        {
            if (firstPlayer.Item2 > secondPlayer.Item2)
            {
                return firstPlayer.Item1;
            }
            else if (firstPlayer.Item2 < secondPlayer.Item2)
            {
                return secondPlayer.Item1;
            }

            return "Draw";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (NewGameForm newGameForm = new NewGameForm())
            {
                if (newGameForm.ShowDialog() == DialogResult.OK)
                {
                    AddNewGame(newGameForm.FirstPlayer, newGameForm.SecondPlayer);
                }
            }
        }

        private void AddNewGame((string, int) firstPlayer, (string, int) secondPlayer)
        {
            FillGameData(firstPlayer, secondPlayer);

            FillPlayersWithPoints(firstPlayer);
            FillPlayersWithPoints(secondPlayer);

            FillRankingListView();
            FillLatestGamesListView();
        }

        private void FillGameData((string, int) firstPlayer, (string, int) secondPlayer)
        {
            if (games.ContainsKey(firstPlayer))
            {
                games[firstPlayer].Add(secondPlayer);
            }
            else if (games.ContainsKey(secondPlayer))
            {
                games[secondPlayer].Add(firstPlayer);
            }
            else
            {
                games.Add(firstPlayer, new List<(string, int)> { secondPlayer });
            }
        }

        private void FillPlayersWithPoints((string, int) player)
        {
            if (playersWithPoints.ContainsKey(player.Item1))
            {
                playersWithPoints[player.Item1] += player.Item2;
            }
            else
            {
                playersWithPoints[player.Item1] = player.Item2;
            }
        }

        private void listView1_DoubleClick(object sender, EventArgs e)
        {
            ListViewItem selectedRow = this.listView1.SelectedItems[0];

            ListViewItem.ListViewSubItem playerNameCell = selectedRow.SubItems[0];

            string playerName = playerNameCell.Text;

            using (PlayerInfoForm playerInfoForm = new PlayerInfoForm
                (playerName, GetPlayerGames(playerName)))
            {
                playerInfoForm.ShowDialog();
            }
        }

        private Dictionary<(string, int), List<(string, int)>> GetPlayerGames
            (string playerName)
            => games.Where(x => x.Key.Item1 == playerName
            || x.Value.Any(y => y.Item1 == playerName))
            .ToDictionary(x => x.Key, x => x.Value.Where(y => y.Item1 == playerName
            || x.Key.Item1 == playerName).ToList());
    }
}
