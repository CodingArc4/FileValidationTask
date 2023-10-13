using FileValidationTask.Utility;

namespace FileValidationTask.Models
{
    public class FileModel
    {
        //public string Name { get; set; }

        [FileValidation(new string[] {".jpg",".png",".jpeg"},1,3)]
        public List<IFormFile>? Filee { get; set; }
    }
}
