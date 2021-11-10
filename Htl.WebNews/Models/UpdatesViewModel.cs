using Htl.Core.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Htl.WebNews.Models
{
    public class UpdatesViewModel
    {
        public IEnumerable<UpdateViewModel> Updates { get; }
        public UpdatesViewModel(IEnumerable<UpdateViewModel> updates)
        {
            Updates = updates;
        }
    }
}
