// ts2fable 0.9.0
module rec Fable.CosmJS.Crypto.sha

#nowarn "3390" // disable warnings for invalid XML comments

open System
open Fable.Core
open Fable.Core.JS

type HashFunction = hash.HashFunction

[<AllowNullLiteral>]
type IExports =
    abstract Sha256: Sha256Static
    /// <summary>Convenience function equivalent to <c>new Sha256(data).digest()</c></summary>
    abstract sha256: data: Uint8Array -> Uint8Array
    abstract Sha512: Sha512Static
    /// <summary>Convenience function equivalent to <c>new Sha512(data).digest()</c></summary>
    abstract sha512: data: Uint8Array -> Uint8Array

[<AllowNullLiteral>]
type Sha256 =
    inherit HashFunction
    abstract blockSize: float
    abstract update: data: Uint8Array -> Sha256
    abstract digest: unit -> Uint8Array

[<AllowNullLiteral>]
type Sha256Static =
    [<EmitConstructor>]
    abstract Create: ?firstData: Uint8Array -> Sha256

[<AllowNullLiteral>]
type Sha512 =
    inherit HashFunction
    abstract blockSize: float
    abstract update: data: Uint8Array -> Sha512
    abstract digest: unit -> Uint8Array

[<AllowNullLiteral>]
type Sha512Static =
    [<EmitConstructor>]
    abstract Create: ?firstData: Uint8Array -> Sha512
