using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SimpleDependencyInjector;
using SimpleDepedencyInjector.Tests.Data;

namespace SimpleDepedencyInjector.Tests {
    [TestClass]
    public class InjectorTest {
        [TestMethod]
        public void InjectWithString() {
            var foo = Injector.Inject<IFoo>("SimpleDepedencyInjector.Tests.Data.Foo, SimpleDepedencyInjector.Tests");
            Assert.IsNotNull(foo);
            Assert.IsInstanceOfType(foo, typeof(Foo));
        }

        [TestMethod]
        public void InjectWithType() {
            var foo = Injector.Inject<IFoo>(typeof(Foo));
            Assert.IsNotNull(foo);
            Assert.IsInstanceOfType(foo, typeof(Foo));
        }

        [TestMethod]
        [ExpectedException(typeof(DependencyInjectionException))]
        public void InjectWithNullString() {
            var foo = Injector.Inject<IFoo>(string.Empty);
        }

        [TestMethod]
        [ExpectedException(typeof(DependencyInjectionException))]
        public void InjectWithWrongString() {
            var foo = Injector.Inject<IFoo>("NotExistentClass, SimpleDepedencyInjector.Tests");
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void InjectWithNullType() {
            Type type = null;
            var foo = Injector.Inject<IFoo>(type);
        }

    }// class
}
