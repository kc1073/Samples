using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace NonGeneric
{
    class Stackoverflow<T>
    {
        private Func<IConvertible, IFormatProvider, T> convertValue;
        private Func<T, T, T> op;

        public Stackoverflow(Func<IConvertible, IFormatProvider, T> ToGenericValue, Func<T, T, T> opGeneric)
        {
            this.convertValue = ToGenericValue;
            this.op = opGeneric;
        }

        private T convert64(IConvertible val, IFormatProvider f)
        {
            return (T)(IConvertible)val.ToInt64(f);
        }

        /* This is what i want to write */
        public Stackoverflow(Func<T, T, T> opGeneric) 
        {
            //this.convertValue = convert64;
            this.convertValue = (val, f) => { return (T)(IConvertible)val.ToInt64(f); };
            this.op = opGeneric;
        }

        public T Operation<K>(K a, K b) where K : IConvertible
        {
            T aAsT = this.convertValue(a, CultureInfo.InvariantCulture);
            T bAsT = this.convertValue(b, CultureInfo.InvariantCulture);
            return op(aAsT, bAsT);
        }
    }

    class Caller
    {
        Stackoverflow<Int64> op1 = new Stackoverflow<Int64>(
         (x, y) => { return x / y; }
         );

        Stackoverflow<Int64> op2 = new Stackoverflow<Int64>(
            (x, y) => { return x + y; }
            );

        Stackoverflow<Int64> op3 = new Stackoverflow<Int64>(
            (x, y) => { return (x - y) * x; }
            );

        public Int64 CallOp1(Int64 a, Int64 b)
        {
            return op1.Operation(a,b);

        }
        public Int64 CallOp2(Int64 a, Int64 b)
        {
            return op2.Operation(a, b);

        }

        public Int64 CallOp3(Int64 a, Int64 b)
        {
            return op3.Operation(a, b);

        }
    }
}

