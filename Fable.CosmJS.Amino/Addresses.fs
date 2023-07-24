// ts2fable 0.9.0
module rec Fable.CosmJS.Amino.Addresses

open System
open Fable.Core
open Fable.Core.JS

type Pubkey = Fable.CosmJS.Amino.Pubkeys.Pubkey

type [<AllowNullLiteral>] IExports =
    abstract rawEd25519PubkeyToRawAddress: pubkeyData: Uint8Array -> Uint8Array
    abstract rawSecp256k1PubkeyToRawAddress: pubkeyData: Uint8Array -> Uint8Array
    abstract pubkeyToRawAddress: pubkey: Pubkey -> Uint8Array
    abstract pubkeyToAddress: pubkey: Pubkey * prefix: string -> string