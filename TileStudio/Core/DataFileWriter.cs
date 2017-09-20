using System;
using System.Text;
using System.IO;
using System.Collections.Generic;

namespace TileStudio.Core
{
    public class DataFileWriter : IDisposable
    {
        public const int MaxDataBlockSize = 256;

        private FileStream File;
        private BinaryWriter Writer;

        public DataFileWriter(string path)
        {
            File = new FileStream(path, FileMode.Create);
            Writer = new BinaryWriter(File, new UTF8Encoding(false));
        }

        public void Dispose()
        {
            Close();
        }

        public void Close()
        {
            Writer.Close();
            File.Close();
        }

        public void WriteByte(byte b)
        {
            Writer.Write(b);
        }

        public void WriteByte(int b)
        {
            if (b < byte.MinValue || b > byte.MaxValue)
                throw new InvalidOperationException("The value must be between " + byte.MinValue + " and " + byte.MaxValue + " items.");

            WriteByte((byte)b);
        }

        public void WriteBytes(List<byte> bytes)
        {
            WriteByte(bytes.Count);
            foreach (byte b in bytes)
                WriteByte(b);
        }

        public void WriteWord(int word)
        {
            if (word < ushort.MinValue || word > ushort.MaxValue)
                throw new InvalidOperationException("The value must be between " + ushort.MinValue + " and " + ushort.MaxValue + " items.");

            WriteByte(word >> 8);
            WriteByte((byte)word);
        }

        public void WriteString(string str)
        {
            Writer.Write(str.ToCharArray());
            WriteByte(0);
        }

        public void WriteDataBlock(DataBlock block)
        {
            if (block.Count >= MaxDataBlockSize)
                throw new InvalidOperationException("The data block must contain less than " + MaxDataBlockSize + " items.");

            WriteByte(block.Count);

            foreach (KeyValuePair<string, string> item in block)
            {
                WriteString(item.Key);
                WriteString(item.Value);
            }
        }
    }
}
