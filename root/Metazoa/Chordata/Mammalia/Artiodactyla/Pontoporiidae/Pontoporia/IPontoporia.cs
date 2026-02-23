namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Artiodactyla.Pontoporiidae.Pontoporia;

/// <summary>
/// Interface defining characteristics of Pontoporia (genus).
/// </summary>
public interface IPontoporia
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
