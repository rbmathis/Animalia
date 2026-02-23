namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Charadriiformes.Burhinidae.Burhinus;

/// <summary>
/// Interface defining characteristics of Burhinus (genus).
/// </summary>
public interface IBurhinus
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
