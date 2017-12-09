using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Unity;
using Unity.Injection;
using Unity.Resolution;

namespace DI
{
    class Program
    {
        public static IUnityContainer container;
        public static void Register()
        {
            container = new UnityContainer();
            container.RegisterType<ILogger, NLogger>();
            container.RegisterType<IClass1, Class1>();
        }
        static void Main(string[] args)
        {
            Register();
            var s = container.Resolve<ILogger>();
        }
    }
}
