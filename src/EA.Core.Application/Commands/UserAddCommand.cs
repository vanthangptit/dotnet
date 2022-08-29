﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using EA.NetDevPack.Domain;
using EA.NetDevPack.Messaging;
using System;
using System.Collections.Generic;
using EA.Core.Application.Commands.Validations;

namespace EA.Core.Application.Commands
{
    public  class UserAddCommand : UserCommand
    {

        public UserAddCommand(Guid id, string loginId, string? loginName, 
            string fullName, string? email, string? address, string? phone, string? photo,
            int? status)
        {
            Id = id;
            LoginID = loginId;
            LoginName = loginName;
            FullName = fullName;
            Email = email;
            Address = address;
            Phone = phone;
            Photo = photo;
            Status = status;
            CreatedBy = CreatedBy;
        }
        public string CreatedBy { get; set; }
        public override bool IsValid()
        {
            ValidationResult = new UserAddCommandValidation().Validate(this);
            return ValidationResult.IsValid;
        }
    }
}