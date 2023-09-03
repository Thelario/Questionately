using _Scripts.Managers;
using UnityEngine;
using UnityEngine.UI;

namespace _Scripts.UI
{
    [RequireComponent(typeof(Button))]
    public class NextQuestionButton : MonoBehaviour
    {
        private Button _button;

        private void Start()
        {
            _button = GetComponent<Button>();
            _button.onClick.AddListener(NextQuestion);
        }

        private void NextQuestion()
        {
            QuestionsManagerUI.Instance.NextQuestion();
        }
    }
}