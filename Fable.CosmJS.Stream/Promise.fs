// ts2fable 0.9.0
module rec Fable.CosmJS.Stream.Promise

#nowarn "3390" // disable warnings for invalid XML comments

open System
open Fable.Core
open Fable.Core.JS
open Fable.CosmJS.Iterable
open Fable.CosmJS.XStream

type [<AllowNullLiteral>] IExports =
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