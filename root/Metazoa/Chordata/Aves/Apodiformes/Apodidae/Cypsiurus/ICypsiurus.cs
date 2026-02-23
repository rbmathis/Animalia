namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Apodiformes.Apodidae.Cypsiurus;

/// <summary>
/// Interface defining characteristics of Cypsiurus (genus).
/// </summary>
public interface ICypsiurus
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
