namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Carnivora.Canidae.Aenocyon;

/// <summary>
/// Interface defining characteristics of Aenocyon (genus).
/// </summary>
public interface IAenocyon
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
