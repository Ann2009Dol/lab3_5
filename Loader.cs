using System;

namespace lab3_5.Models
{
    public class Loader : ILoader
    {
        public event EventHandler Loaded;

        public BolidStatus ReturnCarIntoTheRace()
        {
            Crash();
            return BolidStatus.Normal;
        }

        protected virtual void Crash()
        {
            Loaded?.Invoke(this, EventArgs.Empty);
        }
    }
}
