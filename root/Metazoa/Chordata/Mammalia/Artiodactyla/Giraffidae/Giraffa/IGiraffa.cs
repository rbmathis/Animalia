namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Artiodactyla.Giraffidae.Giraffa;

/// <summary>
/// Interface defining characteristics of Giraffa (genus).
/// </summary>
public interface IGiraffa
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
