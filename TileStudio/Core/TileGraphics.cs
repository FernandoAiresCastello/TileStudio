using System;

namespace TileStudio.Core
{
    public class TileGraphics
    {
        public int Index;
        public int Color1;
        public int Color2;
        public int Color3;

        public const int DefaultIndex = 0;
        public const int DefaultColor1 = 0x0f;
        public const int DefaultColor2 = 0x07;
        public const int DefaultColor3 = 0x08;

        public TileGraphics()
        {
            Clear();
        }

        public TileGraphics(int index, int color1, int color2, int color3)
        {
            Index = index;
            Color1 = color1;
            Color2 = color2;
            Color3 = color3;
        }

        public void Clear()
        {
            Index = 0;
            Color1 = DefaultColor1;
            Color2 = DefaultColor2;
            Color3 = DefaultColor3;
        }
    }
}
