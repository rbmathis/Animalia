namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Tetraodontiformes.Monacanthidae.Chaetodermis;

/// <summary>
/// Interface defining characteristics of Chaetodermis (genus).
/// </summary>
public interface IChaetodermis
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
