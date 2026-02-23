namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Carnivora.Canidae.Cerdocyon;

/// <summary>
/// Interface defining characteristics of Cerdocyon (genus).
/// </summary>
public interface ICerdocyon
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
