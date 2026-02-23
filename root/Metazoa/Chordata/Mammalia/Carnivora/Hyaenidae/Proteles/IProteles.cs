namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Carnivora.Hyaenidae.Proteles;

/// <summary>
/// Interface defining characteristics of Proteles (genus).
/// </summary>
public interface IProteles
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
