using Microsoft.AspNetCore.Mvc;
using MM.DocumentCreator.App;
using MM.DocumentCreator.Models.Documents;

namespace MM.DocumentCreator.Controllers
{
    public class TriazController : Controller
    {
        public IActionResult Create()
        {
            return View();
        }

        // POST: Triaz/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        public IActionResult Create([Bind("Code,CompletedAt,PatientName,Age,PersonalGovNumber,City,District,Postal,StreetAndNumbers,ClassOrGroup,ReporterDetails,KeeperNames,HomeKeeper,Phone,WhatHappened,HowDidYouGetKnowledgeAboutProgram,HasPsychiatristCare,HasADiagnosis,IsTakingMedication,HasSuicideThoughts,DidSelfMutilation,IsDisabled,Homeless,Minority")] TriazDto triazDto)
        {
            try
            {
                Districtify(triazDto);

                var templatePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "DocTemplates", "Triaz_vol2.docx");
                var processor = new DocumentProcessor<TriazDto>(templatePath);
                var doc = processor.Process(triazDto);
                var stream = new MemoryStream();
                doc.SaveAs(stream);
                byte[] bytes = stream.ToArray();
                // zapisywanie do pliku - nazwa pliku imie nazwisko data  np. Maja Michalska 21 03 2023
                // PatientName - imię i nazwisko
                // CompletedAt - data

                Response.Headers.Add("content-disposition", $"attachment; filename={triazDto.PatientName}_{DateTime.Now.ToString("dd MM  yyyy")}.docx");
                return File(bytes, "application/vnd.openxmlformats-officedocument.wordprocessingml.document");
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        private void Districtify (TriazDto triazDto)
        {
            if (triazDto.District.ToLower() == "o")
            {
                triazDto.District = "Ochota";
            }

            if (triazDto.District.ToLower() == "u")
            {
                triazDto.District = "Ursus";
            }

            if (triazDto.District.ToLower() == "s")
            {
                triazDto.District = "Śródmieście";
            }
        }
    }
}
