using System;

namespace SDTD_Web_APP.Models
{
    public class Professor
    {
        public int Id { get; set; }
        public string Emri { get; set; }
        public string Mbiemri { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public DateTime DOB { get; set; }
        public string Titulli { get; set; }
        public bool IsAvailable { get; set; }
        public Consultation[] Konsultimet { get; set; }
        public Student[] Mentoron { get; set; }

    }
}