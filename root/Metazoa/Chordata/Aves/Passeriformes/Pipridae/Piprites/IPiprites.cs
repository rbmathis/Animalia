namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Pipridae.Piprites;

/// <summary>
/// Interface defining characteristics of Piprites (genus).
/// </summary>
public interface IPiprites
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
