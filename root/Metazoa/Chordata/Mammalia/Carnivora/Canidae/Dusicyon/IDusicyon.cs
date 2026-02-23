namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Carnivora.Canidae.Dusicyon;

/// <summary>
/// Interface defining characteristics of Dusicyon (genus).
/// </summary>
public interface IDusicyon
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
