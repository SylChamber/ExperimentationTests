using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Tests
{
    public class Groupe<T> : ValueObject
    {
        public Groupe(string nom, IEnumerable<T> elements)
        {
            Nom = nom ?? throw new ArgumentNullException(nameof(nom));
            Elements = elements ?? throw new ArgumentNullException(nameof(elements));
        }

        public string Nom { get; }
        public IEnumerable<T> Elements { get; }

        protected override IEnumerable<object> GetEqualityComponents()
        {
            yield return Nom;

            foreach (var element in Elements)
            {
                yield return element;
            }
        }

        //public override string ToString()
        //{
        //    return $"{Nom}: [{string.Join("; ", Elements.Select(e => e.ToString()))}]";
        //}
    }
}
