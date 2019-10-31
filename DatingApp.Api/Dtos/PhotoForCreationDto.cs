using System;

namespace DatingApp.Api.Dtos
{
    public class PhotoForCreationDto
    {
        public string Url { get; set; }
        public Microsoft.AspNetCore.Http.IFormFile File { get; set; }

        public string Description { get; set; }
        public DateTime DateAdded { get; set; }
        public string PublicId { get; set; }
    }
}