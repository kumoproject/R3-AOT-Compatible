namespace R3;

public interface IInteractionContext<out TInput, in TOutput>
{
    TInput Input { get; }

    bool IsHandled { get; }

    void SetOutput(TOutput output);
}
