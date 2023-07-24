// ts2fable 0.9.0
module rec Fable.CosmJS.TendermintRpc.TendermintClient

open System
open Fable.Core
open Fable.Core.JS

type Tendermint34Client = Fable.CosmJS.TendermintRpc.Tendermint34.Tendermint34Client.Tendermint34Client
type Tendermint37Client = Fable.CosmJS.TendermintRpc.Tendermint37.Tendermint37Client.Tendermint37Client

[<AllowNullLiteral>]
type IExports =
    abstract isTendermint34Client: client: TendermintClient -> bool
    abstract isTendermint37Client: client: TendermintClient -> bool

/// A TendermintClient is either a Tendermint34Client or a Tendermint37Client
type TendermintClient = U2<Tendermint34Client, Tendermint37Client>
