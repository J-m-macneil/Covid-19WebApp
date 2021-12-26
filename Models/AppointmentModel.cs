using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MyFirstProjectWebApp.Models
{
    public class AppointmentModel
    {
            
            //Set name's to go above form entries.
            [Required]
            [StringLength(20, MinimumLength =4)]
            [DisplayName("Patient Full Name:")]
            public string PatientName { get; set; }

            [Required]
            [DataType(DataType.Date)]
            [DisplayName("Start Of Covid Symptoms:")]
            public DateTime PatientNetWorth { get; set; }

            [Required]
            [Range(1, 10)]
            [DisplayName("Patient's Percieved Level Of COVID Symptoms (1 Low - 10 High):")]
            public int PainLevel { get; set; }

        [Required]
            [DataType(DataType.Date)]
            [DisplayName("Appointment Request Date:")]
            public DateTime AppointmentDate { get; set; }

            [Required]
            [DisplayName("Patient's Doctor's Last Name:")]
            public string DoctorName { get; set; }

    }
}
