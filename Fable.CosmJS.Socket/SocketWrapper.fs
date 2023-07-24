// ts2fable 0.9.0
module rec Fable.CosmJS.Socket.SocketWrapper

open System
open Fable.Core
open Fable.Core.JS

[<AllowNullLiteral>]
type IExports =
    /// A thin wrapper around isomorphic-ws' WebSocket class that adds
    /// - constant message/error/open/close handlers
    /// - explict connection via a connect() method
    /// - type support for events
    /// - handling of corner cases in the open and close behaviour
    abstract SocketWrapper: SocketWrapperStatic

[<AllowNullLiteral>]
type SocketWrapperCloseEvent =
    abstract wasClean: bool
    abstract code: float

[<AllowNullLiteral>]
type SocketWrapperErrorEvent =
    abstract isTrusted: bool option
    abstract ``type``: string option
    abstract message: string option

[<AllowNullLiteral>]
type SocketWrapperMessageEvent =
    abstract data: string
    abstract ``type``: string

/// A thin wrapper around isomorphic-ws' WebSocket class that adds
/// - constant message/error/open/close handlers
/// - explict connection via a connect() method
/// - type support for events
/// - handling of corner cases in the open and close behaviour
[<AllowNullLiteral>]
type SocketWrapper =
    abstract connected: Promise<unit>
    /// returns a promise that resolves when connection is open
    abstract connect: unit -> unit
    /// Closes an established connection and aborts other connection states
    abstract disconnect: unit -> unit
    abstract send: data: string -> Promise<unit>

/// A thin wrapper around isomorphic-ws' WebSocket class that adds
/// - constant message/error/open/close handlers
/// - explict connection via a connect() method
/// - type support for events
/// - handling of corner cases in the open and close behaviour
[<AllowNullLiteral>]
type SocketWrapperStatic =
    [<EmitConstructor>]
    abstract Create:
        url: string *
        messageHandler: (SocketWrapperMessageEvent -> unit) *
        errorHandler: (SocketWrapperErrorEvent -> unit) *
        ?openHandler: (unit -> unit) *
        ?closeHandler: (SocketWrapperCloseEvent -> unit) *
        ?timeout: float ->
            SocketWrapper
