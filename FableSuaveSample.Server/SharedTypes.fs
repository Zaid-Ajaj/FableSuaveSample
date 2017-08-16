module SharedTypes

open System

type Record = { 
    Prop1 : string
    Prop2 : int
    Prop3 : int option
}

type Maybe<'t> = 
    | Just of 't
    | Nothing

type AB = A | B


type GenericRecord<'t> = {
    Value: 't
    OtherValue : int
}

type IServer = { 
    getLength : string -> Async<int>  
    echoInteger : int -> Async<int>  
    echoOption : int option -> Async<int>
    echoMonth : DateTime -> Async<int>
    echoString : string -> Async<string>
    optionOutput : string -> Async<int option>
    genericUnionInput : Maybe<int> -> Async<int>
    genericUnionOutput : bool -> Async<Maybe<int>>
    simpleUnionInputOutput : AB -> Async<AB>
    recordEcho : Record -> Async<Record>
    listIntegers : int list -> Async<int>
    unitToInts : unit -> Async<int>
    recordListToInt : Record[] -> Async<int>
    floatList : float [] -> Async<float>
}


let routeBuilder typeName methodName = 
    sprintf "/api/%s/%s" typeName methodName