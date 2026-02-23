namespace AnimalKingdom.root.Metazoa.Chordata.Testudines.Chelidae.Emydura;

/// <summary>
/// Interface defining characteristics of Emydura (genus).
/// </summary>
public interface IEmydura
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
