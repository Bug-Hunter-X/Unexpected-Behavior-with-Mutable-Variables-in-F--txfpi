let mutable x = 1
let mutable y = 2
let mutable z = x + y
printf "%d" z
x <- 3
printf "%d" z // z will now print 4

//Alternatively, using a function to recalculate z every time
let calculateZ x y = x + y
let x = 1
let y = 2
let z = calculateZ x y
printf "%d" z
let x = 3
let z = calculateZ x y
printf "%d" z