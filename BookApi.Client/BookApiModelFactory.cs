// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace BookApi.Models
{
    /// <summary> Model factory for read-only models. </summary>
    public static partial class BookApiModelFactory
    {
        /// <summary> Initializes a new instance of Book. </summary>
        /// <param name="id"></param>
        /// <param name="title"></param>
        /// <param name="author"></param>
        /// <param name="summary"></param>
        /// <param name="type"></param>
        /// <returns> A new <see cref="Models.Book"/> instance for mocking. </returns>
        public static Book Book(int id = default, string title = null, string author = null, string summary = null, Type type = default)
        {
            return new Book(id, title, author, summary, type);
        }
    }
}