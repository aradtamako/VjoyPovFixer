using CommandLine;

namespace VjoyPovFixer
{
    public class Options
    {
        [Option('i', "index", Required = false, HelpText = "Vjoy device index", Default = 0)]
        public int VjoyDeviceIndex { get; set; }

        [Option('q', "quit", Required = false, HelpText = "Auto quit", Default = false)]
        public bool AutoQuit { get; set; }
    }
}
