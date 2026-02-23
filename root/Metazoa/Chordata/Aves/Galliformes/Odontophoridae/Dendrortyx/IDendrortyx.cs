namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Galliformes.Odontophoridae.Dendrortyx;

/// <summary>
/// Interface defining characteristics of Dendrortyx (genus).
/// </summary>
public interface IDendrortyx
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
