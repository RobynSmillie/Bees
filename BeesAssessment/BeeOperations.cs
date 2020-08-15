using System;
using System.Collections.Generic;
using System.Text;

namespace BeesAssessment
{
    public class BeeOperations
    {
        private List<Bee> beeList;

        public int randomNumber()
        {
            Random random = new Random();
            int num = random.Next(80);
            if(num > 0 || num < 100)
            {
                return num;
            }
            else
            {
                throw new ArgumentOutOfRangeException("number must be between 0 an 100. Actual: " + num);
            }
        }

        public List<Bee> GetBees()
        {
            return beeList;
        }

        public void GenerateBees()
        {
            beeList = new List<Bee>();
            Drone drone1 = new Drone(100);
            Drone drone2 = new Drone(100);
            Drone drone3 = new Drone(100);
            Drone drone4 = new Drone(100);
            Drone drone5 = new Drone(100);
            Drone drone6 = new Drone(100);
            Drone drone7 = new Drone(100);
            Drone drone8 = new Drone(100);
            Drone drone9 = new Drone(100);
            Drone drone10 = new Drone(100);

            Worker worker1 = new Worker(100);
            Worker worker2 = new Worker(100);
            Worker worker3 = new Worker(100);
            Worker worker4 = new Worker(100);
            Worker worker5 = new Worker(100);
            Worker worker6 = new Worker(100);
            Worker worker7 = new Worker(100);
            Worker worker8 = new Worker(100);
            Worker worker9 = new Worker(100);
            Worker worker10 = new Worker(100);

            Queen queen1 = new Queen(100);
            Queen queen2 = new Queen(100);
            Queen queen3 = new Queen(100);
            Queen queen4 = new Queen(100);
            Queen queen5 = new Queen(100);
            Queen queen6 = new Queen(100);
            Queen queen7 = new Queen(100);
            Queen queen8 = new Queen(100);
            Queen queen9 = new Queen(100);
            Queen queen10 = new Queen(100);

            beeList = new List<Bee>();

            beeList.AddMany(drone1, drone2, drone3, drone4, drone5, drone6, drone7, drone8, drone9,
                drone10, worker1, worker2, worker3, worker4, worker5, worker6, worker7, worker8,
                worker9, worker10, queen1, queen2, queen3, queen4, queen5, queen6, queen7, queen8,
                queen9, queen10);
        }
    }
}
