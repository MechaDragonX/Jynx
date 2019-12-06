using DSharpPlus;
using System;
using System.Threading.Tasks;

namespace Jynx
{
    class Program
    {
        static DiscordClient discord;

        static void Main(string[] args)
        {
            MainAsync(args).ConfigureAwait(false).GetAwaiter().GetResult();
        }
        static async Task MainAsync(string[] args)
        {
            discord = new DiscordClient(new DiscordConfiguration
            {
                Token = "<your token here>",
                TokenType = TokenType.Bot
            });

            await discord.ConnectAsync();
            await Task.Delay(-1);
        }
    }
}
