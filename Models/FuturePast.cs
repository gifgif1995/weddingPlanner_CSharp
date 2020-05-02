
using System;
using System.ComponentModel.DataAnnotations;

namespace WeddingPlanner.Models
{
    public class DatePast : ValidationAttribute
    {
        public override bool IsValid(object value)
        {
            DateTime input = Convert.ToDateTime(value);
            return input < DateTime.Now;
        }
    }

    public class DateFuture : ValidationAttribute
    {
        public override bool IsValid(object value)
        {
            DateTime input = Convert.ToDateTime(value);
            return input > DateTime.Now;
        }
    }
}