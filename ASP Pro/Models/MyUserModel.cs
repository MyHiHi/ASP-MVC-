using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using System.ComponentModel.DataAnnotations;

namespace ASP_Pro.Models
{
    public class MyUserModel
    {
        [Display(Name = "用户名")]
        [Required(ErrorMessage = "用户名不能为空!")]
        [StringLength(20, MinimumLength = 3, ErrorMessage = "用户名必须在3-20个字符之间!")]
        public string userName { get; set; }
        [Display(Name = "密码")]
        [Required(ErrorMessage = "密码不能为空!")]
        [StringLength(20, MinimumLength = 6, ErrorMessage = "密码必须在6-20个字符之间!")]
        public String userPassword { get; set; }
        [Display(Name = "邮箱")]
        [Required(ErrorMessage = "邮箱不能为空!")]
        [RegularExpression(@"[A-Za-z0-9._%+-]+@[A-Za-z0-9.-]+\.[A-Za-z]{2,4}",ErrorMessage = "请输入有效的有效地址!")]
        public string userEmail { get; set; }




        [Display(Name = "手机号")]
        [Required(ErrorMessage = "手机号不能为空!")]
        [StringLength(11, MinimumLength = 11, ErrorMessage = "手机号必须为11位数!")]
        public String userPhone{ get; set; }
   
        [Display(Name = "出生日期")]
        [DataType(DataType.Date)]
        [Required(ErrorMessage = "出生日期不能为空!")]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime?userBirth { get; set; }

        //public MyUserModel()
        //{
        //    userId = "01";
        //    userName = "张三";
        //    userAge = 3;
        //    userBirth = null;

        //}

    }
}