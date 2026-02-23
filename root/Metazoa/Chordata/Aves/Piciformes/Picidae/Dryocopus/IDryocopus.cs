namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Piciformes.Picidae.Dryocopus;

/// <summary>
/// Interface defining characteristics of Dryocopus (genus).
/// </summary>
public interface IDryocopus
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
