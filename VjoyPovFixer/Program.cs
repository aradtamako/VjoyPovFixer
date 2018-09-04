using CommandLine;
using System;

namespace VjoyPovFixer
{
    class Program
    {
        static void Main(string[] args)
        {
            var result = Parser.Default.ParseArguments<Options>(args);

            if (result.Tag == ParserResultType.Parsed)
            {
                var parsed = (Parsed<Options>)result;

                int deviceIndex = parsed.Value.VjoyDeviceIndex;

                var vjoy = new VJoy();
                vjoy.Initialize();
                vjoy.Reset();
                vjoy.SetPOV(deviceIndex, 0, VJoy.POVType.Nil);
                vjoy.Update(deviceIndex);
                vjoy.Shutdown();

                Console.WriteLine("successfully finished");
                if (!parsed.Value.AutoQuit)
                {
                    Console.ReadKey();
                }
            }
        }
    }
}
