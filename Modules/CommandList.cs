using Discord;
using Discord.Commands;
using System.Threading.Tasks;

namespace HoloLiveBot.Modules
{
    public class CommandList : ModuleBase
    {
        [Command("help")]
        public async Task info()
        {
            var embed = new EmbedBuilder();

            embed.WithTitle("Noms des commandes\n(>nom)")
                .WithDescription("Live\nRanked\n...")
                .WithColor(Color.Blue);

            await ReplyAsync("", false, embed.Build());
        }
    }
}
