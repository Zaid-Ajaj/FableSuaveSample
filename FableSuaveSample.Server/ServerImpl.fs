module ServerImpl

open SharedTypes 
open System

let implementation : IServer  = {
    getLength = fun input -> async { return input.Length }
    echoInteger = fun n -> async { return n + n }
    echoOption = function 
        | Some n -> async { return n + n }
        | None -> async { return 0 }
    echoMonth = fun date -> async { return date.Month }
    echoString = fun str -> async { return str }
    optionOutput = fun str -> async { return if str <> "" then Some 5 else None }
    genericUnionInput = function
        | Nothing -> async { return 0 }
        | Just x -> async { return x }
    genericUnionOutput = fun b -> async { return if b then Just 5 else Nothing }
    simpleUnionInputOutput = fun union ->
        async {
            return if union = A then B else A
        }
    recordEcho = fun r -> async { return { r with Prop2 = r.Prop2 + 10 } }
    listIntegers = fun xs -> async { return Seq.sum xs }
    unitToInts = fun () -> async { return Seq.sum [1..10] }
    recordListToInt = fun records -> records |> Seq.map (fun r -> r.Prop2) |> Seq.sum |> fun res -> async { return res }
    floatList = fun xs -> Seq.sum xs |> fun result -> async { return Math.Round(result, 2) }
}