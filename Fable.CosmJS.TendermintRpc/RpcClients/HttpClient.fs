// ts2fable 0.9.0
module rec Fable.CosmJS.TendermintRpc.RpcClients.HttpClient

#nowarn "3390" // disable warnings for invalid XML comments

open System
open Fable.Core
open Fable.Core.JS

type JsonRpcRequest = Fable.CosmJS.JsonRpc.Types.JsonRpcRequest
type JsonRpcSuccessResponse = Fable.CosmJS.JsonRpc.Types.JsonRpcSuccessResponse
type RpcClient = Fable.CosmJS.TendermintRpc.RpcClients.RpcClient.RpcClient
type Record<'K,'V> = Fable.CosmJS.Record.Record<'K,'V>

type [<AllowNullLiteral>] IExports =
    abstract HttpClient: HttpClientStatic

type [<AllowNullLiteral>] HttpEndpoint =
    /// <summary>
    /// The URL of the HTTP endpoint.
    /// 
    /// For POST APIs like Tendermint RPC in CosmJS,
    /// this is without the method specific paths (e.g. <see href="https://cosmoshub-4--rpc--full.datahub.figment.io/)" />
    /// </summary>
    abstract url: string
    /// HTTP headers that are sent with every request, such as authorization information.
    abstract headers: Record<string, string>

type [<AllowNullLiteral>] HttpClient =
    inherit RpcClient
    abstract url: string
    abstract headers: Record<string, string> option
    abstract disconnect: unit -> unit
    abstract execute: request: JsonRpcRequest -> Promise<JsonRpcSuccessResponse>

type [<AllowNullLiteral>] HttpClientStatic =
    [<EmitConstructor>] abstract Create: endpoint: U2<string, HttpEndpoint> -> HttpClient