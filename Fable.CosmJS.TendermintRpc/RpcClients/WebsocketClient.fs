// ts2fable 0.9.0
module rec Fable.CosmJS.TendermintRpc.RpcClients.WebsocketClient

open System
open Fable.Core
open Fable.Core.JS

type JsonRpcId = Fable.CosmJS.JsonRpc.Types.JsonRpcId
type JsonRpcRequest = Fable.CosmJS.JsonRpc.Types.JsonRpcRequest
type JsonRpcResponse = Fable.CosmJS.JsonRpc.Types.JsonRpcResponse
type JsonRpcSuccessResponse = Fable.CosmJS.JsonRpc.Types.JsonRpcSuccessResponse
type Stream<'T> = Fable.CosmJS.XStream.Stream<'T>
type RpcStreamingClient = Fable.CosmJS.TendermintRpc.RpcClients.RpcClient.RpcStreamingClient
type SubscriptionEvent = Fable.CosmJS.TendermintRpc.RpcClients.RpcClient.SubscriptionEvent

type [<AllowNullLiteral>] IExports =
    abstract WebsocketClient: WebsocketClientStatic

type [<AllowNullLiteral>] WebsocketClient =
    inherit RpcStreamingClient
    abstract execute: request: JsonRpcRequest -> Promise<JsonRpcSuccessResponse>
    abstract listen: request: JsonRpcRequest -> Stream<SubscriptionEvent>
    /// Resolves as soon as websocket is connected. execute() queues requests automatically,
    /// so this should be required for testing purposes only.
    abstract connected: unit -> Promise<unit>
    abstract disconnect: unit -> unit
    abstract responseForRequestId: id: JsonRpcId -> Promise<JsonRpcResponse>

type [<AllowNullLiteral>] WebsocketClientStatic =
    [<EmitConstructor>] abstract Create: baseUrl: string * ?onError: (obj option -> unit) -> WebsocketClient