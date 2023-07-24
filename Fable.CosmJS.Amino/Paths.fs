module rec Fable.CosmJS.Amino.Paths

// ts2fable 0.9.0
#nowarn "3390" // disable warnings for invalid XML comments

open System
open Fable.Core
open Fable.Core.JS

type HdPath = Fable.CosmJS.Crypto.slip10.HdPath

type [<AllowNullLiteral>] IExports =
    /// <summary>
    /// The Cosmos Hub derivation path in the form <c>m/44'/118'/0'/0/a</c>
    /// with 0-based account index <c>a</c>.
    /// </summary>
    abstract makeCosmoshubPath: a: float -> HdPath