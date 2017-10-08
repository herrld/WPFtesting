using Microsoft.Practices.Unity;
using Microsoft.Practices.Unity.Configuration;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnityInjection
{
    public class DependencyFactory
    {
        private static IUnityContainer container;

        public static IUnityContainer Container
        {
            get
            {
                return container;
            }
            private set
            {
                container = value;
            }
        }

        static DependencyFactory()
        {
            container = new UnityContainer();
        }

        public static object Resolve(Type t)
        {
            if(Container.IsRegistered(t))
            {
                return Container.Resolve(t);
            }
            return null;
        }

        public static T Resolve<T>()
        {
            T ret = default(T);
            if (Container.IsRegistered(typeof(T)))
            {
                ret = Container.Resolve<T>();
            }

            return ret;
        }

    }
}
