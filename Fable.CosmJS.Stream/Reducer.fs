// ts2fable 0.9.0
module rec Fable.CosmJS.Stream.Reducer

#nowarn "3390" // disable warnings for invalid XML comments

open System
open Fable.Core
open Fable.Core.JS
open Fable.CosmJS
open Fable.CosmJS.Iterable

type Stream<'T> = XStream.Stream<'T>

[<AllowNullLiteral>]
type IExports =
    /// Emits one event for each list element as soon as the promise resolves
    abstract fromListPromise: promise: Promise<Iterable<'T>> -> Stream<'T>

    /// <summary>
    /// Listens to stream and collects events. When <c>count</c> events are collected,
    /// the promise resolves with an array of events.
    ///
    /// Rejects if stream completes before <c>count</c> events are collected.
    /// </summary>
    abstract toListPromise: stream: Stream<'T> * count: float -> Promise<ResizeArray<'T>>

    /// Listens to stream, collects one event and revolves.
    ///
    /// Rejects if stream completes before one event was fired.
    abstract firstEvent: stream: Stream<'T> -> Promise<'T>

    abstract Reducer: ReducerStatic
    abstract countStream: stream: Stream<'T> -> Reducer<'T, float>
    abstract asArray: stream: Stream<'T> -> Reducer<'T, ResizeArray<'T>>
    abstract lastValue: stream: Stream<'T> -> Reducer<'T, 'T option>

[<AllowNullLiteral>]
type ReducerFunc<'T, 'U> =
    [<Emit("$0($1...)")>]
    abstract Invoke: acc: 'U * evt: 'T -> 'U

[<AllowNullLiteral>]
type Reducer<'T, 'U> =
    abstract value: unit -> 'U
    abstract finished: unit -> Promise<unit>

[<AllowNullLiteral>]
type ReducerStatic =
    [<EmitConstructor>]
    abstract Create: stream: Stream<'T> * reducer: ReducerFunc<'T, 'U> * initState: 'U -> Reducer<'T, 'U>
