// ts2fable 0.9.0
module rec Fable.CosmJS.TendermintRpc.Types

open System
open Fable.Core
open Fable.Core.JS

type ReadonlyDateWithNanoseconds = Dates.ReadonlyDateWithNanoseconds

type [<AllowNullLiteral>] ValidatorEd25519Pubkey =
    abstract algorithm: string
    abstract data: Uint8Array

type [<AllowNullLiteral>] ValidatorSecp256k1Pubkey =
    abstract algorithm: string
    abstract data: Uint8Array

/// Union type for different possible pubkeys.
type ValidatorPubkey =
    U2<ValidatorEd25519Pubkey, ValidatorSecp256k1Pubkey>

type [<RequireQualifiedAccess>] BlockIdFlag =
    | Unknown = 0
    | Absent = 1
    | Commit = 2
    | Nil = 3
    | Unrecognized = -1

type [<AllowNullLiteral>] CommitSignature =
    /// If this is BlockIdFlag.Absent, all other fields are expected to be unset
    abstract blockIdFlag: BlockIdFlag with get, set
    abstract validatorAddress: Uint8Array option with get, set
    abstract timestamp: ReadonlyDateWithNanoseconds option with get, set
    abstract signature: Uint8Array option with get, set