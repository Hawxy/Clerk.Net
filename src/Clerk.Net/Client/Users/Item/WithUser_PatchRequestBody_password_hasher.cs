// <auto-generated/>
using System.Runtime.Serialization;
using System;
namespace Clerk.Net.Client.Users.Item
{
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.16.0")]
    /// <summary>The hashing algorithm that was used to generate the password digest.The algorithms we support at the moment are [bcrypt](https://en.wikipedia.org/wiki/Bcrypt), [bcrypt_sha256_django](https://docs.djangoproject.com/en/4.0/topics/auth/passwords/),[md5](https://en.wikipedia.org/wiki/MD5), pbkdf2_sha256, pbkdf2_sha512, [pbkdf2_sha256_django](https://docs.djangoproject.com/en/4.0/topics/auth/passwords/),[phpass](https://www.openwall.com/phpass/), [scrypt_firebase](https://firebaseopensource.com/projects/firebase/scrypt/),[sha256](https://en.wikipedia.org/wiki/SHA-2), [scrypt_werkzeug](https://werkzeug.palletsprojects.com/en/3.0.x/utils/#werkzeug.security.generate_password_hash)and the [argon2](https://argon2.online/) variants argon2i and argon2id.If you need support for any particular hashing algorithm, [please let us know](https://clerk.com/support).Note: for password hashers considered insecure (at this moment MD5 and SHA256), the corresponding user password hashes will be transparently migrated to Bcrypt (a secure hasher) upon the user&apos;s first successful password sign in.Insecure schemes are marked with `(insecure)` in the list below.Each of the supported hashers expects the incoming digest to be in a particular format. Specifically:**bcrypt:** The digest should be of the following form:`$&lt;algorithm version&gt;$&lt;cost&gt;$&lt;salt &amp; hash&gt;`**bcrypt_sha256_django:** This is the Django-specific variant of Bcrypt, using SHA256 hashing function. The format should be as follows (as exported from Django):`bcrypt_sha256$$&lt;algorithm version&gt;$&lt;cost&gt;$&lt;salt &amp; hash&gt;`**md5** (insecure): The digest should follow the regular form e.g.:`5f4dcc3b5aa765d61d8327deb882cf99`**pbkdf2_sha256:** This is the PBKDF2 algorithm using the SHA256 hashing function. The format should be as follows:`pbkdf2_sha256$&lt;iterations&gt;$&lt;salt&gt;$&lt;hash&gt;`Note: Both the salt and the hash are expected to be base64-encoded.**pbkdf2_sha512:** This is the PBKDF2 algorithm using the SHA512 hashing function. The format should be as follows:`pbkdf2_sha512$&lt;iterations&gt;$&lt;salt&gt;$&lt;hash&gt;`  _iterations:_ The number of iterations used. Must be an integer less than 420000.  _salt:_ The salt used when generating the hash. Must be less than bytes.  _hash:_ The hex-encoded hash. Must have been generated with a key length less than 1024 bytes.**pbkdf2_sha256_django:** This is the Django-specific variant of PBKDF2 and the digest should have the following format (as exported from Django):`pbkdf2_sha256$&lt;iterations&gt;$&lt;salt&gt;$&lt;hash&gt;`Note: The salt is expected to be un-encoded, the hash is expected base64-encoded.**pbkdf2_sha1:** This is similar to pkbdf2_sha256_django, but with two differences:1. uses sha1 instead of sha2562. accepts the hash as a hex-encoded stringThe format is the following:`pbkdf2_sha1$&lt;iterations&gt;$&lt;salt&gt;$&lt;hash-as-hex-string&gt;`**phpass:** Portable public domain password hashing framework for use in PHP applications. Digests hashed with phpass have the following sections:The format is the following:`$P$&lt;rounds&gt;&lt;salt&gt;&lt;encoded-checksum&gt;`- $P$ is the prefix used to identify phpass hashes.- rounds is a single character encoding a 6-bit integer representing the number of rounds used.- salt is eight characters drawn from [./0-9A-Za-z], providing a 48-bit salt.- checksum is 22 characters drawn from the same set, encoding the 128-bit checksum with MD5.**scrypt_firebase:** The Firebase-specific variant of scrypt.The value is expected to have 6 segments separated by the $ character and include the following information:_hash:_ The actual Base64 hash. This can be retrieved when exporting the user from Firebase._salt:_ The salt used to generate the above hash. Again, this is given when exporting the user._signer key:_ The base64 encoded signer key._salt separator:_ The base64 encoded salt separator._rounds:_ The number of rounds the algorithm needs to run._memory cost:_ The cost of the algorithm runThe first 2 (hash and salt) are per user and can be retrieved when exporting the user from Firebase.The other 4 values (signer key, salt separator, rounds and memory cost) are project-wide settings and can be retrieved from the project&apos;s password hash parameters.Once you have all these, you can combine it in the following format and send this as the digest in order for Clerk to accept it:`&lt;hash&gt;$&lt;salt&gt;$&lt;signer key&gt;$&lt;salt separator&gt;$&lt;rounds&gt;$&lt;memory cost&gt;`**scrypt_werkzeug:** The Werkzeug-specific variant of scrypt.The value is expected to have 3 segments separated by the $ character and include the following information:_algorithm args:_ The algorithm used to generate the hash._salt:_ The salt used to generate the above hash._hash:_ The actual Base64 hash.The algorithm args are the parameters used to generate the hash and are included in the digest.**argon2i:** Algorithms in the argon2 family generate digests that encode the following information:_version (v):_ The argon version, version 19 is assumed_memory (m):_ The memory used by the algorithm (in kibibytes)_iterations (t):_ The number of iterations to perform_parallelism (p):_ The number of threads to useParts are demarcated by the `$` character, with the first part identifying the algorithm variant.The middle part is a comma-separated list of the encoding options (memory, iterations, parallelism).The final part is the actual digest.`$argon2i$v=19$m=4096,t=3,p=1$4t6CL3P7YiHBtwESXawI8Hm20zJj4cs7/4/G3c187e0$m7RQFczcKr5bIR0IIxbpO2P0tyrLjf3eUW3M3QSwnLc`**argon2id:** See the previous algorithm for an explanation of the formatting.For the argon2id case, the value of the algorithm in the first part of the digest is `argon2id`:`$argon2id$v=19$m=64,t=4,p=8$Z2liZXJyaXNo$iGXEpMBTDYQ8G/71tF0qGjxRHEmR3gpGULcE93zUJVU`**sha256** (insecure): The digest should be a 64-length hex string, e.g.:`9f86d081884c7d659a2feaa0c55ad015a3bf4f1b2b0b822cd15d6c15b0f00a08`</summary>
    public enum WithUser_PatchRequestBody_password_hasher
    {
        [EnumMember(Value = "argon2i")]
        #pragma warning disable CS1591
        Argon2i,
        #pragma warning restore CS1591
        [EnumMember(Value = "argon2id")]
        #pragma warning disable CS1591
        Argon2id,
        #pragma warning restore CS1591
        [EnumMember(Value = "bcrypt")]
        #pragma warning disable CS1591
        Bcrypt,
        #pragma warning restore CS1591
        [EnumMember(Value = "bcrypt_sha256_django")]
        #pragma warning disable CS1591
        Bcrypt_sha256_django,
        #pragma warning restore CS1591
        [EnumMember(Value = "md5")]
        #pragma warning disable CS1591
        Md5,
        #pragma warning restore CS1591
        [EnumMember(Value = "pbkdf2_sha256")]
        #pragma warning disable CS1591
        Pbkdf2_sha256,
        #pragma warning restore CS1591
        [EnumMember(Value = "pbkdf2_sha512")]
        #pragma warning disable CS1591
        Pbkdf2_sha512,
        #pragma warning restore CS1591
        [EnumMember(Value = "pbkdf2_sha256_django")]
        #pragma warning disable CS1591
        Pbkdf2_sha256_django,
        #pragma warning restore CS1591
        [EnumMember(Value = "pbkdf2_sha1")]
        #pragma warning disable CS1591
        Pbkdf2_sha1,
        #pragma warning restore CS1591
        [EnumMember(Value = "phpass")]
        #pragma warning disable CS1591
        Phpass,
        #pragma warning restore CS1591
        [EnumMember(Value = "scrypt_firebase")]
        #pragma warning disable CS1591
        Scrypt_firebase,
        #pragma warning restore CS1591
        [EnumMember(Value = "scrypt_werkzeug")]
        #pragma warning disable CS1591
        Scrypt_werkzeug,
        #pragma warning restore CS1591
        [EnumMember(Value = "sha256")]
        #pragma warning disable CS1591
        Sha256,
        #pragma warning restore CS1591
    }
}
