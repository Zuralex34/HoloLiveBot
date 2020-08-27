using Discord.Commands;
using System.Threading.Tasks;
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Internal;
using System.Linq;

namespace HoloLiveBot.Modules.Database
{
    public class HoloRank : ModuleBase
    {
        [Command("hr")]
        public async Task CreateUser()
        {
            using (var ctx = new RankContext())
            {
                if (ctx.Database.GetPendingMigrations().Any())
                {
                    ctx.Database.Migrate();
                    ctx.SaveChanges();
                }
                var server = new Server
                {
                    ServerId = Context.Guild.Id
                };
                var user = new Player
                {
                    PlayerId = Context.User.Id,
                    Server = server
                };
                try
                {
                    if (ctx.Players.Any(x => x.PlayerId == Context.User.Id) == false)
                        ctx.Add(user);
                    if (ctx.Servers.Any(x => x.ServerId == Context.Guild.Id) == false)
                        ctx.Add(server);
                    ctx.SaveChanges();
                }
                catch (Exception e)
                {
                    Console.WriteLine($"Error set server {server.ServerId} or user {user.PlayerId}, {e.InnerException?.Message}");
                }

                foreach (var ply in ctx.Players)
                {
                    Console.WriteLine($"Server : {ply.Server.ServerId}\nPlayer : {ply.PlayerId}\n");
                }
            }
        }
    }
}
