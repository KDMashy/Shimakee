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

            foreach (NPC npc in sessionNPCList)
            {
                if (npc.Completed)
                {
                    if (npc.Name.Equals("Mashiron"))
                    {
                        this.MashironQuest.BackColor = Color.MediumSeaGreen;
                        this.MashironQuest.Enabled = false;
                    } else if (npc.Name.Equals("Shiina"))
                    {
                        this.ShiinaQuest.BackColor = Color.MediumSeaGreen;
                        this.ShiinaQuest.Enabled = false;
                    } else if (npc.Name.Equals("Raku"))
                    {
                        this.RakuQuest.BackColor = Color.MediumSeaGreen;
                        this.RakuQuest.Enabled = false;
                    } else if (npc.Name.Equals("Kaede"))
                    {
                        this.KaedeQuest.BackColor = Color.MediumSeaGreen;
                        this.KaedeQuest.Enabled = false;
                    } else if (npc.Name.Equals("Chi"))
                    {
                        this.ChiQuest.BackColor = Color.MediumSeaGreen;
                        this.ChiQuest.Enabled = false;
                    } else if (npc.Name.Equals("Shiro"))
                    {
                        this.ShiroQuest.BackColor = Color.MediumSeaGreen;
                        this.ShiroQuest.Enabled = false;
                    } else if (npc.Name.Equals("Kuro"))
                    {
                        this.KuroQuest.BackColor = Color.MediumSeaGreen;
                        this.KuroQuest.Enabled = false;
                    } else if (npc.Name.Equals("Hiro"))
                    {
                        this.HiroQuest.BackColor = Color.MediumSeaGreen;
                        this.HiroQuest.Enabled = false;
                    }
                }
            }
        }

        private int npcId;
        
        private void MashironQuest_Click(object sender, EventArgs e)
        {
            npcId = 0;
            questId = 1;
            AcceptNDoneNPCQuest(true, "Mashiron");
            FIGHTQUEST(questId, npcId);
        }

        private void ShiinaQuest_Click(object sender, EventArgs e)
        {
            npcId = 1;
            questId = 1;
            AcceptNDoneNPCQuest(true, "Shiina");
            FIGHTQUEST(questId, npcId);
        }

        private void RakuQuest_Click(object sender, EventArgs e)
        {
            npcId = 2;
            questId = 2;
            AcceptNDoneNPCQuest(true, "Raku");
            FIGHTQUEST(questId, npcId);
        }

        private void KaedeQuest_Click(object sender, EventArgs e)
        {
            npcId = 3;
            questId = 2;
            AcceptNDoneNPCQuest(true, "Kaede");
            FIGHTQUEST(questId, npcId);
        }

        private void ChiQuest_Click(object sender, EventArgs e)
        {
            npcId = 4;
            questId = 3;
            AcceptNDoneNPCQuest(true, "Chi");
            FIGHTQUEST(questId, npcId);
        }

        private void ShiroQuest_Click(object sender, EventArgs e)
        {
            npcId = 5;
            questId = 3;
            AcceptNDoneNPCQuest(true, "Shiro");
            FIGHTQUEST(questId, npcId);
        }

        private void KuroQuest_Click(object sender, EventArgs e)
        {
            npcId = 6;
            questId = 4;
            AcceptNDoneNPCQuest(true, "Kuro");
            FIGHTQUEST(questId, npcId);
        }

        private void HiroQuest_Click(object sender, EventArgs e)
        {
            npcId = 7;
            questId = 5;
            AcceptNDoneNPCQuest(true, "Hiro");
            FIGHTQUEST(questId, npcId);
        }

        private void AcceptNDoneNPCQuest(Boolean which, string name)
        {
            foreach (NPC entity in sessionNPCList)
            {
                if (entity.Name.Equals(name))
                {
                    if (which)
                    {
                        entity.Accepted = true;
                        break;
                    }
                    else
                    {
                        entity.Accepted = false;
                        entity.Completed = true;
                        break;
                    }
                }
            }
        }
        
        private float questId;
        
        private void QuestOneB_Click(object sender, EventArgs e)
        {
            questId = 1;
            npcId = -1;
            FIGHTQUEST(questId, npcId);
        }

        private void QuestTwoB_Click(object sender, EventArgs e)
        {
            questId = 2;
            npcId = -1;
            FIGHTQUEST(questId, npcId);
        }

        private void QuestThreeB_Click(object sender, EventArgs e)
        {
            questId = 3;
            npcId = -1;
            FIGHTQUEST(questId, npcId);
        }

        private void QuestFourB_Click(object sender, EventArgs e)
        {
            questId = 4;
            npcId = -1;
            FIGHTQUEST(questId, npcId);
        }

        private void QuestFiveB_Click(object sender, EventArgs e)
        {
            questId = 5;
            npcId = -1;
            FIGHTQUEST(questId, npcId);
        }

        private void FIGHTQUEST(float quest, int npcId)
        {
            List<Enemy> enemies = enemyFunc.LoadEnemy();
            List<Enemy> forFight = new List<Enemy>();
            foreach (Enemy entity in enemies)
            {
                if (entity.Quest == quest)
                {
                    enemyFunc.UpdateEnemy(entity, sessionPlayer);
                    forFight.Add(entity);
                }
            }

            this.QUESTLOGGINGPANEL.Visible = true;
            this.QUESTPANEL.Visible = false;
            this.NPCPANELFORQUEST.Visible = false;
            switch (quest)
            {
                case 1:
                    this.QandFQuestName.Text = "Quest 1";
                    break;
                case 2:
                    this.QandFQuestName.Text = "Quest 2";
                    break;
                case 3:
                    this.QandFQuestName.Text = "Quest 3";
                    break;
                case 4:
                    this.QandFQuestName.Text = "Quest 4";
                    break;
                case 5:
                    this.QandFQuestName.Text = "Quest 5";
                    break;
            }
            int countEnemy = 0;
            float enemyHp = forFight[countEnemy].Health;
            float playerHp = sessionPlayer.Health;
            float enemyAttack = forFight[countEnemy].Attack;
            float playerAttack = sessionPlayer.Attack;
            float playerDeffense = sessionPlayer.Defense;
            Boolean status = false;
            Enemy current = forFight[countEnemy];
            Random rnd = new Random();
            while (countEnemy < 3 || status == false)
            {
                if (countEnemy != 3)
                {
                    current = forFight[countEnemy];
                }
                enemyHp -= (playerAttack - (current.Defense - rnd.Next(0, Int32.Parse(current.Defense.ToString()))));
                if (enemyHp <= 0)
                {
                    enemyHp = 0;
                }
                this.QandFLoggingBox.Text += $"\nENEMY: {current.Name}, \nENEMY-HP: {enemyHp} / {current.Health}\n";
                if (enemyHp == 0)
                {
                    countEnemy++;
                    enemyHp = current.Health;
                    if (countEnemy == 3)
                    {
                        status = true;
                    }
                }
                else
                {
                    playerHp -= (enemyAttack - (playerDeffense - rnd.Next(0, Int32.Parse(playerDeffense.ToString()))));
                    if (playerHp <= 0)
                    {
                        playerHp = 0;
                    }
                    this.QandFLoggingBox.Text += $"\nPLAYER: {sessionPlayer.Name}, \nPLAYER-HP: {playerHp} / {sessionPlayer.Health}\n";
                    if (playerHp == 0)
                    {
                        status = false;
                        break;
                    }
                }
            }

            if (status == true)
            {
                float xpGive = 0;
                float moneyGive = 0;

                foreach (Enemy entity in forFight)
                {
                    xpGive += entity.experience;
                    moneyGive += entity.money;
                }

                sessionPlayer.Experience += xpGive;
                sessionPlayer.DefaultExp += xpGive;
                sessionPlayer.Money += moneyGive;

                if (npcId != -1)
                {
                    AcceptNDoneNPCQuest(false, sessionNPCList[npcId].Name);
                }
                this.QandFLoggingBox.Text += $"\nQUEST COMPLETED, GIVEN REWARDS:\nEXP: {xpGive}\nMONEY: {moneyGive}";
                this.QandFQuestName.Text += "\nCOMPLETED";
            }
            else
            {
                this.QandFLoggingBox.Text += "\nFAILED, NO REWARDS";
                this.QandFQuestName.Text += "\nFAILED";
            }
        }

        private void LEAVEQUESTB_Click(object sender, EventArgs e)
        {
            this.QUESTLOGGINGPANEL.Visible = false;
            this.QUESTPANEL.Visible = true;
            this.NPCPANELFORQUEST.Visible = true;
            this.QandFLoggingBox.Text = "";
            this.QandFQuestName.Text = "Questname";
            UpdateGame();
        }
    }
}