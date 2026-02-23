namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Artiodactyla.Camelidae.Camelus;

/// <summary>
/// Interface defining characteristics of Camelus (genus).
/// </summary>
public interface ICamelus
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
