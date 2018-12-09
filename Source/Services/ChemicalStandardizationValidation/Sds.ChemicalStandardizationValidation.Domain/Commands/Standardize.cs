﻿using MassTransit;
using System;

namespace Sds.ChemicalStandardizationValidation.Domain.Commands
{
    public interface Standardize : CorrelatedBy<Guid>
    {
        string Bucket { get; }
        Guid BlobId { get; }
        Guid Id { get; }
        Guid UserId { get; }
    }
}