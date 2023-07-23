module rec Fable.CosmJS.Crypto.utils
// ts2fable 0.9.0

open System
open Fable.Core
open Fable.Core.JS

type ArrayLike<'T> = System.Collections.Generic.IList<'T>


[<AllowNullLiteral>]
type IExports =
    abstract toRealUint8Array: data: ArrayLike<float> -> Uint8Array
