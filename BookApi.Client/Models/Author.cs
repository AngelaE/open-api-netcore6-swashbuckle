// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace BookApi.Models
{
    /// <summary> The Author. </summary>
    public partial class Author
    {
        /// <summary> Initializes a new instance of Author. </summary>
        public Author()
        {
        }

        /// <summary> Initializes a new instance of Author. </summary>
        /// <param name="id"></param>
        /// <param name="name"></param>
        internal Author(int? id, string name)
        {
            Id = id;
            Name = name;
        }

        /// <summary> Gets or sets the id. </summary>
        public int? Id { get; set; }
        /// <summary> Gets or sets the name. </summary>
        public string Name { get; set; }
    }
}