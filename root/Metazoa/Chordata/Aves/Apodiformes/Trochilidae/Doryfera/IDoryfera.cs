namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Apodiformes.Trochilidae.Doryfera;

/// <summary>
/// Interface defining characteristics of Doryfera (genus).
/// </summary>
public interface IDoryfera
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
