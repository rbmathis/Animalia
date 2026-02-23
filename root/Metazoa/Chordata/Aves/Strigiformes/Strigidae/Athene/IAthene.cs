namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Strigiformes.Strigidae.Athene;

/// <summary>
/// Interface defining characteristics of Athene (genus).
/// </summary>
public interface IAthene
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
