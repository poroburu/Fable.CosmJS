module rec Fable.CosmJS.TendermintRpc.Tendermint34.Responses
// ts2fable 0.9.0

#nowarn "3390" // disable warnings for invalid XML comments

open System
open Fable.Core
open Fable.Core.JS

type ReadonlyDate = Fable.CosmJS.ReadonlyDate.ReadonlyDate
type ReadonlyDateWithNanoseconds = Fable.CosmJS.TendermintRpc.Dates.ReadonlyDateWithNanoseconds
type CommitSignature = Fable.CosmJS.TendermintRpc.Types.CommitSignature
type ValidatorPubkey = Fable.CosmJS.TendermintRpc.Types.ValidatorPubkey
type Record<'K,'V> = Fable.CosmJS.Record.Record<'K,'V>


type [<AllowNullLiteral>] IExports =
    /// Returns true iff transaction made it successfully into the transaction pool
    abstract broadcastTxSyncSuccess: res: BroadcastTxSyncResponse -> bool
    /// <summary>
    /// Returns true iff transaction made it successfully into a block
    /// (i.e. success in <c>check_tx</c> and <c>deliver_tx</c> field)
    /// </summary>
    abstract broadcastTxCommitSuccess: response: BroadcastTxCommitResponse -> bool

type Response =
    obj

type [<AllowNullLiteral>] AbciInfoResponse =
    abstract data: string option
    abstract lastBlockHeight: float option
    abstract lastBlockAppHash: Uint8Array option

type [<AllowNullLiteral>] ProofOp =
    abstract ``type``: string
    abstract key: Uint8Array
    abstract data: Uint8Array

type [<AllowNullLiteral>] QueryProof =
    abstract ops: ResizeArray<ProofOp>

type [<AllowNullLiteral>] AbciQueryResponse =
    abstract key: Uint8Array
    abstract value: Uint8Array
    abstract proof: QueryProof option
    abstract height: float option
    abstract index: float option
    abstract code: float option
    abstract codespace: string
    abstract log: string option
    abstract info: string

type [<AllowNullLiteral>] BlockResponse =
    abstract blockId: BlockId
    abstract block: Block

type [<AllowNullLiteral>] BlockResultsResponse =
    abstract height: float
    abstract results: ResizeArray<TxData>
    abstract validatorUpdates: ResizeArray<ValidatorUpdate>
    abstract consensusUpdates: ConsensusParams option
    abstract beginBlockEvents: ResizeArray<Event>
    abstract endBlockEvents: ResizeArray<Event>

type [<AllowNullLiteral>] BlockSearchResponse =
    abstract blocks: ResizeArray<BlockResponse>
    abstract totalCount: float

type [<AllowNullLiteral>] BlockchainResponse =
    abstract lastHeight: float
    abstract blockMetas: ResizeArray<BlockMeta>

/// No transaction data in here because RPC method BroadcastTxAsync "returns right away, with no response"
type [<AllowNullLiteral>] BroadcastTxAsyncResponse =
    abstract hash: Uint8Array

type [<AllowNullLiteral>] BroadcastTxSyncResponse =
    inherit TxData
    abstract hash: Uint8Array

type [<AllowNullLiteral>] BroadcastTxCommitResponse =
    abstract height: float
    abstract hash: Uint8Array
    abstract checkTx: TxData
    abstract deliverTx: TxData option

type [<AllowNullLiteral>] CommitResponse =
    abstract header: Header
    abstract commit: Commit
    abstract canonical: bool

type [<AllowNullLiteral>] GenesisResponse =
    abstract genesisTime: ReadonlyDate
    abstract chainId: string
    abstract consensusParams: ConsensusParams
    abstract validators: ResizeArray<Validator>
    abstract appHash: Uint8Array
    abstract appState: Record<string, obj> option

type HealthResponse =
    obj

type [<AllowNullLiteral>] NumUnconfirmedTxsResponse =
    abstract total: float
    abstract totalBytes: float

type [<AllowNullLiteral>] StatusResponse =
    abstract nodeInfo: NodeInfo
    abstract syncInfo: SyncInfo
    abstract validatorInfo: Validator

/// A transaction from RPC calls like search.
/// 
/// Try to keep this compatible to TxEvent
type [<AllowNullLiteral>] TxResponse =
    abstract tx: Uint8Array
    abstract hash: Uint8Array
    abstract height: float
    abstract index: float
    abstract result: TxData
    abstract proof: TxProof option

type [<AllowNullLiteral>] TxSearchResponse =
    abstract txs: ResizeArray<TxResponse>
    abstract totalCount: float

type [<AllowNullLiteral>] ValidatorsResponse =
    abstract blockHeight: float
    abstract validators: ResizeArray<Validator>
    abstract count: float
    abstract total: float

type [<AllowNullLiteral>] NewBlockEvent =
    inherit Block

type [<AllowNullLiteral>] NewBlockHeaderEvent =
    inherit Header

type [<AllowNullLiteral>] TxEvent =
    abstract tx: Uint8Array
    abstract hash: Uint8Array
    abstract height: float
    abstract result: TxData

/// An event attribute
type [<AllowNullLiteral>] Attribute =
    abstract key: Uint8Array
    abstract value: Uint8Array

type [<AllowNullLiteral>] Event =
    abstract ``type``: string
    abstract attributes: ResizeArray<Attribute>

type [<AllowNullLiteral>] TxData =
    abstract code: float
    abstract codespace: string option
    abstract log: string option
    abstract data: Uint8Array option
    abstract events: ResizeArray<Event>
    abstract gasWanted: float
    abstract gasUsed: float

type [<AllowNullLiteral>] TxProof =
    abstract data: Uint8Array
    abstract rootHash: Uint8Array
    abstract proof: {| total: float; index: float; leafHash: Uint8Array; aunts: ResizeArray<Uint8Array> |}

type [<AllowNullLiteral>] BlockMeta =
    abstract blockId: BlockId
    abstract blockSize: float
    abstract header: Header
    abstract numTxs: float

type [<AllowNullLiteral>] BlockId =
    abstract hash: Uint8Array
    abstract parts: {| total: float; hash: Uint8Array |}

type [<AllowNullLiteral>] Block =
    abstract header: Header
    /// For the block at height 1, last commit is not set.
    abstract lastCommit: Commit option
    abstract txs: ResizeArray<Uint8Array>
    abstract evidence: ResizeArray<Evidence>

/// <summary>
/// We lost track on how the evidence structure actually looks like.
/// This is any now and passed to the caller untouched.
/// 
/// See also <see href="https://github.com/cosmos/cosmjs/issues/980." />
/// </summary>
type Evidence =
    obj option

type [<AllowNullLiteral>] Commit =
    abstract blockId: BlockId
    abstract height: float
    abstract round: float
    abstract signatures: ResizeArray<CommitSignature>

/// <summary>raw values from <see href="https://github.com/tendermint/tendermint/blob/dfa9a9a30a666132425b29454e90a472aa579a48/types/vote.go#L44" /></summary>
type [<RequireQualifiedAccess>] VoteType =
    | PreVote = 1
    | PreCommit = 2

type [<AllowNullLiteral>] Vote =
    abstract ``type``: VoteType
    abstract validatorAddress: Uint8Array
    abstract validatorIndex: float
    abstract height: float
    abstract round: float
    abstract timestamp: ReadonlyDate
    abstract blockId: BlockId
    abstract signature: Uint8Array

type [<AllowNullLiteral>] Version =
    abstract block: float
    abstract app: float

type [<AllowNullLiteral>] Header =
    abstract version: Version
    abstract chainId: string
    abstract height: float
    abstract time: ReadonlyDateWithNanoseconds
    /// <summary>Block ID of the previous block. This can be <c>null</c> when the currect block is height 1.</summary>
    abstract lastBlockId: BlockId option
    /// <summary>
    /// Hashes of block data.
    /// 
    /// This is <c>sha256("")</c> for height 1 🤷‍
    /// </summary>
    abstract lastCommitHash: Uint8Array
    /// <summary>This is <c>sha256("")</c> as long as there is no data 🤷‍</summary>
    abstract dataHash: Uint8Array
    abstract validatorsHash: Uint8Array
    abstract nextValidatorsHash: Uint8Array
    abstract consensusHash: Uint8Array
    /// This can be an empty string for height 1 and turn into "0000000000000000" later on 🤷‍
    abstract appHash: Uint8Array
    /// <summary>This is <c>sha256("")</c> as long as there is no data 🤷‍</summary>
    abstract lastResultsHash: Uint8Array
    /// <summary>This is <c>sha256("")</c> as long as there is no data 🤷‍</summary>
    abstract evidenceHash: Uint8Array
    abstract proposerAddress: Uint8Array

type [<AllowNullLiteral>] NodeInfo =
    abstract id: Uint8Array
    /// IP and port
    abstract listenAddr: string
    abstract network: string
    /// <summary>The Tendermint version. Can be empty (see <see href="https://github.com/cosmos/cosmos-sdk/issues/7963)." /></summary>
    abstract version: string
    abstract channels: string
    abstract moniker: string
    abstract other: Map<string, string>
    abstract protocolVersion: {| p2p: float; block: float; app: float |}

type [<AllowNullLiteral>] SyncInfo =
    abstract latestBlockHash: Uint8Array
    abstract latestAppHash: Uint8Array
    abstract latestBlockHeight: float
    abstract latestBlockTime: ReadonlyDate
    abstract catchingUp: bool

type [<AllowNullLiteral>] Validator =
    abstract address: Uint8Array
    abstract pubkey: ValidatorPubkey option
    abstract votingPower: obj
    abstract proposerPriority: float option

type [<AllowNullLiteral>] ValidatorUpdate =
    abstract pubkey: ValidatorPubkey
    abstract votingPower: obj

type [<AllowNullLiteral>] ConsensusParams =
    abstract block: BlockParams
    abstract evidence: EvidenceParams

type [<AllowNullLiteral>] BlockParams =
    abstract maxBytes: float
    abstract maxGas: float

type [<AllowNullLiteral>] TxSizeParams =
    abstract maxBytes: float
    abstract maxGas: float

type [<AllowNullLiteral>] BlockGossipParams =
    abstract blockPartSizeBytes: float

type [<AllowNullLiteral>] EvidenceParams =
    abstract maxAgeNumBlocks: float
    abstract maxAgeDuration: float