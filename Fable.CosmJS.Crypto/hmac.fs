// ts2fable 0.9.0
module rec Fable.CosmJS.Crypto.hmac

open System
open Fable.Core
open Fable.Core.JS

type HashFunction = hash.HashFunction

type [<AllowNullLiteral>] IExports =
    abstract Hmac: HmacStatic

type [<AllowNullLiteral>] Hmac<'H when 'H :> HashFunction> =
    inherit HashFunction
    abstract blockSize: float
    abstract update: data: Uint8Array -> Hmac<'H>
    abstract digest: unit -> Uint8Array

type [<AllowNullLiteral>] HmacStatic =
    [<EmitConstructor>] abstract Create: hashFunctionConstructor: obj * originalKey: Uint8Array -> Hmac<'H>