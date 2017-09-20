using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace TileStudio.Core
{
    public class Map
    {
        public string Name;
        public int BackColor;
        public List<byte> Bytes;
        public List<MapLayer> Layers;

        public const int MinWidth = 1;
        public const int MinHeight = 1;
        public const int MaxWidth = 256;
        public const int MaxHeight = 256;

        public const int DefaultWidth = 32;
        public const int DefaultHeight = 25;
        private int CommonWidth;
        private int CommonHeight;
        public int Width { get { return CommonWidth; } }
        public int Height { get { return CommonHeight; } }

        public Map()
        {
            Init(DefaultWidth, DefaultHeight);
        }

        public Map(int width, int height)
        {
            Init(width, height);
        }

        private void Init(int width, int height)
        {
            Name = "Untitled";
            BackColor = 0;
            Bytes = new List<byte>();

            CommonWidth = width;
            CommonHeight = height;

            Layers = new List<MapLayer>();
            Layers.Add(new MapLayer(CommonWidth, CommonHeight));
        }

        public void Clear()
        {
            BackColor = 0;
            Name = "";
            Bytes.Clear();
            Layers.Clear();
        }

        public void Resize(int newWidth, int newHeight)
        {
            CommonWidth = newWidth;
            CommonHeight = newHeight;

            for (int i = 0; i < Layers.Count; i++)
                Layers[i] = Layers[i].Resize(newWidth, newHeight);
        }

        #region Save to file

        public void Save(string filename)
        {
            using (DataFileWriter writer = new DataFileWriter(filename))
            {
                writer.WriteString(Name);
                writer.WriteByte(BackColor);
                writer.WriteBytes(Bytes);

                writer.WriteByte(Width);
                writer.WriteByte(Height);

                writer.WriteByte(Layers.Count);
                foreach (MapLayer layer in Layers)
                    SaveLayer(writer, layer);
            }
        }

        private void SaveLayer(DataFileWriter writer, MapLayer layer)
        {
            for (int y = 0; y < Height; y++)
                for (int x = 0; x < Width; x++)
                    SaveObject(writer, layer.GetObject(x, y));
        }

        private void SaveObject(DataFileWriter writer, GameObject o)
        {
            writer.WriteWord(o.Graphics.Index);
            writer.WriteByte(o.Graphics.Color1);
            writer.WriteByte(o.Graphics.Color2);
            writer.WriteByte(o.Graphics.Color3);
            writer.WriteBytes(o.Bytes);
        }

        #endregion

        #region Load from file

        public void Load(string filename)
        {
            Clear();

            using (DataFileReader reader = new DataFileReader(filename))
            {
                Name = reader.ReadString();
                BackColor = reader.ReadByte();
                Bytes = reader.ReadBytes();

                CommonWidth = reader.ReadByte();
                CommonHeight = reader.ReadByte();

                int layerCount = reader.ReadByte();
                for (int i = 0; i < layerCount; i++)
                    LoadLayer(reader);
            }
        }

        private void LoadLayer(DataFileReader reader)
        {
            MapLayer layer = new MapLayer(CommonWidth, CommonHeight);

            for (int y = 0; y < Height; y++)
                for (int x = 0; x < Width; x++)
                    LoadObject(reader, layer, x, y);

            Layers.Add(layer);
        }

        private void LoadObject(DataFileReader reader, MapLayer layer, int x, int y)
        {
            GameObject o = new GameObject();

            o.Graphics.Index = reader.ReadWord();
            o.Graphics.Color1 = reader.ReadByte();
            o.Graphics.Color2 = reader.ReadByte();
            o.Graphics.Color3 = reader.ReadByte();
            o.Bytes = reader.ReadBytes();

            layer.SetObject(x, y, o);
        }

        #endregion
    }
}
