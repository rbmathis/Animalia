namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Piciformes.Picidae.Jynx;

/// <summary>
/// Interface defining characteristics of Jynx (genus).
/// </summary>
public interface IJynx
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
