using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace YGOEditor.Structure
{
    /// <summary>
    /// [WIP] YuGi .dat file
    /// </summary>
    public class YuGiData : FilterBindingList<YuGiDataEntry>
    {
        #region CustomDefinition
        public string Path { get; set; }
        private Dictionary<string, YuGiDataEntry> Files { get; set; } = new Dictionary<string, YuGiDataEntry>();

        public YuGiData(string path)
        {
            Path = path;
            Initialize();
        }

        public YuGiData()
        {
        }

        public YuGiDataEntry Find(string name)
        {
            if (Files.ContainsKey(name))
            {
                return Files[name];
            }
            return null;
        }

        public byte[] ReadData(int offset, int length)
        {
            using (BinaryReader reader = new BinaryReader(new FileStream(Path, FileMode.Open)))
            {
                reader.BaseStream.Seek(offset, SeekOrigin.Begin);
                byte[] data = new byte[length];
                reader.Read(data, 0, data.Length);

                return data;
            }
        }

        public bool Initialize()
        {
            using (BinaryReader reader = new BinaryReader(new FileStream(Path, FileMode.Open)))
            {
                string header = Encoding.ASCII.GetString(reader.ReadBytes(8));
                if (header != "KCEJYUGI") return false;

                int fileCount = reader.ReadInt32();
                for (int i = 0; i < fileCount; i++)
                {
                    byte[] fileHeader = new byte[268];
                    reader.Read(fileHeader, 0, fileHeader.Length);
                    this.Add(new YuGiDataEntry(fileHeader, ReadData));
                }
            }
            return true;
        }
        #endregion CustomDefinition

        #region ImplementBidingList
        protected override FilterBindingList<YuGiDataEntry> NewInstance()
        {
            return new YuGiData();
        }

        protected override IEnumerable GetOriginList()
        {
            return Files.Values;
        }

        protected override int CountOrigin()
        {
            return Files.Count;
        }

        protected override void AddOrigin(YuGiDataEntry o)
        {
            if (!Files.ContainsKey(o.FileName))
            {
                Files.Add(o.FileName, o);
            }
        }

        protected override void RemoveOrigin(int index)
        {
            Files.Remove(this[index].FileName);
        }
        #endregion ImplementBidingList
    }
}
