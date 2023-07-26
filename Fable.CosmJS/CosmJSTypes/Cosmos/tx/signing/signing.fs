// ts2fable 0.9.0
module rec Fable.CosmJS.CosmJSTypes.Cosmos.tx.signing.signing

open System
open Fable.Core
open Fable.Core.JS

module _m0 = Fable.CosmJS.CosmJSTypes.Google.Protobuf.ProtobufRW
[<Erase>] type KeyOf<'T> = Key of string

type CompactBitArray = Fable.CosmJS.CosmJSTypes.Cosmos.crypto.multisig.CompactBitArray
type Any = Fable.CosmJS.CosmJSTypes.Google.Protobuf.Any.Any
type Long = Fable.CosmJS._types.long.Long.Long
type Record<'K,'V> = Fable.CosmJS.Record.Record<'K,'V>
let [<Import("protobufPackage","module")>] protobufPackage: obj = jsNative
/// SignatureDescriptors wraps multiple SignatureDescriptor's.
let [<Import("SignatureDescriptors","module")>] SignatureDescriptors: SignatureDescriptors<'I> = jsNative
/// SignatureDescriptor is a convenience type which represents the full data for
/// a signature including the public key of the signer, signing modes and the
/// signature itself. It is primarily used for coordinating signatures between
/// clients.
let [<Import("SignatureDescriptor","module")>] SignatureDescriptor: SignatureDescriptor<'I> = jsNative
/// Data represents signature data
let [<Import("SignatureDescriptor_Data","module")>] SignatureDescriptor_Data: SignatureDescriptor_Data<'I> = jsNative
/// Single is the signature data for a single signer
let [<Import("SignatureDescriptor_Data_Single","module")>] SignatureDescriptor_Data_Single: SignatureDescriptor_Data_Single<'I> = jsNative
/// Multi is the signature data for a multisig public key
let [<Import("SignatureDescriptor_Data_Multi","module")>] SignatureDescriptor_Data_Multi: SignatureDescriptor_Data_Multi<'I> = jsNative

type [<AllowNullLiteral>] IExports =
    abstract signModeFromJSON: object: obj option -> SignMode
    abstract signModeToJSON: object: SignMode -> string

/// SignMode represents a signing mode with its own security guarantees.
/// 
/// This enum should be considered a registry of all known sign modes
/// in the Cosmos ecosystem. Apps are not expected to support all known
/// sign modes. Apps that would like to support custom  sign modes are
/// encouraged to open a small PR against this file to add a new case
/// to this SignMode enum describing their sign mode so that different
/// apps have a consistent version of this enum.
type [<RequireQualifiedAccess>] SignMode =
    /// SIGN_MODE_UNSPECIFIED - SIGN_MODE_UNSPECIFIED specifies an unknown signing mode and will be
    /// rejected.
    | SIGN_MODE_UNSPECIFIED = 0
    /// SIGN_MODE_DIRECT - SIGN_MODE_DIRECT specifies a signing mode which uses SignDoc and is
    /// verified with raw bytes from Tx.
    | SIGN_MODE_DIRECT = 1
    /// SIGN_MODE_TEXTUAL - SIGN_MODE_TEXTUAL is a future signing mode that will verify some
    /// human-readable textual representation on top of the binary representation
    /// from SIGN_MODE_DIRECT. It is currently not supported.
    | SIGN_MODE_TEXTUAL = 2
    /// <summary>
    /// SIGN_MODE_DIRECT_AUX - SIGN_MODE_DIRECT_AUX specifies a signing mode which uses
    /// SignDocDirectAux. As opposed to SIGN_MODE_DIRECT, this sign mode does not
    /// require signers signing over other signers' <c>signer_info</c>. It also allows
    /// for adding Tips in transactions.
    /// 
    /// Since: cosmos-sdk 0.46
    /// </summary>
    | SIGN_MODE_DIRECT_AUX = 3
    /// SIGN_MODE_LEGACY_AMINO_JSON - SIGN_MODE_LEGACY_AMINO_JSON is a backwards compatibility mode which uses
    /// Amino JSON and will be removed in the future.
    | SIGN_MODE_LEGACY_AMINO_JSON = 127
    /// <summary>
    /// SIGN_MODE_EIP_191 - SIGN_MODE_EIP_191 specifies the sign mode for EIP 191 signing on the Cosmos
    /// SDK. Ref: <see href="https://eips.ethereum.org/EIPS/eip-191" />
    /// 
    /// Currently, SIGN_MODE_EIP_191 is registered as a SignMode enum variant,
    /// but is not implemented on the SDK by default. To enable EIP-191, you need
    /// to pass a custom <c>TxConfig</c> that has an implementation of
    /// <c>SignModeHandler</c> for EIP-191. The SDK may decide to fully support
    /// EIP-191 in the future.
    /// 
    /// Since: cosmos-sdk 0.45.2
    /// </summary>
    | SIGN_MODE_EIP_191 = 191
    | UNRECOGNIZED = -1

/// SignatureDescriptors wraps multiple SignatureDescriptor's.
type [<AllowNullLiteral>] SignatureDescriptors =
    /// signatures are the signature descriptors
    abstract signatures: ResizeArray<SignatureDescriptor> with get, set

/// SignatureDescriptor is a convenience type which represents the full data for
/// a signature including the public key of the signer, signing modes and the
/// signature itself. It is primarily used for coordinating signatures between
/// clients.
type [<AllowNullLiteral>] SignatureDescriptor =
    /// public_key is the public key of the signer
    abstract publicKey: Any option with get, set
    abstract data: SignatureDescriptor_Data option with get, set
    /// sequence is the sequence of the account, which describes the
    /// number of committed transactions signed by a given address. It is used to prevent
    /// replay attacks.
    abstract sequence: Long with get, set

/// Data represents signature data
type [<AllowNullLiteral>] SignatureDescriptor_Data =
    /// single represents a single signer
    abstract single: SignatureDescriptor_Data_Single option with get, set
    /// multi represents a multisig signer
    abstract multi: SignatureDescriptor_Data_Multi option with get, set

/// Single is the signature data for a single signer
type [<AllowNullLiteral>] SignatureDescriptor_Data_Single =
    /// mode is the signing mode of the single signer
    abstract mode: SignMode with get, set
    /// signature is the raw signature bytes
    abstract signature: Uint8Array with get, set

/// Multi is the signature data for a multisig public key
type [<AllowNullLiteral>] SignatureDescriptor_Data_Multi =
    /// bitarray specifies which keys within the multisig are signing
    abstract bitarray: CompactBitArray option with get, set
    /// signatures is the signatures of the multi-signature
    abstract signatures: ResizeArray<SignatureDescriptor_Data> with get, set

type [<AllowNullLiteral>] SignatureDescriptors<'I> =
    abstract encode: message: SignatureDescriptors * ?writer: _m0.Writer -> _m0.Writer
    abstract decode: input: U2<_m0.Reader, Uint8Array> * ?length: float -> SignatureDescriptors
    abstract fromJSON: object: obj option -> SignatureDescriptors
    abstract toJSON: message: SignatureDescriptors -> obj
    abstract fromPartial: object: 'I -> SignatureDescriptors when 'I :> Record<Exclude<KeyOf<'I>, string>, obj>

type [<AllowNullLiteral>] SignatureDescriptor<'I> =
    abstract encode: message: SignatureDescriptor * ?writer: _m0.Writer -> _m0.Writer
    abstract decode: input: U2<_m0.Reader, Uint8Array> * ?length: float -> SignatureDescriptor
    abstract fromJSON: object: obj option -> SignatureDescriptor
    abstract toJSON: message: SignatureDescriptor -> obj
    abstract fromPartial: object: 'I -> SignatureDescriptor when 'I :> Record<Exclude<KeyOf<'I>, KeyOf<SignatureDescriptor>>, obj>

type [<AllowNullLiteral>] SignatureDescriptor_Data<'I> =
    abstract encode: message: SignatureDescriptor_Data * ?writer: _m0.Writer -> _m0.Writer
    abstract decode: input: U2<_m0.Reader, Uint8Array> * ?length: float -> SignatureDescriptor_Data
    abstract fromJSON: object: obj option -> SignatureDescriptor_Data
    abstract toJSON: message: SignatureDescriptor_Data -> obj
    abstract fromPartial: object: 'I -> SignatureDescriptor_Data when 'I :> Record<Exclude<KeyOf<'I>, KeyOf<SignatureDescriptor_Data>>, obj>

type [<AllowNullLiteral>] SignatureDescriptor_Data_Single<'I> =
    abstract encode: message: SignatureDescriptor_Data_Single * ?writer: _m0.Writer -> _m0.Writer
    abstract decode: input: U2<_m0.Reader, Uint8Array> * ?length: float -> SignatureDescriptor_Data_Single
    abstract fromJSON: object: obj option -> SignatureDescriptor_Data_Single
    abstract toJSON: message: SignatureDescriptor_Data_Single -> obj
    abstract fromPartial: object: 'I -> SignatureDescriptor_Data_Single when 'I :> Record<Exclude<KeyOf<'I>, KeyOf<SignatureDescriptor_Data_Single>>, obj>

type [<AllowNullLiteral>] SignatureDescriptor_Data_Multi<'I> =
    abstract encode: message: SignatureDescriptor_Data_Multi * ?writer: _m0.Writer -> _m0.Writer
    abstract decode: input: U2<_m0.Reader, Uint8Array> * ?length: float -> SignatureDescriptor_Data_Multi
    abstract fromJSON: object: obj option -> SignatureDescriptor_Data_Multi
    abstract toJSON: message: SignatureDescriptor_Data_Multi -> obj
    abstract fromPartial: object: 'I -> SignatureDescriptor_Data_Multi when 'I :> Record<Exclude<KeyOf<'I>, KeyOf<SignatureDescriptor_Data_Multi>>, obj>