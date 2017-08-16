module ServerImpl

open SharedTypes 
open System


// Async.result : 'a -> Async<'a>
// a simple implementation, just return whatever value you get (echo the input)
let implementation : IServer  = {
    // primitive types
    getLength = fun input -> Async.result input.Length
    echoInteger = Async.result
    echoString = Async.result
    echoBool = Async.result
    echoIntOption = Async.result
    echoStringOption = Async.result
    echoGenericUnionInt = Async.result
    echoGenericUnionString = Async.result
    echoSimpleUnionType = Async.result

    echoRecord = Async.result
    echoGenericRecordInt = Async.result
    echoNestedGeneric = Async.result
        
    echoIntList = Async.result
    echoStringList = Async.result
    echoBoolList = Async.result
    echoListOfListsOfStrings = Async.result
    echoListOfGenericRecords = Async.result
}