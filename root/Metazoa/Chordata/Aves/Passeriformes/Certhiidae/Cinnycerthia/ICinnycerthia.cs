namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Certhiidae.Cinnycerthia;

/// <summary>
/// Interface defining characteristics of Cinnycerthia (genus).
/// </summary>
public interface ICinnycerthia
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
