// ts2fable 0.9.0
module rec Fable.CosmJS.Crypto.ripemd

#nowarn "3390" // disable warnings for invalid XML comments

open System
open Fable.Core
open Fable.Core.JS

type HashFunction = hash.HashFunction

type [<AllowNullLiteral>] IExports =
    abstract Ripemd160: Ripemd160Static
    /// <summary>Convenience function equivalent to <c>new Ripemd160(data).digest()</c></summary>
    abstract ripemd160: data: Uint8Array -> Uint8Array

type [<AllowNullLiteral>] Ripemd160 =
    inherit HashFunction
    abstract blockSize: float
    abstract update: data: Uint8Array -> Ripemd160
    abstract digest: unit -> Uint8Array

type [<AllowNullLiteral>] Ripemd160Static =
    [<EmitConstructor>] abstract Create: ?firstData: Uint8Array -> Ripemd160