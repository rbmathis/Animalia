namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Apodiformes.Apodidae.Cypseloides;

/// <summary>
/// Interface defining characteristics of Cypseloides (genus).
/// </summary>
public interface ICypseloides
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
