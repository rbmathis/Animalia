namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Abrocomidae.Abrocoma;

/// <summary>
/// Interface defining characteristics of Abrocoma (genus).
/// </summary>
public interface IAbrocoma
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
