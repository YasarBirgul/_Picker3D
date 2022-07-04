using Data.UnityObject;
using UnityEngine;

namespace DefaultNamespace
{
    public class Controllers : MonoBehaviour
    {
        public void InitializeLevel(int _levelID,Transform levelHolder)
        {
            Instantiate(Resources.Load<CD_Level>($"Data/CD_Level{_levelID}"), levelHolder);
        }
    }
}