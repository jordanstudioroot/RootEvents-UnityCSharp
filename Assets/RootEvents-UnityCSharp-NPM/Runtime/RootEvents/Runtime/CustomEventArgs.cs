using System;

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
            "Argument1: " + Argument1 + "\n" +
            "Argument2: " + Argument2 + "\n" +
            "Argument3: " + Argument3 + "\n" +
            "Response: " + Response + "\n";
    }
}

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
            "Argument1: " + Argument1 + "\n" +
            "Argument2: " + Argument2 + "\n" +
            "Response: " + Response + "\n";
    }
}

public class CustomEventArgs<Arg, Res> : EventArgs {
    public Res Response { get; set; }
    public Arg Argument { get; private set; }
    public CustomEventArgs(Arg data) {
        this.Argument = data;
    }

    public override string ToString() {
        return
            "Argument: " + Argument + "\n" +
            "Response: " + Response + "\n";
    }
}

public class CustomEventArgs<Res> : EventArgs {
    public Res Response { get; set; }

    public override string ToString() {
        return
            "Response: " + Response + "\n";
    }
}