using MCCL6;

namespace _9MCCL6
{
    internal interface IDBItem<T> where T : IID
    {
        List<T> Items { get; set; }

        void AddItem(T item);
    }
}