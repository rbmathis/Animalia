namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Carnivora.Otariidae.Arctocephalus;

/// <summary>
/// Interface defining characteristics of Arctocephalus (genus).
/// </summary>
public interface IArctocephalus
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
