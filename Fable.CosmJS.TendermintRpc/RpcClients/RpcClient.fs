// ts2fable 0.9.0
module rec Fable.CosmJS.TendermintRpc.RpcClients.RpcClient

#nowarn "3390" // disable warnings for invalid XML comments

open System
open Fable.Core
open Fable.Core.JS

type JsonRpcRequest = Fable.CosmJS.JsonRpc.Types.JsonRpcRequest
type JsonRpcSuccessResponse = Fable.CosmJS.JsonRpc.Types.JsonRpcSuccessResponse
type Stream<'T> = Fable.CosmJS.XStream.Stream<'T>

[<AllowNullLiteral>]
type IExports =
    abstract instanceOfRpcStreamingClient: client: RpcClient -> bool
    abstract hasProtocol: url: string -> bool

/// <summary>
/// An event emitted from Tendermint after subscribing via RPC.
///
/// These events are passed as the <c>result</c> of JSON-RPC responses, which is kind
/// of hacky because it breaks the idea that exactly one JSON-RPC response belongs
/// to each JSON-RPC request. But this is how subscriptions work in Tendermint.
/// </summary>
[<AllowNullLiteral>]
type SubscriptionEvent =
    abstract query: string

    abstract data:
        {| ``type``: string
           value: obj option |}

[<AllowNullLiteral>]
type RpcClient =
    abstract execute: JsonRpcRequest -> Promise<JsonRpcSuccessResponse>
    abstract disconnect: unit -> unit

[<AllowNullLiteral>]
type RpcStreamingClient =
    inherit RpcClient
    abstract listen: JsonRpcRequest -> Stream<SubscriptionEvent>
