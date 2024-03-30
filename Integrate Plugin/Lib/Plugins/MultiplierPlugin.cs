using ds.test.impl.Base;
using System.Drawing;

namespace ds.test.impl.Plugins
{
    internal class MultiplierPlugin : PluginBase
    {
        public override string PluginName => "Multiplier";

        public override string Version => "0.1v";

        public override Image Image => null;

        public override string Description => "Multiplies two numbers";

        public override int Run(int input1, int input2)
        {
            return input1 * input2;
        }
    }
}
