using System;

namespace Lesson15Task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            HeadTeacher headTeacher = new HeadTeacher();
            School school = new School(headTeacher);
            Nursery nursery = new Nursery();

            school.SubscribeToNursery(nursery);

            school.ChildAddedToSchool += headTeacher.ChildAddedToSchoolHandler;

            Child child1 = new Child("Alice", 5);
            Child child2 = new Child("Bob", 7);
            Child child3 = new Child("Kate", 9);

            nursery.GraduateChild(child1);
            nursery.GraduateChild(child2);
            school.AddStudentToSchool(child3);

            Console.WriteLine("\nList of Students in School:");
            foreach (var student in school.Students)
            {
                Console.WriteLine($"{student.Name}, Age: {student.Age}");
            }

        }
    }
}