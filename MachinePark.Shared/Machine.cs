using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MachineParkAlpha.Shared
{
    public class Machine
    {
        public string Id;
        public string Name { get; set; }

        public List<string> Log{ get; set; }

        public bool Status { get; set; }

        public DateTime? ServiceDate { get; set; } = new DateTime(1979, 07, 28);
        public Machine()
        {
            Id = Guid.NewGuid().ToString("n");
        }

        public Category Category { get; set; }


    }
}
