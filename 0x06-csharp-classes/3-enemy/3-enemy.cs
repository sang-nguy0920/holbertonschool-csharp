using System;

namespace Enemies
{
    /// <summary>Initializes a new instance of the Zombie class.</summary>
    class Zombie
    {
        /// <summary>Private field for Zombie class.</summary>
        private int health;

        /// <summary>Public constructor for Zombie class.</summary>
        public Zombie()
        {
            health = 0;
        }
        /// <summary>Public constructor for Zombie class.</summary>
        public Zombie(int value)
        {
            if (value < 0)
            {
                throw new ArgumentException("Health must be greater than or equal to 0");
            }
            health = value;
        }

        /// <summary>Public constructor for Zombie class.</summary>
        public int GetHealth()
        {
            return (health);
        }

    }
}
