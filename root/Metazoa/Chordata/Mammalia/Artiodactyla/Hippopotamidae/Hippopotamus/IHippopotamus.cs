namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Artiodactyla.Hippopotamidae.Hippopotamus;

/// <summary>
/// Interface defining characteristics of Hippopotamus (genus).
/// </summary>
public interface IHippopotamus
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
