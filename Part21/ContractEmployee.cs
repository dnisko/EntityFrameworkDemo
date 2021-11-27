using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Part21
{
    //[Table("ContractEmployees")]
    public class ContractEmployee : Employee
    {
        [Column(Order = 6)]
        public int HoursWorked { get; set; }
        [Column(Order = 7)]
        public int HourlyPay { get; set; }
    }
}