module rec Fable.CosmJS.Amino.Multisig

// ts2fable 0.9.0
#nowarn "3390" // disable warnings for invalid XML comments

open System
open Fable.Core
open Fable.Core.JS

type MultisigThresholdPubkey = Fable.CosmJS.Amino.Pubkeys.MultisigThresholdPubkey
type SinglePubkey = Fable.CosmJS.Amino.Pubkeys.SinglePubkey

type [<AllowNullLiteral>] IExports =
    /// <summary>
    /// Compare arrays lexicographically.
    /// 
    /// Returns value &lt; 0 if <c>a &lt; b</c>.
    /// Returns value &gt; 0 if <c>a &gt; b</c>.
    /// Returns 0 if <c>a === b</c>.
    /// </summary>
    abstract compareArrays: a: Uint8Array * b: Uint8Array -> float
    abstract createMultisigThresholdPubkey: pubkeys: ResizeArray<SinglePubkey> * threshold: float * ?nosort: bool -> MultisigThresholdPubkey