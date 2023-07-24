// ts2fable 0.9.0
module rec Fable.CosmJS.Amino.Secp256k1HdWallet

#nowarn "3390" // disable warnings for invalid XML comments

open System
open Fable.Core
open Fable.Core.JS

type EnglishMnemonic = Fable.CosmJS.Crypto.bip39.EnglishMnemonic
type HdPath = Fable.CosmJS.Crypto.slip10.HdPath
type StdSignDoc = Fable.CosmJS.Amino.SignDoc.StdSignDoc
type AccountData = Fable.CosmJS.Amino.Signer.AccountData
type AminoSignResponse = Fable.CosmJS.Amino.Signer.AminoSignResponse
type OfflineAminoSigner = Fable.CosmJS.Amino.Signer.OfflineAminoSigner
type EncryptionConfiguration = Fable.CosmJS.Amino.Wallet.EncryptionConfiguration
type KdfConfiguration = Fable.CosmJS.Amino.Wallet.KdfConfiguration

type [<AllowNullLiteral>] IExports =
    abstract extractKdfConfiguration: serialization: string -> KdfConfiguration
    abstract Secp256k1HdWallet: Secp256k1HdWalletStatic

/// This interface describes a JSON object holding the encrypted wallet and the meta data.
/// All fields in here must be JSON types.
type [<AllowNullLiteral>] Secp256k1HdWalletSerialization =
    /// A format+version identifier for this serialization format
    abstract ``type``: string
    /// Information about the key derivation function (i.e. password to encryption key)
    abstract kdf: KdfConfiguration
    /// Information about the symmetric encryption
    abstract encryption: EncryptionConfiguration
    /// An instance of Secp256k1HdWalletData, which is stringified, encrypted and base64 encoded.
    abstract data: string

type [<AllowNullLiteral>] Secp256k1HdWalletOptions =
    /// The password to use when deriving a BIP39 seed from a mnemonic.
    abstract bip39Password: string
    /// <summary>The BIP-32/SLIP-10 derivation paths. Defaults to the Cosmos Hub/ATOM path <c>m/44'/118'/0'/0/0</c>.</summary>
    abstract hdPaths: ResizeArray<HdPath>
    /// The bech32 address prefix (human readable part). Defaults to "cosmos".
    abstract prefix: string

type [<AllowNullLiteral>] Secp256k1HdWalletConstructorOptions =
    // TODO check if TS Partial<Secp256k1HdWalletOptions> is test breaking 
    inherit Secp256k1HdWalletOptions
    abstract seed: Uint8Array

type [<AllowNullLiteral>] Secp256k1HdWallet =
    inherit OfflineAminoSigner
    abstract mnemonic: string
    abstract getAccounts: unit -> Promise<ResizeArray<AccountData>>
    abstract signAmino: signerAddress: string * signDoc: StdSignDoc -> Promise<AminoSignResponse>
    /// <summary>Generates an encrypted serialization of this wallet.</summary>
    /// <param name="password">
    /// The user provided password used to generate an encryption key via a KDF.
    /// This is not normalized internally (see "Unicode normalization" to learn more).
    /// </param>
    abstract serialize: password: string -> Promise<string>
    /// <summary>
    /// Generates an encrypted serialization of this wallet.
    /// 
    /// This is an advanced alternative to calling <c>serialize(password)</c> directly, which allows you to
    /// offload the KDF execution to a non-UI thread (e.g. in a WebWorker).
    /// 
    /// The caller is responsible for ensuring the key was derived with the given KDF options. If this
    /// is not the case, the wallet cannot be restored with the original password.
    /// </summary>
    abstract serializeWithEncryptionKey: encryptionKey: Uint8Array * kdfConfiguration: KdfConfiguration -> Promise<string>

type [<AllowNullLiteral>] Secp256k1HdWalletStatic =
    /// <summary>Restores a wallet from the given BIP39 mnemonic.</summary>
    /// <param name="mnemonic">Any valid English mnemonic.</param>
    /// <param name="options">An optional <c>Secp256k1HdWalletOptions</c> object optionally containing a bip39Password, hdPaths, and prefix.</param>
    abstract fromMnemonic: mnemonic: string * ?options: obj -> Promise<Secp256k1HdWallet>
    /// <summary>Generates a new wallet with a BIP39 mnemonic of the given length.</summary>
    /// <param name="length">The number of words in the mnemonic (12, 15, 18, 21 or 24).</param>
    /// <param name="options">An optional <c>Secp256k1HdWalletOptions</c> object optionally containing a bip39Password, hdPaths, and prefix.</param>
    abstract generate: ?length: Secp256k1HdWalletStaticGenerate * ?options: obj -> Promise<Secp256k1HdWallet>
    /// <summary>Restores a wallet from an encrypted serialization.</summary>
    /// <param name="password">
    /// The user provided password used to generate an encryption key via a KDF.
    /// This is not normalized internally (see "Unicode normalization" to learn more).
    /// </param>
    abstract deserialize: serialization: string * password: string -> Promise<Secp256k1HdWallet>
    /// <summary>
    /// Restores a wallet from an encrypted serialization.
    /// 
    /// This is an advanced alternative to calling <c>deserialize(serialization, password)</c> directly, which allows
    /// you to offload the KDF execution to a non-UI thread (e.g. in a WebWorker).
    /// 
    /// The caller is responsible for ensuring the key was derived with the given KDF configuration. This can be
    /// done using <c>extractKdfConfiguration(serialization)</c> and <c>executeKdf(password, kdfConfiguration)</c> from this package.
    /// </summary>
    abstract deserializeWithEncryptionKey: serialization: string * encryptionKey: Uint8Array -> Promise<Secp256k1HdWallet>
    [<EmitConstructor>] abstract Create: mnemonic: EnglishMnemonic * options: Secp256k1HdWalletConstructorOptions -> Secp256k1HdWallet

type [<RequireQualifiedAccess>] Secp256k1HdWalletStaticGenerate =
    | N12 = 12
    | N15 = 15
    | N18 = 18
    | N21 = 21
    | N24 = 24