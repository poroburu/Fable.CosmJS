// ts2fable 0.9.0
module rec Fable.CosmJS.TendermintRpc.RpcClients.HttpBatchClient

open System
open Fable.Core
open Fable.Core.JS



type JsonRpcRequest = Fable.CosmJS.JsonRpc.Types.JsonRpcRequest
type JsonRpcSuccessResponse = Fable.CosmJS.JsonRpc.Types.JsonRpcSuccessResponse
type HttpEndpoint = Fable.CosmJS.TendermintRpc.RpcClients.HttpClient.HttpEndpoint
type RpcClient = Fable.CosmJS.TendermintRpc.RpcClients.RpcClient.RpcClient
type Record<'K,'V> = Fable.CosmJS.Record.Record<'K,'V>


type [<AllowNullLiteral>] IExports =
    abstract HttpBatchClient: HttpBatchClientStatic

type [<AllowNullLiteral>] HttpBatchClientOptions =
    /// Interval for dispatching batches (in milliseconds)
    abstract dispatchInterval: float with get, set
    /// Max number of items sent in one request
    abstract batchSizeLimit: float with get, set

type [<AllowNullLiteral>] HttpBatchClient =
    inherit RpcClient
    abstract url: string
    abstract headers: Record<string, string> option
    abstract options: HttpBatchClientOptions
    abstract disconnect: unit -> unit
    abstract execute: request: JsonRpcRequest -> Promise<JsonRpcSuccessResponse>

type [<AllowNullLiteral>] HttpBatchClientStatic =
    [<EmitConstructor>] abstract Create: endpoint: U2<string, HttpEndpoint> * ?options: obj -> HttpBatchClient