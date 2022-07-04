using System;
using System.Collections.Generic;

namespace Data.ValueObject
{
    [Serializable]
    public class LevelData
    {
        public int levelID;
        public List<PlatformData> platformDatas = new List<PlatformData>();
    }
}