namespace R3;

public interface IOutputContext<out TInput, TOutput> : IInteractionContext<TInput, TOutput>
{
    TOutput GetOutput();
}
