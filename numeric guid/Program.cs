using System;

namespace numeric_guid
{
    class Program
    {
        static void Main(string[] args)
        {
            var buffer = Guid.NewGuid().ToByteArray();
            var bufferToNumeric = BitConverter.ToInt64(buffer, 0);
            var value = bufferToNumeric.ToString();
            var str = "0" + value.ToString();

            Console.WriteLine($"{str}\n{str.Length}");
        }
    }
}
