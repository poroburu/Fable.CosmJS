// ts2fable 0.9.0
module rec Fable.CosmJS.Socket.ReconnectingSocket

open System
open Fable.Core
open Fable.Core.JS
open Fable.CosmJS
open Fable.CosmJS.Socket.SocketWrapper
//open Fable.CosmJS.Stream.ValueAndUpdates


type ValueAndUpdates<'T> = Fable.CosmJS.Stream.ValueAndUpdates.ValueAndUpdates<'T>
type Stream<'T> = XStream.Stream<'T>
type ConnectionStatus = QueueingStreamingSocket.ConnectionStatus
type SocketWrapperMessageEvent = SocketWrapper.SocketWrapperMessageEvent

[<AllowNullLiteral>]
type IExports =
    /// A wrapper around QueueingStreamingSocket that reconnects automatically.
    abstract ReconnectingSocket: ReconnectingSocketStatic

/// A wrapper around QueueingStreamingSocket that reconnects automatically.
[<AllowNullLiteral>]
type ReconnectingSocket =
    abstract connectionStatus: ValueAndUpdates<ConnectionStatus>
    abstract events: Stream<SocketWrapperMessageEvent>
    abstract connect: unit -> unit
    abstract disconnect: unit -> unit
    abstract queueRequest: request: string -> unit

/// A wrapper around QueueingStreamingSocket that reconnects automatically.
[<AllowNullLiteral>]
type ReconnectingSocketStatic =
    [<EmitConstructor>]
    abstract Create: url: string * ?timeout: float * ?reconnectedHandler: (unit -> unit) -> ReconnectingSocket
