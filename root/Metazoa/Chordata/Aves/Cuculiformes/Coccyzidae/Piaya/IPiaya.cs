namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Cuculiformes.Coccyzidae.Piaya;

/// <summary>
/// Interface defining characteristics of Piaya (genus).
/// </summary>
public interface IPiaya
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
