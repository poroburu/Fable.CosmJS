module Fable.CosmJS.TendermintRpc.RpcClients.Http
// ts2fable 0.9.0

#nowarn "3390" // disable warnings for invalid XML comments

open System
open Fable.Core
open Fable.Core.JS

type Record<'K, 'V> = Fable.CosmJS.Record.Record<'K, 'V>

[<AllowNullLiteral>]
type IExports =
    /// <summary>
    /// Helper to work around missing CORS support in Tendermint (<see href="https://github.com/tendermint/tendermint/pull/2800)" />
    ///
    /// For some reason, fetch does not complain about missing server-side CORS support.
    /// </summary>
    [<Emit("$0.http('POST',$1,$2,$3)")>]
    abstract http_POST: url: string * headers: Record<string, string> option * ?request: obj -> Promise<obj option>
