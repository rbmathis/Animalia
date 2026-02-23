namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Corvidae.Pyrrhocorax;

/// <summary>
/// Interface defining characteristics of Pyrrhocorax (genus).
/// </summary>
public interface IPyrrhocorax
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
