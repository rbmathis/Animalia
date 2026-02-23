namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Carnivora.Felidae.Catopuma;

/// <summary>
/// Interface defining characteristics of Catopuma (genus).
/// </summary>
public interface ICatopuma
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
