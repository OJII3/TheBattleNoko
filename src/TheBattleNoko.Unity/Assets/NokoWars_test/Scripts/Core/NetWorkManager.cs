using System;
using NokoWars_test.Core.Interface;

namespace NokoWars_test.Core
{
    public class NetWorkManager: INetworkManager
    {
        private Tuple<string, int> selfAddress;
        private Tuple<string, int> peerAddress;
        private bool Host;

        public Tuple<string, int> getSelfAddress()
        {
            return selfAddress;
        }

        public Tuple<string, int> getPeerAddress()
        {
            return peerAddress;
        }

        public void setSelfAddress(Tuple<string, int> address)
        {
            this.selfAddress = address;
        }

        public void setPeerAddress(Tuple<string, int> address)
        {
            this.peerAddress = address;
        }

        public void setAsHost()
        {
            Host = true;
        }

        public bool isHost
        {
            get => Host;
            private set => Host = value;

        }
    }
}