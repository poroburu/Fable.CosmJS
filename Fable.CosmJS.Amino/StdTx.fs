// ts2fable 0.9.0
module rec Fable.CosmJS.Amino.StdTx

#nowarn "3390" // disable warnings for invalid XML comments

open System
open Fable.Core
open Fable.Core.JS

type StdSignature = Fable.CosmJS.Amino.Signature.StdSignature
type AminoMsg = Fable.CosmJS.Amino.SignDoc.AminoMsg
type StdFee = Fable.CosmJS.Amino.SignDoc.StdFee
type StdSignDoc = Fable.CosmJS.Amino.SignDoc.StdSignDoc

type [<AllowNullLiteral>] IExports =
    abstract isStdTx: txValue: obj -> bool
    abstract makeStdTx: content: obj * signatures: U2<StdSignature, ResizeArray<StdSignature>> -> StdTx

/// <summary>A Cosmos SDK StdTx</summary>
/// <seealso href="https://docs.cosmos.network/master/modules/auth/03_types.html#stdtx" />
type [<AllowNullLiteral>] StdTx =
    abstract msg: ResizeArray<AminoMsg>
    abstract fee: StdFee
    abstract signatures: ResizeArray<StdSignature>
    abstract memo: string option