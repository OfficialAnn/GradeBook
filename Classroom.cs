using System;
using System.Collections.Generic;
using System.Linq;

namespace GradeBook
{
    public class ClassRoom
    {
        private static readonly Random Random = new Random();
        private readonly int _numberOfStudent;
        private readonly List<int> _scores = new List<int>();

        public ClassRoom()
        {
            _numberOfStudent = Random.Next(1, 100);
            for (int i = 0; i < _numberOfStudent; i++)
            {
                int score = new Random().Next(1, 100);
                _scores.Add(score);
            }
        }
        
        public void GetClassInfo()
        {
            Console.WriteLine($"{_numberOfStudent} students sat for an exam");
            Console.WriteLine($"{_scores.Where(x => x > 70).ToList().Count} passed the exam");
            Console.WriteLine($"{_scores.Where(x => x > 50 & x < 70).ToList().Count} scored between 50 and 69");
            Console.WriteLine($"{_scores.Where(x => x < 50).ToList().Count} failed the exam");
        }
        
        

    }
}
