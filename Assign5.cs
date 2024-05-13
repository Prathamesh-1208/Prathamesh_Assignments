using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharpBasics
{
    interface Salary
    {
        float calchra(float basic);
        float calcda(float basic);
    }

  

    class trainersal : Salary
    {
        public float calchra(float basic)
        {
            return basic * 0.1f;
        }

        public float calcda(float basic)
        {
            return basic * 0.05f;
        }
    }

    class ProjectManager : Salary
    {
        public float calchra(float basic)
        {
            return basic * 0.2f;
        }

        public float calcda(float basic)
        {
            return basic * 0.1f;
        }
    }

    class useinterface
    {
        public static void Main(string[] args)
        {
            trainersal obj1 = new trainersal();
            ProjectManager obj2 = new ProjectManager();

            float trainerhra = obj1.calchra(3400000);
            float trainerda = obj1.calcda(320000);
            float pmhra = obj2.calchra(500000);
            float pmda = obj2.calcda(450000);

            Console.WriteLine("HRA of Trainer Salary : " + trainerhra);
            Console.WriteLine("DA of Trainer Salary : " + trainerda);
            Console.WriteLine("******************");

            Console.WriteLine("HRA of Project Manager Salary : " +  pmhra);
            Console.WriteLine("DA of Project Manager Salary : " +  pmda);
        }
    }
}
