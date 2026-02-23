namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Proboscidea.Elephantidae.Palaeoloxodon;

/// <summary>
/// Interface defining characteristics of Palaeoloxodon (genus).
/// </summary>
public interface IPalaeoloxodon
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
