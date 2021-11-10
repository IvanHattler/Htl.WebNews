using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using Htl.Core.Domain;
using Htl.Services.DataInterfaces;

namespace Htl.Data
{
    public class SqlUpdateRepository : IUpdateRepository
    {
        private readonly UpdateContext _updateContext;
        public SqlUpdateRepository(UpdateContext updateContext)
        {
            _updateContext = updateContext
                ?? throw new ArgumentNullException(nameof(updateContext));
        }

        public IEnumerable<Update> GetUpdates()
        {
            return _updateContext.Updates.AsEnumerable();
        }
    }
}
