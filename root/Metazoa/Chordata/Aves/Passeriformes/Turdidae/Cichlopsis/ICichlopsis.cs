namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Turdidae.Cichlopsis;

/// <summary>
/// Interface defining characteristics of Cichlopsis (genus).
/// </summary>
public interface ICichlopsis
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
