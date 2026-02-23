namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Icteridae.Quiscalus;

/// <summary>
/// Interface defining characteristics of Quiscalus (genus).
/// </summary>
public interface IQuiscalus
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
