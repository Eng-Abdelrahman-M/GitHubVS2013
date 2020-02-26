using System;
using System.ComponentModel.DataAnnotations;
using System.Globalization;

namespace gighub.View_Models
{
    public class ValidTime : ValidationAttribute
    {
        private DateTime dateTime;
        public override bool IsValid(object value)
        {
            var isValid = DateTime.TryParseExact(Convert.ToString(value),
                "HH:mm",
                CultureInfo.CurrentUICulture,
                DateTimeStyles.None,
                out dateTime);

            return (isValid);
        }
    }
}