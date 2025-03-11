module CS220.Quiz1.Math

open System

/// Modify the function `collatz` in such a way that the function takes in a
/// 32-bit integer, and returns the number of steps it takes to reach 1 in the
/// Collatz sequence.
let collatz n =
  let isEven (x:uint64) = x % 2UL = 0UL
  let rec iter n cnt =
    if n = 1UL then cnt
    else
      if isEven n then iter (n/2UL) (cnt + 1)
      else iter (3UL * n + 1UL) (cnt + 1)
  iter (uint64 n) 0