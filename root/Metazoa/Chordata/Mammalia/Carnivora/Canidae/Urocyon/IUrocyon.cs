namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Carnivora.Canidae.Urocyon;

/// <summary>
/// Interface defining characteristics of Urocyon (genus).
/// </summary>
public interface IUrocyon
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
