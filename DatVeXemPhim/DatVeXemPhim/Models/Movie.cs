using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace DatVeXemPhim.Models
{
    public class Movie
    {
        public int ID { get; set; }
        // Tiêu đề phim
        [Required(ErrorMessage = "A Name is required")]
        public string Title { get; set; }
        // Thể loại 
        public string Genre { get; set; }
        // Ngày phát hành phìm
        [DataType(DataType.Date)]
        [Display(Name = "Release Date (DD/MM/YYYY)")]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
        public DateTime? ReleaseDate { get; set; }   
        // Thời lượng phim                 
        public string Length { get; set; }
        // Đạo diễn phim
        public string Directors { get; set; }
        // Diễn viên
        public string Actor { get; set; }
        // Giới thiệu phim
        public string Intro { get; set; }
        // Đường dẫn trailer phim
        public string TrailerURL { get; set; }

        
        public virtual ICollection<File> Files { get; set; }

    }
}