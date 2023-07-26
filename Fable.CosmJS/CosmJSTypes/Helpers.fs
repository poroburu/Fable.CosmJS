// ts2fable 0.9.0
module rec Fable.CosmJS.CosmJSTypes.Helpers

#nowarn "3390" // disable warnings for invalid XML comments

open System
open Fable.Core
open Fable.Core.JS

type Function = System.Action
type Long = Fable.CosmJS._types.long.Long.Long

let [<Import("setPaginationParams","module")>] setPaginationParams: (Params -> (PageRequest) option -> Params) = jsNative

type [<AllowNullLiteral>] IExports =
    abstract bytesFromBase64: b64: string -> Uint8Array
    abstract base64FromBytes: arr: Uint8Array -> string
    abstract omitDefault: input: 'T -> 'T option
    abstract toDuration: duration: string -> Duration
    abstract fromDuration: duration: Duration -> string
    abstract isSet: value: obj option -> bool
    abstract isObject: value: obj option -> bool
    abstract toTimestamp: date: DateTime -> Timestamp
    abstract fromTimestamp: t: Timestamp -> DateTime
    abstract fromJsonTimestamp: o: obj option -> Timestamp

type [<AllowNullLiteral>] AminoHeight =
    abstract revision_number: string option
    abstract revision_height: string option

type [<AllowNullLiteral>] Duration =
    /// Signed seconds of the span of time. Must be from -315,576,000,000
    /// to +315,576,000,000 inclusive. Note: these bounds are computed from:
    /// 60 sec/min * 60 min/hr * 24 hr/day * 365.25 days/year * 10000 years
    abstract seconds: Long with get, set
    /// <summary>
    /// Signed fractions of a second at nanosecond resolution of the span
    /// of time. Durations less than one second are represented with a 0
    /// <c>seconds</c> field and a positive or negative <c>nanos</c> field. For durations
    /// of one second or more, a non-zero value for the <c>nanos</c> field must be
    /// of the same sign as the <c>seconds</c> field. Must be from -999,999,999
    /// to +999,999,999 inclusive.
    /// </summary>
    abstract nanos: float with get, set

type [<AllowNullLiteral>] PageRequest =
    abstract key: Uint8Array with get, set
    abstract offset: Long with get, set
    abstract limit: Long with get, set
    abstract countTotal: bool with get, set
    abstract reverse: bool with get, set

type [<AllowNullLiteral>] PageRequestParams =
    abstract ``pagination.key``: string option with get, set
    abstract ``pagination.offset``: string option with get, set
    abstract ``pagination.limit``: string option with get, set
    abstract ``pagination.count_total``: bool option with get, set
    abstract ``pagination.reverse``: bool option with get, set

type [<AllowNullLiteral>] Params =
    abstract ``params``: PageRequestParams with get, set

type Builtin =
    U6<DateTime, Function, Uint8Array, string, float, bool> option

type DeepPartial<'T> =
    obj

type KeysOfUnion<'T> =
    obj

type Exact<'P, 'I when 'I :> 'P> =
    obj

type [<AllowNullLiteral>] Rpc =
    abstract request: service: string * method: string * data: Uint8Array -> Promise<Uint8Array>

type [<AllowNullLiteral>] Timestamp =
    /// Represents seconds of UTC time since Unix epoch
    /// 1970-01-01T00:00:00Z. Must be from 0001-01-01T00:00:00Z to
    /// 9999-12-31T23:59:59Z inclusive.
    abstract seconds: Long with get, set
    /// Non-negative fractions of a second at nanosecond resolution. Negative
    /// second values with fractions must still have non-negative nanos values
    /// that count forward in time. Must be from 0 to 999,999,999
    /// inclusive.
    abstract nanos: float with get, set