using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Data;

namespace MaterialDesignFlipperProblem
{
    public class IsNotNullOrEmptyValidationRule : ValidationRule
    {
        public override ValidationResult Validate(object value, CultureInfo cultureInfo)
        {
            ValidationResult result = (value != null && !string.IsNullOrWhiteSpace(value.ToString())) ? ValidationResult.ValidResult : new ValidationResult(false, "Field cannot be empty.");
            return result;
        }
    }
}
