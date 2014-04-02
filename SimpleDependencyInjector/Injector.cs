using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SimpleDependencyInjector {
    public class Injector {
        public static T Inject<T>(string stringType) {
            Type type = Type.GetType(stringType);
            if (type == null)
                throw new DependencyInjectionException(string.Format("Couldn't find type {0}", stringType));

            return (T)Activator.CreateInstance(type, false);
        }

        public static T Inject<T>(Type type) {
            return (T)Activator.CreateInstance(type, false);
        }
    }// class
}
