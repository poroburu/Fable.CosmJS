// ts2fable 0.9.0
module rec Fable.CosmJS.Amino.Pubkeys

#nowarn "3390" // disable warnings for invalid XML comments

open System
open Fable.Core
open Fable.Core.JS

let [<Import("pubkeyType","module")>] pubkeyType: {| secp256k1: string; ed25519: string; sr25519: string; multisigThreshold: string |} = jsNative

type [<AllowNullLiteral>] IExports =
    abstract isEd25519Pubkey: pubkey: Pubkey -> bool
    abstract isSecp256k1Pubkey: pubkey: Pubkey -> bool
    abstract isSinglePubkey: pubkey: Pubkey -> bool
    abstract isMultisigThresholdPubkey: pubkey: Pubkey -> bool

type [<AllowNullLiteral>] Pubkey =
    abstract ``type``: string
    abstract value: obj option

type [<AllowNullLiteral>] Ed25519Pubkey =
    inherit SinglePubkey
    abstract ``type``: string
    /// The base64 encoding of the Amino binary encoded pubkey.
    /// 
    /// Note: if type is Secp256k1, this must contain a 33 bytes compressed pubkey.
    abstract value: string

type [<AllowNullLiteral>] Secp256k1Pubkey =
    inherit SinglePubkey
    abstract ``type``: string
    /// The base64 encoding of the Amino binary encoded pubkey.
    /// 
    /// Note: if type is Secp256k1, this must contain a 33 bytes compressed pubkey.
    abstract value: string

/// A pubkey which contains the data directly without further nesting.
/// 
/// You can think of this as a non-multisig pubkey.
type [<AllowNullLiteral>] SinglePubkey =
    inherit Pubkey
    abstract ``type``: string
    /// The base64 encoding of the Amino binary encoded pubkey.
    /// 
    /// Note: if type is Secp256k1, this must contain a 33 bytes compressed pubkey.
    abstract value: string

type [<AllowNullLiteral>] MultisigThresholdPubkey =
    inherit Pubkey
    abstract ``type``: string
    abstract value: {| threshold: string; pubkeys: ResizeArray<SinglePubkey> |}