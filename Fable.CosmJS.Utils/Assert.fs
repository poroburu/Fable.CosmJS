// ts2fable 0.9.0
module rec Fable.CosmJS.Utils.Assert

open System
open Fable.Core
open Fable.Core.JS


[<AllowNullLiteral>]
type IExports =
    abstract ``assert``: condition: obj option * ?msg: string -> bool
    abstract assertDefined: value: 'T option * ?msg: string -> bool
    abstract assertDefinedAndNotNull: value: 'T option * ?msg: string -> bool
