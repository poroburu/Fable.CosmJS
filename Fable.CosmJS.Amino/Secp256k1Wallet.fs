module rec Fable.CosmJS.Amino.Secp256k1Wallet

// ts2fable 0.9.0
#nowarn "3390" // disable warnings for invalid XML comments

open System
open Fable.Core
open Fable.Core.JS

type StdSignature = Fable.CosmJS.Amino.Signature.StdSignature
type AminoMsg = Fable.CosmJS.Amino.SignDoc.AminoMsg
type StdFee = Fable.CosmJS.Amino.SignDoc.StdFee
type StdSignDoc = Fable.CosmJS.Amino.SignDoc.StdSignDoc
type AccountData = Fable.CosmJS.Amino.Signer.AccountData
type AminoSignResponse = Fable.CosmJS.Amino.Signer.AminoSignResponse
type OfflineAminoSigner = Fable.CosmJS.Amino.Signer.OfflineAminoSigner

type [<AllowNullLiteral>] IExports =
    abstract isStdTx: txValue: obj -> bool
    abstract makeStdTx: content: obj * signatures: U2<StdSignature, ResizeArray<StdSignature>> -> StdTx
    /// A wallet that holds a single secp256k1 keypair.
    /// 
    /// If you want to work with BIP39 mnemonics and multiple accounts, use Secp256k1HdWallet.
    abstract Secp256k1Wallet: Secp256k1WalletStatic

/// <summary>A Cosmos SDK StdTx</summary>
/// <seealso href="https://docs.cosmos.network/master/modules/auth/03_types.html#stdtx" />
type [<AllowNullLiteral>] StdTx =
    abstract msg: ResizeArray<AminoMsg>
    abstract fee: StdFee
    abstract signatures: ResizeArray<StdSignature>
    abstract memo: string option

/// A wallet that holds a single secp256k1 keypair.
/// 
/// If you want to work with BIP39 mnemonics and multiple accounts, use Secp256k1HdWallet.
type [<AllowNullLiteral>] Secp256k1Wallet =
    inherit OfflineAminoSigner
    abstract getAccounts: unit -> Promise<ResizeArray<AccountData>>
    abstract signAmino: signerAddress: string * signDoc: StdSignDoc -> Promise<AminoSignResponse>

/// A wallet that holds a single secp256k1 keypair.
/// 
/// If you want to work with BIP39 mnemonics and multiple accounts, use Secp256k1HdWallet.
type [<AllowNullLiteral>] Secp256k1WalletStatic =
    /// <summary>Creates a Secp256k1Wallet from the given private key</summary>
    /// <param name="privkey">The private key.</param>
    /// <param name="prefix">The bech32 address prefix (human readable part). Defaults to "cosmos".</param>
    abstract fromKey: privkey: Uint8Array * ?prefix: string -> Promise<Secp256k1Wallet>