namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Sturnidae.Cinnyricinclus;

/// <summary>
/// Interface defining characteristics of Cinnyricinclus (genus).
/// </summary>
public interface ICinnyricinclus
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
