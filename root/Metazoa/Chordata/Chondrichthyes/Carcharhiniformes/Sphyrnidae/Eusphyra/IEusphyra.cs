namespace AnimalKingdom.root.Metazoa.Chordata.Chondrichthyes.Carcharhiniformes.Sphyrnidae.Eusphyra;

/// <summary>
/// Interface defining characteristics of Eusphyra (genus).
/// </summary>
public interface IEusphyra
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
