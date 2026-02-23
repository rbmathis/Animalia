namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Carnivora.Otariidae.Zalophus;

/// <summary>
/// Interface defining characteristics of Zalophus (genus).
/// </summary>
public interface IZalophus
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
