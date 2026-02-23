namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Artiodactyla.Monodontidae.Monodon;

/// <summary>
/// Interface defining characteristics of Monodon (genus).
/// </summary>
public interface IMonodon
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
