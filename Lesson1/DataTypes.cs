using System;

class DataTypes
{
    static void Main()
    {
        Console.WriteLine("ЧИСЛОВЫЕ (целочисленные) ТИПЫ:");
        PrintTypeInfo("byte", ".NET Byte", sizeof(byte), byte.MinValue, byte.MaxValue);
        PrintTypeInfo("sbyte", ".NET SByte", sizeof(sbyte), sbyte.MinValue, sbyte.MaxValue);
        PrintTypeInfo("short", ".NET Int16", sizeof(short), short.MinValue, short.MaxValue);
        PrintTypeInfo("ushort", ".NET UInt16", sizeof(ushort), ushort.MinValue, ushort.MaxValue);
        PrintTypeInfo("int", ".NET Int32", sizeof(int), int.MinValue, int.MaxValue);
        PrintTypeInfo("uint", ".NET UInt32", sizeof(uint), uint.MinValue, uint.MaxValue);
        PrintTypeInfo("long", ".NET Int64", sizeof(long), long.MinValue, long.MaxValue);
        PrintTypeInfo("ulong", ".NET UInt64", sizeof(ulong), ulong.MinValue, ulong.MaxValue);

        Console.WriteLine("\nЧИСЛОВЫЕ (с плавающей точкой) ТИПЫ:");
        PrintTypeInfo("float", ".NET Single", sizeof(float), float.MinValue, float.MaxValue);
        PrintTypeInfo("double", ".NET Double", sizeof(double), double.MinValue, double.MaxValue);
        PrintTypeInfo("decimal", ".NET Decimal", sizeof(decimal), decimal.MinValue, decimal.MaxValue);

        Console.WriteLine("\nСИМВОЛЬНЫЕ ТИПЫ:");
        PrintTypeInfo("char", ".NET Char", sizeof(char), "?", "?");
        PrintTypeInfo("string", ".NET String", "N/A", "N/A", "N/A");

        Console.WriteLine("\nЛОГИЧЕСКИЙ ТИП:");
        PrintTypeInfo("bool", ".NET Boolean", sizeof(bool), false, true);

        Console.WriteLine("\nОСОБЫЕ ТИПЫ:");
        PrintTypeInfo("object", ".NET Object", "N/A", "N/A", "N/A");
        PrintTypeInfo("dynamic", "N/A", "N/A", "N/A", "N/A");
    }

    static void PrintTypeInfo<T>(string typeName, string dotNetType, T size, object min, object max)
    {
        Console.WriteLine($"Тип {typeName,-8} | {dotNetType,-10} | Размер = {size,-3} | MIN = {min,-30} | MAX = {max}");
    }
}
