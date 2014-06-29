namespace WarMachines.Machines
{
    using System;
    using System.Text;
    using WarMachines.Interfaces;

    public class Fighter : Machine, IFighter
    {
        private const int InitialHealthPoints = 200;

        public Fighter(string initialName, double initialAttackPoints, double initialDefensePoints, bool initialStealthMode)
            : base(initialName, InitialHealthPoints, initialAttackPoints, initialDefensePoints)
        {
            this.StealthMode = initialStealthMode;
        }

        public bool StealthMode { get; private set; }

        public void ToggleStealthMode()
        {
            this.StealthMode = !this.StealthMode;
        }

        public override string ToString()
        {
            StringBuilder result = new StringBuilder();
            result.AppendLine(base.ToString());
            string stealthModeAsString = this.StealthMode ? On : Off;
            result.Append(string.Format(" *Stealth: {0}", stealthModeAsString));
            return result.ToString();
        }
    }
}
