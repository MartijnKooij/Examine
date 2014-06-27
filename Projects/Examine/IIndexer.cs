﻿using System;
using System.Xml.Linq;

namespace Examine
{
    /// <summary>
    /// Interface to represent an Examine Indexer
    /// </summary>
    [Obsolete("Use IExamineIndexer instead")]
    public interface IIndexer
    {
        /// <summary>
        /// Forces a particular XML node to be reindexed
        /// </summary>
        /// <param name="node">XML node to reindex</param>
        /// <param name="category">Type of index to use</param>
        void ReIndexNode(XElement node, string category);
        
        /// <summary>
        /// Deletes a node from the index
        /// </summary>
        /// <param name="nodeId">Node to delete</param>
        void DeleteFromIndex(string nodeId);
        
        /// <summary>
        /// Re-indexes all data for the index type specified
        /// </summary>
        /// <param name="type"></param>
        void IndexAll(string type);

        /// <summary>
        /// Rebuilds the entire index from scratch for all index types
        /// </summary>
        void RebuildIndex();

        /// <summary>
        /// Gets/sets the index criteria to create the index with
        /// </summary>
        /// <value>The indexer data.</value>
        IIndexCriteria IndexerData { get; set; }

        /// <summary>
        /// determines whether the index exsists or not
        /// </summary>
        bool IndexExists();

        bool IsIndexNew();
    }
}
