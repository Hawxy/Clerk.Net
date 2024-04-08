// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Clerk.Net.Client.Users {
    public class UsersPostRequestBody : IParsable 
    {
        /// <summary>If Backup Codes are configured on the instance, you can provide them to enable it on the newly created user without the need to reset them.You must provide the backup codes in plain format or the corresponding bcrypt digest.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<string>? BackupCodes { get; set; }
#nullable restore
#else
        public List<string> BackupCodes { get; set; }
#endif
        /// <summary>A custom date/time denoting _when_ the user signed up to the application, specified in RFC3339 format (e.g. `2012-10-20T07:15:20.902Z`).</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? CreatedAt { get; set; }
#nullable restore
#else
        public string CreatedAt { get; set; }
#endif
        /// <summary>Email addresses to add to the user.Must be unique across your instance.The first email address will be set as the user&apos;s primary email address.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<string>? EmailAddress { get; set; }
#nullable restore
#else
        public List<string> EmailAddress { get; set; }
#endif
        /// <summary>The ID of the user as used in your external systems or your previous authentication solution.Must be unique across your instance.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ExternalId { get; set; }
#nullable restore
#else
        public string ExternalId { get; set; }
#endif
        /// <summary>The first name to assign to the user</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? FirstName { get; set; }
#nullable restore
#else
        public string FirstName { get; set; }
#endif
        /// <summary>The last name to assign to the user</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? LastName { get; set; }
#nullable restore
#else
        public string LastName { get; set; }
#endif
        /// <summary>The plaintext password to give the user.Must be at least 8 characters long, and can not be in any list of hacked passwords.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Password { get; set; }
#nullable restore
#else
        public string Password { get; set; }
#endif
        /// <summary>In case you already have the password digests and not the passwords, you can use them for the newly created user via this property.The digests should be generated with one of the supported algorithms.The hashing algorithm can be specified using the `password_hasher` property.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? PasswordDigest { get; set; }
#nullable restore
#else
        public string PasswordDigest { get; set; }
#endif
        /// <summary>The hashing algorithm that was used to generate the password digest.The algorithms we support at the moment are [bcrypt](https://en.wikipedia.org/wiki/Bcrypt), [bcrypt_sha256_django](https://docs.djangoproject.com/en/4.0/topics/auth/passwords/),[md5](https://en.wikipedia.org/wiki/MD5), pbkdf2_sha256, [pbkdf2_sha256_django](https://docs.djangoproject.com/en/4.0/topics/auth/passwords/),[phpass](https://www.openwall.com/phpass/), [scrypt_firebase](https://firebaseopensource.com/projects/firebase/scrypt/),[sha256](https://en.wikipedia.org/wiki/SHA-2)and the [argon2](https://argon2.online/) variants argon2i and argon2id.If you need support for any particular hashing algorithm, [please let us know](https://clerk.com/support).Note: for password hashers considered insecure (at this moment MD5 and SHA256), the corresponding user password hashes will be transparently migrated to Bcrypt (a secure hasher) upon the user&apos;s first successful password sign in.Insecure schemes are marked with `(insecure)` in the list below.Each of the supported hashers expects the incoming digest to be in a particular format. Specifically:**bcrypt:** The digest should be of the following form:`$&lt;algorithm version&gt;$&lt;cost&gt;$&lt;salt &amp; hash&gt;`**bcrypt_sha256_django:** This is the Django-specific variant of Bcrypt, using SHA256 hashing function. The format should be as follows (as exported from Django):`bcrypt_sha256$$&lt;algorithm version&gt;$&lt;cost&gt;$&lt;salt &amp; hash&gt;`**md5** (insecure): The digest should follow the regular form e.g.:`5f4dcc3b5aa765d61d8327deb882cf99`**pbkdf2_sha256:** This is the PBKDF2 algorithm using the SHA256 hashing function. The format should be as follows:`pbkdf2_sha256$&lt;iterations&gt;$&lt;salt&gt;$&lt;hash&gt;`Note: Both the salt and the hash are expected to be base64-encoded.**pbkdf2_sha256_django:** This is the Django-specific variant of PBKDF2 and the digest should have the following format (as exported from Django):`pbkdf2_sha256$&lt;iterations&gt;$&lt;salt&gt;$&lt;hash&gt;`Note: The salt is expected to be un-encoded, the hash is expected base64-encoded.**pbkdf2_sha1:** This is similar to pkbdf2_sha256_django, but with two differences:1. uses sha1 instead of sha2562. accepts the hash as a hex-encoded stringThe format is the following:`pbkdf2_sha1$&lt;iterations&gt;$&lt;salt&gt;$&lt;hash-as-hex-string&gt;`**phpass:** Portable public domain password hashing framework for use in PHP applications. Digests hashed with phpass have the following sections:The format is the following:`$P$&lt;rounds&gt;&lt;salt&gt;&lt;encoded-checksum&gt;`- $P$ is the prefix used to identify phpass hashes.- rounds is a single character encoding a 6-bit integer representing the number of rounds used.- salt is eight characters drawn from [./0-9A-Za-z], providing a 48-bit salt.- checksum is 22 characters drawn from the same set, encoding the 128-bit checksum with MD5.**scrypt_firebase:** The Firebase-specific variant of scrypt.The value is expected to have 6 segments separated by the $ character and include the following information:_hash:_ The actual Base64 hash. This can be retrieved when exporting the user from Firebase._salt:_ The salt used to generate the above hash. Again, this is given when exporting the user._signer key:_ The base64 encoded signer key._salt separator:_ The base64 encoded salt separator._rounds:_ The number of rounds the algorithm needs to run._memory cost:_ The cost of the algorithm runThe first 2 (hash and salt) are per user and can be retrieved when exporting the user from Firebase.The other 4 values (signer key, salt separator, rounds and memory cost) are project-wide settings and can be retrieved from the project&apos;s password hash parameters.Once you have all these, you can combine it in the following format and send this as the digest in order for Clerk to accept it:`&lt;hash&gt;$&lt;salt&gt;$&lt;signer key&gt;$&lt;salt separator&gt;$&lt;rounds&gt;$&lt;memory cost&gt;`**argon2i:** Algorithms in the argon2 family generate digests that encode the following information:_version (v):_ The argon version, version 19 is assumed_memory (m):_ The memory used by the algorithm (in kibibytes)_iterations (t):_ The number of iterations to perform_parallelism (p):_ The number of threads to useParts are demarcated by the `$` character, with the first part identifying the algorithm variant.The middle part is a comma-separated list of the encoding options (memory, iterations, parallelism).The final part is the actual digest.`$argon2i$v=19$m=4096,t=3,p=1$4t6CL3P7YiHBtwESXawI8Hm20zJj4cs7/4/G3c187e0$m7RQFczcKr5bIR0IIxbpO2P0tyrLjf3eUW3M3QSwnLc`**argon2id:** See the previous algorithm for an explanation of the formatting.For the argon2id case, the value of the algorithm in the first part of the digest is `argon2id`:`$argon2id$v=19$m=64,t=4,p=8$Z2liZXJyaXNo$iGXEpMBTDYQ8G/71tF0qGjxRHEmR3gpGULcE93zUJVU`**sha256** (insecure): The digest should be a 64-length hex string, e.g.:`9f86d081884c7d659a2feaa0c55ad015a3bf4f1b2b0b822cd15d6c15b0f00a08`</summary>
        public UsersPostRequestBody_password_hasher? PasswordHasher { get; set; }
        /// <summary>Phone numbers to add to the user.Must be unique across your instance.The first phone number will be set as the user&apos;s primary phone number.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<string>? PhoneNumber { get; set; }
#nullable restore
#else
        public List<string> PhoneNumber { get; set; }
#endif
        /// <summary>Metadata saved on the user, that is only visible to your Backend API</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public UsersPostRequestBody_private_metadata? PrivateMetadata { get; set; }
#nullable restore
#else
        public UsersPostRequestBody_private_metadata PrivateMetadata { get; set; }
#endif
        /// <summary>Metadata saved on the user, that is visible to both your Frontend and Backend APIs</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public UsersPostRequestBody_public_metadata? PublicMetadata { get; set; }
#nullable restore
#else
        public UsersPostRequestBody_public_metadata PublicMetadata { get; set; }
#endif
        /// <summary>When set to `true` all password checks are skipped.It is recommended to use this method only when migrating plaintext passwords to Clerk.Upon migration the user base should be prompted to pick stronger password.</summary>
        public bool? SkipPasswordChecks { get; set; }
        /// <summary>When set to `true`, `password` is not required anymore when creating the user and can be omitted.This is useful when you are trying to create a user that doesn&apos;t have a password, in an instance that is using passwords.Please note that you cannot use this flag if password is the only way for a user to sign into your instance.</summary>
        public bool? SkipPasswordRequirement { get; set; }
        /// <summary>In case TOTP is configured on the instance, you can provide the secret to enable it on the newly created user without the need to reset it.Please note that currently the supported options are:* Period: 30 seconds* Code length: 6 digits* Algorithm: SHA1</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? TotpSecret { get; set; }
#nullable restore
#else
        public string TotpSecret { get; set; }
#endif
        /// <summary>Metadata saved on the user, that can be updated from both the Frontend and Backend APIs.Note: Since this data can be modified from the frontend, it is not guaranteed to be safe.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public UsersPostRequestBody_unsafe_metadata? UnsafeMetadata { get; set; }
#nullable restore
#else
        public UsersPostRequestBody_unsafe_metadata UnsafeMetadata { get; set; }
#endif
        /// <summary>The username to give to the user.It must be unique across your instance.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Username { get; set; }
#nullable restore
#else
        public string Username { get; set; }
#endif
        /// <summary>Web3 wallets to add to the user.Must be unique across your instance.The first wallet will be set as the user&apos;s primary wallet.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<string>? Web3Wallet { get; set; }
#nullable restore
#else
        public List<string> Web3Wallet { get; set; }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="UsersPostRequestBody"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static UsersPostRequestBody CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new UsersPostRequestBody();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                {"backup_codes", n => { BackupCodes = n.GetCollectionOfPrimitiveValues<string>()?.ToList(); } },
                {"created_at", n => { CreatedAt = n.GetStringValue(); } },
                {"email_address", n => { EmailAddress = n.GetCollectionOfPrimitiveValues<string>()?.ToList(); } },
                {"external_id", n => { ExternalId = n.GetStringValue(); } },
                {"first_name", n => { FirstName = n.GetStringValue(); } },
                {"last_name", n => { LastName = n.GetStringValue(); } },
                {"password", n => { Password = n.GetStringValue(); } },
                {"password_digest", n => { PasswordDigest = n.GetStringValue(); } },
                {"password_hasher", n => { PasswordHasher = n.GetEnumValue<UsersPostRequestBody_password_hasher>(); } },
                {"phone_number", n => { PhoneNumber = n.GetCollectionOfPrimitiveValues<string>()?.ToList(); } },
                {"private_metadata", n => { PrivateMetadata = n.GetObjectValue<UsersPostRequestBody_private_metadata>(UsersPostRequestBody_private_metadata.CreateFromDiscriminatorValue); } },
                {"public_metadata", n => { PublicMetadata = n.GetObjectValue<UsersPostRequestBody_public_metadata>(UsersPostRequestBody_public_metadata.CreateFromDiscriminatorValue); } },
                {"skip_password_checks", n => { SkipPasswordChecks = n.GetBoolValue(); } },
                {"skip_password_requirement", n => { SkipPasswordRequirement = n.GetBoolValue(); } },
                {"totp_secret", n => { TotpSecret = n.GetStringValue(); } },
                {"unsafe_metadata", n => { UnsafeMetadata = n.GetObjectValue<UsersPostRequestBody_unsafe_metadata>(UsersPostRequestBody_unsafe_metadata.CreateFromDiscriminatorValue); } },
                {"username", n => { Username = n.GetStringValue(); } },
                {"web3_wallet", n => { Web3Wallet = n.GetCollectionOfPrimitiveValues<string>()?.ToList(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteCollectionOfPrimitiveValues<string>("backup_codes", BackupCodes);
            writer.WriteStringValue("created_at", CreatedAt);
            writer.WriteCollectionOfPrimitiveValues<string>("email_address", EmailAddress);
            writer.WriteStringValue("external_id", ExternalId);
            writer.WriteStringValue("first_name", FirstName);
            writer.WriteStringValue("last_name", LastName);
            writer.WriteStringValue("password", Password);
            writer.WriteStringValue("password_digest", PasswordDigest);
            writer.WriteEnumValue<UsersPostRequestBody_password_hasher>("password_hasher", PasswordHasher);
            writer.WriteCollectionOfPrimitiveValues<string>("phone_number", PhoneNumber);
            writer.WriteObjectValue<UsersPostRequestBody_private_metadata>("private_metadata", PrivateMetadata);
            writer.WriteObjectValue<UsersPostRequestBody_public_metadata>("public_metadata", PublicMetadata);
            writer.WriteBoolValue("skip_password_checks", SkipPasswordChecks);
            writer.WriteBoolValue("skip_password_requirement", SkipPasswordRequirement);
            writer.WriteStringValue("totp_secret", TotpSecret);
            writer.WriteObjectValue<UsersPostRequestBody_unsafe_metadata>("unsafe_metadata", UnsafeMetadata);
            writer.WriteStringValue("username", Username);
            writer.WriteCollectionOfPrimitiveValues<string>("web3_wallet", Web3Wallet);
        }
    }
}
