using System;
using Enums;
using UnityEngine;

namespace Data.ValueObject
{
    [Serializable]
    public class PlatformData
    {
        public Vector3 position;
        public PlatformTypes platformTypes;
        public int RequiredBallCount;
    }
}


