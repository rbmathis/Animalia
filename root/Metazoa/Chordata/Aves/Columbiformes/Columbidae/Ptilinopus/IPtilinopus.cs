namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Columbiformes.Columbidae.Ptilinopus;

/// <summary>
/// Interface defining characteristics of Ptilinopus (genus).
/// </summary>
public interface IPtilinopus
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
