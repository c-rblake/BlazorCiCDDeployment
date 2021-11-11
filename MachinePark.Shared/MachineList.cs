using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MachineParkAlpha.Shared
{
    public class MachineList : IMachineList
    {
        public List<Machine> Machines = new List<Machine>();

        public List<Machine> InitalizeMachines() //add a method to get an interface.
        {
            var Machines = new List<Machine>();

            Machines.Add(new Machine
            {
                Name = "Machine 1",
                Log = new List<string> { "Initalized" },
                Status = false
            });
            Machines.Add(new Machine
            {
                Name = "Machine 2",
                Log = new List<string> { "Initalized" },
                Status = false
            });

            return Machines;
        }

    }
}
