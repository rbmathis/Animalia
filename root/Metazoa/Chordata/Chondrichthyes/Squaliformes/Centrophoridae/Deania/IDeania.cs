namespace AnimalKingdom.root.Metazoa.Chordata.Chondrichthyes.Squaliformes.Centrophoridae.Deania;

/// <summary>
/// Interface defining characteristics of Deania (genus).
/// </summary>
public interface IDeania
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
