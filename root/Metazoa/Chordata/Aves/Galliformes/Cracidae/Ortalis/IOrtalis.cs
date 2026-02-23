namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Galliformes.Cracidae.Ortalis;

/// <summary>
/// Interface defining characteristics of Ortalis (genus).
/// </summary>
public interface IOrtalis
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
