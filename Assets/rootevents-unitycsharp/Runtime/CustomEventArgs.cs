using System;

namespace RootEvents {
    /// <summary>
    /// A zero parameter event argument.
    /// </summary>
    /// <typeparam name="Res">The response type.</typeparam>
    public class CustomEventArgs<Res> : EventArgs {
        public Res Response { get; set; }

        public override string ToString() {
            return
                "Response: " + Response + "\n";
        }
    }

    /// <summary>
    /// A one parameter event arguement.
    /// </summary>
    /// <typeparam name="Arg">The parameter type.</typeparam>
    /// <typeparam name="Res">The response type.</typeparam>
    public class CustomEventArgs<Arg, Res> : EventArgs {
        public Res Response { get; set; }
        public Arg Argument { get; private set; }
        public CustomEventArgs(Arg data) {
            this.Argument = data;
        }

        public override string ToString() {
            return
                "Arg: " + Argument + "\n" +
                "Response: " + Response + "\n";
        }
    }

    /// <summary>
    /// A two parameter event argument.
    /// </summary>
    /// <typeparam name="Arg1">The first paramter type.</typeparam>
    /// <typeparam name="Arg2">The second paramter type.</typeparam>
    /// <typeparam name="Res">The response type.</typeparam>
    public class CustomEventArgs<Arg1, Arg2, Res> : EventArgs {
        public Res Response { get; set; }
        public Arg1 Argument1 { get; private set; }
        public Arg2 Argument2 { get; private set; }
        public CustomEventArgs(Arg1 argument1, Arg2 argument2) {
            this.Argument1 = argument1;
            this.Argument2 = argument2;
        }

        public override string ToString() {
            return
                "Arg1: " + Argument1 + "\n" +
                "Arg2: " + Argument2 + "\n" +
                "Response: " + Response + "\n";
        }
    }

    /// <summary>
    /// A three parameter event argument.
    /// </summary>
    /// <typeparam name="Arg1">The first parameter type.</typeparam>
    /// <typeparam name="Arg2">The second parameter type.</typeparam>
    /// <typeparam name="Arg3">The third parameter type.</typeparam>
    /// <typeparam name="Res">The argument response type.</typeparam>
    public class CustomEventArgs<Arg1, Arg2, Arg3, Res> : EventArgs {
        public Res Response { get; set; }
        public Arg1 Argument1 { get; private set; }
        public Arg2 Argument2 { get; private set; }
        public Arg3 Argument3 { get; private set; }

        public CustomEventArgs(
            Arg1 argument1, 
            Arg2 argument2,
            Arg3 argument3    
        ) {
            this.Argument1 = argument1;
            this.Argument2 = argument2;
            this.Argument3 = argument3;
        }

        public override string ToString() {
            return
                "Arg1: " + Argument1 + "\n" +
                "Arg2: " + Argument2 + "\n" +
                "Arg3: " + Argument3 + "\n" +
                "Response: " + Response + "\n";
        }
    }
}