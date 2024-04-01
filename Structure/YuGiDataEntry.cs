using System;
using System.Text;
using YGOEditor.Lib;

namespace YGOEditor.Structure
{
    /// <summary>
    /// YuGi .dat file entry
    /// </summary>
    public class YuGiDataEntry
    {
        private static readonly Encoding SHIFT_JIS = Encoding.GetEncoding("Shift_JIS");

        public string FileName { get; set; }
        public int Size { get; set; }
        public int FullSize { get; set; }
        public int Offset { get; set; }
        public bool Changed { get; set; } = false;

        private readonly Func<int, int, byte[]> funcReadFile;

        private byte[] data = null;
        public byte[] Data
        {
            get {
                if (this.data != null) { return this.data; }

                this.data = this.funcReadFile(this.Offset, this.Size);
                if (this.Size != this.FullSize)
                {
                    this.data = YuGiLZSS.Decompress(this.data);
                }

                return this.data;
            }
            set { 
                this.data = value;
                FullSize = data.Length;
                Size = data.Length;
                Changed = true;
            }
        }

        public YuGiDataEntry(string fileName, byte[] data)
        {
            FileName = fileName;
            Data = data;
        }

        public YuGiDataEntry(byte[] bytes, Func<int, int, byte[]> funcReadFile)
        {
            FileName = ConvertToFileName(bytes, 0, 256);
            Offset = BitConverter.ToInt32(bytes, 256);
            FullSize = BitConverter.ToInt32(bytes, 260);
            Size = BitConverter.ToInt32(bytes, 264);
            this.funcReadFile = funcReadFile;
        }

        private static string ConvertToFileName(byte[] bytes, int index, int length)
        {
            if (index + length > bytes.Length) throw new ArgumentException("Index and/or length is exceeding the given byte array!");
            byte[] result = new byte[256];
            for (int i = index; i < index + length; i++)
            {
                result[i] = (byte)(((bytes[i] & 0xF0) >> 4) | ((bytes[i] & 0x0F) << 4));
            }

            try
            {
                var res = Encoding.ASCII.GetString(result).Trim('\0');
                return res;
            }
            catch (Exception)
            {
                var res = SHIFT_JIS.GetString(result, 0, result.Length).Trim('\0');
                return res;
            }
        }



        private static byte[] ConvertToBytes(string fileName)
        {
            byte[] bytes = Encoding.ASCII.GetBytes(fileName);
            for (int i = 0; i < bytes.Length; i++)
            {
                bytes[i] = (byte)(((bytes[i] & 0xF0) >> 4) | ((bytes[i] & 0x0F) << 4));
            }
            return bytes;
        }

        public override string ToString()
        {
            return String.Format("Offset: {0}, Size: {1}, SizeExtra: {2}, FileName: {3}", Offset, Size, FullSize, FileName);
        }
    }
}