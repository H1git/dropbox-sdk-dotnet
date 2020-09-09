// <auto-generated>
// Auto-generated by StoneAPI, do not modify.
// </auto-generated>

namespace Dropbox.Api.Files
{
    using sys = System;
    using col = System.Collections.Generic;
    using re = System.Text.RegularExpressions;

    using enc = Dropbox.Api.Stone;

    /// <summary>
    /// <para>The unlock file arg object</para>
    /// </summary>
    public class UnlockFileArg
    {
        #pragma warning disable 108

        /// <summary>
        /// <para>The encoder instance.</para>
        /// </summary>
        internal static enc.StructEncoder<UnlockFileArg> Encoder = new UnlockFileArgEncoder();

        /// <summary>
        /// <para>The decoder instance.</para>
        /// </summary>
        internal static enc.StructDecoder<UnlockFileArg> Decoder = new UnlockFileArgDecoder();

        /// <summary>
        /// <para>Initializes a new instance of the <see cref="UnlockFileArg" /> class.</para>
        /// </summary>
        /// <param name="path">Path in the user's Dropbox to a file.</param>
        public UnlockFileArg(string path)
        {
            if (path == null)
            {
                throw new sys.ArgumentNullException("path");
            }
            if (!re.Regex.IsMatch(path, @"\A(?:(/(.|[\r\n])*)|(ns:[0-9]+(/.*)?)|(id:.*))\z"))
            {
                throw new sys.ArgumentOutOfRangeException("path", @"Value should match pattern '\A(?:(/(.|[\r\n])*)|(ns:[0-9]+(/.*)?)|(id:.*))\z'");
            }

            this.Path = path;
        }

        /// <summary>
        /// <para>Initializes a new instance of the <see cref="UnlockFileArg" /> class.</para>
        /// </summary>
        /// <remarks>This is to construct an instance of the object when
        /// deserializing.</remarks>
        [sys.ComponentModel.EditorBrowsable(sys.ComponentModel.EditorBrowsableState.Never)]
        public UnlockFileArg()
        {
        }

        /// <summary>
        /// <para>Path in the user's Dropbox to a file.</para>
        /// </summary>
        public string Path { get; protected set; }

        #region Encoder class

        /// <summary>
        /// <para>Encoder for  <see cref="UnlockFileArg" />.</para>
        /// </summary>
        private class UnlockFileArgEncoder : enc.StructEncoder<UnlockFileArg>
        {
            /// <summary>
            /// <para>Encode fields of given value.</para>
            /// </summary>
            /// <param name="value">The value.</param>
            /// <param name="writer">The writer.</param>
            public override void EncodeFields(UnlockFileArg value, enc.IJsonWriter writer)
            {
                WriteProperty("path", value.Path, writer, enc.StringEncoder.Instance);
            }
        }

        #endregion


        #region Decoder class

        /// <summary>
        /// <para>Decoder for  <see cref="UnlockFileArg" />.</para>
        /// </summary>
        private class UnlockFileArgDecoder : enc.StructDecoder<UnlockFileArg>
        {
            /// <summary>
            /// <para>Create a new instance of type <see cref="UnlockFileArg" />.</para>
            /// </summary>
            /// <returns>The struct instance.</returns>
            protected override UnlockFileArg Create()
            {
                return new UnlockFileArg();
            }

            /// <summary>
            /// <para>Set given field.</para>
            /// </summary>
            /// <param name="value">The field value.</param>
            /// <param name="fieldName">The field name.</param>
            /// <param name="reader">The json reader.</param>
            protected override void SetField(UnlockFileArg value, string fieldName, enc.IJsonReader reader)
            {
                switch (fieldName)
                {
                    case "path":
                        value.Path = enc.StringDecoder.Instance.Decode(reader);
                        break;
                    default:
                        reader.Skip();
                        break;
                }
            }
        }

        #endregion
    }
}