using ds.test.impl.Base;
using System.Drawing;

namespace ds.test.impl.Plugins
{
    internal class SumPlugin : PluginBase
    {
        public override string PluginName => "Sum Plugin";

        public override string Version => "0.1v";

        public override Image Image => null;

        public override string Description => "Sum two numbers";

        public override int Run(int input1, int input2)
        {
            return input1 + input2;
        }
    }
}
