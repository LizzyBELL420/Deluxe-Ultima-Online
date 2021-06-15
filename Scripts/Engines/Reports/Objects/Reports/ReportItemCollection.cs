//------------------------------------------------------------------------------
// <autogenerated>
//     This code was generated by a tool.
//     Runtime Version: 1.1.4322.573
//
//     Changes to this file may cause incorrect behavior and will be lost if 
//     the code is regenerated.
// </autogenerated>
//------------------------------------------------------------------------------

using System;
using System.Collections;

namespace Server.Engines.Reports
{
    /// <summary>
    /// Strongly typed collection of Server.Engines.Reports.ReportItem.
    /// </summary>
    public class ReportItemCollection : CollectionBase
    {
        /// <summary>
        /// Gets or sets the value of the Server.Engines.Reports.ReportItem at a specific position in the ReportItemCollection.
        /// </summary>
        public ReportItem this[int index]
        {
            get
            {
                return ((ReportItem)(List[index]));
            }
            set
            {
                List[index] = value;
            }
		}

		public int Add( string name, object value )
		{
			return Add( name, value, null );
		}

		public int Add( string name, object value, string format )
		{
			ReportItem item = new ReportItem();

			item.Values.Add( name );
			item.Values.Add( value == null ? "" : value.ToString(), format );

			return Add( item );
		}
        
        /// <summary>
        /// Append a Server.Engines.Reports.ReportItem entry to this collection.
        /// </summary>
        /// <param name="value">Server.Engines.Reports.ReportItem instance.</param>
        /// <returns>The position into which the new element was inserted.</returns>
        public int Add(ReportItem value)
        {
            return List.Add(value);
        }
        
        /// <summary>
        /// Determines whether a specified Server.Engines.Reports.ReportItem instance is in this collection.
        /// </summary>
        /// <param name="value">Server.Engines.Reports.ReportItem instance to search for.</param>
        /// <returns>True if the Server.Engines.Reports.ReportItem instance is in the collection; otherwise false.</returns>
        public bool Contains(ReportItem value)
        {
            return List.Contains(value);
        }
        
        /// <summary>
        /// Retrieve the index a specified Server.Engines.Reports.ReportItem instance is in this collection.
        /// </summary>
        /// <param name="value">Server.Engines.Reports.ReportItem instance to find.</param>
        /// <returns>The zero-based index of the specified Server.Engines.Reports.ReportItem instance. If the object is not found, the return value is -1.</returns>
        public int IndexOf(ReportItem value)
        {
            return List.IndexOf(value);
        }
        
        /// <summary>
        /// Removes a specified Server.Engines.Reports.ReportItem instance from this collection.
        /// </summary>
        /// <param name="value">The Server.Engines.Reports.ReportItem instance to remove.</param>
        public void Remove(ReportItem value)
        {
            List.Remove(value);
        }
        
        /// <summary>
        /// Returns an enumerator that can iterate through the Server.Engines.Reports.ReportItem instance.
        /// </summary>
        /// <returns>An Server.Engines.Reports.ReportItem's enumerator.</returns>
        public new ReportItemCollectionEnumerator GetEnumerator()
        {
            return new ReportItemCollectionEnumerator(this);
        }
        
        /// <summary>
        /// Insert a Server.Engines.Reports.ReportItem instance into this collection at a specified index.
        /// </summary>
        /// <param name="index">Zero-based index.</param>
        /// <param name="value">The Server.Engines.Reports.ReportItem instance to insert.</param>
        public void Insert(int index, ReportItem value)
        {
            List.Insert(index, value);
        }
        
        /// <summary>
        /// Strongly typed enumerator of Server.Engines.Reports.ReportItem.
        /// </summary>
        public class ReportItemCollectionEnumerator : IEnumerator
        {
            
            /// <summary>
            /// Current index
            /// </summary>
            private int _index;
            
            /// <summary>
            /// Current element pointed to.
            /// </summary>
            private ReportItem _currentElement;
            
            /// <summary>
            /// Collection to enumerate.
            /// </summary>
            private readonly ReportItemCollection _collection;
            
            /// <summary>
            /// Default constructor for enumerator.
            /// </summary>
            /// <param name="collection">Instance of the collection to enumerate.</param>
            internal ReportItemCollectionEnumerator(ReportItemCollection collection)
            {
                _index = -1;
                _collection = collection;
            }
            
            /// <summary>
            /// Gets the Server.Engines.Reports.ReportItem object in the enumerated ReportItemCollection currently indexed by this instance.
            /// </summary>
            public ReportItem Current
            {
                get
                {
                    if (((_index == -1) 
                                || (_index >= _collection.Count)))
                    {
                        throw new IndexOutOfRangeException("Enumerator not started.");
                    }
                    else
                    {
                        return _currentElement;
                    }
                }
            }
            
            /// <summary>
            /// Gets the current element in the collection.
            /// </summary>
            object IEnumerator.Current
            {
                get
                {
                    if (((_index == -1) 
                                || (_index >= _collection.Count)))
                    {
                        throw new IndexOutOfRangeException("Enumerator not started.");
                    }
                    else
                    {
                        return _currentElement;
                    }
                }
            }
            
            /// <summary>
            /// Reset the cursor, so it points to the beginning of the enumerator.
            /// </summary>
            public void Reset()
            {
                _index = -1;
                _currentElement = null;
            }
            
            /// <summary>
            /// Advances the enumerator to the next queue of the enumeration, if one is currently available.
            /// </summary>
            /// <returns>true, if the enumerator was succesfully advanced to the next queue; false, if the enumerator has reached the end of the enumeration.</returns>
            public bool MoveNext()
            {
                if ((_index 
                            < (_collection.Count - 1)))
                {
                    _index = (_index + 1);
                    _currentElement = _collection[_index];
                    return true;
                }
                _index = _collection.Count;
                return false;
            }
        }
    }
}
