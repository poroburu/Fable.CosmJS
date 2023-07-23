// ts2fable 0.9.0
module rec CosmJS.Encoding.bech32

#nowarn "3390" // disable warnings for invalid XML comments

open System
open Fable.Core
open Fable.Core.JS


[<AllowNullLiteral>]
type IExports =
    abstract toBech32: prefix: string * data: Uint8Array * ?limit: float -> string
    abstract fromBech32: address: string * ?limit: float -> {| prefix: string; data: Uint8Array |}

    /// <summary>
    /// Takes a bech32 address and returns a normalized (i.e. lower case) representation of it.
    ///
    /// The input is validated along the way, which makes this significantly safer than
    /// using <c>address.toLowerCase()</c>.
    /// </summary>
    abstract normalizeBech32: address: string -> string
