using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Discord;
using Discord.Commands;

namespace ZuramaruBot.Modules.YouTube
{
    public class HoloLiveLive : ModuleBase
    {
        [Command("hl")]
        public async Task Live()
        {
            var embed = new EmbedBuilder();

            embed.WithTitle("Utilisation des commandes HoloLive")
                .WithDescription("- °hl live : Liste des lives en cours.\n- °hl (prénom de la vtuber) : Affiche le live en cours si elle est en live.\n  (exemple : °hl pekora)")
                .WithColor(Color.Gold);
            await ReplyAsync("", false, embed.Build());
        }
    }
}
