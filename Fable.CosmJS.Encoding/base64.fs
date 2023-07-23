// ts2fable 0.9.0
module rec Fable.CosmJS.Encoding.base64

open System
open Fable.Core
open Fable.Core.JS


[<AllowNullLiteral>]
type IExports =
    abstract toBase64: data: Uint8Array -> string
    abstract fromBase64: base64String: string -> Uint8Array
