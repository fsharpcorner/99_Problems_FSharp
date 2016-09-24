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

