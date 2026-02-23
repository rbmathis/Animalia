namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Pipridae.Heterocercus;

/// <summary>
/// Interface defining characteristics of Heterocercus (genus).
/// </summary>
public interface IHeterocercus
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
