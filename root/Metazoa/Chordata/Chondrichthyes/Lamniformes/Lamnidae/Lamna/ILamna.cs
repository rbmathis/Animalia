namespace AnimalKingdom.root.Metazoa.Chordata.Chondrichthyes.Lamniformes.Lamnidae.Lamna;

/// <summary>
/// Interface defining characteristics of Lamna (genus).
/// </summary>
public interface ILamna
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
