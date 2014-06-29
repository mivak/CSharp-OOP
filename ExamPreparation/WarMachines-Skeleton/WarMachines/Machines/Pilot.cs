namespace WarMachines.Machines
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using WarMachines.Interfaces;

    public class Pilot : IPilot
    {
        private readonly IList<IMachine> machines;
        private string name;

        public Pilot(string name)
        {
            this.Name = name;
            this.machines = new List<IMachine>();
        }

        public string Name
        {
            get
            {
                return this.name;
            }

            private set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("Pilot name cannot be null");
                }

                this.name = value;
            }
        }

        public void AddMachine(IMachine machine)
        {
            if (machine == null)
            {
                throw new ArgumentNullException("Machine cannot be null");
            }

            this.machines.Add(machine);
        }

        public string Report()
        {
            StringBuilder result = new StringBuilder();
            string pilotName = this.Name;
            string numberOfMachines = this.machines.Count == 0 ? "no" : this.machines.Count.ToString();
            string machineWord = this.machines.Count == 1 ? "machine" : "machines";
            result.Append(string.Format("{0} - {1} {2}", pilotName, numberOfMachines, machineWord));

            if (this.machines.Count != 0)
            {
                result.AppendLine();
                var sortedMachines = this.machines
                .OrderBy(x => x.HealthPoints)
                .ThenBy(x => x.Name);

                foreach (var machine in sortedMachines)
                {
                    result.AppendLine(machine.ToString());
                }
            }
            
            return result.ToString().TrimEnd();
        }
    }
}