namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Corvidae.Hylocitrea;

/// <summary>
/// Interface defining characteristics of Hylocitrea (genus).
/// </summary>
public interface IHylocitrea
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
