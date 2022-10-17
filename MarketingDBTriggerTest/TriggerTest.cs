using System;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Host;
using Microsoft.Extensions.Logging;

namespace MarketingDBTriggerTest
{
    public class TriggerTest
    {
       
        [FunctionName("TriggerTest")]
        public void Run([TimerTrigger("0 * * * * *")]TimerInfo myTimer, ILogger log)
        {
       
              string con = Environment.GetEnvironmentVariable("Connection", EnvironmentVariableTarget.Process);
              log.LogInformation("ConnectionStr : " + con);
        }
    }
}
