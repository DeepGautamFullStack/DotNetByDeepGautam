using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Extensions.Logging;

namespace DIinDotNetCore
{
    public class DebitService : IDebitService
    {
        private readonly ILogger<DebitService> _logger;
        public DebitService( ILoggerFactory loggerFactory)
        {
            this._logger= loggerFactory.CreateLogger<DebitService>();
        }
        public void Debit(decimal amount)
        {
            Console.WriteLine("Debit from account is done with value of-" + amount);

        }
    }
}
