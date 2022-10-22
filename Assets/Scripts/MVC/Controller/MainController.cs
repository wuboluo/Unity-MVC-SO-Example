using UnityEngine;

namespace MVC
{
    public class MainController : MonoBehaviour
    {
        public MainModelSO mainModel;
        public UpdateNumberChannelSO mainModelChannel;
        private MainView mainView;

        private void Start()
        {
            mainView = GetComponent<MainView>();
            mainView.UpdateData(mainModel);

            // An operation on the 'View' notify the 'Controller'
            mainView.btnUpdate.onClick.AddListener(AddNumberOnClick);

            mainModel.UpdateEventChannel += UpdateInfo;
            // mainModelChannel.OnEventRaised += UpdateInfo;
        }

        private void OnDestroy()
        {
            mainModel.UpdateEventChannel -= UpdateInfo;
            // mainModelChannel.OnEventRaised -= UpdateInfo;
        }

        // 'Controller' update 'View'
        private void UpdateInfo(MainModelSO data)
        {
            mainView.UpdateData(data);
        }

        // 'Controller' update 'Model'
        private void AddNumberOnClick()
        {
            mainModel.AddNumber();
        }
    }
}