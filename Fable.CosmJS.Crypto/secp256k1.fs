// ts2fable 0.9.0
module rec Fable.CosmJS.Crypto.secp256k1

#nowarn "3390" // disable warnings for invalid XML comments

open System
open Fable.Core
open Fable.Core.JS

type ExtendedSecp256k1Signature = secp256k1signature.ExtendedSecp256k1Signature
type Secp256k1Signature = secp256k1signature.Secp256k1Signature

type [<AllowNullLiteral>] IExports =
    abstract Secp256k1: Secp256k1Static

type [<AllowNullLiteral>] Secp256k1Keypair =
    /// A 32 byte private key
    abstract pubkey: Uint8Array
    /// <summary>
    /// A raw secp256k1 public key.
    /// 
    /// The type itself does not give you any guarantee if this is
    /// compressed or uncompressed. If you are unsure where the data
    /// is coming from, use <c>Secp256k1.compressPubkey</c> or
    /// <c>Secp256k1.uncompressPubkey</c> (both idempotent) before processing it.
    /// </summary>
    abstract privkey: Uint8Array

type [<AllowNullLiteral>] Secp256k1 =
    interface end

type [<AllowNullLiteral>] Secp256k1Static =
    [<EmitConstructor>] abstract Create: unit -> Secp256k1
    /// <summary>
    /// Takes a 32 byte private key and returns a privkey/pubkey pair.
    /// 
    /// The resulting pubkey is uncompressed. For the use in Cosmos it should
    /// be compressed first using <c>Secp256k1.compressPubkey</c>.
    /// </summary>
    abstract makeKeypair: privkey: Uint8Array -> Promise<Secp256k1Keypair>
    /// Creates a signature that is
    /// - deterministic (RFC 6979)
    /// - lowS signature
    /// - DER encoded
    abstract createSignature: messageHash: Uint8Array * privkey: Uint8Array -> Promise<ExtendedSecp256k1Signature>
    abstract verifySignature: signature: Secp256k1Signature * messageHash: Uint8Array * pubkey: Uint8Array -> Promise<bool>
    abstract recoverPubkey: signature: ExtendedSecp256k1Signature * messageHash: Uint8Array -> Uint8Array
    /// Takes a compressed or uncompressed pubkey and return a compressed one.
    /// 
    /// This function is idempotent.
    abstract compressPubkey: pubkey: Uint8Array -> Uint8Array
    /// Takes a compressed or uncompressed pubkey and returns an uncompressed one.
    /// 
    /// This function is idempotent.
    abstract uncompressPubkey: pubkey: Uint8Array -> Uint8Array
    abstract trimRecoveryByte: signature: Uint8Array -> Uint8Array