using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Suivi_des_vols.Models
{
    public class Vols
    {
        [Key]
        public int VolId { get; set; }
        public string DepartAirport { get; set; }
        public string DepartLatAirport { get; set; }
        public string DepartLogAirport { get; set; }
        public string DestinationAirport { get; set; }
        public string DestinationtLatAirport { get; set; }
        public string DestinationLogAirport { get; set; }
        public string Distance { get; set; }
        public string QuantiteKerosene { get; set; }


    }
}