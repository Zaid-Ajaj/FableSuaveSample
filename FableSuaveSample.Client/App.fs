module App

open Fable.Core
open Fable.Remoting.Client
open SharedTypes

let server = Proxy.createWithBuilder<IServer> routeBuilder

QUnit.registerModule "Fable.Remoting"

QUnit.test "IServer.getLegth" <| fun test ->
    let finish = test.async()
    async {
        let! result = server.getLength "hello"
        do test.equal result 5
        do finish()
    } 
    |> Async.StartImmediate

QUnit.test "ISever.echoInteger" <| fun test ->
    let finish = test.async()
    async {
        let! result = server.echoInteger 20
        do test.equal result 40
        do test.notEqual result 10
        do finish()
    } 
    |> Async.StartImmediate


QUnit.test "IServer.echoOption" <| fun test ->
    let finish = test.async()
    async {
        let! someResult = server.echoOption (Some 5)
        let! noneResult = server.echoOption None
        do test.equal someResult 10
        do test.equal noneResult 0
        do finish()
    } 
    |> Async.StartImmediate