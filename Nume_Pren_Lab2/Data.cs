using System.Collections;

namespace Nume_Pren_Lab2
{
    public class Data
    {
        public class Nume_Pren_Lab2Context
        {
            internal IEnumerable Publisher;
            internal IEnumerable<object> Author;

            public object Book { get; internal set; }

            internal Task SaveChangesAsync()
            {
                throw new NotImplementedException();
            }
        }
    }
}