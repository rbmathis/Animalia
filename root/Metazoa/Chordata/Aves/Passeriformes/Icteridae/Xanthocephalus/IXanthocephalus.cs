namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Icteridae.Xanthocephalus;

/// <summary>
/// Interface defining characteristics of Xanthocephalus (genus).
/// </summary>
public interface IXanthocephalus
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
