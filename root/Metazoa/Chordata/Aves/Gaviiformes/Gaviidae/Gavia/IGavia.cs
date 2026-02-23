namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Gaviiformes.Gaviidae.Gavia;

/// <summary>
/// Interface defining characteristics of Gavia (genus).
/// </summary>
public interface IGavia
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
