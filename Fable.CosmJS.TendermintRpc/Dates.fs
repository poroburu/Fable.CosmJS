// ts2fable 0.9.0
module rec Fable.CosmJS.TendermintRpc.Dates

#nowarn "3390" // disable warnings for invalid XML comments
#nowarn "0044" // disable warnings for `Obsolete` usage

open System
open Fable.Core
open Fable.Core.JS
open Fable.CosmJS


type ReadonlyDate = ReadonlyDate.ReadonlyDate

[<AllowNullLiteral>]
type IExports =
    abstract fromRfc3339WithNanoseconds: dateTimeString: string -> DateWithNanoseconds
    abstract toRfc3339WithNanoseconds: dateTime: ReadonlyDateWithNanoseconds -> string
    abstract fromSeconds: seconds: float * ?nanos: float -> DateWithNanoseconds

    /// <summary>
    /// Calculates the UNIX timestamp in seconds as well as the nanoseconds after the given second.
    ///
    /// This is useful when dealing with external systems like the protobuf type
    /// <see href="https://developers.google.com/protocol-buffers/docs/reference/google.protobuf#google.protobuf.Timestamp">.google.protobuf.Timestamp</see>
    /// or any other system that does not use millisecond precision.
    /// </summary>
    abstract toSeconds: date: ReadonlyDateWithNanoseconds -> {| seconds: float; nanos: float |}

    [<Obsolete("Use fromRfc3339WithNanoseconds/toRfc3339WithNanoseconds instead")>]
    abstract DateTime: DateTimeStatic

[<AllowNullLiteral>]
type ReadonlyDateWithNanoseconds =
    inherit ReadonlyDate
    abstract nanoseconds: float option

[<AllowNullLiteral>]
type DateWithNanoseconds =
    inherit DateTime
    /// Nanoseconds after the time stored in a vanilla Date (millisecond granularity)
    abstract nanoseconds: float option with get, set

[<Obsolete("Use fromRfc3339WithNanoseconds/toRfc3339WithNanoseconds instead")>]
[<AllowNullLiteral>]
type DateTime =
    interface
    end

[<Obsolete("Use fromRfc3339WithNanoseconds/toRfc3339WithNanoseconds instead")>]
[<AllowNullLiteral>]
type DateTimeStatic =
    [<EmitConstructor>]
    abstract Create: unit -> DateTime

    [<Obsolete("Use fromRfc3339WithNanoseconds instead")>]
    abstract decode: dateTimeString: string -> ReadonlyDateWithNanoseconds

    [<Obsolete("Use toRfc3339WithNanoseconds instead")>]
    abstract encode: dateTime: ReadonlyDateWithNanoseconds -> string
