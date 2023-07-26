// ts2fable 0.9.0
module rec Fable.CosmJS.ProtoSigning.Signer

open System
open Fable.Core
open Fable.Core.JS

type OfflineAminoSigner = Fable.CosmJS.Amino.Signer.OfflineAminoSigner
type StdSignature = Fable.CosmJS.Amino.Signature.StdSignature
type SignDoc = Cosmjs_types_cosmos_tx_v1beta1_tx.SignDoc

type [<AllowNullLiteral>] IExports =
    abstract isOfflineDirectSigner: signer: OfflineSigner -> bool

type [<StringEnum>] [<RequireQualifiedAccess>] Algo =
    | Secp256k1
    | Ed25519
    | Sr25519

type [<AllowNullLiteral>] AccountData =
    /// A printable address (typically bech32 encoded)
    abstract address: string
    abstract algo: Algo
    abstract pubkey: Uint8Array

type [<AllowNullLiteral>] DirectSignResponse =
    /// The sign doc that was signed.
    /// This may be different from the input signDoc when the signer modifies it as part of the signing process.
    abstract signed: SignDoc
    abstract signature: StdSignature

type [<AllowNullLiteral>] OfflineDirectSigner =
    abstract getAccounts: unit -> Promise<ResizeArray<AccountData>>
    abstract signDirect: string -> SignDoc -> Promise<DirectSignResponse>

type OfflineSigner =
    U2<OfflineAminoSigner, OfflineDirectSigner>