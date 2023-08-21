using System;
using System.Linq;
using BasicCRUDAppEF;

class Program
{
    static void Main()
    {
        try
        {

            using (var context = new ApplicationDbContext())
            {
                // Create
                var newStudent = new Student { FirstName = "Orhun", LastName = "Sabah" };
                context.Students.Add(newStudent);

                var newStudent2 = new Student { FirstName = "Mehmet", LastName = "Gume" };
                context.Students.Add(newStudent2);

                var newStudent3 = new Student { FirstName = "Ebru", LastName = "Basgoynuk" };
                context.Students.Add(newStudent3);

                var newStudent4 = new Student { FirstName = "Emre", LastName = "Durmuş" };
                context.Students.Add(newStudent4);
                context.SaveChanges();



                // Read
                var students = context.Students.ToList();
                foreach (var student in students)
                {
                    Console.WriteLine($"Student ID: {student.Id}, Name: {student.FirstName} {student.LastName}");
                }

                // Update
                var studentToUpdate = context.Students.FirstOrDefault(s => s.FirstName == "Orhun");
                if (studentToUpdate != null)
                {
                    studentToUpdate.LastName = "Smith";
                    context.SaveChanges();
                }

                // Delete
                var studentToDelete = context.Students.FirstOrDefault(s => s.LastName == "Sabah");
                if (studentToDelete != null)
                {
                    context.Students.Remove(studentToDelete);
                    context.SaveChanges();
                }
            }
        }

        catch (Exception ex)
        {
            Console.WriteLine("Hata oluştu:");
            Console.WriteLine(ex.Message);
        }
        Console.ReadLine();
    }
}


