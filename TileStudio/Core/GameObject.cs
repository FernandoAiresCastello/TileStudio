using System;
using System.Collections.Generic;

namespace TileStudio.Core
{
    public class GameObject
    {
        public TileGraphics Graphics;
        public List<byte> Bytes;

        public GameObject()
        {
            Graphics = new TileGraphics();
            Bytes = new List<byte>();
        }

        public GameObject(TileGraphics graphics, List<byte> bytes)
        {
            Graphics = graphics;
            Bytes = bytes;
        }

        public GameObject(GameObject other)
        {
            Graphics = new TileGraphics();
            Bytes = new List<byte>();

            Graphics.Index = other.Graphics.Index;
            Graphics.Color1 = other.Graphics.Color1;
            Graphics.Color2 = other.Graphics.Color2;
            Graphics.Color3 = other.Graphics.Color3;
            
            foreach (byte b in other.Bytes)
                Bytes.Add(b);
        }

        public void Clear()
        {
            Graphics.Clear();
            Bytes.Clear();
        }

        public override string ToString()
        {
            return
                "IX:" + Graphics.Index + " " +
                "C1:" + Graphics.Color1 + " " +
                "C2:" + Graphics.Color2 + " " +
                "C3:" + Graphics.Color3 + " " +
                "DATA: {" + GetBytesAsString() + "}";
        }

        private string GetBytesAsString()
        {
            string data = "";
            int i = 0;

            foreach (byte b in Bytes)
            {
                data += b;
                i++;
                if (i < Bytes.Count)
                    data += ", ";
            }

            return data;
        }
    }
}
