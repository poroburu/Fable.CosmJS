// ts2fable 0.9.0
module rec Fable.CosmJS.ReadonlyDate

open System
open Fable.Core
open Fable.Core.JS
open Fable.Import.Browser

/// An object like JavaScript's Date, but immutable.
/// 
/// Immutability is enforced at compile time by removing
/// all mutable methods in the type definition.
let [<Import("ReadonlyDate","module")>] ReadonlyDate: ReadonlyDateConstructor = jsNative

type [<AllowNullLiteral>] IExports =
    abstract ReadonlyDateConstructor: ReadonlyDateConstructorStatic

/// An object like JavaScript's Date, but immutable.
/// 
/// Immutability is enforced at compile time by removing
/// all mutable methods in the type definition.
type [<AllowNullLiteral>] ReadonlyDate =
    abstract toString: unit -> string
    abstract toDateString: unit -> string
    abstract toTimeString: unit -> string
    abstract toLocaleString: unit -> string
    abstract toLocaleDateString: unit -> string
    abstract toLocaleTimeString: unit -> string
    abstract valueOf: unit -> float
    abstract getTime: unit -> float
    abstract getFullYear: unit -> float
    abstract getUTCFullYear: unit -> float
    abstract getMonth: unit -> float
    abstract getUTCMonth: unit -> float
    abstract getDate: unit -> float
    abstract getUTCDate: unit -> float
    abstract getDay: unit -> float
    abstract getUTCDay: unit -> float
    abstract getHours: unit -> float
    abstract getUTCHours: unit -> float
    abstract getMinutes: unit -> float
    abstract getUTCMinutes: unit -> float
    abstract getSeconds: unit -> float
    abstract getUTCSeconds: unit -> float
    abstract getMilliseconds: unit -> float
    abstract getUTCMilliseconds: unit -> float
    abstract getTimezoneOffset: unit -> float
    abstract toUTCString: unit -> string
    abstract toISOString: unit -> string
    abstract toJSON: ?key: obj -> string
    abstract toLocaleString: ?locales: U2<string, ResizeArray<string>> * ?options: Intl.DateTimeFormatOptions -> string
    abstract toLocaleDateString: ?locales: U2<string, ResizeArray<string>> * ?options: Intl.DateTimeFormatOptions -> string
    abstract toLocaleTimeString: ?locales: U2<string, ResizeArray<string>> * ?options: Intl.DateTimeFormatOptions -> string
    [<Emit("$0.[Symbol.toPrimitive]('default')")>] abstract ``[Symbol.toPrimitive]_default``: unit -> string
    [<Emit("$0.[Symbol.toPrimitive]('string')")>] abstract ``[Symbol.toPrimitive]_string``: unit -> string
    [<Emit("$0.[Symbol.toPrimitive]('number')")>] abstract ``[Symbol.toPrimitive]_number``: unit -> float
    abstract ``[Symbol.toPrimitive]``: hint: string -> U2<string, float>

type [<AllowNullLiteral>] ReadonlyDateConstructor =
    [<Emit("$0($1...)")>] abstract Invoke: unit -> string
    abstract prototype: DateTime
    abstract parse: s: string -> float
    abstract UTC: year: float * month: float * ?date: float * ?hours: float * ?minutes: float * ?seconds: float * ?ms: float -> float
    abstract now: unit -> float

type [<AllowNullLiteral>] ReadonlyDateConstructorStatic =
    [<EmitConstructor>] abstract Create: unit -> ReadonlyDateConstructor
    [<EmitConstructor>] abstract Create: value: U2<float, string> -> ReadonlyDateConstructor
    [<EmitConstructor>] abstract Create: year: float * month: float * ?date: float * ?hours: float * ?minutes: float * ?seconds: float * ?ms: float -> ReadonlyDateConstructor