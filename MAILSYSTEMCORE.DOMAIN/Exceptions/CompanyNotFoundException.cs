﻿using MAILSYSTEMCORE.DOMAIN.Exceptions.Base;
using System.Runtime.Serialization;

namespace MAILSYSTEMCORE.DOMAIN.Exceptions;

[Serializable]
public sealed class CompanyNotFoundException : NotFoundException
{
    public CompanyNotFoundException(Guid companyId)
        : base($"The ccompany with the identifier {companyId} was not found.")
    {
    }

    private CompanyNotFoundException(SerializationInfo serializationInfo, StreamingContext streamingContext)
        : base(serializationInfo, streamingContext)
    {
    }
}
