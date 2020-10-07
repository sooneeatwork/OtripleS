﻿//---------------------------------------------------------------
// Copyright (c) Coalition of the Good-Hearted Engineers
// FREE TO USE AS LONG AS SOFTWARE FUNDS ARE DONATED TO THE POOR
//----------------------------------------------------------------

using System;
using System.Linq;
using OtripleS.Web.Api.Models.StudentContacts;

namespace OtripleS.Web.Api.Services.StudentContacts
{
    public partial class StudentContactService
    {
        private void ValidateStorageStudentContacts(IQueryable<StudentContact> storageStudentContacts)
        {
            if (!storageStudentContacts.Any())
            {
                this.loggingBroker.LogWarning("No studentContacts found in storage.");
            }
        }
    }
}