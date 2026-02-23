namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Carnivora.Felidae.Panthera;

/// <summary>
/// Interface defining characteristics of Panthera (genus).
/// </summary>
public interface IPanthera
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
