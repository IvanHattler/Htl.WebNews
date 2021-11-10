using Htl.Core.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Htl.WebNews.Models
{
    public class UpdateViewModel
    {
        public string SummaryText { get; }
        public UpdateViewModel(Update update)
        {
            SummaryText = update.ToString();
        }
    }
}
