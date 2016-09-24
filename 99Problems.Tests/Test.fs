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
let myButLast_1() =
    myButLast [1;2;3;4] |> should equal (Some 3)

[<Test>]
let myButLast_2() =
    myButLast [] |> should equal None

[<Test>]
let myButLast_3() =
    myButLast [1] |> should equal None

[<Test>]
let elementAt_1() =
    elementAt [] 2 |> should equal (None)

[<Test>]
let elementAt_2() =
    elementAt [1;2] 3 |> should equal None

[<Test>]
let elementAt_3() =
    elementAt [1;3;5] 2 |> should equal (Some 3)

[<Test>]
let myLength_1() =
    myLength [] |> should equal 0

[<Test>]
let myLength_2() =
    myLength [1;2;3;4;5] |> should equal 5

[<Test>]
let myReverse_1() =
    myReverse [1;2;3;4;5] |> should equal [5;4;3;2;1]

[<Test>]
let isPalindrome_1() =
    isPalindrome "mac" |> should equal false

[<Test>]
let isPalindrome_2() =
    isPalindrome "laval" |> should equal true

