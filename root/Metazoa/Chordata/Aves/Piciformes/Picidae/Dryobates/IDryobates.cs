namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Piciformes.Picidae.Dryobates;

/// <summary>
/// Interface defining characteristics of Dryobates (genus).
/// </summary>
public interface IDryobates
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
