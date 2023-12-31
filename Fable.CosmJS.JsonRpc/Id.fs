﻿// ts2fable 0.9.0
module rec Fable.CosmJS.JsonRpc.Id

open System
open Fable.Core
open Fable.Core.JS


type [<AllowNullLiteral>] IExports =
    /// Creates a new ID to be used for creating a JSON-RPC request.
    /// 
    /// Multiple calls of this produce unique values.
    /// 
    /// The output may be any value compatible to JSON-RPC request IDs with an undefined output format and generation logic.
    abstract makeJsonRpcId: unit -> float