// ts2fable 0.9.0
module rec Fable.CosmJS.Amino.Signature

#nowarn "3390" // disable warnings for invalid XML comments

open System
open Fable.Core
open Fable.Core.JS

type Pubkey = Fable.CosmJS.Amino.Pubkeys.Pubkey

type [<AllowNullLiteral>] IExports =
    /// <summary>Takes a binary pubkey and signature to create a signature object</summary>
    /// <param name="pubkey">a compressed secp256k1 public key</param>
    /// <param name="signature">a 64 byte fixed length representation of secp256k1 signature components r and s</param>
    abstract encodeSecp256k1Signature: pubkey: Uint8Array * signature: Uint8Array -> StdSignature
    abstract decodeSignature: signature: StdSignature -> {| pubkey: Uint8Array; signature: Uint8Array |}

type [<AllowNullLiteral>] StdSignature =
    abstract pub_key: Pubkey
    abstract signature: string