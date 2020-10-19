using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace PlayGroundMVC.Models.FileUpload
{
    public class FileUploadContext : DbContext 
    {

        public FileUploadContext() : base("name=FileUploadContext")
        {
        }
        public System.Data.Entity.DbSet<FileUpload.FileUploadModel> fileUploadModel { get; set; }



    }
}