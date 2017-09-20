using System;
using System.IO;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace TileStudio.Core
{
    public class Palette : List<Color>
    {
        private const int MaxColors = 256;

        public Palette()
        {
            for (int i = 0; i < MaxColors; i++)
                Add(Color.Black);
        }

        public new void Clear()
        {
            for (int i = 0; i < MaxColors; i++)
                this[i] = Color.Black;
        }

        public void Load(string filename)
        {
            Clear();

            byte[] paletteBytes = File.ReadAllBytes(filename);
            int ptr = 0;
            int paletteIndex = 0;

            while (ptr < paletteBytes.Length)
            {
                this[paletteIndex] = Color.FromArgb(
                    paletteBytes[ptr + 3], paletteBytes[ptr], paletteBytes[ptr + 1], paletteBytes[ptr + 2]);

                paletteIndex++;
                ptr += 4;
            }
        }
    }
}
