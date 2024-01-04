using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.PortableExecutable;
using System.Text;
using System.Threading.Tasks;

namespace CamstarHelper.Entity
{
    public class ObjectGroup : NamedDataObject
    {
        public IEnumerable<BaseObject>? Entities { get; set; }
        public string EntryType { get; set; }
        //public IEnumerable<ObjectGroup> Groups { get; set; }
        public new string Name { get; set; }

    }
}
