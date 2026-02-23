namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Strigiformes.Strigidae.Jubula;

/// <summary>
/// Interface defining characteristics of Jubula (genus).
/// </summary>
public interface IJubula
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
