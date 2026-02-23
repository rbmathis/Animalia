namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Anseriformes.Anatidae.Plectropterus;

/// <summary>
/// Interface defining characteristics of Plectropterus (genus).
/// </summary>
public interface IPlectropterus
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
