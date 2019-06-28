using System;
using System.Collections.Generic;
using System.Text;

namespace Tests
{
    public class DepotCourrier : ValueObject
    {
        public DepotCourrier(string code, string adresse)
        {
            Code = code ?? throw new ArgumentNullException(nameof(code));
            Adresse = adresse ?? throw new ArgumentNullException(nameof(adresse));
        }

        public string Code { get; }
        public string Adresse { get; }

        protected override IEnumerable<object> GetEqualityComponents()
        {
            yield return Code;
            yield return Adresse;
        }

        public override string ToString()
        {
            return $@"Code: ""{Code}"", Adresse: ({Adresse})";
        }
    }
}
