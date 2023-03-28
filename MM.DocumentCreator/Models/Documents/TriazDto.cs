using System.ComponentModel;

namespace MM.DocumentCreator.Models.Documents
{
    public class TriazDto
    {
        [DisplayName("Kod")]
        public string Code { get; set; } = "C";

        [DisplayName("Data zgłoszenia")]
        public string CompletedAt { get; set; } = DateTime.Now.ToString("dd-MM-yyyy");

        //[DisplayName("Imię i nazwisko osoby przyjmującej zgłoszenie")]
        //public string WorkerName { get; set; } = string.Empty;

        // ----------------- patient-----------------------
        [DisplayName("Imię i nazwisko")]
        public string PatientName { get; set; } = string.Empty;

        [DisplayName("Wiek")]
        public int Age { get; set; }

        [DisplayName("PESEL")]
        public string PersonalGovNumber { get; set; } = string.Empty;

        [DisplayName("Miejsce zamieszkania")]
        public string City { get; set; } = string.Empty;

        [DisplayName("kod pocztowy")]
        public string Postal { get; set; } = string.Empty;

        [DisplayName("Dzielnica")]
        public string District { get; set; } = string.Empty;

        [DisplayName("Adres (ulica, numer)")]
        public string StreetAndNumbers { get; set; } = string.Empty;

        [DisplayName("Klasa, grupa")]
        public string ClassOrGroup { get; set; } = string.Empty;

        //----------------keepers

        [DisplayName("Dane osoby zgłaszającej")]
        public string ReporterDetails { get; set; } = string.Empty;

        [DisplayName("Imiona i nazwiska rodziców/opiekunów prawnych")]
        public string KeeperNames { get; set; } = string.Empty;

        [DisplayName("Z kim mieszka dziecko")]
        public string HomeKeeper { get; set; } = string.Empty;

        [DisplayName("Numer telefonu")]
        public string Phone { get; set; } = string.Empty;

        // -----------------problem-------------------------

        [DisplayName("Proszę opowiedzieć co się dzieje")]
        public string WhatHappened { get; set; } = string.Empty;

        [DisplayName("Skąd się dowiedział Pan/ Pani o programie?")]
        public string HowDidYouGetKnowledgeAboutProgram { get; set; } = string.Empty;

        [DisplayName("Czy dziecko jest pod opieką psychologa lub psychiatry?")]
        public string HasPsychiatristCare { get; set; }

        [DisplayName("Czy posiada diagnozę?")]
        public string HasADiagnosis { get; set; }

        [DisplayName("Czy przyjmuje na stałe leki?")]
        public string IsTakingMedication { get; set; }

        [DisplayName("Czy występowały myśli samobójcze?")]
        public string HasSuicideThoughts { get; set; }

        [DisplayName("Czy dokonywało samookaleczeń?")]
        public string DidSelfMutilation { get; set; }

        [DisplayName(" Osoba z niepełnosprawnościami")]
        public string IsDisabled { get; set; }

        [DisplayName("Osoba bezdomna lub dotknięta wykluczeniem z dostępu do mieszkań")]
        public string Homeless { get; set; }

        [DisplayName("Osoba należąca do mniejszości narodowej lub etnicznej")]
        public string Minority { get; set; }
    }
}
