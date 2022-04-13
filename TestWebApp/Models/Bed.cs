using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TestWebApp.Models
{
	public class Bed
	{
        public int ID { get; set; }

        [Display(Name = "Bed No")]
        public int BedNo { get; set; }

        public bool Status { get; set; }

        [Display(Name = "Patient Name")]
        public string PatientName { get; set; } = string.Empty;

        [DataType(DataType.Date)]
        public DateTime DOB { get; set; }

        [Display(Name = "Presenting Issue")]
        public string PresentingIssue { get; set; } = string.Empty;

        [Display(Name = "Last Comment")]
        public string LastComment { get; set; } = string.Empty;

        [Display(Name = "Last Modified")]
        public DateTime LastModified { get; set; }

        public string Nurse { get; set; } = string.Empty;
    }
}
