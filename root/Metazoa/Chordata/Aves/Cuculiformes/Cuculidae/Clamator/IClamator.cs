namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Cuculiformes.Cuculidae.Clamator;

/// <summary>
/// Interface defining characteristics of Clamator (genus).
/// </summary>
public interface IClamator
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
