using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace InQuick.Models
{
    public class NewPatient
    {
        public Guid ID { get; set; }

        [DataType(DataType.DateTime)]
        [Display(Name = "Consultation Date:")]
        public DateTime ConsultationDate { get; set; }

        [Display(Name = "Doctors' Name:")]
        public string DoctorsName { get; set; }

        [Display(Name = "Referred By:")]
        public string ReferredBy { get; set; }

        [Display(Name = "Case Type:")]
        public string CaseType { get; set; }

        [Display(Name = "Details of Injury or Illness:")]
        public string IllnessDetails { get; set; }

        [Display(Name = "Details of Treatment:")]
        public string TreatmentDetails { get; set; }

        [Display(Name = "Name:")]
        public string PatientName { get; set; }

        [Display(Name = "SSN:")]
        public string SSN { get; set; }

        [Display(Name = "Address:")]
        public string PatientStreet { get; set; }

        [Display(Name = "City:")]
        public string PatientCity { get; set; }

        [Display(Name = "State:")]
        public string PatientState { get; set; }

        [Display(Name = "ZIP:")]
        public string PatientZIP { get; set; }

        [Display(Name = "Mobile#:")]
        public string PatientMobilePhone { get; set; }

        [Display(Name = "Home#:")]
        public string PatientHomePhone { get; set; }

        [Display(Name = "Work#:")]
        public string PatientWorkPhone { get; set; }

        [Display(Name = "Email:")]
        public string PatientEmail { get; set; }

        [Display(Name = "Notes & Comments:")]
        public string PatientNotes { get; set; }

        [Display(Name = "Pre-visit instructions and directions provided.")]
        public bool InstructionsProvided { get; set; }

        [Display(Name = "Applicable records and reports acquired.")]
        public bool ReportsAcquired { get; set; }

        [Display(Name = "Appointment date and time confirmed.")]
        public bool AppointmentConfirmed { get; set; }

        [Display(Name = "Insurance pre-authorization completed (if required).")]
        public bool PreAuthorizationCompleted { get; set; }

        [Display(Name = "Name:")]
        public string InsuredsName { get; set; }

        [Display(Name = "D.O.B.:")]
        public DateTime InsuredsDOB { get; set; }

        [Display(Name = "Relationship:")]
        public string InsuredsRelationshipToPatient { get; set; }

        [Display(Name = "Since:")]
        public DateTime InsuredsRelationshipSince { get; set; }

        [Display(Name = "Employer:")]
        public string InsuredsEmployer { get; set; }

        [Display(Name = "Phone#:")]
        public string EmployersPhone { get; set; }

        [Display(Name = "Address:")]
        public string EmployersStreet { get; set; }

        [Display(Name = "City:")]
        public string EmployersCity { get; set; }

        [Display(Name = "State:")]
        public string EmployersState { get; set; }

        [Display(Name = "ZIP:")]
        public string EmployersZip { get; set; }

        [Display(Name = "Note:")]
        public string EmployersNote { get; set; }

        [Display(Name = "Supervisor:")]
        public string InsuredsSupervisor { get; set; }

        [Display(Name = "Primary Insurance:")]
        public string PrimaryInsuranceProvider { get; set; }

        [Display(Name = "Phone#:")]
        public string PrimaryInsurancePhone { get; set; }

        [Display(Name = "Insured's ID:")]
        public string PrimaryInsuranceID { get; set; }

        [Display(Name = "Address:")]
        public string PrimaryInsuranceStreet { get; set; }

        [Display(Name = "City:")]
        public string PrimaryInsuranceCity { get; set; }

        [Display(Name = "State:")]
        public string PrimaryInsuranceState { get; set; }

        [Display(Name = "ZIP:")]
        public string PrimaryInsuranceZIP { get; set; }

        [Display(Name = "Group#:")]
        public string PrimaryInsuranceGroupNumber { get; set; }

        [Display(Name = "Contact:")]
        public string PrimaryInsurancePOC { get; set; }

        [Display(Name = "Title:")]
        public string PrimaryInsurancePOCTitle { get; set; }

        [Display(Name = "Phone#:")]
        public string PrimaryInsurancePOCPhone { get; set; }

        [Display(Name = "Claim#:")]
        public string PrimaryInsuranceClaimNumber { get; set; }

        [Display(Name = "Notes:")]
        public string PrimaryInsuranceNotes { get; set; }

        [Display(Name = "Secondary Insurance:")]
        public string SecondaryInsuranceProvider { get; set; }

        [Display(Name = "Phone#:")]
        public string SecondaryInsurancePhone { get; set; }

        [Display(Name = "Insured's ID:")]
        public string SecondaryInsuranceID { get; set; }

        [Display(Name = "Address:")]
        public string SecondaryInsuranceStreet { get; set; }

        [Display(Name = "City:")]
        public string SecondaryInsuranceCity { get; set; }

        [Display(Name = "State:")]
        public string SecondaryInsuranceState { get; set; }

        [Display(Name = "ZIP:")]
        public string SecondaryInsuranceZIP { get; set; }

        [Display(Name = "Group#:")]
        public string SecondaryInsuranceGroupNumber { get; set; }

        [Display(Name = "Contact:")]
        public string SecondaryInsurancePOC { get; set; }

        [Display(Name = "Title:")]
        public string SecondaryInsurancePOCTitle { get; set; }

        [Display(Name = "Phone#:")]
        public string SecondaryInsurancePOCPhone { get; set; }

        [Display(Name = "Claim#:")]
        public string SecondaryInsuranceClaimNumber { get; set; }

        [Display(Name = "Notes:")]
        public string SecondaryInsuranceNotes { get; set; }

    }
}
