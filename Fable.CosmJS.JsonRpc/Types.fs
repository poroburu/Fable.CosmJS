// ts2fable 0.9.0
module rec Fable.CosmJS.JsonRpc.Types

#nowarn "3390" // disable warnings for invalid XML comments

open System
open Fable.Core
open Fable.Core.JS

type JsonCompatibleArray = Compatibility.JsonCompatibleArray
type JsonCompatibleDictionary = Compatibility.JsonCompatibleDictionary
type JsonCompatibleValue = Compatibility.JsonCompatibleValue
/// <summary>Error codes as specified in JSON-RPC 2.0</summary>
/// <seealso href="https://www.jsonrpc.org/specification#error_object" />
let [<Import("jsonRpcCode","module")>] jsonRpcCode: JsonRpcCode = jsNative

type [<AllowNullLiteral>] IExports =
    abstract isJsonRpcErrorResponse: response: JsonRpcResponse -> bool
    abstract isJsonRpcSuccessResponse: response: JsonRpcResponse -> bool

type JsonRpcId =
    U2<float, string>

type [<AllowNullLiteral>] JsonRpcRequest =
    abstract jsonrpc: string
    abstract id: JsonRpcId
    abstract method: string
    abstract ``params``: U2<JsonCompatibleArray, JsonCompatibleDictionary>

type [<AllowNullLiteral>] JsonRpcSuccessResponse =
    abstract jsonrpc: string
    abstract id: JsonRpcId
    abstract result: obj option

type [<AllowNullLiteral>] JsonRpcError =
    abstract code: float
    abstract message: string
    abstract data: JsonCompatibleValue option

/// <summary>And error object as described in <see href="https://www.jsonrpc.org/specification#error_object" /></summary>
type [<AllowNullLiteral>] JsonRpcErrorResponse =
    abstract jsonrpc: string
    abstract id: JsonRpcId option
    abstract error: JsonRpcError

type JsonRpcResponse =
    U2<JsonRpcSuccessResponse, JsonRpcErrorResponse>

type [<AllowNullLiteral>] JsonRpcCode =
    abstract parseError: float with get, set
    abstract invalidRequest: float with get, set
    abstract methodNotFound: float with get, set
    abstract invalidParams: float with get, set
    abstract internalError: float with get, set
    abstract serverError: {| ``default``: float |} with get, set