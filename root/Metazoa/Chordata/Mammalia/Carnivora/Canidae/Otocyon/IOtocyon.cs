namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Carnivora.Canidae.Otocyon;

/// <summary>
/// Interface defining characteristics of Otocyon (genus).
/// </summary>
public interface IOtocyon
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
