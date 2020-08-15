using System;
using System.Collections.Generic;
using System.Text;

namespace BeesAssessment
{
    public class Worker : Bee
    {
        private const int MIN_HEALTH = 70;
        private float health;

        public Worker(float maxHealth) : base()
        {
            health = maxHealth;
            SetMinHealth(MIN_HEALTH);
        }
    }
}
