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

            // 对 view 的操作通知 controller
            mainView.btnUpdate.onClick.AddListener(AddNumberOnClick);

            mainModel.UpdateEventChannel += UpdateInfo;
            // mainModelChannel.OnEventRaised += UpdateInfo;
        }

        private void OnDestroy()
        {
            mainModel.UpdateEventChannel -= UpdateInfo;
            // mainModelChannel.OnEventRaised -= UpdateInfo;
        }

        // controller 更新 view
        private void UpdateInfo(MainModelSO data)
        {
            mainView.UpdateData(data);
        }

        // controller 更新 model
        private void AddNumberOnClick()
        {
            mainModel.AddNumber();
        }
    }
}