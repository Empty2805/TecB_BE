using System;
using System.ComponentModel.DataAnnotations;

namespace WanoSoft_TecB.Models
{
    public class User
    {
        public int USER_ID { get; set; }
        [MinLength(200)]
        public string LAST_NM { get; set; }
        [MinLength(200)]
        public string FIRST_NM { get; set; }
        [MinLength(1)]
        public string ROLE_TYPE_CD { get; set; }
        [Required]
        [MinLength(64)]
        public string PASSWORD { get; set; }
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
