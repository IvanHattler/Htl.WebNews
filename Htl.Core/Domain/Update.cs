using System;
using System.Collections.Generic;
using System.Text;

namespace Htl.Core.Domain
{
    public class Update : DomainObject<Guid>
    {
        public string Version { get; set; }
        public string Number { get; set; }
        public string Author { get; set; }
        public string Description { get; set; }

        public Update(string version, string number, string author, string description)
        {
            Version = version ?? throw new ArgumentNullException(nameof(version));
            Number = number ?? throw new ArgumentNullException(nameof(number));
            Author = author ?? throw new ArgumentNullException(nameof(author));
            Description = description ?? throw new ArgumentNullException(nameof(description));
        }

        public override DomainObject<Guid> GetCopy()
        {
            return new Update(Version, Number, Author, Description);
        }

        public override string ToString()
        {
            return $"{Version} | {Number} | {Author}";
        }
    }
}
