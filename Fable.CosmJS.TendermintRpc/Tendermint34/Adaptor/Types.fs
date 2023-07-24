module rec Fable.CosmJS.TendermintRpc.Tendermint34.Adaptor.Types

// ts2fable 0.9.0
open System
open Fable.Core
open Fable.Core.JS

module Requests = Fable.CosmJS.TendermintRpc.Tendermint34.Requests
module Responses = Fable.CosmJS.TendermintRpc.Tendermint34.Responses
type JsonRpcRequest = Fable.CosmJS.JsonRpc.Types.JsonRpcRequest
type JsonRpcSuccessResponse = Fable.CosmJS.JsonRpc.Types.JsonRpcSuccessResponse
type SubscriptionEvent = Fable.CosmJS.TendermintRpc.RpcClients.RpcClient.SubscriptionEvent

type [<AllowNullLiteral>] Adaptor =
    abstract ``params``: Params
    abstract responses: Responses
    abstract hashTx: Uint8Array -> Uint8Array
    abstract hashBlock: Responses.Header -> Uint8Array

type [<AllowNullLiteral>] Encoder<'T when 'T :> Requests.Request> =
    [<Emit("$0($1...)")>] abstract Invoke: req: 'T -> JsonRpcRequest

type [<AllowNullLiteral>] Decoder<'T when 'T :> Responses.Response> =
    [<Emit("$0($1...)")>] abstract Invoke: res: JsonRpcSuccessResponse -> 'T

type [<AllowNullLiteral>] Params =
    abstract encodeAbciInfo: Requests.AbciInfoRequest -> JsonRpcRequest
    abstract encodeAbciQuery: Requests.AbciQueryRequest -> JsonRpcRequest
    abstract encodeBlock: Requests.BlockRequest -> JsonRpcRequest
    abstract encodeBlockchain: Requests.BlockchainRequest -> JsonRpcRequest
    abstract encodeBlockResults: Requests.BlockResultsRequest -> JsonRpcRequest
    abstract encodeBlockSearch: Requests.BlockSearchRequest -> JsonRpcRequest
    abstract encodeBroadcastTx: Requests.BroadcastTxRequest -> JsonRpcRequest
    abstract encodeCommit: Requests.CommitRequest -> JsonRpcRequest
    abstract encodeGenesis: Requests.GenesisRequest -> JsonRpcRequest
    abstract encodeHealth: Requests.HealthRequest -> JsonRpcRequest
    abstract encodeNumUnconfirmedTxs: Requests.NumUnconfirmedTxsRequest -> JsonRpcRequest
    abstract encodeStatus: Requests.StatusRequest -> JsonRpcRequest
    abstract encodeSubscribe: Requests.SubscribeRequest -> JsonRpcRequest
    abstract encodeTx: Requests.TxRequest -> JsonRpcRequest
    abstract encodeTxSearch: Requests.TxSearchRequest -> JsonRpcRequest
    abstract encodeValidators: Requests.ValidatorsRequest -> JsonRpcRequest

type [<AllowNullLiteral>] Responses =
    abstract decodeAbciInfo: JsonRpcSuccessResponse -> Responses.AbciInfoResponse
    abstract decodeAbciQuery: JsonRpcSuccessResponse -> Responses.AbciQueryResponse
    abstract decodeBlock: JsonRpcSuccessResponse -> Responses.BlockResponse
    abstract decodeBlockResults: JsonRpcSuccessResponse -> Responses.BlockResultsResponse
    abstract decodeBlockSearch: JsonRpcSuccessResponse -> Responses.BlockSearchResponse
    abstract decodeBlockchain: JsonRpcSuccessResponse -> Responses.BlockchainResponse
    abstract decodeBroadcastTxSync: JsonRpcSuccessResponse -> Responses.BroadcastTxSyncResponse
    abstract decodeBroadcastTxAsync: JsonRpcSuccessResponse -> Responses.BroadcastTxAsyncResponse
    abstract decodeBroadcastTxCommit: JsonRpcSuccessResponse -> Responses.BroadcastTxCommitResponse
    abstract decodeCommit: JsonRpcSuccessResponse -> Responses.CommitResponse
    abstract decodeGenesis: JsonRpcSuccessResponse -> Responses.GenesisResponse
    abstract decodeHealth: JsonRpcSuccessResponse -> Responses.HealthResponse
    abstract decodeNumUnconfirmedTxs: JsonRpcSuccessResponse -> Responses.NumUnconfirmedTxsResponse
    abstract decodeStatus: JsonRpcSuccessResponse -> Responses.StatusResponse
    abstract decodeTx: JsonRpcSuccessResponse -> Responses.TxResponse
    abstract decodeTxSearch: JsonRpcSuccessResponse -> Responses.TxSearchResponse
    abstract decodeValidators: JsonRpcSuccessResponse -> Responses.ValidatorsResponse
    abstract decodeNewBlockEvent: SubscriptionEvent -> Responses.NewBlockEvent
    abstract decodeNewBlockHeaderEvent: SubscriptionEvent -> Responses.NewBlockHeaderEvent
    abstract decodeTxEvent: SubscriptionEvent -> Responses.TxEvent