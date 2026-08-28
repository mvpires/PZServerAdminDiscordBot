using Discord.Commands;
using System.Threading.Tasks;

public class AdminCommands : ModuleBase<SocketCommandContext>
{
    [Command("debug")]
    [Summary("Command enabled for debug purposes. (!debug ...)")]
    [Remarks("skip")]
    public async Task Debug(string param1 = "", string param2 = "", string param3 = "")
    {
        await Context.Message.AddReactionAsync(EmojiList.GreenCheck);
        await SteamWebAPI.GetWorkshopItemDetails(new string[] { });
    }
}
