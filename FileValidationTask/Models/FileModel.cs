using FileValidationTask.Utility;

namespace FileValidationTask.Models
{
    public class FileModel
    {
        [FileValidation(new string[] {".jpg",".png",".jpeg"},1,3)]
        public List<IFormFile>? Filee { get; set; }
    }
}