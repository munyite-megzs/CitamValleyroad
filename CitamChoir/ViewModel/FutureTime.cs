using System;
using System.ComponentModel.DataAnnotations;
using System.Globalization;

namespace CitamChoir.ViewModel
{
    public class FutureTime : ValidationAttribute
    {
            public override bool IsValid(object value)
            {

                var isValid = DateTime.TryParseExact(Convert.ToString(value),
                    "HH:MM",
                    CultureInfo.CurrentCulture,
                    DateTimeStyles.None, out DateTime dateTime);

                return isValid;
            }
        }
}
