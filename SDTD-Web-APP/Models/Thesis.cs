using System;

namespace SDTD_Web_APP.Models
{
    public class Thesis
    {
        public int Id { get; set; }
        public string Emri { get; set; }
        public bool StatusiIAprovimit { get; set; }
        public DateTime DataEAplikimit { get; set; }
        public int StudentId { get; set; }
        public Student Student { get; set; }
        public Professor Professor { get; set; }
    }
}