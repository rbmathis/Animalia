namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Galliformes.Cracidae.Pauxi;

/// <summary>
/// Interface defining characteristics of Pauxi (genus).
/// </summary>
public interface IPauxi
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
