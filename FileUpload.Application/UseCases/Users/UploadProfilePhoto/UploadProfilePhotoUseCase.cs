using FileTypeChecker;
using FileTypeChecker.Extensions;
using FileTypeChecker.Types;
using Microsoft.AspNetCore.Http;

namespace FileUpload.Application.UseCases.Users.UploadProfilePhoto;

public class UploadProfilePhotoUseCase
{
    public void Execute(IFormFile file)
    {
        var fileStream = file.OpenReadStream();

        var isImage = fileStream.Is<JointPhotographicExpertsGroup>();
    }
}