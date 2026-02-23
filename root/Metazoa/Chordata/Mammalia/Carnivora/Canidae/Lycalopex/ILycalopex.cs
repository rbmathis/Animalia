namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Carnivora.Canidae.Lycalopex;

/// <summary>
/// Interface defining characteristics of Lycalopex (genus).
/// </summary>
public interface ILycalopex
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
