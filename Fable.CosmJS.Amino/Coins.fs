// ts2fable 0.9.0
module rec Fable.CosmJS.Amino.Coins

#nowarn "3390" // disable warnings for invalid XML comments

open System
open Fable.Core
open Fable.Core.JS


type [<AllowNullLiteral>] IExports =
    /// Creates a coin.
    /// 
    /// If your values do not exceed the safe integer range of JS numbers (53 bit),
    /// you can use the number type here. This is the case for all typical Cosmos SDK
    /// chains that use the default 6 decimals.
    /// 
    /// In case you need to supportr larger values, use unsigned integer strings instead.
    abstract coin: amount: U2<float, string> * denom: string -> Coin
    /// Creates a list of coins with one element.
    abstract coins: amount: U2<float, string> * denom: string -> ResizeArray<Coin>
    /// <summary>
    /// Takes a coins list like "819966000ucosm,700000000ustake" and parses it.
    /// 
    /// A Stargate-ready variant of this function is available via:
    /// 
    /// <code>
    /// import { parseCoins } from "@cosmjs/proto-signing";
    /// // or
    /// import { parseCoins } from "@cosmjs/stargate";
    /// </code>
    /// </summary>
    abstract parseCoins: input: string -> ResizeArray<Coin>
    /// Function to sum up coins with type Coin
    abstract addCoins: lhs: Coin * rhs: Coin -> Coin

type [<AllowNullLiteral>] Coin =
    abstract denom: string
    abstract amount: string