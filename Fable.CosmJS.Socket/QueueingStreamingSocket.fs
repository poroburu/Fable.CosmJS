// ts2fable 0.9.0
module rec Fable.CosmJS.Socket.QueueingStreamingSocket

open System
open Fable.Core
open Fable.Core.JS
open Fable.CosmJS
open Fable.CosmJS.Stream

type ValueAndUpdates<'T> = ValueAndUpdates.ValueAndUpdates<'T>
type Stream<'T> = XStream.Stream<'T>
type SocketWrapperMessageEvent = SocketWrapperMessageEvent

type [<AllowNullLiteral>] IExports =
    /// A wrapper around StreamingSocket that can queue requests.
    abstract QueueingStreamingSocket: QueueingStreamingSocketStatic

type [<RequireQualifiedAccess>] ConnectionStatus =
    | Unconnected = 0
    | Connecting = 1
    | Connected = 2
    | Disconnected = 3

/// A wrapper around StreamingSocket that can queue requests.
type [<AllowNullLiteral>] QueueingStreamingSocket =
    abstract connectionStatus: ValueAndUpdates<ConnectionStatus>
    abstract events: Stream<SocketWrapperMessageEvent>
    abstract connect: unit -> unit
    abstract disconnect: unit -> unit
    abstract reconnect: unit -> unit
    abstract getQueueLength: unit -> float
    abstract queueRequest: request: string -> unit

/// A wrapper around StreamingSocket that can queue requests.
type [<AllowNullLiteral>] QueueingStreamingSocketStatic =
    [<EmitConstructor>] abstract Create: url: string * ?timeout: float * ?reconnectedHandler: (unit -> unit) -> QueueingStreamingSocket