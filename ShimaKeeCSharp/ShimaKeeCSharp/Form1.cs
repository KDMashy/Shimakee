﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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
        public Form1()
        {
            InitializeComponent();
            /*Player player = new Player("tesztP", 300, 25, 15, 1600, 0);
            NPC npc = new NPC("", false, false, player.Name);
            NPCFunctions npcf = new NPCFunctions();
            List<NPC> lista = npcf.ReadNPC(player);
            foreach (NPC npcp in lista)
            {
                testBox.Text += npcp.Name + npcp.Completed + "\n";
            }*/
        }
    }
}