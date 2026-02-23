namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Corvidae.Perisoreus;

/// <summary>
/// Interface defining characteristics of Perisoreus (genus).
/// </summary>
public interface IPerisoreus
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
