﻿// <autogenerated>
//   This file was generated by T4 code generator DtosCodeScript.tt.
//   Any changes made to this file manually will be lost next time the file is regenerated.
// </autogenerated>


using OSharp.Core.Data;
using System.ComponentModel;
using Bode.Services.Core.Models.User;

namespace Bode.Services.Core.Dtos.User
{
	public partial class FeedBackDto: IAddDto, IEditDto<int>
	{
        public System.Int32 Id { get; set; }
                            public System.String Content { get; set; }
                                        public System.Int32 UserInfoId { get; set; }
                    	}
}
