using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Htl.WebNews.Infrastructure
{
    public class PagingOptions
    {
        public const string Paging = "Paging";

        [Range(1, 1000,
            ErrorMessage = "Value for {0} must be between {1} and {2}.")]
        public int CountOnPage { get; set; }
    }
}
