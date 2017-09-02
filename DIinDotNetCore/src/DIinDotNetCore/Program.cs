using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;

namespace DIinDotNetCore
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // ASP.NET Core is designed from the ground up to support and leverage dependency injection. ASP.NET Core applications can leverage built-in framework services by having them injected into methods in the Startup class, and application services can be configured for injection as well. The default services container provided by ASP.NET Core provides a minimal feature set and is not intended to replace other containers.+
            // View or download sample code
            //What is Dependency Injection?
            //Dependency injection(DI) is a technique for achieving loose coupling between objects and their collaborators, or dependencies.Rather than directly instantiating collaborators, or using static references, the objects a class needs in order to perform its actions are provided to the class in some fashion.Most often, classes will declare their dependencies via their constructor, allowing them to follow the Explicit Dependencies Principle. This approach is known as "constructor injection".1
            //When classes are designed with DI in mind, they are more loosely coupled because they do not have direct, hard-coded dependencies on their collaborators.This follows the Dependency Inversion Principle, which states that "high level modules should not depend on low level modules; both should depend on abstractions." Instead of referencing specific implementations, classes request abstractions (typically interfaces) which are provided to them when the class is constructed.Extracting dependencies into interfaces and providing implementations of these interfaces as parameters is also an example of the Strategy design pattern.
            //When a system is designed to use DI, with many classes requesting their dependencies via their constructor (or properties), it's helpful to have a class dedicated to creating these classes with their associated dependencies. These classes are referred to as containers, or more specifically, Inversion of Control (IoC) containers or Dependency Injection (DI) containers. A container is essentially a factory that is responsible for providing instances of types that are requested from it. If a given type has declared that it has dependencies, and the container has been configured to provide the dependency types, it will create the dependencies as part of creating the requested instance. In this way, complex dependency graphs can be provided to classes without the need for any hard-coded object construction. In addition to creating objects with their dependencies, containers typically manage object lifetimes within the application.

            //setup our Dependency injection
            var serviceProvider = new ServiceCollection()
                .AddLogging()
                .AddSingleton<ICreditService, CreditService>()
                .AddSingleton<IDebitService, DebitService>()
                .BuildServiceProvider();

            //configure logging service defult provided by Microsoft 
            serviceProvider
                .GetService<ILoggerFactory>()
                .AddConsole(LogLevel.Debug);

            var logger = serviceProvider.GetService<ILoggerFactory>()
                .CreateLogger<Program>();
            logger.LogDebug("Starting dependency injection proof of concepts in dot net core.");

            //call the services methods
            var obj1 = serviceProvider.GetService<IDebitService>();
            obj1.Debit(20);

            var obj2 = serviceProvider.GetService<ICreditService>();
            obj2.Credit(20);

            logger.LogDebug("All Dependency injection test done! Now your are good to for Dotnet Core dependency injections");

            Console.ReadKey();
        }
    }
}
