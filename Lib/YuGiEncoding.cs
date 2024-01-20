using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YGOEditor.Structure;

namespace YGOEditor.Lib
{
    static class YuGiEncoding
    {
        public static Dictionary<string, Encoding> MAP_CODE = new Dictionary<string, Encoding>() {
            { "eng", Encoding.UTF8 },
            { "fra", Encoding.GetEncoding("iso-8859-1") },
            { "ger", Encoding.GetEncoding("iso-8859-1") },
            { "ita", Encoding.GetEncoding("iso-8859-1") },
            { "jpn", Encoding.GetEncoding("Shift_JIS")  },
            { "spa", Encoding.GetEncoding("iso-8859-1") },
        };

        public static string GetString(byte[] bytes) {
            try
            {
                var res = Encoding.ASCII.GetString(bytes).Trim('\0');
                return res;
            }
            catch (Exception)
            {
                var res = Encoding.GetEncoding("Shift_JIS").GetString(bytes, 0, bytes.Length).Trim('\0');
                return res;
            }
        }

        public static string GetString(byte[] bytes, string lang)
        {
            if (lang.Length < 3)
            {
                return GetString(bytes);
            }
            string result;
            try
            {
                MAP_CODE.TryGetValue(lang, out Encoding encode);
                result = encode.GetString(bytes, 0, bytes.Length);
            }
            catch (Exception)
            {
                result = Encoding.UTF8.GetString(bytes, 0, bytes.Length);
            }

            return result;
        }
    }
}
