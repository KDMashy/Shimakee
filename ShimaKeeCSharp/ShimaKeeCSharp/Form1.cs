using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ShimaKeeCSharp.entity;
using ShimaKeeCSharp.entity.npc;

namespace ShimaKeeCSharp
{
    public partial class Form1 : Form
    {
        private NPCFunctions npcFunc;
        private PlayerFunctions playerFunc;
        private EnemyFunctions enemyFunc;
        private Player sessionPlayer;
        private List<NPC> sessionNPCList;
        public Form1()
        {
            InitializeComponent();
            npcFunc = new NPCFunctions();
            playerFunc = new PlayerFunctions();
            enemyFunc = new EnemyFunctions();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            //véletlen volt...
        }

        private void CreateNewButton_Click(object sender, EventArgs e)
        {
            this.LoadGameButton.Enabled = false;
            this.ExitFromGameButton.Enabled = false;
            this.CreateNewButton.Enabled = false;
            this.CreateNewPlayerPanel.Visible = true;
        }

        private void LoadGameButton_Click(object sender, EventArgs e)
        {
            this.CreateNewButton.Enabled = false;
            this.ExitFromGameButton.Enabled = false;
            this.LoadGameButton.Enabled = false;
            this.LoadCharactersPanel.Visible = true;
            List<Player> newPlayers = playerFunc.LoadPlayers();
            foreach (Player random in newPlayers)
            {
                this.CharactersListBoxForLoad.Items.Add(random.Name);
            }
        }

        private void CancelCreationButton_Click(object sender, EventArgs e)
        {
            this.LoadGameButton.Enabled = true;
            this.ExitFromGameButton.Enabled = true;
            this.CreateNewButton.Enabled = true;
            this.CreateNewPlayerPanel.Visible = false;
        }

        private void LoadCancelButton_Click(object sender, EventArgs e)
        {
            this.CreateNewButton.Enabled = true;
            this.ExitFromGameButton.Enabled = true;
            this.LoadGameButton.Enabled = true;
            this.LoadCharactersPanel.Visible = false;
            this.CharactersListBoxForLoad.Items.Clear();
        }

        private void ExitFromGameButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CreateCharacterButton_Click(object sender, EventArgs e)
        {
            Player player = new Player(
                this.PlayerNameTextBoxCreation.Text,
                400,
                50,
                25,
                0,
                0);
            this.PlayerNameTextBoxCreation.Text = "";
            playerFunc.CreatePlayer(player);
            sessionPlayer = player;
            sessionNPCList = npcFunc.ReadNPC(sessionPlayer);
            this.LoadGameButton.Enabled = true;
            this.ExitFromGameButton.Enabled = true;
            this.CreateNewButton.Enabled = true;
            this.CreateNewPlayerPanel.Visible = false;
            this.GameMenuOptions.Visible = false;
            UpdateGame();
            this.GAMEPANEL.Visible = true;
        }

        private void SAVEANDLOGOUTB_Click(object sender, EventArgs e)
        {
            playerFunc.SavePlayer(sessionPlayer, sessionNPCList);
            sessionPlayer = null;
            sessionNPCList = null;
            this.GameMenuOptions.Visible = true;
            this.GAMEPANEL.Visible = false;
        }

        private void DeleteCharacterButton_Click(object sender, EventArgs e)
        {
            List<Player> players = playerFunc.LoadPlayers();
            foreach (Player character in players)
            {
                if (character.Name.Equals(this.CharactersListBoxForLoad.SelectedItem.ToString()))
                {
                    playerFunc.DeletePlayer(character);
                    break;
                }
            }
            this.CharactersListBoxForLoad.Items.Clear();
            players = playerFunc.LoadPlayers();
            foreach (Player random in players)
            {
                this.CharactersListBoxForLoad.Items.Add(random.Name);
            }
        }

        private void LoadCharacterButton_Click(object sender, EventArgs e)
        {
            List<Player> players = playerFunc.LoadPlayers();
            foreach (Player character in players)
            {
                if (character.Name.Equals(this.CharactersListBoxForLoad.SelectedItem.ToString()))
                {
                    sessionPlayer = character;
                    sessionNPCList = npcFunc.ReadNPC(sessionPlayer);
                    break;
                }
            }
            this.CharactersListBoxForLoad.Items.Clear();
            this.CreateNewButton.Enabled = true;
            this.LoadGameButton.Enabled = true;
            this.ExitFromGameButton.Enabled = true;
            this.LoadCharactersPanel.Visible = false;
            this.GameMenuOptions.Visible = false;
            UpdateGame();
            this.GAMEPANEL.Visible = true;
        }

        private void UpdateGame()
        {
            if (sessionPlayer.Experience >= sessionPlayer.LvlCap)
            {
                sessionPlayer = playerFunc.LvlUp(sessionPlayer);
            }
            this.PlayerNameIG.Text = "Player: " + sessionPlayer.Name;
            this.PayerLvlIG.Text = "LvL: " + sessionPlayer.Lvl;
            this.PlayerXPIG.Text = "XP: " + sessionPlayer.Experience + " / " + sessionPlayer.LvlCap;
            this.PlayerHPIG.Text = "HP: " + sessionPlayer.Health;
            this.PlayerATKIG.Text = "ATK: " + sessionPlayer.Attack;
            this.PlayerDEFIG.Text = "DEF: " + sessionPlayer.Defense;
            this.PlayerMoneyIG.Text = "Money: " + sessionPlayer.Money;
        }

        private void MashironQuest_Click(object sender, EventArgs e)
        {
            throw new System.NotImplementedException();
        }

        private void ShiinaQuest_Click(object sender, EventArgs e)
        {
            throw new System.NotImplementedException();
        }

        private void RakuQuest_Click(object sender, EventArgs e)
        {
            throw new System.NotImplementedException();
        }

        private void KaedeQuest_Click(object sender, EventArgs e)
        {
            throw new System.NotImplementedException();
        }

        private void ChiQuest_Click(object sender, EventArgs e)
        {
            throw new System.NotImplementedException();
        }

        private void ShiroQuest_Click(object sender, EventArgs e)
        {
            throw new System.NotImplementedException();
        }

        private void KuroQuest_Click(object sender, EventArgs e)
        {
            throw new System.NotImplementedException();
        }

        private void HiroQuest_Click(object sender, EventArgs e)
        {
            throw new System.NotImplementedException();
        }

        private void QuestOneB_Click(object sender, EventArgs e)
        {
            throw new System.NotImplementedException();
        }

        private void QuestTwoB_Click(object sender, EventArgs e)
        {
            throw new System.NotImplementedException();
        }

        private void QuestThreeB_Click(object sender, EventArgs e)
        {
            throw new System.NotImplementedException();
        }

        private void QuestFourB_Click(object sender, EventArgs e)
        {
            throw new System.NotImplementedException();
        }

        private void QuestFiveB_Click(object sender, EventArgs e)
        {
            throw new System.NotImplementedException();
        }
    }
}