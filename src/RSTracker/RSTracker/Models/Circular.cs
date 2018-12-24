using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace RSTracker.Models
{
    public class Circular
    {
        public Circular()
        {
            CreateDate = DateTime.Now;
            ModifiedDate = DateTime.Now;
            CreatedBy = null;
            ModifiedBy = null;
        }
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id {get; set;}

        [Display(Name = "Ref. No.")]
        public int RequisitionId { get; set; }
        [ForeignKey("RequisitionId")]
        public virtual Requisition Requisition { get; set; }

        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}")]
        [Display(Name = "Posting Of Job Ad Date")]
        public DateTime? CircularDate { get; set; }

        //Added By Rakib
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}")]
        [Display(Name = "End Date Of Posting Job")]
        public DateTime? CircularEndDate { get; set; }

        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}")]
        [Display(Name = "Date Of Forwarding CV To Hiring Manager")]
        public DateTime? SendCVToHiringManagerDate { get; set; }

        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}")]
        [Display(Name = "Date Of Forwarding CV To HR")]
        public DateTime? SendCVToHRDate { get; set; }

        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}")]
        [Display(Name = "Date Of Scheduling Aptitude Test")]
        public DateTime? ScheduleAptitudeTestDate { get; set; }

        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}")]
        [Display(Name = "Date Of Conducitng Aptitude Test")]
        public DateTime? ConductAptitudeTestDate { get; set; }

        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}")]
        [Display(Name = "Date Of Conducitng Technical Test")]
        public DateTime? ConductTechnicalTestDate { get; set; }

        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}")]
        [Display(Name = "Date Of Selection Candidate For Final Interview")]
        public DateTime? FinalInterviewSelectionDate { get; set; }

        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}")]
        [Display(Name = "Date Of Conducting Final Interview")]
        public DateTime? ConductFinalInterviewDate { get; set; }

        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}")]
        [Display(Name = "Reference Check Completion Date")]
        public DateTime? ReferenceCheckDate { get; set; }

        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}")]
        [Display(Name = "Date Of Final Meeting with CEO")]
        public DateTime? FinalMeetingWithCEODate { get; set; }

        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}")]
        [Display(Name = "Date Of Final Completing Medical Test")]
        public DateTime? MedicalTestDate { get; set; }

        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}")]
        [Display(Name = "Date Of Final Handovering Joining Letter")]
        public DateTime? JoiningLetterDate { get; set; }

        [Display(Name = "No. of CV from AD")]
        public int? NoOfCvFromAD { get; set; }

        [Display(Name = "No of CV from Online")]
        public int? NoOfCvFromOnline { get; set; }

        [Display(Name = "No. of hard copy CV")]
        public int? NoOfCvFromHardcopy { get; set; }

        [Display(Name = "No. of CV From Ref")]
        public int? NoOfCvFromRef { get; set; }

        [Display(Name = "CV sent to line manager")]
        public int? CvSendtoLM { get; set; }

        [Display(Name = "Sorted CV from line manager")]
        public int? SortedCvFromLM { get; set; }

        //Final selected candidate for interview
        [Display(Name = "Final Candidates")]
        public int? FinalSelectedCandidate { get; set; }

        //[Display(Name = "Written Test Date")]
        //[DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}")]
        //public DateTime? WrittentestDate { get; set; }
 
        [Display(Name = "Written test pass candidates")]
        public int? WrittenTestPassedCandidate { get; set; }

        //[Display(Name = "Viva date")]
        //[DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}")]
        //public DateTime? VivaDate { get; set; }

        [Display(Name = "No. of candidates for viva")]
        public int? VivaCandidate { get; set; }

        [Display(Name = "No. of candidate for final viva")]
        public int? FinalVivaCandidate { get; set; }

        [Display(Name = "Reference check")]
        public string ReferenceCheck { get; set; }

        //[Display(Name = "Final meeting with CEO")]
        //public string FinalMeetingWithCEO { get; set; }

        [Display(Name = "Selected candidate details")]
        public string SelectedCandidateDetails { get; set; }

        //[Display(Name = "AL Issue Date")]
        //[DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}")]
        //public DateTime? ALIssueDate { get; set; }

        //[Display(Name = "Date of joining")]
        //[DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}")]
        //public DateTime? DateOfJoining { get; set; }

        [Display(Name = "Process length")]
        public int? ProcessLength { get; set; }

        public DateTime CreateDate { get; set; }
        public DateTime ModifiedDate { get; set; }

        //User Id
        public string CreatedBy { get; set; }
        public string ModifiedBy { get; set; }

    }
}