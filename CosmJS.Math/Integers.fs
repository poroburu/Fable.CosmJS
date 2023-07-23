// ts2fable 0.9.0
module rec CosmJS.Math.Integers

#nowarn "3390" // disable warnings for invalid XML comments
#nowarn "0044" // disable warnings for `Obsolete` usage

open System
open Fable.Core
open Fable.Core.JS

type ArrayLike<'T> = System.Collections.Generic.IList<'T>


[<AllowNullLiteral>]
type IExports =
    abstract uint64MaxValue: obj
    abstract Uint32: Uint32Static
    abstract Int53: Int53Static
    abstract Uint53: Uint53Static
    abstract Uint64: Uint64Static
    abstract _int53Class: IntegerStatic<Int53>
    abstract _uint53Class: IntegerStatic<Uint53>
    abstract _uint32Class: obj
    abstract _uint64Class: obj

/// Internal interface to ensure all integer types can be used equally
[<AllowNullLiteral>]
type Integer =
    abstract toNumber: unit -> float
    abstract toBigInt: unit -> obj
    abstract toString: unit -> string

[<AllowNullLiteral>]
type WithByteConverters =
    abstract toBytesBigEndian: unit -> Uint8Array
    abstract toBytesLittleEndian: unit -> Uint8Array

[<AllowNullLiteral>]
type IntegerStatic<'T> =
    abstract fromString: string -> 'T

[<AllowNullLiteral>]
type FixedLengthIntegerStatic<'T> =
    abstract fromBytes: ArrayLike<float> -> FixedLengthIntegerStaticFromBytes -> 'T

[<AllowNullLiteral>]
type Uint32 =
    inherit Integer
    inherit WithByteConverters
    abstract data: float
    abstract toBytesBigEndian: unit -> Uint8Array
    abstract toBytesLittleEndian: unit -> Uint8Array
    abstract toNumber: unit -> float
    abstract toBigInt: unit -> obj
    abstract toString: unit -> string

[<AllowNullLiteral>]
type Uint32Static =
    [<Obsolete("use Uint32.fromBytes")>]
    abstract fromBigEndianBytes: bytes: ArrayLike<float> -> Uint32

    /// <summary>Creates a Uint32 from a fixed length byte array.</summary>
    /// <param name="bytes">a list of exactly 4 bytes</param>
    /// <param name="endianess">defaults to big endian</param>
    abstract fromBytes: bytes: ArrayLike<float> * endianess: FixedLengthIntegerStaticFromBytes -> Uint32

    abstract fromString: str: string -> Uint32

    [<EmitConstructor>]
    abstract Create: input: float -> Uint32

[<AllowNullLiteral>]
type Int53 =
    inherit Integer
    abstract data: float
    abstract toNumber: unit -> float
    abstract toBigInt: unit -> obj
    abstract toString: unit -> string

[<AllowNullLiteral>]
type Int53Static =
    abstract fromString: str: string -> Int53

    [<EmitConstructor>]
    abstract Create: input: float -> Int53

[<AllowNullLiteral>]
type Uint53 =
    inherit Integer
    abstract data: Int53
    abstract toNumber: unit -> float
    abstract toBigInt: unit -> obj
    abstract toString: unit -> string

[<AllowNullLiteral>]
type Uint53Static =
    abstract fromString: str: string -> Uint53

    [<EmitConstructor>]
    abstract Create: input: float -> Uint53

[<AllowNullLiteral>]
type Uint64 =
    inherit Integer
    inherit WithByteConverters
    abstract toBytesBigEndian: unit -> Uint8Array
    abstract toBytesLittleEndian: unit -> Uint8Array
    abstract toString: unit -> string
    abstract toBigInt: unit -> obj
    abstract toNumber: unit -> float

[<AllowNullLiteral>]
type Uint64Static =
    [<Obsolete("use Uint64.fromBytes")>]
    abstract fromBytesBigEndian: bytes: ArrayLike<float> -> Uint64

    /// <summary>Creates a Uint64 from a fixed length byte array.</summary>
    /// <param name="bytes">a list of exactly 8 bytes</param>
    /// <param name="endianess">defaults to big endian</param>
    abstract fromBytes: bytes: ArrayLike<float> * endianess: FixedLengthIntegerStaticFromBytes -> Uint64

    abstract fromString: str: string -> Uint64
    abstract fromNumber: input: float -> Uint64

[<StringEnum>]
[<RequireQualifiedAccess>]
type FixedLengthIntegerStaticFromBytes =
    | Be
    | Le
