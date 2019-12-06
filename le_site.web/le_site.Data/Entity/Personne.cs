using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace le_site.Data.Entity
{
    public class Personne
    {
        public int Id { get; set; }
        [StringLength(100)]
        public string Nom { get; set; }
        [StringLength(100)]
        public string Prenom{ get; set; }
        [StringLength(100)]
        public string Adresse { get; set; }
    }
}
