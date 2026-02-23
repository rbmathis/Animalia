namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Dinornithiformes.Emeidae.Emeus;

/// <summary>
/// Interface defining characteristics of Emeus (genus).
/// </summary>
public interface IEmeus
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
