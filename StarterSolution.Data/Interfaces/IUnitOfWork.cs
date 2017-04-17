namespace StarterSolution.Data.Interfaces
{
    using System;
    using System.Threading.Tasks;

    public interface IUnitOfWork : IDisposable
    {
        IPartsRepository Parts { get; }
        ICarsRepository Cars { get; }
        Task<int> CompleteAsync();
    }
}
