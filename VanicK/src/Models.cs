#region

using System.Linq;

#endregion

namespace vanick
{
    internal class Models
    {
        internal struct GlowColorStruct
        {
            public float red { get; set; }
            public float green { get; set; }
            public float blue { get; set; }
            public float alpha { get; set; }
        }

        internal struct rgba //Overlay player color or "chams"
        {
            public byte r;
            public byte g;
            public byte b;
            public byte a;
        }

        internal struct GlowSettingsStruct
        {
            public bool renderOccluded { get; set; }
            public bool renderUnoccluded { get; set; }
        }
    }
}