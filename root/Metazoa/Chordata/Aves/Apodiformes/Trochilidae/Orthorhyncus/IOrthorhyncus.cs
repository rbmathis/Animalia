namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Apodiformes.Trochilidae.Orthorhyncus;

/// <summary>
/// Interface defining characteristics of Orthorhyncus (genus).
/// </summary>
public interface IOrthorhyncus
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
