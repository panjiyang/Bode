﻿using System;
using Bode.Services.Core.Models.User;
using OSharp.Core.Data;

namespace Bode.Services.Core.Dtos.User
{
    public class UserInfoRegistDto : IAddDto
    {
        public int Id { get; set; }
        public string PhoneNo { get; set; }
        public string Password { get; set; }
        public string NickName { get; set; }
        public string HeadPic { get; set; }
        public DateTime BirthDay { get; set; }
        public string Signature { get; set; }
        public string RegistKey { get; set; }
        public Sex Sex { get; set; }
    }
}
