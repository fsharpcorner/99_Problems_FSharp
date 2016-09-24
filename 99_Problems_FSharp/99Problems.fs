//namespace _99_Problems_FSharp
module Main

let myLast l =
    match l with
    | [] -> None
    | _ -> l |> List.rev |> List.head |> Some

let rec myLast' l =
    match l with
    | [] -> None
    | [x] -> Some x
    | (x::xs) -> myLast' xs

let rec myButLast l=
  match l with
    | [] -> None
    | [x] -> None
    | [x;xs] -> Some x
    | (x::xs) -> myButLast xs

let rec elementAt l n =
    match l, n with
    | [], _ -> None
    | (x::_), 1 -> Some x
    | (_::xs), n -> elementAt xs (n-1)

let myLength l =
    let rec myLengthImpl l n =
        match l with
        | [] -> 0
        | [_] -> n + 1 
        | (_::xs) -> myLengthImpl xs (n+1)
    myLengthImpl l 0
