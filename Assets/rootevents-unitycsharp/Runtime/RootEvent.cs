using System;

namespace RootEvents {
    public class RootEvent {
        private event EventHandler _raise;
        ~RootEvent() {
            UnsubscribeAll();
        }

        public void Subscribe(EventHandler handler) {
            _raise += handler;
        }

        public void Unsubscribe(EventHandler handler) {
            _raise -= handler;
        }

        public void UnsubscribeAll() {
            foreach (Delegate del in _raise.GetInvocationList()) {
                _raise -= (EventHandler)del;
            }
        }
        
        public void Publish(object source) {
            if (_raise != null) {
                _raise(source, null);
                return;
            }

            throw new System.Exception("Event had no subscribers.");
        }

    }

    /// <summary>
    /// A zero parameter event.
    /// </summary>
    /// <typeparam name="Res"> The event response type.</typeparam>
    public class RootEvent<Res> {
        private event EventHandler<CustomEventArgs<Res>> _raise;

        ~RootEvent() {
            UnsubscribeAll();
        }

        public void Subscribe(EventHandler<CustomEventArgs<Res>> handler) {
            _raise += handler;
        }

        public void Unsubscribe(EventHandler<CustomEventArgs<Res>> handler) {
            _raise -= handler;
        }

        public void UnsubscribeAll() {
            foreach (Delegate del in _raise.GetInvocationList()) {
                _raise -= (EventHandler<CustomEventArgs<Res>>)del;
            }
        }

        public CustomEventArgs<Res> Publish(object source) {
            CustomEventArgs<Res> result =
                    new CustomEventArgs<Res>();

            if (_raise != null) {
                _raise(source, result);
                return result;
            }

            throw new System.Exception("Event with empty signature had " +
                "subcribers.");
        }
    }

    /// <summary>
    /// A single parameter event.
    /// </summary>
    /// <typeparam name="Arg">The event parameter type.</typeparam>
    /// <typeparam name="Res">The event response type.</typeparam>
    public class RootEvent<Arg, Res> {
        private event EventHandler<CustomEventArgs<Arg, Res>> _raise;

        ~RootEvent() {
            UnsubscribeAll();
        }

        public void Subscribe(
            EventHandler<CustomEventArgs<Arg, Res>> handler
        ) {
            _raise += handler;
        }

        public void Unsubscribe(
            EventHandler<CustomEventArgs<Arg, Res>> handler
        ) {
            _raise -= handler;
        }

        public void UnsubscribeAll() {
            foreach (Delegate del in _raise.GetInvocationList()) {
                _raise -= (EventHandler<CustomEventArgs<Arg, Res>>)del;
            }
        }

        public CustomEventArgs<Arg, Res> Publish(object source, Arg arg) {
            CustomEventArgs<Arg, Res> result =
                    new CustomEventArgs<Arg, Res>(arg);

            if (_raise != null) {
                _raise(source, result);
                return result;
            }

            throw new System.Exception("Event with signature (" +
                arg.ToString() + ") had no subscribers.");
        }
    }

    /// <summary>
    /// A two parameter event.
    /// </summary>
    /// <typeparam name="Arg1">The first parameter type.</typeparam>
    /// <typeparam name="Arg2">The second parameter type.</typeparam>
    /// <typeparam name="Res">The event response type.</typeparam>
    public class RootEvent<Arg1, Arg2, Res> {
        private event EventHandler<CustomEventArgs<Arg1, Arg2, Res>> _raise;

        ~RootEvent() {
            UnsubscribeAll();
        }

        public void Subscribe(
            EventHandler<CustomEventArgs<Arg1, Arg2, Res>> handler
        ) {
            _raise += handler;
        }

        public void Unsubscribe(
            EventHandler<CustomEventArgs<Arg1, Arg2, Res>> handler
        ) {
            _raise -= handler;
        }

        public void UnsubscribeAll() {
            foreach (Delegate del in _raise.GetInvocationList()) {
                _raise -= 
                    (EventHandler<CustomEventArgs<Arg1, Arg2, Res>>)del;
            }
        }

        public CustomEventArgs<Arg1, Arg2, Res> Publish(
            object source,
            Arg1 arg1,
            Arg2 arg2
        ) {
            CustomEventArgs<Arg1, Arg2, Res> result =
                    new CustomEventArgs<Arg1, Arg2, Res>(arg1, arg2);

            if (_raise != null) {
                _raise(source, result);
                return result;
            }

            throw new System.Exception("Event with signature (" +
                arg1.ToString() + ", " + arg2.ToString() + ") had no subscribers.");
        }
    }

    /// <summary>
    /// A three parameter event.
    /// </summary>
    /// <typeparam name="Arg1">The first parameter type.</typeparam>
    /// <typeparam name="Arg2">The second parameter type.</typeparam>
    /// <typeparam name="Arg3">The third parameter type.</typeparam>
    /// <typeparam name="Res">The event parameter type.</typeparam>
    public class RootEvent<Arg1, Arg2, Arg3, Res> {
        private event
            EventHandler<CustomEventArgs<Arg1, Arg2, Arg3, Res>> _raise;
        public void Subscribe(
            EventHandler<CustomEventArgs<Arg1, Arg2, Arg3, Res>> handler
        ) {
            _raise += handler;
        }

        public void Unsubscribe(
            EventHandler<CustomEventArgs<Arg1, Arg2, Arg3, Res>> handler
        ) {
            _raise -= handler;
        }

        public void UnsubscribeAll() {
            foreach (Delegate del in _raise.GetInvocationList()) {
                _raise -= 
                    (EventHandler<CustomEventArgs<Arg1, Arg2, Arg3, Res>>)del;
            }
        }

        public CustomEventArgs<Arg1, Arg2, Arg3, Res> Publish(
            object source,
            Arg1 arg1,
            Arg2 arg2,
            Arg3 arg3
        ) {
            CustomEventArgs<Arg1, Arg2, Arg3, Res> result =
                new CustomEventArgs<Arg1, Arg2, Arg3, Res>(
                    arg1,
                    arg2,
                    arg3
                );

            if (_raise != null) {
                _raise(source, result);
                return result;
            }

            throw new System.Exception(
                "Event with signature (" + arg1.ToString() + ", " +
                    arg2.ToString() + ") had no subscribers.");
        }
    }
}