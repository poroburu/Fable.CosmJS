// ts2fable 0.9.0
module rec Fable.CosmJS.Encoding.hex
open System
open Fable.Core
open Fable.Core.JS


type [<AllowNullLiteral>] IExports =
    abstract toUtf8: str: string -> Uint8Array
    /// Takes UTF-8 data and decodes it to a string.
    /// 
    /// In lossy mode, the replacement character � is used to substitude invalid
    /// encodings. By default lossy mode is off and invalid data will lead to exceptions.
    abstract fromUtf8: data: Uint8Array * ?lossy: bool -> string
    abstract toHex: data: Uint8Array -> string
    abstract fromHex: hexstring: string -> Uint8Array