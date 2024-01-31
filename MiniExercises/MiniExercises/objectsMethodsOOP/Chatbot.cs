using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniExercises.objectsMethodsOOP
{
    public class Chatbot
    {
        public string Respond(string message)
        {
            if (string.IsNullOrEmpty(message))
            {
                return "Hello? Are you there?";
            }
            return "You said: " + message;
        }

        public string Respond(string message, bool isQuestion)
        {
            if (isQuestion)
            {
                return "That's an interesting question!";
            }
            return "You said: " + message;
        }

    }

}
