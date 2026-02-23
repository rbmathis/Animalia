namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Pipridae.Machaeropterus;

/// <summary>
/// Interface defining characteristics of Machaeropterus (genus).
/// </summary>
public interface IMachaeropterus
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
