using System;
using System.Collections.Generic;
using System.Text;

namespace SmoothWeigthRound
{
    public class Server
    {
        private int weight;
        private int currentWeight;
        private string ip;
        public Server(int weight,int currentWeight,string ip)
        {
            this.weight = weight;
            this.currentWeight = currentWeight;
            this.ip = ip;
        }

        public int getWeight()
        {
            return weight;
        }

        public void setWeight(int weight)
        {
            this.weight = weight;
        }

        public int getCurrentWeight()
        {
            return currentWeight;
        }

        public void setCurrentWeight(int currentWeight)
        {
            this.currentWeight = currentWeight;
        }

        public string getIp()
        {
            return ip;
        }
        public void setIp(string ip)
        {
            this.ip = ip;
        }
    }
}
