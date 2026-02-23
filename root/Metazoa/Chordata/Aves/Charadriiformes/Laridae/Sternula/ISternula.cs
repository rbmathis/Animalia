namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Charadriiformes.Laridae.Sternula;

/// <summary>
/// Interface defining characteristics of Sternula (genus).
/// </summary>
public interface ISternula
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
