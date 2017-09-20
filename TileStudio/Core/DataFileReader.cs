using System;
using System.Text;
using System.IO;
using System.Collections.Generic;

namespace TileStudio.Core
{
    public class DataFileReader : IDisposable
    {
        private FileStream File;
        private BinaryReader Reader;

        public DataFileReader(string path)
        {
            File = new FileStream(path, FileMode.Open);
            Reader = new BinaryReader(File, new UTF8Encoding(false));
        }

        public void Dispose()
        {
            Close();
        }

        public void Close()
        {
            Reader.Close();
            File.Close();
        }

        public byte ReadByte()
        {
            return Reader.ReadByte();
        }

        public List<byte> ReadBytes()
        {
            int length = Reader.ReadByte();

            List<byte> bytes = new List<byte>();
            for (int i = 0; i < length; i++)
                bytes.Add(Reader.ReadByte());

            return bytes;
        }

        public int ReadWord()
        {
            byte byte1 = ReadByte();
            byte byte2 = ReadByte();

            return byte1 << 8 | byte2;
        }

        public string ReadString()
        {
            string str = "";
            byte ch;

            while (true)
            {
                ch = ReadByte();
                if (ch == 0)
                    break;

                str += (char)ch;
            }

            return str;
        }

        public DataBlock ReadDataBlock()
        {
            DataBlock data = new DataBlock();
            int count = ReadByte();

            for (int i = 0; i < count; i++)
            {
                string key = ReadString();
                string value = ReadString();

                data.Add(key, value);
            }

            return data;
        }
    }
}
