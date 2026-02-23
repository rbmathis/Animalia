namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Carnivora.Eupleridae.Eupleres;

/// <summary>
/// Interface defining characteristics of Eupleres (genus).
/// </summary>
public interface IEupleres
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
