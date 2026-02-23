namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Mohoidae.Chaetoptila;

/// <summary>
/// Interface defining characteristics of Chaetoptila (genus).
/// </summary>
public interface IChaetoptila
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
