using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace LVH_Lesson06.Models
{
    public class LvhSong
    {
        [Key]
        public double Id {get;set; }
        [Required(ErrorMessage="Lvh: Hãy nhập tiêu đề")]
        [DisplayName("Tiêu đề")]
        public string LvhTitle { get; set; }
        [Required(ErrorMessage = "Lvh: Hãy nhập tác giả")]
        [DisplayName("Tác giả")]
        public string LvhAuthor{ get; set; }
        [Required(ErrorMessage = "Lvh: Hãy nhập nghệ sĩ")]
        [StringLength(50,MinimumLength =2, ErrorMessage = "Lvh: Tên nghệ sĩ tối thiểu 2 ký tự, tối đa 50 ký tự")]
        [DisplayName("Nghệ sĩ")]
        public string LvhArtist { get; set; }
        [Required(ErrorMessage = "Lvh: Hãy nhập năm xuất bản")]
        [RegularExpression(@"[0-9],{4}",ErrorMessage ="Lvh: Nhập năm xuất bản có 4 ký tự số")]
        [Range (1900,2024,ErrorMessage ="Năm xuất bản khoảng năm 1900 - 2024")]
        [DisplayName("Năm xuất bản")]
        public int  LvhYearlease { get; set; }

    }
}