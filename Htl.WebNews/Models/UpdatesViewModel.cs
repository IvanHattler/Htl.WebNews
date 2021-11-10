using Htl.Core.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Htl.WebNews.Models
{
    public class UpdatesViewModel
    {
        public IEnumerable<Update> Updates { get; }
        public UpdatesViewModel(IEnumerable<Update> updates)
        {
            Updates = updates;
        }
    }
}
