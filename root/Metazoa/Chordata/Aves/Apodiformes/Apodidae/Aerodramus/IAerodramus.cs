namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Apodiformes.Apodidae.Aerodramus;

/// <summary>
/// Interface defining characteristics of Aerodramus (genus).
/// </summary>
public interface IAerodramus
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
