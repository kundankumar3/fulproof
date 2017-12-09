using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Unity;

namespace DI
{
    public static  class UnityConfig
    {
        public static IUnityContainer container;
        public static void Register()
        {
            container = new UnityContainer();
            container.RegisterType<ILogger, NLogger>();
        }
    }
}
