module Tests

open FsUnit
open NUnit.Framework
open Main

[<Test>]
let mylast_1() =
    myLast [1;2;3;4] |> should equal (Some 4)
[<Test>]
let mylast_2() =
    myLast [] |> should equal None


