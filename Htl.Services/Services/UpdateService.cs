using Htl.Core.Domain;
using Htl.Services.DataInterfaces;
using Htl.Services.ServiceInterfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Htl.Services.Services
{
    public class UpdateService : IUpdateService
    {
        private readonly IUpdateRepository _repository;
        public UpdateService(IUpdateRepository repository)
        {
            _repository = repository 
                ?? throw new ArgumentNullException(nameof(repository));
        }
        public IEnumerable<Update> GetUpdates()
        {
            return _repository.GetUpdates();
        }
    }
}
