using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using InQuick.Models;

namespace InQuick.Migrations
{
    [DbContext(typeof(InQuickContext))]
    [Migration("20170727230148_Initial")]
    partial class Initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("ProductVersion", "1.1.2")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("InQuick.Models.NewPatient", b =>
                {
                    b.Property<Guid>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<bool>("AppointmentConfirmed");

                    b.Property<string>("CaseType");

                    b.Property<DateTime>("ConsultationDate");

                    b.Property<string>("DoctorsName");

                    b.Property<string>("EmployersCity");

                    b.Property<string>("EmployersNote");

                    b.Property<string>("EmployersPhone");

                    b.Property<string>("EmployersState");

                    b.Property<string>("EmployersStreet");

                    b.Property<string>("EmployersZip");

                    b.Property<string>("IllnessDetails");

                    b.Property<bool>("InstructionsProvided");

                    b.Property<DateTime>("InsuredsDOB");

                    b.Property<string>("InsuredsEmployer");

                    b.Property<string>("InsuredsName");

                    b.Property<DateTime>("InsuredsRelationshipSince");

                    b.Property<string>("InsuredsRelationshipToPatient");

                    b.Property<string>("InsuredsSupervisor");

                    b.Property<string>("PatientCity");

                    b.Property<string>("PatientEmail");

                    b.Property<string>("PatientHomePhone");

                    b.Property<string>("PatientMobilePhone");

                    b.Property<string>("PatientName");

                    b.Property<string>("PatientNotes");

                    b.Property<string>("PatientState");

                    b.Property<string>("PatientStreet");

                    b.Property<string>("PatientWorkPhone");

                    b.Property<string>("PatientZIP");

                    b.Property<bool>("PreAuthorizationCompleted");

                    b.Property<string>("PrimaryInsuranceCity");

                    b.Property<string>("PrimaryInsuranceClaimNumber");

                    b.Property<string>("PrimaryInsuranceGroupNumber");

                    b.Property<string>("PrimaryInsuranceID");

                    b.Property<string>("PrimaryInsuranceNotes");

                    b.Property<string>("PrimaryInsurancePOC");

                    b.Property<string>("PrimaryInsurancePOCPhone");

                    b.Property<string>("PrimaryInsurancePOCTitle");

                    b.Property<string>("PrimaryInsurancePhone");

                    b.Property<string>("PrimaryInsuranceProvider");

                    b.Property<string>("PrimaryInsuranceState");

                    b.Property<string>("PrimaryInsuranceStreet");

                    b.Property<string>("PrimaryInsuranceZIP");

                    b.Property<string>("ReferredBy");

                    b.Property<bool>("ReportsAcquired");

                    b.Property<string>("SSN");

                    b.Property<string>("SecondaryInsuranceCity");

                    b.Property<string>("SecondaryInsuranceClaimNumber");

                    b.Property<string>("SecondaryInsuranceGroupNumber");

                    b.Property<string>("SecondaryInsuranceID");

                    b.Property<string>("SecondaryInsuranceNotes");

                    b.Property<string>("SecondaryInsurancePOC");

                    b.Property<string>("SecondaryInsurancePOCPhone");

                    b.Property<string>("SecondaryInsurancePOCTitle");

                    b.Property<string>("SecondaryInsurancePhone");

                    b.Property<string>("SecondaryInsuranceProvider");

                    b.Property<string>("SecondaryInsuranceState");

                    b.Property<string>("SecondaryInsuranceStreet");

                    b.Property<string>("SecondaryInsuranceZIP");

                    b.Property<string>("TreatmentDetails");

                    b.HasKey("ID");

                    b.ToTable("NewPatient");
                });
        }
    }
}
