using System;
using System.Collections.Generic;

namespace TileStudio.Core
{
    public class MapLayer
    {
        private int Width;
        private int Height;
        private GameObject[,] Objects;

        public MapLayer(int width, int height)
        {
            Width = width;
            Height = height;

            Objects = new GameObject[Height, Width];
            for (int y = 0; y < Height; y++)
                for (int x = 0; x < Width; x++)
                    SetObject(x, y, new GameObject());
        }

        public int GetWidth()
        {
            return Width;
        }

        public int GetHeight()
        {
            return Height;
        }

        public void Clear()
        {
            for (int y = 0; y < Height; y++)
                for (int x = 0; x < Width; x++)
                    GetObject(x, y).Clear();
        }

        public void FillObject(GameObject o)
        {
            for (int y = 0; y < Height; y++)
                for (int x = 0; x < Width; x++)
                    SetObject(x, y, new GameObject(o));
        }

        public void SetObject(int x, int y, GameObject o)
        {
            if (x < 0 || y < 0 || x >= Width || y >= Height)
                return;

            Objects[y, x] = o;
        }

        public GameObject GetObject(int x, int y)
        {
            if (x < 0 || y < 0 || x >= Width || y >= Height)
                return null;

            return Objects[y, x];
        }

        public void SetObjectTile(int x, int y, TileGraphics tile)
        {
            GameObject o = GetObject(x, y);

            if (o != null)
            {
                o.Graphics.Index = tile.Index;
                o.Graphics.Color1 = tile.Color1;
                o.Graphics.Color2 = tile.Color2;
                o.Graphics.Color3 = tile.Color3;
            }
        }

        public void SetObjectData(int x, int y, List<byte> data)
        {
            GameObject o = GetObject(x, y);
            if (o != null)
                o.Bytes = data;
        }

        public MapLayer Resize(int newWidth, int newHeight)
        {
            MapLayer resizedMap = new MapLayer(newWidth, newHeight);

            for (int y = 0; y < Height; y++)
            {
                for (int x = 0; x < Width; x++)
                {
                    if (x >= resizedMap.Width || y >= resizedMap.Height)
                        continue;

                    resizedMap.SetObject(x, y, new GameObject(GetObject(x, y)));
                }
            }

            return resizedMap;
        }
    }
}
