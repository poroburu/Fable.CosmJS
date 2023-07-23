// ts2fable 0.9.0
module rec Fable.CosmJS.Utils.Sleep

open System
open Fable.Core
open Fable.Core.JS

[<AllowNullLiteral>]
type IExports =
    abstract sleep: ms: float -> Promise<unit>
