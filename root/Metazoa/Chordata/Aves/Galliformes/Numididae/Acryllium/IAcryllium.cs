namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Galliformes.Numididae.Acryllium;

/// <summary>
/// Interface defining characteristics of Acryllium (genus).
/// </summary>
public interface IAcryllium
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
