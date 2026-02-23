namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Carnivora.Felidae.Herpailurus;

/// <summary>
/// Interface defining characteristics of Herpailurus (genus).
/// </summary>
public interface IHerpailurus
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
