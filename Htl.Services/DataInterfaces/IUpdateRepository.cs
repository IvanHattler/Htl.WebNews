using Htl.Core.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace Htl.Services.DataInterfaces
{
    public interface IUpdateRepository
    {
        IEnumerable<Update> GetUpdates(int count);
    }
}
