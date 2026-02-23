namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Carnivora.Canidae.Chrysocyon;

/// <summary>
/// Interface defining characteristics of Chrysocyon (genus).
/// </summary>
public interface IChrysocyon
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
