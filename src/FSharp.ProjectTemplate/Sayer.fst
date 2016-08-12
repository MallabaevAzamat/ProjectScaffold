module Sayer

let say_sum (a:int) (b:int {b < a}): Tot (r:int {r <= a + a}) = a + b