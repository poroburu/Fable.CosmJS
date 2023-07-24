// ts2fable 0.9.0
module rec Fable.CosmJS.TendermintRpc.Tendermint37.Requests

#nowarn "3390" // disable warnings for invalid XML comments

open System
open Fable.Core
open Fable.Core.JS


type [<AllowNullLiteral>] IExports =
    abstract buildQuery: components: BuildQueryComponents -> string

/// <summary>
/// RPC methods as documented in <see href="https://docs.tendermint.com/master/rpc/" />
/// 
/// Enum raw value must match the spelling in the "shell" example call (snake_case)
/// </summary>
type [<StringEnum>] [<RequireQualifiedAccess>] Method =
    | [<CompiledName("abci_info")>] AbciInfo
    | [<CompiledName("abci_query")>] AbciQuery
    | Block
    /// Get block headers for minHeight <= height <= maxHeight.
    | Blockchain
    | [<CompiledName("block_results")>] BlockResults
    | [<CompiledName("block_search")>] BlockSearch
    | [<CompiledName("broadcast_tx_async")>] BroadcastTxAsync
    | [<CompiledName("broadcast_tx_sync")>] BroadcastTxSync
    | [<CompiledName("broadcast_tx_commit")>] BroadcastTxCommit
    | Commit
    | Genesis
    | Health
    | [<CompiledName("num_unconfirmed_txs")>] NumUnconfirmedTxs
    | Status
    | Subscribe
    | Tx
    | [<CompiledName("tx_search")>] TxSearch
    | Validators
    | Unsubscribe

type Request =
    obj

/// <summary>Raw values must match the tendermint event name</summary>
/// <seealso href="https://godoc.org/github.com/tendermint/tendermint/types#pkg-constants" />
type [<StringEnum>] [<RequireQualifiedAccess>] SubscriptionEventType =
    | [<CompiledName("NewBlock")>] NewBlock
    | [<CompiledName("NewBlockHeader")>] NewBlockHeader
    | [<CompiledName("Tx")>] Tx

type [<AllowNullLiteral>] AbciInfoRequest =
    abstract method: Method

type [<AllowNullLiteral>] AbciQueryRequest =
    abstract method: Method
    abstract ``params``: AbciQueryParams

type [<AllowNullLiteral>] AbciQueryParams =
    abstract path: string
    abstract data: Uint8Array
    abstract height: float option
    /// <summary>
    /// A flag that defines if proofs are included in the response or not.
    /// 
    /// Internally this is mapped to the old inverse name <c>trusted</c> for Tendermint &lt; 0.26.
    /// Starting with Tendermint 0.26, the default value changed from true to false.
    /// </summary>
    abstract prove: bool option

type [<AllowNullLiteral>] BlockRequest =
    abstract method: Method
    abstract ``params``: {| height: float option |}

type [<AllowNullLiteral>] BlockchainRequest =
    abstract method: Method
    abstract ``params``: BlockchainRequestParams

type [<AllowNullLiteral>] BlockchainRequestParams =
    abstract minHeight: float option
    abstract maxHeight: float option

type [<AllowNullLiteral>] BlockResultsRequest =
    abstract method: Method
    abstract ``params``: {| height: float option |}

type [<AllowNullLiteral>] BlockSearchRequest =
    abstract method: Method
    abstract ``params``: BlockSearchParams

type [<AllowNullLiteral>] BlockSearchParams =
    abstract query: string
    abstract page: float option
    abstract per_page: float option
    abstract order_by: string option

type [<AllowNullLiteral>] BroadcastTxRequest =
    abstract method: Method
    abstract ``params``: BroadcastTxParams

type [<AllowNullLiteral>] BroadcastTxParams =
    abstract tx: Uint8Array

type [<AllowNullLiteral>] CommitRequest =
    abstract method: Method
    abstract ``params``: {| height: float option |}

type [<AllowNullLiteral>] GenesisRequest =
    abstract method: Method

type [<AllowNullLiteral>] HealthRequest =
    abstract method: Method

type [<AllowNullLiteral>] NumUnconfirmedTxsRequest =
    abstract method: Method

type [<AllowNullLiteral>] StatusRequest =
    abstract method: Method

type [<AllowNullLiteral>] SubscribeRequest =
    abstract method: Method
    abstract query: {| ``type``: SubscriptionEventType; raw: string option |}

type [<AllowNullLiteral>] QueryTag =
    abstract key: string
    abstract value: string

type [<AllowNullLiteral>] TxRequest =
    abstract method: Method
    abstract ``params``: TxParams

type [<AllowNullLiteral>] TxParams =
    abstract hash: Uint8Array
    abstract prove: bool option

type [<AllowNullLiteral>] TxSearchRequest =
    abstract method: Method
    abstract ``params``: TxSearchParams

type [<AllowNullLiteral>] TxSearchParams =
    abstract query: string
    abstract prove: bool option
    abstract page: float option
    abstract per_page: float option
    abstract order_by: string option

type [<AllowNullLiteral>] ValidatorsRequest =
    abstract method: Method
    abstract ``params``: ValidatorsParams

type [<AllowNullLiteral>] ValidatorsParams =
    abstract height: float option
    abstract page: float option
    abstract per_page: float option

type [<AllowNullLiteral>] BuildQueryComponents =
    abstract tags: ResizeArray<QueryTag> option
    abstract raw: string option