namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Suliformes.Sulidae.Sula;

/// <summary>
/// Interface defining characteristics of Sula (genus).
/// </summary>
public interface ISula
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
