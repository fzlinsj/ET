using System.Collections.Generic;

namespace ET.Server
{
    [ComponentOf(typeof(BattleScene))]
    public class ServerFrameRecvComponent: Entity, IAwake
    {
        public int NowFrame;
        public Dictionary<long, OneFrameMessages> FrameMessages = new ();
    }
}