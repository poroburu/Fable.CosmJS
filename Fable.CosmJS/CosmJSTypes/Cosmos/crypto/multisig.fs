module rec Fable.CosmJS.CosmJSTypes.Cosmos.crypto.multisig

// ts2fable 0.9.0
open System
open Fable.Core
open Fable.Core.JS

module _m0 = Fable.CosmJS.CosmJSTypes.Google.Protobuf.ProtobufRW

type Record<'K, 'V> = Fable.CosmJS.Record.Record<'K,'V>

[<Erase>] type KeyOf<'T> = Key of string

let [<Import("protobufPackage","module")>] protobufPackage: obj = jsNative
/// MultiSignature wraps the signatures from a multisig.LegacyAminoPubKey.
/// See cosmos.tx.v1betata1.ModeInfo.Multi for how to specify which signers
/// signed and with which modes.
let [<Import("MultiSignature","module")>] MultiSignature: MultiSignature<'I> = jsNative
/// CompactBitArray is an implementation of a space efficient bit array.
/// This is used to ensure that the encoded data takes up a minimal amount of
/// space after proto encoding.
/// This is not thread safe, and is not intended for concurrent usage.
let [<Import("CompactBitArray","module")>] CompactBitArray: CompactBitArray<'I> = jsNative

/// MultiSignature wraps the signatures from a multisig.LegacyAminoPubKey.
/// See cosmos.tx.v1betata1.ModeInfo.Multi for how to specify which signers
/// signed and with which modes.
type [<AllowNullLiteral>] MultiSignature =
    abstract signatures: ResizeArray<Uint8Array> with get, set

/// CompactBitArray is an implementation of a space efficient bit array.
/// This is used to ensure that the encoded data takes up a minimal amount of
/// space after proto encoding.
/// This is not thread safe, and is not intended for concurrent usage.
type [<AllowNullLiteral>] CompactBitArray =
    abstract extraBitsStored: float with get, set
    abstract elems: Uint8Array with get, set

type [<AllowNullLiteral>] MultiSignature<'I> =
    abstract encode: message: MultiSignature * ?writer: _m0.Writer -> _m0.Writer
    abstract decode: input: U2<_m0.Reader, Uint8Array> * ?length: float -> MultiSignature
    abstract fromJSON: object: obj option -> MultiSignature
    abstract toJSON: message: MultiSignature -> obj
    abstract fromPartial: object: 'I -> MultiSignature when 'I :> Record<Exclude<KeyOf<'I>, string>, obj>

type [<AllowNullLiteral>] CompactBitArray<'I> =
    abstract encode: message: CompactBitArray * ?writer: _m0.Writer -> _m0.Writer
    abstract decode: input: U2<_m0.Reader, Uint8Array> * ?length: float -> CompactBitArray
    abstract fromJSON: object: obj option -> CompactBitArray
    abstract toJSON: message: CompactBitArray -> obj
    abstract fromPartial: object: 'I -> CompactBitArray when 'I :> Record<Exclude<KeyOf<'I>, KeyOf<CompactBitArray>>, obj>