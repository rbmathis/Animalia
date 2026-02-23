namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Pipridae.Antilophia;

/// <summary>
/// Interface defining characteristics of Antilophia (genus).
/// </summary>
public interface IAntilophia
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
