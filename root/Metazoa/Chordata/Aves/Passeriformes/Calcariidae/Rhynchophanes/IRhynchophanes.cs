namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Calcariidae.Rhynchophanes;

/// <summary>
/// Interface defining characteristics of Rhynchophanes (genus).
/// </summary>
public interface IRhynchophanes
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
