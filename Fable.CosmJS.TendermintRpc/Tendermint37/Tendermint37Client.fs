// ts2fable 0.9.0
module rec Fable.CosmJS.TendermintRpc.Tendermint37.Tendermint37Client

#nowarn "3390" // disable warnings for invalid XML comments

open System
open Fable.Core
open Fable.Core.JS

module Requests = Fable.CosmJS.TendermintRpc.Tendermint37.Requests
module Responses = Fable.CosmJS.TendermintRpc.Tendermint37.Responses
type Stream<'T> = Fable.CosmJS.XStream.Stream<'T>
type HttpEndpoint = Fable.CosmJS.TendermintRpc.RpcClients.HttpClient.HttpEndpoint
type RpcClient = Fable.CosmJS.TendermintRpc.RpcClients.RpcClient.RpcClient

type [<AllowNullLiteral>] IExports =
    abstract Tendermint37Client: Tendermint37ClientStatic

type [<AllowNullLiteral>] Tendermint37Client =
    abstract disconnect: unit -> unit
    abstract abciInfo: unit -> Promise<Responses.AbciInfoResponse>
    abstract abciQuery: ``params``: Requests.AbciQueryParams -> Promise<Responses.AbciQueryResponse>
    abstract block: ?height: float -> Promise<Responses.BlockResponse>
    abstract blockResults: ?height: float -> Promise<Responses.BlockResultsResponse>
    /// <summary>
    /// Search for events that are in a block.
    /// 
    /// NOTE
    /// This method will error on any node that is running a Tendermint version lower than 0.34.9.
    /// </summary>
    /// <seealso href="https://docs.tendermint.com/master/rpc/#/Info/block_search" />
    abstract blockSearch: ``params``: Requests.BlockSearchParams -> Promise<Responses.BlockSearchResponse>
    abstract blockSearchAll: ``params``: Requests.BlockSearchParams -> Promise<Responses.BlockSearchResponse>
    /// <summary>Queries block headers filtered by minHeight &lt;= height &lt;= maxHeight.</summary>
    /// <param name="minHeight">The minimum height to be included in the result. Defaults to 0.</param>
    /// <param name="maxHeight">The maximum height to be included in the result. Defaults to infinity.</param>
    abstract blockchain: ?minHeight: float * ?maxHeight: float -> Promise<Responses.BlockchainResponse>
    /// <summary>Broadcast transaction to mempool and wait for response</summary>
    /// <seealso href="https://docs.tendermint.com/master/rpc/#/Tx/broadcast_tx_sync" />
    abstract broadcastTxSync: ``params``: Requests.BroadcastTxParams -> Promise<Responses.BroadcastTxSyncResponse>
    /// <summary>Broadcast transaction to mempool and do not wait for result</summary>
    /// <seealso href="https://docs.tendermint.com/master/rpc/#/Tx/broadcast_tx_async" />
    abstract broadcastTxAsync: ``params``: Requests.BroadcastTxParams -> Promise<Responses.BroadcastTxAsyncResponse>
    /// <summary>Broadcast transaction to mempool and wait for block</summary>
    /// <seealso href="https://docs.tendermint.com/master/rpc/#/Tx/broadcast_tx_commit" />
    abstract broadcastTxCommit: ``params``: Requests.BroadcastTxParams -> Promise<Responses.BroadcastTxCommitResponse>
    abstract commit: ?height: float -> Promise<Responses.CommitResponse>
    abstract genesis: unit -> Promise<Responses.GenesisResponse>
    abstract health: unit -> Promise<Responses.HealthResponse>
    abstract numUnconfirmedTxs: unit -> Promise<Responses.NumUnconfirmedTxsResponse>
    abstract status: unit -> Promise<Responses.StatusResponse>
    abstract subscribeNewBlock: unit -> Stream<Responses.NewBlockEvent>
    abstract subscribeNewBlockHeader: unit -> Stream<Responses.NewBlockHeaderEvent>
    abstract subscribeTx: ?query: string -> Stream<Responses.TxEvent>
    /// <summary>Get a single transaction by hash</summary>
    /// <seealso href="https://docs.tendermint.com/master/rpc/#/Info/tx" />
    abstract tx: ``params``: Requests.TxParams -> Promise<Responses.TxResponse>
    /// <summary>Search for transactions that are in a block</summary>
    /// <seealso href="https://docs.tendermint.com/master/rpc/#/Info/tx_search" />
    abstract txSearch: ``params``: Requests.TxSearchParams -> Promise<Responses.TxSearchResponse>
    abstract txSearchAll: ``params``: Requests.TxSearchParams -> Promise<Responses.TxSearchResponse>
    abstract validators: ``params``: Requests.ValidatorsParams -> Promise<Responses.ValidatorsResponse>
    abstract validatorsAll: ?height: float -> Promise<Responses.ValidatorsResponse>

type [<AllowNullLiteral>] Tendermint37ClientStatic =
    /// Creates a new Tendermint client for the given endpoint.
    /// 
    /// Uses HTTP when the URL schema is http or https. Uses WebSockets otherwise.
    abstract connect: endpoint: U2<string, HttpEndpoint> -> Promise<Tendermint37Client>
    /// Creates a new Tendermint client given an RPC client.
    abstract create: rpcClient: RpcClient -> Promise<Tendermint37Client>