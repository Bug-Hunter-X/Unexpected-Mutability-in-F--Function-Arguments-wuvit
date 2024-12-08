let x = 10
let y = 20

let add x y = 
    (x + y, y) //Return a tuple of values instead of modifying a mutable variable

let (result, yResult) = add x y
printfn "%d %d" result yResult //Expected output: 30 20, Actual output: 30 20

//The solution avoids mutable variables entirely, leading to a more functional and predictable approach.
//Immutability helps prevent unintended side effects.  The function now returns a tuple instead of modifying parameters.
//This solution is more robust, easier to understand, and less prone to bugs.