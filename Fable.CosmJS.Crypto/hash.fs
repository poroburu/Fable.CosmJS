// ts2fable 0.9.0
module rec Fable.CosmJS.Crypto.hash

open System
open Fable.Core
open Fable.Core.JS


[<AllowNullLiteral>]
type HashFunction =
    abstract blockSize: float
    abstract update: Uint8Array -> HashFunction
    abstract digest: unit -> Uint8Array
