namespace _Scripts.Game
{
    [System.Serializable]
    public struct Group
    {
        public int groupId;
        public string espanol;
        public string ingles;
        public string frances;

        public override string ToString()
        {
            return "Group: " + groupId + ", " + espanol + ", " + ingles + ", " + frances;
        }
    }
}