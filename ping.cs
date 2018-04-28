using Discord;
using Discord.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace RoseBOT.Modules
{
    public class Ping : ModuleBase<SocketCommandContext>
    {
        Random rand = new Random();

        string[] pics = new string[]
        {
            #region
            "../../Pictures/a.jpg",
            "../../Pictures/b.jpg",
            "../../Pictures/c.jpg",
            "../../Pictures/d.jpg",
            "../../Pictures/e.jpg",
            "../../Pictures/f.jpg",
            "../../Pictures/g.jpg",
            "../../Pictures/h.jpg",
            "../../Pictures/i.jpg",
            "../../Pictures/j.jpg",
            "../../Pictures/k.jpg",
            "../../Pictures/l.jpg",
            "../../Pictures/m.jpg",
            "../../Pictures/n.jpg",
            "../../Pictures/o.jpg",
            "../../Pictures/p.jpg",
            "../../Pictures/q.jpg",
            "../../Pictures/r.jpg",
            "../../Pictures/s.jpg",
            "../../Pictures/t.jpg",
            "../../Pictures/u.jpg",
            "../../Pictures/v.jpg",
            "../../Pictures/w.jpg",
            "../../Pictures/x.jpg",
            "../../Pictures/y.jpg",
            "../../Pictures/z.jpg",
            "../../Pictures/1.jpg",
            "../../Pictures/2.jpg",
            "../../Pictures/3.jpg",
            "../../Pictures/4.jpg",
            "../../Pictures/5.jpg",
            "../../Pictures/6.jpg",
            "../../Pictures/7.jpg",
            "../../Pictures/8.jpg",
            "../../Pictures/9.jpg",
            "../../Pictures/10.jpg",
            "../../Pictures/11.jpg",
            "../../Pictures/12.jpg",
            "../../Pictures/13.jpg",
            "../../Pictures/14.jpg",
            "../../Pictures/15.jpg",
            "../../Pictures/16.jpg",
            "../../Pictures/17.jpg"
            #endregion

        };

        [Command("Rose")]
        public async Task PingAsync()
        //public async Task PingAsync(string name = "Greg")
      //  public async Task PingAsync([Remainder] string stuffToSay)
        {
            // await ReplyAsync("Hello World");


            //   EmbedBuilder builder = new EmbedBuilder();
            /*
                                    builder.WithTitle("Ping!")
                                        .WithDescription("This is a really nice ping!")
                                        .WithColor(Color.Blue);

                        builder.AddField("Field1", "test")
                            .AddInlineField("field2", "test")
                            .AddInlineField("field3", "test");

                        //Context.User;
                        //Context.Client;
                        //Context.Guild;
                        //Context.Message;
                        //Context.Channel;

                        await ReplyAsync("", false, builder.Build());

            */

            // await ReplyAsync($"{Context.Client.CurrentUser.Mention} || {Context.User.Mention} sent {Context.Message.Content} in {Context.Guild.Name}!");

            //await ReplyAsync($"{name} is a tool");
           // await ReplyAsync(stuffToSay);
            int random = rand.Next(pics.Length);
            await Context.Channel.SendFileAsync(pics[random]);       
        }
    }
}
