namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Carnivora.Felidae.Prionailurus;

/// <summary>
/// Interface defining characteristics of Prionailurus (genus).
/// </summary>
public interface IPrionailurus
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
