using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFMigrationApp
{
    public class Faculty
    {
        public int Id { get; set; }
        public int GroupCount { get; set; }
        public string DecanName { get; set; }
        public string Name { get; set; }

        public virtual ICollection<Group> Groups { get; set; }

        public Faculty()
        {
            Groups = new List<Group>();
        }
    }
}
