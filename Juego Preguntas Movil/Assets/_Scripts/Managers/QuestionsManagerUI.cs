using _Scripts.Game;
using _Scripts.Managers;
using Game.Managers;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace _Scripts.UI
{
    public class QuestionsManagerUI : Singleton<QuestionsManagerUI>
    {
        [SerializeField] private TMP_Text cardTitle;
        [SerializeField] private TMP_Text cardQuestion;
        [SerializeField] private Image backImage;
        [SerializeField] private Image frameImage;

        public void NextQuestion()
        {
            Question question = QuestionsManager.Instance.GetRandomQuestion();
            Group group = GroupsLoader.Instance.GetGroup(question.groupId);
            GroupColor groupColor = GroupsLoader.Instance.GetGroupColor(question.groupId);

            cardTitle.text = group.espanol;
            cardQuestion.text = question.questionSpanish;

            backImage.color = groupColor.groupCardColor;
            frameImage.color = groupColor.groupFrameColor;
            cardTitle.color = groupColor.groupTitleColor;
            cardQuestion.color = groupColor.questionColor;
        }
    }
}
