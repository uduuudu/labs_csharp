using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamModel
{
    public class Exam
    {
        public string Subject { get; set; }
        public int count_students { get; set; }
        public int count_hours { get; set; }
        public Exam(string s, int c1, int c2) // конструктор
        {
            Subject = s;
            count_students = c1;
            count_hours = c2;
        }
        public virtual double Q() // функция "качества"
        {
            return count_students / Convert.ToDouble(count_hours);
        }


        public virtual string print() // вывод информации об объекте
        {
            return $"Экзамен по дисциплине {Subject}, количество сдающих студентов - {count_students}, количество часов - {count_hours}, качество - {Q()}";
        }
    }
}
