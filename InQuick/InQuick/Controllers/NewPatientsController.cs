using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using InQuick.Models;

namespace InQuick.Controllers
{
    public class NewPatientsController : Controller
    {
        private readonly InQuickContext _context;

        public NewPatientsController(InQuickContext context)
        {
            _context = context;    
        }

        // GET: NewPatients
        public async Task<IActionResult> Index()
        {
            return View(await _context.NewPatient.ToListAsync());
        }

        // GET: NewPatients/Details/5
        public async Task<IActionResult> Details(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var newPatient = await _context.NewPatient
                .SingleOrDefaultAsync(m => m.ID == id);
            if (newPatient == null)
            {
                return NotFound();
            }

            return View(newPatient);
        }

        // GET: NewPatients/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: NewPatients/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ID,ConsultationDate,DoctorsName,ReferredBy,CaseType,IllnessDetails,TreatmentDetails,PatientName,SSN,PatientStreet,PatientCity,PatientState,PatientZIP,PatientMobilePhone,PatientHomePhone,PatientWorkPhone,PatientEmail,PatientNotes,InstructionsProvided,ReportsAcquired,AppointmentConfirmed,PreAuthorizationCompleted,InsuredsName,InsuredsDOB,InsuredsRelationshipToPatient,InsuredsRelationshipSince,InsuredsEmployer,EmployersPhone,EmployersStreet,EmployersCity,EmployersState,EmployersZip,EmployersNote,InsuredsSupervisor,PrimaryInsuranceProvider,PrimaryInsurancePhone,PrimaryInsuranceID,PrimaryInsuranceStreet,PrimaryInsuranceCity,PrimaryInsuranceState,PrimaryInsuranceZIP,PrimaryInsuranceGroupNumber,PrimaryInsurancePOC,PrimaryInsurancePOCTitle,PrimaryInsurancePOCPhone,PrimaryInsuranceClaimNumber,PrimaryInsuranceNotes,SecondaryInsuranceProvider,SecondaryInsurancePhone,SecondaryInsuranceID,SecondaryInsuranceStreet,SecondaryInsuranceCity,SecondaryInsuranceState,SecondaryInsuranceZIP,SecondaryInsuranceGroupNumber,SecondaryInsurancePOC,SecondaryInsurancePOCTitle,SecondaryInsurancePOCPhone,SecondaryInsuranceClaimNumber,SecondaryInsuranceNotes")] NewPatient newPatient)
        {
            if (ModelState.IsValid)
            {
                newPatient.ID = Guid.NewGuid();
                _context.Add(newPatient);
                await _context.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return View(newPatient);
        }

        // GET: NewPatients/Edit/5
        public async Task<IActionResult> Edit(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var newPatient = await _context.NewPatient.SingleOrDefaultAsync(m => m.ID == id);
            if (newPatient == null)
            {
                return NotFound();
            }
            return View(newPatient);
        }

        // POST: NewPatients/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(Guid id, [Bind("ID,ConsultationDate,DoctorsName,ReferredBy,CaseType,IllnessDetails,TreatmentDetails,PatientName,SSN,PatientStreet,PatientCity,PatientState,PatientZIP,PatientMobilePhone,PatientHomePhone,PatientWorkPhone,PatientEmail,PatientNotes,InstructionsProvided,ReportsAcquired,AppointmentConfirmed,PreAuthorizationCompleted,InsuredsName,InsuredsDOB,InsuredsRelationshipToPatient,InsuredsRelationshipSince,InsuredsEmployer,EmployersPhone,EmployersStreet,EmployersCity,EmployersState,EmployersZip,EmployersNote,InsuredsSupervisor,PrimaryInsuranceProvider,PrimaryInsurancePhone,PrimaryInsuranceID,PrimaryInsuranceStreet,PrimaryInsuranceCity,PrimaryInsuranceState,PrimaryInsuranceZIP,PrimaryInsuranceGroupNumber,PrimaryInsurancePOC,PrimaryInsurancePOCTitle,PrimaryInsurancePOCPhone,PrimaryInsuranceClaimNumber,PrimaryInsuranceNotes,SecondaryInsuranceProvider,SecondaryInsurancePhone,SecondaryInsuranceID,SecondaryInsuranceStreet,SecondaryInsuranceCity,SecondaryInsuranceState,SecondaryInsuranceZIP,SecondaryInsuranceGroupNumber,SecondaryInsurancePOC,SecondaryInsurancePOCTitle,SecondaryInsurancePOCPhone,SecondaryInsuranceClaimNumber,SecondaryInsuranceNotes")] NewPatient newPatient)
        {
            if (id != newPatient.ID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(newPatient);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!NewPatientExists(newPatient.ID))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction("Index");
            }
            return View(newPatient);
        }

        // GET: NewPatients/Delete/5
        public async Task<IActionResult> Delete(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var newPatient = await _context.NewPatient
                .SingleOrDefaultAsync(m => m.ID == id);
            if (newPatient == null)
            {
                return NotFound();
            }

            return View(newPatient);
        }

        // POST: NewPatients/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(Guid id)
        {
            var newPatient = await _context.NewPatient.SingleOrDefaultAsync(m => m.ID == id);
            _context.NewPatient.Remove(newPatient);
            await _context.SaveChangesAsync();
            return RedirectToAction("Index");
        }

        private bool NewPatientExists(Guid id)
        {
            return _context.NewPatient.Any(e => e.ID == id);
        }
    }
}
