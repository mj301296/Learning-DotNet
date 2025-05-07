
        Console.WriteLine("{0,-10} {1,10} {2,30} {3,30}", "Type", "Bytes", "Min Value", "Max Value");

        PrintTypeInfo<sbyte>("sbyte");
        PrintTypeInfo<byte>("byte");
        PrintTypeInfo<short>("short");
        PrintTypeInfo<ushort>("ushort");
        PrintTypeInfo<int>("int");
        PrintTypeInfo<uint>("uint");
        PrintTypeInfo<long>("long");
        PrintTypeInfo<ulong>("ulong");
        PrintTypeInfo<float>("float");
        PrintTypeInfo<double>("double");
        PrintTypeInfo<decimal>("decimal");

        Console.ReadLine();

    static void PrintTypeInfo<T>(string typeName) where T : struct, IComparable
    {
        var size = System.Runtime.InteropServices.Marshal.SizeOf(typeof(T));
        var min = (T)typeof(T).GetField("MinValue")?.GetValue(null);
        var max = (T)typeof(T).GetField("MaxValue")?.GetValue(null);

        Console.WriteLine("{0,-10} {1,10} {2,30} {3,30}", typeName, size, min, max);
    }