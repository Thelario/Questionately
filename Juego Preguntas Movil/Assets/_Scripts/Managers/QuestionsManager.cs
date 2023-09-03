using System.Collections.Generic;
using _Scripts.Game;
using Game.Managers;
using UnityEngine;

namespace _Scripts.Managers
{
    public class QuestionsManager : Singleton<QuestionsManager>
    {
        [HideInInspector] public List<Question> questions = new ();

        public Question GetRandomQuestion()
        {
            if (questions.Count == 0)
            {
                return new Question
                {
                    id = -1,
                    groupId = 7,
                    questionEnglish = "No more questions available!!!",
                    questionSpanish = "¡¡¡No hay más preguntas disponibles!!!",
                    questionFrench = "Il n'y a plus de questions disponibles !!!"
                };
            }
            
            int questionIndex = Random.Range(0, questions.Count);
            
            Question question = questions[questionIndex];
            
            questions.RemoveAt(questionIndex);

            return question;
        }
        
        public void LoadQuestions()
        {
            questions.Clear();

            string[] data = CsvReader.Read("Questions");

            const int factor = 5;
            int tableSize = data.Length / factor - 1;

            for (int i = 0; i < tableSize; i++)
            {
                int id = int.Parse(data[factor * (i + 1)]);
                int groupId = int.Parse(data[factor * (i + 1) + 1]);
                string questionSpanish = data[factor * (i + 1) + 2];
                string questionEnglish = data[factor * (i + 1) + 3];
                string questionFrench = data[factor * (i + 1) + 4];
                
                questions.Add(CreateQuestion(id, groupId, questionSpanish, questionEnglish, questionFrench));
            }
        }

        private Question CreateQuestion(int id, int groupId, string questionSpanish, string questionEnglish, string questionFrench)
        {
            Question question = new ()
            {
                id = id,
                groupId = groupId,
                questionSpanish = questionSpanish,
                questionEnglish = questionEnglish,
                questionFrench = questionFrench
            };

            return question;
        }
    }
}