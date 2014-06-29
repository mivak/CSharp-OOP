namespace CommonTypeSystem
{
    using System;
    using System.Collections;
    using System.Collections.Generic;

    public class BitArray64 : IEnumerable<int>
    {
        private readonly ulong[] values;
        private int pos;

        public BitArray64(int length)
        {
            this.values = new ulong[length];
            this.pos = 0;
        }

        public int Length
        {
            get { return this.values.Length; }
        }

        public ulong this[int i]
        {
            get { return this.values[i]; }
            set { this.values[i] = value; }
        }

        public static bool operator ==(BitArray64 a, BitArray64 b)
        {
            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] != b[i])
                {
                    return false;
                }
            }
        
            return true;
        }

        public static bool operator !=(BitArray64 a, BitArray64 b)
        {
            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] != b[i])
                {
                    return false;
                }
            }
            
            return true;
        }

        public void Add(ulong value)
        {
            if (this.pos < this.values.Length)
            {
                this.values[this.pos] = value;
                this.pos++;
            }
            else
            {
                throw new ArgumentOutOfRangeException();
            }
        }

        public override bool Equals(object obj)
        {
            BitArray64 lala = (BitArray64)obj;
            for (int i = 0; i < this.Length; i++)
            {
                if (this[i] != lala[i])
                {
                    return false;
                }
            }
            
            return true;
        }

        public override int GetHashCode()
        {
            unchecked
            {
                ulong hash = 19;
                foreach (var item in this.values)
                {
                    hash += (ulong)item.GetHashCode();
                    hash *= 23;
                }

                hash += (ulong)this.values.Length.GetHashCode();
                return (int)hash;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return (IEnumerator<int>)this.GetEnumerator();
        }

        IEnumerator<int> IEnumerable<int>.GetEnumerator()
        {
            return (IEnumerator<int>)this.GetEnumerator();
        }
        
        public BitArray64Enum GetEnumerator()
        {
            return new BitArray64Enum(this.values);
        }
    }
}