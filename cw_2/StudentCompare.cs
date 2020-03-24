using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;

namespace cw_2
{
    class StudentCompare : IEqualityComparer<Student>
    {
        public bool Equals(Student x, Student y)
        {

            if (Student.ReferenceEquals(x, y)) return true;

            //Check whether any of the compared objects is null.
            if (Student.ReferenceEquals(x, null) || Student.ReferenceEquals(y, null))
                return false;

            //Check whether the products' properties are equal.
            return x.Name == y.Name && x.Surname == y.Surname && x.Id_student == y.Id_student;
        }

        // If Equals() returns true for a pair of objects 
        // then GetHashCode() must return the same value for these objects.



        public int GetHashCode(Student student)
        {
            //Check whether the object is null
            if (Student.ReferenceEquals(student, null)) return 0;

            //Get hash code for the Name field if it is not null.
            int hashStudentName = student.Name == null ? 0 : student.Name.GetHashCode();

            //Get hash code for the Code field.
            int hashStudentSurname = student.Surname.GetHashCode();
            int hashStudentId = student.Id_student.GetHashCode();

            //Calculate the hash code for the product.
            return hashStudentId ^ hashStudentName ^ hashStudentSurname;
        }
    }
}









