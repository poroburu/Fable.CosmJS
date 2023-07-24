// ts2fable 0.9.0
module rec Fable.CosmJS.Amino.Encoding

#nowarn "3390" // disable warnings for invalid XML comments

open System
open Fable.Core
open Fable.Core.JS

type Ed25519Pubkey = Fable.CosmJS.Amino.Pubkeys.Ed25519Pubkey
type Pubkey = Fable.CosmJS.Amino.Pubkeys.Pubkey
type Secp256k1Pubkey = Fable.CosmJS.Amino.Pubkeys.Secp256k1Pubkey

type [<AllowNullLiteral>] IExports =
    /// Takes a Secp256k1 public key as raw bytes and returns the Amino JSON
    /// representation of it (the type/value wrapper object).
    abstract encodeSecp256k1Pubkey: pubkey: Uint8Array -> Secp256k1Pubkey
    /// Takes an Edd25519 public key as raw bytes and returns the Amino JSON
    /// representation of it (the type/value wrapper object).
    abstract encodeEd25519Pubkey: pubkey: Uint8Array -> Ed25519Pubkey
    /// Decodes a pubkey in the Amino binary format to a type/value object.
    abstract decodeAminoPubkey: data: Uint8Array -> Pubkey
    /// <summary>
    /// Decodes a bech32 pubkey to Amino binary, which is then decoded to a type/value object.
    /// The bech32 prefix is ignored and discareded.
    /// </summary>
    /// <param name="bechEncoded">the bech32 encoded pubkey</param>
    abstract decodeBech32Pubkey: bechEncoded: string -> Pubkey
    /// Encodes a public key to binary Amino.
    abstract encodeAminoPubkey: pubkey: Pubkey -> Uint8Array
    /// <summary>Encodes a public key to binary Amino and then to bech32.</summary>
    /// <param name="pubkey">the public key to encode</param>
    /// <param name="prefix">the bech32 prefix (human readable part)</param>
    abstract encodeBech32Pubkey: pubkey: Pubkey * prefix: string -> string