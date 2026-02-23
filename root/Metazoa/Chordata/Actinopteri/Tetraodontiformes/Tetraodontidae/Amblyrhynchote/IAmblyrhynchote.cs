namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Tetraodontiformes.Tetraodontidae.Amblyrhynchote;

/// <summary>
/// Interface defining characteristics of Amblyrhynchote (genus).
/// </summary>
public interface IAmblyrhynchote
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
