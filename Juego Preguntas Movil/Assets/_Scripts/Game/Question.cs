namespace _Scripts.Game
{
    [System.Serializable]
    public struct Question
    {
        public int id;
        public int groupId;
        public string questionSpanish;
        public string questionEnglish;
        public string questionFrench;

        public override string ToString()
        {
            return "Question: " + id + ", " + groupId + ", " + questionSpanish + ", " + questionEnglish + ", " + questionFrench;
        }
    }
}