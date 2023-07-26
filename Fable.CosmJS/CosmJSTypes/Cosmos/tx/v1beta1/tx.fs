// ts2fable 0.9.0
module rec Fable.CosmJS.CosmJSTypes.Cosmos.tx.v1beta1.tx

#nowarn "3390" // disable warnings for invalid XML comments

open System
open Fable.Core
open Fable.Core.JS

module _m0 = Fable.CosmJS.CosmJSTypes.Google.Protobuf.ProtobufRW
[<Erase>] type KeyOf<'T> = Key of string

type Any = Fable.CosmJS.CosmJSTypes.Google.Protobuf.Any.Any
type SignMode = ___signing_v1beta1_signing.SignMode
type CompactBitArray = ______crypto_multisig_v1beta1_multisig.CompactBitArray
type Coin = ______base_v1beta1_coin.Coin
type Long = _________helpers.Long
type Record<'K, 'V> = Fable.CosmJS.Record.Record<'K, 'V>
let [<Import("protobufPackage","module")>] protobufPackage: obj = jsNative
/// Tx is the standard type used for broadcasting transactions.
let [<Import("Tx","module")>] Tx: Tx<'I> = jsNative
/// <summary>
/// TxRaw is a variant of Tx that pins the signer's exact binary representation
/// of body and auth_info. This is used for signing, broadcasting and
/// verification. The binary <c>serialize(tx: TxRaw)</c> is stored in Tendermint and
/// the hash <c>sha256(serialize(tx: TxRaw))</c> becomes the "txhash", commonly used
/// as the transaction ID.
/// </summary>
let [<Import("TxRaw","module")>] TxRaw: TxRaw<'I> = jsNative
/// SignDoc is the type used for generating sign bytes for SIGN_MODE_DIRECT.
let [<Import("SignDoc","module")>] SignDoc: SignDoc<'I> = jsNative
/// SignDocDirectAux is the type used for generating sign bytes for
/// SIGN_MODE_DIRECT_AUX.
/// 
/// Since: cosmos-sdk 0.46
let [<Import("SignDocDirectAux","module")>] SignDocDirectAux: SignDocDirectAux<'I> = jsNative
/// TxBody is the body of a transaction that all signers sign over.
let [<Import("TxBody","module")>] TxBody: TxBody<'I> = jsNative
/// AuthInfo describes the fee and signer modes that are used to sign a
/// transaction.
let [<Import("AuthInfo","module")>] AuthInfo: AuthInfo<'I> = jsNative
/// SignerInfo describes the public key and signing mode of a single top-level
/// signer.
let [<Import("SignerInfo","module")>] SignerInfo: SignerInfo<'I> = jsNative
/// ModeInfo describes the signing mode of a single or nested multisig signer.
let [<Import("ModeInfo","module")>] ModeInfo: ModeInfo<'I> = jsNative
/// Single is the mode info for a single signer. It is structured as a message
/// to allow for additional fields such as locale for SIGN_MODE_TEXTUAL in the
/// future
let [<Import("ModeInfo_Single","module")>] ModeInfo_Single: ModeInfo_Single<'I> = jsNative
/// Multi is the mode info for a multisig public key
let [<Import("ModeInfo_Multi","module")>] ModeInfo_Multi: ModeInfo_Multi<'I> = jsNative
/// Fee includes the amount of coins paid in fees and the maximum
/// gas to be used by the transaction. The ratio yields an effective "gasprice",
/// which must be above some miminum to be accepted into the mempool.
let [<Import("Fee","module")>] Fee: Fee<'I> = jsNative
/// Tip is the tip used for meta-transactions.
/// 
/// Since: cosmos-sdk 0.46
let [<Import("Tip","module")>] Tip: Tip<'I> = jsNative
/// AuxSignerData is the intermediary format that an auxiliary signer (e.g. a
/// tipper) builds and sends to the fee payer (who will build and broadcast the
/// actual tx). AuxSignerData is not a valid tx in itself, and will be rejected
/// by the node if sent directly as-is.
/// 
/// Since: cosmos-sdk 0.46
let [<Import("AuxSignerData","module")>] AuxSignerData: AuxSignerData<'I> = jsNative

/// Tx is the standard type used for broadcasting transactions.
type [<AllowNullLiteral>] Tx =
    /// body is the processable content of the transaction
    abstract body: TxBody option with get, set
    /// auth_info is the authorization related content of the transaction,
    /// specifically signers, signer modes and fee
    abstract authInfo: AuthInfo option with get, set
    /// signatures is a list of signatures that matches the length and order of
    /// AuthInfo's signer_infos to allow connecting signature meta information like
    /// public key and signing mode by position.
    abstract signatures: ResizeArray<Uint8Array> with get, set

/// <summary>
/// TxRaw is a variant of Tx that pins the signer's exact binary representation
/// of body and auth_info. This is used for signing, broadcasting and
/// verification. The binary <c>serialize(tx: TxRaw)</c> is stored in Tendermint and
/// the hash <c>sha256(serialize(tx: TxRaw))</c> becomes the "txhash", commonly used
/// as the transaction ID.
/// </summary>
type [<AllowNullLiteral>] TxRaw =
    /// body_bytes is a protobuf serialization of a TxBody that matches the
    /// representation in SignDoc.
    abstract bodyBytes: Uint8Array with get, set
    /// auth_info_bytes is a protobuf serialization of an AuthInfo that matches the
    /// representation in SignDoc.
    abstract authInfoBytes: Uint8Array with get, set
    /// signatures is a list of signatures that matches the length and order of
    /// AuthInfo's signer_infos to allow connecting signature meta information like
    /// public key and signing mode by position.
    abstract signatures: ResizeArray<Uint8Array> with get, set

/// SignDoc is the type used for generating sign bytes for SIGN_MODE_DIRECT.
type [<AllowNullLiteral>] SignDoc =
    /// body_bytes is protobuf serialization of a TxBody that matches the
    /// representation in TxRaw.
    abstract bodyBytes: Uint8Array with get, set
    /// auth_info_bytes is a protobuf serialization of an AuthInfo that matches the
    /// representation in TxRaw.
    abstract authInfoBytes: Uint8Array with get, set
    /// chain_id is the unique identifier of the chain this transaction targets.
    /// It prevents signed transactions from being used on another chain by an
    /// attacker
    abstract chainId: string with get, set
    /// account_number is the account number of the account in state
    abstract accountNumber: Long with get, set

/// SignDocDirectAux is the type used for generating sign bytes for
/// SIGN_MODE_DIRECT_AUX.
/// 
/// Since: cosmos-sdk 0.46
type [<AllowNullLiteral>] SignDocDirectAux =
    /// body_bytes is protobuf serialization of a TxBody that matches the
    /// representation in TxRaw.
    abstract bodyBytes: Uint8Array with get, set
    /// public_key is the public key of the signing account.
    abstract publicKey: Any option with get, set
    /// chain_id is the identifier of the chain this transaction targets.
    /// It prevents signed transactions from being used on another chain by an
    /// attacker.
    abstract chainId: string with get, set
    /// account_number is the account number of the account in state.
    abstract accountNumber: Long with get, set
    /// sequence is the sequence number of the signing account.
    abstract sequence: Long with get, set
    /// <summary>
    /// Tip is the optional tip used for transactions fees paid in another denom.
    /// It should be left empty if the signer is not the tipper for this
    /// transaction.
    /// 
    /// This field is ignored if the chain didn't enable tips, i.e. didn't add the
    /// <c>TipDecorator</c> in its posthandler.
    /// </summary>
    abstract tip: Tip option with get, set

/// TxBody is the body of a transaction that all signers sign over.
type [<AllowNullLiteral>] TxBody =
    /// messages is a list of messages to be executed. The required signers of
    /// those messages define the number and order of elements in AuthInfo's
    /// signer_infos and Tx's signatures. Each required signer address is added to
    /// the list only the first time it occurs.
    /// By convention, the first required signer (usually from the first message)
    /// is referred to as the primary signer and pays the fee for the whole
    /// transaction.
    abstract messages: ResizeArray<Any> with get, set
    /// <summary>
    /// memo is any arbitrary note/comment to be added to the transaction.
    /// WARNING: in clients, any publicly exposed text should not be called memo,
    /// but should be called <c>note</c> instead (see <see href="https://github.com/cosmos/cosmos-sdk/issues/9122)." />
    /// </summary>
    abstract memo: string with get, set
    /// timeout is the block height after which this transaction will not
    /// be processed by the chain
    abstract timeoutHeight: Long with get, set
    /// extension_options are arbitrary options that can be added by chains
    /// when the default options are not sufficient. If any of these are present
    /// and can't be handled, the transaction will be rejected
    abstract extensionOptions: ResizeArray<Any> with get, set
    /// extension_options are arbitrary options that can be added by chains
    /// when the default options are not sufficient. If any of these are present
    /// and can't be handled, they will be ignored
    abstract nonCriticalExtensionOptions: ResizeArray<Any> with get, set

/// AuthInfo describes the fee and signer modes that are used to sign a
/// transaction.
type [<AllowNullLiteral>] AuthInfo =
    /// signer_infos defines the signing modes for the required signers. The number
    /// and order of elements must match the required signers from TxBody's
    /// messages. The first element is the primary signer and the one which pays
    /// the fee.
    abstract signerInfos: ResizeArray<SignerInfo> with get, set
    /// Fee is the fee and gas limit for the transaction. The first signer is the
    /// primary signer and the one which pays the fee. The fee can be calculated
    /// based on the cost of evaluating the body and doing signature verification
    /// of the signers. This can be estimated via simulation.
    abstract fee: Fee option with get, set
    /// <summary>
    /// Tip is the optional tip used for transactions fees paid in another denom.
    /// 
    /// This field is ignored if the chain didn't enable tips, i.e. didn't add the
    /// <c>TipDecorator</c> in its posthandler.
    /// 
    /// Since: cosmos-sdk 0.46
    /// </summary>
    abstract tip: Tip option with get, set

/// SignerInfo describes the public key and signing mode of a single top-level
/// signer.
type [<AllowNullLiteral>] SignerInfo =
    /// public_key is the public key of the signer. It is optional for accounts
    /// that already exist in state. If unset, the verifier can use the required \
    /// signer address for this position and lookup the public key.
    abstract publicKey: Any option with get, set
    /// mode_info describes the signing mode of the signer and is a nested
    /// structure to support nested multisig pubkey's
    abstract modeInfo: ModeInfo option with get, set
    /// sequence is the sequence of the account, which describes the
    /// number of committed transactions signed by a given address. It is used to
    /// prevent replay attacks.
    abstract sequence: Long with get, set

/// ModeInfo describes the signing mode of a single or nested multisig signer.
type [<AllowNullLiteral>] ModeInfo =
    /// single represents a single signer
    abstract single: ModeInfo_Single option with get, set
    /// multi represents a nested multisig signer
    abstract multi: ModeInfo_Multi option with get, set

/// Single is the mode info for a single signer. It is structured as a message
/// to allow for additional fields such as locale for SIGN_MODE_TEXTUAL in the
/// future
type [<AllowNullLiteral>] ModeInfo_Single =
    /// mode is the signing mode of the single signer
    abstract mode: SignMode with get, set

/// Multi is the mode info for a multisig public key
type [<AllowNullLiteral>] ModeInfo_Multi =
    /// bitarray specifies which keys within the multisig are signing
    abstract bitarray: CompactBitArray option with get, set
    /// mode_infos is the corresponding modes of the signers of the multisig
    /// which could include nested multisig public keys
    abstract modeInfos: ResizeArray<ModeInfo> with get, set

/// Fee includes the amount of coins paid in fees and the maximum
/// gas to be used by the transaction. The ratio yields an effective "gasprice",
/// which must be above some miminum to be accepted into the mempool.
type [<AllowNullLiteral>] Fee =
    /// amount is the amount of coins to be paid as a fee
    abstract amount: ResizeArray<Coin> with get, set
    /// gas_limit is the maximum gas that can be used in transaction processing
    /// before an out of gas error occurs
    abstract gasLimit: Long with get, set
    /// if unset, the first signer is responsible for paying the fees. If set, the specified account must pay the fees.
    /// the payer must be a tx signer (and thus have signed this field in AuthInfo).
    /// setting this field does *not* change the ordering of required signers for the transaction.
    abstract payer: string with get, set
    /// if set, the fee payer (either the first signer or the value of the payer field) requests that a fee grant be used
    /// to pay fees instead of the fee payer's own balance. If an appropriate fee grant does not exist or the chain does
    /// not support fee grants, this will fail
    abstract granter: string with get, set

/// Tip is the tip used for meta-transactions.
/// 
/// Since: cosmos-sdk 0.46
type [<AllowNullLiteral>] Tip =
    /// amount is the amount of the tip
    abstract amount: ResizeArray<Coin> with get, set
    /// tipper is the address of the account paying for the tip
    abstract tipper: string with get, set

/// AuxSignerData is the intermediary format that an auxiliary signer (e.g. a
/// tipper) builds and sends to the fee payer (who will build and broadcast the
/// actual tx). AuxSignerData is not a valid tx in itself, and will be rejected
/// by the node if sent directly as-is.
/// 
/// Since: cosmos-sdk 0.46
type [<AllowNullLiteral>] AuxSignerData =
    /// address is the bech32-encoded address of the auxiliary signer. If using
    /// AuxSignerData across different chains, the bech32 prefix of the target
    /// chain (where the final transaction is broadcasted) should be used.
    abstract address: string with get, set
    /// sign_doc is the SIGN_MODE_DIRECT_AUX sign doc that the auxiliary signer
    /// signs. Note: we use the same sign doc even if we're signing with
    /// LEGACY_AMINO_JSON.
    abstract signDoc: SignDocDirectAux option with get, set
    /// mode is the signing mode of the single signer.
    abstract mode: SignMode with get, set
    /// sig is the signature of the sign doc.
    abstract ``sig``: Uint8Array with get, set

type [<AllowNullLiteral>] Tx<'I> =
    abstract encode: message: Tx * ?writer: _m0.Writer -> _m0.Writer
    abstract decode: input: U2<_m0.Reader, Uint8Array> * ?length: float -> Tx
    abstract fromJSON: object: obj option -> Tx
    abstract toJSON: message: Tx -> obj
    abstract fromPartial: object: 'I -> Tx when 'I :> Record<Exclude<KeyOf<'I>, KeyOf<Tx>>, obj>

type [<AllowNullLiteral>] TxRaw<'I> =
    abstract encode: message: TxRaw * ?writer: _m0.Writer -> _m0.Writer
    abstract decode: input: U2<_m0.Reader, Uint8Array> * ?length: float -> TxRaw
    abstract fromJSON: object: obj option -> TxRaw
    abstract toJSON: message: TxRaw -> obj
    abstract fromPartial: object: 'I -> TxRaw when 'I :> Record<Exclude<KeyOf<'I>, KeyOf<TxRaw>>, obj>

type [<AllowNullLiteral>] SignDoc<'I> =
    abstract encode: message: SignDoc * ?writer: _m0.Writer -> _m0.Writer
    abstract decode: input: U2<_m0.Reader, Uint8Array> * ?length: float -> SignDoc
    abstract fromJSON: object: obj option -> SignDoc
    abstract toJSON: message: SignDoc -> obj
    abstract fromPartial: object: 'I -> SignDoc when 'I :> Record<Exclude<KeyOf<'I>, KeyOf<SignDoc>>, obj>

type [<AllowNullLiteral>] SignDocDirectAux<'I> =
    abstract encode: message: SignDocDirectAux * ?writer: _m0.Writer -> _m0.Writer
    abstract decode: input: U2<_m0.Reader, Uint8Array> * ?length: float -> SignDocDirectAux
    abstract fromJSON: object: obj option -> SignDocDirectAux
    abstract toJSON: message: SignDocDirectAux -> obj
    abstract fromPartial: object: 'I -> SignDocDirectAux when 'I :> Record<Exclude<KeyOf<'I>, KeyOf<SignDocDirectAux>>, obj>

type [<AllowNullLiteral>] TxBody<'I> =
    abstract encode: message: TxBody * ?writer: _m0.Writer -> _m0.Writer
    abstract decode: input: U2<_m0.Reader, Uint8Array> * ?length: float -> TxBody
    abstract fromJSON: object: obj option -> TxBody
    abstract toJSON: message: TxBody -> obj
    abstract fromPartial: object: 'I -> TxBody when 'I :> Record<Exclude<KeyOf<'I>, KeyOf<TxBody>>, obj>

type [<AllowNullLiteral>] AuthInfo<'I> =
    abstract encode: message: AuthInfo * ?writer: _m0.Writer -> _m0.Writer
    abstract decode: input: U2<_m0.Reader, Uint8Array> * ?length: float -> AuthInfo
    abstract fromJSON: object: obj option -> AuthInfo
    abstract toJSON: message: AuthInfo -> obj
    abstract fromPartial: object: 'I -> AuthInfo when 'I :> Record<Exclude<KeyOf<'I>, KeyOf<AuthInfo>>, obj>

type [<AllowNullLiteral>] SignerInfo<'I> =
    abstract encode: message: SignerInfo * ?writer: _m0.Writer -> _m0.Writer
    abstract decode: input: U2<_m0.Reader, Uint8Array> * ?length: float -> SignerInfo
    abstract fromJSON: object: obj option -> SignerInfo
    abstract toJSON: message: SignerInfo -> obj
    abstract fromPartial: object: 'I -> SignerInfo when 'I :> Record<Exclude<KeyOf<'I>, KeyOf<SignerInfo>>, obj>

type [<AllowNullLiteral>] ModeInfo<'I> =
    abstract encode: message: ModeInfo * ?writer: _m0.Writer -> _m0.Writer
    abstract decode: input: U2<_m0.Reader, Uint8Array> * ?length: float -> ModeInfo
    abstract fromJSON: object: obj option -> ModeInfo
    abstract toJSON: message: ModeInfo -> obj
    abstract fromPartial: object: 'I -> ModeInfo when 'I :> Record<Exclude<KeyOf<'I>, KeyOf<ModeInfo>>, obj>

type [<AllowNullLiteral>] ModeInfo_Single<'I> =
    abstract encode: message: ModeInfo_Single * ?writer: _m0.Writer -> _m0.Writer
    abstract decode: input: U2<_m0.Reader, Uint8Array> * ?length: float -> ModeInfo_Single
    abstract fromJSON: object: obj option -> ModeInfo_Single
    abstract toJSON: message: ModeInfo_Single -> obj
    abstract fromPartial: object: 'I -> ModeInfo_Single when 'I :> Record<Exclude<KeyOf<'I>, string>, obj>

type [<AllowNullLiteral>] ModeInfo_Multi<'I> =
    abstract encode: message: ModeInfo_Multi * ?writer: _m0.Writer -> _m0.Writer
    abstract decode: input: U2<_m0.Reader, Uint8Array> * ?length: float -> ModeInfo_Multi
    abstract fromJSON: object: obj option -> ModeInfo_Multi
    abstract toJSON: message: ModeInfo_Multi -> obj
    abstract fromPartial: object: 'I -> ModeInfo_Multi when 'I :> Record<Exclude<KeyOf<'I>, KeyOf<ModeInfo_Multi>>, obj>

type [<AllowNullLiteral>] Fee<'I> =
    abstract encode: message: Fee * ?writer: _m0.Writer -> _m0.Writer
    abstract decode: input: U2<_m0.Reader, Uint8Array> * ?length: float -> Fee
    abstract fromJSON: object: obj option -> Fee
    abstract toJSON: message: Fee -> obj
    abstract fromPartial: object: 'I -> Fee when 'I :> Record<Exclude<KeyOf<'I>, KeyOf<Fee>>, obj>

type [<AllowNullLiteral>] Tip<'I> =
    abstract encode: message: Tip * ?writer: _m0.Writer -> _m0.Writer
    abstract decode: input: U2<_m0.Reader, Uint8Array> * ?length: float -> Tip
    abstract fromJSON: object: obj option -> Tip
    abstract toJSON: message: Tip -> obj
    abstract fromPartial: object: 'I -> Tip when 'I :> Record<Exclude<KeyOf<'I>, KeyOf<Tip>>, obj>

type [<AllowNullLiteral>] AuxSignerData<'I> =
    abstract encode: message: AuxSignerData * ?writer: _m0.Writer -> _m0.Writer
    abstract decode: input: U2<_m0.Reader, Uint8Array> * ?length: float -> AuxSignerData
    abstract fromJSON: object: obj option -> AuxSignerData
    abstract toJSON: message: AuxSignerData -> obj
    abstract fromPartial: object: 'I -> AuxSignerData when 'I :> Record<Exclude<KeyOf<'I>, KeyOf<AuxSignerData>>, obj>