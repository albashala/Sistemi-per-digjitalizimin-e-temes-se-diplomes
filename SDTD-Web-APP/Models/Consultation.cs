using System;

namespace SDTD_Web_APP.Models
{
    public class Consultation
    {
        public int Id { get; set; }
        public DateTime SllotiKohor { get; set; }
        public int StudentId { get; set; }
        public Student Student { get; set; }
        public int ProfessorId { get; set; }
        public  Professor Professor { get; set; }
    }
}