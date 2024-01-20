﻿namespace YGOEditor.Lib
{
    /// <summary>
    /// Compressed word(2 bytes) of the LZSS compression
    /// </summary>
    class YuGiCompressedWord
    {
        /// <summary>
        /// Offset of the compressed word inside the sliding window
        /// </summary>
        public ushort Offset { get; set; }
        /// <summary>
        /// Length of the compressed word
        /// </summary>
        public ushort Length { get; set; }

        public YuGiCompressedWord(ushort offset, ushort length)
        {
            Offset = offset;
            Length = length;
        }

        public YuGiCompressedWord(byte[] data)
        {
            byte lower = data[0];
            byte higher = data[1];

            Offset = lower;
            Offset |= (ushort)((higher & 0xF0) << 4);
            Length = (ushort)((higher & 0x0F) + 3);
        }

        public byte[] GetBytes()
        {
            byte[] result = new byte[2];

            result[0] = (byte)Offset;
            result[1] = (byte)((Offset & 0x0F00) >> 4);
            result[1] |= (byte)(Length - 3);

            return result;
        }
    }
}