let mutable x = 10
let mutable y = 20

let add x y = 
    x <- x + y
    y

let result = add x y
printfn "%d %d" x result //Expected output: 30 20, Actual output: 30 20

// The above code demonstrates mutable variables are passed by reference.
//However, in F#, this behavior can sometimes be unexpected and lead to subtle bugs.

let mutable x1 = 10
let y1 = 20

let add1 x y = 
    x <- x + y
    y

let result1 = add1 &x1 y1 //Error. F# compiler will not allow you to pass mutable variable by reference to a function that does not explicitly accepts them by reference.
printfn "%d %d" x1 result1 //Expected output: 30 20, Actual output: Compile time error