namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Carnivora.Otariidae.Callorhinus;

/// <summary>
/// Interface defining characteristics of Callorhinus (genus).
/// </summary>
public interface ICallorhinus
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
