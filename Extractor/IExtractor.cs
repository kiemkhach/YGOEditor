using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YGOEditor.Structure;

namespace YGOEditor.Extractor.Card
{
    public interface IExtractor
    {
        void Parse();
        void Parse(byte[] bytes, string lang);
        bool CheckName(YuGiDataEntry file);
    }
}
