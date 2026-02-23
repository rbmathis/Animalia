namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Charadriiformes.Laridae.Pinguinus;

/// <summary>
/// Interface defining characteristics of Pinguinus (genus).
/// </summary>
public interface IPinguinus
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
