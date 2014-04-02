SimplestDependencyInjectorEver
==============================

This is the fastest, simple and naive implementation of a dependency injection I can think of.

1. Add the .Dll to your project
2. Call Injector.Inject<T>("Your type, Assembly");
3. And Voi lá! An object is returned.

```
Car car = Injector.Inject<Car>("Your_Namespace.Your_Type, AssemblyName");
```
