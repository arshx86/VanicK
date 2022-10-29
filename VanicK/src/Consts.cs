#region

using System.Drawing;
using System.Linq;

#endregion

namespace vanick
{
    internal class Consts
    {
        internal static Models.GlowColorStruct GlowTeam = Utils.CreateStruct(Color.White);
        internal static Models.GlowColorStruct GlowEnemy = Utils.CreateStruct(Color.Yellow);
    }
}