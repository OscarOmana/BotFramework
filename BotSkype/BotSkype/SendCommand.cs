using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.Azure.Devices.Client;
using Newtonsoft.Json;
using System.Diagnostics;
using System.Text;
using System.Threading.Tasks;

namespace BotSkype
{
    public static class SendCommand
    {
       
        public static async void SendDataToHub(string light, string handler)
        {
            DeviceClient deviceClient;
            string iotHubUri = "hubcasatulancingo.azure-devices.net";
            string deviceKey = "aJpjn3jlGDSlcFrOJqjCxXmHtm8HyBC5HTXr+TQ7pK0=";
            string deviceId = "maquinaCasa";

            //deviceClient = DeviceClient.Create(iotHubUri, AuthenticationMethodFactory.CreateAuthenticationWithRegistrySymmetricKey(deviceId, deviceKey), TransportType.Http1);
            deviceClient = DeviceClient.Create(iotHubUri, new DeviceAuthenticationWithRegistrySymmetricKey(deviceId, deviceKey));

            var telemetryDataPoint = new
            {
                lightNumber = light,
                lightStatus = handler,
                date = DateTime.Now
            };
       
            var messageString = JsonConvert.SerializeObject(telemetryDataPoint);
            var message = new Message(Encoding.ASCII.GetBytes(messageString));

            Debug.WriteLine(messageString);
            await deviceClient.SendEventAsync(message);
        }
    }
}