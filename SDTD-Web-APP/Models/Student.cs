using System;

namespace SDTD_Web_APP.Models
{
    public class Student
    {
        public int Id { get; set; }
        public string Emri { get; set; }
        public string Mbiemri { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string Departamenti { get; set; }
        public DateTime DOB { get; set; }
        public bool IsActive { get; set; }
        public Thesis Tema { get; set; }
        public Consultation[] Konsultimet { get; set; }
        public Professor Professor { get; set; }
    }
}
