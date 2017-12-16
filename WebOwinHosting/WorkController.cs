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
        public static int button1Click = 1;
        public static int button2Click = 1;

        Logger log = LogManager.GetCurrentClassLogger();
        [HttpGet]
        [Route("api/Work/GetSum")]
        public int GetSum()
        {
            Dictionary<string, string> resultDict = new Dictionary<string, string>();
            Random rnd = new Random();
            int num1 = rnd.Next(1000);
            int num2 = rnd.Next(1000);
            int sum = num1 + num2;
            resultDict.Add("Number 1: ", num1.ToString());
            resultDict.Add("Number 2: ", num2.ToString());
            resultDict.Add("Sum: ", sum.ToString());

            client.TrackTrace("Addition operation", resultDict);
            return num1 + num2;
        }

        [HttpGet]
        [Route("api/Work/GetMul")]
        public int GetMul(int x)
        {
            Random rand = new Random();
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

        public List<string> GetString()
        {
            List<string> Users = new List<string>();
            Users.Add("Sean");
            Users.Add("Emmy");
            Users.Add("Cosmo");
            return Users;
        }

        [HttpPost]
        [Route("api/Work/GetLink/{id}")]
        public int GetLink(int id)
        {

            Console.WriteLine(id);
            return id;
        }

        public int GetCountButton1()
        {
            return button1Click++;
        }
        public int GetCountButton2()
        {
            return button2Click++;
        }
    }
}
