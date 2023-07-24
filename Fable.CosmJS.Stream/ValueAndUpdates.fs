// ts2fable 0.9.0
module rec Fable.CosmJS.Stream.ValueAndUpdates

#nowarn "3390" // disable warnings for invalid XML comments

open System
open Fable.Core
open Fable.Core.JS
open Fable.CosmJS
open Fable.CosmJS.Stream.DefaultValueProducer

type MemoryStream<'T> = XStream.MemoryStream<'T>

type [<AllowNullLiteral>] IExports =
    /// A read only wrapper around DefaultValueProducer that allows
    /// to synchronously get the current value using the .value property
    /// and listen to to updates by suscribing to the .updates stream
    abstract ValueAndUpdates: ValueAndUpdatesStatic

type [<AllowNullLiteral>] SearchFunction<'T> =
    [<Emit("$0($1...)")>] abstract Invoke: value: 'T -> bool

/// A read only wrapper around DefaultValueProducer that allows
/// to synchronously get the current value using the .value property
/// and listen to to updates by suscribing to the .updates stream
type [<AllowNullLiteral>] ValueAndUpdates<'T> =
    abstract updates: MemoryStream<'T>
    abstract value: 'T
    /// <summary>Resolves as soon as search value is found.</summary>
    /// <param name="search">either a value or a function that must return true when found</param>
    /// <returns>the value of the update that caused the search match</returns>
    abstract waitFor: search: U2<SearchFunction<'T>, 'T> -> Promise<'T>

/// A read only wrapper around DefaultValueProducer that allows
/// to synchronously get the current value using the .value property
/// and listen to to updates by suscribing to the .updates stream
type [<AllowNullLiteral>] ValueAndUpdatesStatic =
    [<EmitConstructor>] abstract Create: producer: DefaultValueProducer<'T> -> ValueAndUpdates<'T>