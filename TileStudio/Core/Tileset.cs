using System;
using System.IO;
using System.Collections.Generic;
using System.Text;

namespace TileStudio.Core
{
    public class Tileset : List<Tile>
    {
        public const int TilesetPageSize = 256;

        public void AddPage()
        {
            for (int i = 0; i < TilesetPageSize; i++)
                Add(new Tile());
        }

        public void DeletePage(int page)
        {
            int firstTile = page * TilesetPageSize;

            RemoveRange(page, TilesetPageSize);
        }

        public void Load(string filename)
        {
            if (!File.Exists(filename))
                return;

            Clear();

            byte[] tilesetBytes = File.ReadAllBytes(filename);
            int ptr = 0;

            while (ptr < tilesetBytes.Length)
            {
                int[,] pixels = new int[Tile.Height, Tile.Width];
                for (int y = 0; y < Tile.Height; y++)
                    for (int x = 0; x < Tile.Width; x++)
                        pixels[y, x] = tilesetBytes[ptr++];

                Add(new Tile(pixels));
            }
        }

        public void Save(string filename)
        {
            StreamWriter writer = new StreamWriter(filename);

            foreach (Tile tile in this)
            {
                for (int y = 0; y < Tile.Height; y++)
                    for (int x = 0; x < Tile.Width; x++)
                        writer.Write((char)tile.Pixels[y, x]);
            }

            writer.Flush();
            writer.Close();
        }
    }
}
