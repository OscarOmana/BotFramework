using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;
using Microsoft.Bot.Builder.Dialogs;
using Microsoft.Bot.Connector;

namespace BotSkype
{
    [BotAuthentication]
    public class MessagesController : ApiController
    {
        public async Task<HttpResponseMessage> Post([FromBody]Activity activity)
        {
            if (activity.Type == ActivityTypes.Message)
            {
                

                // Luz Baño abajo interior
                if (activity.Text == "encender baño abajo interior")
                {
                    SendCommand.SendDataToHub("01", "1");
                }
                else if (activity.Text == "apagar baño abajo interior")
                {
                    SendCommand.SendDataToHub("01", "0");
                }

                // Luz Baño arriba interior
                if (activity.Text == "encender baño arriba interior")
                {
                    SendCommand.SendDataToHub("02", "1");
                }
                else if (activity.Text == "apagar baño arriba interior")
                {
                    SendCommand.SendDataToHub("02", "0");
                }

                // Luz Sala
                if (activity.Text == "encender sala")
                {
                    SendCommand.SendDataToHub("03", "1");
                }
                else if (activity.Text == "apagar sala")
                {
                    SendCommand.SendDataToHub("03", "0");
                }

                // Luz Oscar
                if (activity.Text == "encender oscar")
                {
                    SendCommand.SendDataToHub("04", "1");
                }
                else if (activity.Text == "apagar oscar")
                {
                    SendCommand.SendDataToHub("04", "0");
                }

                // Luz Baño arriba exterior
                if (activity.Text == "encender baño arriba exterior")
                {
                    SendCommand.SendDataToHub("05", "1");
                }
                else if (activity.Text == "apagar baño arriba exterior")
                {
                    SendCommand.SendDataToHub("05", "0");
                }

                // Luz Baño abajo exterior
                if (activity.Text == "encender baño abajo exterior")
                {
                    SendCommand.SendDataToHub("06", "1");
                }
                else if (activity.Text == "apagar baño abajo exterior")
                {
                    SendCommand.SendDataToHub("06", "0");
                }

                // Luz Cuarto Cosas
                if (activity.Text == "encender cosas")
                {
                    SendCommand.SendDataToHub("07", "1");
                }
                else if (activity.Text == "apagar cosas")
                {
                    SendCommand.SendDataToHub("07", "0");
                }

                // Luz Cocina
                if (activity.Text == "encender cocina")
                {
                    SendCommand.SendDataToHub("08", "1");
                }
                else if (activity.Text == "apagar cocina")
                {
                    SendCommand.SendDataToHub("08", "0");
                }

                // Ventilador
                if (activity.Text == "encender ventilador")
                {
                    SendCommand.SendDataToHub("09", "1");
                }
                else if (activity.Text == "apagar ventilador")
                {
                    SendCommand.SendDataToHub("09", "0");
                }

                // Luz Taller
                if (activity.Text == "encender taller")
                {
                   // await Conversation.SendAsync(activity, () => new Dialogs.RootDialog());
                    SendCommand.SendDataToHub("10", "1");
                }
                else if (activity.Text == "apagar taller")
                {
                    SendCommand.SendDataToHub("10", "0");
                }

                // Luz Polli
                if (activity.Text == "encender polli")
                {
                    SendCommand.SendDataToHub("11", "1");
                }
                else if (activity.Text == "apagar polli")
                {
                    SendCommand.SendDataToHub("11", "0");
                }

                // Luz Patio
                if (activity.Text == "encender patio")
                {
                    SendCommand.SendDataToHub("12", "1");
                }
                else if (activity.Text == "apagar patio")
                {
                    SendCommand.SendDataToHub("12", "0");
                }
            }
            else
            {
                HandleSystemMessage(activity);
            }
            var response = Request.CreateResponse(HttpStatusCode.OK);
            return response;
        }

        private Activity HandleSystemMessage(Activity message)
        {
            if (message.Type == ActivityTypes.DeleteUserData)
            {
                // Implement user deletion here
                // If we handle user deletion, return a real message
            }
            else if (message.Type == ActivityTypes.ConversationUpdate)
            {
                // Handle conversation state changes, like members being added and removed
                // Use Activity.MembersAdded and Activity.MembersRemoved and Activity.Action for info
                // Not available in all channels
            }
            else if (message.Type == ActivityTypes.ContactRelationUpdate)
            {
                // Handle add/remove from contact lists
                // Activity.From + Activity.Action represent what happened
            }
            else if (message.Type == ActivityTypes.Typing)
            {
                // Handle knowing tha the user is typing
            }
            else if (message.Type == ActivityTypes.Ping)
            {
            }

            return null;
        }
    }
}