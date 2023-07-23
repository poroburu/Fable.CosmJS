// ts2fable 0.9.0
module rec Fable.CosmJS.Crypto.slip10

#nowarn "3390" // disable warnings for invalid XML comments

open System
open Fable.Core
open Fable.Core.JS

type Uint32 = Fable.CosmJS.Math.Integers.Uint32

[<AllowNullLiteral>]
type IExports =
    /// Reverse mapping of Slip10Curve
    abstract slip10CurveFromString: curveString: string -> Slip10Curve
    abstract Slip10RawIndex: Slip10RawIndexStatic
    abstract Slip10: Slip10Static
    abstract pathToString: path: HdPath -> string
    abstract stringToPath: input: string -> HdPath

[<AllowNullLiteral>]
type Slip10Result =
    abstract chainCode: Uint8Array
    abstract privkey: Uint8Array

/// <summary>Raw values must match the curve string in SLIP-0010 master key generation</summary>
/// <seealso href="https://github.com/satoshilabs/slips/blob/master/slip-0010.md#master-key-generation" />
[<StringEnum>]
[<RequireQualifiedAccess>]
type Slip10Curve =
    | [<CompiledName("Bitcoin seed")>] Secp256k1
    | [<CompiledName("ed25519 seed")>] Ed25519

[<AllowNullLiteral>]
type Slip10RawIndex =
    inherit Uint32
    abstract isHardened: unit -> bool

[<AllowNullLiteral>]
type Slip10RawIndexStatic =
    [<EmitConstructor>]
    abstract Create: unit -> Slip10RawIndex

    abstract hardened: hardenedIndex: float -> Slip10RawIndex
    abstract normal: normalIndex: float -> Slip10RawIndex

/// An array of raw SLIP10 indices.
///
/// This can be constructed via string parsing:
///
/// <code lang="ts">
/// import { stringToPath } from "@cosmjs/crypto";
///
/// const path = stringToPath("m/0'/1/2'/2/1000000000");
/// </code>
///
/// or manually:
///
/// <code lang="ts">
/// import { HdPath, Slip10RawIndex } from "@cosmjs/crypto";
///
/// // m/0'/1/2'/2/1000000000
/// const path: HdPath = [
///   Slip10RawIndex.hardened(0),
///   Slip10RawIndex.normal(1),
///   Slip10RawIndex.hardened(2),
///   Slip10RawIndex.normal(2),
///   Slip10RawIndex.normal(1000000000),
/// ];
/// </code>
type HdPath = ResizeArray<Slip10RawIndex>

[<AllowNullLiteral>]
type Slip10 =
    interface
    end

[<AllowNullLiteral>]
type Slip10Static =
    [<EmitConstructor>]
    abstract Create: unit -> Slip10

    abstract derivePath: curve: Slip10Curve * seed: Uint8Array * path: HdPath -> Slip10Result
