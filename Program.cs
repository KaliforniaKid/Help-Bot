using System;
using Discord;
using Discord.WebSocket;
using System.Threading.Tasks;


namespace Bot1
{
    public class Program
    {
        static void Main(string[] args)
       => new Program().StartAsync().GetAwaiter().GetResult();
    
        private DiscordSocketClient _client;

        private CommandHandler _handler;

        public async Task StartAsync()
        {
           
            _client = new DiscordSocketClient();

            await _client.LoginAsync(TokenType.Bot, "NDIxMjYzNDM4OTU5MDgzNTQw.DYS2lQ.-i37OIcFrRp1dSiJbV0NW2UYmYU");

            await _client.StartAsync();

            _handler = new CommandHandler(_client);

            await Task.Delay(-1);
        }
    }
}