module Tests

open FsUnit
open NUnit.Framework
open Main

[<Test>]
let myLast_1() =
    myLast [1;2;3;4] |> should equal (Some 4)
[<Test>]
let myLast_2() =
    myLast [] |> should equal None

[<Test>]
let myLast'_1() =
    myLast' [1;2;3;4] |> should equal (Some 4)
[<Test>]
let myLast'_2() =
    myLast' [] |> should equal None

[<Test>]
let myButLast'_1() =
    myButLast [1;2;3;4] |> should equal (Some 3)

[<Test>]
let myButLast'_2() =
    myButLast [] |> should equal None

[<Test>]
let myButLast'_3() =
    myButLast [1] |> should equal None
