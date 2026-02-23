namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Thraupidae.Pyrrhocoma;

/// <summary>
/// Interface defining characteristics of Pyrrhocoma (genus).
/// </summary>
public interface IPyrrhocoma
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
