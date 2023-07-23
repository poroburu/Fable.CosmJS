// ts2fable 0.9.0
module rec Fable.CosmJS.Encoding.ascii
open System
open Fable.Core
open Fable.Core.JS


type [<AllowNullLiteral>] IExports =
    abstract toAscii: input: string -> Uint8Array
    abstract fromAscii: data: Uint8Array -> string