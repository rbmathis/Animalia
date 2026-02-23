namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Apodiformes.Apodidae.Aeronautes;

/// <summary>
/// Interface defining characteristics of Aeronautes (genus).
/// </summary>
public interface IAeronautes
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
