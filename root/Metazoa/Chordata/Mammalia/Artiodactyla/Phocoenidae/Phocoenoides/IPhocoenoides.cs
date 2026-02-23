namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Artiodactyla.Phocoenidae.Phocoenoides;

/// <summary>
/// Interface defining characteristics of Phocoenoides (genus).
/// </summary>
public interface IPhocoenoides
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
