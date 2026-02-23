namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Strigiformes.Strigidae.Sceloglaux;

/// <summary>
/// Interface defining characteristics of Sceloglaux (genus).
/// </summary>
public interface ISceloglaux
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
