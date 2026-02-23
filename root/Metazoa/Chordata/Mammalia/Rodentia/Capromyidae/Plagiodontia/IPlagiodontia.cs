namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Capromyidae.Plagiodontia;

/// <summary>
/// Interface defining characteristics of Plagiodontia (genus).
/// </summary>
public interface IPlagiodontia
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
