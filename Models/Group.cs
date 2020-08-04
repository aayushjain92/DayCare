using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DayCare.Models
{
    public class Group
    {
        private string groupId;
        private static Dictionary<string, Group> groups;
        private HashSet<Person> teachers;

        private Group(string gName)
        {
            this.groupId = gName;
        }


        public static Dictionary<string, Group> initializeGroups()
        {
            if(groups == null)
            {
                groups = new Dictionary<string, Group>();
                groups.Add("6-12", new Group("6-12"));
                groups.Add("13-24", new Group("6-12"));
                groups.Add("25-35", new Group("6-12"));
                groups.Add("36-47", new Group("6-12"));
                groups.Add("48-59", new Group("6-12"));
                groups.Add("60+", new Group("6-12"));
                groups.Add("availableResources", new Group("6-12"));
            }
            return groups;
        }
    }
}
