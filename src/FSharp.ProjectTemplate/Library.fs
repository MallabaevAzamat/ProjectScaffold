namespace FSharp.ProjectTemplate

open Sayer

/// Documentation for my library
///
/// ## Example
///
///     let h = Library.hello 1
///     printfn "%d" h
///
module Library = 
  
  /// Returns 42
  ///
  /// ## Parameters
  ///  - `num` - whatever
  let hello num = say_sum (say_sum (bigint 42) (bigint 42)) (bigint -42)
