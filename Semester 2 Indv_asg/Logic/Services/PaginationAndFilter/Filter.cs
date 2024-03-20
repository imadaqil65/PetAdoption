namespace Logic.Services.PaginationAndFilter
{
    public class Filter<T>
    {
        private readonly IEnumerable<T> data;
        public Filter(IEnumerable<T> data)
        {
            this.data = data;
        }
        public IEnumerable<T> ApplyFilter(Func<T, bool> filter)
        {
            return data.Where(filter);
        }
    }
}