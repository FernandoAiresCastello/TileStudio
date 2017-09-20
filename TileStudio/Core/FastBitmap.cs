using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.Runtime.InteropServices;

namespace TileStudio.Core
{
    public class FastBitmap : IDisposable
    {
        public Bitmap Bitmap { get; private set; }

        protected GCHandle BitsHandle { get; private set; }

        private int[] Bits;
        private bool Disposed;
        private int Height;
        private int Width;

        public FastBitmap(int width, int height)
        {
            Width = width;
            Height = height;
            Bits = new int[width * height];
            BitsHandle = GCHandle.Alloc(Bits, GCHandleType.Pinned);
            Bitmap = new Bitmap(width, height, width * 4, PixelFormat.Format32bppPArgb, BitsHandle.AddrOfPinnedObject());
        }

        public void Dispose()
        {
            if (Disposed)
                return;

            Disposed = true;
            Bitmap.Dispose();
            BitsHandle.Free();
        }
    }
}
