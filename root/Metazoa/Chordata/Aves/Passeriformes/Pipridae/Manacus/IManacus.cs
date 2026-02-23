namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Pipridae.Manacus;

/// <summary>
/// Interface defining characteristics of Manacus (genus).
/// </summary>
public interface IManacus
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
