namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Chiroptera.Vespertilionidae.Hesperoptenus;

/// <summary>
/// Interface defining characteristics of Hesperoptenus (genus).
/// </summary>
public interface IHesperoptenus
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
