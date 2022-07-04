
using System;
using DefaultNamespace;
using UnityEngine;
using UnityEngine.UI;

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


