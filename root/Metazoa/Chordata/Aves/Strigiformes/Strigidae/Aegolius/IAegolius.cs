namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Strigiformes.Strigidae.Aegolius;

/// <summary>
/// Interface defining characteristics of Aegolius (genus).
/// </summary>
public interface IAegolius
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
