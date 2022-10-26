using UnityEngine;
using UnityEngine.UI;

namespace MVC
{
    public class MainView : MonoBehaviour
    {
        public Text txtNumber;
        public Button btnUpdate;

        // 只负责 view 值的更改
        public void UpdateData(MainModelSO data)
        {
            txtNumber.text = data.number.ToString();
        }
    }
}