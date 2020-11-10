using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using TorreWebapp.Models.JobOpportunity;

namespace TorreWebapp.Models
{
    public class Compensations
    {
        public Compensation freelancer { get; set; }
        public Compensation employee { get; set; }
        public string compensation
        {
            get
            {
                string _compensation = "<ul>";
                if (freelancer != null)
                {
                    _compensation += $"<li>Frelancer: {freelancer.minAmount.GetValueOrDefault()}{freelancer.currency} - {freelancer.maxAmount.GetValueOrDefault()}{freelancer.currency} {freelancer.periodicity}</li>";
                }
                if (employee != null)
                {
                    _compensation += $"<li>Employee: {employee.minAmount.GetValueOrDefault()}{employee.currency} - {employee.maxAmount.GetValueOrDefault()}{employee.currency} {employee.periodicity}</li>";
                }
                _compensation += "</ul>";
                return _compensation;
            }
        }
    }
}
