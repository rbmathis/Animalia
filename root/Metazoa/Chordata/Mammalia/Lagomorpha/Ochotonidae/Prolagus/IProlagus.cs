namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Lagomorpha.Ochotonidae.Prolagus;

/// <summary>
/// Interface defining characteristics of Prolagus (genus).
/// </summary>
public interface IProlagus
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
