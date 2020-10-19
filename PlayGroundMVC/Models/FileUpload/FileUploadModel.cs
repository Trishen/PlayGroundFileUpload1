using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace PlayGroundMVC.Models.FileUpload
{
    public class FileUploadModel
    {

        [Key]
        public int FileId { get; set; }
        public byte[] File { get; set; }
        [Display(Name = "File Name")]
        public string FileName { get; set; }


    }
}