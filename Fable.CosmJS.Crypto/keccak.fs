// ts2fable 0.9.0
module rec Fable.CosmJS.Crypto.keccak

#nowarn "3390" // disable warnings for invalid XML comments

open System
open Fable.Core
open Fable.Core.JS

type HashFunction = hash.HashFunction

[<AllowNullLiteral>]
type IExports =
    abstract Keccak256: Keccak256Static
    /// <summary>Convenience function equivalent to <c>new Keccak256(data).digest()</c></summary>
    abstract keccak256: data: Uint8Array -> Uint8Array

[<AllowNullLiteral>]
type Keccak256 =
    inherit HashFunction
    abstract blockSize: float
    abstract update: data: Uint8Array -> Keccak256
    abstract digest: unit -> Uint8Array

[<AllowNullLiteral>]
type Keccak256Static =
    [<EmitConstructor>]
    abstract Create: ?firstData: Uint8Array -> Keccak256
