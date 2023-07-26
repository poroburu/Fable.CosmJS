// ts2fable 0.9.0
module rec Fable.CosmJS.ProtoSigning.Coins

open System
open Fable.Core
open Fable.Core.JS


type Coin = Fable.CosmJS.Amino.Coins.Coin

type [<AllowNullLiteral>] IExports =
    /// Takes a coins list like "819966000ucosm,700000000ustake" and parses it.
    /// 
    /// This is a Stargate ready version of parseCoins from @cosmjs/amino.
    /// It supports more denoms.
    abstract parseCoins: input: string -> ResizeArray<Coin>