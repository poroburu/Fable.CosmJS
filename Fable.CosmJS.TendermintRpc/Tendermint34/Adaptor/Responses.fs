// ts2fable 0.9.0
module rec Fable.CosmJS.TendermintRpc.Tendermint34.Adaptor.Responses

#nowarn "3390" // disable warnings for invalid XML comments

open System
open Fable.Core
open Fable.Core.JS

module Responses = Fable.CosmJS.TendermintRpc.Tendermint34.Responses
type JsonRpcSuccessResponse = Fable.CosmJS.JsonRpc.Types.JsonRpcSuccessResponse
type SubscriptionEvent = Fable.CosmJS.TendermintRpc.RpcClients.RpcClient.SubscriptionEvent

type [<AllowNullLiteral>] IExports =
    abstract decodeEvent: ``event``: RpcEvent -> Responses.Event
    abstract decodeValidatorUpdate: data: RpcValidatorUpdate -> Responses.ValidatorUpdate
    abstract decodeValidatorGenesis: data: RpcValidatorGenesis -> Responses.Validator
    abstract decodeValidatorInfo: data: RpcValidatorInfo -> Responses.Validator
    abstract Responses: ResponsesStatic

type [<AllowNullLiteral>] RpcProofOp =
    abstract ``type``: string
    /// base64 encoded
    abstract key: string
    /// base64 encoded
    abstract data: string

type [<AllowNullLiteral>] RpcQueryProof =
    abstract ops: ResizeArray<RpcProofOp>

type [<AllowNullLiteral>] RpcAttribute =
    /// base64 encoded
    abstract key: string
    /// base64 encoded
    abstract value: string option

type [<AllowNullLiteral>] RpcEvent =
    abstract ``type``: string
    /// <summary>Can be omitted (see <see href="https://github.com/cosmos/cosmjs/pull/1198)" /></summary>
    abstract attributes: ResizeArray<RpcAttribute> option

type RpcPubkey =
    U2<{| ``type``: string; value: string |}, {| Sum: {| ``type``: string; value: RpcPubkeySumValue |} |}>

type [<AllowNullLiteral>] RpcValidatorUpdate =
    abstract pub_key: RpcPubkey
    abstract power: string option

type [<AllowNullLiteral>] RpcValidatorGenesis =
    /// hex-encoded
    abstract address: string
    abstract pub_key: RpcPubkey
    abstract power: string
    abstract name: string option

type [<AllowNullLiteral>] RpcValidatorInfo =
    /// hex encoded
    abstract address: string
    abstract pub_key: RpcPubkey
    abstract voting_power: string
    abstract proposer_priority: string option

type [<AllowNullLiteral>] Responses =
    interface end

type [<AllowNullLiteral>] ResponsesStatic =
    [<EmitConstructor>] abstract Create: unit -> Responses
    abstract decodeAbciInfo: response: JsonRpcSuccessResponse -> Responses.AbciInfoResponse
    abstract decodeAbciQuery: response: JsonRpcSuccessResponse -> Responses.AbciQueryResponse
    abstract decodeBlock: response: JsonRpcSuccessResponse -> Responses.BlockResponse
    abstract decodeBlockResults: response: JsonRpcSuccessResponse -> Responses.BlockResultsResponse
    abstract decodeBlockSearch: response: JsonRpcSuccessResponse -> Responses.BlockSearchResponse
    abstract decodeBlockchain: response: JsonRpcSuccessResponse -> Responses.BlockchainResponse
    abstract decodeBroadcastTxSync: response: JsonRpcSuccessResponse -> Responses.BroadcastTxSyncResponse
    abstract decodeBroadcastTxAsync: response: JsonRpcSuccessResponse -> Responses.BroadcastTxAsyncResponse
    abstract decodeBroadcastTxCommit: response: JsonRpcSuccessResponse -> Responses.BroadcastTxCommitResponse
    abstract decodeCommit: response: JsonRpcSuccessResponse -> Responses.CommitResponse
    abstract decodeGenesis: response: JsonRpcSuccessResponse -> Responses.GenesisResponse
    abstract decodeHealth: unit -> Responses.HealthResponse
    abstract decodeNumUnconfirmedTxs: response: JsonRpcSuccessResponse -> Responses.NumUnconfirmedTxsResponse
    abstract decodeStatus: response: JsonRpcSuccessResponse -> Responses.StatusResponse
    abstract decodeNewBlockEvent: ``event``: SubscriptionEvent -> Responses.NewBlockEvent
    abstract decodeNewBlockHeaderEvent: ``event``: SubscriptionEvent -> Responses.NewBlockHeaderEvent
    abstract decodeTxEvent: ``event``: SubscriptionEvent -> Responses.TxEvent
    abstract decodeTx: response: JsonRpcSuccessResponse -> Responses.TxResponse
    abstract decodeTxSearch: response: JsonRpcSuccessResponse -> Responses.TxSearchResponse
    abstract decodeValidators: response: JsonRpcSuccessResponse -> Responses.ValidatorsResponse

type [<AllowNullLiteral>] RpcPubkeySumValue =
    /// base64 encoded
    [<EmitIndexer>] abstract Item: algorithm: string -> string with get, set