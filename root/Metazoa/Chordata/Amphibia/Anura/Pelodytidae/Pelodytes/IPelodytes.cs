namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Pelodytidae.Pelodytes;

/// <summary>
/// Interface defining characteristics of Pelodytes (genus).
/// </summary>
public interface IPelodytes
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
