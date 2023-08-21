using System;
using System.ComponentModel.DataAnnotations;

namespace BasicCRUDAppEF
{
    public class Student
    {
        [Key]
        public int Id { get; set; }

       
        public string ?FirstName { get; set; }

        
        public string ?LastName { get; set; }
    }
}

