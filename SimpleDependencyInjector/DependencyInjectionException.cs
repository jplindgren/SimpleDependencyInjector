using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SimpleDependencyInjector {
    public class DependencyInjectionException : Exception{
        public DependencyInjectionException(String message) : base(message) { }
    }// class
}
