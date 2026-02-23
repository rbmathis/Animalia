namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Ploceidae.Quelea;

/// <summary>
/// Interface defining characteristics of Quelea (genus).
/// </summary>
public interface IQuelea
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
