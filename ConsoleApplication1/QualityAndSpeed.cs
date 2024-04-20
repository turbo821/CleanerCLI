using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    public class QualityAndSpeed
    {
        public QualityAndSpeed() { }
        public QualityAndSpeed(List<int> qualityList, double speedFactor)
        {
            this.QualityList = new List<int>(qualityList);
            this.SpeedFactor = speedFactor;
        }

        public List<int> QualityList { get; set; }
        public double SpeedFactor { get; set; }

        public List<int> MakeExtendQualityList()
        {
            List<int> listExtend = new List<int>();
            for (int i = 0; i < QualityList[0]; i++)
            {
                listExtend.Add(1);
            }
            for (int i = 0; i < QualityList[1]; i++)
            {
                listExtend.Add(2);
            }
            for (int i = 0; i < QualityList[2]; i++)
            {
                listExtend.Add(3);
            }
            for (int i = 0; i < QualityList[3]; i++)
            {
                listExtend.Add(4);
            }
            for (int i = 0; i < QualityList[4]; i++)
            {
                listExtend.Add(5);
            }
            return listExtend;
        }
        public string DisplayList()
        {
            return "[ " + QualityList[0] + " " + QualityList[1] + " " + QualityList[2] + " " + QualityList[3] + " " + QualityList[4] + " ]";
        }
        public static QualityAndSpeed operator +(QualityAndSpeed object1, QualityAndSpeed object2)
        {
            List<int> quList = new List<int>() { object1.QualityList[0] + object2.QualityList[0], object1.QualityList[1] + object2.QualityList[1],
            object1.QualityList[2] + object2.QualityList[2],object1.QualityList[3] + object2.QualityList[3],
            object1.QualityList[4] + object2.QualityList[4]};
            double spFactor = Math.Round(object1.SpeedFactor * object2.SpeedFactor, 2);
            return new QualityAndSpeed(quList, spFactor);
        }


    }
}
