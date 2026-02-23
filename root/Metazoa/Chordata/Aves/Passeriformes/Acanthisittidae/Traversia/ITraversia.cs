namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Acanthisittidae.Traversia;

/// <summary>
/// Interface defining characteristics of Traversia (genus).
/// </summary>
public interface ITraversia
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
