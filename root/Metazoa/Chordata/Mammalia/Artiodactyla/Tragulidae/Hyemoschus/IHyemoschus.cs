namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Artiodactyla.Tragulidae.Hyemoschus;

/// <summary>
/// Interface defining characteristics of Hyemoschus (genus).
/// </summary>
public interface IHyemoschus
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
