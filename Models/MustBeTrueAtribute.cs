using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Controllers2.Models
{
    public class MustBeTrueAtribute : ValidationAttribute 
    {
        public override bool IsValid(object value)     // наслідуєм системний клас ValidationAttribute                                                    
        {                                              // перевизначаєм один метод IsValid, в нашому випадку 
            return value is bool && (bool)value;       // він стоїть перед властивістю тому в якості аргументу буде передаватись значення властивості
        }
    }
}