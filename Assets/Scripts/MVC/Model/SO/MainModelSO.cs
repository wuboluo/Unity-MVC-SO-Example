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

        // Notify the 'Controller' when the 'Model' data changes
        private void UpdateInfo()
        {
            // use c# Event.
            UpdateEventChannel?.Invoke(this);

            // use scriptableObject as event
            // mainModelChannel.Raise(this);
        }
    }
}