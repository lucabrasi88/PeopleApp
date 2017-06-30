using System.ComponentModel;
using System.Globalization;
using System.Windows.Controls;
using System.Windows.Data;

namespace PeopleApp.Validation
{
    public class CellDataInfoValidationRule : ValidationRule
    {
        public override ValidationResult Validate(object value,
                                         CultureInfo cultureInfo)
        {
            // Obtains the bound business object
            BindingExpression expression = value as BindingExpression;
            IDataErrorInfo info = expression.DataItem as IDataErrorInfo;

            // Determines the binding path
            string boundProperty = expression.ParentBinding.Path.Path;

            // Obtains any errors relating to this bound property
            string error = info[boundProperty];
            if (!string.IsNullOrEmpty(error))
            {
                return new ValidationResult(false, error);
            }

            return ValidationResult.ValidResult;
        }
    }
}
