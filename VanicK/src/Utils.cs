#region

using System.Drawing;
using System.Linq;
using System.Net;
using Newtonsoft.Json;
using static vanick.Offsets;

#endregion

namespace vanick
{
    public static class Utils
    {
        internal static OffsetMain RenewOffsets()
        {
            using (var wc = new WebClient())
            {
                string json = wc.DownloadString("https://raw.githubusercontent.com/frk1/hazedumper/master/csgo.min.json");
                return JsonConvert.DeserializeObject<OffsetMain>(json);
            }

            return null;
        }

        internal static Models.GlowColorStruct CreateStruct(Color color)
        {
            return new Models.GlowColorStruct
            {
                alpha = color.A,
                blue = color.B,
                green = color.G,
                red = color.R
            };
        }

        internal static Color FromStruct(Models.GlowColorStruct str)
        {
            return Color.FromArgb((int)str.alpha, (int)str.red, (int)str.green, (int)str.blue);
        }
    }
}