﻿using System;

namespace PracticalTask.Core.APIUtilities
{
    public interface IRepositoryActionResult : IRepositoryResult
    {
        Exception Exception { get; }
        new RepositoryActionStatus Status { get; }

        IRepositoryActionResult GetRepositoryActionResult(object result = null,
            RepositoryActionStatus status = RepositoryActionStatus.BadRequest, Exception exception = null,
            string message = null);
    }
}
