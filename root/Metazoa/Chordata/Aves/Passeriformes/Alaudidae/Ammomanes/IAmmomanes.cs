namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Alaudidae.Ammomanes;

/// <summary>
/// Interface defining characteristics of Ammomanes (genus).
/// </summary>
public interface IAmmomanes
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
