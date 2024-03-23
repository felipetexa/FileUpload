using FileUpload.Application.UseCases.Users.UploadProfilePhoto;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FileUpload.API.Controllers;

[Route("api/[controller]")]
[ApiController]

public class StorageController : ControllerBase
{
    [HttpPost]
    public IActionResult UploadImage(IFormFile file)
    {
        var useCase = new UploadProfilePhotoUseCase();
        
        useCase.Execute(file);
        
        return Created();
    }
}