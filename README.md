# RootEvents

A lightweight publisher-subscriberi framework used by Studio Root Games. Can be copied directly into a project, turned into a Unity Package Manager package, or added to a project initialized as an npm package using `npm install jordanstudioroot/RootEvents-UnityCSharp`.

# Requirements

# Usage
1. Declare an event by instantiating a new RootEvent: `RootEvent<Argument, Response> foo = new RootEvent<Argument, Response>();`
2. Subscribe a function of the corresponding signature to the event by passing it as an argument to the event: `foo.Subscribe(HandlerFunction);`
3. Fire the event as needed, passing the object publishing the event and any required arguments to the event: `foo.Publish(this, argument);`
4. When the event is no longer relevant to a particular object, or in general, call `foo.Unsubscribe(HandlerFunction);` or `foo.UnsubscribeAll();`

# Recommendations
Declare the events in a central [event aggregator](https://martinfowler.com/eaaDev/EventAggregator.html) if you have numerous events and numerous subscribers.

# TODO
- [ ] Tests
- [ ] Example event aggregator class.
