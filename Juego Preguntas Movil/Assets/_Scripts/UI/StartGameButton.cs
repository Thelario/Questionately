using _Scripts.Game;
using _Scripts.Managers;
using UnityEngine;
using UnityEngine.UI;

namespace _Scripts.UI
{
    [RequireComponent(typeof(Button))]
    public class StartGameButton : MonoBehaviour
    {
        private Button _button;

        private void Start()
        {
            _button = GetComponent<Button>();
            _button.onClick.AddListener(StartGame);
        }

        private void StartGame()
        {
            QuestionsManager.Instance.LoadQuestions();
            QuestionsManagerUI.Instance.NextQuestion();
        }
    }
}