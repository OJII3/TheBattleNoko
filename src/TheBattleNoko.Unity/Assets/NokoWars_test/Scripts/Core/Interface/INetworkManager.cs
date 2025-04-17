using System;

namespace NokoWars_test.Core.Interface
{
    public interface INetworkManager
    {
        public void setSelfAddress(Tuple<string, int> selfAddress);
        public void setPeerAddress(Tuple<string, int> peerAddress);
    }
}