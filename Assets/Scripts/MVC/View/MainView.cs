using UnityEngine;
using UnityEngine.UI;

namespace MVC
{
    public class MainView : MonoBehaviour
    {
        public Text txtNumber;
        public Button btnUpdate;

        // Only responsible for changes in 'View' value
        public void UpdateData(MainModelSO data)
        {
            txtNumber.text = data.number.ToString();
        }
    }
}