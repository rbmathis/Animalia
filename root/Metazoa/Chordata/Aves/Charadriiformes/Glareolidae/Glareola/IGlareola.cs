namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Charadriiformes.Glareolidae.Glareola;

/// <summary>
/// Interface defining characteristics of Glareola (genus).
/// </summary>
public interface IGlareola
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
