using ECC.Core.Enums;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;

namespace ECC.Models
{
    public class ResistorViewModels
    {

        [Display(Name="Band A Color")]
        [Required(ErrorMessage="Please select")]
        public ColorEnum BandA { get; set; }

        [Display(Name = "Band B Color")]
        [Required(ErrorMessage = "Please select")]
        public ColorEnum BandB { get; set; }

        [Display(Name = "Band C Color")]
        [Required(ErrorMessage = "Please select")]
        public ColorEnum BandC { get; set; }

        [Display(Name = "Band D Color")]
        [Required(ErrorMessage = "Please select")]
        public ColorEnum BandD { get; set; }

        public IEnumerable<SelectListItem> ComponentValues { get; set; }

        public IEnumerable<SelectListItem> TolenranceValues { get; set; }

        public int ResistorValue { get; set; }

        public double ResistorMaxValue { get; set; }

        public double ResistorMinValue { get; set; }

    }
}