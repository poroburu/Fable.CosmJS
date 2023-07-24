module rec Fable.CosmJS.TendermintRpc.Tendermint34.Adaptor.Requests

// ts2fable 0.9.0
open System
open Fable.Core
open Fable.Core.JS

module Requests = Fable.CosmJS.TendermintRpc.Tendermint34.Requests
type JsonRpcRequest = Fable.CosmJS.JsonRpc.Types.JsonRpcRequest

type [<AllowNullLiteral>] IExports =
    abstract Params: ParamsStatic

type [<AllowNullLiteral>] Params =
    interface end

type [<AllowNullLiteral>] ParamsStatic =
    [<EmitConstructor>] abstract Create: unit -> Params
    abstract encodeAbciInfo: req: Requests.AbciInfoRequest -> JsonRpcRequest
    abstract encodeAbciQuery: req: Requests.AbciQueryRequest -> JsonRpcRequest
    abstract encodeBlock: req: Requests.BlockRequest -> JsonRpcRequest
    abstract encodeBlockchain: req: Requests.BlockchainRequest -> JsonRpcRequest
    abstract encodeBlockResults: req: Requests.BlockResultsRequest -> JsonRpcRequest
    abstract encodeBlockSearch: req: Requests.BlockSearchRequest -> JsonRpcRequest
    abstract encodeBroadcastTx: req: Requests.BroadcastTxRequest -> JsonRpcRequest
    abstract encodeCommit: req: Requests.CommitRequest -> JsonRpcRequest
    abstract encodeGenesis: req: Requests.GenesisRequest -> JsonRpcRequest
    abstract encodeHealth: req: Requests.HealthRequest -> JsonRpcRequest
    abstract encodeNumUnconfirmedTxs: req: Requests.NumUnconfirmedTxsRequest -> JsonRpcRequest
    abstract encodeStatus: req: Requests.StatusRequest -> JsonRpcRequest
    abstract encodeSubscribe: req: Requests.SubscribeRequest -> JsonRpcRequest
    abstract encodeTx: req: Requests.TxRequest -> JsonRpcRequest
    abstract encodeTxSearch: req: Requests.TxSearchRequest -> JsonRpcRequest
    abstract encodeValidators: req: Requests.ValidatorsRequest -> JsonRpcRequest