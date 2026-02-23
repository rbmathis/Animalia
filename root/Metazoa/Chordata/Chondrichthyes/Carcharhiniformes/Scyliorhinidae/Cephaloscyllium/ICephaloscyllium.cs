namespace AnimalKingdom.root.Metazoa.Chordata.Chondrichthyes.Carcharhiniformes.Scyliorhinidae.Cephaloscyllium;

/// <summary>
/// Interface defining characteristics of Cephaloscyllium (genus).
/// </summary>
public interface ICephaloscyllium
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
