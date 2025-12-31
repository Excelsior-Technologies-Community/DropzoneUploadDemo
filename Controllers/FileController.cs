using DropzoneUploadDemo.Data;
using DropzoneUploadDemo.Models;
using Microsoft.AspNetCore.Mvc;

namespace DropzoneUploadDemo.Controllers
{
    public class FileController : Controller
    {
        private readonly IWebHostEnvironment _env;
        private readonly AppDbContext _db;

        public FileController(IWebHostEnvironment env, AppDbContext db)
        {
            _env = env;
            _db = db;
        }

        public IActionResult Upload()
        {
            var files = _db.UploadedFiles
                .OrderByDescending(x => x.Id)
                .ToList();

            return View(files);
        }

        [HttpPost]
        public IActionResult UploadFile(IFormFile file)
        {
            if (file == null || file.Length == 0)
                return BadRequest();

            var folder = Path.Combine(_env.WebRootPath, "uploads");

            if (!Directory.Exists(folder))
                Directory.CreateDirectory(folder);

            var name = Guid.NewGuid() + Path.GetExtension(file.FileName);
            var path = Path.Combine(folder, name);

            using var stream = new FileStream(path, FileMode.Create);
            file.CopyTo(stream);

            _db.UploadedFiles.Add(new UploadedFile
            {
                FileName = file.FileName,
                
            });

            _db.SaveChanges();

            return Ok();
        }
    }
}
