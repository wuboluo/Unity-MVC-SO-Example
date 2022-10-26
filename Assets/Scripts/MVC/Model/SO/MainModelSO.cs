using System;
using UnityEngine;

namespace MVC
{
    [CreateAssetMenu(menuName = "MVC/Model/MainModel")]
    public class MainModelSO : ScriptableObject
    {
        public UpdateNumberChannelSO mainModelChannel;
        public int number;

        public event Action<MainModelSO> UpdateEventChannel;

        public void AddNumber()
        {
            number += 1;
            UpdateInfo();
        }

        // 当 model 数据发生变化时通知 controller
        private void UpdateInfo()
        {
            // 1，使用 C#的Action
            UpdateEventChannel?.Invoke(this);

            // 2，使用 ScriptableObject
            // mainModelChannel.Raise(this);
        }
    }
}