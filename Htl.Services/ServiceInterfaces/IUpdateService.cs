using Htl.Core.Domain;
using System;
using System.Collections.Generic;

namespace Htl.Services.ServiceInterfaces
{
    public interface IUpdateService
    {
        IEnumerable<Update> GetUpdates(int count);
    }
}
