// ts2fable 0.9.0
module rec Fable.CosmJS.Socket.StreamingSocket

open System
open Fable.Core
open Fable.Core.JS
open Fable.CosmJS

type Stream<'T> = XStream.Stream<'T>
type SocketWrapperMessageEvent = SocketWrapper.SocketWrapperMessageEvent

type [<AllowNullLiteral>] IExports =
    /// A WebSocket wrapper that exposes all events as a stream.
    /// 
    /// This underlying socket will not be closed when the stream has no listeners
    abstract StreamingSocket: StreamingSocketStatic

/// A WebSocket wrapper that exposes all events as a stream.
/// 
/// This underlying socket will not be closed when the stream has no listeners
type [<AllowNullLiteral>] StreamingSocket =
    abstract connected: Promise<unit>
    abstract events: Stream<SocketWrapperMessageEvent>
    abstract connect: unit -> unit
    abstract disconnect: unit -> unit
    abstract send: data: string -> Promise<unit>

/// A WebSocket wrapper that exposes all events as a stream.
/// 
/// This underlying socket will not be closed when the stream has no listeners
type [<AllowNullLiteral>] StreamingSocketStatic =
    [<EmitConstructor>] abstract Create: url: string * ?timeout: float -> StreamingSocket