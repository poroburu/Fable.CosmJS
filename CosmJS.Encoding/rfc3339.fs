// ts2fable 0.9.0
module rec CosmJS.Encoding.rfc3339
open System
open Fable.Core
open Fable.Core.JS

type ReadonlyDate = Readonly_date.ReadonlyDate

type [<AllowNullLiteral>] IExports =
    abstract fromRfc3339: str: string -> DateTime
    abstract toRfc3339: date: U2<DateTime, ReadonlyDate> -> string