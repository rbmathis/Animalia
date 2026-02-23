namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Charadriiformes.Glareolidae.Rhinoptilus;

/// <summary>
/// Interface defining characteristics of Rhinoptilus (genus).
/// </summary>
public interface IRhinoptilus
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
