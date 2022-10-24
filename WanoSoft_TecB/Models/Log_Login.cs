using System;
using System.ComponentModel.DataAnnotations;

namespace WanoSoft_TecB.Models
{
    public class Log_Login
    {
        public User USER_ID{ get; set; }
        [MinLength(8)]
        public DateTime LOGIN_DATE { get; set; }
        [MinLength(5)]
        public string STATUS_CD { get; set; }
        [MinLength(8)]
        public DateTime CREATE_DATE { get; set; }
        [MinLength(14)]
        public string CREATE_USER { get; set; }
        [MinLength(8)]
        public DateTime UPDATE_DATE { get; set; }
        [MinLength(14)]
        public string UPDATE_USER { get; set; }
    }
}
