using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Masterdetails.Models
{
    public class Applicant
    {
        public Applicant()
        {
            ApplicantExes = new List<ApplicantEx>();
        }
        public int Id { get; set; }
        public string Name { get; set; }
        [DataType(DataType.Date)]
        public DateTime Date { get; set; }
        [NotMapped]

        public int TotalEx { get; set; }
        public bool IsAvaiable { get; set; }
        [ValidateNever]
        public string Picpath { get; set; }
        [NotMapped]
        public IFormFile Picture { get; set; }
        public List<ApplicantEx> ApplicantExes { get; set; }

    }
}
