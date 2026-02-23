namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Eulipotyphla.Erinaceidae.Paraechinus;

/// <summary>
/// Interface defining characteristics of Paraechinus (genus).
/// </summary>
public interface IParaechinus
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
