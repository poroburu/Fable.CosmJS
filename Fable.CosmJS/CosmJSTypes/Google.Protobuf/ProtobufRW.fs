module Fable.CosmJS.CosmJSTypes.Google.Protobuf.ProtobufRW

open Fable.Core.JS
open Fable.Core

/// Any compatible Long instance.
/// This is a minimal stand-alone definition of a Long instance. The actual type is that exported by long.js.
type [<AllowNullLiteral>] Long =
    /// Low bits
    abstract low: float with get, set
    /// High bits
    abstract high: float with get, set
    /// Whether unsigned or not
    abstract unsigned: bool with get, set

/// <summary>Wire format reader using <c>Uint8Array</c> if available, otherwise <c>Array</c>.</summary>
type [<AllowNullLiteral>] Reader =
    /// Read buffer.
    abstract buf: Uint8Array with get, set
    /// Read buffer position.
    abstract pos: float with get, set
    /// Read buffer length.
    abstract len: float with get, set
    /// <summary>Reads a varint as an unsigned 32 bit value.</summary>
    /// <returns>Value read</returns>
    abstract uint32: unit -> float
    /// <summary>Reads a varint as a signed 32 bit value.</summary>
    /// <returns>Value read</returns>
    abstract int32: unit -> float
    /// <summary>Reads a zig-zag encoded varint as a signed 32 bit value.</summary>
    /// <returns>Value read</returns>
    abstract sint32: unit -> float
    /// <summary>Reads a varint as a signed 64 bit value.</summary>
    /// <returns>Value read</returns>
    abstract int64: unit -> Long
    /// <summary>Reads a varint as an unsigned 64 bit value.</summary>
    /// <returns>Value read</returns>
    abstract uint64: unit -> Long
    /// <summary>Reads a zig-zag encoded varint as a signed 64 bit value.</summary>
    /// <returns>Value read</returns>
    abstract sint64: unit -> Long
    /// <summary>Reads a varint as a boolean.</summary>
    /// <returns>Value read</returns>
    abstract bool: unit -> bool
    /// <summary>Reads fixed 32 bits as an unsigned 32 bit integer.</summary>
    /// <returns>Value read</returns>
    abstract fixed32: unit -> float
    /// <summary>Reads fixed 32 bits as a signed 32 bit integer.</summary>
    /// <returns>Value read</returns>
    abstract sfixed32: unit -> float
    /// <summary>Reads fixed 64 bits.</summary>
    /// <returns>Value read</returns>
    abstract fixed64: unit -> Long
    /// <summary>Reads zig-zag encoded fixed 64 bits.</summary>
    /// <returns>Value read</returns>
    abstract sfixed64: unit -> Long
    /// <summary>Reads a float (32 bit) as a number.</summary>
    /// <returns>Value read</returns>
    abstract float: unit -> float
    /// <summary>Reads a double (64 bit float) as a number.</summary>
    /// <returns>Value read</returns>
    abstract double: unit -> float
    /// <summary>Reads a sequence of bytes preceeded by its length as a varint.</summary>
    /// <returns>Value read</returns>
    abstract bytes: unit -> Uint8Array
    /// <summary>Reads a string preceeded by its byte length as a varint.</summary>
    /// <returns>Value read</returns>
    abstract string: unit -> string
    /// <summary>Skips the specified number of bytes if specified, otherwise skips a varint.</summary>
    /// <param name="length">Length if known, otherwise a varint is assumed</param>
    /// <returns><c>this</c></returns>
    abstract skip: ?length: float -> Reader
    /// <summary>Skips the next element of the specified wire type.</summary>
    /// <param name="wireType">Wire type received</param>
    /// <returns><c>this</c></returns>
    abstract skipType: wireType: float -> Reader

/// <summary>Wire format writer using <c>Uint8Array</c> if available, otherwise <c>Array</c>.</summary>
type [<AllowNullLiteral>] Writer =
    /// Current length.
    abstract len: float with get, set
    /// Operations head.
    abstract head: obj with get, set
    /// Operations tail
    abstract tail: obj with get, set
    /// Linked forked states.
    abstract states: obj option with get, set
    /// <summary>Writes an unsigned 32 bit value as a varint.</summary>
    /// <param name="value">Value to write</param>
    /// <returns><c>this</c></returns>
    abstract uint32: value: float -> Writer
    /// <summary>Writes a signed 32 bit value as a varint.</summary>
    /// <param name="value">Value to write</param>
    /// <returns><c>this</c></returns>
    abstract int32: value: float -> Writer
    /// <summary>Writes a 32 bit value as a varint, zig-zag encoded.</summary>
    /// <param name="value">Value to write</param>
    /// <returns><c>this</c></returns>
    abstract sint32: value: float -> Writer
    /// <summary>Writes an unsigned 64 bit value as a varint.</summary>
    /// <param name="value">Value to write</param>
    /// <returns><c>this</c></returns>
    /// <exception cref="TypeError">If <c>value</c> is a string and no long library is present.</exception>
    abstract uint64: value: U3<Long, float, string> -> Writer
    /// <summary>Writes a signed 64 bit value as a varint.</summary>
    /// <param name="value">Value to write</param>
    /// <returns><c>this</c></returns>
    /// <exception cref="TypeError">If <c>value</c> is a string and no long library is present.</exception>
    abstract int64: value: U3<Long, float, string> -> Writer
    /// <summary>Writes a signed 64 bit value as a varint, zig-zag encoded.</summary>
    /// <param name="value">Value to write</param>
    /// <returns><c>this</c></returns>
    /// <exception cref="TypeError">If <c>value</c> is a string and no long library is present.</exception>
    abstract sint64: value: U3<Long, float, string> -> Writer
    /// <summary>Writes a boolish value as a varint.</summary>
    /// <param name="value">Value to write</param>
    /// <returns><c>this</c></returns>
    abstract bool: value: bool -> Writer
    /// <summary>Writes an unsigned 32 bit value as fixed 32 bits.</summary>
    /// <param name="value">Value to write</param>
    /// <returns><c>this</c></returns>
    abstract fixed32: value: float -> Writer
    /// <summary>Writes a signed 32 bit value as fixed 32 bits.</summary>
    /// <param name="value">Value to write</param>
    /// <returns><c>this</c></returns>
    abstract sfixed32: value: float -> Writer
    /// <summary>Writes an unsigned 64 bit value as fixed 64 bits.</summary>
    /// <param name="value">Value to write</param>
    /// <returns><c>this</c></returns>
    /// <exception cref="TypeError">If <c>value</c> is a string and no long library is present.</exception>
    abstract fixed64: value: U3<Long, float, string> -> Writer
    /// <summary>Writes a signed 64 bit value as fixed 64 bits.</summary>
    /// <param name="value">Value to write</param>
    /// <returns><c>this</c></returns>
    /// <exception cref="TypeError">If <c>value</c> is a string and no long library is present.</exception>
    abstract sfixed64: value: U3<Long, float, string> -> Writer
    /// <summary>Writes a float (32 bit).</summary>
    /// <param name="value">Value to write</param>
    /// <returns><c>this</c></returns>
    abstract float: value: float -> Writer
    /// <summary>Writes a double (64 bit float).</summary>
    /// <param name="value">Value to write</param>
    /// <returns><c>this</c></returns>
    abstract double: value: float -> Writer
    /// <summary>Writes a sequence of bytes.</summary>
    /// <param name="value">Buffer or base64 encoded string to write</param>
    /// <returns><c>this</c></returns>
    abstract bytes: value: U2<Uint8Array, string> -> Writer
    /// <summary>Writes a string.</summary>
    /// <param name="value">Value to write</param>
    /// <returns><c>this</c></returns>
    abstract string: value: string -> Writer
    /// <summary>
    /// Forks this writer's state by pushing it to a stack.
    /// Calling <see cref="Writer.reset">reset</see> or <see cref="Writer.ldelim">ldelim</see> resets the writer to the previous state.
    /// </summary>
    /// <returns><c>this</c></returns>
    abstract fork: unit -> Writer
    /// <summary>Resets this instance to the last state.</summary>
    /// <returns><c>this</c></returns>
    abstract reset: unit -> Writer
    /// <summary>Resets to the last state and appends the fork state's current write length as a varint followed by its operations.</summary>
    /// <returns><c>this</c></returns>
    abstract ldelim: unit -> Writer
    /// <summary>Finishes the write operation.</summary>
    /// <returns>Finished buffer</returns>
    abstract finish: unit -> Uint8Array