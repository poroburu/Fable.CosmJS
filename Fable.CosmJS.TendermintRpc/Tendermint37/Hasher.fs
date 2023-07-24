// ts2fable 0.9.0
module rec Fable.CosmJS.TendermintRpc.Tendermint37.Hasher

open System
open Fable.Core
open Fable.Core.JS

type ReadonlyDateWithNanoseconds = Fable.CosmJS.TendermintRpc.Dates.ReadonlyDateWithNanoseconds
type BlockId = Fable.CosmJS.TendermintRpc.Tendermint37.Responses.BlockId
type Version = Fable.CosmJS.TendermintRpc.Tendermint37.Responses.Version
type Header = Fable.CosmJS.TendermintRpc.Tendermint37.Responses.Header
type Record<'K,'V> = Fable.CosmJS.Record.Record<'K,'V>

type [<AllowNullLiteral>] IExports =
    /// A runtime checker that ensures a given value is set (i.e. not undefined or null)
    /// 
    /// This is used when you want to verify that data at runtime matches the expected type.
    abstract assertSet: value: 'T -> 'T
    /// A runtime checker that ensures a given value is a boolean
    /// 
    /// This is used when you want to verify that data at runtime matches the expected type.
    /// This implies assertSet.
    abstract assertBoolean: value: bool -> bool
    /// A runtime checker that ensures a given value is a string.
    /// 
    /// This is used when you want to verify that data at runtime matches the expected type.
    /// This implies assertSet.
    abstract assertString: value: string -> string
    /// A runtime checker that ensures a given value is a number
    /// 
    /// This is used when you want to verify that data at runtime matches the expected type.
    /// This implies assertSet.
    abstract assertNumber: value: float -> float
    /// A runtime checker that ensures a given value is an array
    /// 
    /// This is used when you want to verify that data at runtime matches the expected type.
    /// This implies assertSet.
    abstract assertArray: value: ResizeArray<'T> -> ResizeArray<'T>
    /// A runtime checker that ensures a given value is an object in the sense of JSON
    /// (an unordered collection of key–value pairs where the keys are strings)
    /// 
    /// This is used when you want to verify that data at runtime matches the expected type.
    /// This implies assertSet.
    abstract assertObject: value: 'T -> 'T
    /// Throws an error if value matches the empty value for the
    /// given type (array/string of length 0, number of value 0, ...)
    /// 
    /// Otherwise returns the value.
    /// 
    /// This implies assertSet
    abstract assertNotEmpty: value: 'T -> 'T
    abstract may: transform: ('T -> 'U) * value: 'T option -> 'U option
    abstract dictionaryToStringMap: obj: Record<string, obj> -> Map<string, string>
    abstract encodeString: s: string -> Uint8Array
    abstract encodeUvarint: n: float -> Uint8Array
    abstract encodeTime: time: ReadonlyDateWithNanoseconds -> Uint8Array
    abstract encodeBytes: bytes: Uint8Array -> Uint8Array
    abstract encodeVersion: version: Version -> Uint8Array
    abstract encodeBlockId: blockId: BlockId -> Uint8Array
    abstract hashTx: tx: Uint8Array -> Uint8Array
    abstract hashBlock: header: Header -> Uint8Array