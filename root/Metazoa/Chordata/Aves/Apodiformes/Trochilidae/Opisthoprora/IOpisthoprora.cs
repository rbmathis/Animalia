namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Apodiformes.Trochilidae.Opisthoprora;

/// <summary>
/// Interface defining characteristics of Opisthoprora (genus).
/// </summary>
public interface IOpisthoprora
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
