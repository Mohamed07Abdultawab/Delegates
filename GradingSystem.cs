using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates
{
    internal class GradingSystem
    {
        public void DisplayGradingInfo(List<Student> students,
            Func<List<int>,double> calculateAverage,
            Predicate<double>isUserPassed,
            Action<Student,double,bool>displayData)
        {
            foreach (var student in students)
            {
                double averageGrades = calculateAverage.Invoke(student.Grades);
                isUserPassed(averageGrades);
                bool checkIfPassed = isUserPassed.Invoke(averageGrades);
                displayData.Invoke(student, averageGrades, checkIfPassed);
            }
        }
    }
}
