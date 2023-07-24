// ts2fable 0.9.0
module Fable.CosmJS.TendermintRpc.Tendermint34.Hasher

open System
open Fable.Core
open Fable.Core.JS

type Header = Responses.Header

type [<AllowNullLiteral>] IExports =
    abstract hashTx: tx: Uint8Array -> Uint8Array
    abstract hashBlock: header: Header -> Uint8Array