using Microsoft.ApplicationInsights;
using Microsoft.ApplicationInsights.DataContracts;
using NLog;
using System;
using System.Collections.Generic;
using System.Web.Http;

namespace WebOwinHosting
{
    public class WorkController : ApiController
    {
        public TelemetryClient client = new TelemetryClient();
         
        Logger log = LogManager.GetCurrentClassLogger();
        [HttpGet]
        [Route("api/Work/GetSum")]
        public int GetSum()
        {
            var proper = new Dictionary<string, string>();
            proper.Add("Name", "Adarsh");
            proper.Add("Name1", "Adarsh1");
            proper.Add("Name2", "Adarsh2");
                      Random rand = new Random(100);
            var no1 = rand.Next(10);
            log.Info("no1: " + no1);
            var no2 = rand.Next(200);
            log.Info("no2: " + no2);
            log.Fatal("Fatal");
            client.TrackTrace ("cc status", SeverityLevel.Error, proper);
            return no1 + no2;
        }
        [HttpGet]
        [Route("api/Work/GetMul")]
        public int GetMul(int x)
        {
            Random rand = new Random(100);
            
            var no2 = rand.Next(200);
            return x + no2;
            
        }

        [HttpGet]
        [Route("api/Work/GetDiff")]
        public int GetDiff()
        {
            Random rand = new Random(100);
            var no1 = rand.Next(10);
            var no2 = rand.Next(200);
            throw new Exception("Test exception");
            return no1 - no2;

        }

        [HttpGet]
        [Route("api/Work/GetDiv")]
        public int GetDiv()
        {
            try
            {
                Random rand = new Random(100);
                var no1 = rand.Next(10);
                var no2 = 0;// rand.Next(200);

                return no1 / no2;
            }
            catch (DivideByZeroException ex)
            {
                log.Trace("div/o er", ex);
            }
            return 9999;
        }

        [HttpGet]
        [Route("api/Work/GetError")]
        public int GetError()
        {
            try
            {
                Random rand = new Random(100);
                var no1 = rand.Next(10);
                var no2 = 0;

                return (no1 / no2);
            }
            catch (DivideByZeroException ex)
            {
                                Logger log = LogManager.GetCurrentClassLogger();
                log.Trace("div/o error2", ex);
                throw new Exception("Test exception");
            }
            return 666;
        }
    }
}
