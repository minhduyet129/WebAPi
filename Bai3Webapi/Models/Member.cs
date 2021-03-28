using System;

namespace Bai3Webapi.Models{

    public class Person{ 
            public string FirstName { get; set; }
            public string LastName { get; set; }
            public string Gender { get; set; }
            public DateTime DateOfBirth { get; set; }
            public string Phone { get; set; }
            public string BirthPlace { get; set; }
            public bool IsGraduated { get; set; }
    }
    public class Members:Person
        {
           public DateTime StartDate { get; set; }
            public DateTime EndDate { get; set; }

        }
}
