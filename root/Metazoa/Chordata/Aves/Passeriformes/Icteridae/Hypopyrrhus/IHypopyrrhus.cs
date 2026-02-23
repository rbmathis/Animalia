namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Icteridae.Hypopyrrhus;

/// <summary>
/// Interface defining characteristics of Hypopyrrhus (genus).
/// </summary>
public interface IHypopyrrhus
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
