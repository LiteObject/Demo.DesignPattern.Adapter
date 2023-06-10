# The Adapter Design Pattern
The Adapter design pattern allows objects with incompatible interfaces to work together by providing a common interface that both objects can use. 

This pattern is useful when you want to reuse an existing class but its interface doesn't match the requirements of the client code. 

## Example 1
We have a legacy `LegacyCar` class that has an incompatible interface (`Start` method). 
We want to use this class in our client code that expects objects to implement the `IVehicle` interface.

To bridge the gap, we create an `CarAdapter` class that implements the `IVehicle` interface. 
The adapter takes an instance of `LegacyCar` in its constructor. Inside the adapter's `StartEngine` method,
we convert the parameters-less to the format expected by the `LegacyCar` and then call its `Start` method.

The `Client` class doesn't know about the `LegacyCar` or the adapter details. It simply uses the `IVehicle` 
interface to start the engine.

Finally, in the `Main` method, we create an instance of `LegacyCar`, create the adapter by passing the 
`LegacyCar`, create the client, and use the client to start the engine. The client code is unaware of 
the adapter and can seamlessly work with the `IVehicle` interface.

The Adapter pattern allows us to reuse the existing `LegacyCar` class in our client code without modifying
it. It provides a way to adapt the incompatible interface of the `LegacyCar` to the `IVehicle` interface 
expected by the client.

## Example 2
We have an existing `Logger` class with a method Log that takes a string message as an argument. However, we 
want to use a new logging framework that expects a different interface, `ILog`, with a method `LogMessage`.

To adapt the `Logger` class to the `ILog` interface, we create a `LoggerAdapter` class that implements `ILog`. The 
adapter takes an instance of the `Logger` class in its constructor. Inside the adapter's `LogMessage` method, we 
call the `Log` method of the `Logger` class.

The `Client` class depends on the `ILog` interface and doesn't know about the `Logger` or the adapter details. 
It uses the `ILog` interface to log messages.

In the `Main` method, we create an instance of `Logger`, create the adapter by passing the `Logger`, create the client 
by passing the adapter, and use the client to log messages. The client code is unaware of the adapter and can 
seamlessly work with the `ILog` interface.

The Adapter pattern allows us to adapt the existing `Logger` class to work with the new logging framework without 
modifying it. It provides a way to bridge the gap between the incompatible interfaces and allows the client code 
to use the `ILog` interface to log messages.