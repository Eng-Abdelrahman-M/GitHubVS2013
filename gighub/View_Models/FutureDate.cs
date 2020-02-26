using System;
using System.ComponentModel.DataAnnotations;
using System.Globalization;

namespace gighub.View_Models
{
    public class FutureDate : ValidationAttribute
    {
        private DateTime dateTime;
        public override bool IsValid(object value)
        {
            var isValid = DateTime.TryParseExact(Convert.ToString(value),
                "dd mm yyyy",
                CultureInfo.CurrentUICulture,
                DateTimeStyles.None,
                out dateTime);

            return (isValid && dateTime > DateTime.Now);
        }
    }
}