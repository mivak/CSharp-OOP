namespace CommonTypeSystem
{
    using System;
    using System.Collections;

    public class BitArray64Enum : IEnumerator
    {
        private readonly ulong[] values;
        private int position = -1;

        public BitArray64Enum(ulong[] values)
        {
            this.values = values;
        }

        public object Current
        {
            get
            {
                try
                {
                    return this.values[this.position];
                }
                catch (IndexOutOfRangeException)
                {
                    throw new InvalidOperationException();
                }
            }
        }

        public bool MoveNext()
        {
            this.position++;
            return this.position < this.values.LongLength;
        }

        public void Reset()
        {
            this.position = -1;
        }
    }
}