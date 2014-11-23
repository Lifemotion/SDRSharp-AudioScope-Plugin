using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using bwl.Network.ClientServerMessaging.Light;

namespace SDRSharp.AudioScope
{
    class SdrNetServer
    {
        private NetServer _server;
        private int _netIndex;
        private int _sampleRate;

        public void Start()
        {
            if (_server != null) { throw new Exception(); }
            _server = new NetServer();
            _server.StartServer(3110, false);
        }

        public unsafe void SendSamples(float* buffer, int length)
        {
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < length; i+=2)
            {
                sb.Append(BitConverter.DoubleToInt64Bits(buffer[i] + buffer[i+1]));
                sb.Append(";");
            }
            String str = sb.ToString();
            NetMessage msg = new NetMessage('S', "samples", (_netIndex++).ToString(), str, _sampleRate.ToString ());
            SendToAll(msg);
        }

        public void SendToAll(NetMessage msg)
        {
            try
            {
                foreach (var client in _server.Clients)
                {
                    try
                    {
                        client.SendMessage(msg);
                    }
                    catch (Exception) { }
                }
            }
            catch (Exception) { }
        }

        public void SetSampleRate(double value)
        {
            _sampleRate =(int)value;
        }
    }
}
