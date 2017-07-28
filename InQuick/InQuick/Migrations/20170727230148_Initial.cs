using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;

namespace InQuick.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "NewPatient",
                columns: table => new
                {
                    ID = table.Column<Guid>(nullable: false),
                    AppointmentConfirmed = table.Column<bool>(nullable: false),
                    CaseType = table.Column<string>(nullable: true),
                    ConsultationDate = table.Column<DateTime>(nullable: false),
                    DoctorsName = table.Column<string>(nullable: true),
                    EmployersCity = table.Column<string>(nullable: true),
                    EmployersNote = table.Column<string>(nullable: true),
                    EmployersPhone = table.Column<string>(nullable: true),
                    EmployersState = table.Column<string>(nullable: true),
                    EmployersStreet = table.Column<string>(nullable: true),
                    EmployersZip = table.Column<string>(nullable: true),
                    IllnessDetails = table.Column<string>(nullable: true),
                    InstructionsProvided = table.Column<bool>(nullable: false),
                    InsuredsDOB = table.Column<DateTime>(nullable: false),
                    InsuredsEmployer = table.Column<string>(nullable: true),
                    InsuredsName = table.Column<string>(nullable: true),
                    InsuredsRelationshipSince = table.Column<DateTime>(nullable: false),
                    InsuredsRelationshipToPatient = table.Column<string>(nullable: true),
                    InsuredsSupervisor = table.Column<string>(nullable: true),
                    PatientCity = table.Column<string>(nullable: true),
                    PatientEmail = table.Column<string>(nullable: true),
                    PatientHomePhone = table.Column<string>(nullable: true),
                    PatientMobilePhone = table.Column<string>(nullable: true),
                    PatientName = table.Column<string>(nullable: true),
                    PatientNotes = table.Column<string>(nullable: true),
                    PatientState = table.Column<string>(nullable: true),
                    PatientStreet = table.Column<string>(nullable: true),
                    PatientWorkPhone = table.Column<string>(nullable: true),
                    PatientZIP = table.Column<string>(nullable: true),
                    PreAuthorizationCompleted = table.Column<bool>(nullable: false),
                    PrimaryInsuranceCity = table.Column<string>(nullable: true),
                    PrimaryInsuranceClaimNumber = table.Column<string>(nullable: true),
                    PrimaryInsuranceGroupNumber = table.Column<string>(nullable: true),
                    PrimaryInsuranceID = table.Column<string>(nullable: true),
                    PrimaryInsuranceNotes = table.Column<string>(nullable: true),
                    PrimaryInsurancePOC = table.Column<string>(nullable: true),
                    PrimaryInsurancePOCPhone = table.Column<string>(nullable: true),
                    PrimaryInsurancePOCTitle = table.Column<string>(nullable: true),
                    PrimaryInsurancePhone = table.Column<string>(nullable: true),
                    PrimaryInsuranceProvider = table.Column<string>(nullable: true),
                    PrimaryInsuranceState = table.Column<string>(nullable: true),
                    PrimaryInsuranceStreet = table.Column<string>(nullable: true),
                    PrimaryInsuranceZIP = table.Column<string>(nullable: true),
                    ReferredBy = table.Column<string>(nullable: true),
                    ReportsAcquired = table.Column<bool>(nullable: false),
                    SSN = table.Column<string>(nullable: true),
                    SecondaryInsuranceCity = table.Column<string>(nullable: true),
                    SecondaryInsuranceClaimNumber = table.Column<string>(nullable: true),
                    SecondaryInsuranceGroupNumber = table.Column<string>(nullable: true),
                    SecondaryInsuranceID = table.Column<string>(nullable: true),
                    SecondaryInsuranceNotes = table.Column<string>(nullable: true),
                    SecondaryInsurancePOC = table.Column<string>(nullable: true),
                    SecondaryInsurancePOCPhone = table.Column<string>(nullable: true),
                    SecondaryInsurancePOCTitle = table.Column<string>(nullable: true),
                    SecondaryInsurancePhone = table.Column<string>(nullable: true),
                    SecondaryInsuranceProvider = table.Column<string>(nullable: true),
                    SecondaryInsuranceState = table.Column<string>(nullable: true),
                    SecondaryInsuranceStreet = table.Column<string>(nullable: true),
                    SecondaryInsuranceZIP = table.Column<string>(nullable: true),
                    TreatmentDetails = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NewPatient", x => x.ID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "NewPatient");
        }
    }
}
