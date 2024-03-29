﻿using System;
using System.ComponentModel.DataAnnotations;
using System.Globalization;

namespace CitamChoir.ViewModel
{
    public class FutureDate : ValidationAttribute
    {
        public override bool IsValid(object value)
        {

            var isValid = DateTime.TryParseExact(Convert.ToString(value),
                "d MM yyyy",
                CultureInfo.CurrentCulture,
                DateTimeStyles.None, out DateTime dateTime);

            return isValid;
        }
    }


   
}