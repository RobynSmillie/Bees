using System;
using System.Collections.Generic;
using System.Text;

namespace BeesAssessment
{
    public class Bee
    {
        private float health;
        private Boolean isAlive;
        private int minHealth;
        private String healthStatus;

        public Bee()
        {
            health = 100;
            isAlive = true;
        }

        public String Damage(int percentDamage)
        {
            if (isAlive)
            {
                float damage = (health / 100) * percentDamage;
                health -= damage;
                int healthInt = Convert.ToInt32(health);
                SetHealth(healthInt);
                minHealth = GetMinHealth();
                UpdateHealth(minHealth);
                return healthStatus;
            }
            return healthStatus;
        }

        private String UpdateHealth(int minHealth)
        {
            if(GetHealth() >= minHealth)
            {
                SetHealthStatus("Health status: " + health + " Alive :)");
                return GetHealthStatus();
            }
            else
            {
                SetIsAlive(false);
                SetHealthStatus("Health status: Dead :( ");
                return GetHealthStatus();
            }
        }

        public float GetHealth() { return health; }
        public void SetHealth(float newHealth) { health = newHealth; }
        public Boolean GetIsAlive() { return isAlive; }
        public void SetIsAlive(Boolean newIsAlive) { isAlive = newIsAlive; }

        public int GetMinHealth() { return minHealth; }
        public void SetMinHealth(int min) { minHealth = min; }
        public String GetHealthStatus() { return healthStatus; }
        public void SetHealthStatus(String status) { healthStatus = status; }
    }
}
