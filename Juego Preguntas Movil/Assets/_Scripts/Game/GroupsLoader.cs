using System.Collections.Generic;
using Game.Managers;
using UnityEngine;

namespace _Scripts.Game
{
    public class GroupsLoader : Singleton<GroupsLoader>
    {
        public GroupColor[] groupColors;
        public List<Group> groups = new ();

        private void Start()
        {
            LoadGroups();
        }

        public Group GetGroup(int groupId)
        {
            foreach (Group group in groups)
            {
                if (group.groupId == groupId)
                    return group;
            }

            return new Group();
        }

        public GroupColor GetGroupColor(int groupId)
        {
            foreach (GroupColor groupColor in groupColors)
            {
                if (groupColor.groupId == groupId)
                    return groupColor;
            }

            return new GroupColor();
        }

        private void LoadGroups()
        {
            groups.Clear();

            string[] data = CsvReader.Read("Groups");

            int factor = 4;
            int tableSize = data.Length / factor - 1;

            for (int i = 0; i < tableSize; i++)
            {
                int groupId = int.Parse(data[factor * (i + 1)]);
                string espanol = data[factor * (i + 1) + 1];
                string ingles = data[factor * (i + 1) + 2];
                string frances = data[factor * (i + 1) + 3];
                
                groups.Add(CreateGroup(groupId, espanol, ingles, frances));
            }
        }

        private Group CreateGroup(int groupId, string espanol, string ingles, string frances)
        {
            Group group = new Group();
            
            group.groupId = groupId;
            group.espanol = espanol;
            group.ingles = ingles;
            group.frances = frances;
            
            return group;
        }
    }
}