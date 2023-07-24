// ts2fable 0.9.0
module rec Fable.CosmJS.Amino.Signer

#nowarn "3390" // disable warnings for invalid XML comments

open System
open Fable.Core
open Fable.Core.JS

type StdSignature = Fable.CosmJS.Amino.Signature.StdSignature
type StdSignDoc = Fable.CosmJS.Amino.SignDoc.StdSignDoc

type [<StringEnum>] [<RequireQualifiedAccess>] Algo =
    | Secp256k1
    | Ed25519
    | Sr25519

type [<AllowNullLiteral>] AccountData =
    /// A printable address (typically bech32 encoded)
    abstract address: string
    abstract algo: Algo
    abstract pubkey: Uint8Array

type [<AllowNullLiteral>] AminoSignResponse =
    /// The sign doc that was signed.
    /// This may be different from the input signDoc when the signer modifies it as part of the signing process.
    abstract signed: StdSignDoc
    abstract signature: StdSignature

type [<AllowNullLiteral>] OfflineAminoSigner =
    /// Get AccountData array from wallet. Rejects if not enabled.
    abstract getAccounts: unit -> Promise<ResizeArray<AccountData>>
    /// <summary>
    /// Request signature from whichever key corresponds to provided bech32-encoded address. Rejects if not enabled.
    /// 
    /// The signer implementation may offer the user the ability to override parts of the signDoc. It must
    /// return the doc that was signed in the response.
    /// </summary>
    /// <param name="signerAddress">The address of the account that should sign the transaction</param>
    /// <param name="signDoc">The content that should be signed</param>
    abstract signAmino: string -> StdSignDoc -> Promise<AminoSignResponse>