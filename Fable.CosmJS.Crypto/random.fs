// ts2fable 0.9.0
module rec Fable.CosmJS.Crypto.random

#nowarn "3390" // disable warnings for invalid XML comments

open System
open Fable.Core
open Fable.Core.JS


type [<AllowNullLiteral>] IExports =
    abstract Random: RandomStatic

type [<AllowNullLiteral>] Random =
    interface end

type [<AllowNullLiteral>] RandomStatic =
    [<EmitConstructor>] abstract Create: unit -> Random
    /// <summary>Returns <c>count</c> cryptographically secure random bytes</summary>
    abstract getBytes: count: float -> Uint8Array