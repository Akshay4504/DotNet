using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Bridge
{
    internal class SonyLedTv: ILEDTV
    {
        public void SwitchOn()
        {
            Console.WriteLine("turning On:Sony TV");
        }
        public void SwitchOff()
        {
            Console.WriteLine("turning Off:Sony TV");
        }
        public void SetChannel(int channelNumber)
        {
            Console.WriteLine("Setting channel to " + channelNumber + "on Sony Tv");
        }
    }
}
