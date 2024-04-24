using System.ComponentModel.DataAnnotations;

namespace WebApp.Validators;

public class ColumnNameAttribute : ValidationAttribute
{
    protected override ValidationResult IsValid(object value, ValidationContext validationContext)
    {
        if (!ValidColumnNames.Contains((string) value))
        {
            return new ValidationResult("Query is not a valid column name");
        }

        return ValidationResult.Success;
    }

    private static readonly string[] ValidColumnNames = new string[] { "name", "description", "category", "area"};
}