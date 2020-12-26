﻿using Hospital_System_Demo.Doctors_Nurses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital_System_Demo.Patients
{
    public class Pregled
    {
        public int Id { get; set; }
        public virtual Pacijent Pacijent { get; set; }
        public virtual Doktor Doktor { get; set; }
        public virtual MedicinskaSestra Tehnicar { get; set; }
        public virtual Dijagnoza Dijagnoza { get; set; }
        public string Datum { get; set; }
        public string OpisTrenutnogStanja { get; set; }
        public bool AktivanPregled { get; set; }

    }
}