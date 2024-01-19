using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson15Task1
{
    internal class School
    {
        public event EventHandler<ChildEventArgs> ChildAddedToSchool;

        private readonly HeadTeacher headTeacher;
        private readonly List<Child> students;

        public IReadOnlyList<Child> Students => students;

        public School(HeadTeacher headTeacher)
        {
            this.headTeacher = headTeacher;
            this.students = new List<Child>();
        }

        public void AddStudentToSchool(Child student)
        {
            students.Add(student);
            headTeacher.ChildAddedToSchoolHandler(this, new ChildEventArgs(student));
            headTeacher.NotifyParents(student.Name);
        }

        public virtual void SubscribeToNursery(Nursery nursery)
        {
            nursery.ChildGraduated += (sender, args) => AddStudentToSchool(args.Child);
        }
    }
}
