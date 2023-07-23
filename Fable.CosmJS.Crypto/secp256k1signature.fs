// ts2fable 0.9.0
module rec Fable.CosmJS.Crypto.secp256k1signature

#nowarn "3390" // disable warnings for invalid XML comments

open System
open Fable.Core
open Fable.Core.JS


type [<AllowNullLiteral>] IExports =
    abstract Secp256k1Signature: Secp256k1SignatureStatic
    /// A Secp256k1Signature plus the recovery parameter
    abstract ExtendedSecp256k1Signature: ExtendedSecp256k1SignatureStatic

type [<AllowNullLiteral>] Secp256k1Signature =
    abstract r: ?length: float -> Uint8Array
    abstract s: ?length: float -> Uint8Array
    abstract toFixedLength: unit -> Uint8Array
    abstract toDer: unit -> Uint8Array

type [<AllowNullLiteral>] Secp256k1SignatureStatic =
    /// <summary>
    /// Takes the pair of integers (r, s) as 2x32 byte of binary data.
    /// 
    /// Note: This is the format Cosmos SDK uses natively.
    /// </summary>
    /// <param name="data">a 64 byte value containing integers r and s.</param>
    abstract fromFixedLength: data: Uint8Array -> Secp256k1Signature
    abstract fromDer: data: Uint8Array -> Secp256k1Signature
    [<EmitConstructor>] abstract Create: r: Uint8Array * s: Uint8Array -> Secp256k1Signature

/// A Secp256k1Signature plus the recovery parameter
type [<AllowNullLiteral>] ExtendedSecp256k1Signature =
    inherit Secp256k1Signature
    abstract recovery: float
    /// A simple custom encoding that encodes the extended signature as
    /// r (32 bytes) | s (32 bytes) | recovery param (1 byte)
    /// where | denotes concatenation of bonary data.
    abstract toFixedLength: unit -> Uint8Array

/// A Secp256k1Signature plus the recovery parameter
type [<AllowNullLiteral>] ExtendedSecp256k1SignatureStatic =
    /// Decode extended signature from the simple fixed length encoding
    /// described in toFixedLength().
    abstract fromFixedLength: data: Uint8Array -> ExtendedSecp256k1Signature
    [<EmitConstructor>] abstract Create: r: Uint8Array * s: Uint8Array * recovery: float -> ExtendedSecp256k1Signature