using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TShockAPI;

namespace ChatAssistant
{
    class Players
    {
        public int Index = -1;
        public TSPlayer TSPlayer;
        public bool quitting = false;
        public bool InMenu = false;
        public Menu Menu;
        public int Channel = -1;
        public ChatMessage[] Log = new ChatMessage[50];
        public List<int> Ignores = new List<int>();
        public PlayerSettings Flags = 0;
    }
}

