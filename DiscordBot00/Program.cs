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
            _client = new DiscordClient(x=>{
                x.AppName = "Discord Bot 00";
                x.AppUrl = "";
                x.AppVersion = "0.01";
                x.LogLevel = LogSeverity.Info;
                x.LogHandler = Log;
            });

            _client.UsingCommands(x=>{
                x.PrefixChar = '~';
                x.AllowMentionPrefix = true;
            });

            var token = "MjA0ODUyOTk1ODkxMDAzMzky.CndzAA.n4TL112_e4-ej8LnOrnMOJ-R6s4";

            CreateCommands();

            _client.ExecuteAndWait(async () => {
                await _client.Connect(token);
            });
        }

        public void CreateCommands()
        {
            var commandService = _client.GetService<CommandService>();
            commandService.CreateCommand("tosmap")
                .Do(async (e) =>
                {
                    await e.Channel.SendMessage("This command is not available right now because the dev is a shithole. Please commit sudoku, dev!!");
                });
        }

        public void Log(object sender, LogMessageEventArgs e)
        {
            //[INFO][DISCORD]Client connected
            Console.WriteLine($"[{e.Severity}][{e.Source}][{e.Message}]");
            
        }
    }
}
