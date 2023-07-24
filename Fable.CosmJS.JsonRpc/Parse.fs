// ts2fable 0.9.0
module rec Fable.CosmJS.JsonRpc.Parse

#nowarn "3390" // disable warnings for invalid XML comments

open System
open Fable.Core
open Fable.Core.JS

type JsonRpcErrorResponse = Types.JsonRpcErrorResponse
type JsonRpcId = Types.JsonRpcId
type JsonRpcRequest = Types.JsonRpcRequest
type JsonRpcResponse = Types.JsonRpcResponse
type JsonRpcSuccessResponse = Types.JsonRpcSuccessResponse

type [<AllowNullLiteral>] IExports =
    /// Creates a new ID to be used for creating a JSON-RPC request.
    /// 
    /// Multiple calls of this produce unique values.
    /// 
    /// The output may be any value compatible to JSON-RPC request IDs with an undefined output format and generation logic.
    abstract makeJsonRpcId: unit -> float
    /// <summary>
    /// Extracts ID field from request or response object.
    /// 
    /// Returns <c>null</c> when no valid ID was found.
    /// </summary>
    abstract parseJsonRpcId: data: obj -> JsonRpcId option
    abstract parseJsonRpcRequest: data: obj -> JsonRpcRequest
    /// Throws if data is not a JsonRpcErrorResponse
    abstract parseJsonRpcErrorResponse: data: obj -> JsonRpcErrorResponse
    /// Throws if data is not a JsonRpcSuccessResponse
    abstract parseJsonRpcSuccessResponse: data: obj -> JsonRpcSuccessResponse
    /// Returns a JsonRpcErrorResponse if input can be parsed as a JSON-RPC error. Otherwise parses
    /// input as JsonRpcSuccessResponse. Throws if input is neither a valid error nor success response.
    abstract parseJsonRpcResponse: data: obj -> JsonRpcResponse