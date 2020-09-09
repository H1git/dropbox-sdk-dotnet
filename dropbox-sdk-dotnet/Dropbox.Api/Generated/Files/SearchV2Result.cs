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
    /// <para>The search v2 result object</para>
    /// </summary>
    public class SearchV2Result
    {
        #pragma warning disable 108

        /// <summary>
        /// <para>The encoder instance.</para>
        /// </summary>
        internal static enc.StructEncoder<SearchV2Result> Encoder = new SearchV2ResultEncoder();

        /// <summary>
        /// <para>The decoder instance.</para>
        /// </summary>
        internal static enc.StructDecoder<SearchV2Result> Decoder = new SearchV2ResultDecoder();

        /// <summary>
        /// <para>Initializes a new instance of the <see cref="SearchV2Result" /> class.</para>
        /// </summary>
        /// <param name="matches">A list (possibly empty) of matches for the query.</param>
        /// <param name="hasMore">Used for paging. If true, indicates there is another page of
        /// results available that can be fetched by calling <see
        /// cref="Dropbox.Api.Files.Routes.FilesUserRoutes.SearchContinueV2Async" /> with the
        /// cursor.</param>
        /// <param name="cursor">Pass the cursor into <see
        /// cref="Dropbox.Api.Files.Routes.FilesUserRoutes.SearchContinueV2Async" /> to fetch
        /// the next page of results.</param>
        public SearchV2Result(col.IEnumerable<SearchMatchV2> matches,
                              bool hasMore,
                              string cursor = null)
        {
            var matchesList = enc.Util.ToList(matches);

            if (matches == null)
            {
                throw new sys.ArgumentNullException("matches");
            }

            if (cursor != null)
            {
                if (cursor.Length < 1)
                {
                    throw new sys.ArgumentOutOfRangeException("cursor", "Length should be at least 1");
                }
            }

            this.Matches = matchesList;
            this.HasMore = hasMore;
            this.Cursor = cursor;
        }

        /// <summary>
        /// <para>Initializes a new instance of the <see cref="SearchV2Result" /> class.</para>
        /// </summary>
        /// <remarks>This is to construct an instance of the object when
        /// deserializing.</remarks>
        [sys.ComponentModel.EditorBrowsable(sys.ComponentModel.EditorBrowsableState.Never)]
        public SearchV2Result()
        {
        }

        /// <summary>
        /// <para>A list (possibly empty) of matches for the query.</para>
        /// </summary>
        public col.IList<SearchMatchV2> Matches { get; protected set; }

        /// <summary>
        /// <para>Used for paging. If true, indicates there is another page of results
        /// available that can be fetched by calling <see
        /// cref="Dropbox.Api.Files.Routes.FilesUserRoutes.SearchContinueV2Async" /> with the
        /// cursor.</para>
        /// </summary>
        public bool HasMore { get; protected set; }

        /// <summary>
        /// <para>Pass the cursor into <see
        /// cref="Dropbox.Api.Files.Routes.FilesUserRoutes.SearchContinueV2Async" /> to fetch
        /// the next page of results.</para>
        /// </summary>
        public string Cursor { get; protected set; }

        #region Encoder class

        /// <summary>
        /// <para>Encoder for  <see cref="SearchV2Result" />.</para>
        /// </summary>
        private class SearchV2ResultEncoder : enc.StructEncoder<SearchV2Result>
        {
            /// <summary>
            /// <para>Encode fields of given value.</para>
            /// </summary>
            /// <param name="value">The value.</param>
            /// <param name="writer">The writer.</param>
            public override void EncodeFields(SearchV2Result value, enc.IJsonWriter writer)
            {
                WriteListProperty("matches", value.Matches, writer, global::Dropbox.Api.Files.SearchMatchV2.Encoder);
                WriteProperty("has_more", value.HasMore, writer, enc.BooleanEncoder.Instance);
                if (value.Cursor != null)
                {
                    WriteProperty("cursor", value.Cursor, writer, enc.StringEncoder.Instance);
                }
            }
        }

        #endregion


        #region Decoder class

        /// <summary>
        /// <para>Decoder for  <see cref="SearchV2Result" />.</para>
        /// </summary>
        private class SearchV2ResultDecoder : enc.StructDecoder<SearchV2Result>
        {
            /// <summary>
            /// <para>Create a new instance of type <see cref="SearchV2Result" />.</para>
            /// </summary>
            /// <returns>The struct instance.</returns>
            protected override SearchV2Result Create()
            {
                return new SearchV2Result();
            }

            /// <summary>
            /// <para>Set given field.</para>
            /// </summary>
            /// <param name="value">The field value.</param>
            /// <param name="fieldName">The field name.</param>
            /// <param name="reader">The json reader.</param>
            protected override void SetField(SearchV2Result value, string fieldName, enc.IJsonReader reader)
            {
                switch (fieldName)
                {
                    case "matches":
                        value.Matches = ReadList<SearchMatchV2>(reader, global::Dropbox.Api.Files.SearchMatchV2.Decoder);
                        break;
                    case "has_more":
                        value.HasMore = enc.BooleanDecoder.Instance.Decode(reader);
                        break;
                    case "cursor":
                        value.Cursor = enc.StringDecoder.Instance.Decode(reader);
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