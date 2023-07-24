// ts2fable 0.9.0
module rec Fable.CosmJS.Stream.DefaultValueProducer

#nowarn "3390" // disable warnings for invalid XML comments

open System
open Fable.Core
open Fable.Core.JS
open Fable.CosmJS
type Array<'T> = System.Collections.Generic.IList<'T>

type Stream<'T> = XStream.Stream<'T>
type Listener<'T> = XStream.Listener<'T>
type Producer<'T> = XStream.Producer<'T>

[<AllowNullLiteral>]
type IExports =
    /// <summary>
    /// An implementation of concat that buffers all source stream events
    ///
    /// Marble diagram:
    ///
    /// <code lang="text">
    /// --1--2---3---4-|
    /// -a--b-c--d-|
    /// --------X---------Y---------Z-
    ///           concat
    /// --1--2---3---4-abcdXY-------Z-
    /// </code>
    ///
    /// This is inspired by RxJS's concat as documented at <see href="http://rxmarbles.com/#concat" /> and behaves
    /// differently than xstream's concat as discussed in <see href="https://github.com/staltz/xstream/issues/170." />
    /// </summary>
    abstract concat: [<ParamArray>] streams: Array<Stream<'T>> -> Stream<'T>

    abstract DefaultValueProducer: DefaultValueProducerStatic

[<AllowNullLiteral>]
type DefaultValueProducerCallsbacks =
    abstract onStarted: unit -> unit
    abstract onStop: unit -> unit

[<AllowNullLiteral>]
type DefaultValueProducer<'T> =
    inherit Producer<'T>
    abstract value: 'T

    /// Update the current value.
    ///
    /// If producer is active (i.e. someone is listening), this emits an event.
    /// If not, just the current value is updated.
    abstract update: value: 'T -> unit

    /// Produce an error
    abstract error: error: obj option -> unit
    /// Called by the stream. Do not call this directly.
    abstract start: listener: Listener<'T> -> unit
    /// Called by the stream. Do not call this directly.
    abstract stop: unit -> unit

[<AllowNullLiteral>]
type DefaultValueProducerStatic =
    [<EmitConstructor>]
    abstract Create: value: 'T * ?callbacks: DefaultValueProducerCallsbacks -> DefaultValueProducer<'T>
