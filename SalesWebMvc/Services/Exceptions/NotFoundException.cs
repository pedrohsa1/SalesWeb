using System;

namespace SalesWebMvc.Services.Exceptions
{
    public class NotFoundException : ApplicationException
    {
        //Esse construtor repassa essa message para a classe base
        public NotFoundException(string message) : base(message)
        {

        }
    }
}
