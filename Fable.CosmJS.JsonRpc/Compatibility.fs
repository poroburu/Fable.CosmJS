// ts2fable 0.9.0
module rec Fable.CosmJS.JsonRpc.Compatibility
open System
open Fable.Core
open Fable.Core.JS

type ReadonlyArray<'T> = System.Collections.Generic.IReadOnlyList<'T>


type [<AllowNullLiteral>] IExports =
    abstract isJsonCompatibleValue: value: obj -> bool
    abstract isJsonCompatibleArray: value: obj -> bool
    abstract isJsonCompatibleDictionary: data: obj -> bool

/// A single JSON value. This is the missing return type of JSON.parse().
type JsonCompatibleValue =
    U5<JsonCompatibleDictionary, JsonCompatibleArray, string, float, bool> option

/// An array of JsonCompatibleValue
type [<AllowNullLiteral>] JsonCompatibleArray =
    inherit ReadonlyArray<JsonCompatibleValue>

/// A string to json value dictionary.
type [<AllowNullLiteral>] JsonCompatibleDictionary =
    [<EmitIndexer>] abstract Item: key: string -> U2<JsonCompatibleValue, ResizeArray<JsonCompatibleValue>>