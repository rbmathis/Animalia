namespace AnimalKingdom.root.Metazoa.Chordata.Testudines.Chelidae.Pseudemydura;

/// <summary>
/// Interface defining characteristics of Pseudemydura (genus).
/// </summary>
public interface IPseudemydura
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
