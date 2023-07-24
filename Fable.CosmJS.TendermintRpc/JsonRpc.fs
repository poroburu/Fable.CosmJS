// ts2fable 0.9.0
module rec Fable.CosmJS.TendermintRpc.JsonRpc

open System
open Fable.Core
open Fable.Core.JS


type JsonRpcRequest = Fable.CosmJS.JsonRpc.Types.JsonRpcRequest

type [<AllowNullLiteral>] IExports =
    /// Creates a JSON-RPC request with random ID
    abstract createJsonRpcRequest: method: string * ?``params``: CreateJsonRpcRequestParams -> JsonRpcRequest

type [<AllowNullLiteral>] CreateJsonRpcRequestParams =
    interface end