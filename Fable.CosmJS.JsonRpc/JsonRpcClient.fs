// ts2fable 0.9.0
module rec Fable.CosmJS.JsonRpc.JsonRpcClient

open System
open Fable.Core
open Fable.Core.JS
open Fable.CosmJS

type Stream<'T> = XStream.Stream<'T>
type JsonRpcRequest = JsonRpcRequest
type JsonRpcResponse = JsonRpcResponse
type JsonRpcSuccessResponse = JsonRpcSuccessResponse

type [<AllowNullLiteral>] IExports =
    /// A thin wrapper that is used to bring together requests and responses by ID.
    /// 
    /// Using this class is only advised for continous communication channels like
    /// WebSockets or WebWorker messaging.
    abstract JsonRpcClient: JsonRpcClientStatic

type [<AllowNullLiteral>] SimpleMessagingConnection<'Request, 'Response> =
    abstract responseStream: Stream<'Response>
    abstract sendRequest: 'Request -> unit

/// A thin wrapper that is used to bring together requests and responses by ID.
/// 
/// Using this class is only advised for continous communication channels like
/// WebSockets or WebWorker messaging.
type [<AllowNullLiteral>] JsonRpcClient =
    abstract run: request: JsonRpcRequest -> Promise<JsonRpcSuccessResponse>

/// A thin wrapper that is used to bring together requests and responses by ID.
/// 
/// Using this class is only advised for continous communication channels like
/// WebSockets or WebWorker messaging.
type [<AllowNullLiteral>] JsonRpcClientStatic =
    [<EmitConstructor>] abstract Create: connection: SimpleMessagingConnection<JsonRpcRequest, JsonRpcResponse> -> JsonRpcClient