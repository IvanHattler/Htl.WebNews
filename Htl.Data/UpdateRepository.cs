using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using Htl.Core.Domain;

namespace Htl.Data
{
    public class UpdateRepository
    {
        private readonly UpdateContext _updateContext;
        public UpdateRepository(UpdateContext updateContext)
        {
            _updateContext = updateContext
                ?? throw new ArgumentNullException(nameof(updateContext));
        }

        public IEnumerable<Update> GetUpdates()
        {
            return _updateContext.Updates.Select(u => u);
        }
    }
}
