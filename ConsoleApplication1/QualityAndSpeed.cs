using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    public class QualityAndSpeed
    {
        private List<int> qualityList;
        private double speedFactor;

        public QualityAndSpeed(List<int> qualityList, double speedFactor)
        {
            this.qualityList = new List<int>(qualityList);
            this.speedFactor = speedFactor;
        }

        public List<int> QualityList
        {
            get { return qualityList; }
            set { qualityList = value; }
        }
        public double SpeedFactor
        {
            get { return speedFactor; }
            set { speedFactor = value; }
        }
        public List<int> MakeExtendQualityList()
        {
            List<int> listExtend = new List<int>();
            for (int i = 0; i < qualityList[0]; i++)
            {
                listExtend.Add(1);
            }
            for (int i = 0; i < qualityList[1]; i++)
            {
                listExtend.Add(2);
            }
            for (int i = 0; i < qualityList[2]; i++)
            {
                listExtend.Add(3);
            }
            for (int i = 0; i < qualityList[3]; i++)
            {
                listExtend.Add(4);
            }
            for (int i = 0; i < qualityList[4]; i++)
            {
                listExtend.Add(5);
            }
            return listExtend;
        }
        public static QualityAndSpeed operator +(QualityAndSpeed object1, QualityAndSpeed object2)
        {
            List<int> quList = new List<int>() { object1.qualityList[0]+ object2.qualityList[0], object1.qualityList[1] + object2.qualityList[1],
            object1.qualityList[2]+ object2.qualityList[2],object1.qualityList[3]+ object2.qualityList[3],
            object1.qualityList[4]+ object2.qualityList[4],};
            double spFactor = object1.SpeedFactor + object2.SpeedFactor;
            return new QualityAndSpeed(quList, spFactor);
        }


    }
}
