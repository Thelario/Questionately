using UnityEngine;
using UnityEngine.UI;

namespace _Scripts.UI
{
    [RequireComponent(typeof(Button))]
    public class CanvasSwitcher : MonoBehaviour
    {
        [SerializeField] private CanvasType desiredCanvasType;
        [SerializeField] private bool transition;

        private Button _menuButton;

        private void Start()
        {
            _menuButton = GetComponent<Button>();
            _menuButton.onClick.AddListener(OnButtonClicked);
        }

        private void OnButtonClicked()
        {
            CanvasManager.Instance.SwitchCanvas(desiredCanvasType);
        }
    }
}
