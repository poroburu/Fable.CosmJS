// ts2fable 0.9.0
module rec Fable.CosmJS.Stream.DropDuplicates

open System
open Fable.Core
open Fable.Core.JS
open Fable.CosmJS

type Stream<'T> = XStream.Stream<'T>

[<AllowNullLiteral>]
type IExports =
    /// Drops duplicate values in a stream.
    ///
    /// Marble diagram:
    ///
    /// <code lang="text">
    /// -1-1-1-2-4-3-3-4--
    ///   dropDuplicates
    /// -1-----2-4-3------
    /// </code>
    ///
    /// Each value must be uniquely identified by a string given by
    /// valueToKey(value).
    ///
    /// Internally this maintains a set of keys that have been processed already,
    /// i.e. memory consumption and Set lookup times should be considered when
    /// using this function.
    abstract dropDuplicates: valueToKey: ('T -> string) -> SameTypeStreamOperator<'T>

/// The type that fits into Stream.compose() with input stream and output stream
/// of the same type.
[<AllowNullLiteral>]
type SameTypeStreamOperator<'T> =
    /// The type that fits into Stream.compose() with input stream and output stream
    /// of the same type.
    [<Emit("$0($1...)")>]
    abstract Invoke: ins: Stream<'T> -> Stream<'T>
