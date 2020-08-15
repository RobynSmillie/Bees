using System;
using System.Collections.Generic;
using System.Text;

namespace BeesAssessment
{
    public class Drone : Bee
    {
        private const int MIN_HEALTH = 50;
        private float health;

        public Drone(float maxHealth) : base()
        {
            health = maxHealth;
            SetMinHealth(MIN_HEALTH);
        }
    }
}
