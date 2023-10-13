using System.ComponentModel.DataAnnotations;

namespace FileValidationTask.Utility
{
    public class FileValidation : ValidationAttribute
    {
        private readonly string[] _allowedExtensions;
        private readonly int  _maxSize;
        private readonly int _fileCount;
        public FileValidation(string[] allowedExtensions, int maxSize,int fileCount)
        {
            _allowedExtensions = allowedExtensions;
            _maxSize = maxSize;
            _fileCount = fileCount;

        }

        protected override ValidationResult? IsValid(object? value, ValidationContext validationContext)
        {
            var file = value as IFormFile;

            if (file != null)
            {
                var extension = Path.GetExtension(file.FileName);
                if (!_allowedExtensions.Contains(extension.ToLower()))
                {
                    return new ValidationResult($"File Extension is not supported");
                }
            }

            if (file != null)
            {
                if (file.Length > (1000000 * _maxSize))
                {
                    return new ValidationResult($"The required size for file upload is {_maxSize} MB.");
                }
            }

            return ValidationResult.Success;
        }
    }
}
