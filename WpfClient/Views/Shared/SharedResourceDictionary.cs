using System;
using System.Collections.Generic;
using System.Threading;
using System.Windows;

namespace WpfClient.Views.Shared
{
    public sealed class SharedResourceDictionary : ResourceDictionary
    {
        /// <summary>
        ///     Internal cache of loaded dictionaries
        /// </summary>
        public static ThreadLocal<IDictionary<Uri, ResourceDictionary>> SharedDictionaries = new ThreadLocal<IDictionary<Uri, ResourceDictionary>>();

        /// <summary>
        ///     Local member of the source uri
        /// </summary>
        private Uri _sourceUri;

        /// <summary>
        ///     Gets or sets the uniform resource identifier (URI) to load resources from.
        /// </summary>
        public new Uri Source
        {
            get => _sourceUri;
            set
            {
                _sourceUri = value;

                if (!SharedDictionaries.IsValueCreated) 
                {
                    SharedDictionaries.Value = new Dictionary<Uri, ResourceDictionary>();
                }                    

                if (!SharedDictionaries.Value.ContainsKey(_sourceUri))
                {
                    // If the dictionary is not yet loaded, load it by setting the source of the base class
                    base.Source = _sourceUri;

                    // add it to the cache
                    SharedDictionaries.Value.Add(_sourceUri, this);
                }
                else
                {
                    // If the dictionary is already loaded, get it from the cache
                    MergedDictionaries.Add(SharedDictionaries.Value[_sourceUri]);
                }
            }
        }
    }
}
