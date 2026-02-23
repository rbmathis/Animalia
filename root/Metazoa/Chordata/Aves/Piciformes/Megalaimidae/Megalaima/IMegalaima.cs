namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Piciformes.Megalaimidae.Megalaima;

/// <summary>
/// Interface defining characteristics of Megalaima (genus).
/// </summary>
public interface IMegalaima
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
