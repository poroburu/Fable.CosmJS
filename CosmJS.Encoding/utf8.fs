// ts2fable 0.9.0
module rec CosmJS.Encoding.utf8

open System
open Fable.Core
open Fable.Core.JS


[<AllowNullLiteral>]
type IExports =
    abstract toUtf8: str: string -> Uint8Array

    /// Takes UTF-8 data and decodes it to a string.
    ///
    /// In lossy mode, the replacement character � is used to substitute invalid
    /// encodings. By default lossy mode is off and invalid data will lead to exceptions.
    abstract fromUtf8: data: Uint8Array * ?lossy: bool -> string
