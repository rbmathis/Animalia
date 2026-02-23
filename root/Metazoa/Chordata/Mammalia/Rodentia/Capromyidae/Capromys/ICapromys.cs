namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Capromyidae.Capromys;

/// <summary>
/// Interface defining characteristics of Capromys (genus).
/// </summary>
public interface ICapromys
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
