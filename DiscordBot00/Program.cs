using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Discord;
using Discord.Commands;

namespace DiscordBot00
{
    class Program
    {
        static void Main(string[] args)
        {
            new Program().Start();
        }
        private DiscordClient _client;
        public void Start()
        {
            _client = new DiscordClient();
        }
    }
}
