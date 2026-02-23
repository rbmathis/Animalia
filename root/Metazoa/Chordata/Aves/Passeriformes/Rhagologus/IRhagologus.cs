namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Rhagologus;

/// <summary>
/// Interface defining characteristics of Rhagologus (genus).
/// </summary>
public interface IRhagologus
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
