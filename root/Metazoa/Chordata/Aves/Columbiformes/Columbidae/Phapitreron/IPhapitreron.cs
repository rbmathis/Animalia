namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Columbiformes.Columbidae.Phapitreron;

/// <summary>
/// Interface defining characteristics of Phapitreron (genus).
/// </summary>
public interface IPhapitreron
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
