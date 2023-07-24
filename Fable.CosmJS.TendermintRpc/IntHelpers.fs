// ts2fable 0.9.0
module rec Fable.CosmJS.TendermintRpc.IntHelpers

open System
open Fable.Core
open Fable.Core.JS


[<AllowNullLiteral>]
type IExports =
    /// Takes an integer value from the Tendermint RPC API and
    /// returns it as number.
    ///
    /// Only works within the safe integer range.
    abstract apiToSmallInt: input: U2<string, float> -> float

    /// Takes an integer value from the Tendermint RPC API and
    /// returns it as BigInt.
    ///
    /// This supports the full uint64 and int64 ranges.
    abstract apiToBigInt: input: string -> obj

    /// Takes an integer in the safe integer range and returns
    /// a string representation to be used in the Tendermint RPC API.
    abstract smallIntToApi: num: float -> string
