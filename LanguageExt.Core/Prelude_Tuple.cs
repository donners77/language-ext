﻿using System;

namespace LanguageExt
{
    /// <summary>
    /// Usage:  Add 'using LanguageExt.Prelude' to your code.
    /// </summary>
    public static partial class Prelude
    {
        public static Tuple<T1, T2> tuple<T1, T2>(T1 item1, T2 item2) =>
            Tuple.Create(item1, item2);

        public static Tuple<T1, T2, T3> tuple<T1, T2, T3>(T1 item1, T2 item2, T3 item3) =>
            Tuple.Create(item1, item2, item3);

        public static Tuple<T1, T2, T3, T4> tuple<T1, T2, T3, T4>(T1 item1, T2 item2, T3 item3, T4 item4) =>
            Tuple.Create(item1, item2, item3, item4);

        public static Tuple<T1, T2, T3, T4, T5> tuple<T1, T2, T3, T4, T5>(T1 item1, T2 item2, T3 item3, T4 item4, T5 item5) =>
            Tuple.Create(item1, item2, item3, item4, item5);

        public static Tuple<T1, T2, T3, T4, T5, T6> tuple<T1, T2, T3, T4, T5, T6>(T1 item1, T2 item2, T3 item3, T4 item4, T5 item5, T6 item6) =>
            Tuple.Create(item1, item2, item3, item4, item5, item6);

        public static Tuple<T1, T2, T3, T4, T5, T6, T7> tuple<T1, T2, T3, T4, T5, T6, T7>(T1 item1, T2 item2, T3 item3, T4 item4, T5 item5, T6 item6, T7 item7) =>
            Tuple.Create(item1, item2, item3, item4, item5, item6, item7);

        public static R map<T1, T2, R>(Tuple<T1, T2> self, Func<T1, T2, R> func) =>
            func(self.Item1, self.Item2);

        public static R map<T1, T2, T3, R>(Tuple<T1, T2, T3> self, Func<T1, T2, T3, R> func) =>
            func(self.Item1, self.Item2, self.Item3);

        public static R map<T1, T2, T3, T4, R>(Tuple<T1, T2, T3, T4> self, Func<T1, T2, T3, T4, R> func) =>
            func(self.Item1, self.Item2, self.Item3, self.Item4);

        public static R map<T1, T2, T3, T4, T5, R>(Tuple<T1, T2, T3, T4, T5> self, Func<T1, T2, T3, T4, T5, R> func) =>
            func(self.Item1, self.Item2, self.Item3, self.Item4, self.Item5);

        public static R map<T1, T2, T3, T4, T5, T6, R>(Tuple<T1, T2, T3, T4, T5, T6> self, Func<T1, T2, T3, T4, T5, T6, R> func) =>
            func(self.Item1, self.Item2, self.Item3, self.Item4, self.Item5, self.Item6);

        public static R map<T1, T2, T3, T4, T5, T6, T7, R>(Tuple<T1, T2, T3, T4, T5, T6, T7> self, Func<T1, T2, T3, T4, T5, T6, T7, R> func) =>
            func(self.Item1, self.Item2, self.Item3, self.Item4, self.Item5, self.Item6, self.Item7);

        public static Unit map<T1, T2>(Tuple<T1, T2> self, Action<T1, T2> func)
        {
            func(self.Item1, self.Item2);
            return Unit.Default;
        }

        public static Unit map<T1, T2, T3>(Tuple<T1, T2, T3> self, Action<T1, T2, T3> func)
        {
            func(self.Item1, self.Item2, self.Item3);
            return Unit.Default;
        }

        public static Unit map<T1, T2, T3, T4>(Tuple<T1, T2, T3, T4> self, Action<T1, T2, T3, T4> func)
        {
            func(self.Item1, self.Item2, self.Item3, self.Item4);
            return Unit.Default;
        }

        public static Unit map<T1, T2, T3, T4, T5>(Tuple<T1, T2, T3, T4, T5> self, Action<T1, T2, T3, T4, T5> func)
        {
            func(self.Item1, self.Item2, self.Item3, self.Item4, self.Item5);
            return Unit.Default;
        }

        public static Unit map<T1, T2, T3, T4, T5, T6>(Tuple<T1, T2, T3, T4, T5, T6> self, Action<T1, T2, T3, T4, T5, T6> func)
        {
            func(self.Item1, self.Item2, self.Item3, self.Item4, self.Item5, self.Item6);
            return Unit.Default;
        }

        public static Unit map<T1, T2, T3, T4, T5, T6, T7>(Tuple<T1, T2, T3, T4, T5, T6, T7> self, Action<T1, T2, T3, T4, T5, T6, T7> func)
        {
            func(self.Item1, self.Item2, self.Item3, self.Item4, self.Item5, self.Item6, self.Item7);
            return Unit.Default;
        }


        [Obsolete("'with' has been renamed to 'map', please use that instead")]
        public static R with<T1, T2, R>(Tuple<T1, T2> self, Func<T1, T2, R> func) =>
            func(self.Item1, self.Item2);

        [Obsolete("'with' has been renamed to 'map', please use that instead")]
        public static R with<T1, T2, T3, R>(Tuple<T1, T2, T3> self, Func<T1, T2, T3, R> func) =>
            func(self.Item1, self.Item2, self.Item3);

        [Obsolete("'with' has been renamed to 'map', please use that instead")]
        public static R with<T1, T2, T3, T4, R>(Tuple<T1, T2, T3, T4> self, Func<T1, T2, T3, T4, R> func) =>
            func(self.Item1, self.Item2, self.Item3, self.Item4);

        [Obsolete("'with' has been renamed to 'map', please use that instead")]
        public static R with<T1, T2, T3, T4, T5, R>(Tuple<T1, T2, T3, T4, T5> self, Func<T1, T2, T3, T4, T5, R> func) =>
            func(self.Item1, self.Item2, self.Item3, self.Item4, self.Item5);

        [Obsolete("'with' has been renamed to 'map', please use that instead")]
        public static R with<T1, T2, T3, T4, T5, T6, R>(Tuple<T1, T2, T3, T4, T5, T6> self, Func<T1, T2, T3, T4, T5, T6, R> func) =>
            func(self.Item1, self.Item2, self.Item3, self.Item4, self.Item5, self.Item6);

        [Obsolete("'with' has been renamed to 'map', please use that instead")]
        public static R with<T1, T2, T3, T4, T5, T6, T7, R>(Tuple<T1, T2, T3, T4, T5, T6, T7> self, Func<T1, T2, T3, T4, T5, T6, T7, R> func) =>
            func(self.Item1, self.Item2, self.Item3, self.Item4, self.Item5, self.Item6, self.Item7);

        [Obsolete("'with' has been renamed to 'map', please use that instead")]
        public static Unit with<T1, T2>(Tuple<T1, T2> self, Action<T1, T2> func)
        {
            func(self.Item1, self.Item2);
            return Unit.Default;
        }

        [Obsolete("'with' has been renamed to 'map', please use that instead")]
        public static Unit with<T1, T2, T3>(Tuple<T1, T2, T3> self, Action<T1, T2, T3> func)
        {
            func(self.Item1, self.Item2, self.Item3);
            return Unit.Default;
        }

        [Obsolete("'with' has been renamed to 'map', please use that instead")]
        public static Unit with<T1, T2, T3, T4>(Tuple<T1, T2, T3, T4> self, Action<T1, T2, T3, T4> func)
        {
            func(self.Item1, self.Item2, self.Item3, self.Item4);
            return Unit.Default;
        }

        [Obsolete("'with' has been renamed to 'map', please use that instead")]
        public static Unit with<T1, T2, T3, T4, T5>(Tuple<T1, T2, T3, T4, T5> self, Action<T1, T2, T3, T4, T5> func)
        {
            func(self.Item1, self.Item2, self.Item3, self.Item4, self.Item5);
            return Unit.Default;
        }

        [Obsolete("'with' has been renamed to 'map', please use that instead")]
        public static Unit with<T1, T2, T3, T4, T5, T6>(Tuple<T1, T2, T3, T4, T5, T6> self, Action<T1, T2, T3, T4, T5, T6> func)
        {
            func(self.Item1, self.Item2, self.Item3, self.Item4, self.Item5, self.Item6);
            return Unit.Default;
        }

        [Obsolete("'with' has been renamed to 'map', please use that instead")]
        public static Unit with<T1, T2, T3, T4, T5, T6, T7>(Tuple<T1, T2, T3, T4, T5, T6, T7> self, Action<T1, T2, T3, T4, T5, T6, T7> func)
        {
            func(self.Item1, self.Item2, self.Item3, self.Item4, self.Item5, self.Item6, self.Item7);
            return Unit.Default;
        }
    }
}
