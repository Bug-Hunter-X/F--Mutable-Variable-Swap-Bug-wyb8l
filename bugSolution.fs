let mutable x = 10
let mutable y = 20

let swap (xRef: byref<int>) (yRef: byref<int>) = 
    let temp = xRef
    xRef <- yRef
    yRef <- temp

swap &x &y
printf "%d %d" x y

//Alternative solution using tuples:
let swapTuple (x, y) = (y, x)
let (x, y) = swapTuple (x, y)
printf "%d %d" x y