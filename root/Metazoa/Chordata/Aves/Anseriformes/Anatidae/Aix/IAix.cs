namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Anseriformes.Anatidae.Aix;

/// <summary>
/// Interface defining characteristics of Aix (genus).
/// </summary>
public interface IAix
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
