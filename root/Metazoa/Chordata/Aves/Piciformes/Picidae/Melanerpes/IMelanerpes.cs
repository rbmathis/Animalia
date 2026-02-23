namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Piciformes.Picidae.Melanerpes;

/// <summary>
/// Interface defining characteristics of Melanerpes (genus).
/// </summary>
public interface IMelanerpes
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
