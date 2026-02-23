namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Furnariidae.Hylocryptus;

/// <summary>
/// Interface defining characteristics of Hylocryptus (genus).
/// </summary>
public interface IHylocryptus
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
