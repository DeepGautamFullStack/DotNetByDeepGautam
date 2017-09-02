using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DIinDotNetCore
{
    public class CreditService : ICreditService
    {
        public readonly IDebitService _debitService;
        private readonly ILogger<CreditService> _logger;
        public CreditService(IDebitService debitService, ILoggerFactory loggerFactory)
        {
            this._debitService = debitService;
            this._logger = loggerFactory.CreateLogger<CreditService>();
        }
        public void Credit(decimal amount)
        {
            Console.WriteLine("Credit from account is done with value of-"+amount);

            //perform debit of 0
            _debitService.Debit(0);
        }
    }
}
