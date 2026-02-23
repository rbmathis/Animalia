namespace AnimalKingdom.root.Metazoa.Chordata.Testudines.Testudinidae.Gopherus;

/// <summary>
/// Interface defining characteristics of Gopherus (genus).
/// </summary>
public interface IGopherus
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
