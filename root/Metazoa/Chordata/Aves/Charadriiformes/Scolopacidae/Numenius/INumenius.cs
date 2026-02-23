namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Charadriiformes.Scolopacidae.Numenius;

/// <summary>
/// Interface defining characteristics of Numenius (genus).
/// </summary>
public interface INumenius
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
