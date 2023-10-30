using System.Collections;

namespace MAILSYSTEMCORE.DOMAIN.Extensions;

public static class CollectionExtension
{
    public static void AddRange<T>(this ICollection<T> collection, IEnumerable<T> newItems)
    {
        foreach (T item in newItems)
        {
            collection.Add(item);
        }
    }

    public static void AddUniqueRange<T>(this ICollection<T> collection, IEnumerable<T> newItems)
    {
        foreach (T item in newItems)
        {
            if (!collection.IsItemUnique(item))
            {
                collection.Add(item);
            }
        }
    }

    public static bool IsItemUnique<T>(this ICollection<T> collection, T item)
    {
        return collection.Contains(item);
    }

    public static IReadOnlyCollection<T> AsReadOnly<T>(this ICollection<T> source)
    {
        if (source == null)
        {
            throw new ArgumentNullException(nameof(source));
        }

        return source as IReadOnlyCollection<T> ?? new ReadOnlyCollectionAdapter<T>(source);
    }

    private sealed class ReadOnlyCollectionAdapter<T> : IReadOnlyCollection<T>
    {
        private readonly ICollection<T> source;
        public ReadOnlyCollectionAdapter(ICollection<T> source) => this.source = source;
        public int Count => source.Count;
        public IEnumerator<T> GetEnumerator() => source.GetEnumerator();
        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }
}
